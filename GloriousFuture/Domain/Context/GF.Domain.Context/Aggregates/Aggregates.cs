using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Objects.DataClasses;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using GF.Infrastructure.Crosscutting.Context;

[assembly: EdmSchemaAttribute()]

#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_PayRecords_Users", "User", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.User), "PayRecord", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.PayRecord), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_RechargeRecords_Users", "User", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.User), "RechargeRecord", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.RechargeRecord), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_ScorePublishes_Regions", "Region", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.Region), "ScorePublish", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.ScorePublish), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_Users_Roles", "Role", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.Role), "User", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.User), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_Users_Universities", "University", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(GF.Domain.Context.University), "User", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.User), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_Achievements_HighSchool", "HighSchool", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.HighSchool), "Achievement", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.Achievement), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_Achievements_Users", "User", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.User), "Achievement", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.Achievement), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_Applications_Specialities", "Speciality", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.Speciality), "Application", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.Application), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_Applications_Universities", "University", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.University), "Application", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.Application), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_Applications_Users", "User", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.User), "Application", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.Application), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_UniversityAcceptanceStatistics_Regions", "Region", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.Region), "UniversityAcceptanceStatistic", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.UniversityAcceptanceStatistic), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_UniversityEnrollPlans_Regions", "Region", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.Region), "UniversityEnrollPlan", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.UniversityEnrollPlan), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_SpecialityAcceptanceStatistics_Specialities", "Speciality", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.Speciality), "SpecialityAcceptanceStatistic", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.SpecialityAcceptanceStatistic), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_UniversityEnrollPlans_Specialities", "Speciality", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.Speciality), "UniversityEnrollPlan", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.UniversityEnrollPlan), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics", "UniversityAcceptanceStatistic", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.UniversityAcceptanceStatistic), "SpecialityAcceptanceStatistic", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.SpecialityAcceptanceStatistic), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_UniversityAcceptanceStatistics_Universities", "University", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.University), "UniversityAcceptanceStatistic", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.UniversityAcceptanceStatistic), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_UniversityEnrollPlans_Universities", "University", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.University), "UniversityEnrollPlan", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.UniversityEnrollPlan), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_Achievements_Regions", "Region", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.Region), "Achievement", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.Achievement), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_IDCard_Users", "User", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.User), "IDCard", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.IDCard), true)]
[assembly: EdmRelationshipAttribute("GF.Domain.Context", "FK_Universities_Regions", "Region", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(GF.Domain.Context.Region), "University", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(GF.Domain.Context.University), true)]

#endregion

namespace GF.Domain.Context
{

