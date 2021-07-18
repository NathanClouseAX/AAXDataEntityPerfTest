﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 7/17/2021 8:49:18 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for RelationshipTypeSingle in the schema.
        /// </summary>
    public partial class RelationshipTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<RelationshipType>
    {
        /// <summary>
        /// Initialize a new RelationshipTypeSingle object.
        /// </summary>
        public RelationshipTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new RelationshipTypeSingle object.
        /// </summary>
        public RelationshipTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new RelationshipTypeSingle object.
        /// </summary>
        public RelationshipTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<RelationshipType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for PersonalContactOrganizationWorkerRelationshipType1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonalContactOrganizations> PersonalContactOrganizationWorkerRelationshipType1
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonalContactOrganizationWorkerRelationshipType1 == null))
                {
                    this._PersonalContactOrganizationWorkerRelationshipType1 = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PersonalContactOrganizations>(GetPath("PersonalContactOrganizationWorkerRelationshipType1"));
                }
                return this._PersonalContactOrganizationWorkerRelationshipType1;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonalContactOrganizations> _PersonalContactOrganizationWorkerRelationshipType1;
        /// <summary>
        /// There are no comments for TeamMember in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TeamMember> TeamMember
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TeamMember == null))
                {
                    this._TeamMember = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TeamMember>(GetPath("TeamMember"));
                }
                return this._TeamMember;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TeamMember> _TeamMember;
        /// <summary>
        /// There are no comments for PersonalContactPersonWorkerRelationshipType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonalContactPerson> PersonalContactPersonWorkerRelationshipType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonalContactPersonWorkerRelationshipType == null))
                {
                    this._PersonalContactPersonWorkerRelationshipType = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PersonalContactPerson>(GetPath("PersonalContactPersonWorkerRelationshipType"));
                }
                return this._PersonalContactPersonWorkerRelationshipType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonalContactPerson> _PersonalContactPersonWorkerRelationshipType;
    }
        /// <summary>
        /// There are no comments for RelationshipType in the schema.
        /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("ID")]
    [global::Microsoft.OData.Client.EntitySet("RelationshipTypes")]
    public partial class RelationshipType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new RelationshipType object.
        /// </summary>
        /// <param name="ID">Initial value of ID.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static RelationshipType CreateRelationshipType(string ID)
        {
            RelationshipType relationshipType = new RelationshipType();
            relationshipType.ID = ID;
            return relationshipType;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this._ID = value;
                this.OnIDChanged();
                this.OnPropertyChanged("ID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ID;
        partial void OnIDChanging(string value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property SystemType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSystemRelationshipType> SystemType
        {
            get
            {
                return this._SystemType;
            }
            set
            {
                this.OnSystemTypeChanging(value);
                this._SystemType = value;
                this.OnSystemTypeChanged();
                this.OnPropertyChanged("SystemType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSystemRelationshipType> _SystemType;
        partial void OnSystemTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirSystemRelationshipType> value);
        partial void OnSystemTypeChanged();
        /// <summary>
        /// There are no comments for Property PartyBType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirPartyType> PartyBType
        {
            get
            {
                return this._PartyBType;
            }
            set
            {
                this.OnPartyBTypeChanging(value);
                this._PartyBType = value;
                this.OnPartyBTypeChanged();
                this.OnPropertyChanged("PartyBType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirPartyType> _PartyBType;
        partial void OnPartyBTypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirPartyType> value);
        partial void OnPartyBTypeChanged();
        /// <summary>
        /// There are no comments for Property PartyAType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirPartyType> PartyAType
        {
            get
            {
                return this._PartyAType;
            }
            set
            {
                this.OnPartyATypeChanging(value);
                this._PartyAType = value;
                this.OnPartyATypeChanged();
                this.OnPropertyChanged("PartyAType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirPartyType> _PartyAType;
        partial void OnPartyATypeChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.DirPartyType> value);
        partial void OnPartyATypeChanged();
        /// <summary>
        /// There are no comments for Property Symmetric in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> Symmetric
        {
            get
            {
                return this._Symmetric;
            }
            set
            {
                this.OnSymmetricChanging(value);
                this._Symmetric = value;
                this.OnSymmetricChanged();
                this.OnPropertyChanged("Symmetric");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _Symmetric;
        partial void OnSymmetricChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnSymmetricChanged();
        /// <summary>
        /// There are no comments for Property RelationshipAToB in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RelationshipAToB
        {
            get
            {
                return this._RelationshipAToB;
            }
            set
            {
                this.OnRelationshipAToBChanging(value);
                this._RelationshipAToB = value;
                this.OnRelationshipAToBChanged();
                this.OnPropertyChanged("RelationshipAToB");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RelationshipAToB;
        partial void OnRelationshipAToBChanging(string value);
        partial void OnRelationshipAToBChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property RelationshipBToA in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string RelationshipBToA
        {
            get
            {
                return this._RelationshipBToA;
            }
            set
            {
                this.OnRelationshipBToAChanging(value);
                this._RelationshipBToA = value;
                this.OnRelationshipBToAChanged();
                this.OnPropertyChanged("RelationshipBToA");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RelationshipBToA;
        partial void OnRelationshipBToAChanging(string value);
        partial void OnRelationshipBToAChanged();
        /// <summary>
        /// There are no comments for Property PersonalContactOrganizationWorkerRelationshipType1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonalContactOrganizations> PersonalContactOrganizationWorkerRelationshipType1
        {
            get
            {
                return this._PersonalContactOrganizationWorkerRelationshipType1;
            }
            set
            {
                this.OnPersonalContactOrganizationWorkerRelationshipType1Changing(value);
                this._PersonalContactOrganizationWorkerRelationshipType1 = value;
                this.OnPersonalContactOrganizationWorkerRelationshipType1Changed();
                this.OnPropertyChanged("PersonalContactOrganizationWorkerRelationshipType1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonalContactOrganizations> _PersonalContactOrganizationWorkerRelationshipType1 = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonalContactOrganizations>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonalContactOrganizationWorkerRelationshipType1Changing(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonalContactOrganizations> value);
        partial void OnPersonalContactOrganizationWorkerRelationshipType1Changed();
        /// <summary>
        /// There are no comments for Property TeamMember in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamMember> TeamMember
        {
            get
            {
                return this._TeamMember;
            }
            set
            {
                this.OnTeamMemberChanging(value);
                this._TeamMember = value;
                this.OnTeamMemberChanged();
                this.OnPropertyChanged("TeamMember");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamMember> _TeamMember = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamMember>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTeamMemberChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamMember> value);
        partial void OnTeamMemberChanged();
        /// <summary>
        /// There are no comments for Property PersonalContactPersonWorkerRelationshipType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonalContactPerson> PersonalContactPersonWorkerRelationshipType
        {
            get
            {
                return this._PersonalContactPersonWorkerRelationshipType;
            }
            set
            {
                this.OnPersonalContactPersonWorkerRelationshipTypeChanging(value);
                this._PersonalContactPersonWorkerRelationshipType = value;
                this.OnPersonalContactPersonWorkerRelationshipTypeChanged();
                this.OnPropertyChanged("PersonalContactPersonWorkerRelationshipType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonalContactPerson> _PersonalContactPersonWorkerRelationshipType = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonalContactPerson>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonalContactPersonWorkerRelationshipTypeChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonalContactPerson> value);
        partial void OnPersonalContactPersonWorkerRelationshipTypeChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
