Imports System
Imports System.Collections.Generic
Imports System.Linq

Imports Microsoft.AspNet.Membership.OpenAuth

Namespace ScatterRadarLine.Account
    Partial Public Class Manage
        Inherits System.Web.UI.Page

        Private privateSuccessMessage As String
        Protected Property SuccessMessage() As String
            Get
                Return privateSuccessMessage
            End Get
            Private Set(ByVal value As String)
                privateSuccessMessage = value
            End Set
        End Property

        Private privateCanRemoveExternalLogins As Boolean
        Protected Property CanRemoveExternalLogins() As Boolean
            Get
                Return privateCanRemoveExternalLogins
            End Get
            Private Set(ByVal value As Boolean)
                privateCanRemoveExternalLogins = value
            End Set
        End Property

        Protected Sub Page_Load()
            If Not IsPostBack Then
                ' Determine the sections to render
                Dim hasLocalPassword = OpenAuth.HasLocalPassword(User.Identity.Name)
                setPassword.Visible = Not hasLocalPassword
                changePassword.Visible = hasLocalPassword

                CanRemoveExternalLogins = hasLocalPassword

                ' Render success message
                Dim message = Request.QueryString("m")
                If message IsNot Nothing Then
                    ' Strip the query string from action
                    Form.Action = ResolveUrl("~/Account/Manage")

                    SuccessMessage = If(message Is "ChangePwdSuccess", "Your password has been changed.", If(message Is "SetPwdSuccess", "Your password has been set.", If(message Is "RemoveLoginSuccess", "The external login was removed.", String.Empty)))
                    successMessage_Renamed.Visible = Not String.IsNullOrEmpty(SuccessMessage)
                End If
            End If

        End Sub

        Protected Sub setPassword_Click(ByVal sender As Object, ByVal e As EventArgs)
            If IsValid Then
                Dim result = OpenAuth.AddLocalPassword(User.Identity.Name, password.Text)
                If result.IsSuccessful Then
                    Response.Redirect("~/Account/Manage?m=SetPwdSuccess")
                Else

                    ModelState.AddModelError("NewPassword", result.ErrorMessage)

                End If
            End If
        End Sub


        Public Function GetExternalLogins() As IEnumerable(Of OpenAuthAccountData)
            Dim accounts = OpenAuth.GetAccountsForUser(User.Identity.Name)
            CanRemoveExternalLogins = CanRemoveExternalLogins OrElse accounts.Count() > 1
            Return accounts
        End Function

        Public Sub RemoveExternalLogin(ByVal providerName As String, ByVal providerUserId As String)
            Dim m = If(OpenAuth.DeleteAccount(User.Identity.Name, providerName, providerUserId), "?m=RemoveLoginSuccess", String.Empty)
            Response.Redirect("~/Account/Manage" & m)
        End Sub


        Protected Shared Function ConvertToDisplayDateTime(ByVal utcDateTime? As Date) As String
            ' You can change this method to convert the UTC date time into the desired display
            ' offset and format. Here we're converting it to the server timezone and formatting
            ' as a short date and a long time string, using the current thread culture.
            Return If(utcDateTime.HasValue, utcDateTime.Value.ToLocalTime().ToString("G"), "[never]")
        End Function
    End Class
End Namespace