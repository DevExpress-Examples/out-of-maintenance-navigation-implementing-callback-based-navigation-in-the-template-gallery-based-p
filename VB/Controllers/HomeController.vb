Imports DevExpress.Web.Mvc
Imports System.Web.Mvc

Namespace ProjectTemplateNavigationMvc.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function GetPartialView(ByVal itemName As String) As ActionResult
			Return RedirectToAction(itemName)
		End Function

		Public Function CallbackPanelPartial(ByVal itemName As String) As ActionResult
			ViewData("ActionName") = itemName
			Return PartialView()
		End Function

		Public Function View1Partial() As ActionResult
			Return PartialView()
		End Function

		Public Function View2Partial() As ActionResult
			Return PartialView()
		End Function

		Public Function View3Partial() As ActionResult
			Return PartialView()
		End Function

		Public Function View4Partial() As ActionResult
			Return PartialView()
		End Function
	End Class
End Namespace