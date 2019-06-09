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

namespace LabASPNETWeb.DataRepository.Linq
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LabWebAppAspNet")]
	public partial class DBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertwpNew(wpNew instance);
    partial void UpdatewpNew(wpNew instance);
    partial void DeletewpNew(wpNew instance);
    partial void InsertwpUser(wpUser instance);
    partial void UpdatewpUser(wpUser instance);
    partial void DeletewpUser(wpUser instance);
    #endregion
		
		public DBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LabWebAppAspNetConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<wpNew> wpNews
		{
			get
			{
				return this.GetTable<wpNew>();
			}
		}
		
		public System.Data.Linq.Table<wpUser> wpUsers
		{
			get
			{
				return this.GetTable<wpUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.wpNews")]
	public partial class wpNew : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _title;
		
		private string _content;
		
		private string _tags;
		
		private string _usr_create;
		
		private System.Nullable<System.DateTime> _createdt;
		
		private System.Nullable<System.DateTime> _lastupdt;
		
		private System.Nullable<bool> _activeyn;
		
		private System.Nullable<bool> _homepageyn;
		
		private EntityRef<wpUser> _wpUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OncontentChanging(string value);
    partial void OncontentChanged();
    partial void OntagsChanging(string value);
    partial void OntagsChanged();
    partial void Onusr_createChanging(string value);
    partial void Onusr_createChanged();
    partial void OncreatedtChanging(System.Nullable<System.DateTime> value);
    partial void OncreatedtChanged();
    partial void OnlastupdtChanging(System.Nullable<System.DateTime> value);
    partial void OnlastupdtChanged();
    partial void OnactiveynChanging(System.Nullable<bool> value);
    partial void OnactiveynChanged();
    partial void OnhomepageynChanging(System.Nullable<bool> value);
    partial void OnhomepageynChanged();
    #endregion
		
		public wpNew()
		{
			this._wpUser = default(EntityRef<wpUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(200)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_content", DbType="NText", UpdateCheck=UpdateCheck.Never)]
		public string content
		{
			get
			{
				return this._content;
			}
			set
			{
				if ((this._content != value))
				{
					this.OncontentChanging(value);
					this.SendPropertyChanging();
					this._content = value;
					this.SendPropertyChanged("content");
					this.OncontentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tags", DbType="VarChar(255)")]
		public string tags
		{
			get
			{
				return this._tags;
			}
			set
			{
				if ((this._tags != value))
				{
					this.OntagsChanging(value);
					this.SendPropertyChanging();
					this._tags = value;
					this.SendPropertyChanged("tags");
					this.OntagsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usr_create", DbType="VarChar(100)")]
		public string usr_create
		{
			get
			{
				return this._usr_create;
			}
			set
			{
				if ((this._usr_create != value))
				{
					if (this._wpUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onusr_createChanging(value);
					this.SendPropertyChanging();
					this._usr_create = value;
					this.SendPropertyChanged("usr_create");
					this.Onusr_createChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_createdt", DbType="DateTime")]
		public System.Nullable<System.DateTime> createdt
		{
			get
			{
				return this._createdt;
			}
			set
			{
				if ((this._createdt != value))
				{
					this.OncreatedtChanging(value);
					this.SendPropertyChanging();
					this._createdt = value;
					this.SendPropertyChanged("createdt");
					this.OncreatedtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastupdt", DbType="DateTime")]
		public System.Nullable<System.DateTime> lastupdt
		{
			get
			{
				return this._lastupdt;
			}
			set
			{
				if ((this._lastupdt != value))
				{
					this.OnlastupdtChanging(value);
					this.SendPropertyChanging();
					this._lastupdt = value;
					this.SendPropertyChanged("lastupdt");
					this.OnlastupdtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activeyn", DbType="Bit")]
		public System.Nullable<bool> activeyn
		{
			get
			{
				return this._activeyn;
			}
			set
			{
				if ((this._activeyn != value))
				{
					this.OnactiveynChanging(value);
					this.SendPropertyChanging();
					this._activeyn = value;
					this.SendPropertyChanged("activeyn");
					this.OnactiveynChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_homepageyn", DbType="Bit")]
		public System.Nullable<bool> homepageyn
		{
			get
			{
				return this._homepageyn;
			}
			set
			{
				if ((this._homepageyn != value))
				{
					this.OnhomepageynChanging(value);
					this.SendPropertyChanging();
					this._homepageyn = value;
					this.SendPropertyChanged("homepageyn");
					this.OnhomepageynChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="wpUser_wpNew", Storage="_wpUser", ThisKey="usr_create", OtherKey="username", IsForeignKey=true)]
		public wpUser wpUser
		{
			get
			{
				return this._wpUser.Entity;
			}
			set
			{
				wpUser previousValue = this._wpUser.Entity;
				if (((previousValue != value) 
							|| (this._wpUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._wpUser.Entity = null;
						previousValue.wpNews.Remove(this);
					}
					this._wpUser.Entity = value;
					if ((value != null))
					{
						value.wpNews.Add(this);
						this._usr_create = value.username;
					}
					else
					{
						this._usr_create = default(string);
					}
					this.SendPropertyChanged("wpUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.wpUsers")]
	public partial class wpUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _username;
		
		private string _email;
		
		private string _name;
		
		private System.Nullable<System.DateTime> _createdt;
		
		private System.Nullable<System.DateTime> _lastupddt;
		
		private System.Nullable<bool> _activeyn;
		
		private System.Nullable<System.DateTime> _lastlogindt;
		
		private string _pwd;
		
		private EntitySet<wpNew> _wpNews;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OncreatedtChanging(System.Nullable<System.DateTime> value);
    partial void OncreatedtChanged();
    partial void OnlastupddtChanging(System.Nullable<System.DateTime> value);
    partial void OnlastupddtChanged();
    partial void OnactiveynChanging(System.Nullable<bool> value);
    partial void OnactiveynChanged();
    partial void OnlastlogindtChanging(System.Nullable<System.DateTime> value);
    partial void OnlastlogindtChanged();
    partial void OnpwdChanging(string value);
    partial void OnpwdChanged();
    #endregion
		
		public wpUser()
		{
			this._wpNews = new EntitySet<wpNew>(new Action<wpNew>(this.attach_wpNews), new Action<wpNew>(this.detach_wpNews));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(255)")]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_createdt", DbType="DateTime")]
		public System.Nullable<System.DateTime> createdt
		{
			get
			{
				return this._createdt;
			}
			set
			{
				if ((this._createdt != value))
				{
					this.OncreatedtChanging(value);
					this.SendPropertyChanging();
					this._createdt = value;
					this.SendPropertyChanged("createdt");
					this.OncreatedtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastupddt", DbType="DateTime")]
		public System.Nullable<System.DateTime> lastupddt
		{
			get
			{
				return this._lastupddt;
			}
			set
			{
				if ((this._lastupddt != value))
				{
					this.OnlastupddtChanging(value);
					this.SendPropertyChanging();
					this._lastupddt = value;
					this.SendPropertyChanged("lastupddt");
					this.OnlastupddtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_activeyn", DbType="Bit")]
		public System.Nullable<bool> activeyn
		{
			get
			{
				return this._activeyn;
			}
			set
			{
				if ((this._activeyn != value))
				{
					this.OnactiveynChanging(value);
					this.SendPropertyChanging();
					this._activeyn = value;
					this.SendPropertyChanged("activeyn");
					this.OnactiveynChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastlogindt", DbType="DateTime")]
		public System.Nullable<System.DateTime> lastlogindt
		{
			get
			{
				return this._lastlogindt;
			}
			set
			{
				if ((this._lastlogindt != value))
				{
					this.OnlastlogindtChanging(value);
					this.SendPropertyChanging();
					this._lastlogindt = value;
					this.SendPropertyChanged("lastlogindt");
					this.OnlastlogindtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pwd", DbType="VarChar(255)")]
		public string pwd
		{
			get
			{
				return this._pwd;
			}
			set
			{
				if ((this._pwd != value))
				{
					this.OnpwdChanging(value);
					this.SendPropertyChanging();
					this._pwd = value;
					this.SendPropertyChanged("pwd");
					this.OnpwdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="wpUser_wpNew", Storage="_wpNews", ThisKey="username", OtherKey="usr_create")]
		public EntitySet<wpNew> wpNews
		{
			get
			{
				return this._wpNews;
			}
			set
			{
				this._wpNews.Assign(value);
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
		
		private void attach_wpNews(wpNew entity)
		{
			this.SendPropertyChanging();
			entity.wpUser = this;
		}
		
		private void detach_wpNews(wpNew entity)
		{
			this.SendPropertyChanging();
			entity.wpUser = null;
		}
	}
}
#pragma warning restore 1591