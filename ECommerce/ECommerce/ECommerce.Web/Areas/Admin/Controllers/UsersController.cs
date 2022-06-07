using ECommerce.Business.Abstract;
using ECommerce.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Entities.Concrete;// User için ekle
namespace ECommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        IUserService _userService;

        public object Users { get; private set; }

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            UsersListViewModel model = new UsersListViewModel();
            model.UserList = _userService.List();

            return View(model);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(UserAddModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                User user = new User
                {
                    Email = model.Email,
                    IsAdmin = model.IsAdmin,
                    Password = model.Password,
                    Status = model.Status

                };
                _userService.Add(user);

                return RedirectToAction("List");
            }


        }

        public IActionResult Edit(int id)
        {
            var user = _userService.GetById(id);
            if (user != null)
            {
                UserEditModel userEditModel = new UserEditModel
                {
                    Email = user.Email,
                    IsAdmin = user.IsAdmin.Value,
                    Status = user.Status.Value

                };
                return View(userEditModel);
            }
            else
            {
                TempData["error"] = "Kullanıcı Bulunamadı";
                return RedirectToAction("List");
            }
        }
        [HttpPost]
        public IActionResult Edit(UserEditModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                User user = new User
                {
                    Email = model.Email,
                    IsAdmin = model.IsAdmin,
                    Password = model.Password,
                    Status = model.Status
                };
                _userService.Edit(user);
                return RedirectToAction("List");
            }
        }
    }
}
