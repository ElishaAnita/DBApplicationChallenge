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

namespace DBApplicationChallenge
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbapplicationchallenge")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMaterialMaster(MaterialMaster instance);
    partial void UpdateMaterialMaster(MaterialMaster instance);
    partial void DeleteMaterialMaster(MaterialMaster instance);
    partial void InsertProjectRecord(ProjectRecord instance);
    partial void UpdateProjectRecord(ProjectRecord instance);
    partial void DeleteProjectRecord(ProjectRecord instance);
    partial void InsertPurchaseRecord(PurchaseRecord instance);
    partial void UpdatePurchaseRecord(PurchaseRecord instance);
    partial void DeletePurchaseRecord(PurchaseRecord instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::DBApplicationChallenge.Properties.Settings.Default.dbapplicationchallengeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MaterialMaster> MaterialMasters
		{
			get
			{
				return this.GetTable<MaterialMaster>();
			}
		}
		
		public System.Data.Linq.Table<ProjectRecord> ProjectRecords
		{
			get
			{
				return this.GetTable<ProjectRecord>();
			}
		}
		
		public System.Data.Linq.Table<PurchaseRecord> PurchaseRecords
		{
			get
			{
				return this.GetTable<PurchaseRecord>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MaterialMaster")]
	public partial class MaterialMaster : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _uid;
		
		private string _PartNumber;
		
		private string _Description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuidChanging(int value);
    partial void OnuidChanged();
    partial void OnPartNumberChanging(string value);
    partial void OnPartNumberChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    #endregion
		
		public MaterialMaster()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this.OnuidChanging(value);
					this.SendPropertyChanging();
					this._uid = value;
					this.SendPropertyChanged("uid");
					this.OnuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PartNumber", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string PartNumber
		{
			get
			{
				return this._PartNumber;
			}
			set
			{
				if ((this._PartNumber != value))
				{
					this.OnPartNumberChanging(value);
					this.SendPropertyChanging();
					this._PartNumber = value;
					this.SendPropertyChanged("PartNumber");
					this.OnPartNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(300) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProjectRecord")]
	public partial class ProjectRecord : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _uid;
		
		private string _projectNumber;
		
		private string _projectDescription;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuidChanging(int value);
    partial void OnuidChanged();
    partial void OnprojectNumberChanging(string value);
    partial void OnprojectNumberChanged();
    partial void OnprojectDescriptionChanging(string value);
    partial void OnprojectDescriptionChanged();
    #endregion
		
		public ProjectRecord()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this.OnuidChanging(value);
					this.SendPropertyChanging();
					this._uid = value;
					this.SendPropertyChanged("uid");
					this.OnuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_projectNumber", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string projectNumber
		{
			get
			{
				return this._projectNumber;
			}
			set
			{
				if ((this._projectNumber != value))
				{
					this.OnprojectNumberChanging(value);
					this.SendPropertyChanging();
					this._projectNumber = value;
					this.SendPropertyChanged("projectNumber");
					this.OnprojectNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_projectDescription", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string projectDescription
		{
			get
			{
				return this._projectDescription;
			}
			set
			{
				if ((this._projectDescription != value))
				{
					this.OnprojectDescriptionChanging(value);
					this.SendPropertyChanging();
					this._projectDescription = value;
					this.SendPropertyChanged("projectDescription");
					this.OnprojectDescriptionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PurchaseRecord")]
	public partial class PurchaseRecord : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _uid;
		
		private string _PONumber;
		
		private string _partNumber;
		
		private double _quantity;
		
		private double _costPer;
		
		private string _purchaser;
		
		private string _projet;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuidChanging(int value);
    partial void OnuidChanged();
    partial void OnPONumberChanging(string value);
    partial void OnPONumberChanged();
    partial void OnpartNumberChanging(string value);
    partial void OnpartNumberChanged();
    partial void OnquantityChanging(double value);
    partial void OnquantityChanged();
    partial void OncostPerChanging(double value);
    partial void OncostPerChanged();
    partial void OnpurchaserChanging(string value);
    partial void OnpurchaserChanged();
    partial void OnprojetChanging(string value);
    partial void OnprojetChanged();
    #endregion
		
		public PurchaseRecord()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this.OnuidChanging(value);
					this.SendPropertyChanging();
					this._uid = value;
					this.SendPropertyChanged("uid");
					this.OnuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PONumber", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string PONumber
		{
			get
			{
				return this._PONumber;
			}
			set
			{
				if ((this._PONumber != value))
				{
					this.OnPONumberChanging(value);
					this.SendPropertyChanging();
					this._PONumber = value;
					this.SendPropertyChanged("PONumber");
					this.OnPONumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_partNumber", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string partNumber
		{
			get
			{
				return this._partNumber;
			}
			set
			{
				if ((this._partNumber != value))
				{
					this.OnpartNumberChanging(value);
					this.SendPropertyChanging();
					this._partNumber = value;
					this.SendPropertyChanged("partNumber");
					this.OnpartNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_quantity", DbType="Float NOT NULL")]
		public double quantity
		{
			get
			{
				return this._quantity;
			}
			set
			{
				if ((this._quantity != value))
				{
					this.OnquantityChanging(value);
					this.SendPropertyChanging();
					this._quantity = value;
					this.SendPropertyChanged("quantity");
					this.OnquantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_costPer", DbType="Float NOT NULL")]
		public double costPer
		{
			get
			{
				return this._costPer;
			}
			set
			{
				if ((this._costPer != value))
				{
					this.OncostPerChanging(value);
					this.SendPropertyChanging();
					this._costPer = value;
					this.SendPropertyChanged("costPer");
					this.OncostPerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_purchaser", DbType="NVarChar(16) NOT NULL", CanBeNull=false)]
		public string purchaser
		{
			get
			{
				return this._purchaser;
			}
			set
			{
				if ((this._purchaser != value))
				{
					this.OnpurchaserChanging(value);
					this.SendPropertyChanging();
					this._purchaser = value;
					this.SendPropertyChanged("purchaser");
					this.OnpurchaserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_projet", DbType="NVarChar(11) NOT NULL", CanBeNull=false)]
		public string projet
		{
			get
			{
				return this._projet;
			}
			set
			{
				if ((this._projet != value))
				{
					this.OnprojetChanging(value);
					this.SendPropertyChanging();
					this._projet = value;
					this.SendPropertyChanged("projet");
					this.OnprojetChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _uid;
		
		private string _userName;
		
		private string _fullName;
		
		private string _email;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuidChanging(int value);
    partial void OnuidChanged();
    partial void OnuserNameChanging(string value);
    partial void OnuserNameChanged();
    partial void OnfullNameChanging(string value);
    partial void OnfullNameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    #endregion
		
		public User()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_uid", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				if ((this._uid != value))
				{
					this.OnuidChanging(value);
					this.SendPropertyChanging();
					this._uid = value;
					this.SendPropertyChanged("uid");
					this.OnuidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userName", DbType="NVarChar(8) NOT NULL", CanBeNull=false)]
		public string userName
		{
			get
			{
				return this._userName;
			}
			set
			{
				if ((this._userName != value))
				{
					this.OnuserNameChanging(value);
					this.SendPropertyChanging();
					this._userName = value;
					this.SendPropertyChanged("userName");
					this.OnuserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fullName", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string fullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if ((this._fullName != value))
				{
					this.OnfullNameChanging(value);
					this.SendPropertyChanging();
					this._fullName = value;
					this.SendPropertyChanged("fullName");
					this.OnfullNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="NVarChar(80) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
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