    #region Entities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "Achievement")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class Achievement : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new Achievement object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="score">Initial value of the Score property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        /// <param name="courseType">Initial value of the CourseType property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="highSchoolId">Initial value of the HighSchoolId property.</param>
        /// <param name="provinceId">Initial value of the ProvinceId property.</param>
        public static Achievement CreateAchievement(global::System.Int32 id, global::System.Double score, global::System.Int32 year, global::System.String courseType, global::System.Guid userId, global::System.Guid highSchoolId, global::System.Guid provinceId)
        {
            Achievement achievement = new Achievement();
            achievement.Id = id;
            achievement.Score = score;
            achievement.Year = year;
            achievement.CourseType = courseType;
            achievement.UserId = userId;
            achievement.HighSchoolId = highSchoolId;
            achievement.ProvinceId = provinceId;
            return achievement;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Double Score
        {
            get
            {
                return _Score;
            }
            set
            {
                OnScoreChanging(value);
                ReportPropertyChanging("Score");
                _Score = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Score");
                OnScoreChanged();
            }
        }
        private global::System.Double _Score;
        partial void OnScoreChanging(global::System.Double value);
        partial void OnScoreChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String ACEENumber
        {
            get
            {
                return _ACEENumber;
            }
            set
            {
                OnACEENumberChanging(value);
                ReportPropertyChanging("ACEENumber");
                _ACEENumber = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ACEENumber");
                OnACEENumberChanged();
            }
        }
        private global::System.String _ACEENumber;
        partial void OnACEENumberChanging(global::System.String value);
        partial void OnACEENumberChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.Int32 _Year;
        partial void OnYearChanging(global::System.Int32 value);
        partial void OnYearChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String CourseType
        {
            get
            {
                return _CourseType;
            }
            set
            {
                OnCourseTypeChanging(value);
                ReportPropertyChanging("CourseType");
                _CourseType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CourseType");
                OnCourseTypeChanged();
            }
        }
        private global::System.String _CourseType;
        partial void OnCourseTypeChanging(global::System.String value);
        partial void OnCourseTypeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid HighSchoolId
        {
            get
            {
                return _HighSchoolId;
            }
            set
            {
                OnHighSchoolIdChanging(value);
                ReportPropertyChanging("HighSchoolId");
                _HighSchoolId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HighSchoolId");
                OnHighSchoolIdChanged();
            }
        }
        private global::System.Guid _HighSchoolId;
        partial void OnHighSchoolIdChanging(global::System.Guid value);
        partial void OnHighSchoolIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid ProvinceId
        {
            get
            {
                return _ProvinceId;
            }
            set
            {
                OnProvinceIdChanging(value);
                ReportPropertyChanging("ProvinceId");
                _ProvinceId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProvinceId");
                OnProvinceIdChanged();
            }
        }
        private global::System.Guid _ProvinceId;
        partial void OnProvinceIdChanging(global::System.Guid value);
        partial void OnProvinceIdChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Achievements_HighSchool", "HighSchool")]
        public HighSchool HighSchool
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<HighSchool>("GF.Domain.Context.FK_Achievements_HighSchool", "HighSchool").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<HighSchool>("GF.Domain.Context.FK_Achievements_HighSchool", "HighSchool").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<HighSchool> HighSchoolReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<HighSchool>("GF.Domain.Context.FK_Achievements_HighSchool", "HighSchool");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<HighSchool>("GF.Domain.Context.FK_Achievements_HighSchool", "HighSchool", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Achievements_Users", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_Achievements_Users", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_Achievements_Users", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_Achievements_Users", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("GF.Domain.Context.FK_Achievements_Users", "User", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Achievements_Regions", "Region")]
        public Region Region
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_Achievements_Regions", "Region").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_Achievements_Regions", "Region").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Region> RegionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_Achievements_Regions", "Region");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Region>("GF.Domain.Context.FK_Achievements_Regions", "Region", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "Application")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class Application : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new Application object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        /// <param name="batch">Initial value of the Batch property.</param>
        /// <param name="applicationSequence">Initial value of the ApplicationSequence property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="specialityId">Initial value of the SpecialityId property.</param>
        /// <param name="isAccepted">Initial value of the IsAccepted property.</param>
        /// <param name="applyTime">Initial value of the ApplyTime property.</param>
        /// <param name="universityId">Initial value of the UniversityId property.</param>
        public static Application CreateApplication(global::System.Guid id, global::System.Int32 year, global::System.String batch, global::System.Int32 applicationSequence, global::System.Guid userId, global::System.Guid specialityId, global::System.Boolean isAccepted, global::System.DateTime applyTime, global::System.Guid universityId)
        {
            Application application = new Application();
            application.Id = id;
            application.Year = year;
            application.Batch = batch;
            application.ApplicationSequence = applicationSequence;
            application.UserId = userId;
            application.SpecialityId = specialityId;
            application.IsAccepted = isAccepted;
            application.ApplyTime = applyTime;
            application.UniversityId = universityId;
            return application;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.Int32 _Year;
        partial void OnYearChanging(global::System.Int32 value);
        partial void OnYearChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Batch
        {
            get
            {
                return _Batch;
            }
            set
            {
                OnBatchChanging(value);
                ReportPropertyChanging("Batch");
                _Batch = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Batch");
                OnBatchChanged();
            }
        }
        private global::System.String _Batch;
        partial void OnBatchChanging(global::System.String value);
        partial void OnBatchChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 ApplicationSequence
        {
            get
            {
                return _ApplicationSequence;
            }
            set
            {
                OnApplicationSequenceChanging(value);
                ReportPropertyChanging("ApplicationSequence");
                _ApplicationSequence = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ApplicationSequence");
                OnApplicationSequenceChanged();
            }
        }
        private global::System.Int32 _ApplicationSequence;
        partial void OnApplicationSequenceChanging(global::System.Int32 value);
        partial void OnApplicationSequenceChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid SpecialityId
        {
            get
            {
                return _SpecialityId;
            }
            set
            {
                OnSpecialityIdChanging(value);
                ReportPropertyChanging("SpecialityId");
                _SpecialityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SpecialityId");
                OnSpecialityIdChanged();
            }
        }
        private global::System.Guid _SpecialityId;
        partial void OnSpecialityIdChanging(global::System.Guid value);
        partial void OnSpecialityIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsAccepted
        {
            get
            {
                return _IsAccepted;
            }
            set
            {
                OnIsAcceptedChanging(value);
                ReportPropertyChanging("IsAccepted");
                _IsAccepted = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsAccepted");
                OnIsAcceptedChanged();
            }
        }
        private global::System.Boolean _IsAccepted;
        partial void OnIsAcceptedChanging(global::System.Boolean value);
        partial void OnIsAcceptedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime ApplyTime
        {
            get
            {
                return _ApplyTime;
            }
            set
            {
                OnApplyTimeChanging(value);
                ReportPropertyChanging("ApplyTime");
                _ApplyTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ApplyTime");
                OnApplyTimeChanged();
            }
        }
        private global::System.DateTime _ApplyTime;
        partial void OnApplyTimeChanging(global::System.DateTime value);
        partial void OnApplyTimeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UniversityId
        {
            get
            {
                return _UniversityId;
            }
            set
            {
                OnUniversityIdChanging(value);
                ReportPropertyChanging("UniversityId");
                _UniversityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UniversityId");
                OnUniversityIdChanged();
            }
        }
        private global::System.Guid _UniversityId;
        partial void OnUniversityIdChanging(global::System.Guid value);
        partial void OnUniversityIdChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Applications_Specialities", "Speciality")]
        public Speciality Speciality
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Speciality>("GF.Domain.Context.FK_Applications_Specialities", "Speciality").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Speciality>("GF.Domain.Context.FK_Applications_Specialities", "Speciality").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Speciality> SpecialityReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Speciality>("GF.Domain.Context.FK_Applications_Specialities", "Speciality");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Speciality>("GF.Domain.Context.FK_Applications_Specialities", "Speciality", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Applications_Universities", "University")]
        public University University
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_Applications_Universities", "University").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_Applications_Universities", "University").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<University> UniversityReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_Applications_Universities", "University");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<University>("GF.Domain.Context.FK_Applications_Universities", "University", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Applications_Users", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_Applications_Users", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_Applications_Users", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_Applications_Users", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("GF.Domain.Context.FK_Applications_Users", "User", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "ApplicationStatistic")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class ApplicationStatistic : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new ApplicationStatistic object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="totalQuantity">Initial value of the TotalQuantity property.</param>
        /// <param name="successQuantity">Initial value of the SuccessQuantity property.</param>
        /// <param name="failQuantity">Initial value of the FailQuantity property.</param>
        /// <param name="applicationSequence">Initial value of the ApplicationSequence property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        public static ApplicationStatistic CreateApplicationStatistic(global::System.Int32 id, global::System.Int32 totalQuantity, global::System.Int32 successQuantity, global::System.Int32 failQuantity, global::System.Int32 applicationSequence, global::System.Int32 year)
        {
            ApplicationStatistic applicationStatistic = new ApplicationStatistic();
            applicationStatistic.Id = id;
            applicationStatistic.TotalQuantity = totalQuantity;
            applicationStatistic.SuccessQuantity = successQuantity;
            applicationStatistic.FailQuantity = failQuantity;
            applicationStatistic.ApplicationSequence = applicationSequence;
            applicationStatistic.Year = year;
            return applicationStatistic;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 TotalQuantity
        {
            get
            {
                return _TotalQuantity;
            }
            set
            {
                OnTotalQuantityChanging(value);
                ReportPropertyChanging("TotalQuantity");
                _TotalQuantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("TotalQuantity");
                OnTotalQuantityChanged();
            }
        }
        private global::System.Int32 _TotalQuantity;
        partial void OnTotalQuantityChanging(global::System.Int32 value);
        partial void OnTotalQuantityChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 SuccessQuantity
        {
            get
            {
                return _SuccessQuantity;
            }
            set
            {
                OnSuccessQuantityChanging(value);
                ReportPropertyChanging("SuccessQuantity");
                _SuccessQuantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SuccessQuantity");
                OnSuccessQuantityChanged();
            }
        }
        private global::System.Int32 _SuccessQuantity;
        partial void OnSuccessQuantityChanging(global::System.Int32 value);
        partial void OnSuccessQuantityChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 FailQuantity
        {
            get
            {
                return _FailQuantity;
            }
            set
            {
                OnFailQuantityChanging(value);
                ReportPropertyChanging("FailQuantity");
                _FailQuantity = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("FailQuantity");
                OnFailQuantityChanged();
            }
        }
        private global::System.Int32 _FailQuantity;
        partial void OnFailQuantityChanging(global::System.Int32 value);
        partial void OnFailQuantityChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 ApplicationSequence
        {
            get
            {
                return _ApplicationSequence;
            }
            set
            {
                OnApplicationSequenceChanging(value);
                ReportPropertyChanging("ApplicationSequence");
                _ApplicationSequence = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ApplicationSequence");
                OnApplicationSequenceChanged();
            }
        }
        private global::System.Int32 _ApplicationSequence;
        partial void OnApplicationSequenceChanging(global::System.Int32 value);
        partial void OnApplicationSequenceChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.Int32 _Year;
        partial void OnYearChanging(global::System.Int32 value);
        partial void OnYearChanged();

        #endregion


    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "HighSchool")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class HighSchool : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new HighSchool object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="schoolName">Initial value of the SchoolName property.</param>
        /// <param name="regionId">Initial value of the RegionId property.</param>
        public static HighSchool CreateHighSchool(global::System.Guid id, global::System.String schoolName, global::System.Int32 regionId)
        {
            HighSchool highSchool = new HighSchool();
            highSchool.Id = id;
            highSchool.SchoolName = schoolName;
            highSchool.RegionId = regionId;
            return highSchool;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String SchoolName
        {
            get
            {
                return _SchoolName;
            }
            set
            {
                OnSchoolNameChanging(value);
                ReportPropertyChanging("SchoolName");
                _SchoolName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SchoolName");
                OnSchoolNameChanged();
            }
        }
        private global::System.String _SchoolName;
        partial void OnSchoolNameChanging(global::System.String value);
        partial void OnSchoolNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 RegionId
        {
            get
            {
                return _RegionId;
            }
            set
            {
                OnRegionIdChanging(value);
                ReportPropertyChanging("RegionId");
                _RegionId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RegionId");
                OnRegionIdChanged();
            }
        }
        private global::System.Int32 _RegionId;
        partial void OnRegionIdChanging(global::System.Int32 value);
        partial void OnRegionIdChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Achievements_HighSchool", "Achievement")]
        public EntityCollection<Achievement> Achievements
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Achievement>("GF.Domain.Context.FK_Achievements_HighSchool", "Achievement");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Achievement>("GF.Domain.Context.FK_Achievements_HighSchool", "Achievement", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "IDCard")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class IDCard : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new IDCard object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="chineseName">Initial value of the ChineseName property.</param>
        /// <param name="iDCardNo">Initial value of the IDCardNo property.</param>
        public static IDCard CreateIDCard(global::System.Int32 id, global::System.Guid userId, global::System.String chineseName, global::System.String iDCardNo)
        {
            IDCard iDCard = new IDCard();
            iDCard.Id = id;
            iDCard.UserId = userId;
            iDCard.ChineseName = chineseName;
            iDCard.IDCardNo = iDCardNo;
            return iDCard;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String ChineseName
        {
            get
            {
                return _ChineseName;
            }
            set
            {
                OnChineseNameChanging(value);
                ReportPropertyChanging("ChineseName");
                _ChineseName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ChineseName");
                OnChineseNameChanged();
            }
        }
        private global::System.String _ChineseName;
        partial void OnChineseNameChanging(global::System.String value);
        partial void OnChineseNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String IDCardNo
        {
            get
            {
                return _IDCardNo;
            }
            set
            {
                OnIDCardNoChanging(value);
                ReportPropertyChanging("IDCardNo");
                _IDCardNo = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("IDCardNo");
                OnIDCardNoChanged();
            }
        }
        private global::System.String _IDCardNo;
        partial void OnIDCardNoChanging(global::System.String value);
        partial void OnIDCardNoChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_IDCard_Users", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_IDCard_Users", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_IDCard_Users", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_IDCard_Users", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("GF.Domain.Context.FK_IDCard_Users", "User", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "PayRecord")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class PayRecord : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new PayRecord object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="action">Initial value of the Action property.</param>
        /// <param name="coins">Initial value of the Coins property.</param>
        /// <param name="actionTime">Initial value of the ActionTime property.</param>
        public static PayRecord CreatePayRecord(global::System.Int32 id, global::System.Guid userId, global::System.String action, global::System.Int32 coins, global::System.DateTime actionTime)
        {
            PayRecord payRecord = new PayRecord();
            payRecord.Id = id;
            payRecord.UserId = userId;
            payRecord.Action = action;
            payRecord.Coins = coins;
            payRecord.ActionTime = actionTime;
            return payRecord;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Action
        {
            get
            {
                return _Action;
            }
            set
            {
                OnActionChanging(value);
                ReportPropertyChanging("Action");
                _Action = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Action");
                OnActionChanged();
            }
        }
        private global::System.String _Action;
        partial void OnActionChanging(global::System.String value);
        partial void OnActionChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Coins
        {
            get
            {
                return _Coins;
            }
            set
            {
                OnCoinsChanging(value);
                ReportPropertyChanging("Coins");
                _Coins = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Coins");
                OnCoinsChanged();
            }
        }
        private global::System.Int32 _Coins;
        partial void OnCoinsChanging(global::System.Int32 value);
        partial void OnCoinsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime ActionTime
        {
            get
            {
                return _ActionTime;
            }
            set
            {
                OnActionTimeChanging(value);
                ReportPropertyChanging("ActionTime");
                _ActionTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ActionTime");
                OnActionTimeChanged();
            }
        }
        private global::System.DateTime _ActionTime;
        partial void OnActionTimeChanging(global::System.DateTime value);
        partial void OnActionTimeChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_PayRecords_Users", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_PayRecords_Users", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_PayRecords_Users", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_PayRecords_Users", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("GF.Domain.Context.FK_PayRecords_Users", "User", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "RechargeRecord")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class RechargeRecord : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new RechargeRecord object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="coins">Initial value of the Coins property.</param>
        /// <param name="rechargeTime">Initial value of the RechargeTime property.</param>
        public static RechargeRecord CreateRechargeRecord(global::System.Int32 id, global::System.Guid userId, global::System.Int32 coins, global::System.DateTime rechargeTime)
        {
            RechargeRecord rechargeRecord = new RechargeRecord();
            rechargeRecord.Id = id;
            rechargeRecord.UserId = userId;
            rechargeRecord.Coins = coins;
            rechargeRecord.RechargeTime = rechargeTime;
            return rechargeRecord;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Coins
        {
            get
            {
                return _Coins;
            }
            set
            {
                OnCoinsChanging(value);
                ReportPropertyChanging("Coins");
                _Coins = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Coins");
                OnCoinsChanged();
            }
        }
        private global::System.Int32 _Coins;
        partial void OnCoinsChanging(global::System.Int32 value);
        partial void OnCoinsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime RechargeTime
        {
            get
            {
                return _RechargeTime;
            }
            set
            {
                OnRechargeTimeChanging(value);
                ReportPropertyChanging("RechargeTime");
                _RechargeTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RechargeTime");
                OnRechargeTimeChanged();
            }
        }
        private global::System.DateTime _RechargeTime;
        partial void OnRechargeTimeChanging(global::System.DateTime value);
        partial void OnRechargeTimeChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_RechargeRecords_Users", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_RechargeRecords_Users", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_RechargeRecords_Users", "User").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<User>("GF.Domain.Context.FK_RechargeRecords_Users", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<User>("GF.Domain.Context.FK_RechargeRecords_Users", "User", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "Region")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class Region : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new Region object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="gbcode">Initial value of the Gbcode property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="class">Initial value of the Class property.</param>
        public static Region CreateRegion(global::System.Guid id, global::System.Int32 gbcode, global::System.String name, global::System.Int32 @class)
        {
            Region region = new Region();
            region.Id = id;
            region.Gbcode = gbcode;
            region.Name = name;
            region.Class = @class;
            return region;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Gbcode
        {
            get
            {
                return _Gbcode;
            }
            set
            {
                OnGbcodeChanging(value);
                ReportPropertyChanging("Gbcode");
                _Gbcode = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Gbcode");
                OnGbcodeChanged();
            }
        }
        private global::System.Int32 _Gbcode;
        partial void OnGbcodeChanging(global::System.Int32 value);
        partial void OnGbcodeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Class
        {
            get
            {
                return _Class;
            }
            set
            {
                OnClassChanging(value);
                ReportPropertyChanging("Class");
                _Class = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Class");
                OnClassChanged();
            }
        }
        private global::System.Int32 _Class;
        partial void OnClassChanging(global::System.Int32 value);
        partial void OnClassChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_ScorePublishes_Regions", "ScorePublish")]
        public EntityCollection<ScorePublish> ScorePublishes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<ScorePublish>("GF.Domain.Context.FK_ScorePublishes_Regions", "ScorePublish");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<ScorePublish>("GF.Domain.Context.FK_ScorePublishes_Regions", "ScorePublish", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityAcceptanceStatistics_Regions", "UniversityAcceptanceStatistic")]
        public EntityCollection<UniversityAcceptanceStatistic> UniversityAcceptanceStatistics
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UniversityAcceptanceStatistic>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Regions", "UniversityAcceptanceStatistic");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UniversityAcceptanceStatistic>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Regions", "UniversityAcceptanceStatistic", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityEnrollPlans_Regions", "UniversityEnrollPlan")]
        public EntityCollection<UniversityEnrollPlan> UniversityEnrollPlans
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UniversityEnrollPlan>("GF.Domain.Context.FK_UniversityEnrollPlans_Regions", "UniversityEnrollPlan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UniversityEnrollPlan>("GF.Domain.Context.FK_UniversityEnrollPlans_Regions", "UniversityEnrollPlan", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Achievements_Regions", "Achievement")]
        public EntityCollection<Achievement> Achievements
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Achievement>("GF.Domain.Context.FK_Achievements_Regions", "Achievement");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Achievement>("GF.Domain.Context.FK_Achievements_Regions", "Achievement", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Universities_Regions", "University")]
        public EntityCollection<University> Universities
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<University>("GF.Domain.Context.FK_Universities_Regions", "University");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<University>("GF.Domain.Context.FK_Universities_Regions", "University", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "Role")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class Role : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new Role object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Role CreateRole(global::System.Guid id, global::System.String name)
        {
            Role role = new Role();
            role.Id = id;
            role.Name = name;
            return role;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Users_Roles", "User")]
        public EntityCollection<User> Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<User>("GF.Domain.Context.FK_Users_Roles", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<User>("GF.Domain.Context.FK_Users_Roles", "User", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "ScorePublish")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class ScorePublish : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new ScorePublish object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="provinceId">Initial value of the ProvinceId property.</param>
        /// <param name="publishDate">Initial value of the PublishDate property.</param>
        public static ScorePublish CreateScorePublish(global::System.Int32 id, global::System.Guid provinceId, global::System.DateTime publishDate)
        {
            ScorePublish scorePublish = new ScorePublish();
            scorePublish.Id = id;
            scorePublish.ProvinceId = provinceId;
            scorePublish.PublishDate = publishDate;
            return scorePublish;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid ProvinceId
        {
            get
            {
                return _ProvinceId;
            }
            set
            {
                OnProvinceIdChanging(value);
                ReportPropertyChanging("ProvinceId");
                _ProvinceId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProvinceId");
                OnProvinceIdChanged();
            }
        }
        private global::System.Guid _ProvinceId;
        partial void OnProvinceIdChanging(global::System.Guid value);
        partial void OnProvinceIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime PublishDate
        {
            get
            {
                return _PublishDate;
            }
            set
            {
                OnPublishDateChanging(value);
                ReportPropertyChanging("PublishDate");
                _PublishDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PublishDate");
                OnPublishDateChanged();
            }
        }
        private global::System.DateTime _PublishDate;
        partial void OnPublishDateChanging(global::System.DateTime value);
        partial void OnPublishDateChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_ScorePublishes_Regions", "Region")]
        public Region Region
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_ScorePublishes_Regions", "Region").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_ScorePublishes_Regions", "Region").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Region> RegionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_ScorePublishes_Regions", "Region");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Region>("GF.Domain.Context.FK_ScorePublishes_Regions", "Region", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "Speciality")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class Speciality : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new Speciality object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="category">Initial value of the Category property.</param>
        public static Speciality CreateSpeciality(global::System.Guid id, global::System.String name, global::System.String category)
        {
            Speciality speciality = new Speciality();
            speciality.Id = id;
            speciality.Name = name;
            speciality.Category = category;
            return speciality;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Category
        {
            get
            {
                return _Category;
            }
            set
            {
                OnCategoryChanging(value);
                ReportPropertyChanging("Category");
                _Category = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Category");
                OnCategoryChanged();
            }
        }
        private global::System.String _Category;
        partial void OnCategoryChanging(global::System.String value);
        partial void OnCategoryChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String SpecialityCode
        {
            get
            {
                return _SpecialityCode;
            }
            set
            {
                OnSpecialityCodeChanging(value);
                ReportPropertyChanging("SpecialityCode");
                _SpecialityCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SpecialityCode");
                OnSpecialityCodeChanged();
            }
        }
        private global::System.String _SpecialityCode;
        partial void OnSpecialityCodeChanging(global::System.String value);
        partial void OnSpecialityCodeChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Applications_Specialities", "Application")]
        public EntityCollection<Application> Applications
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Application>("GF.Domain.Context.FK_Applications_Specialities", "Application");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Application>("GF.Domain.Context.FK_Applications_Specialities", "Application", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_SpecialityAcceptanceStatistics_Specialities", "SpecialityAcceptanceStatistic")]
        public EntityCollection<SpecialityAcceptanceStatistic> SpecialityAcceptanceStatistics
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SpecialityAcceptanceStatistic>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_Specialities", "SpecialityAcceptanceStatistic");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SpecialityAcceptanceStatistic>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_Specialities", "SpecialityAcceptanceStatistic", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityEnrollPlans_Specialities", "UniversityEnrollPlan")]
        public EntityCollection<UniversityEnrollPlan> UniversityEnrollPlans
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UniversityEnrollPlan>("GF.Domain.Context.FK_UniversityEnrollPlans_Specialities", "UniversityEnrollPlan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UniversityEnrollPlan>("GF.Domain.Context.FK_UniversityEnrollPlans_Specialities", "UniversityEnrollPlan", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "SpecialityAcceptanceStatistic")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class SpecialityAcceptanceStatistic : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new SpecialityAcceptanceStatistic object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="highestScore">Initial value of the HighestScore property.</param>
        /// <param name="lowestScore">Initial value of the LowestScore property.</param>
        /// <param name="averageScore">Initial value of the AverageScore property.</param>
        /// <param name="specialityId">Initial value of the SpecialityId property.</param>
        /// <param name="plannedEnrollNumber">Initial value of the PlannedEnrollNumber property.</param>
        /// <param name="realEnrollNumber">Initial value of the RealEnrollNumber property.</param>
        /// <param name="batch">Initial value of the Batch property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        /// <param name="universityAcceptanceStatisticsId">Initial value of the UniversityAcceptanceStatisticsId property.</param>
        public static SpecialityAcceptanceStatistic CreateSpecialityAcceptanceStatistic(global::System.Int32 id, global::System.Double highestScore, global::System.Double lowestScore, global::System.Double averageScore, global::System.Guid specialityId, global::System.Int32 plannedEnrollNumber, global::System.Int32 realEnrollNumber, global::System.String batch, global::System.Int32 year, global::System.Int32 universityAcceptanceStatisticsId)
        {
            SpecialityAcceptanceStatistic specialityAcceptanceStatistic = new SpecialityAcceptanceStatistic();
            specialityAcceptanceStatistic.Id = id;
            specialityAcceptanceStatistic.HighestScore = highestScore;
            specialityAcceptanceStatistic.LowestScore = lowestScore;
            specialityAcceptanceStatistic.AverageScore = averageScore;
            specialityAcceptanceStatistic.SpecialityId = specialityId;
            specialityAcceptanceStatistic.PlannedEnrollNumber = plannedEnrollNumber;
            specialityAcceptanceStatistic.RealEnrollNumber = realEnrollNumber;
            specialityAcceptanceStatistic.Batch = batch;
            specialityAcceptanceStatistic.Year = year;
            specialityAcceptanceStatistic.UniversityAcceptanceStatisticsId = universityAcceptanceStatisticsId;
            return specialityAcceptanceStatistic;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Double HighestScore
        {
            get
            {
                return _HighestScore;
            }
            set
            {
                OnHighestScoreChanging(value);
                ReportPropertyChanging("HighestScore");
                _HighestScore = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HighestScore");
                OnHighestScoreChanged();
            }
        }
        private global::System.Double _HighestScore;
        partial void OnHighestScoreChanging(global::System.Double value);
        partial void OnHighestScoreChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Double LowestScore
        {
            get
            {
                return _LowestScore;
            }
            set
            {
                OnLowestScoreChanging(value);
                ReportPropertyChanging("LowestScore");
                _LowestScore = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LowestScore");
                OnLowestScoreChanged();
            }
        }
        private global::System.Double _LowestScore;
        partial void OnLowestScoreChanging(global::System.Double value);
        partial void OnLowestScoreChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Double AverageScore
        {
            get
            {
                return _AverageScore;
            }
            set
            {
                OnAverageScoreChanging(value);
                ReportPropertyChanging("AverageScore");
                _AverageScore = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AverageScore");
                OnAverageScoreChanged();
            }
        }
        private global::System.Double _AverageScore;
        partial void OnAverageScoreChanging(global::System.Double value);
        partial void OnAverageScoreChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid SpecialityId
        {
            get
            {
                return _SpecialityId;
            }
            set
            {
                OnSpecialityIdChanging(value);
                ReportPropertyChanging("SpecialityId");
                _SpecialityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SpecialityId");
                OnSpecialityIdChanged();
            }
        }
        private global::System.Guid _SpecialityId;
        partial void OnSpecialityIdChanging(global::System.Guid value);
        partial void OnSpecialityIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 PlannedEnrollNumber
        {
            get
            {
                return _PlannedEnrollNumber;
            }
            set
            {
                OnPlannedEnrollNumberChanging(value);
                ReportPropertyChanging("PlannedEnrollNumber");
                _PlannedEnrollNumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PlannedEnrollNumber");
                OnPlannedEnrollNumberChanged();
            }
        }
        private global::System.Int32 _PlannedEnrollNumber;
        partial void OnPlannedEnrollNumberChanging(global::System.Int32 value);
        partial void OnPlannedEnrollNumberChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 RealEnrollNumber
        {
            get
            {
                return _RealEnrollNumber;
            }
            set
            {
                OnRealEnrollNumberChanging(value);
                ReportPropertyChanging("RealEnrollNumber");
                _RealEnrollNumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RealEnrollNumber");
                OnRealEnrollNumberChanged();
            }
        }
        private global::System.Int32 _RealEnrollNumber;
        partial void OnRealEnrollNumberChanging(global::System.Int32 value);
        partial void OnRealEnrollNumberChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Batch
        {
            get
            {
                return _Batch;
            }
            set
            {
                OnBatchChanging(value);
                ReportPropertyChanging("Batch");
                _Batch = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Batch");
                OnBatchChanged();
            }
        }
        private global::System.String _Batch;
        partial void OnBatchChanging(global::System.String value);
        partial void OnBatchChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.Int32 _Year;
        partial void OnYearChanging(global::System.Int32 value);
        partial void OnYearChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 UniversityAcceptanceStatisticsId
        {
            get
            {
                return _UniversityAcceptanceStatisticsId;
            }
            set
            {
                OnUniversityAcceptanceStatisticsIdChanging(value);
                ReportPropertyChanging("UniversityAcceptanceStatisticsId");
                _UniversityAcceptanceStatisticsId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UniversityAcceptanceStatisticsId");
                OnUniversityAcceptanceStatisticsIdChanged();
            }
        }
        private global::System.Int32 _UniversityAcceptanceStatisticsId;
        partial void OnUniversityAcceptanceStatisticsIdChanging(global::System.Int32 value);
        partial void OnUniversityAcceptanceStatisticsIdChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_SpecialityAcceptanceStatistics_Specialities", "Speciality")]
        public Speciality Speciality
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Speciality>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_Specialities", "Speciality").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Speciality>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_Specialities", "Speciality").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Speciality> SpecialityReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Speciality>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_Specialities", "Speciality");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Speciality>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_Specialities", "Speciality", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics", "UniversityAcceptanceStatistic")]
        public UniversityAcceptanceStatistic UniversityAcceptanceStatistic
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UniversityAcceptanceStatistic>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics", "UniversityAcceptanceStatistic").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UniversityAcceptanceStatistic>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics", "UniversityAcceptanceStatistic").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<UniversityAcceptanceStatistic> UniversityAcceptanceStatisticReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<UniversityAcceptanceStatistic>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics", "UniversityAcceptanceStatistic");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<UniversityAcceptanceStatistic>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics", "UniversityAcceptanceStatistic", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "University")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class University : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new University object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        /// <param name="universityType">Initial value of the UniversityType property.</param>
        /// <param name="subjection">Initial value of the Subjection property.</param>
        /// <param name="educationLevel">Initial value of the EducationLevel property.</param>
        /// <param name="schoolType">Initial value of the SchoolType property.</param>
        /// <param name="is985">Initial value of the Is985 property.</param>
        /// <param name="is211">Initial value of the Is211 property.</param>
        /// <param name="isNational">Initial value of the IsNational property.</param>
        /// <param name="provinceId">Initial value of the ProvinceId property.</param>
        public static University CreateUniversity(global::System.Guid id, global::System.String name, global::System.String universityType, global::System.String subjection, global::System.String educationLevel, global::System.String schoolType, global::System.Boolean is985, global::System.Boolean is211, global::System.Boolean isNational, global::System.Guid provinceId)
        {
            University university = new University();
            university.Id = id;
            university.Name = name;
            university.UniversityType = universityType;
            university.Subjection = subjection;
            university.EducationLevel = educationLevel;
            university.SchoolType = schoolType;
            university.Is985 = is985;
            university.Is211 = is211;
            university.IsNational = isNational;
            university.ProvinceId = provinceId;
            return university;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        [Display(Name = "院校名称")]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        [Display(Name="院校类型")]
        public global::System.String UniversityType
        {
            get
            {
                return _UniversityType;
            }
            set
            {
                OnUniversityTypeChanging(value);
                ReportPropertyChanging("UniversityType");
                _UniversityType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UniversityType");
                OnUniversityTypeChanged();
            }
        }
        private global::System.String _UniversityType;
        partial void OnUniversityTypeChanging(global::System.String value);
        partial void OnUniversityTypeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        [Display(Name="院校隶属")]
        public global::System.String Subjection
        {
            get
            {
                return _Subjection;
            }
            set
            {
                OnSubjectionChanging(value);
                ReportPropertyChanging("Subjection");
                _Subjection = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Subjection");
                OnSubjectionChanged();
            }
        }
        private global::System.String _Subjection;
        partial void OnSubjectionChanging(global::System.String value);
        partial void OnSubjectionChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        [Display(Name="学历层次")]
        public global::System.String EducationLevel
        {
            get
            {
                return _EducationLevel;
            }
            set
            {
                OnEducationLevelChanging(value);
                ReportPropertyChanging("EducationLevel");
                _EducationLevel = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("EducationLevel");
                OnEducationLevelChanged();
            }
        }
        private global::System.String _EducationLevel;
        partial void OnEducationLevelChanging(global::System.String value);
        partial void OnEducationLevelChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        [Display(Name="办学类型")]
        public global::System.String SchoolType
        {
            get
            {
                return _SchoolType;
            }
            set
            {
                OnSchoolTypeChanging(value);
                ReportPropertyChanging("SchoolType");
                _SchoolType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SchoolType");
                OnSchoolTypeChanged();
            }
        }
        private global::System.String _SchoolType;
        partial void OnSchoolTypeChanging(global::System.String value);
        partial void OnSchoolTypeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        [Display(Name="985")]
        public global::System.Boolean Is985
        {
            get
            {
                return _Is985;
            }
            set
            {
                OnIs985Changing(value);
                ReportPropertyChanging("Is985");
                _Is985 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Is985");
                OnIs985Changed();
            }
        }
        private global::System.Boolean _Is985;
        partial void OnIs985Changing(global::System.Boolean value);
        partial void OnIs985Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        [Display(Name="211")]
        public global::System.Boolean Is211
        {
            get
            {
                return _Is211;
            }
            set
            {
                OnIs211Changing(value);
                ReportPropertyChanging("Is211");
                _Is211 = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Is211");
                OnIs211Changed();
            }
        }
        private global::System.Boolean _Is211;
        partial void OnIs211Changing(global::System.Boolean value);
        partial void OnIs211Changed();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        [Display(Name="院校举办者")]
        public global::System.Boolean IsNational
        {
            get
            {
                return _IsNational;
            }
            set
            {
                OnIsNationalChanging(value);
                ReportPropertyChanging("IsNational");
                _IsNational = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsNational");
                OnIsNationalChanged();
            }
        }
        private global::System.Boolean _IsNational;
        partial void OnIsNationalChanging(global::System.Boolean value);
        partial void OnIsNationalChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String UniversityCode
        {
            get
            {
                return _UniversityCode;
            }
            set
            {
                OnUniversityCodeChanging(value);
                ReportPropertyChanging("UniversityCode");
                _UniversityCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("UniversityCode");
                OnUniversityCodeChanged();
            }
        }
        private global::System.String _UniversityCode;
        partial void OnUniversityCodeChanging(global::System.String value);
        partial void OnUniversityCodeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid ProvinceId
        {
            get
            {
                return _ProvinceId;
            }
            set
            {
                OnProvinceIdChanging(value);
                ReportPropertyChanging("ProvinceId");
                _ProvinceId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProvinceId");
                OnProvinceIdChanged();
            }
        }
        private global::System.Guid _ProvinceId;
        partial void OnProvinceIdChanging(global::System.Guid value);
        partial void OnProvinceIdChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Users_Universities", "User")]
        public EntityCollection<User> Users
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<User>("GF.Domain.Context.FK_Users_Universities", "User");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<User>("GF.Domain.Context.FK_Users_Universities", "User", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Applications_Universities", "Application")]
        public EntityCollection<Application> Applications
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Application>("GF.Domain.Context.FK_Applications_Universities", "Application");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Application>("GF.Domain.Context.FK_Applications_Universities", "Application", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityAcceptanceStatistics_Universities", "UniversityAcceptanceStatistic")]
        public EntityCollection<UniversityAcceptanceStatistic> UniversityAcceptanceStatistics
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UniversityAcceptanceStatistic>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Universities", "UniversityAcceptanceStatistic");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UniversityAcceptanceStatistic>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Universities", "UniversityAcceptanceStatistic", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityEnrollPlans_Universities", "UniversityEnrollPlan")]
        public EntityCollection<UniversityEnrollPlan> UniversityEnrollPlans
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<UniversityEnrollPlan>("GF.Domain.Context.FK_UniversityEnrollPlans_Universities", "UniversityEnrollPlan");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<UniversityEnrollPlan>("GF.Domain.Context.FK_UniversityEnrollPlans_Universities", "UniversityEnrollPlan", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Universities_Regions", "Region")]
        public Region Region
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_Universities_Regions", "Region").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_Universities_Regions", "Region").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Region> RegionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_Universities_Regions", "Region");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Region>("GF.Domain.Context.FK_Universities_Regions", "Region", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "UniversityAcceptanceStatistic")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class UniversityAcceptanceStatistic : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new UniversityAcceptanceStatistic object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        /// <param name="highestScore">Initial value of the HighestScore property.</param>
        /// <param name="lowestScore">Initial value of the LowestScore property.</param>
        /// <param name="averageScore">Initial value of the AverageScore property.</param>
        /// <param name="batch">Initial value of the Batch property.</param>
        /// <param name="universityId">Initial value of the UniversityId property.</param>
        /// <param name="provinceId">Initial value of the ProvinceId property.</param>
        /// <param name="acceptNumber">Initial value of the AcceptNumber property.</param>
        public static UniversityAcceptanceStatistic CreateUniversityAcceptanceStatistic(global::System.Int32 id, global::System.Int32 year, global::System.Double highestScore, global::System.Double lowestScore, global::System.Double averageScore, global::System.String batch, global::System.Guid universityId, global::System.Guid provinceId, global::System.Int32 acceptNumber)
        {
            UniversityAcceptanceStatistic universityAcceptanceStatistic = new UniversityAcceptanceStatistic();
            universityAcceptanceStatistic.Id = id;
            universityAcceptanceStatistic.Year = year;
            universityAcceptanceStatistic.HighestScore = highestScore;
            universityAcceptanceStatistic.LowestScore = lowestScore;
            universityAcceptanceStatistic.AverageScore = averageScore;
            universityAcceptanceStatistic.Batch = batch;
            universityAcceptanceStatistic.UniversityId = universityId;
            universityAcceptanceStatistic.ProvinceId = provinceId;
            universityAcceptanceStatistic.AcceptNumber = acceptNumber;
            return universityAcceptanceStatistic;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.Int32 _Year;
        partial void OnYearChanging(global::System.Int32 value);
        partial void OnYearChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Double HighestScore
        {
            get
            {
                return _HighestScore;
            }
            set
            {
                OnHighestScoreChanging(value);
                ReportPropertyChanging("HighestScore");
                _HighestScore = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("HighestScore");
                OnHighestScoreChanged();
            }
        }
        private global::System.Double _HighestScore;
        partial void OnHighestScoreChanging(global::System.Double value);
        partial void OnHighestScoreChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Double LowestScore
        {
            get
            {
                return _LowestScore;
            }
            set
            {
                OnLowestScoreChanging(value);
                ReportPropertyChanging("LowestScore");
                _LowestScore = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LowestScore");
                OnLowestScoreChanged();
            }
        }
        private global::System.Double _LowestScore;
        partial void OnLowestScoreChanging(global::System.Double value);
        partial void OnLowestScoreChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Double AverageScore
        {
            get
            {
                return _AverageScore;
            }
            set
            {
                OnAverageScoreChanging(value);
                ReportPropertyChanging("AverageScore");
                _AverageScore = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AverageScore");
                OnAverageScoreChanged();
            }
        }
        private global::System.Double _AverageScore;
        partial void OnAverageScoreChanging(global::System.Double value);
        partial void OnAverageScoreChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Batch
        {
            get
            {
                return _Batch;
            }
            set
            {
                OnBatchChanging(value);
                ReportPropertyChanging("Batch");
                _Batch = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Batch");
                OnBatchChanged();
            }
        }
        private global::System.String _Batch;
        partial void OnBatchChanging(global::System.String value);
        partial void OnBatchChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UniversityId
        {
            get
            {
                return _UniversityId;
            }
            set
            {
                OnUniversityIdChanging(value);
                ReportPropertyChanging("UniversityId");
                _UniversityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UniversityId");
                OnUniversityIdChanged();
            }
        }
        private global::System.Guid _UniversityId;
        partial void OnUniversityIdChanging(global::System.Guid value);
        partial void OnUniversityIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid ProvinceId
        {
            get
            {
                return _ProvinceId;
            }
            set
            {
                OnProvinceIdChanging(value);
                ReportPropertyChanging("ProvinceId");
                _ProvinceId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProvinceId");
                OnProvinceIdChanged();
            }
        }
        private global::System.Guid _ProvinceId;
        partial void OnProvinceIdChanging(global::System.Guid value);
        partial void OnProvinceIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 AcceptNumber
        {
            get
            {
                return _AcceptNumber;
            }
            set
            {
                OnAcceptNumberChanging(value);
                ReportPropertyChanging("AcceptNumber");
                _AcceptNumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AcceptNumber");
                OnAcceptNumberChanged();
            }
        }
        private global::System.Int32 _AcceptNumber;
        partial void OnAcceptNumberChanging(global::System.Int32 value);
        partial void OnAcceptNumberChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityAcceptanceStatistics_Regions", "Region")]
        public Region Region
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Regions", "Region").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Regions", "Region").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Region> RegionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Regions", "Region");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Region>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Regions", "Region", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics", "SpecialityAcceptanceStatistic")]
        public EntityCollection<SpecialityAcceptanceStatistic> SpecialityAcceptanceStatistics
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SpecialityAcceptanceStatistic>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics", "SpecialityAcceptanceStatistic");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SpecialityAcceptanceStatistic>("GF.Domain.Context.FK_SpecialityAcceptanceStatistics_UniversityAcceptanceStatistics", "SpecialityAcceptanceStatistic", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityAcceptanceStatistics_Universities", "University")]
        public University University
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Universities", "University").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Universities", "University").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<University> UniversityReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Universities", "University");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<University>("GF.Domain.Context.FK_UniversityAcceptanceStatistics_Universities", "University", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "UniversityEnrollPlan")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class UniversityEnrollPlan : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new UniversityEnrollPlan object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="plannedNumber">Initial value of the PlannedNumber property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        /// <param name="provinceId">Initial value of the ProvinceId property.</param>
        /// <param name="batch">Initial value of the Batch property.</param>
        /// <param name="planCategory">Initial value of the PlanCategory property.</param>
        /// <param name="universityId">Initial value of the UniversityId property.</param>
        /// <param name="specialityId">Initial value of the SpecialityId property.</param>
        /// <param name="courseType">Initial value of the CourseType property.</param>
        /// <param name="studyYears">Initial value of the StudyYears property.</param>
        public static UniversityEnrollPlan CreateUniversityEnrollPlan(global::System.Int32 id, global::System.Int32 plannedNumber, global::System.Int32 year, global::System.Guid provinceId, global::System.String batch, global::System.String planCategory, global::System.Guid universityId, global::System.Guid specialityId, global::System.String courseType, global::System.Int32 studyYears)
        {
            UniversityEnrollPlan universityEnrollPlan = new UniversityEnrollPlan();
            universityEnrollPlan.Id = id;
            universityEnrollPlan.PlannedNumber = plannedNumber;
            universityEnrollPlan.Year = year;
            universityEnrollPlan.ProvinceId = provinceId;
            universityEnrollPlan.Batch = batch;
            universityEnrollPlan.PlanCategory = planCategory;
            universityEnrollPlan.UniversityId = universityId;
            universityEnrollPlan.SpecialityId = specialityId;
            universityEnrollPlan.CourseType = courseType;
            universityEnrollPlan.StudyYears = studyYears;
            return universityEnrollPlan;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 PlannedNumber
        {
            get
            {
                return _PlannedNumber;
            }
            set
            {
                OnPlannedNumberChanging(value);
                ReportPropertyChanging("PlannedNumber");
                _PlannedNumber = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PlannedNumber");
                OnPlannedNumberChanged();
            }
        }
        private global::System.Int32 _PlannedNumber;
        partial void OnPlannedNumberChanging(global::System.Int32 value);
        partial void OnPlannedNumberChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.Int32 _Year;
        partial void OnYearChanging(global::System.Int32 value);
        partial void OnYearChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid ProvinceId
        {
            get
            {
                return _ProvinceId;
            }
            set
            {
                OnProvinceIdChanging(value);
                ReportPropertyChanging("ProvinceId");
                _ProvinceId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ProvinceId");
                OnProvinceIdChanged();
            }
        }
        private global::System.Guid _ProvinceId;
        partial void OnProvinceIdChanging(global::System.Guid value);
        partial void OnProvinceIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Batch
        {
            get
            {
                return _Batch;
            }
            set
            {
                OnBatchChanging(value);
                ReportPropertyChanging("Batch");
                _Batch = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Batch");
                OnBatchChanged();
            }
        }
        private global::System.String _Batch;
        partial void OnBatchChanging(global::System.String value);
        partial void OnBatchChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String PlanCategory
        {
            get
            {
                return _PlanCategory;
            }
            set
            {
                OnPlanCategoryChanging(value);
                ReportPropertyChanging("PlanCategory");
                _PlanCategory = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("PlanCategory");
                OnPlanCategoryChanged();
            }
        }
        private global::System.String _PlanCategory;
        partial void OnPlanCategoryChanging(global::System.String value);
        partial void OnPlanCategoryChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UniversityId
        {
            get
            {
                return _UniversityId;
            }
            set
            {
                OnUniversityIdChanging(value);
                ReportPropertyChanging("UniversityId");
                _UniversityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UniversityId");
                OnUniversityIdChanged();
            }
        }
        private global::System.Guid _UniversityId;
        partial void OnUniversityIdChanging(global::System.Guid value);
        partial void OnUniversityIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid SpecialityId
        {
            get
            {
                return _SpecialityId;
            }
            set
            {
                OnSpecialityIdChanging(value);
                ReportPropertyChanging("SpecialityId");
                _SpecialityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SpecialityId");
                OnSpecialityIdChanged();
            }
        }
        private global::System.Guid _SpecialityId;
        partial void OnSpecialityIdChanging(global::System.Guid value);
        partial void OnSpecialityIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String CourseType
        {
            get
            {
                return _CourseType;
            }
            set
            {
                OnCourseTypeChanging(value);
                ReportPropertyChanging("CourseType");
                _CourseType = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CourseType");
                OnCourseTypeChanged();
            }
        }
        private global::System.String _CourseType;
        partial void OnCourseTypeChanging(global::System.String value);
        partial void OnCourseTypeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 StudyYears
        {
            get
            {
                return _StudyYears;
            }
            set
            {
                OnStudyYearsChanging(value);
                ReportPropertyChanging("StudyYears");
                _StudyYears = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("StudyYears");
                OnStudyYearsChanged();
            }
        }
        private global::System.Int32 _StudyYears;
        partial void OnStudyYearsChanging(global::System.Int32 value);
        partial void OnStudyYearsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String Remarks
        {
            get
            {
                return _Remarks;
            }
            set
            {
                OnRemarksChanging(value);
                ReportPropertyChanging("Remarks");
                _Remarks = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Remarks");
                OnRemarksChanged();
            }
        }
        private global::System.String _Remarks;
        partial void OnRemarksChanging(global::System.String value);
        partial void OnRemarksChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityEnrollPlans_Regions", "Region")]
        public Region Region
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_UniversityEnrollPlans_Regions", "Region").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_UniversityEnrollPlans_Regions", "Region").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Region> RegionReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Region>("GF.Domain.Context.FK_UniversityEnrollPlans_Regions", "Region");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Region>("GF.Domain.Context.FK_UniversityEnrollPlans_Regions", "Region", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityEnrollPlans_Specialities", "Speciality")]
        public Speciality Speciality
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Speciality>("GF.Domain.Context.FK_UniversityEnrollPlans_Specialities", "Speciality").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Speciality>("GF.Domain.Context.FK_UniversityEnrollPlans_Specialities", "Speciality").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Speciality> SpecialityReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Speciality>("GF.Domain.Context.FK_UniversityEnrollPlans_Specialities", "Speciality");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Speciality>("GF.Domain.Context.FK_UniversityEnrollPlans_Specialities", "Speciality", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_UniversityEnrollPlans_Universities", "University")]
        public University University
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_UniversityEnrollPlans_Universities", "University").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_UniversityEnrollPlans_Universities", "University").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<University> UniversityReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_UniversityEnrollPlans_Universities", "University");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<University>("GF.Domain.Context.FK_UniversityEnrollPlans_Universities", "University", value);
                }
            }
        }

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "User")]
    [Serializable()]
    [DataContractAttribute(IsReference = true)]
    public partial class User : EntityObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="password">Initial value of the Password property.</param>
        /// <param name="email">Initial value of the Email property.</param>
        /// <param name="coins">Initial value of the Coins property.</param>
        /// <param name="isLocked">Initial value of the IsLocked property.</param>
        /// <param name="gender">Initial value of the Gender property.</param>
        /// <param name="isIDCardValid">Initial value of the IsIDCardValid property.</param>
        /// <param name="lastActivityDate">Initial value of the LastActivityDate property.</param>
        /// <param name="roleId">Initial value of the RoleId property.</param>
        public static User CreateUser(global::System.Guid id, global::System.String userName, global::System.String password, global::System.String email, global::System.Int32 coins, global::System.Boolean isLocked, global::System.Boolean gender, global::System.Boolean isIDCardValid, global::System.DateTime lastActivityDate, global::System.Guid roleId)
        {
            User user = new User();
            user.Id = id;
            user.UserName = userName;
            user.Password = password;
            user.Email = email;
            user.Coins = coins;
            user.IsLocked = isLocked;
            user.Gender = gender;
            user.IsIDCardValid = isIDCardValid;
            user.LastActivityDate = lastActivityDate;
            user.RoleId = roleId;
            return user;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = true, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Password
        {
            get
            {
                return _Password;
            }
            set
            {
                OnPasswordChanging(value);
                ReportPropertyChanging("Password");
                _Password = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Password");
                OnPasswordChanged();
            }
        }
        private global::System.String _Password;
        partial void OnPasswordChanging(global::System.String value);
        partial void OnPasswordChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String QQ
        {
            get
            {
                return _QQ;
            }
            set
            {
                OnQQChanging(value);
                ReportPropertyChanging("QQ");
                _QQ = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("QQ");
                OnQQChanged();
            }
        }
        private global::System.String _QQ;
        partial void OnQQChanging(global::System.String value);
        partial void OnQQChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Coins
        {
            get
            {
                return _Coins;
            }
            set
            {
                OnCoinsChanging(value);
                ReportPropertyChanging("Coins");
                _Coins = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Coins");
                OnCoinsChanged();
            }
        }
        private global::System.Int32 _Coins;
        partial void OnCoinsChanging(global::System.Int32 value);
        partial void OnCoinsChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsLocked
        {
            get
            {
                return _IsLocked;
            }
            set
            {
                OnIsLockedChanging(value);
                ReportPropertyChanging("IsLocked");
                _IsLocked = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsLocked");
                OnIsLockedChanged();
            }
        }
        private global::System.Boolean _IsLocked;
        partial void OnIsLockedChanging(global::System.Boolean value);
        partial void OnIsLockedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String IDCardNo
        {
            get
            {
                return _IDCardNo;
            }
            set
            {
                OnIDCardNoChanging(value);
                ReportPropertyChanging("IDCardNo");
                _IDCardNo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("IDCardNo");
                OnIDCardNoChanged();
            }
        }
        private global::System.String _IDCardNo;
        partial void OnIDCardNoChanging(global::System.String value);
        partial void OnIDCardNoChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public global::System.String ChineseName
        {
            get
            {
                return _ChineseName;
            }
            set
            {
                OnChineseNameChanging(value);
                ReportPropertyChanging("ChineseName");
                _ChineseName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ChineseName");
                OnChineseNameChanged();
            }
        }
        private global::System.String _ChineseName;
        partial void OnChineseNameChanging(global::System.String value);
        partial void OnChineseNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Boolean Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.Boolean _Gender;
        partial void OnGenderChanging(global::System.Boolean value);
        partial void OnGenderChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsIDCardValid
        {
            get
            {
                return _IsIDCardValid;
            }
            set
            {
                OnIsIDCardValidChanging(value);
                ReportPropertyChanging("IsIDCardValid");
                _IsIDCardValid = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsIDCardValid");
                OnIsIDCardValidChanged();
            }
        }
        private global::System.Boolean _IsIDCardValid;
        partial void OnIsIDCardValidChanging(global::System.Boolean value);
        partial void OnIsIDCardValidChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime LastActivityDate
        {
            get
            {
                return _LastActivityDate;
            }
            set
            {
                OnLastActivityDateChanging(value);
                ReportPropertyChanging("LastActivityDate");
                _LastActivityDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("LastActivityDate");
                OnLastActivityDateChanged();
            }
        }
        private global::System.DateTime _LastActivityDate;
        partial void OnLastActivityDateChanging(global::System.DateTime value);
        partial void OnLastActivityDateChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid RoleId
        {
            get
            {
                return _RoleId;
            }
            set
            {
                OnRoleIdChanging(value);
                ReportPropertyChanging("RoleId");
                _RoleId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("RoleId");
                OnRoleIdChanged();
            }
        }
        private global::System.Guid _RoleId;
        partial void OnRoleIdChanging(global::System.Guid value);
        partial void OnRoleIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Guid> UniversityId
        {
            get
            {
                return _UniversityId;
            }
            set
            {
                OnUniversityIdChanging(value);
                ReportPropertyChanging("UniversityId");
                _UniversityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UniversityId");
                OnUniversityIdChanged();
            }
        }
        private Nullable<global::System.Guid> _UniversityId;
        partial void OnUniversityIdChanging(Nullable<global::System.Guid> value);
        partial void OnUniversityIdChanged();

        #endregion


        #region Navigation Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_PayRecords_Users", "PayRecord")]
        public EntityCollection<PayRecord> PayRecords
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<PayRecord>("GF.Domain.Context.FK_PayRecords_Users", "PayRecord");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<PayRecord>("GF.Domain.Context.FK_PayRecords_Users", "PayRecord", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_RechargeRecords_Users", "RechargeRecord")]
        public EntityCollection<RechargeRecord> RechargeRecords
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<RechargeRecord>("GF.Domain.Context.FK_RechargeRecords_Users", "RechargeRecord");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<RechargeRecord>("GF.Domain.Context.FK_RechargeRecords_Users", "RechargeRecord", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Users_Roles", "Role")]
        public Role Role
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("GF.Domain.Context.FK_Users_Roles", "Role").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("GF.Domain.Context.FK_Users_Roles", "Role").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Role> RoleReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Role>("GF.Domain.Context.FK_Users_Roles", "Role");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Role>("GF.Domain.Context.FK_Users_Roles", "Role", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Users_Universities", "University")]
        public University University
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_Users_Universities", "University").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_Users_Universities", "University").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<University> UniversityReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<University>("GF.Domain.Context.FK_Users_Universities", "University");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<University>("GF.Domain.Context.FK_Users_Universities", "University", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Achievements_Users", "Achievement")]
        public EntityCollection<Achievement> Achievements
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Achievement>("GF.Domain.Context.FK_Achievements_Users", "Achievement");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Achievement>("GF.Domain.Context.FK_Achievements_Users", "Achievement", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_Applications_Users", "Application")]
        public EntityCollection<Application> Applications
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Application>("GF.Domain.Context.FK_Applications_Users", "Application");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Application>("GF.Domain.Context.FK_Applications_Users", "Application", value);
                }
            }
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("GF.Domain.Context", "FK_IDCard_Users", "IDCard")]
        public EntityCollection<IDCard> IDCards
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<IDCard>("GF.Domain.Context.FK_IDCard_Users", "IDCard");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<IDCard>("GF.Domain.Context.FK_IDCard_Users", "IDCard", value);
                }
            }
        }

        #endregion

    }

    #endregion

    #region ComplexTypes

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "ApplicationsDTO")]
    [DataContractAttribute(IsReference = true)]
    [Serializable()]
    public partial class ApplicationsDTO : ComplexObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new ApplicationsDTO object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="year">Initial value of the Year property.</param>
        /// <param name="batch">Initial value of the Batch property.</param>
        /// <param name="applicationSequence">Initial value of the ApplicationSequence property.</param>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="specialityId">Initial value of the SpecialityId property.</param>
        /// <param name="isAccepted">Initial value of the IsAccepted property.</param>
        /// <param name="applyTime">Initial value of the ApplyTime property.</param>
        /// <param name="universityId">Initial value of the UniversityId property.</param>
        /// <param name="universityName">Initial value of the UniversityName property.</param>
        /// <param name="specialityName">Initial value of the SpecialityName property.</param>
        public static ApplicationsDTO CreateApplicationsDTO(global::System.Guid id, global::System.Int32 year, global::System.String batch, global::System.Int32 applicationSequence, global::System.Guid userId, global::System.Guid specialityId, global::System.Boolean isAccepted, global::System.DateTime applyTime, global::System.Guid universityId, global::System.String universityName, global::System.String specialityName)
        {
            ApplicationsDTO applicationsDTO = new ApplicationsDTO();
            applicationsDTO.Id = id;
            applicationsDTO.Year = year;
            applicationsDTO.Batch = batch;
            applicationsDTO.ApplicationSequence = applicationSequence;
            applicationsDTO.UserId = userId;
            applicationsDTO.SpecialityId = specialityId;
            applicationsDTO.IsAccepted = isAccepted;
            applicationsDTO.ApplyTime = applyTime;
            applicationsDTO.UniversityId = universityId;
            applicationsDTO.UniversityName = universityName;
            applicationsDTO.SpecialityName = specialityName;
            return applicationsDTO;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
        {
            get
            {
                return _Id;
            }
            set
            {
                OnIdChanging(value);
                ReportPropertyChanging("Id");
                _Id = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Id");
                OnIdChanged();
            }
        }
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 Year
        {
            get
            {
                return _Year;
            }
            set
            {
                OnYearChanging(value);
                ReportPropertyChanging("Year");
                _Year = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Year");
                OnYearChanged();
            }
        }
        private global::System.Int32 _Year;
        partial void OnYearChanging(global::System.Int32 value);
        partial void OnYearChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String Batch
        {
            get
            {
                return _Batch;
            }
            set
            {
                OnBatchChanging(value);
                ReportPropertyChanging("Batch");
                _Batch = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Batch");
                OnBatchChanged();
            }
        }
        private global::System.String _Batch;
        partial void OnBatchChanging(global::System.String value);
        partial void OnBatchChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Int32 ApplicationSequence
        {
            get
            {
                return _ApplicationSequence;
            }
            set
            {
                OnApplicationSequenceChanging(value);
                ReportPropertyChanging("ApplicationSequence");
                _ApplicationSequence = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ApplicationSequence");
                OnApplicationSequenceChanged();
            }
        }
        private global::System.Int32 _ApplicationSequence;
        partial void OnApplicationSequenceChanging(global::System.Int32 value);
        partial void OnApplicationSequenceChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid SpecialityId
        {
            get
            {
                return _SpecialityId;
            }
            set
            {
                OnSpecialityIdChanging(value);
                ReportPropertyChanging("SpecialityId");
                _SpecialityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SpecialityId");
                OnSpecialityIdChanged();
            }
        }
        private global::System.Guid _SpecialityId;
        partial void OnSpecialityIdChanging(global::System.Guid value);
        partial void OnSpecialityIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Boolean IsAccepted
        {
            get
            {
                return _IsAccepted;
            }
            set
            {
                OnIsAcceptedChanging(value);
                ReportPropertyChanging("IsAccepted");
                _IsAccepted = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsAccepted");
                OnIsAcceptedChanged();
            }
        }
        private global::System.Boolean _IsAccepted;
        partial void OnIsAcceptedChanging(global::System.Boolean value);
        partial void OnIsAcceptedChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime ApplyTime
        {
            get
            {
                return _ApplyTime;
            }
            set
            {
                OnApplyTimeChanging(value);
                ReportPropertyChanging("ApplyTime");
                _ApplyTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ApplyTime");
                OnApplyTimeChanged();
            }
        }
        private global::System.DateTime _ApplyTime;
        partial void OnApplyTimeChanging(global::System.DateTime value);
        partial void OnApplyTimeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UniversityId
        {
            get
            {
                return _UniversityId;
            }
            set
            {
                OnUniversityIdChanging(value);
                ReportPropertyChanging("UniversityId");
                _UniversityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UniversityId");
                OnUniversityIdChanged();
            }
        }
        private global::System.Guid _UniversityId;
        partial void OnUniversityIdChanging(global::System.Guid value);
        partial void OnUniversityIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String UniversityName
        {
            get
            {
                return _UniversityName;
            }
            set
            {
                OnUniversityNameChanging(value);
                ReportPropertyChanging("UniversityName");
                _UniversityName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UniversityName");
                OnUniversityNameChanged();
            }
        }
        private global::System.String _UniversityName;
        partial void OnUniversityNameChanging(global::System.String value);
        partial void OnUniversityNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String SpecialityName
        {
            get
            {
                return _SpecialityName;
            }
            set
            {
                OnSpecialityNameChanging(value);
                ReportPropertyChanging("SpecialityName");
                _SpecialityName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SpecialityName");
                OnSpecialityNameChanged();
            }
        }
        private global::System.String _SpecialityName;
        partial void OnSpecialityNameChanging(global::System.String value);
        partial void OnSpecialityNameChanged();

        #endregion

    }

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmComplexTypeAttribute(NamespaceName = "GF.Domain.Context", Name = "LatestApplicationsDTO")]
    [DataContractAttribute(IsReference = true)]
    [Serializable()]
    public partial class LatestApplicationsDTO : ComplexObject
    {
        #region Factory Method

        /// <summary>
        /// Create a new LatestApplicationsDTO object.
        /// </summary>
        /// <param name="userId">Initial value of the UserId property.</param>
        /// <param name="userName">Initial value of the UserName property.</param>
        /// <param name="applyTime">Initial value of the ApplyTime property.</param>
        /// <param name="universityName">Initial value of the UniversityName property.</param>
        /// <param name="universityId">Initial value of the UniversityId property.</param>
        /// <param name="specialityId">Initial value of the SpecialityId property.</param>
        /// <param name="specialityName">Initial value of the SpecialityName property.</param>
        public static LatestApplicationsDTO CreateLatestApplicationsDTO(global::System.Guid userId, global::System.String userName, global::System.DateTime applyTime, global::System.String universityName, global::System.Guid universityId, global::System.Guid specialityId, global::System.String specialityName)
        {
            LatestApplicationsDTO latestApplicationsDTO = new LatestApplicationsDTO();
            latestApplicationsDTO.UserId = userId;
            latestApplicationsDTO.UserName = userName;
            latestApplicationsDTO.ApplyTime = applyTime;
            latestApplicationsDTO.UniversityName = universityName;
            latestApplicationsDTO.UniversityId = universityId;
            latestApplicationsDTO.SpecialityId = specialityId;
            latestApplicationsDTO.SpecialityName = specialityName;
            return latestApplicationsDTO;
        }

        #endregion

        #region Primitive Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UserId
        {
            get
            {
                return _UserId;
            }
            set
            {
                OnUserIdChanging(value);
                ReportPropertyChanging("UserId");
                _UserId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UserId");
                OnUserIdChanged();
            }
        }
        private global::System.Guid _UserId;
        partial void OnUserIdChanging(global::System.Guid value);
        partial void OnUserIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                OnUserNameChanging(value);
                ReportPropertyChanging("UserName");
                _UserName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UserName");
                OnUserNameChanged();
            }
        }
        private global::System.String _UserName;
        partial void OnUserNameChanging(global::System.String value);
        partial void OnUserNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.DateTime ApplyTime
        {
            get
            {
                return _ApplyTime;
            }
            set
            {
                OnApplyTimeChanging(value);
                ReportPropertyChanging("ApplyTime");
                _ApplyTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ApplyTime");
                OnApplyTimeChanged();
            }
        }
        private global::System.DateTime _ApplyTime;
        partial void OnApplyTimeChanging(global::System.DateTime value);
        partial void OnApplyTimeChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String UniversityName
        {
            get
            {
                return _UniversityName;
            }
            set
            {
                OnUniversityNameChanging(value);
                ReportPropertyChanging("UniversityName");
                _UniversityName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("UniversityName");
                OnUniversityNameChanged();
            }
        }
        private global::System.String _UniversityName;
        partial void OnUniversityNameChanging(global::System.String value);
        partial void OnUniversityNameChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid UniversityId
        {
            get
            {
                return _UniversityId;
            }
            set
            {
                OnUniversityIdChanging(value);
                ReportPropertyChanging("UniversityId");
                _UniversityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("UniversityId");
                OnUniversityIdChanged();
            }
        }
        private global::System.Guid _UniversityId;
        partial void OnUniversityIdChanging(global::System.Guid value);
        partial void OnUniversityIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.Guid SpecialityId
        {
            get
            {
                return _SpecialityId;
            }
            set
            {
                OnSpecialityIdChanging(value);
                ReportPropertyChanging("SpecialityId");
                _SpecialityId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SpecialityId");
                OnSpecialityIdChanged();
            }
        }
        private global::System.Guid _SpecialityId;
        partial void OnSpecialityIdChanging(global::System.Guid value);
        partial void OnSpecialityIdChanged();

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty = false, IsNullable = false)]
        [DataMemberAttribute()]
        public global::System.String SpecialityName
        {
            get
            {
                return _SpecialityName;
            }
            set
            {
                OnSpecialityNameChanging(value);
                ReportPropertyChanging("SpecialityName");
                _SpecialityName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SpecialityName");
                OnSpecialityNameChanged();
            }
        }
        private global::System.String _SpecialityName;
        partial void OnSpecialityNameChanging(global::System.String value);
        partial void OnSpecialityNameChanged();

