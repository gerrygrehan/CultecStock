Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework
Imports Microsoft.AspNet.Identity.Owin
Imports System
Imports System.Linq
Imports System.Web
Imports System.Web.UI

Public Partial Class Account_Register
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.Page.User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub
    Protected Sub CreateUser_Click(sender As Object, e As EventArgs)
        Dim manager = New UserManager()
        Dim user = New ApplicationUser() With {.UserName = userName.Text}
        Dim result = manager.Create(user, Password.Text)
        If result.Succeeded Then
            IdentityHelper.SignIn(manager, user, isPersistent:=False)
            IdentityHelper.RedirectToReturnUrl(Request.QueryString("ReturnUrl"), Response)
        Else
            ErrorMessage.Text = result.Errors.FirstOrDefault()
        End If
    End Sub
End Class
