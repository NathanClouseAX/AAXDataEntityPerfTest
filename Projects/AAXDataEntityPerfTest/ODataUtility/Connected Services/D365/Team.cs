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
        /// There are no comments for TeamSingle in the schema.
        /// </summary>
    public partial class TeamSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Team>
    {
        /// <summary>
        /// Initialize a new TeamSingle object.
        /// </summary>
        public TeamSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TeamSingle object.
        /// </summary>
        public TeamSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TeamSingle object.
        /// </summary>
        public TeamSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Team> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for TeamMembers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TeamMember> TeamMembers
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TeamMembers == null))
                {
                    this._TeamMembers = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.TeamMember>(GetPath("TeamMembers"));
                }
                return this._TeamMembers;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.TeamMember> _TeamMembers;
        /// <summary>
        /// There are no comments for TeamMembershipCriterion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TeamMembershipCriterionSingle TeamMembershipCriterion
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._TeamMembershipCriterion == null))
                {
                    this._TeamMembershipCriterion = new global::Microsoft.Dynamics.DataEntities.TeamMembershipCriterionSingle(this.Context, GetPath("TeamMembershipCriterion"));
                }
                return this._TeamMembershipCriterion;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TeamMembershipCriterionSingle _TeamMembershipCriterion;
    }
        /// <summary>
        /// There are no comments for Team in the schema.
        /// </summary>
    /// <KeyProperties>
    /// PartyNumber
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("PartyNumber")]
    [global::Microsoft.OData.Client.EntitySet("Teams")]
    public partial class Team : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Team object.
        /// </summary>
        /// <param name="partyNumber">Initial value of PartyNumber.</param>
        /// <param name="teamMembershipCriterion">Initial value of TeamMembershipCriterion.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Team CreateTeam(string partyNumber, global::Microsoft.Dynamics.DataEntities.TeamMembershipCriterion teamMembershipCriterion)
        {
            Team team = new Team();
            team.PartyNumber = partyNumber;
            if ((teamMembershipCriterion == null))
            {
                throw new global::System.ArgumentNullException("teamMembershipCriterion");
            }
            team.TeamMembershipCriterion = teamMembershipCriterion;
            return team;
        }
        /// <summary>
        /// There are no comments for Property PartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string PartyNumber
        {
            get
            {
                return this._PartyNumber;
            }
            set
            {
                this.OnPartyNumberChanging(value);
                this._PartyNumber = value;
                this.OnPartyNumberChanged();
                this.OnPropertyChanged("PartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PartyNumber;
        partial void OnPartyNumberChanging(string value);
        partial void OnPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property IsActive in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsActive
        {
            get
            {
                return this._IsActive;
            }
            set
            {
                this.OnIsActiveChanging(value);
                this._IsActive = value;
                this.OnIsActiveChanged();
                this.OnPropertyChanged("IsActive");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsActive;
        partial void OnIsActiveChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsActiveChanged();
        /// <summary>
        /// There are no comments for Property TeamTypeName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TeamTypeName
        {
            get
            {
                return this._TeamTypeName;
            }
            set
            {
                this.OnTeamTypeNameChanging(value);
                this._TeamTypeName = value;
                this.OnTeamTypeNameChanged();
                this.OnPropertyChanged("TeamTypeName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TeamTypeName;
        partial void OnTeamTypeNameChanging(string value);
        partial void OnTeamTypeNameChanged();
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
        /// There are no comments for Property Administrator in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Administrator
        {
            get
            {
                return this._Administrator;
            }
            set
            {
                this.OnAdministratorChanging(value);
                this._Administrator = value;
                this.OnAdministratorChanged();
                this.OnPropertyChanged("Administrator");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Administrator;
        partial void OnAdministratorChanging(string value);
        partial void OnAdministratorChanged();
        /// <summary>
        /// There are no comments for Property TeamMembers in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamMember> TeamMembers
        {
            get
            {
                return this._TeamMembers;
            }
            set
            {
                this.OnTeamMembersChanging(value);
                this._TeamMembers = value;
                this.OnTeamMembersChanged();
                this.OnPropertyChanged("TeamMembers");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamMember> _TeamMembers = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamMember>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnTeamMembersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.TeamMember> value);
        partial void OnTeamMembersChanged();
        /// <summary>
        /// There are no comments for Property TeamMembershipCriterion in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TeamMembershipCriterion TeamMembershipCriterion
        {
            get
            {
                return this._TeamMembershipCriterion;
            }
            set
            {
                this.OnTeamMembershipCriterionChanging(value);
                this._TeamMembershipCriterion = value;
                this.OnTeamMembershipCriterionChanged();
                this.OnPropertyChanged("TeamMembershipCriterion");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TeamMembershipCriterion _TeamMembershipCriterion;
        partial void OnTeamMembershipCriterionChanging(global::Microsoft.Dynamics.DataEntities.TeamMembershipCriterion value);
        partial void OnTeamMembershipCriterionChanged();
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
