using Microsoft.AspNetCore.Mvc;
using NetCoreAdminInfo.Entity;
using NetCoreAdminInfo.ViewModel;

namespace NetCoreAdminInfo.Controllers
{
    public class AdminController : Controller
    {
        private readonly DriverManagementContext db;
        public AdminController(DriverManagementContext db)
        {
            this.db = db;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //GET: Admin/Create
        public IActionResult Create()
        {
            AdminInfoModel model = new AdminInfoModel();
            model.GenList = db.GenderTables
                                .Select(x => new DropdownModel { ID = x.GenderId, TEXT = x.Category }).ToList();
            model.ActList = db.ActivityTables
                              .Select(x => new DropdownModel { ID = x.IsActive, TEXT = x.Available }).ToList();
            model.HobList = db.HobbyTables
                             .Select(x => new HobbyModel { HobbyId = x.HobbyId, Hobby = x.Hobby, IsActive = x.IsActive == null ? false : x.IsActive.Value }).ToList();

            return View(model);
        }

        //POST: Admin/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AdminInfoModel model)
        {
            if (!ModelState.IsValid)
            {
                model.GenList = db.GenderTables
                                .Select(x => new DropdownModel { ID = x.GenderId, TEXT = x.Category }).ToList();
                model.ActList = db.ActivityTables
                                  .Select(x => new DropdownModel { ID = x.IsActive, TEXT = x.Available }).ToList();
                model.HobList = db.HobbyTables
                                 .Select(x => new HobbyModel { HobbyId = x.HobbyId, Hobby = x.Hobby, IsActive = x.IsActive == null ? false : x.IsActive.Value }).ToList();

                return View(model);
            }

            //model.IsResponse = true;
            AdminDetail admin = new AdminDetail();

            admin.AdminId = model.AdminId;
            admin.Name = model.AdminName;
            admin.GenderId = model.GenderId;
            admin.ActiveId = model.ActiveId;
            //admin.ImagePath = model.ImageFilePath;
            admin.RegisterDate = model.RegisterDate;

            //Uploading Image of User
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files");

            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            FileInfo fileInfo = new FileInfo(model.ImageFile.FileName);
            string fileName = fileInfo.ToString();  

            string fileNameWithPath = Path.Combine(path, fileName);

            using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
            {
                model.ImageFile.CopyTo(stream);
            }

            model.ImageFilePath = "~/wwwroot/files/" + fileName;
            admin.ImagePath = model.ImageFilePath;  //Adding image path to database 
            //Uploading Image of User

            db.AdminDetails.Add(admin);

            await db.SaveChangesAsync();

            return RedirectToAction("Create",model);   
        }
    }
}
