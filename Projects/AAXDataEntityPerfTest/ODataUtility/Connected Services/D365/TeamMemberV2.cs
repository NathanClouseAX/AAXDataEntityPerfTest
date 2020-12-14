﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 12/8/2020 7:45:22 PM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for TeamMemberV2Single in the schema.
        /// </summary>
    public partial class TeamMemberV2Single : global::Microsoft.OData.Client.DataServiceQuerySingle<TeamMemberV2>
    {
        /// <summary>
        /// Initialize a new TeamMemberV2Single object.
        /// </summary>
        public TeamMemberV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TeamMemberV2Single object.
        /// </summary>
        public TeamMemberV2Single(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TeamMemberV2Single object.
        /// </summary>
        public TeamMemberV2Single(global::Microsoft.OData.Client.DataServiceQuerySingle<TeamMemberV2> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Teams in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.PersonSingle Teams
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Teams == null))
                {
                    this._Teams = new global::Microsoft.Dynamics.DataEntities.PersonSingle(this.Context, GetPath("Teams"));
                }
                return this._Teams;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.PersonSingle _Teams;
        /// <summary>
        /// There are no comments for Team in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TeamV2Single Team
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Team == null))
                {
                    this._Team = new global::Microsoft.Dynamics.DataEntities.TeamV2Single(this.Context, GetPath("Team"));
                }
                return this._Team;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.TeamV2Single _Team;
    }
        /// <summary>
        /// There are no comments for TeamMemberV2 in the schema.
        /// </summary>
    /// <KeyProperties>
    /// TeamMemberPartyNumber
    /// TeamName
    /// ValidFrom
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TeamMemberPartyNumber", "TeamName", "ValidFrom")]
    [global::Microsoft.OData.Client.EntitySet("TeamMembersV2")]
    public partial class TeamMemberV2 : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TeamMemberV2 object.
        /// </summary>
        /// <param name="teamMemberPartyNumber">Initial value of TeamMemberPartyNumber.</param>
        /// <param name="teamName">Initial value of TeamName.</param>
        /// <param name="validFrom">Initial value of ValidFrom.</param>
        /// <param name="validTo">Initial value of ValidTo.</param>
        /// <param name="teams">Initial value of Teams.</param>
        /// <param name="team">Initial value of Team.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TeamMemberV2 CreateTeamMemberV2(string teamMemberPartyNumber, 
                    string teamName, 
                    global::System.DateTimeOffset validFrom, 
                    global::System.DateTimeOffset validTo, 
                    global::Microsoft.Dynamics.DataEntities.Person teams, 
                    global::Microsoft.Dynamics.DataEntities.TeamV2 team)
        {
            TeamMemberV2 teamMemberV2 = new TeamMemberV2();
            teamMemberV2.TeamMemberPartyNumber = teamMemberPartyNumber;
            teamMemberV2.TeamName = teamName;
            teamMemberV2.ValidFrom = validFrom;
            teamMemberV2.ValidTo = validTo;
            if ((teams == null))
            {
                throw new global::System.ArgumentNullException("teams");
            }
            teamMemberV2.Teams = teams;
            if ((team == null))
            {
                throw new global::System.ArgumentNullException("team");
            }
            teamMemberV2.Team = team;
            return teamMemberV2;
        }
        /// <summary>
        /// There are no comments for Property TeamMemberPartyNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property ValidFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property IsTeamLead in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> IsTeamLead
        {
            get
            {
                return this._IsTeamLead;
            }
            set
            {
                this.OnIsTeamLeadChanging(value);
                this._IsTeamLead = value;
                this.OnIsTeamLeadChanged();
                this.OnPropertyChanged("IsTeamLead");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> _IsTeamLead;
        partial void OnIsTeamLeadChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.NoYes> value);
        partial void OnIsTeamLeadChanged();
        /// <summary>
        /// There are no comments for Property ValidTo in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
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
        /// There are no comments for Property Teams in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.Person Teams
        {
            get
            {
                return this._Teams;
            }
            set
            {
                this.OnTeamsChanging(value);
                this._Teams = value;
                this.OnTeamsChanged();
                this.OnPropertyChanged("Teams");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.Dynamics.DataEntities.Person _Teams;
        partial void OnTeamsChanging(global::Microsoft.Dynamics.DataEntities.Person value);
        partial void OnTeamsChanged();
        /// <summary>
        /// There are no comments for Property Team in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.Dynamics.DataEntities.TeamV2 Team
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
        private global::Microsoft.Dynamics.DataEntities.TeamV2 _Team;
        partial void OnTeamChanging(global::Microsoft.Dynamics.DataEntities.TeamV2 value);
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
