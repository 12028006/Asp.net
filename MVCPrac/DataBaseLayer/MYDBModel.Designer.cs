//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace DataBaseLayer
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MYDBEntities4 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MYDBEntities4 object using the connection string found in the 'MYDBEntities4' section of the application configuration file.
        /// </summary>
        public MYDBEntities4() : base("name=MYDBEntities4", "MYDBEntities4")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MYDBEntities4 object.
        /// </summary>
        public MYDBEntities4(string connectionString) : base(connectionString, "MYDBEntities4")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MYDBEntities4 object.
        /// </summary>
        public MYDBEntities4(EntityConnection connection) : base(connection, "MYDBEntities4")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Registration> Registrations
        {
            get
            {
                if ((_Registrations == null))
                {
                    _Registrations = base.CreateObjectSet<Registration>("Registrations");
                }
                return _Registrations;
            }
        }
        private ObjectSet<Registration> _Registrations;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Registrations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRegistrations(Registration registration)
        {
            base.AddObject("Registrations", registration);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MYDBModel", Name="Registration")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Registration : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Registration object.
        /// </summary>
        /// <param name="regId">Initial value of the RegId property.</param>
        public static Registration CreateRegistration(global::System.Int32 regId)
        {
            Registration registration = new Registration();
            registration.RegId = regId;
            return registration;
        }

        #endregion

        #region Simple Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 RegId
        {
            get
            {
                return _RegId;
            }
            set
            {
                if (_RegId != value)
                {
                    OnRegIdChanging(value);
                    ReportPropertyChanging("RegId");
                    _RegId = StructuralObject.SetValidValue(value, "RegId");
                    ReportPropertyChanged("RegId");
                    OnRegIdChanged();
                }
            }
        }
        private global::System.Int32 _RegId;
        partial void OnRegIdChanging(global::System.Int32 value);
        partial void OnRegIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                OnFullNameChanging(value);
                ReportPropertyChanging("FullName");
                _FullName = StructuralObject.SetValidValue(value, true, "FullName");
                ReportPropertyChanged("FullName");
                OnFullNameChanged();
            }
        }
        private global::System.String _FullName;
        partial void OnFullNameChanging(global::System.String value);
        partial void OnFullNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true, "Address");
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value, true, "Gender");
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.String _Gender;
        partial void OnGenderChanging(global::System.String value);
        partial void OnGenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true, "City");
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DoB
        {
            get
            {
                return _DoB;
            }
            set
            {
                OnDoBChanging(value);
                ReportPropertyChanging("DoB");
                _DoB = StructuralObject.SetValidValue(value, "DoB");
                ReportPropertyChanged("DoB");
                OnDoBChanged();
            }
        }
        private Nullable<global::System.DateTime> _DoB;
        partial void OnDoBChanging(Nullable<global::System.DateTime> value);
        partial void OnDoBChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Cno
        {
            get
            {
                return _Cno;
            }
            set
            {
                OnCnoChanging(value);
                ReportPropertyChanging("Cno");
                _Cno = StructuralObject.SetValidValue(value, true, "Cno");
                ReportPropertyChanged("Cno");
                OnCnoChanged();
            }
        }
        private global::System.String _Cno;
        partial void OnCnoChanging(global::System.String value);
        partial void OnCnoChanged();

        #endregion

    }

    #endregion

}
