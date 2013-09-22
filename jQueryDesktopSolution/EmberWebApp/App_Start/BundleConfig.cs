using System.Web;
using System.Web.Optimization;

namespace EmberWebApp
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // SCRIPT
            var jquery = new ScriptBundle("~/bundles/jquery");
            jquery.Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery-ui-{version}.js");
            jquery.Transforms.Clear();
            bundles.Add(jquery);

            var emberBundle = new ScriptBundle("~/bundles/ember");
            emberBundle.Include("~/Scripts/handlebars.js", "~/Scripts/ember*");
            emberBundle.Transforms.Clear();
            bundles.Add(emberBundle);

            bundles.Add(new ScriptBundle("~/bundles/modernizr")
                .Include("~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/app-templates", new EmberHandlebarsBundleTransform() { MinifyTemplates = false })
                .Include("~/Scripts/App/Templates/*.handlebars"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                .Include(
                    "~/Scripts/App/App.js",
                    "~/Scripts/App/Controllers/*.js",
                    "~/Scripts/App/Libraries/*.js",
                    "~/Scripts/App/Helpers/*.js",
                    "~/Scripts/App/Models/*.js",
                    "~/Scripts/App/Views/*.js",
                    "~/Scripts/App/Routes/*.js",
                    "~/Scripts/App/Router.js"
                    )
                );

            // STYLES
            var cssBundle = new StyleBundle("~/Content/css")
                    .Include("~/Content/site.css")
                    .Include("~/Content/bootstrap*");
            emberBundle.Transforms.Clear();
            bundles.Add(cssBundle);

#if DEBUG
            BundleTable.EnableOptimizations = true;
#else
            BundleTable.EnableOptimizations = true; // Needed to ensure Handlebars templates are pre-compiled.
#endif


        }
    }
}