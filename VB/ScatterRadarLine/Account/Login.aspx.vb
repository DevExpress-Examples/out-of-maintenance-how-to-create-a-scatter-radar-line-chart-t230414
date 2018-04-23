Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace ScatterRadarLine.Account
    Partial Public Class Login
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            RegisterHyperLink.NavigateUrl = "Register"
            OpenAuthLogin.ReturnUrl = Request.QueryString("ReturnUrl")

            Dim returnUrl = HttpUtility.UrlEncode(Request.QueryString("ReturnUrl"))
            If Not String.IsNullOrEmpty(returnUrl) Then
                RegisterHyperLink.NavigateUrl &= "?ReturnUrl=" & returnUrl
            End If
        End Sub
    End Class
End Namespace