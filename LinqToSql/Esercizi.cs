using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSql
{
    public class Esercizi
    {
        const string connectionString = @"Persist Security Info = False; Integrated Security =true; Initial Catalog=CinemaDb; Server = WINAPPM2JMGI3WG\SQLEXPRESS; ";

        //Selezionare i film
        public static void SelectMovies()
        {
            CinemaDataContext db = new CinemaDataContext(connectionString); //classe che mi dà in automatico dopo la scaffolding

            foreach (var movie in db.Movies)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", movie.ID, movie.Titolo, movie.Genere, movie.Durata);
            }
        }

        //Filtrare film
        public static void FilterMovieByGenere()
        {
            CinemaDataContext db = new CinemaDataContext(connectionString);
            foreach (var movie in db.Movies)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", movie.ID, movie.Titolo, movie.Genere, movie.Durata);
            }

            //Query
            Console.WriteLine("Genere: ");
            string Genere;
            Genere = Console.ReadLine();

            IQueryable<Movy> moviesFiltered =
                from m in db.Movies
                where m.Genere == Genere
                select m;

            foreach (var m in moviesFiltered)
            {
                Console.WriteLine("{0} - {1} - {2}", m.ID, m.Titolo,m.Durata);
            }
            Console.ReadKey();
        }

        //inserimento record
        public static void InsertMovie()
        {
            CinemaDataContext db= new CinemaDataContext(connectionString);

            SelectMovies();
            var movieToInsert = new Movy();
            movieToInsert.Titolo = "LaLaLand";
            movieToInsert.Genere = "Romantico";
            movieToInsert.Durata = 120;

            db.Movies.InsertOnSubmit(movieToInsert); //fin qui lavoro in locale

            ////delete
            //var deleteMovie = db.Movies.SingleOrDefault(m => m.ID == 2);
            //if (deleteMovie!= null)
            //{
            //    db.Movies.DeleteOnSubmit(deleteMovie);
            //}

            try
            {
                db.SubmitChanges(); //qui mando le modifiche al database
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            SelectMovies();
            Console.ReadKey();
        }

        //Update Movie
        public static void UpdateMovieByTitolo()
        {
            CinemaDataContext db = new CinemaDataContext(connectionString);

            Console.WriteLine("Dimmi il titolo del film da aggiornare: ");
            string titolo;
            titolo = Console.ReadLine();

            //Query
            IQueryable<Movy> filmByTitolo =
                from film in db.Movies
                where film.Titolo == titolo
                select film;

            Console.WriteLine("I film trovati sono: {0}", filmByTitolo.Count());

            if (filmByTitolo.Count()==0)
            {
                return;
            }
            if (filmByTitolo.Count() > 1)
            {
                return;
            }

            SelectMovies();

            Console.WriteLine("Scrivere i valori aggiornati:");
            Console.WriteLine("Titolo: ");
            string title = Console.ReadLine();
            Console.WriteLine("Genere: ");
            string genere = Console.ReadLine();
            Console.WriteLine("Durata: ");
            int durata = Convert.ToInt32(Console.ReadLine());

            foreach (var f in filmByTitolo)
            {
                f.Titolo = title;
                f.Genere = genere;
                f.Durata = durata;
            }

            //Gestione concorrenza
            try
            {
                Console.WriteLine("Premi un tasto per mandare modifiche al db");
                Console.ReadKey();
                db.SubmitChanges(ConflictMode.FailOnFirstConflict); //gestione di come mandare le eccezioni
            }
            catch (ChangeConflictException e)
            {
                Console.WriteLine("Concurrency error: ");
                Console.WriteLine(e);
                Console.ReadKey();

                //OverwriteCurrentValues->ignora le mie modifiche(aggiorna il mio obj model)
                //KeepCurrentValues->ignora le modifiche altrui(sovrascrive il db con il mio obj model)
                //KeepChanges->cerca di tenere entrambe le modifiche 
                db.ChangeConflicts.ResolveAll(RefreshMode.OverwriteCurrentValues);

                db.SubmitChanges(); //da fare sempre
            }
        }
    }
}
