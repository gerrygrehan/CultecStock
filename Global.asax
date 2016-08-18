<%@ Application Language="VB" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    Sub Application_Start(sender As Object, e As EventArgs)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
    End Sub
    
    
    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        Session("CurrentError") = "Global: " & _
            Server.GetLastError.Message
        Server.Transfer("ErrorPage404.aspx")
    End Sub


</script>
