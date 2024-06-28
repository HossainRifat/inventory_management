using System.Web;
using System.Web.Optimization;

namespace Inventory_Management
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/guest-css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/guest.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/guest-js").Include(
                "~/Scripts/jquery-3.4.1.min.js"
                ));

            bundles.Add(new StyleBundle("~/Content/admin-css").Include(
                    "~/Content/Assets/vendors/feather/feather.css",
                    "~/Content/Assets/vendors/mdi/css/materialdesignicons.min.css",
                    "~/Content/Assets/vendors/ti-icons/css/themify-icons.css",
                    "~/Content/Assets/vendors/font-awesome/css/font-awesome.min.css",
                    "~/Content/Assets/vendors/typicons/typicons.css",
                    "~/Content/Assets/vendors/simple-line-icons/css/simple-line-icons.css",
                    "~/Content/Assets/vendors/css/vendor.bundle.base.css",
                    "~/Content/Assets/vendors/bootstrap-datepicker/bootstrap-datepicker.min.css",
                    "~/Content/Assets/css/style.css"
                ));

            bundles.Add(new ScriptBundle("~/bundles/admin-base-js").Include(
                "~/Scripts/Assets/vendors/js/base.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/admin-js").Include(
                    "~/Scripts/Assets/vendors/bootstrap-datepicker/bootstrap-datepicker.min.js",
                    "~/Scripts/Assets/js/off-canvas.js",
                    "~/Scripts/Assets/js/hoverable-collapse.js",
                    "~/Scripts/Assets/js/template.js",
                    "~/Scripts/Assets/js/settings.js",
                    "~/Scripts/Assets/js/todolist.js"
            ));
        }
    }
}
