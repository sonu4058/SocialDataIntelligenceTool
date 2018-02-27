using System.Web;
using System.Web.Optimization;

namespace SocialDataIntelligenceTool
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",                      
                      "~/Resources/js/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      
                      "~/Content/site.css",
                      "~/Resources/css/bootstrap.min.css",
                      "~/Resources/css/font-awesome.min.css",
                      "~/Resources/css/owl.carousel.css",
                      "~/Resources/css/owl.theme.min.css",
                      "~/Resources/css/animate.css",
                      "~/Resources/css/newcss/main.css",
                      "~/Resources/css/mycustom.css"));
        }
    }
}
