Imports System.Data.SqlClient
Partial Class ManagePurchaseOrders
    Inherits System.Web.UI.Page
    '@reference Hamill, D. (2016) "Week 7 - Website Authentication & Site Links". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.Page.User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub

    Sub changeStatusShipped(Sender As Object, E As EventArgs)

        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)


        ' Set Connection and Open
        Dim linkToDB As New SqlConnection()
        linkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        linkToDB.Open()

        Dim poName As String = DropDownList1.SelectedValue
        Dim myStatus As String = DropDownList2.SelectedValue

        'Get Status Id
        Dim sqlSelectStatusID As String = "SELECT [Id] from Status WHERE ([Status] = '" + myStatus + "')"
        Dim dataAction As New SqlCommand(sqlSelectStatusID, linkToDB)
        Dim myStatusId As String = CInt(dataAction.ExecuteScalar())

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        ' @reference Hamill, D. (2016) " Week 13: Introducing ADO.net: ADO.NET Data Entry Form". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.

        con.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        con.Open()

        cmd.Connection = con

        cmd.CommandText = "Update PurchaseOrder SET Status = ('" + myStatusId + "') WHERE ([POId] = '" + poName + "') "
        cmd.ExecuteNonQuery()

        ' Get Purchase Order ID


        con.Close()
        linkToDB.Close()
        Server.Transfer("ManagePurchaseOrders.aspx")
    End Sub

    Sub changeStatusDelivered(Sender As Object, E As EventArgs)

        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
        ' Set Connection and Open
        Dim linkToDB As New SqlConnection()
        linkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        linkToDB.Open()

        Dim poName As String = DropDownList3.SelectedValue
        Dim myStatus As String = DropDownList4.SelectedValue

        'Get Status Id
        Dim sqlSelectStatusID As String = "SELECT [Id] from Status WHERE ([Status] = '" + myStatus + "')"
        Dim dataAction As New SqlCommand(sqlSelectStatusID, linkToDB)
        Dim myStatusId As String = CInt(dataAction.ExecuteScalar())

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        ' @ reference Hamill, D. (2016) " Week 13: Introducing ADO.net: ADO.NET Data Entry Form". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.
        con.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        con.Open()

        cmd.Connection = con

        cmd.CommandText = "Update PurchaseOrder SET Status = ('" + myStatusId + "') WHERE ([POId] = '" + poName + "') "
        cmd.ExecuteNonQuery()


        ' UPDATE CURRENT STOCK
        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
        'Get Purchase Order Id
        Dim sqlSelectPOID As String = "SELECT [Id] from PurchaseOrder WHERE ([POId] = '" + poName + "')"
        Dim comSelectPOID As New SqlCommand(sqlSelectPOID, linkToDB)
        Dim myPOID As String = CInt(comSelectPOID.ExecuteScalar())

        ' Find Purchase Order Lines for that Purchase order
        Dim sqlGetPOLineId As String = "SELECT [Id] from PurchaseOrderLine Where ([PurchaseOrderID] = '" + myPOID + "')"
        Dim comGetPOLineId As New SqlCommand(sqlGetPOLineId, linkToDB)
        Dim listPOLineId As New List(Of Integer)

        ' @reference StackOverFlow (2016) How to store sql query value into array. Available at: http://stackoverflow.com/questions/11652823/how-to-store-sql-query-value-into-array (Accessed: 31 July 2016).
        Using reader As SqlDataReader = comGetPOLineId.ExecuteReader()
            While reader.Read()
                listPOLineId.Add(reader.GetValue(reader.GetOrdinal("Id")))
            End While
        End Using
        Dim help As String = String.Join(",", listPOLineId)

        ' @reference DotNetPerls (2016) VB.NET for each loop examples. Available at: http://www.dotnetperls.com/for-each-vbnet
        For Each poLineId As String In listPOLineId
            Dim currentpoLine = poLineId
            Dim sqlGetProdID As String = "SELECT [ProductId] from PurchaseOrderLine Where ([Id] = '" + currentpoLine + "')"
            Dim comGetProdID As New SqlCommand(sqlGetProdID, linkToDB)
            Dim prodId As String = CInt(comGetProdID.ExecuteScalar())

            Dim sqlGetQuantity As String = "SELECT [Quantity] from PurchaseOrderLine Where ([Id] = '" + currentpoLine + "')"
            Dim comGetQuantity As New SqlCommand(sqlGetQuantity, linkToDB)
            Dim quantity As Integer = CInt(comGetQuantity.ExecuteScalar())

            Dim sqlGetCS As String = "SELECT [Quantity] from CurrentStock Where ([Id] = '" + prodId + "')"
            Dim comGetCS As New SqlCommand(sqlGetCS, linkToDB)
            Dim currentStock As Integer = CInt(comGetCS.ExecuteScalar())

            Dim newStock As String = CInt(currentStock + quantity)

            Dim updateCS As New SqlCommand
            updateCS.Connection = con
            updateCS.CommandText = "Update CurrentStock SET Quantity = ('" + newStock + "') WHERE ([Id] = '" + prodId + "')"
            updateCS.ExecuteNonQuery()

        Next

        con.Close()
        linkToDB.Close()
        Server.Transfer("Default.aspx")

    End Sub

End Class
