public IActionResult SomeAction()
{
    ViewData["Greetings"] = "Hello";
    ViewData["Address"] = new Address()
    {
        Name = "Md. Alamin Mahamud",
        City = "Dhaka",
        HomeTown = "Comilla",
        ZipCode = 1214
    };
    
    return View();
}
