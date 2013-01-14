using System.Data.Objects;
using GF.Domain.Context;
using System.Data.EntityClient;
using System;

namespace GF.Infrastructure.Data.Context
{

    #region Contexts

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    internal partial class ApplicationContext : ObjectContext
    {
        #region Constructors

        /// <summary>
        /// Initializes a new ApplicationContext object using the connection string found in the 'ApplicationContext' section of the application configuration file.
        /// </summary>
        public ApplicationContext()
            : base("name=ApplicationContext", "ApplicationContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new ApplicationContext object.
        /// </summary>
        public ApplicationContext(string connectionString)
            : base(connectionString, "ApplicationContext")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new ApplicationContext object.
        /// </summary>
        public ApplicationContext(EntityConnection connection)
            : base(connection, "ApplicationContext")
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
        public ObjectSet<HighSchool> HighSchools
        {
            get
            {
                if ((_HighSchools == null))
                {
                    _HighSchools = base.CreateObjectSet<HighSchool>("HighSchools");
                }
                return _HighSchools;
            }
        }
        private ObjectSet<HighSchool> _HighSchools;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<PayRecord> PayRecords
        {
            get
            {
                if ((_PayRecords == null))
                {
                    _PayRecords = base.CreateObjectSet<PayRecord>("PayRecords");
                }
                return _PayRecords;
            }
        }
        private ObjectSet<PayRecord> _PayRecords;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<RechargeRecord> RechargeRecords
        {
            get
            {
                if ((_RechargeRecords == null))
                {
                    _RechargeRecords = base.CreateObjectSet<RechargeRecord>("RechargeRecords");
                }
                return _RechargeRecords;
            }
        }
        private ObjectSet<RechargeRecord> _RechargeRecords;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Region> Regions
        {
            get
            {
                if ((_Regions == null))
                {
                    _Regions = base.CreateObjectSet<Region>("Regions");
                }
                return _Regions;
            }
        }
        private ObjectSet<Region> _Regions;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Role> Roles
        {
            get
            {
                if ((_Roles == null))
                {
                    _Roles = base.CreateObjectSet<Role>("Roles");
                }
                return _Roles;
            }
        }
        private ObjectSet<Role> _Roles;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ScorePublish> ScorePublishes
        {
            get
            {
                if ((_ScorePublishes == null))
                {
                    _ScorePublishes = base.CreateObjectSet<ScorePublish>("ScorePublishes");
                }
                return _ScorePublishes;
            }
        }
        private ObjectSet<ScorePublish> _ScorePublishes;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Speciality> Specialities
        {
            get
            {
                if ((_Specialities == null))
                {
                    _Specialities = base.CreateObjectSet<Speciality>("Specialities");
                }
                return _Specialities;
            }
        }
        private ObjectSet<Speciality> _Specialities;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<University> Universities
        {
            get
            {
                if ((_Universities == null))
                {
                    _Universities = base.CreateObjectSet<University>("Universities");
                }
                return _Universities;
            }
        }
        private ObjectSet<University> _Universities;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Achievement> Achievements
        {
            get
            {
                if ((_Achievements == null))
                {
                    _Achievements = base.CreateObjectSet<Achievement>("Achievements");
                }
                return _Achievements;
            }
        }
        private ObjectSet<Achievement> _Achievements;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Application> Applications
        {
            get
            {
                if ((_Applications == null))
                {
                    _Applications = base.CreateObjectSet<Application>("Applications");
                }
                return _Applications;
            }
        }
        private ObjectSet<Application> _Applications;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<ApplicationStatistic> ApplicationStatistics
        {
            get
            {
                if ((_ApplicationStatistics == null))
                {
                    _ApplicationStatistics = base.CreateObjectSet<ApplicationStatistic>("ApplicationStatistics");
                }
                return _ApplicationStatistics;
            }
        }
        private ObjectSet<ApplicationStatistic> _ApplicationStatistics;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<SpecialityAcceptanceStatistic> SpecialityAcceptanceStatistics
        {
            get
            {
                if ((_SpecialityAcceptanceStatistics == null))
                {
                    _SpecialityAcceptanceStatistics = base.CreateObjectSet<SpecialityAcceptanceStatistic>("SpecialityAcceptanceStatistics");
                }
                return _SpecialityAcceptanceStatistics;
            }
        }
        private ObjectSet<SpecialityAcceptanceStatistic> _SpecialityAcceptanceStatistics;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<UniversityAcceptanceStatistic> UniversityAcceptanceStatistics
        {
            get
            {
                if ((_UniversityAcceptanceStatistics == null))
                {
                    _UniversityAcceptanceStatistics = base.CreateObjectSet<UniversityAcceptanceStatistic>("UniversityAcceptanceStatistics");
                }
                return _UniversityAcceptanceStatistics;
            }
        }
        private ObjectSet<UniversityAcceptanceStatistic> _UniversityAcceptanceStatistics;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<UniversityEnrollPlan> UniversityEnrollPlans
        {
            get
            {
                if ((_UniversityEnrollPlans == null))
                {
                    _UniversityEnrollPlans = base.CreateObjectSet<UniversityEnrollPlan>("UniversityEnrollPlans");
                }
                return _UniversityEnrollPlans;
            }
        }
        private ObjectSet<UniversityEnrollPlan> _UniversityEnrollPlans;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<IDCard> IDCards
        {
            get
            {
                if ((_IDCards == null))
                {
                    _IDCards = base.CreateObjectSet<IDCard>("IDCards");
                }
                return _IDCards;
            }
        }
        private ObjectSet<IDCard> _IDCards;

        #endregion

        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the HighSchools EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToHighSchools(HighSchool highSchool)
        {
            base.AddObject("HighSchools", highSchool);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the PayRecords EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPayRecords(PayRecord payRecord)
        {
            base.AddObject("PayRecords", payRecord);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the RechargeRecords EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRechargeRecords(RechargeRecord rechargeRecord)
        {
            base.AddObject("RechargeRecords", rechargeRecord);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Regions EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRegions(Region region)
        {
            base.AddObject("Regions", region);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Roles EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToRoles(Role role)
        {
            base.AddObject("Roles", role);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the ScorePublishes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToScorePublishes(ScorePublish scorePublish)
        {
            base.AddObject("ScorePublishes", scorePublish);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Specialities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSpecialities(Speciality speciality)
        {
            base.AddObject("Specialities", speciality);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Universities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUniversities(University university)
        {
            base.AddObject("Universities", university);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Achievements EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAchievements(Achievement achievement)
        {
            base.AddObject("Achievements", achievement);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Applications EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToApplications(Application application)
        {
            base.AddObject("Applications", application);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the ApplicationStatistics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToApplicationStatistics(ApplicationStatistic applicationStatistic)
        {
            base.AddObject("ApplicationStatistics", applicationStatistic);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the SpecialityAcceptanceStatistics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSpecialityAcceptanceStatistics(SpecialityAcceptanceStatistic specialityAcceptanceStatistic)
        {
            base.AddObject("SpecialityAcceptanceStatistics", specialityAcceptanceStatistic);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the UniversityAcceptanceStatistics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUniversityAcceptanceStatistics(UniversityAcceptanceStatistic universityAcceptanceStatistic)
        {
            base.AddObject("UniversityAcceptanceStatistics", universityAcceptanceStatistic);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the UniversityEnrollPlans EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUniversityEnrollPlans(UniversityEnrollPlan universityEnrollPlan)
        {
            base.AddObject("UniversityEnrollPlans", universityEnrollPlan);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the IDCards EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToIDCards(IDCard iDCard)
        {
            base.AddObject("IDCards", iDCard);
        }

        #endregion

        #region Function Imports

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="specialityId">No Metadata Documentation available.</param>
        /// <param name="province">No Metadata Documentation available.</param>
        /// <param name="applicationSequence">No Metadata Documentation available.</param>
        public int GetApplicationSequenceProvinceStatistic(Nullable<global::System.Guid> specialityId, global::System.String province, Nullable<global::System.Int32> applicationSequence)
        {
            ObjectParameter specialityIdParameter;
            if (specialityId.HasValue)
            {
                specialityIdParameter = new ObjectParameter("SpecialityId", specialityId);
            }
            else
            {
                specialityIdParameter = new ObjectParameter("SpecialityId", typeof(global::System.Guid));
            }

            ObjectParameter provinceParameter;
            if (province != null)
            {
                provinceParameter = new ObjectParameter("Province", province);
            }
            else
            {
                provinceParameter = new ObjectParameter("Province", typeof(global::System.String));
            }

            ObjectParameter applicationSequenceParameter;
            if (applicationSequence.HasValue)
            {
                applicationSequenceParameter = new ObjectParameter("ApplicationSequence", applicationSequence);
            }
            else
            {
                applicationSequenceParameter = new ObjectParameter("ApplicationSequence", typeof(global::System.Int32));
            }

            return base.ExecuteFunction("GetApplicationSequenceProvinceStatistic", specialityIdParameter, provinceParameter, applicationSequenceParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="name">No Metadata Documentation available.</param>
        public ObjectResult<User> GetUserByName(global::System.String name)
        {
            ObjectParameter nameParameter;
            if (name != null)
            {
                nameParameter = new ObjectParameter("Name", name);
            }
            else
            {
                nameParameter = new ObjectParameter("Name", typeof(global::System.String));
            }

            return base.ExecuteFunction<User>("GetUserByName", nameParameter);
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        /// <param name="name">No Metadata Documentation available.</param>
        public ObjectResult<User> GetUserByName(global::System.String name, MergeOption mergeOption)
        {
            ObjectParameter nameParameter;
            if (name != null)
            {
                nameParameter = new ObjectParameter("Name", name);
            }
            else
            {
                nameParameter = new ObjectParameter("Name", typeof(global::System.String));
            }

            return base.ExecuteFunction<User>("GetUserByName", mergeOption, nameParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="id">No Metadata Documentation available.</param>
        public ObjectResult<User> GetUserById(Nullable<global::System.Guid> id)
        {
            ObjectParameter idParameter;
            if (id.HasValue)
            {
                idParameter = new ObjectParameter("Id", id);
            }
            else
            {
                idParameter = new ObjectParameter("Id", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<User>("GetUserById", idParameter);
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        /// <param name="id">No Metadata Documentation available.</param>
        public ObjectResult<User> GetUserById(Nullable<global::System.Guid> id, MergeOption mergeOption)
        {
            ObjectParameter idParameter;
            if (id.HasValue)
            {
                idParameter = new ObjectParameter("Id", id);
            }
            else
            {
                idParameter = new ObjectParameter("Id", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<User>("GetUserById", mergeOption, idParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="id">No Metadata Documentation available.</param>
        /// <param name="isExist">No Metadata Documentation available.</param>
        public int CheckUserExistById(Nullable<global::System.Guid> id, ObjectParameter isExist)
        {
            ObjectParameter idParameter;
            if (id.HasValue)
            {
                idParameter = new ObjectParameter("Id", id);
            }
            else
            {
                idParameter = new ObjectParameter("Id", typeof(global::System.Guid));
            }

            return base.ExecuteFunction("CheckUserExistById", idParameter, isExist);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="name">No Metadata Documentation available.</param>
        /// <param name="isExist">No Metadata Documentation available.</param>
        public int CheckUserExistByName(global::System.String name, ObjectParameter isExist)
        {
            ObjectParameter nameParameter;
            if (name != null)
            {
                nameParameter = new ObjectParameter("Name", name);
            }
            else
            {
                nameParameter = new ObjectParameter("Name", typeof(global::System.String));
            }

            return base.ExecuteFunction("CheckUserExistByName", nameParameter, isExist);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="id">No Metadata Documentation available.</param>
        public ObjectResult<Application> GetApplicationById(Nullable<global::System.Guid> id)
        {
            ObjectParameter idParameter;
            if (id.HasValue)
            {
                idParameter = new ObjectParameter("Id", id);
            }
            else
            {
                idParameter = new ObjectParameter("Id", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<Application>("GetApplicationById", idParameter);
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        /// <param name="id">No Metadata Documentation available.</param>
        public ObjectResult<Application> GetApplicationById(Nullable<global::System.Guid> id, MergeOption mergeOption)
        {
            ObjectParameter idParameter;
            if (id.HasValue)
            {
                idParameter = new ObjectParameter("Id", id);
            }
            else
            {
                idParameter = new ObjectParameter("Id", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<Application>("GetApplicationById", mergeOption, idParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="id">No Metadata Documentation available.</param>
        public ObjectResult<University> GetUniversityById(Nullable<global::System.Guid> id)
        {
            ObjectParameter idParameter;
            if (id.HasValue)
            {
                idParameter = new ObjectParameter("Id", id);
            }
            else
            {
                idParameter = new ObjectParameter("Id", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<University>("GetUniversityById", idParameter);
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        /// <param name="id">No Metadata Documentation available.</param>
        public ObjectResult<University> GetUniversityById(Nullable<global::System.Guid> id, MergeOption mergeOption)
        {
            ObjectParameter idParameter;
            if (id.HasValue)
            {
                idParameter = new ObjectParameter("Id", id);
            }
            else
            {
                idParameter = new ObjectParameter("Id", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<University>("GetUniversityById", mergeOption, idParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="id">No Metadata Documentation available.</param>
        public ObjectResult<Speciality> GetSpecialityById(Nullable<global::System.Guid> id)
        {
            ObjectParameter idParameter;
            if (id.HasValue)
            {
                idParameter = new ObjectParameter("Id", id);
            }
            else
            {
                idParameter = new ObjectParameter("Id", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<Speciality>("GetSpecialityById", idParameter);
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        /// <param name="id">No Metadata Documentation available.</param>
        public ObjectResult<Speciality> GetSpecialityById(Nullable<global::System.Guid> id, MergeOption mergeOption)
        {
            ObjectParameter idParameter;
            if (id.HasValue)
            {
                idParameter = new ObjectParameter("Id", id);
            }
            else
            {
                idParameter = new ObjectParameter("Id", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<Speciality>("GetSpecialityById", mergeOption, idParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="provinceId">No Metadata Documentation available.</param>
        public ObjectResult<ScorePublish> GetScorePublishByProvinceId(Nullable<global::System.Guid> provinceId)
        {
            ObjectParameter provinceIdParameter;
            if (provinceId.HasValue)
            {
                provinceIdParameter = new ObjectParameter("ProvinceId", provinceId);
            }
            else
            {
                provinceIdParameter = new ObjectParameter("ProvinceId", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<ScorePublish>("GetScorePublishByProvinceId", provinceIdParameter);
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="mergeOption"></param>
        /// <param name="provinceId">No Metadata Documentation available.</param>
        public ObjectResult<ScorePublish> GetScorePublishByProvinceId(Nullable<global::System.Guid> provinceId, MergeOption mergeOption)
        {
            ObjectParameter provinceIdParameter;
            if (provinceId.HasValue)
            {
                provinceIdParameter = new ObjectParameter("ProvinceId", provinceId);
            }
            else
            {
                provinceIdParameter = new ObjectParameter("ProvinceId", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<ScorePublish>("GetScorePublishByProvinceId", mergeOption, provinceIdParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="userId">No Metadata Documentation available.</param>
        public ObjectResult<ApplicationsDTO> GetApplicationsByUserId(Nullable<global::System.Guid> userId)
        {
            ObjectParameter userIdParameter;
            if (userId.HasValue)
            {
                userIdParameter = new ObjectParameter("UserId", userId);
            }
            else
            {
                userIdParameter = new ObjectParameter("UserId", typeof(global::System.Guid));
            }

            return base.ExecuteFunction<ApplicationsDTO>("GetApplicationsByUserId", userIdParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="specialityId">No Metadata Documentation available.</param>
        /// <param name="province">No Metadata Documentation available.</param>
        public int GetApplicationScoreRankStatistic(Nullable<global::System.Guid> specialityId, global::System.String province)
        {
            ObjectParameter specialityIdParameter;
            if (specialityId.HasValue)
            {
                specialityIdParameter = new ObjectParameter("SpecialityId", specialityId);
            }
            else
            {
                specialityIdParameter = new ObjectParameter("SpecialityId", typeof(global::System.Guid));
            }

            ObjectParameter provinceParameter;
            if (province != null)
            {
                provinceParameter = new ObjectParameter("Province", province);
            }
            else
            {
                provinceParameter = new ObjectParameter("Province", typeof(global::System.String));
            }

            return base.ExecuteFunction("GetApplicationScoreRankStatistic", specialityIdParameter, provinceParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="specialityId">No Metadata Documentation available.</param>
        /// <param name="province">No Metadata Documentation available.</param>
        /// <param name="applicationSequence">No Metadata Documentation available.</param>
        public int GetApplicationSequenceScoreRankStatistic(Nullable<global::System.Guid> specialityId, global::System.String province, Nullable<global::System.Int32> applicationSequence)
        {
            ObjectParameter specialityIdParameter;
            if (specialityId.HasValue)
            {
                specialityIdParameter = new ObjectParameter("SpecialityId", specialityId);
            }
            else
            {
                specialityIdParameter = new ObjectParameter("SpecialityId", typeof(global::System.Guid));
            }

            ObjectParameter provinceParameter;
            if (province != null)
            {
                provinceParameter = new ObjectParameter("Province", province);
            }
            else
            {
                provinceParameter = new ObjectParameter("Province", typeof(global::System.String));
            }

            ObjectParameter applicationSequenceParameter;
            if (applicationSequence.HasValue)
            {
                applicationSequenceParameter = new ObjectParameter("ApplicationSequence", applicationSequence);
            }
            else
            {
                applicationSequenceParameter = new ObjectParameter("ApplicationSequence", typeof(global::System.Int32));
            }

            return base.ExecuteFunction("GetApplicationSequenceScoreRankStatistic", specialityIdParameter, provinceParameter, applicationSequenceParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="specialityId">No Metadata Documentation available.</param>
        /// <param name="province">No Metadata Documentation available.</param>
        public int GetApplicationUserStatistic(Nullable<global::System.Guid> specialityId, global::System.String province)
        {
            ObjectParameter specialityIdParameter;
            if (specialityId.HasValue)
            {
                specialityIdParameter = new ObjectParameter("SpecialityId", specialityId);
            }
            else
            {
                specialityIdParameter = new ObjectParameter("SpecialityId", typeof(global::System.Guid));
            }

            ObjectParameter provinceParameter;
            if (province != null)
            {
                provinceParameter = new ObjectParameter("Province", province);
            }
            else
            {
                provinceParameter = new ObjectParameter("Province", typeof(global::System.String));
            }

            return base.ExecuteFunction("GetApplicationUserStatistic", specialityIdParameter, provinceParameter);
        }

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        /// <param name="top">No Metadata Documentation available.</param>
        public ObjectResult<LatestApplicationsDTO> GetLatestApplications(Nullable<global::System.Int32> top)
        {
            ObjectParameter topParameter;
            if (top.HasValue)
            {
                topParameter = new ObjectParameter("top", top);
            }
            else
            {
                topParameter = new ObjectParameter("top", typeof(global::System.Int32));
            }

            return base.ExecuteFunction<LatestApplicationsDTO>("GetLatestApplications", topParameter);
        }

        #endregion

    }

    #endregion

}
