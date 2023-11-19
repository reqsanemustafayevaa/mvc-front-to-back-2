using Front_to_back_2.Models;
using Front_to_back_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace Front_to_back_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public HomeController(AppDbContext dbContext)
        {
            _appDbContext = dbContext;
        }
        public IActionResult Index()
        {
            //List<Slider>sliders=new List<Slider>();
            //Slider slider=new Slider() { Id = 1,Title="BB206security",Description="Guvenlik bizim isimiz",ImageUrl="carousel-1.jpg",Redirecturl1="https://google.com",RedirectUrl2= "https://google.com" };
            //Slider slider1 = new Slider() { Id = 1, Title = "Ramzes security", Description = "Ramzinin isidir Ramze", ImageUrl = "carousel-3.jpg", Redirecturl1 = "https://google.com", RedirectUrl2 = "https://google.com" };
            //sliders.Add(slider1);
            //sliders.Add(slider);
            HomeViewModel homeviewModel = new HomeViewModel();
            homeviewModel.Sliders =_appDbContext.Sliders.ToList();
            homeviewModel.Services=_appDbContext.Services.ToList();
            
            return View(homeviewModel);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Service() 
        {
            return View();
        }
    }
}
