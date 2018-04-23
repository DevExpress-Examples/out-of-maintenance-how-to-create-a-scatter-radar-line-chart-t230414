Imports System
Imports System.Collections.Generic
Imports System.Web
Imports Microsoft.AspNet.Membership.OpenAuth

Namespace ScatterRadarLine.Account
    Partial Public Class OpenAuthProviders
        Inherits System.Web.UI.UserControl

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

            If IsPostBack Then
                Dim provider = Request.Form("provider")
                If provider Is Nothing Then
                    Return
                End If

                Dim redirectUrl = "~/Account/RegisterExternalLogin"
                If Not String.IsNullOrEmpty(ReturnUrl) Then
                    Dim resolvedReturnUrl = ResolveUrl(ReturnUrl)
                    redirectUrl &= "?ReturnUrl=" & HttpUtility.UrlEncode(resolvedReturnUrl)
                End If

                OpenAuth.RequestAuthentication(provider, redirectUrl)
            End If
        End Sub



        Public Property ReturnUrl() As String


        Public Function GetProviderNames() As IEnumerable(Of ProviderDetails)
            Return OpenAuth.AuthenticationClients.GetAll()
        End Function

    End Class
End Namespace