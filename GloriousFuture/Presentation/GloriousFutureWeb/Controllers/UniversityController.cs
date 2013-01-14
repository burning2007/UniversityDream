using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GF.Application.Context.Services;
using GloriousFutureWeb.Models;
using GF.Domain.Context;

namespace GloriousFutureWeb.Controllers
{
    [Authorize]
    public class UniversityController : Controller
    {
        private UniversityAppService universityService;
        private RegionAppService regionService;
        private Dictionary<string, string> universityTypes;
        private Dictionary<string, string> schoolTypes;
        private int pageCount = 15;
        private IList<Region> provinces;

        
        public UniversityController()
        {
            universityService = new UniversityAppService();
            regionService = new RegionAppService();

            provinces = regionService.GetFiltered(r => r.Class == 1);

            var universityTypeCollection = Enum.GetNames(typeof(UniversityType));
            universityTypes = new Dictionary<string, string>();
            foreach (var universityType in universityTypeCollection)
                universityTypes.Add(universityType, universityType);

            schoolTypes = new Dictionary<string, string>();
            var schoolTypeCollection = Enum.GetNames(typeof(SchoolType));
            foreach (var schoolType in schoolTypeCollection)
                schoolTypes.Add(schoolType, schoolType);
        }

        //
        // GET: /University/

        [HttpGet]
        //[OutputCache(Duration = 600, VaryByParam = "userName")]
        public ActionResult Index(string userName)
        {
            var totalPagesCount = 0;
            var universities = universityService.GetUniversities<string>(0, pageCount, out totalPagesCount, u => u.Name, true);
            ViewBag.PageIndex = 0;
            ViewBag.UniversityName = "";
            ViewBag.SchoolType = SchoolType.全部;
            ViewBag.Is211 = null;
            ViewBag.Is985 = null;
            ViewBag.IsNational = null;
            ViewBag.UniversityTypes = universityTypes;
            ViewBag.UniversityType = UniversityType.全部;
            ViewBag.SchoolTypes = schoolTypes;
            ViewBag.TotalPagesCount = totalPagesCount;
            ViewBag.Provinces = new SelectList(provinces, "Id", "Name");
            return View("Index", universities);
        }

        [AllowAnonymous]
        public ActionResult Search(string universityName, Guid? id, string universityType, string schoolType, bool? is211, bool? is985, bool? isNational, int pageIndex = 0)
        {
            if (universityName == "请输入院校名称")
                universityName = string.Empty;

            var universityTypeOriginal = universityType;
            if (universityType == UniversityType.全部.ToString())
                universityType = "";

            var schoolTypeOriginal = schoolType;
            if (schoolType == SchoolType.全部.ToString())
                schoolType = "";

            var totalPagesCount = 0;
            var universities = universityService.GetUniversities<string>(pageIndex, pageCount, out totalPagesCount, u => u.Name, true, u =>
                    u.Name.Contains((string.IsNullOrEmpty(universityName) ? u.Name : universityName))
                    && u.UniversityType == (string.IsNullOrEmpty(universityType) ? u.UniversityType : universityType)
                    && u.SchoolType == (string.IsNullOrEmpty(schoolType) ? u.SchoolType : schoolType)
                    && u.Is211 == (!is211.HasValue ? u.Is211 : is211.Value)
                    && u.Is985 == (!is985.HasValue ? u.Is985 : is985.Value)
                    && u.IsNational == (!isNational.HasValue ? u.IsNational : isNational.Value)
                    && u.ProvinceId == (id == null ? u.ProvinceId : id));
            ViewBag.UniversityName = universityName;
            ViewBag.Id = id;
            ViewBag.UniversityType = universityTypeOriginal;
            ViewBag.SchoolType = schoolTypeOriginal;
            ViewBag.Is211 = is211;
            ViewBag.Is985 = is985;
            ViewBag.IsNational = isNational;
            ViewBag.PageIndex = pageIndex;
            ViewBag.UniversityTypes = universityTypes;
            ViewBag.SchoolTypes = schoolTypes;
            ViewBag.TotalPagesCount = totalPagesCount;
            ViewBag.Provinces = new SelectList(provinces, "Id", "Name", id);
            return View("Index", universities);
        }


        //public ActionResult GetSpeciality(Guid universityId)
        //{
        //    var specialites = universityService.GetSpecialitiesByUniversityId(universityId).OrderBy<SpecialityDTO, string>(s => s.MainCategory);
        //    return View("Speciality", specialites);
        //}






    }
}
