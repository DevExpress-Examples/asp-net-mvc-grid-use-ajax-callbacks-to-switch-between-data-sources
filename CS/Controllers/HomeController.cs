using System.Collections;
using System.Web.Mvc;

namespace GridViewChangeModelMvc.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult GridViewPartial(GridType gridType = GridType.Categories) {
            IEnumerable model = null;

            switch (gridType) {
                case GridType.Categories:
                    model = NorthwindDataProvider.GetCategories();
                    ViewData["KeyFieldName"] = "CategoryID";
                    break;
                case GridType.Products:
                    model = NorthwindDataProvider.GetProducts();
                    ViewData["KeyFieldName"] = "ProductID";
                    break;
            }

            return PartialView(model);
        }
    }
}