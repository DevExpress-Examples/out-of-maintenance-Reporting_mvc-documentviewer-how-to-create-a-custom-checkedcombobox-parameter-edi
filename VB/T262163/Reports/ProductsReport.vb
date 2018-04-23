Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Collections.Generic
Imports System.Linq
Imports T262163.Models

Namespace T262163.Reports
	Partial Public Class ProductsReport
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub ProductsReport_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
			Dim db As New NorthwindEntities()
'INSTANT VB NOTE: The variable categories was renamed since Visual Basic does not handle local variables named the same as class members well:
			Dim categories_Renamed() As String = Convert.ToString(Me.Parameters("Categories").Value).Split(";"c)

			Me.DataSource = From product In db.Products
			                Where categories_Renamed.Contains(product.Category.CategoryName)
			                Select product
		End Sub

	End Class
End Namespace
