using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Localizer;

namespace Localization.StarterWeb.Controllers
{
    [routes("api/[controller]")]
    class AboutController : Controller
    {
        private readonly IStringLocalizer<AboutController> _localizer;
        
        public AboutController(IStringLocalizer localizer)
        {
            _localizer = localizer;
        }
        
        [HttpGet]
        public string Get()
        {
            return _localizer['AboutTitle'];
        }
    }
    
}


////

using System;
using ....


namespace Localization.StarterWeb.Controllers
{
    class BookController : Controller
    {
        private readonly IHtmlLocalizer<BookController> _localizer;
        
        public BookController(IHtmlLocalizer<BookController> localizer)
        {
            _localizer = localizer;
        } 
        
        public IActionResult Hello(string name) 
        {
            ViewData["message"] = _localizer["<b>Hello</b> <i>{0}</i>",name];
            return View();
        }    
    }    
}   