using System.Collections.Generic;

namespace NavigationPaging.Models
{
	public class Thingamabob
	{
		public string Name { get; set; }
		public IEnumerable<string> Likes { get; set; }
		public IEnumerable<string> Dislikes { get; set; }
	}
}