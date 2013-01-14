using System.Data.Objects;
using GF.Domain.Context;
using System.Data.EntityClient;

namespace GF.Infrastructure.Data.Seedwork
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
        public ObjectSet<Account> Accounts
        {
            get
            {
                if ((_Accounts == null))
                {
                    _Accounts = base.CreateObjectSet<Account>("Accounts");
                }
                return _Accounts;
            }
        }
        private ObjectSet<Account> _Accounts;

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
        public ObjectSet<EnrollPlan> EnrollPlans
        {
            get
            {
                if ((_EnrollPlans == null))
                {
                    _EnrollPlans = base.CreateObjectSet<EnrollPlan>("EnrollPlans");
                }
                return _EnrollPlans;
            }
        }
        private ObjectSet<EnrollPlan> _EnrollPlans;

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
        public ObjectSet<AchievementHistory> AchievementHistories
        {
            get
            {
                if ((_AchievementHistories == null))
                {
                    _AchievementHistories = base.CreateObjectSet<AchievementHistory>("AchievementHistories");
                }
                return _AchievementHistories;
            }
        }
        private ObjectSet<AchievementHistory> _AchievementHistories;

        #endregion

        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the Accounts EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAccounts(Account account)
        {
            base.AddObject("Accounts", account);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Universities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUniversities(University university)
        {
            base.AddObject("Universities", university);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the EnrollPlans EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToEnrollPlans(EnrollPlan enrollPlan)
        {
            base.AddObject("EnrollPlans", enrollPlan);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the UniversityAcceptanceStatistics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUniversityAcceptanceStatistics(UniversityAcceptanceStatistic universityAcceptanceStatistic)
        {
            base.AddObject("UniversityAcceptanceStatistics", universityAcceptanceStatistic);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the SpecialityAcceptanceStatistics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSpecialityAcceptanceStatistics(SpecialityAcceptanceStatistic specialityAcceptanceStatistic)
        {
            base.AddObject("SpecialityAcceptanceStatistics", specialityAcceptanceStatistic);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Specialities EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToSpecialities(Speciality speciality)
        {
            base.AddObject("Specialities", speciality);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Applications EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToApplications(Application application)
        {
            base.AddObject("Applications", application);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Achievements EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAchievements(Achievement achievement)
        {
            base.AddObject("Achievements", achievement);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the ScorePublishes EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToScorePublishes(ScorePublish scorePublish)
        {
            base.AddObject("ScorePublishes", scorePublish);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the ApplicationStatistics EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToApplicationStatistics(ApplicationStatistic applicationStatistic)
        {
            base.AddObject("ApplicationStatistics", applicationStatistic);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the AchievementHistories EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAchievementHistories(AchievementHistory achievementHistory)
        {
            base.AddObject("AchievementHistories", achievementHistory);
        }

        #endregion

        #region Function Imports

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectResult<ApplicationSequenceStatistic_DTO> GetApplicationSequenceStatistic()
        {
            return base.ExecuteFunction<ApplicationSequenceStatistic_DTO>("GetApplicationSequenceStatistic");
        }

        #endregion

    }

    #endregion
}
