Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Threading
Imports System.Globalization
Imports DevExpress.Web.ASPxEditors

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Overrides Sub InitializeCulture()
		SetCulture()
		MyBase.InitializeCulture()
	End Sub

	Private Sub SetCulture()
		Dim c As HttpCookie = Request.Cookies("Culture")
		If c Is Nothing Then
			Return
		End If
		Dim langValue As String = c.Value
		If (Not String.IsNullOrEmpty(langValue)) Then

			Culture = langValue
			UICulture = langValue

			Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(langValue)
			Thread.CurrentThread.CurrentUICulture = New CultureInfo(langValue)
		End If
	End Sub

	Protected Sub combo_Init(ByVal sender As Object, ByVal e As EventArgs)

		Dim c As HttpCookie = Request.Cookies("Culture")
		If c Is Nothing Then
			Return
		End If
		Dim rbl As ASPxRadioButtonList = (TryCast(sender, ASPxRadioButtonList))
		Dim item As ListEditItem = rbl.Items.FindByValue(c.Value)
		rbl.SelectedItem = item
	End Sub
End Class
