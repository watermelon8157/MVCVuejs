using System.Web;
using System.Web.Optimization;

namespace MVCVue
{
    public class BundleConfig
    {
        // 如需「搭配」的詳細資訊，請瀏覽 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用開發版本的 Modernizr 進行開發並學習。然後，當您
            // 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap4/bootstrap.min.css",
                      "~/Content/fontawesome/fontawesome-free_all.min.css",
                      "~/Content/fonts.googleapis.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/scripts/js").Include(
                     "~/Scripts/modernizr-2.6.2.js",
                     "~/Scripts/jquery-2.1.1.min.js",
                     "~/Scripts/moment.js",
                     "~/Scripts/moment-with-locales.js",
                     "~/Scripts/Vue/vue.min.js",
                     "~/Scripts/Vue/vue-resource.min.js",
                     "~/Scripts/Vue/vue-bootstrap-datetimepicker.min.js",
                     "~/Scripts/Vue/vue-select.js",
                     "~/Scripts/Vue/vue-router.min.js",
                     "~/Scripts/bootstrap4/bootstrap.min.js"
                     ));
             
        }
    }
}
