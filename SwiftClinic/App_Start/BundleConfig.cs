using System.Web.Optimization;

namespace SwiftClinic
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {


            //////////// Start of Bundle for SwiftKlinic ///////////////////

            bundles.Add(new StyleBundle("~/Login/css").Include(
                "~/Content/AdminTemplate/css/bootstrap.min.css",
                "~/Content/AdminTemplate/font-awesome/css/font-awesome.css",
                "~/Content/AdminTemplate/css/animate.css",
                "~/Content/AdminTemplate/css/style.css"));

            //////////// End of Bundle for SwiftKlinic ///////////////////



            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));




        }
    }
}
