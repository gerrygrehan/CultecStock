Imports System.Data.SqlClient
Imports System.Data

' CustomReport.aspx.vb
' Date 20-7-16
' @author Gerry Grehan, 14104911

Partial Class CustomReport
    Inherits System.Web.UI.Page

    '@reference Hamill, D. (2016) "Week 7 - Website Authentication & Site Links". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.Page.User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub

    Sub generateReport(Sender As Object, E As EventArgs)

        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)

        ' Set Connection and Open
        Dim linkToDB As New SqlConnection()
        linkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        linkToDB.Open()

        ' Get Selections
        Dim myStartDate As String
        Dim myEndDate As String
        Dim myCustomerName As String
        myStartDate = Request.Form("startDate")
        myEndDate = Request.Form("endDate")
        myCustomerName = selectCustomer.SelectedValue

        ' Get Customer ID to match User name
        Dim sqlSelectCusID As String = "SELECT [Id] from Customer WHERE ([Name] = '" + myCustomerName + "')"
        Dim dataAction As New SqlCommand(sqlSelectCusID, linkToDB)
        Dim myCustomerId As String = CInt(dataAction.ExecuteScalar())

        'Get Purchase Orders
        Dim sqlGetSORId As String = "SELECT Id from StockOutRecord Where CustomerID = '" + myCustomerId + "' and Date Between '" + myStartDate + "' and '" + myEndDate + "'"
        Dim comGetSORId As New SqlCommand(sqlGetSORId, linkToDB)
        Dim listId As New List(Of Integer)


        ' @reference StackOverFlow (2016) How to store sql query value into array. Available at: http://stackoverflow.com/questions/11652823/how-to-store-sql-query-value-into-array (Accessed: 31 July 2016).
        Using reader As SqlDataReader = comGetSORId.ExecuteReader()
            While reader.Read()
                listId.Add(reader.GetValue(reader.GetOrdinal("Id")))
            End While
        End Using
        Dim slist As String = String.Join(",", listId)

        If slist = String.Empty Then
            PlaceHolder2.Controls.Add(New LiteralControl("<h3>No Stock Out Records</h3>"))
        Else

            ' @reference StackOverFlow (2016) Html from code behind. Available at: http://stackoverflow.com/questions/4945058/html-from-code-behind (Accessed: 31 July 2016).

            PlaceHolder2.Controls.Add(New LiteralControl("<table class=""table table-bordered"">" _
                        & "<thead>" _
                        & "<tr>" _
                            & "<td><strong>Date</strong></td>" _
                            & "<td><strong>Customer</strong></td>" _
                            & "<td><strong>36</strong></td>" _
                            & "<td><strong>35</strong></td>" _
                            & "<td><strong>34</strong></td>" _
                            & "<td><strong>33</strong></td>" _
                            & "<td><strong>32</strong></td>" _
                            & "<td class=""blue""><strong>32B</strong></td>" _
                            & "<td class=""danger""><strong>32B</strong></td>" _
                            & "<td class=""success""><strong>32B</strong></td>" _
                            & "<td><strong>30</strong></td>" _
                            & "<td class=""blue""><strong>30B</strong></td>" _
                            & "<td class=""danger""><strong>30P</strong></td>" _
                            & "<td class=""success""><strong>30G</strong></td>" _
                            & "<td><strong>28</strong></td>" _
                            & "<td class=""blue""><strong>28B</strong></td>" _
                            & "<td class=""danger""><strong>28P</strong></td>" _
                            & "<td class=""success""><strong>28G</strong></td>" _
                            & "<td><strong>26</strong></td>" _
                            & "<td class=""blue""><strong>26B</strong></td>" _
                            & "<td class=""danger""><strong>26P</strong></td>" _
                            & "<td class=""success""><strong>26G</strong></td>" _
                            & "<td><strong>24</strong></td>" _
                            & "<td class=""blue""><strong>24B</strong></td>" _
                            & "<td class=""danger""><strong>24P</strong></td>" _
                            & "<td class=""success""><strong>24G</strong></td>" _
                            & "<td><strong>TOTALS</strong></td>" _
                        & "</tr>" _
                    & "</thead>" _
                    & "<tbody>"
                    ))

            ' @reference DotNetPerls (2016) VB.NET for each loop examples. Available at: http://www.dotnetperls.com/for-each-vbnet
            For Each sorId As String In listId

                Dim currentId = sorId
                Dim sqlGetName As String = "Select CustomerName from StockOutRecord WHERE ([Id] = '" + currentId + "')"
                Dim comGetCurrentName As New SqlCommand(sqlGetName, linkToDB)
                Dim cusName As String = CStr(comGetCurrentName.ExecuteScalar)

                Dim sqlGetDate As String = "Select Date from StockOutRecord WHERE ([Id] = '" + currentId + "')"
                Dim comGetCurrentDate As New SqlCommand(sqlGetDate, linkToDB)
                Dim cusDate As String = CStr(comGetCurrentDate.ExecuteScalar)

                Dim sqlGet36Quant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 1)"
                Dim comGet36Quant As New SqlCommand(sqlGet36Quant, linkToDB)
                Dim quant36 As Object = CInt(comGet36Quant.ExecuteScalar)

                Dim sqlGet35Quant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 2)"
                Dim comGet35Quant As New SqlCommand(sqlGet35Quant, linkToDB)
                Dim quant35 As Integer = CInt(comGet35Quant.ExecuteScalar)

                Dim sqlGet34Quant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 3)"
                Dim comGet34Quant As New SqlCommand(sqlGet34Quant, linkToDB)
                Dim quant34 As Integer = CInt(comGet34Quant.ExecuteScalar)

                Dim sqlGet33Quant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 4)"
                Dim comGet33Quant As New SqlCommand(sqlGet33Quant, linkToDB)
                Dim quant33 As Integer = CInt(comGet33Quant.ExecuteScalar)

                Dim sqlGet32Quant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 5)"
                Dim comGet32Quant As New SqlCommand(sqlGet32Quant, linkToDB)
                Dim quant32 As Integer = CInt(comGet32Quant.ExecuteScalar)

                Dim sqlGet32BQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 6)"
                Dim comGet32BQuant As New SqlCommand(sqlGet32BQuant, linkToDB)
                Dim quant32B As Integer = CInt(comGet32BQuant.ExecuteScalar)

                Dim sqlGet32PQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 7)"
                Dim comGet32PQuant As New SqlCommand(sqlGet32PQuant, linkToDB)
                Dim quant32P As Integer = CInt(comGet32PQuant.ExecuteScalar)

                Dim sqlGet32GQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 8)"
                Dim comGet32GQuant As New SqlCommand(sqlGet32GQuant, linkToDB)
                Dim quant32G As Integer = CInt(comGet32GQuant.ExecuteScalar)

                Dim sqlGet30Quant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 9)"
                Dim comGet30Quant As New SqlCommand(sqlGet30Quant, linkToDB)
                Dim quant30 As Integer = CInt(comGet30Quant.ExecuteScalar)

                Dim sqlGet30BQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 10)"
                Dim comGet30BQuant As New SqlCommand(sqlGet30BQuant, linkToDB)
                Dim quant30B As Integer = CInt(comGet30BQuant.ExecuteScalar)

                Dim sqlGet30PQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 11)"
                Dim comGet30PQuant As New SqlCommand(sqlGet30PQuant, linkToDB)
                Dim quant30P As Integer = CInt(comGet30PQuant.ExecuteScalar)

                Dim sqlGet30GQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 12)"
                Dim comGet30GQuant As New SqlCommand(sqlGet30GQuant, linkToDB)
                Dim quant30G As Integer = CInt(comGet30GQuant.ExecuteScalar)

                Dim sqlGet28Quant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 13)"
                Dim comGet28Quant As New SqlCommand(sqlGet28Quant, linkToDB)
                Dim quant28 As String = CInt(comGet28Quant.ExecuteScalar)

                Dim sqlGet28BQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 14)"
                Dim comGet28BQuant As New SqlCommand(sqlGet28BQuant, linkToDB)
                Dim quant28B As Integer = CInt(comGet28BQuant.ExecuteScalar)

                Dim sqlGet28PQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 15)"
                Dim comGet28PQuant As New SqlCommand(sqlGet28PQuant, linkToDB)
                Dim quant28P As Integer = CInt(comGet28PQuant.ExecuteScalar)

                Dim sqlGet28GQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 16)"
                Dim comGet28GQuant As New SqlCommand(sqlGet28GQuant, linkToDB)
                Dim quant28G As Integer = CInt(comGet28GQuant.ExecuteScalar)

                Dim sqlGet26Quant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 17)"
                Dim comGet26Quant As New SqlCommand(sqlGet26Quant, linkToDB)
                Dim quant26 As Integer = CInt(comGet26Quant.ExecuteScalar)

                Dim sqlGet26BQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 18)"
                Dim comGet26BQuant As New SqlCommand(sqlGet26BQuant, linkToDB)
                Dim quant26B As Integer = CInt(comGet26BQuant.ExecuteScalar)

                Dim sqlGet26PQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 19)"
                Dim comGet26PQuant As New SqlCommand(sqlGet26PQuant, linkToDB)
                Dim quant26P As Integer = CInt(comGet26PQuant.ExecuteScalar)

                Dim sqlGet26GQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 20)"
                Dim comGet26GQuant As New SqlCommand(sqlGet26GQuant, linkToDB)
                Dim quant26G As Integer = CInt(comGet26GQuant.ExecuteScalar)

                Dim sqlGet24Quant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 21)"
                Dim comGet24Quant As New SqlCommand(sqlGet24Quant, linkToDB)
                Dim quant24 As Integer = CInt(comGet24Quant.ExecuteScalar)

                Dim sqlGet24BQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 22)"
                Dim comGet24BQuant As New SqlCommand(sqlGet24BQuant, linkToDB)
                Dim quant24B As Integer = CInt(comGet24BQuant.ExecuteScalar)

                Dim sqlGet24PQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 23)"
                Dim comGet24PQuant As New SqlCommand(sqlGet24PQuant, linkToDB)
                Dim quant24P As Integer = CInt(comGet24PQuant.ExecuteScalar)

                Dim sqlGet24GQuant As String = "Select Quantity from StockOutLine WHERE ([StockOutID] = '" + currentId + "') AND ([ProductID] = 24)"
                Dim comGet24GQuant As New SqlCommand(sqlGet24GQuant, linkToDB)
                Dim quant24G As Integer = CInt(comGet24GQuant.ExecuteScalar)

                Dim totalOut = quant36 + quant35 + quant34 + quant33 + quant32 + quant32B + quant32P + quant32G + quant30 + quant30B + quant30P + quant30G + quant28 + quant28B + quant28P + quant28G + quant26 + quant26B + quant26P + quant26G + quant24 + quant24B + quant24P + quant24G

                PlaceHolder1.Controls.Add(New LiteralControl("<tr>" _
                                & "<td class="""">" & cusDate & "</td>" _
                                & "<td class="""">" & cusName & "</td>" _
                                & "<td class="""">" & quant36 & "</td>" _
                                & "<td class="""">" & quant35 & "</td>" _
                                & "<td class="""">" & quant34 & "</td>" _
                                & "<td class="""">" & quant33 & "</td>" _
                                & "<td class="""">" & quant32 & "</td>" _
                                & "<td class=""blue"">" & quant32B & "</td>" _
                                & "<td class=""danger"">" & quant32P & "</td>" _
                                & "<td class=""success"">" & quant32G & "</td>" _
                                & "<td class="""">" & quant30 & "</td>" _
                                & "<td class=""blue"">" & quant30B & "</td>" _
                                & "<td class=""danger"">" & quant30P & "</td>" _
                                & "<td class=""success"">" & quant30G & "</td>" _
                                & "<td class="""">" & quant28 & "</td>" _
                                & "<td class=""blue"">" & quant28B & "</td>" _
                                & "<td class=""danger"">" & quant28P & "</td>" _
                                & "<td class=""success"">" & quant28G & "</td>" _
                                & "<td class="""">" & quant26 & "</td>" _
                                & "<td class=""blue"">" & quant26B & "</td>" _
                                & "<td class=""danger"">" & quant26P & "</td>" _
                                & "<td class=""success"">" & quant26G & "</td>" _
                                & "<td class="""">" & quant24 & "</td>" _
                                & "<td class=""blue"">" & quant24B & "</td>" _
                                & "<td class=""danger"">" & quant24P & "</td>" _
                                & "<td class=""success"">" & quant24G & "</td>" _
                                & "<td class="""">" & totalOut & "</td>" _
                                & "</tr>"
                               ))

            Next
            ' @reference DotNetPerls (2016) VB.NET for each loop examples. Available at: http://www.dotnetperls.com/for-each-vbnet

            PlaceHolder3.Controls.Add(New LiteralControl("<tr>" _
                                                            & "<td class=""""></td>" _
                                                            & "<td class=""""><strong>Totals</strong></td>"
                                                        ))

            ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
            'Get Product Ids
            Dim sqlGetProdId As String = "SELECT Id from Products Order By Id Asc"
            Dim comGetProdId As New SqlCommand(sqlGetProdId, linkToDB)
            Dim listProdId As New List(Of Integer)

            ' @reference StackOverFlow (2016) How to store sql query value into array. Available at: http://stackoverflow.com/questions/11652823/how-to-store-sql-query-value-into-array (Accessed: 31 July 2016).
            Using reader1 As SqlDataReader = comGetProdId.ExecuteReader()
                While reader1.Read()
                    listProdId.Add(reader1.GetValue(reader1.GetOrdinal("Id")))
                End While
            End Using
            Dim prodlist As String = String.Join(",", listProdId)

            For Each prodId As String In listProdId
                Dim currentProdId = prodId
                Dim sqlGetQuantity As String = "SELECT Sum(StockOutLine.Quantity) as totalQuantity FROM StockOutLine INNER JOIN StockOutRecord ON StockOutLine.StockOutID = StockOutRecord.Id where StockOutRecord.CustomerID = '" + myCustomerId + "' and StockOutLine.ProductID = '" + currentProdId + "'  and StockOutLine.Date Between '" + myStartDate + "' and '" + myEndDate + "'"
                Dim comGetQuantity As New SqlCommand(sqlGetQuantity, linkToDB)
                Dim sizeQuantity As Object = CInt(comGetQuantity.ExecuteScalar())

                PlaceHolder4.Controls.Add(New LiteralControl("<td class=""""><strong>" & sizeQuantity & "</strong></td>"))
            Next

            ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
            Dim sqlGetTotQuantity As String = "SELECT Sum(StockOutLine.Quantity) as totQuantity FROM StockOutLine INNER JOIN StockOutRecord ON StockOutLine.StockOutID = StockOutRecord.Id where StockOutRecord.CustomerID = '" + myCustomerId + "' and StockOutLine.Date Between '" + myStartDate + "' and '" + myEndDate + "'"
            Dim comGetTotQuantity As New SqlCommand(sqlGetTotQuantity, linkToDB)
            Dim totQuantity As Object = CInt(comGetTotQuantity.ExecuteScalar())

            ' @reference DotNetPerls (2016) VB.NET for each loop examples. Available at: http://www.dotnetperls.com/for-each-vbnet
            PlaceHolder5.Controls.Add(New LiteralControl("<td><strong>" & totQuantity & "<strong></td>" _
                                                        & "</tr>" _
                                                        & "</tbody>" _
                                                        & "</table>"
                                                        ))

            linkToDB.Close()
        End If

    End Sub

End Class
