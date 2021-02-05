﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 2/4/2021 7:24:30 AM
namespace Microsoft.Dynamics.DataEntities
{
        /// <summary>
        /// There are no comments for TestTypeSingle in the schema.
        /// </summary>
    public partial class TestTypeSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<TestType>
    {
        /// <summary>
        /// Initialize a new TestTypeSingle object.
        /// </summary>
        public TestTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new TestTypeSingle object.
        /// </summary>
        public TestTypeSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new TestTypeSingle object.
        /// </summary>
        public TestTypeSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<TestType> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for WorkerExam in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerExam> WorkerExam
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._WorkerExam == null))
                {
                    this._WorkerExam = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.WorkerExam>(GetPath("WorkerExam"));
                }
                return this._WorkerExam;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.WorkerExam> _WorkerExam;
        /// <summary>
        /// There are no comments for PersonExam in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonExam> PersonExam
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonExam == null))
                {
                    this._PersonExam = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.PersonExam>(GetPath("PersonExam"));
                }
                return this._PersonExam;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.PersonExam> _PersonExam;
        /// <summary>
        /// There are no comments for JobTemplateExam in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> JobTemplateExam
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTemplateExam == null))
                {
                    this._JobTemplateExam = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateExam>(GetPath("JobTemplateExam"));
                }
                return this._JobTemplateExam;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> _JobTemplateExam;
        /// <summary>
        /// There are no comments for JobPreferredExam in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredExam> JobPreferredExam
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobPreferredExam == null))
                {
                    this._JobPreferredExam = Context.CreateQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredExam>(GetPath("JobPreferredExam"));
                }
                return this._JobPreferredExam;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Microsoft.Dynamics.DataEntities.JobPreferredExam> _JobPreferredExam;
    }
        /// <summary>
        /// There are no comments for TestType in the schema.
        /// </summary>
    /// <KeyProperties>
    /// TestId
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("TestId")]
    [global::Microsoft.OData.Client.EntitySet("TestTypes")]
    public partial class TestType : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new TestType object.
        /// </summary>
        /// <param name="testId">Initial value of TestId.</param>
        /// <param name="interval">Initial value of Interval.</param>
        /// <param name="passingScore">Initial value of PassingScore.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static TestType CreateTestType(string testId, int interval, int passingScore)
        {
            TestType testType = new TestType();
            testType.TestId = testId;
            testType.Interval = interval;
            testType.PassingScore = passingScore;
            return testType;
        }
        /// <summary>
        /// There are no comments for Property TestId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string TestId
        {
            get
            {
                return this._TestId;
            }
            set
            {
                this.OnTestIdChanging(value);
                this._TestId = value;
                this.OnTestIdChanged();
                this.OnPropertyChanged("TestId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TestId;
        partial void OnTestIdChanging(string value);
        partial void OnTestIdChanged();
        /// <summary>
        /// There are no comments for Property GenerateFrom in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmFrequencyGenerateFrom> GenerateFrom
        {
            get
            {
                return this._GenerateFrom;
            }
            set
            {
                this.OnGenerateFromChanging(value);
                this._GenerateFrom = value;
                this.OnGenerateFromChanged();
                this.OnPropertyChanged("GenerateFrom");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmFrequencyGenerateFrom> _GenerateFrom;
        partial void OnGenerateFromChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmFrequencyGenerateFrom> value);
        partial void OnGenerateFromChanged();
        /// <summary>
        /// There are no comments for Property Interval in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Interval
        {
            get
            {
                return this._Interval;
            }
            set
            {
                this.OnIntervalChanging(value);
                this._Interval = value;
                this.OnIntervalChanged();
                this.OnPropertyChanged("Interval");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Interval;
        partial void OnIntervalChanging(int value);
        partial void OnIntervalChanged();
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
        /// There are no comments for Property PassingScore in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int PassingScore
        {
            get
            {
                return this._PassingScore;
            }
            set
            {
                this.OnPassingScoreChanging(value);
                this._PassingScore = value;
                this.OnPassingScoreChanged();
                this.OnPropertyChanged("PassingScore");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _PassingScore;
        partial void OnPassingScoreChanging(int value);
        partial void OnPassingScoreChanged();
        /// <summary>
        /// There are no comments for Property Frequency in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmFrequencyUnit> Frequency
        {
            get
            {
                return this._Frequency;
            }
            set
            {
                this.OnFrequencyChanging(value);
                this._Frequency = value;
                this.OnFrequencyChanged();
                this.OnPropertyChanged("Frequency");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmFrequencyUnit> _Frequency;
        partial void OnFrequencyChanging(global::System.Nullable<global::Microsoft.Dynamics.DataEntities.HcmFrequencyUnit> value);
        partial void OnFrequencyChanged();
        /// <summary>
        /// There are no comments for Property WorkerExam in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerExam> WorkerExam
        {
            get
            {
                return this._WorkerExam;
            }
            set
            {
                this.OnWorkerExamChanging(value);
                this._WorkerExam = value;
                this.OnWorkerExamChanged();
                this.OnPropertyChanged("WorkerExam");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerExam> _WorkerExam = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerExam>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnWorkerExamChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.WorkerExam> value);
        partial void OnWorkerExamChanged();
        /// <summary>
        /// There are no comments for Property PersonExam in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonExam> PersonExam
        {
            get
            {
                return this._PersonExam;
            }
            set
            {
                this.OnPersonExamChanging(value);
                this._PersonExam = value;
                this.OnPersonExamChanged();
                this.OnPropertyChanged("PersonExam");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonExam> _PersonExam = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonExam>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnPersonExamChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.PersonExam> value);
        partial void OnPersonExamChanged();
        /// <summary>
        /// There are no comments for Property JobTemplateExam in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> JobTemplateExam
        {
            get
            {
                return this._JobTemplateExam;
            }
            set
            {
                this.OnJobTemplateExamChanging(value);
                this._JobTemplateExam = value;
                this.OnJobTemplateExamChanged();
                this.OnPropertyChanged("JobTemplateExam");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> _JobTemplateExam = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateExam>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobTemplateExamChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobTemplateExam> value);
        partial void OnJobTemplateExamChanged();
        /// <summary>
        /// There are no comments for Property JobPreferredExam in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredExam> JobPreferredExam
        {
            get
            {
                return this._JobPreferredExam;
            }
            set
            {
                this.OnJobPreferredExamChanging(value);
                this._JobPreferredExam = value;
                this.OnJobPreferredExamChanged();
                this.OnPropertyChanged("JobPreferredExam");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredExam> _JobPreferredExam = new global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredExam>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnJobPreferredExamChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Microsoft.Dynamics.DataEntities.JobPreferredExam> value);
        partial void OnJobPreferredExamChanged();
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
