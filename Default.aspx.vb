Imports System.Data.SqlClient

Partial Class _Default
    Inherits Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)

        Dim linkToDB As New SqlConnection()
        linkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        linkToDB.Open()

        ' Stock Used in last Month Table

        Dim DateToday As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim LastDate As String = DateTime.Now.AddMonths(-1).ToString("yyyy/MM/dd")

        Dim sqlMonthly36 As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 1 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly36 As New SqlCommand(sqlMonthly36, linkToDB)
        Dim um36 As Integer = CInt(comMonthly36.ExecuteScalar())
        Session("UM36") = um36


        Dim sqlMonthly35 As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 2 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly35 As New SqlCommand(sqlMonthly35, linkToDB)
        Dim um35 As Integer = CInt(comMonthly35.ExecuteScalar())
        Session("UM35") = um35

        Dim sqlMonthly34 As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 3 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly34 As New SqlCommand(sqlMonthly34, linkToDB)
        Dim um34 As Integer = CInt(comMonthly34.ExecuteScalar())
        Session("UM34") = um34

        Dim sqlMonthly33 As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 4 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly33 As New SqlCommand(sqlMonthly33, linkToDB)
        Dim um33 As Integer = CInt(comMonthly33.ExecuteScalar())
        Session("UM33") = um33

        Dim sqlMonthly32 As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 5 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly32 As New SqlCommand(sqlMonthly32, linkToDB)
        Dim um32 As Integer = CInt(comMonthly32.ExecuteScalar())
        Session("UM32") = um32


        Dim sqlMonthly32B As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 6 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly32B As New SqlCommand(sqlMonthly32B, linkToDB)
        Dim um32B As Integer = CInt(comMonthly32B.ExecuteScalar())
        Session("UM32B") = um32B

        Dim sqlMonthly32P As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 7 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly32P As New SqlCommand(sqlMonthly32P, linkToDB)
        Dim um32P As Integer = CInt(comMonthly32P.ExecuteScalar())
        Session("UM32P") = um32P

        Dim sqlMonthly32G As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 8 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly32G As New SqlCommand(sqlMonthly32G, linkToDB)
        Dim um32G As Integer = CInt(comMonthly32G.ExecuteScalar())
        Session("UM32G") = um32G

        Dim sqlMonthly30 As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 9 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly30 As New SqlCommand(sqlMonthly30, linkToDB)
        Dim um30 As Integer = CInt(comMonthly30.ExecuteScalar())
        Session("UM30") = um30

        Dim sqlMonthly30B As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 10 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly30B As New SqlCommand(sqlMonthly30B, linkToDB)
        Dim um30B As Integer = CInt(comMonthly30B.ExecuteScalar())
        Session("UM30B") = um30B

        Dim sqlMonthly30P As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 11 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly30P As New SqlCommand(sqlMonthly30P, linkToDB)
        Dim um30P As Integer = CInt(comMonthly30P.ExecuteScalar())
        Session("UM30P") = um30P

        Dim sqlMonthly30G As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 12 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly30G As New SqlCommand(sqlMonthly30G, linkToDB)
        Dim um30G As Integer = CInt(comMonthly30G.ExecuteScalar())
        Session("UM30G") = um30G

        Dim sqlMonthly28 As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 13 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly28 As New SqlCommand(sqlMonthly28, linkToDB)
        Dim um28 As Integer = CInt(comMonthly28.ExecuteScalar())
        Session("UM28") = um28

        Dim sqlMonthly28B As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 14 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly28B As New SqlCommand(sqlMonthly28B, linkToDB)
        Dim um28B As Integer = CInt(comMonthly28B.ExecuteScalar())
        Session("UM28B") = um28B

        Dim sqlMonthly28P As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 15 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly28P As New SqlCommand(sqlMonthly28P, linkToDB)
        Dim um28P As Integer = CInt(comMonthly28P.ExecuteScalar())
        Session("UM28P") = um28P

        Dim sqlMonthly28G As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 16 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly28G As New SqlCommand(sqlMonthly28G, linkToDB)
        Dim um28G As Integer = CInt(comMonthly28G.ExecuteScalar())
        Session("UM28G") = um28G

        Dim sqlMonthly26 As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 17 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly26 As New SqlCommand(sqlMonthly26, linkToDB)
        Dim um26 As Integer = CInt(comMonthly26.ExecuteScalar())
        Session("UM26") = um26

        Dim sqlMonthly26B As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 18 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly26B As New SqlCommand(sqlMonthly26B, linkToDB)
        Dim um26B As Integer = CInt(comMonthly26B.ExecuteScalar())
        Session("UM26B") = um26B

        Dim sqlMonthly26P As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 19 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly26P As New SqlCommand(sqlMonthly26P, linkToDB)
        Dim um26P As Integer = CInt(comMonthly26P.ExecuteScalar())
        Session("UM26P") = um26P

        Dim sqlMonthly26G As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 20 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly26G As New SqlCommand(sqlMonthly26G, linkToDB)
        Dim um26G As Integer = CInt(comMonthly26G.ExecuteScalar())
        Session("UM26G") = um26G

        Dim sqlMonthly24 As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 21 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly24 As New SqlCommand(sqlMonthly24, linkToDB)
        Dim um24 As Integer = CInt(comMonthly24.ExecuteScalar())
        Session("UM24") = um24

        Dim sqlMonthly24B As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 22 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly24B As New SqlCommand(sqlMonthly24B, linkToDB)
        Dim um24B As Integer = CInt(comMonthly24B.ExecuteScalar())
        Session("UM24B") = um24B

        Dim sqlMonthly24P As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 23 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly24P As New SqlCommand(sqlMonthly24P, linkToDB)
        Dim um24P As Integer = CInt(comMonthly24P.ExecuteScalar())
        Session("UM24P") = um24P

        Dim sqlMonthly24G As String = "Select Sum(Quantity) As totalUsed from StockOutLine Where ProductID = 24 and Date Between '" + LastDate + "' and '" + DateToday + "'"
        Dim comMonthly24G As New SqlCommand(sqlMonthly24G, linkToDB)
        Dim um24G As Integer = CInt(comMonthly24G.ExecuteScalar())
        Session("UM24G") = um24G

        'Totals
        Session("TotalUM32") = um32 + um32B + um32P + um32G
        Session("TotalUM30") = um32 + um30B + um30P + um30G
        Session("TotalUM28") = um28 + um28B + um28P + um28G
        Session("TotalUM26") = um26 + um26B + um26P + um26G
        Session("TotalUM24") = um24 + um24B + um24P + um24G

        Session("TotUsePlain") = um36 + um35 + um34 + um33 + um32 + um30 + um28 + um26 + um24
        Session("TotUseBlue") = um32B + um30B + um28B + um26B + um24B
        Session("TotUsePink") = um32P + um30P + um28P + um26P + um24P
        Session("TotUseGreen") = um32G + um30G + um28G + um26G + um26G
        Session("TotUsedMonthly") = um36 + um35 + um34 + um33 + um32 + um30 + um28 + um26 + um24 + um32B + um30B + um28B + um26B + um24B + um32P + um30P + um28P + um26P + um24P + um32G + um30G + um28G + um26G + um26G

        
        '@reference Hamill, D. (2016) "Week 7 - Website Authentication & Site Links". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.


        If Not Me.Page.User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub

    Function createCurrentStockTable() As IList(Of Integer)
        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
        Dim linkToDB As New SqlConnection()
        linkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        linkToDB.Open()

        'http://stackoverflow.com/questions/11652823/how-to-store-sql-query-value-into-array
        Dim sqlGetQuantity As String = "SELECT Quantity from CurrentStock Order By Id asc"
        Dim comGetQuantity As New SqlCommand(sqlGetQuantity, linkToDB)
        Dim listQuantity As New List(Of Integer)

        ' @reference StackOverFlow (2016) How to store sql query value into array. Available at: http://stackoverflow.com/questions/11652823/how-to-store-sql-query-value-into-array (Accessed: 31 July 2016).
        Using reader As SqlDataReader = comGetQuantity.ExecuteReader()
            While reader.Read()
                listQuantity.Add(reader.GetValue(reader.GetOrdinal("Quantity")))
            End While
        End Using

        ' @reference DotNetPerls (2016) VB.NET convert list to string. Available at: http://www.dotnetperls.com/convert-list-string-vbnet (Accessed: 10 July 2016).
        Dim value As String = String.Join(",", listQuantity)
        Dim quant36 = listQuantity.Item(0)
        Dim quant35 = listQuantity.Item(1)
        Dim quant34 = listQuantity.Item(2)
        Dim quant33 = listQuantity.Item(3)
        Dim quant32 = listQuantity.Item(4)
        Dim quant32B = listQuantity.Item(5)
        Dim quant32P = listQuantity.Item(6)
        Dim quant32G = listQuantity.Item(7)
        Dim total32 = quant32 + quant32B + quant32P + quant32G
        Dim quant30 = listQuantity.Item(8)
        Dim quant30B = listQuantity.Item(9)
        Dim quant30P = listQuantity.Item(10)
        Dim quant30G = listQuantity.Item(11)
        Dim total30 = quant30 + quant30B + quant30P + quant30G
        Dim quant28 = listQuantity.Item(12)
        Dim quant28B = listQuantity.Item(13)
        Dim quant28P = listQuantity.Item(14)
        Dim quant28G = listQuantity.Item(15)
        Dim total28 = quant28 + quant28B + quant28P + quant28G
        Dim quant26 = listQuantity.Item(16)
        Dim quant26B = listQuantity.Item(17)
        Dim quant26P = listQuantity.Item(18)
        Dim quant26G = listQuantity.Item(19)
        Dim total26 = quant26 + quant26B + quant26P + quant26G
        Dim quant24 = listQuantity.Item(20)
        Dim quant24B = listQuantity.Item(21)
        Dim quant24P = listQuantity.Item(22)
        Dim quant24G = listQuantity.Item(23)
        Dim total24 = quant24 + quant24B + quant24P + quant24G
        Dim totalPlain = quant36 + quant35 + quant34 + quant33 + quant32 + quant30 + quant28 + quant26 + quant24
        Dim totalBlue = quant32B + quant30B + quant28B + quant26B + quant24B
        Dim totalPink = quant32P + quant30P + quant28P + quant26P + quant24P
        Dim totalGreen = quant32G + quant30G + quant28G + quant26G + quant24G
        Dim totalAll = totalPlain + totalBlue + totalPink + totalGreen

        Response.Write("<tr>" _
                                & "<td class=""""><strong>36</strong></td>" _
                                & "<td class="""">" & quant36 & "</td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""""><strong>" & quant36 & "</strong></td>" _
                            & "</tr>" _
                            & "<tr>" _
                                & "<td class=""""><strong>35</strong></td>" _
                                & "<td class="""">" & quant35 & "</td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""""><strong>" & quant35 & "</strong></td>" _
                            & "</tr>" _
                            & "<tr>" _
                                & "<td class=""""><strong>34</strong></td>" _
                                & "<td class="""">" & quant34 & "</td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""""><strong>" & quant34 & "</strong></td>" _
                            & "</tr>" _
                            & "<tr>" _
                                & "<td class=""""><strong>33</strong></td>" _
                                & "<td class="""">" & quant33 & "</td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""grey""></td>" _
                                & "<td class=""""><strong>" & quant33 & "</strong></td>" _
                            & "</tr>" _
                            & "<tr>" _
                                & "<td class=""""><strong>32</strong></td>" _
                                & "<td class="""">" & quant32 & "</td>" _
                                & "<td class=""blue"">" & quant32B & "</td>" _
                                & "<td class=""danger"">" & quant32P & "</td>" _
                                & "<td class=""success"">" & quant32G & "</td>" _
                                & "<td class=""""><strong>" & total32 & "</strong></td>" _
                            & "</tr>" _
                            & "<tr>" _
                                & "<td class=""""><strong>30</strong></td>" _
                                & "<td class="""">" & quant30 & "</td>" _
                                & "<td class=""blue"">" & quant30B & "</td>" _
                                & "<td class=""danger"">" & quant30P & "</td>" _
                                & "<td class=""success"">" & quant30G & "</td>" _
                                & "<td class=""""><strong>" & total30 & "</strong></td>" _
                            & "</tr>" _
                            & "<tr>" _
                                & "<td class=""""><strong>28</strong></td>" _
                                & "<td class="""">" & quant28 & "</td>" _
                                & "<td class=""blue"">" & quant28B & "</td>" _
                                & "<td class=""danger"">" & quant28P & "</td>" _
                                & "<td class=""success"">" & quant28G & "</td>" _
                                & "<td class=""""><strong>" & total28 & "</strong></td>" _
                            & "</tr>" _
                            & "<tr>" _
                                & "<td class=""""><strong>26</strong></td>" _
                                & "<td class="""">" & quant26 & "</td>" _
                                & "<td class=""blue"">" & quant26B & "</td>" _
                                & "<td class=""danger"">" & quant26P & "</td>" _
                                & "<td class=""success"">" & quant26G & "</td>" _
                                & "<td class=""""><strong>" & total26 & "</strong></td>" _
                            & "</tr>" _
                            & "<tr>" _
                                & "<td class=""""><strong>24</strong></td>" _
                                & "<td class="""">" & quant24 & "</td>" _
                                & "<td class=""blue"">" & quant24B & "</td>" _
                                & "<td class=""danger"">" & quant24P & "</td>" _
                                & "<td class=""success"">" & quant24G & "</td>" _
                                & "<td class=""""><strong>" & total24 & "</strong></td>" _
                            & "</tr>" _
                            & "<tr>" _
                                & "<td class=""""><strong>TOTALS</strong></td>" _
                                & "<td class=""""><strong>" & totalPlain & "</strong></td>" _
                                & "<td class=""""><strong>" & totalBlue & "</strong></td>" _
                                & "<td class=""""><strong>" & totalPink & "</strong></td>" _
                                & "<td class=""""><strong>" & totalGreen & "</strong></td>" _
                                & "<td class=""""><strong>" & totalAll & "</strong></td>" _
                            & "</tr>" _
                          )

        linkToDB.Close()
        'Dim quant36 = listQuantities.Item(0)


    End Function

End Class