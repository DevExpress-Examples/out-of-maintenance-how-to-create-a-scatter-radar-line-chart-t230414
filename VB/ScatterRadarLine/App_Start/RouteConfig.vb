Imports System
Imports System.Collections.Generic
Imports System.Web
Imports System.Web.Routing
Imports Microsoft.AspNet.FriendlyUrls

Namespace ScatterRadarLine
    Public NotInheritable Class RouteConfig

        Private Sub New()
        End Sub

        Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
            routes.EnableFriendlyUrls()
        End Sub
    End Class
End Namespace
