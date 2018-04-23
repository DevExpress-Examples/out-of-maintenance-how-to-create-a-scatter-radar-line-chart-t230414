Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports Microsoft.AspNet.Membership.OpenAuth

Namespace ScatterRadarLine
    Friend NotInheritable Class AuthConfig

        Private Sub New()
        End Sub

        Public Shared Sub RegisterOpenAuth()
            ' See http://go.microsoft.com/fwlink/?LinkId=252803 for details on setting up this ASP.NET
            ' application to support logging in via external services.

            'OpenAuth.AuthenticationClients.AddTwitter(
            '    consumerKey: "your Twitter consumer key",
            '    consumerSecret: "your Twitter consumer secret");

            'OpenAuth.AuthenticationClients.AddFacebook(
            '    appId: "your Facebook app id",
            '    appSecret: "your Facebook app secret");

            'OpenAuth.AuthenticationClients.AddMicrosoft(
            '    clientId: "your Microsoft account client id",
            '    clientSecret: "your Microsoft account client secret");

            'OpenAuth.AuthenticationClients.AddGoogle();
        End Sub
    End Class
End Namespace