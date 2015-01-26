using System.Collections.Generic;
using System.Linq;

namespace NavigationPaging.Models
{
	public class ThingamabobRepository : IThingamabobRepository
	{
		private static List<Thingamabob> _Thingamabobs;

		static ThingamabobRepository()
		{
			_Thingamabobs = new List<Thingamabob>{
				new Thingamabob
				{
					Name = "Widdergee",
					Likes = new List<string>{"channel hopping", "fare dodging", "picture hanging", 
						"ear flicking", "soft soaping"},
					Dislikes = new List<string>{"finger pointing", "rubber necking", "flag waving",
						"child rearing", "brain dumping"}
				},
				new Thingamabob
				{
					Name = "Bretina",
					Likes = new List<string>{"bareback riding", "barn storming", "head bashing", 
						"bell ringing", "tub thumping"},
					Dislikes = new List<string>{"bear baiting", "henpecking", "sightseeing", 
						"hobnobbing", "phone hacking"}
				},
				new Thingamabob
				{
					Name = "Teg",
					Likes = new List<string>{"food fighting", "card counting", "life drawing", 
						"chain smoking", "backtracking"},
					Dislikes = new List<string>{"penpushing", "clock watching", "cross hatching", 
						"brass rubbing", "lip synching"}
				},
				new Thingamabob
				{
					Name = "Klimbert",
					Likes = new List<string>{"log rolling", "window dressing", "dog fooding", 
						"face saving", "rule bending"},
					Dislikes = new List<string>{"wool gathering", "meat eating", "flower arranging", 
						"bounty hunting", "fly fishing"}
				},
				new Thingamabob
				{
					Name = "Qax",
					Likes = new List<string>{"tree climbing", "skin diving", "sugar coating", 
						"jam making", "body popping"},
					Dislikes = new List<string>{"penny pinching", "picket fencing", "name dropping", 
						"back slapping", "knife throwing"}
				},
				new Thingamabob
				{
					Name = "Moffa",
					Likes = new List<string>{"online shopping", "tiptoeing", "lock picking", 
						"leg pulling", "mountain climbing"},
					Dislikes = new List<string>{"fact finding", "trout tickling", "bull fighting", 
						"arm wrestling", "crowd surfing"}
				},
				new Thingamabob
				{
					Name = "Chowba",
					Likes = new List<string>{"pill popping", "house sitting", "free running", 
						"bookkeeping", "night clubbing"},
					Dislikes = new List<string>{"bridge building", "cake making", "wrong footing", 
						"face lifting", "brow beating"}
				},
				new Thingamabob
				{
					Name = "Jeebly",
					Likes = new List<string>{"fine tuning", "lowriding", "nose picking", 
						"card carrying", "wrong righting"},
					Dislikes = new List<string>{"ball breaking", "base touching", "zigzagging", 
						"laser printing", "fly catching"}
				},
				new Thingamabob
				{
					Name = "Warkle",
					Likes = new List<string>{"sign painting", "shot putting", "switch hitting", 
						"daydreaming", "tie dyeing"},
					Dislikes = new List<string>{"time wasting", "white knuckling", "fence sitting", 
						"buck passing", "weather forecasting"}
				},
				new Thingamabob
				{
					Name = "Ulfi",
					Likes = new List<string>{"heartbreaking", "number crunching", "scene shifting", 
						"hard drinking", "loose living"},
					Dislikes = new List<string>{"beekeeping", "pot scrubbing", "war mongering", 
						"pulpit preaching", "bible bashing"}
				}
			};
		}

		public IQueryable<Thingamabob> Thingamabobs
		{
			get
			{
				return _Thingamabobs.AsQueryable();
			}
		}
	}
}