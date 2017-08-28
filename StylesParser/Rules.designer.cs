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

namespace StylesParser
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="rules")]
	public partial class RulesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertcssRule(cssRule instance);
    partial void UpdatecssRule(cssRule instance);
    partial void DeletecssRule(cssRule instance);
    partial void InsertcssRulesView(cssRulesView instance);
    partial void UpdatecssRulesView(cssRulesView instance);
    partial void DeletecssRulesView(cssRulesView instance);
    partial void InsertselectorsRanksView(selectorsRanksView instance);
    partial void UpdateselectorsRanksView(selectorsRanksView instance);
    partial void DeleteselectorsRanksView(selectorsRanksView instance);
    partial void InsertselectorsView(selectorsView instance);
    partial void UpdateselectorsView(selectorsView instance);
    partial void DeleteselectorsView(selectorsView instance);
    partial void InsertView_Selector(View_Selector instance);
    partial void UpdateView_Selector(View_Selector instance);
    partial void DeleteView_Selector(View_Selector instance);
    partial void Insertview(view instance);
    partial void Updateview(view instance);
    partial void Deleteview(view instance);
    #endregion
		
		public RulesDataContext() : 
				base(global::StylesParser.Properties.Settings.Default.rulesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RulesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RulesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RulesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RulesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<cssRule> cssRules
		{
			get
			{
				return this.GetTable<cssRule>();
			}
		}
		
		public System.Data.Linq.Table<cssRulesView> cssRulesViews
		{
			get
			{
				return this.GetTable<cssRulesView>();
			}
		}
		
		public System.Data.Linq.Table<selector> selectors
		{
			get
			{
				return this.GetTable<selector>();
			}
		}
		
		public System.Data.Linq.Table<selectorsRank> selectorsRanks
		{
			get
			{
				return this.GetTable<selectorsRank>();
			}
		}
		
		public System.Data.Linq.Table<selectorsRanksView> selectorsRanksViews
		{
			get
			{
				return this.GetTable<selectorsRanksView>();
			}
		}
		
		public System.Data.Linq.Table<selectorsView> selectorsViews
		{
			get
			{
				return this.GetTable<selectorsView>();
			}
		}
		
		public System.Data.Linq.Table<View_Selector> View_Selectors
		{
			get
			{
				return this.GetTable<View_Selector>();
			}
		}
		
		public System.Data.Linq.Table<view> views
		{
			get
			{
				return this.GetTable<view>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cssRules")]
	public partial class cssRule : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _FileName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    #endregion
		
		public cssRule()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(1000)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cssRulesViews")]
	public partial class cssRulesView : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private int _FileId;
		
		private EntitySet<selectorsRanksView> _selectorsRanksViews;
		
		private EntitySet<selectorsView> _selectorsViews;
		
		private EntityRef<view> _view;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFileIdChanging(int value);
    partial void OnFileIdChanged();
    #endregion
		
		public cssRulesView()
		{
			this._selectorsRanksViews = new EntitySet<selectorsRanksView>(new Action<selectorsRanksView>(this.attach_selectorsRanksViews), new Action<selectorsRanksView>(this.detach_selectorsRanksViews));
			this._selectorsViews = new EntitySet<selectorsView>(new Action<selectorsView>(this.attach_selectorsViews), new Action<selectorsView>(this.detach_selectorsViews));
			this._view = default(EntityRef<view>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(1000)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileId", DbType="Int NOT NULL")]
		public int FileId
		{
			get
			{
				return this._FileId;
			}
			set
			{
				if ((this._FileId != value))
				{
					if (this._view.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFileIdChanging(value);
					this.SendPropertyChanging();
					this._FileId = value;
					this.SendPropertyChanged("FileId");
					this.OnFileIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cssRulesView_selectorsRanksView", Storage="_selectorsRanksViews", ThisKey="Id", OtherKey="RuleId")]
		public EntitySet<selectorsRanksView> selectorsRanksViews
		{
			get
			{
				return this._selectorsRanksViews;
			}
			set
			{
				this._selectorsRanksViews.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cssRulesView_selectorsView", Storage="_selectorsViews", ThisKey="Id", OtherKey="RuleId")]
		public EntitySet<selectorsView> selectorsViews
		{
			get
			{
				return this._selectorsViews;
			}
			set
			{
				this._selectorsViews.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="view_cssRulesView", Storage="_view", ThisKey="FileId", OtherKey="Id", IsForeignKey=true)]
		public view view
		{
			get
			{
				return this._view.Entity;
			}
			set
			{
				view previousValue = this._view.Entity;
				if (((previousValue != value) 
							|| (this._view.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._view.Entity = null;
						previousValue.cssRulesViews.Remove(this);
					}
					this._view.Entity = value;
					if ((value != null))
					{
						value.cssRulesViews.Add(this);
						this._FileId = value.Id;
					}
					else
					{
						this._FileId = default(int);
					}
					this.SendPropertyChanged("view");
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
		
		private void attach_selectorsRanksViews(selectorsRanksView entity)
		{
			this.SendPropertyChanging();
			entity.cssRulesView = this;
		}
		
		private void detach_selectorsRanksViews(selectorsRanksView entity)
		{
			this.SendPropertyChanging();
			entity.cssRulesView = null;
		}
		
		private void attach_selectorsViews(selectorsView entity)
		{
			this.SendPropertyChanging();
			entity.cssRulesView = this;
		}
		
		private void detach_selectorsViews(selectorsView entity)
		{
			this.SendPropertyChanging();
			entity.cssRulesView = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.selectors")]
	public partial class selector
	{
		
		private int _Id;
		
		private int _RuleId;
		
		private string _Name;
		
		private string _FileName;
		
		private System.Nullable<int> _ParentSelectorId;
		
		public selector()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
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
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RuleId", DbType="Int NOT NULL")]
		public int RuleId
		{
			get
			{
				return this._RuleId;
			}
			set
			{
				if ((this._RuleId != value))
				{
					this._RuleId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX)")]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this._FileName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentSelectorId", DbType="Int")]
		public System.Nullable<int> ParentSelectorId
		{
			get
			{
				return this._ParentSelectorId;
			}
			set
			{
				if ((this._ParentSelectorId != value))
				{
					this._ParentSelectorId = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.selectorsRanks")]
	public partial class selectorsRank
	{
		
		private int _Id;
		
		private int _RuleId;
		
		private string _Name;
		
		private string _FileName;
		
		private System.Nullable<int> _ParentSelectorId;
		
		private int _Rank;
		
		public selectorsRank()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
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
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RuleId", DbType="Int NOT NULL")]
		public int RuleId
		{
			get
			{
				return this._RuleId;
			}
			set
			{
				if ((this._RuleId != value))
				{
					this._RuleId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX)")]
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
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this._FileName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentSelectorId", DbType="Int")]
		public System.Nullable<int> ParentSelectorId
		{
			get
			{
				return this._ParentSelectorId;
			}
			set
			{
				if ((this._ParentSelectorId != value))
				{
					this._ParentSelectorId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rank", DbType="Int NOT NULL")]
		public int Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				if ((this._Rank != value))
				{
					this._Rank = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.selectorsRanksViews")]
	public partial class selectorsRanksView : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _RuleId;
		
		private string _Name;
		
		private int _FileId;
		
		private System.Nullable<int> _ParentSelectorId;
		
		private int _Rank;
		
		private EntityRef<cssRulesView> _cssRulesView;
		
		private EntityRef<view> _view;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRuleIdChanging(int value);
    partial void OnRuleIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFileIdChanging(int value);
    partial void OnFileIdChanged();
    partial void OnParentSelectorIdChanging(System.Nullable<int> value);
    partial void OnParentSelectorIdChanged();
    partial void OnRankChanging(int value);
    partial void OnRankChanged();
    #endregion
		
		public selectorsRanksView()
		{
			this._cssRulesView = default(EntityRef<cssRulesView>);
			this._view = default(EntityRef<view>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RuleId", DbType="Int NOT NULL")]
		public int RuleId
		{
			get
			{
				return this._RuleId;
			}
			set
			{
				if ((this._RuleId != value))
				{
					if (this._cssRulesView.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRuleIdChanging(value);
					this.SendPropertyChanging();
					this._RuleId = value;
					this.SendPropertyChanged("RuleId");
					this.OnRuleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileId", DbType="Int NOT NULL")]
		public int FileId
		{
			get
			{
				return this._FileId;
			}
			set
			{
				if ((this._FileId != value))
				{
					if (this._view.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFileIdChanging(value);
					this.SendPropertyChanging();
					this._FileId = value;
					this.SendPropertyChanged("FileId");
					this.OnFileIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentSelectorId", DbType="Int")]
		public System.Nullable<int> ParentSelectorId
		{
			get
			{
				return this._ParentSelectorId;
			}
			set
			{
				if ((this._ParentSelectorId != value))
				{
					this.OnParentSelectorIdChanging(value);
					this.SendPropertyChanging();
					this._ParentSelectorId = value;
					this.SendPropertyChanged("ParentSelectorId");
					this.OnParentSelectorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rank", DbType="Int NOT NULL")]
		public int Rank
		{
			get
			{
				return this._Rank;
			}
			set
			{
				if ((this._Rank != value))
				{
					this.OnRankChanging(value);
					this.SendPropertyChanging();
					this._Rank = value;
					this.SendPropertyChanged("Rank");
					this.OnRankChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cssRulesView_selectorsRanksView", Storage="_cssRulesView", ThisKey="RuleId", OtherKey="Id", IsForeignKey=true)]
		public cssRulesView cssRulesView
		{
			get
			{
				return this._cssRulesView.Entity;
			}
			set
			{
				cssRulesView previousValue = this._cssRulesView.Entity;
				if (((previousValue != value) 
							|| (this._cssRulesView.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cssRulesView.Entity = null;
						previousValue.selectorsRanksViews.Remove(this);
					}
					this._cssRulesView.Entity = value;
					if ((value != null))
					{
						value.selectorsRanksViews.Add(this);
						this._RuleId = value.Id;
					}
					else
					{
						this._RuleId = default(int);
					}
					this.SendPropertyChanged("cssRulesView");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="view_selectorsRanksView", Storage="_view", ThisKey="FileId", OtherKey="Id", IsForeignKey=true)]
		public view view
		{
			get
			{
				return this._view.Entity;
			}
			set
			{
				view previousValue = this._view.Entity;
				if (((previousValue != value) 
							|| (this._view.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._view.Entity = null;
						previousValue.selectorsRanksViews.Remove(this);
					}
					this._view.Entity = value;
					if ((value != null))
					{
						value.selectorsRanksViews.Add(this);
						this._FileId = value.Id;
					}
					else
					{
						this._FileId = default(int);
					}
					this.SendPropertyChanged("view");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.selectorsViews")]
	public partial class selectorsView : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _RuleId;
		
		private string _Name;
		
		private int _FileId;
		
		private System.Nullable<int> _ParentSelectorId;
		
		private EntityRef<cssRulesView> _cssRulesView;
		
		private EntityRef<view> _view;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnRuleIdChanging(int value);
    partial void OnRuleIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFileIdChanging(int value);
    partial void OnFileIdChanged();
    partial void OnParentSelectorIdChanging(System.Nullable<int> value);
    partial void OnParentSelectorIdChanged();
    #endregion
		
		public selectorsView()
		{
			this._cssRulesView = default(EntityRef<cssRulesView>);
			this._view = default(EntityRef<view>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RuleId", DbType="Int NOT NULL")]
		public int RuleId
		{
			get
			{
				return this._RuleId;
			}
			set
			{
				if ((this._RuleId != value))
				{
					if (this._cssRulesView.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRuleIdChanging(value);
					this.SendPropertyChanging();
					this._RuleId = value;
					this.SendPropertyChanged("RuleId");
					this.OnRuleIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(MAX)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileId", DbType="Int NOT NULL")]
		public int FileId
		{
			get
			{
				return this._FileId;
			}
			set
			{
				if ((this._FileId != value))
				{
					if (this._view.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnFileIdChanging(value);
					this.SendPropertyChanging();
					this._FileId = value;
					this.SendPropertyChanged("FileId");
					this.OnFileIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentSelectorId", DbType="Int")]
		public System.Nullable<int> ParentSelectorId
		{
			get
			{
				return this._ParentSelectorId;
			}
			set
			{
				if ((this._ParentSelectorId != value))
				{
					this.OnParentSelectorIdChanging(value);
					this.SendPropertyChanging();
					this._ParentSelectorId = value;
					this.SendPropertyChanged("ParentSelectorId");
					this.OnParentSelectorIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="cssRulesView_selectorsView", Storage="_cssRulesView", ThisKey="RuleId", OtherKey="Id", IsForeignKey=true)]
		public cssRulesView cssRulesView
		{
			get
			{
				return this._cssRulesView.Entity;
			}
			set
			{
				cssRulesView previousValue = this._cssRulesView.Entity;
				if (((previousValue != value) 
							|| (this._cssRulesView.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._cssRulesView.Entity = null;
						previousValue.selectorsViews.Remove(this);
					}
					this._cssRulesView.Entity = value;
					if ((value != null))
					{
						value.selectorsViews.Add(this);
						this._RuleId = value.Id;
					}
					else
					{
						this._RuleId = default(int);
					}
					this.SendPropertyChanged("cssRulesView");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="view_selectorsView", Storage="_view", ThisKey="FileId", OtherKey="Id", IsForeignKey=true)]
		public view view
		{
			get
			{
				return this._view.Entity;
			}
			set
			{
				view previousValue = this._view.Entity;
				if (((previousValue != value) 
							|| (this._view.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._view.Entity = null;
						previousValue.selectorsViews.Remove(this);
					}
					this._view.Entity = value;
					if ((value != null))
					{
						value.selectorsViews.Add(this);
						this._FileId = value.Id;
					}
					else
					{
						this._FileId = default(int);
					}
					this.SendPropertyChanged("view");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.View_Selector")]
	public partial class View_Selector : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _SelectorName;
		
		private int _ViewId;
		
		private System.Nullable<int> _SelectorType;
		
		private EntityRef<view> _view;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSelectorNameChanging(string value);
    partial void OnSelectorNameChanged();
    partial void OnViewIdChanging(int value);
    partial void OnViewIdChanged();
    partial void OnSelectorTypeChanging(System.Nullable<int> value);
    partial void OnSelectorTypeChanged();
    #endregion
		
		public View_Selector()
		{
			this._view = default(EntityRef<view>);
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SelectorName", DbType="VarChar(MAX)")]
		public string SelectorName
		{
			get
			{
				return this._SelectorName;
			}
			set
			{
				if ((this._SelectorName != value))
				{
					this.OnSelectorNameChanging(value);
					this.SendPropertyChanging();
					this._SelectorName = value;
					this.SendPropertyChanged("SelectorName");
					this.OnSelectorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ViewId", DbType="Int NOT NULL")]
		public int ViewId
		{
			get
			{
				return this._ViewId;
			}
			set
			{
				if ((this._ViewId != value))
				{
					if (this._view.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnViewIdChanging(value);
					this.SendPropertyChanging();
					this._ViewId = value;
					this.SendPropertyChanged("ViewId");
					this.OnViewIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SelectorType", DbType="Int")]
		public System.Nullable<int> SelectorType
		{
			get
			{
				return this._SelectorType;
			}
			set
			{
				if ((this._SelectorType != value))
				{
					this.OnSelectorTypeChanging(value);
					this.SendPropertyChanging();
					this._SelectorType = value;
					this.SendPropertyChanged("SelectorType");
					this.OnSelectorTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="view_View_Selector", Storage="_view", ThisKey="ViewId", OtherKey="Id", IsForeignKey=true)]
		public view view
		{
			get
			{
				return this._view.Entity;
			}
			set
			{
				view previousValue = this._view.Entity;
				if (((previousValue != value) 
							|| (this._view.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._view.Entity = null;
						previousValue.View_Selectors.Remove(this);
					}
					this._view.Entity = value;
					if ((value != null))
					{
						value.View_Selectors.Add(this);
						this._ViewId = value.Id;
					}
					else
					{
						this._ViewId = default(int);
					}
					this.SendPropertyChanged("view");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.views")]
	public partial class view : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Path;
		
		private EntitySet<cssRulesView> _cssRulesViews;
		
		private EntitySet<selectorsRanksView> _selectorsRanksViews;
		
		private EntitySet<selectorsView> _selectorsViews;
		
		private EntitySet<View_Selector> _View_Selectors;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnPathChanging(string value);
    partial void OnPathChanged();
    #endregion
		
		public view()
		{
			this._cssRulesViews = new EntitySet<cssRulesView>(new Action<cssRulesView>(this.attach_cssRulesViews), new Action<cssRulesView>(this.detach_cssRulesViews));
			this._selectorsRanksViews = new EntitySet<selectorsRanksView>(new Action<selectorsRanksView>(this.attach_selectorsRanksViews), new Action<selectorsRanksView>(this.detach_selectorsRanksViews));
			this._selectorsViews = new EntitySet<selectorsView>(new Action<selectorsView>(this.attach_selectorsViews), new Action<selectorsView>(this.detach_selectorsViews));
			this._View_Selectors = new EntitySet<View_Selector>(new Action<View_Selector>(this.attach_View_Selectors), new Action<View_Selector>(this.detach_View_Selectors));
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Path", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Path
		{
			get
			{
				return this._Path;
			}
			set
			{
				if ((this._Path != value))
				{
					this.OnPathChanging(value);
					this.SendPropertyChanging();
					this._Path = value;
					this.SendPropertyChanged("Path");
					this.OnPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="view_cssRulesView", Storage="_cssRulesViews", ThisKey="Id", OtherKey="FileId")]
		public EntitySet<cssRulesView> cssRulesViews
		{
			get
			{
				return this._cssRulesViews;
			}
			set
			{
				this._cssRulesViews.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="view_selectorsRanksView", Storage="_selectorsRanksViews", ThisKey="Id", OtherKey="FileId")]
		public EntitySet<selectorsRanksView> selectorsRanksViews
		{
			get
			{
				return this._selectorsRanksViews;
			}
			set
			{
				this._selectorsRanksViews.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="view_selectorsView", Storage="_selectorsViews", ThisKey="Id", OtherKey="FileId")]
		public EntitySet<selectorsView> selectorsViews
		{
			get
			{
				return this._selectorsViews;
			}
			set
			{
				this._selectorsViews.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="view_View_Selector", Storage="_View_Selectors", ThisKey="Id", OtherKey="ViewId")]
		public EntitySet<View_Selector> View_Selectors
		{
			get
			{
				return this._View_Selectors;
			}
			set
			{
				this._View_Selectors.Assign(value);
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
		
		private void attach_cssRulesViews(cssRulesView entity)
		{
			this.SendPropertyChanging();
			entity.view = this;
		}
		
		private void detach_cssRulesViews(cssRulesView entity)
		{
			this.SendPropertyChanging();
			entity.view = null;
		}
		
		private void attach_selectorsRanksViews(selectorsRanksView entity)
		{
			this.SendPropertyChanging();
			entity.view = this;
		}
		
		private void detach_selectorsRanksViews(selectorsRanksView entity)
		{
			this.SendPropertyChanging();
			entity.view = null;
		}
		
		private void attach_selectorsViews(selectorsView entity)
		{
			this.SendPropertyChanging();
			entity.view = this;
		}
		
		private void detach_selectorsViews(selectorsView entity)
		{
			this.SendPropertyChanging();
			entity.view = null;
		}
		
		private void attach_View_Selectors(View_Selector entity)
		{
			this.SendPropertyChanging();
			entity.view = this;
		}
		
		private void detach_View_Selectors(View_Selector entity)
		{
			this.SendPropertyChanging();
			entity.view = null;
		}
	}
}
#pragma warning restore 1591
