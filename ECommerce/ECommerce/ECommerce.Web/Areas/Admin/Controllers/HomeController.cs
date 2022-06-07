using ECommerce.Business.Abstract;
using ECommerce.Business.Helpers;
using ECommerce.Entities.Concrete;
using ECommerce.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ECommerce.Web.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        private readonly IUserTokenService _userTokenService;
        // LoginController program tarafından kullanıldığı anda
        // Dependenjy tool bu Interface yi IUserService görüyor ve kendisindeki configurasyona göre
        //  services.AddScoped<IUserService, UserManager>();
        // IUserService istentiğinde bize UserManager ornekleyip veriyor.
        private readonly ICookieHelper _cookieHelper;

        public HomeController(ICookieHelper cookieHelper, IUserTokenService userTokenService, IUserService userService)
        {
            _cookieHelper = cookieHelper;
            _userTokenService = userTokenService;
            _userService = userService;
        }

        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }


        
        [HttpPost]
        [Area("Admin")]
        public IActionResult Index(AdminLoginModel model)
        {
            // LoginViewModel bize gelen datanın validation işleminden geçip geçmediğinin kontrolü yapılır.Geçti ise true geçemedi ise false değeri fırlatır.
            if (ModelState.IsValid)
            {
                var result = _userService.Login(model.Email, model.Password,true);
                if (result == null)
                {
                    ModelState.AddModelError("LoginError", "Giriş Başarısız.");
                }
                else
                {
                    // token oluştur
                    //_UserTokenServis ile bir token oluşturun.
                    // Google c# guid key nasıl oluşturulur.
                    UserToken userToken = new UserToken();
                    userToken.Status = true;
                    userToken.TokenKey = Guid.NewGuid().ToString();
                    userToken.UserId = result.Id;
                    userToken.CreateDate = DateTime.Now;

                    _userTokenService.Add(userToken);

                    _cookieHelper.Add("AdminLogin", userToken.TokenKey, Response, DateTime.Now.AddMonths(12));

                    //cookie çerez işlemlerini yapmalıyız.
                    return RedirectToAction("Index", "DashBoard");
                }
            }

            return View();
        }
    }
}
