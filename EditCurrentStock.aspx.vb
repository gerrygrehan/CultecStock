
Partial Class EditCurrentStock
    Inherits System.Web.UI.Page

    '@reference Hamill, D. (2016) "Week 7 - Website Authentication & Site Links". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.Page.User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub
End Class
