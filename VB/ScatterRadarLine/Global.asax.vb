Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Optimization
Imports System.Web.Routing
Imports System.Web.Security
Imports ScatterRadarLine

Namespace ScatterRadarLine
    Public Class [Global]
        Inherits HttpApplication

        Private Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
            ' Code that runs on application startup
            BundleConfig.RegisterBundles(BundleTable.Bundles)
            AuthConfig.RegisterOpenAuth()
            RouteConfig.RegisterRoutes(RouteTable.Routes)
        End Sub

        Private Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
            '  Code that runs on application shutdown

        End Sub

        Private Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
            ' Code that runs when an unhandled error occurs

        End Sub
    End Class
End Namespace
