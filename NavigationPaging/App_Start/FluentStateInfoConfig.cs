using Navigation;

[assembly: WebActivatorEx.PreApplicationStartMethod(
    typeof(NavigationPaging.FluentStateInfoConfig), "Register")]
namespace NavigationPaging
{
    public class FluentStateInfoConfig
    {
        /// <summary>
        /// This method is where you configure your navigation. You can find out more
        /// about it by heading over to http://navigation.codeplex.com/documentation
        /// To get you started here's an example
        /// </summary>
        public static void Register()
        {
			StateInfoConfig.Fluent
				.Dialog("Thingamabob", new
				{
					Listing = new MvcState("{startRowIndex}/{sortExpression}", "Thingamabob", "Index")
						.Defaults(new { startRowIndex = 0, maximumRows = 3, sortExpression = "name" })
						.Derived("maximumRows", "totalRowCount")
						.TrackCrumbTrail(false),
				}, d => d.Listing)
				.Build();
		}
    }
}