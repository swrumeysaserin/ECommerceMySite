using ECommerce.Business.Abstract;
using ECommerce.Business.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashBoardController : Controller
    {
        ICookieHelper _cookieHelper;
        IUserTokenService _userTokenService;
        IUserService _userService;

        public DashBoardController(ICookieHelper cookieHelper, IUserTokenService userTokenService, IUserService userService)
        {
            _cookieHelper = cookieHelper;
            _userTokenService = userTokenService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var check = CheckAdmin();
            if (!check)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        private bool CheckAdmin()
        {
            try
            {
                var cookie = _cookieHelper.Get("AdminLogin", Request);
                var id = _userTokenService.GetTokenUserId(cookie);
                var user = _userService.GetById(id);
                if (user == null)
                {
                    return false;
                }
                else if (!user.IsAdmin.Value)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (System.Exception)
            {

                return false;
            }
        }
    }
}
