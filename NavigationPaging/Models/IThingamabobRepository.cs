using System.Linq;

namespace NavigationPaging.Models
{
	public interface IThingamabobRepository
	{
		IQueryable<Thingamabob> Thingamabobs { get; }
	}
}