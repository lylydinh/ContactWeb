using System.Web.Optimization;

namespace ContactWeb
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Content/js/lib/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/js/lib/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/datatables").Include(
                        "~/Content/js/lib/jquery.dataTables.min.js",
                        "~/Content/js/lib/dataTables.bootstrap.min.js",
                        "~/Content/js/lib/dataTables.colReorder.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/jquery.dataTables.min.css",
                      "~/Content/css/jquery.dataTables_themeroller.css",
                      "~/Content/css/dataTables.bootstrap.min.css",
                      "~/Content/css/colReorder.bootstrap.min.css",
                      "~/Content/css/site.css"));
        }
    }
}