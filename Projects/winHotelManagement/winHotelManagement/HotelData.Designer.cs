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

namespace winHotelManagement
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HotelData")]
	public partial class HotelDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertSuite(Suite instance);
    partial void UpdateSuite(Suite instance);
    partial void DeleteSuite(Suite instance);
    partial void InsertBooking(Booking instance);
    partial void UpdateBooking(Booking instance);
    partial void DeleteBooking(Booking instance);
    #endregion
		
		public HotelDataDataContext() : 
				base(global::winHotelManagement.Properties.Settings.Default.HotelDataConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HotelDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HotelDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Suite> Suites
		{
			get
			{
				return this.GetTable<Suite>();
			}
		}
		
		public System.Data.Linq.Table<Booking> Bookings
		{
			get
			{
				return this.GetTable<Booking>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Username;
		
		private string _Hash;
		
		private string _Role;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnHashChanging(string value);
    partial void OnHashChanged();
    partial void OnRoleChanging(string value);
    partial void OnRoleChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hash", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Hash
		{
			get
			{
				return this._Hash;
			}
			set
			{
				if ((this._Hash != value))
				{
					this.OnHashChanging(value);
					this.SendPropertyChanging();
					this._Hash = value;
					this.SendPropertyChanged("Hash");
					this.OnHashChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Role", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Role
		{
			get
			{
				return this._Role;
			}
			set
			{
				if ((this._Role != value))
				{
					this.OnRoleChanging(value);
					this.SendPropertyChanging();
					this._Role = value;
					this.SendPropertyChanged("Role");
					this.OnRoleChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Suites")]
	public partial class Suite : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SuiteNumber;
		
		private string _SuiteType;
		
		private double _Rate;
		
		private int _SuiteSize;
		
		private int _Beds;
		
		private int _NumberOfAdultsAllowed;
		
		private int _NumberOfChildrenAllowed;
		
		private bool _Breakfast;
		
		private bool _AC;
		
		private bool _TV;
		
		private bool _Balcony;
		
		private bool _Minibar;
		
		private bool _Sauna;
		
		private bool _Jacuzzi;
		
		private bool _RoomService;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSuiteNumberChanging(int value);
    partial void OnSuiteNumberChanged();
    partial void OnSuiteTypeChanging(string value);
    partial void OnSuiteTypeChanged();
    partial void OnRateChanging(double value);
    partial void OnRateChanged();
    partial void OnSuiteSizeChanging(int value);
    partial void OnSuiteSizeChanged();
    partial void OnBedsChanging(int value);
    partial void OnBedsChanged();
    partial void OnNumberOfAdultsAllowedChanging(int value);
    partial void OnNumberOfAdultsAllowedChanged();
    partial void OnNumberOfChildrenAllowedChanging(int value);
    partial void OnNumberOfChildrenAllowedChanged();
    partial void OnBreakfastChanging(bool value);
    partial void OnBreakfastChanged();
    partial void OnACChanging(bool value);
    partial void OnACChanged();
    partial void OnTVChanging(bool value);
    partial void OnTVChanged();
    partial void OnBalconyChanging(bool value);
    partial void OnBalconyChanged();
    partial void OnMinibarChanging(bool value);
    partial void OnMinibarChanged();
    partial void OnSaunaChanging(bool value);
    partial void OnSaunaChanged();
    partial void OnJacuzziChanging(bool value);
    partial void OnJacuzziChanged();
    partial void OnRoomServiceChanging(bool value);
    partial void OnRoomServiceChanged();
    #endregion
		
		public Suite()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuiteNumber", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SuiteNumber
		{
			get
			{
				return this._SuiteNumber;
			}
			set
			{
				if ((this._SuiteNumber != value))
				{
					this.OnSuiteNumberChanging(value);
					this.SendPropertyChanging();
					this._SuiteNumber = value;
					this.SendPropertyChanged("SuiteNumber");
					this.OnSuiteNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuiteType", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string SuiteType
		{
			get
			{
				return this._SuiteType;
			}
			set
			{
				if ((this._SuiteType != value))
				{
					this.OnSuiteTypeChanging(value);
					this.SendPropertyChanging();
					this._SuiteType = value;
					this.SendPropertyChanged("SuiteType");
					this.OnSuiteTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rate", DbType="Float NOT NULL")]
		public double Rate
		{
			get
			{
				return this._Rate;
			}
			set
			{
				if ((this._Rate != value))
				{
					this.OnRateChanging(value);
					this.SendPropertyChanging();
					this._Rate = value;
					this.SendPropertyChanged("Rate");
					this.OnRateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuiteSize", DbType="Int NOT NULL")]
		public int SuiteSize
		{
			get
			{
				return this._SuiteSize;
			}
			set
			{
				if ((this._SuiteSize != value))
				{
					this.OnSuiteSizeChanging(value);
					this.SendPropertyChanging();
					this._SuiteSize = value;
					this.SendPropertyChanged("SuiteSize");
					this.OnSuiteSizeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Beds", DbType="Int NOT NULL")]
		public int Beds
		{
			get
			{
				return this._Beds;
			}
			set
			{
				if ((this._Beds != value))
				{
					this.OnBedsChanging(value);
					this.SendPropertyChanging();
					this._Beds = value;
					this.SendPropertyChanged("Beds");
					this.OnBedsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfAdultsAllowed", DbType="Int NOT NULL")]
		public int NumberOfAdultsAllowed
		{
			get
			{
				return this._NumberOfAdultsAllowed;
			}
			set
			{
				if ((this._NumberOfAdultsAllowed != value))
				{
					this.OnNumberOfAdultsAllowedChanging(value);
					this.SendPropertyChanging();
					this._NumberOfAdultsAllowed = value;
					this.SendPropertyChanged("NumberOfAdultsAllowed");
					this.OnNumberOfAdultsAllowedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfChildrenAllowed", DbType="Int NOT NULL")]
		public int NumberOfChildrenAllowed
		{
			get
			{
				return this._NumberOfChildrenAllowed;
			}
			set
			{
				if ((this._NumberOfChildrenAllowed != value))
				{
					this.OnNumberOfChildrenAllowedChanging(value);
					this.SendPropertyChanging();
					this._NumberOfChildrenAllowed = value;
					this.SendPropertyChanged("NumberOfChildrenAllowed");
					this.OnNumberOfChildrenAllowedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Breakfast", DbType="Bit NOT NULL")]
		public bool Breakfast
		{
			get
			{
				return this._Breakfast;
			}
			set
			{
				if ((this._Breakfast != value))
				{
					this.OnBreakfastChanging(value);
					this.SendPropertyChanging();
					this._Breakfast = value;
					this.SendPropertyChanged("Breakfast");
					this.OnBreakfastChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AC", DbType="Bit NOT NULL")]
		public bool AC
		{
			get
			{
				return this._AC;
			}
			set
			{
				if ((this._AC != value))
				{
					this.OnACChanging(value);
					this.SendPropertyChanging();
					this._AC = value;
					this.SendPropertyChanged("AC");
					this.OnACChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TV", DbType="Bit NOT NULL")]
		public bool TV
		{
			get
			{
				return this._TV;
			}
			set
			{
				if ((this._TV != value))
				{
					this.OnTVChanging(value);
					this.SendPropertyChanging();
					this._TV = value;
					this.SendPropertyChanged("TV");
					this.OnTVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balcony", DbType="Bit NOT NULL")]
		public bool Balcony
		{
			get
			{
				return this._Balcony;
			}
			set
			{
				if ((this._Balcony != value))
				{
					this.OnBalconyChanging(value);
					this.SendPropertyChanging();
					this._Balcony = value;
					this.SendPropertyChanged("Balcony");
					this.OnBalconyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Minibar", DbType="Bit NOT NULL")]
		public bool Minibar
		{
			get
			{
				return this._Minibar;
			}
			set
			{
				if ((this._Minibar != value))
				{
					this.OnMinibarChanging(value);
					this.SendPropertyChanging();
					this._Minibar = value;
					this.SendPropertyChanged("Minibar");
					this.OnMinibarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sauna", DbType="Bit NOT NULL")]
		public bool Sauna
		{
			get
			{
				return this._Sauna;
			}
			set
			{
				if ((this._Sauna != value))
				{
					this.OnSaunaChanging(value);
					this.SendPropertyChanging();
					this._Sauna = value;
					this.SendPropertyChanged("Sauna");
					this.OnSaunaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Jacuzzi", DbType="Bit NOT NULL")]
		public bool Jacuzzi
		{
			get
			{
				return this._Jacuzzi;
			}
			set
			{
				if ((this._Jacuzzi != value))
				{
					this.OnJacuzziChanging(value);
					this.SendPropertyChanging();
					this._Jacuzzi = value;
					this.SendPropertyChanged("Jacuzzi");
					this.OnJacuzziChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomService", DbType="Bit NOT NULL")]
		public bool RoomService
		{
			get
			{
				return this._RoomService;
			}
			set
			{
				if ((this._RoomService != value))
				{
					this.OnRoomServiceChanging(value);
					this.SendPropertyChanging();
					this._RoomService = value;
					this.SendPropertyChanged("RoomService");
					this.OnRoomServiceChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bookings")]
	public partial class Booking : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _SuiteNumber;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _EndDate;
		
		private string _Name;
		
		private string _Telephone;
		
		private string _Email;
		
		private string _Adress;
		
		private string _City;
		
		private string _State;
		
		private string _ZipCode;
		
		private bool _Breakfast;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSuiteNumberChanging(int value);
    partial void OnSuiteNumberChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.DateTime value);
    partial void OnEndDateChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTelephoneChanging(string value);
    partial void OnTelephoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnAdressChanging(string value);
    partial void OnAdressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipCodeChanging(string value);
    partial void OnZipCodeChanged();
    partial void OnBreakfastChanging(bool value);
    partial void OnBreakfastChanged();
    #endregion
		
		public Booking()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuiteNumber", DbType="Int NOT NULL")]
		public int SuiteNumber
		{
			get
			{
				return this._SuiteNumber;
			}
			set
			{
				if ((this._SuiteNumber != value))
				{
					this.OnSuiteNumberChanging(value);
					this.SendPropertyChanging();
					this._SuiteNumber = value;
					this.SendPropertyChanged("SuiteNumber");
					this.OnSuiteNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime2 NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime2 NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telephone", DbType="NVarChar(MAX)")]
		public string Telephone
		{
			get
			{
				return this._Telephone;
			}
			set
			{
				if ((this._Telephone != value))
				{
					this.OnTelephoneChanging(value);
					this.SendPropertyChanging();
					this._Telephone = value;
					this.SendPropertyChanged("Telephone");
					this.OnTelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(MAX)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adress", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Adress
		{
			get
			{
				return this._Adress;
			}
			set
			{
				if ((this._Adress != value))
				{
					this.OnAdressChanging(value);
					this.SendPropertyChanging();
					this._Adress = value;
					this.SendPropertyChanged("Adress");
					this.OnAdressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Breakfast", DbType="Bit NOT NULL")]
		public bool Breakfast
		{
			get
			{
				return this._Breakfast;
			}
			set
			{
				if ((this._Breakfast != value))
				{
					this.OnBreakfastChanging(value);
					this.SendPropertyChanging();
					this._Breakfast = value;
					this.SendPropertyChanged("Breakfast");
					this.OnBreakfastChanged();
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
}
#pragma warning restore 1591
