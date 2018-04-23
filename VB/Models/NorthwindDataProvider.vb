Imports System.Collections
Imports System.Collections.Generic

Public Class NorthwindDataProvider
	Public Shared Function GetCategories() As IEnumerable
		Dim categories As New List(Of Category)()

		categories.Add(New Category() With {.CategoryID = 1, .CategoryName = "Beverages"})
		categories.Add(New Category() With {.CategoryID = 2, .CategoryName = "Condiments"})
		categories.Add(New Category() With {.CategoryID = 3, .CategoryName = "Confections"})
		categories.Add(New Category() With {.CategoryID = 4, .CategoryName = "Dairy Products"})
		categories.Add(New Category() With {.CategoryID = 5, .CategoryName = "Grains/Cereals"})
		categories.Add(New Category() With {.CategoryID = 6, .CategoryName = "Meat/Poultry"})
		categories.Add(New Category() With {.CategoryID = 7, .CategoryName = "Produce"})
		categories.Add(New Category() With {.CategoryID = 8, .CategoryName = "Seafood"})

		Return categories
	End Function

	Public Shared Function GetProducts() As IEnumerable
		Dim products As New List(Of Product)()

		products.Add(New Product() With {.ProductID = 1, .ProductName = "Chai", .UnitPrice = 19, .UnitsOnOrder = 0})
		products.Add(New Product() With {.ProductID = 2, .ProductName = "Chang", .UnitPrice = 19, .UnitsOnOrder = 40})
		products.Add(New Product() With {.ProductID = 3, .ProductName = "Aniseed Syrup", .UnitPrice = 10, .UnitsOnOrder = 70})
		products.Add(New Product() With {.ProductID = 4, .ProductName = "Chef Anton's Cajun Seasoning", .UnitPrice = 22, .UnitsOnOrder = 0})
		products.Add(New Product() With {.ProductID = 5, .ProductName = "Chef Anton's Gumbo Mix", .UnitPrice = 21.35D, .UnitsOnOrder = 0})
		products.Add(New Product() With {.ProductID = 6, .ProductName = "Grandma's Boysenberry Spread", .UnitPrice = 25, .UnitsOnOrder = 0})

		Return products
	End Function
End Class