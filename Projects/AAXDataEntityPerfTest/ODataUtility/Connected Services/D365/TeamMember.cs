﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 11/28/2021 8:55:09 PM
namespace Microsoft.Dynamics.DataEntities
{
    /// <summary>
    /// There are no comments for TeamMemberSingle in the schema.
    /// </summary>
    public partial class TeamMemberSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TeamMember>
    {
        /// <summary>
        /// Initialize a new TeamMemberSingle object.
        /// </summary>
        public TeamMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TeamMemberSingle object.
        /// </summary>
        public TeamMemberSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TeamMemberSingle object.
        /// </summary>
        public TeamMemberSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TeamMember> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for RelationshipType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.RelationshipTypeSingle RelationshipType
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._RelationshipType == null))
                {
                    this._RelationshipType = new global::Microsoft.Dynamics.DataEntities.RelationshipTypeSingle(this.Context, GetPath("RelationshipType"));
                }
                return this._RelationshipType;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RelationshipTypeSingle _RelationshipType;
        /// <summary>
        /// There are no comments for Team in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TeamSingle Team
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Team == null))
                {
                    this._Team = new global::Microsoft.Dynamics.DataEntities.TeamSingle(this.Context, GetPath("Team"));
                }
                return this._Team;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TeamSingle _Team;
    }
    /// <summary>
    /// There are no comments for TeamMember in the schema.
    /// </summary>
    /// <KeyProperties>
    /// RelationshipTypeId
    /// TeamMemberPartyNumber
    /// TeamPartyNumber
    /// ValidTo
    /// ValidFrom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("RelationshipTypeId", "TeamMemberPartyNumber", "TeamPartyNumber", "ValidTo", "ValidFrom")]
    [global::Microsoft.OData.Client.EntitySet("TeamMembers")]
    public partial class TeamMember : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TeamMember object.
        /// </summary>
        /// <param name="relationshipTypeId">Initial value of RelationshipTypeId.</param>
        /// <param name="teamMemberPartyNumber">Initial value of TeamMemberPartyNumber.</param>
        /// <param name="teamPartyNumber">Initial value of TeamPartyNumber.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="relationshipType">Initial value of RelationshipType.</param>
        /// <param name="team">Initial value of Team.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TeamMember CreateTeamMember(string relationshipTypeId, 
                    string teamMemberPartyNumber, 
                    string teamPartyNumber, 
                    global::System.DateTimeOffset validTo, 
                    global::System.DateTimeOffset validFrom, 
                    global::Microsoft.Dynamics.DataEntities.RelationshipType relationshipType, 
                    global::Microsoft.Dynamics.DataEntities.Team team)
        {
            TeamMember teamMember = new TeamMember();
            teamMember.RelationshipTypeId = relationshipTypeId;
            teamMember.TeamMemberPartyNumber = teamMemberPartyNumber;
            teamMember.TeamPartyNumber = teamPartyNumber;
            teamMember.ValidTo = validTo;
            teamMember.ValidFrom = validFrom;
            if ((relationshipType == null))
            {
                throw new global::System.ArgumentNullException("relationshipType");
            }
            teamMember.RelationshipType = relationshipType;
            if ((team == null))
            {
                throw new global::System.ArgumentNullException("team");
            }
            teamMember.Team = team;
            return teamMember;
        }
        /// <summary>
        /// There are no comments for Property RelationshipTypeId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RelationshipTypeId is required.")]
        public virtual string RelationshipTypeId
        {
            get
            {
                return this._RelationshipTypeId;
            }
            set
            {
                this.OnRelationshipTypeIdChanging(value);
                this._RelationshipTypeId = value;
                this.OnRelationshipTypeIdChanged();
                this.OnPropertyChanged("RelationshipTypeId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _RelationshipTypeId;
        partial void OnRelationshipTypeIdChanging(string value);
        partial void OnRelationshipTypeIdChanged();
        /// <summary>
        /// There are no comments for Property TeamMemberPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TeamMemberPartyNumber is required.")]
        public virtual string TeamMemberPartyNumber
        {
            get
            {
                return this._TeamMemberPartyNumber;
            }
            set
            {
                this.OnTeamMemberPartyNumberChanging(value);
                this._TeamMemberPartyNumber = value;
                this.OnTeamMemberPartyNumberChanged();
                this.OnPropertyChanged("TeamMemberPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TeamMemberPartyNumber;
        partial void OnTeamMemberPartyNumberChanging(string value);
        partial void OnTeamMemberPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property TeamPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "TeamPartyNumber is required.")]
        public virtual string TeamPartyNumber
        {
            get
            {
                return this._TeamPartyNumber;
            }
            set
            {
                this.OnTeamPartyNumberChanging(value);
                this._TeamPartyNumber = value;
                this.OnTeamPartyNumberChanged();
                this.OnPropertyChanged("TeamPartyNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TeamPartyNumber;
        partial void OnTeamPartyNumberChanging(string value);
        partial void OnTeamPartyNumberChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidTo is required.")]
        public virtual global::System.DateTimeOffset ValidTo
        {
            get
            {
                return this._ValidTo;
            }
            set
            {
                this.OnValidToChanging(value);
                this._ValidTo = value;
                this.OnValidToChanged();
                this.OnPropertyChanged("ValidTo");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidTo;
        partial void OnValidToChanging(global::System.DateTimeOffset value);
        partial void OnValidToChanged();
        /// <summary>
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ValidFrom is required.")]
        public virtual global::System.DateTimeOffset ValidFrom
        {
            get
            {
                return this._ValidFrom;
            }
            set
            {
                this.OnValidFromChanging(value);
                this._ValidFrom = value;
                this.OnValidFromChanged();
                this.OnPropertyChanged("ValidFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.DateTimeOffset _ValidFrom;
        partial void OnValidFromChanging(global::System.DateTimeOffset value);
        partial void OnValidFromChanged();
        /// <summary>
        /// There are no comments for Property TeamName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TeamName
        {
            get
            {
                return this._TeamName;
            }
            set
            {
                this.OnTeamNameChanging(value);
                this._TeamName = value;
                this.OnTeamNameChanged();
                this.OnPropertyChanged("TeamName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TeamName;
        partial void OnTeamNameChanging(string value);
        partial void OnTeamNameChanged();
        /// <summary>
        /// There are no comments for Property TeamMemberName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        public virtual string TeamMemberName
        {
            get
            {
                return this._TeamMemberName;
            }
            set
            {
                this.OnTeamMemberNameChanging(value);
                this._TeamMemberName = value;
                this.OnTeamMemberNameChanged();
                this.OnPropertyChanged("TeamMemberName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TeamMemberName;
        partial void OnTeamMemberNameChanging(string value);
        partial void OnTeamMemberNameChanged();
        /// <summary>
        /// There are no comments for Property RelationshipType in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "RelationshipType is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.RelationshipType RelationshipType
        {
            get
            {
                return this._RelationshipType;
            }
            set
            {
                this.OnRelationshipTypeChanging(value);
                this._RelationshipType = value;
                this.OnRelationshipTypeChanged();
                this.OnPropertyChanged("RelationshipType");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.RelationshipType _RelationshipType;
        partial void OnRelationshipTypeChanging(global::Microsoft.Dynamics.DataEntities.RelationshipType value);
        partial void OnRelationshipTypeChanged();
        /// <summary>
        /// There are no comments for Property Team in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Team is required.")]
        public virtual global::Microsoft.Dynamics.DataEntities.Team Team
        {
            get
            {
                return this._Team;
            }
            set
            {
                this.OnTeamChanging(value);
                this._Team = value;
                this.OnTeamChanged();
                this.OnPropertyChanged("Team");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Team _Team;
        partial void OnTeamChanging(global::Microsoft.Dynamics.DataEntities.Team value);
        partial void OnTeamChanged();
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
