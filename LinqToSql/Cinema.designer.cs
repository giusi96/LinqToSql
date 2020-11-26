﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToSql
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CinemaDb")]
	public partial class CinemaDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertActor(Actor instance);
    partial void UpdateActor(Actor instance);
    partial void DeleteActor(Actor instance);
    partial void InsertCast(Cast instance);
    partial void UpdateCast(Cast instance);
    partial void DeleteCast(Cast instance);
    partial void InsertMovy(Movy instance);
    partial void UpdateMovy(Movy instance);
    partial void DeleteMovy(Movy instance);
    partial void InsertPrenotazioni(Prenotazioni instance);
    partial void UpdatePrenotazioni(Prenotazioni instance);
    partial void DeletePrenotazioni(Prenotazioni instance);
    partial void InsertProgrammazione(Programmazione instance);
    partial void UpdateProgrammazione(Programmazione instance);
    partial void DeleteProgrammazione(Programmazione instance);
    partial void InsertSale(Sale instance);
    partial void UpdateSale(Sale instance);
    partial void DeleteSale(Sale instance);
    #endregion
		
		public CinemaDataContext() : 
				base(global::LinqToSql.Properties.Settings.Default.CinemaDbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CinemaDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CinemaDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CinemaDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CinemaDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Actor> Actors
		{
			get
			{
				return this.GetTable<Actor>();
			}
		}
		
		public System.Data.Linq.Table<Cast> Casts
		{
			get
			{
				return this.GetTable<Cast>();
			}
		}
		
		public System.Data.Linq.Table<Movy> Movies
		{
			get
			{
				return this.GetTable<Movy>();
			}
		}
		
		public System.Data.Linq.Table<Prenotazioni> Prenotazionis
		{
			get
			{
				return this.GetTable<Prenotazioni>();
			}
		}
		
		public System.Data.Linq.Table<Programmazione> Programmaziones
		{
			get
			{
				return this.GetTable<Programmazione>();
			}
		}
		
		public System.Data.Linq.Table<Sale> Sales
		{
			get
			{
				return this.GetTable<Sale>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Actors")]
	public partial class Actor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private System.DateTime _Birthdate;
		
		private decimal _Cachet;
		
		private EntitySet<Cast> _Casts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnBirthdateChanging(System.DateTime value);
    partial void OnBirthdateChanged();
    partial void OnCachetChanging(decimal value);
    partial void OnCachetChanged();
    #endregion
		
		public Actor()
		{
			this._Casts = new EntitySet<Cast>(new Action<Cast>(this.attach_Casts), new Action<Cast>(this.detach_Casts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthdate", DbType="Date NOT NULL")]
		public System.DateTime Birthdate
		{
			get
			{
				return this._Birthdate;
			}
			set
			{
				if ((this._Birthdate != value))
				{
					this.OnBirthdateChanging(value);
					this.SendPropertyChanging();
					this._Birthdate = value;
					this.SendPropertyChanged("Birthdate");
					this.OnBirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cachet", DbType="Money NOT NULL")]
		public decimal Cachet
		{
			get
			{
				return this._Cachet;
			}
			set
			{
				if ((this._Cachet != value))
				{
					this.OnCachetChanging(value);
					this.SendPropertyChanging();
					this._Cachet = value;
					this.SendPropertyChanged("Cachet");
					this.OnCachetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Actor_Cast", Storage="_Casts", ThisKey="ID", OtherKey="ActorId")]
		public EntitySet<Cast> Casts
		{
			get
			{
				return this._Casts;
			}
			set
			{
				this._Casts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Casts(Cast entity)
		{
			this.SendPropertyChanging();
			entity.Actor = this;
		}
		
		private void detach_Casts(Cast entity)
		{
			this.SendPropertyChanging();
			entity.Actor = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Casts")]
	public partial class Cast : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MovieId;
		
		private int _ActorId;
		
		private EntityRef<Actor> _Actor;
		
		private EntityRef<Movy> _Movy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMovieIdChanging(int value);
    partial void OnMovieIdChanged();
    partial void OnActorIdChanging(int value);
    partial void OnActorIdChanged();
    #endregion
		
		public Cast()
		{
			this._Actor = default(EntityRef<Actor>);
			this._Movy = default(EntityRef<Movy>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MovieId
		{
			get
			{
				return this._MovieId;
			}
			set
			{
				if ((this._MovieId != value))
				{
					if (this._Movy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovieIdChanging(value);
					this.SendPropertyChanging();
					this._MovieId = value;
					this.SendPropertyChanged("MovieId");
					this.OnMovieIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActorId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ActorId
		{
			get
			{
				return this._ActorId;
			}
			set
			{
				if ((this._ActorId != value))
				{
					if (this._Actor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnActorIdChanging(value);
					this.SendPropertyChanging();
					this._ActorId = value;
					this.SendPropertyChanged("ActorId");
					this.OnActorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Actor_Cast", Storage="_Actor", ThisKey="ActorId", OtherKey="ID", IsForeignKey=true)]
		public Actor Actor
		{
			get
			{
				return this._Actor.Entity;
			}
			set
			{
				Actor previousValue = this._Actor.Entity;
				if (((previousValue != value) 
							|| (this._Actor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Actor.Entity = null;
						previousValue.Casts.Remove(this);
					}
					this._Actor.Entity = value;
					if ((value != null))
					{
						value.Casts.Add(this);
						this._ActorId = value.ID;
					}
					else
					{
						this._ActorId = default(int);
					}
					this.SendPropertyChanged("Actor");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_Cast", Storage="_Movy", ThisKey="MovieId", OtherKey="ID", IsForeignKey=true)]
		public Movy Movy
		{
			get
			{
				return this._Movy.Entity;
			}
			set
			{
				Movy previousValue = this._Movy.Entity;
				if (((previousValue != value) 
							|| (this._Movy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movy.Entity = null;
						previousValue.Casts.Remove(this);
					}
					this._Movy.Entity = value;
					if ((value != null))
					{
						value.Casts.Add(this);
						this._MovieId = value.ID;
					}
					else
					{
						this._MovieId = default(int);
					}
					this.SendPropertyChanged("Movy");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Movies")]
	public partial class Movy : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Titolo;
		
		private string _Genere;
		
		private int _Durata;
		
		private EntitySet<Cast> _Casts;
		
		private EntitySet<Programmazione> _Programmaziones;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTitoloChanging(string value);
    partial void OnTitoloChanged();
    partial void OnGenereChanging(string value);
    partial void OnGenereChanged();
    partial void OnDurataChanging(int value);
    partial void OnDurataChanged();
    #endregion
		
		public Movy()
		{
			this._Casts = new EntitySet<Cast>(new Action<Cast>(this.attach_Casts), new Action<Cast>(this.detach_Casts));
			this._Programmaziones = new EntitySet<Programmazione>(new Action<Programmazione>(this.attach_Programmaziones), new Action<Programmazione>(this.detach_Programmaziones));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Titolo", DbType="NVarChar(255)")]
		public string Titolo
		{
			get
			{
				return this._Titolo;
			}
			set
			{
				if ((this._Titolo != value))
				{
					this.OnTitoloChanging(value);
					this.SendPropertyChanging();
					this._Titolo = value;
					this.SendPropertyChanged("Titolo");
					this.OnTitoloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Genere", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Genere
		{
			get
			{
				return this._Genere;
			}
			set
			{
				if ((this._Genere != value))
				{
					this.OnGenereChanging(value);
					this.SendPropertyChanging();
					this._Genere = value;
					this.SendPropertyChanged("Genere");
					this.OnGenereChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Durata", DbType="Int NOT NULL")]
		public int Durata
		{
			get
			{
				return this._Durata;
			}
			set
			{
				if ((this._Durata != value))
				{
					this.OnDurataChanging(value);
					this.SendPropertyChanging();
					this._Durata = value;
					this.SendPropertyChanged("Durata");
					this.OnDurataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_Cast", Storage="_Casts", ThisKey="ID", OtherKey="MovieId")]
		public EntitySet<Cast> Casts
		{
			get
			{
				return this._Casts;
			}
			set
			{
				this._Casts.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_Programmazione", Storage="_Programmaziones", ThisKey="ID", OtherKey="MovieID")]
		public EntitySet<Programmazione> Programmaziones
		{
			get
			{
				return this._Programmaziones;
			}
			set
			{
				this._Programmaziones.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Casts(Cast entity)
		{
			this.SendPropertyChanging();
			entity.Movy = this;
		}
		
		private void detach_Casts(Cast entity)
		{
			this.SendPropertyChanging();
			entity.Movy = null;
		}
		
		private void attach_Programmaziones(Programmazione entity)
		{
			this.SendPropertyChanging();
			entity.Movy = this;
		}
		
		private void detach_Programmaziones(Programmazione entity)
		{
			this.SendPropertyChanging();
			entity.Movy = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Prenotazioni")]
	public partial class Prenotazioni : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Mail;
		
		private int _N_posti;
		
		private int _ProgrammazioneID;
		
		private int _ID;
		
		private EntityRef<Programmazione> _Programmazione;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMailChanging(string value);
    partial void OnMailChanged();
    partial void OnN_postiChanging(int value);
    partial void OnN_postiChanged();
    partial void OnProgrammazioneIDChanging(int value);
    partial void OnProgrammazioneIDChanged();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    #endregion
		
		public Prenotazioni()
		{
			this._Programmazione = default(EntityRef<Programmazione>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mail", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Mail
		{
			get
			{
				return this._Mail;
			}
			set
			{
				if ((this._Mail != value))
				{
					this.OnMailChanging(value);
					this.SendPropertyChanging();
					this._Mail = value;
					this.SendPropertyChanged("Mail");
					this.OnMailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_N_posti", DbType="Int NOT NULL")]
		public int N_posti
		{
			get
			{
				return this._N_posti;
			}
			set
			{
				if ((this._N_posti != value))
				{
					this.OnN_postiChanging(value);
					this.SendPropertyChanging();
					this._N_posti = value;
					this.SendPropertyChanged("N_posti");
					this.OnN_postiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProgrammazioneID", DbType="Int NOT NULL")]
		public int ProgrammazioneID
		{
			get
			{
				return this._ProgrammazioneID;
			}
			set
			{
				if ((this._ProgrammazioneID != value))
				{
					if (this._Programmazione.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProgrammazioneIDChanging(value);
					this.SendPropertyChanging();
					this._ProgrammazioneID = value;
					this.SendPropertyChanged("ProgrammazioneID");
					this.OnProgrammazioneIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Programmazione_Prenotazioni", Storage="_Programmazione", ThisKey="ProgrammazioneID", OtherKey="ID", IsForeignKey=true)]
		public Programmazione Programmazione
		{
			get
			{
				return this._Programmazione.Entity;
			}
			set
			{
				Programmazione previousValue = this._Programmazione.Entity;
				if (((previousValue != value) 
							|| (this._Programmazione.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Programmazione.Entity = null;
						previousValue.Prenotazionis.Remove(this);
					}
					this._Programmazione.Entity = value;
					if ((value != null))
					{
						value.Prenotazionis.Add(this);
						this._ProgrammazioneID = value.ID;
					}
					else
					{
						this._ProgrammazioneID = default(int);
					}
					this.SendPropertyChanged("Programmazione");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Programmazione")]
	public partial class Programmazione : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _MovieID;
		
		private System.Nullable<int> _SalaID;
		
		private System.Nullable<System.TimeSpan> _Orario;
		
		private System.Nullable<decimal> _Prezzo;
		
		private System.Nullable<int> _Posti_Disponibili;
		
		private EntitySet<Prenotazioni> _Prenotazionis;
		
		private EntityRef<Movy> _Movy;
		
		private EntityRef<Sale> _Sale;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnMovieIDChanging(int value);
    partial void OnMovieIDChanged();
    partial void OnSalaIDChanging(System.Nullable<int> value);
    partial void OnSalaIDChanged();
    partial void OnOrarioChanging(System.Nullable<System.TimeSpan> value);
    partial void OnOrarioChanged();
    partial void OnPrezzoChanging(System.Nullable<decimal> value);
    partial void OnPrezzoChanged();
    partial void OnPosti_DisponibiliChanging(System.Nullable<int> value);
    partial void OnPosti_DisponibiliChanged();
    #endregion
		
		public Programmazione()
		{
			this._Prenotazionis = new EntitySet<Prenotazioni>(new Action<Prenotazioni>(this.attach_Prenotazionis), new Action<Prenotazioni>(this.detach_Prenotazionis));
			this._Movy = default(EntityRef<Movy>);
			this._Sale = default(EntityRef<Sale>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieID", DbType="Int NOT NULL")]
		public int MovieID
		{
			get
			{
				return this._MovieID;
			}
			set
			{
				if ((this._MovieID != value))
				{
					if (this._Movy.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._MovieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SalaID", DbType="Int")]
		public System.Nullable<int> SalaID
		{
			get
			{
				return this._SalaID;
			}
			set
			{
				if ((this._SalaID != value))
				{
					if (this._Sale.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSalaIDChanging(value);
					this.SendPropertyChanging();
					this._SalaID = value;
					this.SendPropertyChanged("SalaID");
					this.OnSalaIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Orario", DbType="Time")]
		public System.Nullable<System.TimeSpan> Orario
		{
			get
			{
				return this._Orario;
			}
			set
			{
				if ((this._Orario != value))
				{
					this.OnOrarioChanging(value);
					this.SendPropertyChanging();
					this._Orario = value;
					this.SendPropertyChanged("Orario");
					this.OnOrarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Prezzo", DbType="Money")]
		public System.Nullable<decimal> Prezzo
		{
			get
			{
				return this._Prezzo;
			}
			set
			{
				if ((this._Prezzo != value))
				{
					this.OnPrezzoChanging(value);
					this.SendPropertyChanging();
					this._Prezzo = value;
					this.SendPropertyChanged("Prezzo");
					this.OnPrezzoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Posti_Disponibili", DbType="Int")]
		public System.Nullable<int> Posti_Disponibili
		{
			get
			{
				return this._Posti_Disponibili;
			}
			set
			{
				if ((this._Posti_Disponibili != value))
				{
					this.OnPosti_DisponibiliChanging(value);
					this.SendPropertyChanging();
					this._Posti_Disponibili = value;
					this.SendPropertyChanged("Posti_Disponibili");
					this.OnPosti_DisponibiliChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Programmazione_Prenotazioni", Storage="_Prenotazionis", ThisKey="ID", OtherKey="ProgrammazioneID")]
		public EntitySet<Prenotazioni> Prenotazionis
		{
			get
			{
				return this._Prenotazionis;
			}
			set
			{
				this._Prenotazionis.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Movy_Programmazione", Storage="_Movy", ThisKey="MovieID", OtherKey="ID", IsForeignKey=true)]
		public Movy Movy
		{
			get
			{
				return this._Movy.Entity;
			}
			set
			{
				Movy previousValue = this._Movy.Entity;
				if (((previousValue != value) 
							|| (this._Movy.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Movy.Entity = null;
						previousValue.Programmaziones.Remove(this);
					}
					this._Movy.Entity = value;
					if ((value != null))
					{
						value.Programmaziones.Add(this);
						this._MovieID = value.ID;
					}
					else
					{
						this._MovieID = default(int);
					}
					this.SendPropertyChanged("Movy");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sale_Programmazione", Storage="_Sale", ThisKey="SalaID", OtherKey="ID", IsForeignKey=true)]
		public Sale Sale
		{
			get
			{
				return this._Sale.Entity;
			}
			set
			{
				Sale previousValue = this._Sale.Entity;
				if (((previousValue != value) 
							|| (this._Sale.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sale.Entity = null;
						previousValue.Programmaziones.Remove(this);
					}
					this._Sale.Entity = value;
					if ((value != null))
					{
						value.Programmaziones.Add(this);
						this._SalaID = value.ID;
					}
					else
					{
						this._SalaID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Sale");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Prenotazionis(Prenotazioni entity)
		{
			this.SendPropertyChanging();
			entity.Programmazione = this;
		}
		
		private void detach_Prenotazionis(Prenotazioni entity)
		{
			this.SendPropertyChanging();
			entity.Programmazione = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sale")]
	public partial class Sale : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Nome;
		
		private System.Nullable<int> _Posti;
		
		private EntitySet<Programmazione> _Programmaziones;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNomeChanging(string value);
    partial void OnNomeChanged();
    partial void OnPostiChanging(System.Nullable<int> value);
    partial void OnPostiChanged();
    #endregion
		
		public Sale()
		{
			this._Programmaziones = new EntitySet<Programmazione>(new Action<Programmazione>(this.attach_Programmaziones), new Action<Programmazione>(this.detach_Programmaziones));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="NVarChar(255)")]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this.OnNomeChanging(value);
					this.SendPropertyChanging();
					this._Nome = value;
					this.SendPropertyChanged("Nome");
					this.OnNomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Posti", DbType="Int")]
		public System.Nullable<int> Posti
		{
			get
			{
				return this._Posti;
			}
			set
			{
				if ((this._Posti != value))
				{
					this.OnPostiChanging(value);
					this.SendPropertyChanging();
					this._Posti = value;
					this.SendPropertyChanged("Posti");
					this.OnPostiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sale_Programmazione", Storage="_Programmaziones", ThisKey="ID", OtherKey="SalaID")]
		public EntitySet<Programmazione> Programmaziones
		{
			get
			{
				return this._Programmaziones;
			}
			set
			{
				this._Programmaziones.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Programmaziones(Programmazione entity)
		{
			this.SendPropertyChanging();
			entity.Sale = this;
		}
		
		private void detach_Programmaziones(Programmazione entity)
		{
			this.SendPropertyChanging();
			entity.Sale = null;
		}
	}
}
#pragma warning restore 1591
