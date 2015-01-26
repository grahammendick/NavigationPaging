using Navigation;
using NavigationPaging.Models;
using System.Linq;
using System.Web.Mvc;

namespace NavigationPaging.Controllers
{
    public class ThingamabobController : Controller
    {
		private IThingamabobRepository _Repository;

		public ThingamabobController()
			: this(new ThingamabobRepository())
		{
		}

		public ThingamabobController(IThingamabobRepository repository)
		{
			_Repository = repository;
		}

		public ActionResult Index(string sortExpression, string name, int startRowIndex, int maximumRows)
        {
			var thingamabobs = _Repository.Thingamabobs;
			if (!string.IsNullOrEmpty(name))
				thingamabobs = thingamabobs.Where(t => t.Name.Contains(name));
			if (sortExpression == "name")
				thingamabobs = thingamabobs.OrderBy(t => t.Name);
			else
				thingamabobs = thingamabobs.OrderByDescending(t => t.Name);
			StateContext.Bag.name = name;
			StateContext.Bag.totalRowCount = thingamabobs.Count();
			return View(thingamabobs.Skip(startRowIndex).Take(maximumRows));
		}
    }
}