using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers;

public class PortfolioController : Controller
{
    [HttpGet]
    [Route("/")]

    public string Index()
    {
        return $"This is my Index!";
    }
    [HttpGet]
    [Route("/project")]

    public string Project()
    {
        return $"This is my projects";
    }
    [HttpGet]
    [Route("/contact")]

    public string Contact()
    {
        return $"This is my Contact!";
    }
}