        #endregion

    }

    #endregion

    #region Public Methods

    // TODO: add custermized constructor for IOC

    #region User

    partial class User : IValidatableObject
    {

        public User()
        {
            IsLocked = false;
            LastActivityDate = DateTime.Now;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="coins"></param>
        /// <param name="zone"></param>
        /// <param name="identityCardNumber"></param>
        /// <param name="chineseName"></param>
        /// <param name="roleId"></param>
        public User(Guid id, string userName, string password, string email, int coins, string identityCardNumber, string chineseName)
        {
            Id = id;
            UserName = userName;
            Password = DataCryptography.EncryptString(password);
            Email = email;
            Coins = coins;
            IsLocked = false;
            IDCardNo = identityCardNumber;
            ChineseName = chineseName;
            LastActivityDate = DateTime.Now;
        }

        public User(Guid id, string userName, string password, string email, string qq)
        {
            Id = id;
            UserName = userName;
            Password = DataCryptography.EncryptString(password);
            Email = email;
            QQ = qq;
            Coins = 0;
            IsLocked = false;
            LastActivityDate = DateTime.Now;
        }

        public bool Login(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException("password");

            this.LastActivityDate = DateTime.Now;
            return DataCryptography.DecryptString(Password) == password;
        }

        public void ChangePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException("password");

            if (password.Length < 6 || password.Length > 12)
                throw new ArgumentOutOfRangeException("password");

            Regex regex = new Regex("[a-zA-Z0-9]{" + password.Length + "}" );
            if (!regex.IsMatch(password))
            {
                // throw custermized exception
                throw new AggregateException(Resource.ResourceMessage.ex_PasswordFormatNotMatch);
            }

            Password = DataCryptography.EncryptString(password); 
        }

        public void ResetPassword()
        {
            Password = string.Empty;
            var password = string.Empty;

            // TODO: consolidate the reset password
            for (int i = 0; i < 6; i++)
            {
                Random random = new Random(1);
                password += random.Next(100).ToString();
            }

            Password = DataCryptography.EncryptString(password.Substring(0, 6));
        }

        public void ChangeIDCard(string idCardNo, string chineseName)
        {
            this.IDCardNo = idCardNo;
            this.ChineseName = chineseName;
            this.IsIDCardValid = false;
        }

        public void LockAccount()
        {
            this.IsLocked = true;
        }

        public void UnlockAccount()
        {
            this.IsLocked = false;
        }

        public void Recharge(int coins)
        {
            if (coins <= 0)
                return;

            Coins += coins;
        }

        public System.Collections.Generic.IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // TODO:

            return null;
        }
    }

    #endregion

    #region Achievement

    partial class Achievement
    {
        public Achievement()
        {
            this.Year = DateTime.Now.Year;
        }
    }
    #endregion

    #region Application

    partial class Application
    {
        public Application()
        {
            this.ApplyTime = DateTime.Now;
            if (Id == Guid.Empty)
                this.Id = Guid.NewGuid();
            this.IsAccepted = false;
            this.Year = DateTime.Now.Year;
        }


        public Application(global::System.Guid userId, global::System.Guid specialityId, global::System.Guid id = default(Guid), global::System.String batch = "第一批次", global::System.Int32 applicationSequence = 1)
        {
            this.Id = id;
            this.UserId = userId;
            this.SpecialityId = specialityId;
            this.Batch = batch;
            this.ApplicationSequence = applicationSequence;
            this.ApplyTime = DateTime.Now;
            if (Id == Guid.Empty)
                this.Id = Guid.NewGuid();
            this.IsAccepted = false;
            this.Year = DateTime.Now.Year;
        }

    }

    #endregion

    #region ScorePublish

    partial class ScorePublish
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="publishDate"></param>
        public void ChangePublishDate(DateTime publishDate)
        {
            if (publishDate == null)
                throw new ArgumentNullException("publishDate");

            //if (publishDate < CollegeEntranceExamTime)
            //{
            //    // throw exception
            //    throw new AggregateException(Resource.ResourceMessage.ex_PublishDateLessThanCollegeEntranceExamTime);
            //}

            PublishDate = publishDate;
        }
    }

    #endregion
    
    #endregion


    public enum CourseType
    { 
        理工,
        文史,
        文理综合,
        外语文,
        外语理
    }

    public enum RoleType
    {
        个人,
        企业
    }

}
