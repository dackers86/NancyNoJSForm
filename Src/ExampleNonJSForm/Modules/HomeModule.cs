public class HomeModule : Nancy.NancyModule
{
    public HomeModule()
    {
        Get["/"] = _ =>
        {
            ViewBag.title = "Yeah!";
            return View["Home"];
        };
    }
}