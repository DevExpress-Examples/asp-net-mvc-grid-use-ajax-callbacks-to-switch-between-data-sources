Imports System.Collections
Imports System.Web.Mvc

Namespace GridViewChangeModelMvc.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function GridViewPartial(Optional ByVal gridType As GridType = GridType.Categories) As ActionResult
			Dim model As IEnumerable = Nothing

			Select Case gridType
				Case GridType.Categories
					model = NorthwindDataProvider.GetCategories()
					ViewData("KeyFieldName") = "CategoryID"
				Case GridType.Products
					model = NorthwindDataProvider.GetProducts()
					ViewData("KeyFieldName") = "ProductID"
			End Select

			Return PartialView(model)
		End Function
	End Class
End Namespace