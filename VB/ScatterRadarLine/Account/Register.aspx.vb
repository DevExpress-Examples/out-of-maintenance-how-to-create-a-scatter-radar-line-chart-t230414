Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports Microsoft.AspNet.Membership.OpenAuth

Namespace ScatterRadarLine.Account
    Partial Public Class Register
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            RegisterUser.ContinueDestinationPageUrl = Request.QueryString("ReturnUrl")
        End Sub

        Protected Sub RegisterUser_CreatedUser(ByVal sender As Object, ByVal e As EventArgs)
            FormsAuthentication.SetAuthCookie(RegisterUser.UserName, createPersistentCookie:= False)

            Dim continueUrl As String = RegisterUser.ContinueDestinationPageUrl
            If Not OpenAuth.IsLocalUrl(continueUrl) Then
                continueUrl = "~/"
            End If
            Response.Redirect(continueUrl)
        End Sub
    End Class
End Namespace