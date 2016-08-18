Imports System.Data
Imports System.Data.SqlClient

Partial Class StockOut
    Inherits System.Web.UI.Page

    Private Property sqlSelectCusID As Object

    '@reference Hamill, D. (2016) "Week 7 - Website Authentication & Site Links". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.Page.User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
        End If


    End Sub


    Sub SubmitRecord(Sender As Object, E As EventArgs)

        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
        ' @reference Hamill, D. (2016) " Week 13: Introducing ADO.net: ADO.NET Data Entry Form". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.

        ' Set Connection and Open
        Dim linkToDB As New SqlConnection()
        linkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        linkToDB.Open()

        ' Get Date and Customer
        Dim myDate As String
        Dim myCustomerName As String
        myDate = Request.Form("stockoutdate")
        myCustomerName = stockoutcustomer.SelectedValue

        ' Get Customer ID to match User name
        Dim sqlSelectCusID As String = "SELECT [Id] from Customer WHERE ([Name] = '" + myCustomerName + "')"
        Dim dataAction As New SqlCommand(sqlSelectCusID, linkToDB)
        Dim myCustomerId As String = CInt(dataAction.ExecuteScalar())

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        '@reference Hamill, D. (2016) "Week 7 - Website Authentication & Site Links". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.
        con.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        con.Open()

        cmd.Connection = con

        cmd.CommandText = "Insert INTO StockOutRecord(date, CustomerName, CustomerID) VALUES ('" + myDate + "', '" + myCustomerName + "', '" + myCustomerId + "')"
        cmd.ExecuteNonQuery()


        'Start of the Stock Line Entries and Update Current Stock
        'Open a new connection
        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
        Dim FreshlinkToDB As New SqlConnection()
        FreshlinkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        FreshlinkToDB.Open()

        '   Get Last Stock Id record   
        Dim sqlGetRecordID As String = "Select top 1 [Id] from StockOutRecord Order by [Id] desc"
        Dim dataActionID As New SqlCommand(sqlGetRecordID, FreshlinkToDB)
        Dim myGetRecordID As String = CInt(dataActionID.ExecuteScalar())


        '   Start of Stock Out Line for 36"
        Dim check36 = Request.Form("stockline36")
        If Request.Form("stockline36") = String.Empty Then
            ' Get Quantity Number
            ' Declare Product Id
            Dim my36ProdId As String = (1)
            Dim cmd36 As New SqlCommand
            ' Insert StockOutLine
            Dim my36Quantity As String = CInt(0)
            cmd36.Connection = con
            cmd36.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my36ProdId + "', '" + my36Quantity + "')"
            cmd36.ExecuteNonQuery()

            ' Update Current Stock 36
            Dim Quantity36 As String = "SELECT Quantity from CurrentStock WHERE Id = 1"
            Dim Stock36 As New SqlCommand(Quantity36, FreshlinkToDB)
            Dim CS36 As Integer = CInt(Stock36.ExecuteScalar())
            Dim calc36 As String = CInt(CS36 - my36Quantity)

            Dim update36 As New SqlCommand
            update36.Connection = con
            update36.CommandText = "Update CurrentStock SET Quantity = ('" + calc36 + "') WHERE ([Id] = 1)"
            update36.ExecuteNonQuery()
        Else
            ' Get Quantity Number
            ' Declare Product Id
            Dim my36ProdId As String = (1)
            Dim cmd36 As New SqlCommand
            ' Insert StockOutLine
            Dim my36Quantity As String = CInt(Request.Form("stockline36"))
            cmd36.Connection = con
            cmd36.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my36ProdId + "', '" + my36Quantity + "')"
            cmd36.ExecuteNonQuery()

            ' Update Current Stock 36
            Dim Quantity36 As String = "SELECT Quantity from CurrentStock WHERE Id = 1"
            Dim Stock36 As New SqlCommand(Quantity36, FreshlinkToDB)
            Dim CS36 As Integer = CInt(Stock36.ExecuteScalar())
            Dim calc36 As String = CInt(CS36 - my36Quantity)

            Dim update36 As New SqlCommand
            update36.Connection = con
            update36.CommandText = "Update CurrentStock SET Quantity = ('" + calc36 + "') WHERE ([Id] = 1)"
            update36.ExecuteNonQuery()
        End If


        '   Start of Stock Out Line for 35"
        ' Declare Product Id

        Dim check35 = Request.Form("stockline35")
        If Request.Form("stockline35") = String.Empty Then
            ' Get Quantity Number
            Dim my35ProdId As String = (2)
            Dim cmd35 As New SqlCommand
            Dim my35Quantity As String = CInt(0)
            cmd35.Connection = con
            cmd35.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my35ProdId + "', '" + my35Quantity + "')"
            cmd35.ExecuteNonQuery()

            ' Update Current Stock 35
            Dim Quantity35 As String = "SELECT Quantity from CurrentStock WHERE Id = 2"
            Dim Stock35 As New SqlCommand(Quantity35, FreshlinkToDB)
            Dim CS35 As Integer = CInt(Stock35.ExecuteScalar())
            Dim calc35 As String = CInt(CS35 - my35Quantity)

            Dim update35 As New SqlCommand
            update35.Connection = con
            update35.CommandText = "Update CurrentStock SET Quantity = ('" + calc35 + "') WHERE ([Id] = 2)"
            update35.ExecuteNonQuery()
        Else
            ' Get Quantity Number
            Dim my35ProdId As String = (2)
            Dim cmd35 As New SqlCommand
            Dim my35Quantity As String = CInt(Request.Form("stockline35"))
            cmd35.Connection = con
            cmd35.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my35ProdId + "', '" + my35Quantity + "')"
            cmd35.ExecuteNonQuery()

            ' Update Current Stock 35
            Dim Quantity35 As String = "SELECT Quantity from CurrentStock WHERE Id = 2"
            Dim Stock35 As New SqlCommand(Quantity35, FreshlinkToDB)
            Dim CS35 As Integer = CInt(Stock35.ExecuteScalar())
            Dim calc35 As String = CInt(CS35 - my35Quantity)

            Dim update35 As New SqlCommand
            update35.Connection = con
            update35.CommandText = "Update CurrentStock SET Quantity = ('" + calc35 + "') WHERE ([Id] = 2)"
            update35.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 34"
        Dim check34 = Request.Form("stockline34")
        If Request.Form("stockline34") = String.Empty Then
            ' Declare Product Id
            Dim my34ProdId As String = (3)
            Dim cmd34 As New SqlCommand
            ' Get Quantity Number
            Dim my34Quantity As String = CInt(0)
            cmd34.Connection = con
            cmd34.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my34ProdId + "', '" + my34Quantity + "')"
            cmd34.ExecuteNonQuery()

            ' Update Current Stock 34
            Dim Quantity34 As String = "SELECT Quantity from CurrentStock WHERE Id = 3"
            Dim Stock34 As New SqlCommand(Quantity34, FreshlinkToDB)
            Dim CS34 As Integer = CInt(Stock34.ExecuteScalar())
            Dim calc34 As String = CInt(CS34 - my34Quantity)

            Dim update34 As New SqlCommand
            update34.Connection = con
            update34.CommandText = "Update CurrentStock SET Quantity = ('" + calc34 + "') WHERE ([Id] = 3)"
            update34.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my34ProdId As String = (3)
            Dim cmd34 As New SqlCommand
            ' Get Quantity Number
            Dim my34Quantity As String = CInt(Request.Form("stockline34"))
            cmd34.Connection = con
            cmd34.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my34ProdId + "', '" + my34Quantity + "')"
            cmd34.ExecuteNonQuery()

            ' Update Current Stock 34
            Dim Quantity34 As String = "SELECT Quantity from CurrentStock WHERE Id = 3"
            Dim Stock34 As New SqlCommand(Quantity34, FreshlinkToDB)
            Dim CS34 As Integer = CInt(Stock34.ExecuteScalar())
            Dim calc34 As String = CInt(CS34 - my34Quantity)

            Dim update34 As New SqlCommand
            update34.Connection = con
            update34.CommandText = "Update CurrentStock SET Quantity = ('" + calc34 + "') WHERE ([Id] = 3)"
            update34.ExecuteNonQuery()

        End If

        '   Start of Stock Out Line for 33"
        Dim check33 = Request.Form("stockline33")
        If Request.Form("stockline33") = String.Empty Then
            ' Declare Product Id
            Dim my33ProdId As String = (4)
            Dim cmd33 As New SqlCommand
            ' Get Quantity Number
            Dim my33Quantity As String = CInt(0)
            cmd33.Connection = con
            cmd33.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my33ProdId + "', '" + my33Quantity + "')"
            cmd33.ExecuteNonQuery()

            ' Update Current Stock 33
            Dim Quantity33 As String = "SELECT Quantity from CurrentStock WHERE Id = 4"
            Dim Stock33 As New SqlCommand(Quantity33, FreshlinkToDB)
            Dim CS33 As Integer = CInt(Stock33.ExecuteScalar())
            Dim calc33 As String = CInt(CS33 - my33Quantity)

            Dim update33 As New SqlCommand
            update33.Connection = con
            update33.CommandText = "Update CurrentStock SET Quantity = ('" + calc33 + "') WHERE ([Id] = 4)"
            update33.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my33ProdId As String = (4)
            Dim cmd33 As New SqlCommand
            ' Get Quantity Number
            Dim my33Quantity As String = CInt(Request.Form("stockline33"))
            cmd33.Connection = con
            cmd33.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my33ProdId + "', '" + my33Quantity + "')"
            cmd33.ExecuteNonQuery()

            ' Update Current Stock 33
            Dim Quantity33 As String = "SELECT Quantity from CurrentStock WHERE Id = 4"
            Dim Stock33 As New SqlCommand(Quantity33, FreshlinkToDB)
            Dim CS33 As Integer = CInt(Stock33.ExecuteScalar())
            Dim calc33 As String = CInt(CS33 - my33Quantity)

            Dim update33 As New SqlCommand
            update33.Connection = con
            update33.CommandText = "Update CurrentStock SET Quantity = ('" + calc33 + "') WHERE ([Id] = 4)"
            update33.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 32"

        Dim check32 = Request.Form("stockline32")
        If Request.Form("stockline32") = String.Empty Then
            ' Declare Product Id
            Dim my32ProdId As String = (5)
            Dim cmd32 As New SqlCommand
            ' Get Quantity Number
            Dim my32Quantity As String = CInt(0)
            cmd32.Connection = con
            cmd32.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my32ProdId + "', '" + my32Quantity + "')"
            cmd32.ExecuteNonQuery()

            ' Update Current Stock 32
            Dim Quantity32 As String = "SELECT Quantity from CurrentStock WHERE Id = 5"
            Dim Stock32 As New SqlCommand(Quantity32, FreshlinkToDB)
            Dim CS32 As Integer = CInt(Stock32.ExecuteScalar())
            Dim calc32 As String = CInt(CS32 - my32Quantity)

            Dim update32 As New SqlCommand
            update32.Connection = con
            update32.CommandText = "Update CurrentStock SET Quantity = ('" + calc32 + "') WHERE ([Id] = 5)"
            update32.ExecuteNonQuery()

        Else
            ' Declare Product Id
            Dim my32ProdId As String = (5)
            Dim cmd32 As New SqlCommand
            ' Get Quantity Number
            Dim my32Quantity As String = CInt(Request.Form("stockline32"))
            cmd32.Connection = con
            cmd32.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my32ProdId + "', '" + my32Quantity + "')"
            cmd32.ExecuteNonQuery()

            ' Update Current Stock 32
            Dim Quantity32 As String = "SELECT Quantity from CurrentStock WHERE Id = 5"
            Dim Stock32 As New SqlCommand(Quantity32, FreshlinkToDB)
            Dim CS32 As Integer = CInt(Stock32.ExecuteScalar())
            Dim calc32 As String = CInt(CS32 - my32Quantity)

            Dim update32 As New SqlCommand
            update32.Connection = con
            update32.CommandText = "Update CurrentStock SET Quantity = ('" + calc32 + "') WHERE ([Id] = 5)"
            update32.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 32B"

        Dim check32B = Request.Form("stockline32B")
        If Request.Form("stockline32B") = String.Empty Then
            ' Declare Product Id
            Dim my32BProdId As String = (6)
            Dim cmd32B As New SqlCommand
            ' Get Quantity Number
            Dim my32BQuantity As String = CInt(0)
            cmd32B.Connection = con
            cmd32B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my32BProdId + "', '" + my32BQuantity + "')"
            cmd32B.ExecuteNonQuery()

            ' Update Current Stock 32B
            Dim Quantity32B As String = "SELECT Quantity from CurrentStock WHERE Id = 6"
            Dim Stock32B As New SqlCommand(Quantity32B, FreshlinkToDB)
            Dim CS32B As Integer = CInt(Stock32B.ExecuteScalar())
            Dim calc32B As String = CInt(CS32B - my32BQuantity)

            Dim update32B As New SqlCommand
            update32B.Connection = con
            update32B.CommandText = "Update CurrentStock SET Quantity = ('" + calc32B + "') WHERE ([Id] = 6)"
            update32B.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my32BProdId As String = (6)
            Dim cmd32B As New SqlCommand
            ' Get Quantity Number
            Dim my32BQuantity As String = CInt(Request.Form("stockline32B"))
            cmd32B.Connection = con
            cmd32B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my32BProdId + "', '" + my32BQuantity + "')"
            cmd32B.ExecuteNonQuery()

            ' Update Current Stock 32B
            Dim Quantity32B As String = "SELECT Quantity from CurrentStock WHERE Id = 6"
            Dim Stock32B As New SqlCommand(Quantity32B, FreshlinkToDB)
            Dim CS32B As Integer = CInt(Stock32B.ExecuteScalar())
            Dim calc32B As String = CInt(CS32B - my32BQuantity)

            Dim update32B As New SqlCommand
            update32B.Connection = con
            update32B.CommandText = "Update CurrentStock SET Quantity = ('" + calc32B + "') WHERE ([Id] = 6)"
            update32B.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 32P"

        Dim check32P = Request.Form("stockline32P")
        If Request.Form("stockline32P") = String.Empty Then
            ' Declare Product Id
            Dim my32PProdId As String = (7)
            Dim cmd32P As New SqlCommand
            ' Get Quantity Number
            Dim my32PQuantity As String = CInt(0)
            cmd32P.Connection = con
            cmd32P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my32PProdId + "', '" + my32PQuantity + "')"
            cmd32P.ExecuteNonQuery()

            ' Update Current Stock 32P
            Dim Quantity32P As String = "SELECT Quantity from CurrentStock WHERE Id = 7"
            Dim Stock32P As New SqlCommand(Quantity32P, FreshlinkToDB)
            Dim CS32P As Integer = CInt(Stock32P.ExecuteScalar())
            Dim calc32P As String = CInt(CS32P - my32PQuantity)

            Dim update32P As New SqlCommand
            update32P.Connection = con
            update32P.CommandText = "Update CurrentStock SET Quantity = ('" + calc32P + "') WHERE ([Id] = 7)"
            update32P.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my32PProdId As String = (7)
            Dim cmd32P As New SqlCommand
            ' Get Quantity Number
            Dim my32PQuantity As String = CInt(Request.Form("stockline32P"))
            cmd32P.Connection = con
            cmd32P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my32PProdId + "', '" + my32PQuantity + "')"
            cmd32P.ExecuteNonQuery()

            ' Update Current Stock 32P
            Dim Quantity32P As String = "SELECT Quantity from CurrentStock WHERE Id = 7"
            Dim Stock32P As New SqlCommand(Quantity32P, FreshlinkToDB)
            Dim CS32P As Integer = CInt(Stock32P.ExecuteScalar())
            Dim calc32P As String = CInt(CS32P - my32PQuantity)

            Dim update32P As New SqlCommand
            update32P.Connection = con
            update32P.CommandText = "Update CurrentStock SET Quantity = ('" + calc32P + "') WHERE ([Id] = 7)"
            update32P.ExecuteNonQuery()

        End If


        '   Start of Stock Out Line for 32G"

        Dim check32G = Request.Form("stockline32G")
        If Request.Form("stockline32G") = String.Empty Then
            ' Declare Product Id
            Dim my32GProdId As String = (8)
            Dim cmd32G As New SqlCommand
            ' Get Quantity Number
            Dim my32GQuantity As String = CInt(0)
            cmd32G.Connection = con
            cmd32G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my32GProdId + "', '" + my32GQuantity + "')"
            cmd32G.ExecuteNonQuery()

            ' Update Current Stock 32G
            Dim Quantity32G As String = "SELECT Quantity from CurrentStock WHERE Id = 8"
            Dim Stock32G As New SqlCommand(Quantity32G, FreshlinkToDB)
            Dim CS32G As Integer = CInt(Stock32G.ExecuteScalar())
            Dim calc32G As String = CInt(CS32G - my32GQuantity)

            Dim update32G As New SqlCommand
            update32G.Connection = con
            update32G.CommandText = "Update CurrentStock SET Quantity = ('" + calc32G + "') WHERE ([Id] = 8)"
            update32G.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my32GProdId As String = (8)
            Dim cmd32G As New SqlCommand
            ' Get Quantity Number
            Dim my32GQuantity As String = CInt(Request.Form("stockline32G"))
            cmd32G.Connection = con
            cmd32G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my32GProdId + "', '" + my32GQuantity + "')"
            cmd32G.ExecuteNonQuery()

            ' Update Current Stock 32G
            Dim Quantity32G As String = "SELECT Quantity from CurrentStock WHERE Id = 8"
            Dim Stock32G As New SqlCommand(Quantity32G, FreshlinkToDB)
            Dim CS32G As Integer = CInt(Stock32G.ExecuteScalar())
            Dim calc32G As String = CInt(CS32G - my32GQuantity)

            Dim update32G As New SqlCommand
            update32G.Connection = con
            update32G.CommandText = "Update CurrentStock SET Quantity = ('" + calc32G + "') WHERE ([Id] = 8)"
            update32G.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 30"

        Dim check30 = Request.Form("stockline30")
        If Request.Form("stockline30") = String.Empty Then
            ' Declare Product Id
            Dim my30ProdId As String = (9)
            Dim cmd30 As New SqlCommand
            ' Get Quantity Number
            Dim my30Quantity As String = CInt(0)
            cmd30.Connection = con
            cmd30.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my30ProdId + "', '" + my30Quantity + "')"
            cmd30.ExecuteNonQuery()

            ' Update Current Stock 30
            Dim Quantity30 As String = "SELECT Quantity from CurrentStock WHERE Id = 9"
            Dim Stock30 As New SqlCommand(Quantity30, FreshlinkToDB)
            Dim CS30 As Integer = CInt(Stock30.ExecuteScalar())
            Dim calc30 As String = CInt(CS30 - my30Quantity)

            Dim update30 As New SqlCommand
            update30.Connection = con
            update30.CommandText = "Update CurrentStock SET Quantity = ('" + calc30 + "') WHERE ([Id] = 9)"
            update30.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my30ProdId As String = (9)
            Dim cmd30 As New SqlCommand
            ' Get Quantity Number
            Dim my30Quantity As String = CInt(Request.Form("stockline30"))
            cmd30.Connection = con
            cmd30.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my30ProdId + "', '" + my30Quantity + "')"
            cmd30.ExecuteNonQuery()

            ' Update Current Stock 30
            Dim Quantity30 As String = "SELECT Quantity from CurrentStock WHERE Id = 9"
            Dim Stock30 As New SqlCommand(Quantity30, FreshlinkToDB)
            Dim CS30 As Integer = CInt(Stock30.ExecuteScalar())
            Dim calc30 As String = CInt(CS30 - my30Quantity)

            Dim update30 As New SqlCommand
            update30.Connection = con
            update30.CommandText = "Update CurrentStock SET Quantity = ('" + calc30 + "') WHERE ([Id] = 9)"
            update30.ExecuteNonQuery()

        End If

        '   Start of Stock Out Line for 30B"

        Dim check30B = Request.Form("stockline30B")
        If Request.Form("stockline30B") = String.Empty Then
            ' Declare Product Id
            Dim my30BProdId As String = (10)
            Dim cmd30B As New SqlCommand
            ' Get Quantity Number
            Dim my30BQuantity As String = CInt(0)
            cmd30B.Connection = con
            cmd30B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my30BProdId + "', '" + my30BQuantity + "')"
            cmd30B.ExecuteNonQuery()

            ' Update Current Stock 30B
            Dim Quantity30B As String = "SELECT Quantity from CurrentStock WHERE Id = 10"
            Dim Stock30B As New SqlCommand(Quantity30B, FreshlinkToDB)
            Dim CS30B As Integer = CInt(Stock30B.ExecuteScalar())
            Dim calc30B As String = CInt(CS30B - my30BQuantity)

            Dim update30B As New SqlCommand
            update30B.Connection = con
            update30B.CommandText = "Update CurrentStock SET Quantity = ('" + calc30B + "') WHERE ([Id] = 10)"
            update30B.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my30BProdId As String = (10)
            Dim cmd30B As New SqlCommand
            ' Get Quantity Number
            Dim my30BQuantity As String = CInt(Request.Form("stockline30B"))
            cmd30B.Connection = con
            cmd30B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my30BProdId + "', '" + my30BQuantity + "')"
            cmd30B.ExecuteNonQuery()

            ' Update Current Stock 30B
            Dim Quantity30B As String = "SELECT Quantity from CurrentStock WHERE Id = 10"
            Dim Stock30B As New SqlCommand(Quantity30B, FreshlinkToDB)
            Dim CS30B As Integer = CInt(Stock30B.ExecuteScalar())
            Dim calc30B As String = CInt(CS30B - my30BQuantity)

            Dim update30B As New SqlCommand
            update30B.Connection = con
            update30B.CommandText = "Update CurrentStock SET Quantity = ('" + calc30B + "') WHERE ([Id] = 10)"
            update30B.ExecuteNonQuery()

        End If

        '   Start of Stock Out Line for 30P"

        Dim check30P = Request.Form("stockline30P")
        If Request.Form("stockline30P") = String.Empty Then
            ' Declare Product Id
            Dim my30PProdId As String = (11)
            Dim cmd30P As New SqlCommand
            ' Get Quantity Number
            Dim my30PQuantity As String = CInt(0)
            cmd30P.Connection = con
            cmd30P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my30PProdId + "', '" + my30PQuantity + "')"
            cmd30P.ExecuteNonQuery()

            ' Update Current Stock 30P
            Dim Quantity30P As String = "SELECT Quantity from CurrentStock WHERE Id = 11"
            Dim Stock30P As New SqlCommand(Quantity30P, FreshlinkToDB)
            Dim CS30P As Integer = CInt(Stock30P.ExecuteScalar())
            Dim calc30P As String = CInt(CS30P - my30PQuantity)

            Dim update30P As New SqlCommand
            update30P.Connection = con
            update30P.CommandText = "Update CurrentStock SET Quantity = ('" + calc30P + "') WHERE ([Id] = 11)"
            update30P.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my30PProdId As String = (11)
            Dim cmd30P As New SqlCommand
            ' Get Quantity Number
            Dim my30PQuantity As String = CInt(Request.Form("stockline30P"))
            cmd30P.Connection = con
            cmd30P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my30PProdId + "', '" + my30PQuantity + "')"
            cmd30P.ExecuteNonQuery()

            ' Update Current Stock 30P
            Dim Quantity30P As String = "SELECT Quantity from CurrentStock WHERE Id = 11"
            Dim Stock30P As New SqlCommand(Quantity30P, FreshlinkToDB)
            Dim CS30P As Integer = CInt(Stock30P.ExecuteScalar())
            Dim calc30P As String = CInt(CS30P - my30PQuantity)

            Dim update30P As New SqlCommand
            update30P.Connection = con
            update30P.CommandText = "Update CurrentStock SET Quantity = ('" + calc30P + "') WHERE ([Id] = 11)"
            update30P.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 30G"

        Dim check30G = Request.Form("stockline30G")
        If Request.Form("stockline30G") = String.Empty Then
            ' Declare Product Id
            Dim my30GProdId As String = (12)
            Dim cmd30G As New SqlCommand
            ' Get Quantity Number
            Dim my30GQuantity As String = CInt(0)
            cmd30G.Connection = con
            cmd30G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my30GProdId + "', '" + my30GQuantity + "')"
            cmd30G.ExecuteNonQuery()

            ' Update Current Stock 30G
            Dim Quantity30G As String = "SELECT Quantity from CurrentStock WHERE Id = 12"
            Dim Stock30G As New SqlCommand(Quantity30G, FreshlinkToDB)
            Dim CS30G As Integer = CInt(Stock30G.ExecuteScalar())
            Dim calc30G As String = CInt(CS30G - my30GQuantity)

            Dim update30G As New SqlCommand
            update30G.Connection = con
            update30G.CommandText = "Update CurrentStock SET Quantity = ('" + calc30G + "') WHERE ([Id] = 12)"
            update30G.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my30GProdId As String = (12)
            Dim cmd30G As New SqlCommand
            ' Get Quantity Number
            Dim my30GQuantity As String = CInt(Request.Form("stockline30G"))
            cmd30G.Connection = con
            cmd30G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my30GProdId + "', '" + my30GQuantity + "')"
            cmd30G.ExecuteNonQuery()

            ' Update Current Stock 30G
            Dim Quantity30G As String = "SELECT Quantity from CurrentStock WHERE Id = 12"
            Dim Stock30G As New SqlCommand(Quantity30G, FreshlinkToDB)
            Dim CS30G As Integer = CInt(Stock30G.ExecuteScalar())
            Dim calc30G As String = CInt(CS30G - my30GQuantity)

            Dim update30G As New SqlCommand
            update30G.Connection = con
            update30G.CommandText = "Update CurrentStock SET Quantity = ('" + calc30G + "') WHERE ([Id] = 12)"
            update30G.ExecuteNonQuery()

        End If

        '   Start of Stock Out Line for 28"

        Dim check28 = Request.Form("stockline28")
        If Request.Form("stockline28") = String.Empty Then
            ' Declare Product Id
            Dim my28ProdId As String = (13)
            Dim cmd28 As New SqlCommand
            ' Get Quantity Number
            Dim my28Quantity As String = CInt(0)
            cmd28.Connection = con
            cmd28.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my28ProdId + "', '" + my28Quantity + "')"
            cmd28.ExecuteNonQuery()

            ' Update Current Stock 28
            Dim Quantity28 As String = "SELECT Quantity from CurrentStock WHERE Id = 13"
            Dim Stock28 As New SqlCommand(Quantity28, FreshlinkToDB)
            Dim CS28 As Integer = CInt(Stock28.ExecuteScalar())
            Dim calc28 As String = CInt(CS28 - my28Quantity)

            Dim update28 As New SqlCommand
            update28.Connection = con
            update28.CommandText = "Update CurrentStock SET Quantity = ('" + calc28 + "') WHERE ([Id] = 13)"
            update28.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my28ProdId As String = (13)
            Dim cmd28 As New SqlCommand
            ' Get Quantity Number
            Dim my28Quantity As String = CInt(Request.Form("stockline28"))
            cmd28.Connection = con
            cmd28.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my28ProdId + "', '" + my28Quantity + "')"
            cmd28.ExecuteNonQuery()

            ' Update Current Stock 28
            Dim Quantity28 As String = "SELECT Quantity from CurrentStock WHERE Id = 13"
            Dim Stock28 As New SqlCommand(Quantity28, FreshlinkToDB)
            Dim CS28 As Integer = CInt(Stock28.ExecuteScalar())
            Dim calc28 As String = CInt(CS28 - my28Quantity)

            Dim update28 As New SqlCommand
            update28.Connection = con
            update28.CommandText = "Update CurrentStock SET Quantity = ('" + calc28 + "') WHERE ([Id] = 13)"
            update28.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 28B"

        Dim check28B = Request.Form("stockline28B")
        If Request.Form("stockline28B") = String.Empty Then
            ' Declare Product Id
            Dim my28BProdId As String = (14)
            Dim cmd28B As New SqlCommand
            ' Get Quantity Number
            Dim my28BQuantity As String = CInt(0)
            cmd28B.Connection = con
            cmd28B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my28BProdId + "', '" + my28BQuantity + "')"
            cmd28B.ExecuteNonQuery()

            ' Update Current Stock 28B
            Dim Quantity28B As String = "SELECT Quantity from CurrentStock WHERE Id = 14"
            Dim Stock28B As New SqlCommand(Quantity28B, FreshlinkToDB)
            Dim CS28B As Integer = CInt(Stock28B.ExecuteScalar())
            Dim calc28B As String = CInt(CS28B - my28BQuantity)

            Dim update28B As New SqlCommand
            update28B.Connection = con
            update28B.CommandText = "Update CurrentStock SET Quantity = ('" + calc28B + "') WHERE ([Id] = 14)"
            update28B.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my28BProdId As String = (14)
            Dim cmd28B As New SqlCommand
            ' Get Quantity Number
            Dim my28BQuantity As String = CInt(Request.Form("stockline28B"))
            cmd28B.Connection = con
            cmd28B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my28BProdId + "', '" + my28BQuantity + "')"
            cmd28B.ExecuteNonQuery()

            ' Update Current Stock 28B
            Dim Quantity28B As String = "SELECT Quantity from CurrentStock WHERE Id = 14"
            Dim Stock28B As New SqlCommand(Quantity28B, FreshlinkToDB)
            Dim CS28B As Integer = CInt(Stock28B.ExecuteScalar())
            Dim calc28B As String = CInt(CS28B - my28BQuantity)

            Dim update28B As New SqlCommand
            update28B.Connection = con
            update28B.CommandText = "Update CurrentStock SET Quantity = ('" + calc28B + "') WHERE ([Id] = 14)"
            update28B.ExecuteNonQuery()

        End If

        '   Start of Stock Out Line for 28P"

        Dim check28P = Request.Form("stockline28P")
        If Request.Form("stockline28P") = String.Empty Then
            ' Declare Product Id
            Dim my28PProdId As String = (15)
            Dim cmd28P As New SqlCommand
            ' Get Quantity Number
            Dim my28PQuantity As String = CInt(0)
            cmd28P.Connection = con
            cmd28P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my28PProdId + "', '" + my28PQuantity + "')"
            cmd28P.ExecuteNonQuery()

            ' Update Current Stock 28P
            Dim Quantity28P As String = "SELECT Quantity from CurrentStock WHERE Id = 15"
            Dim Stock28P As New SqlCommand(Quantity28P, FreshlinkToDB)
            Dim CS28P As Integer = CInt(Stock28P.ExecuteScalar())
            Dim calc28P As String = CInt(CS28P - my28PQuantity)

            Dim update28P As New SqlCommand
            update28P.Connection = con
            update28P.CommandText = "Update CurrentStock SET Quantity = ('" + calc28P + "') WHERE ([Id] = 15)"
            update28P.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my28PProdId As String = (15)
            Dim cmd28P As New SqlCommand
            ' Get Quantity Number
            Dim my28PQuantity As String = CInt(Request.Form("stockline28P"))
            cmd28P.Connection = con
            cmd28P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my28PProdId + "', '" + my28PQuantity + "')"
            cmd28P.ExecuteNonQuery()

            ' Update Current Stock 28P
            Dim Quantity28P As String = "SELECT Quantity from CurrentStock WHERE Id = 15"
            Dim Stock28P As New SqlCommand(Quantity28P, FreshlinkToDB)
            Dim CS28P As Integer = CInt(Stock28P.ExecuteScalar())
            Dim calc28P As String = CInt(CS28P - my28PQuantity)

            Dim update28P As New SqlCommand
            update28P.Connection = con
            update28P.CommandText = "Update CurrentStock SET Quantity = ('" + calc28P + "') WHERE ([Id] = 15)"
            update28P.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 28G"

        Dim check28G = Request.Form("stockline28G")
        If Request.Form("stockline28G") = String.Empty Then
            ' Declare Product Id
            Dim my28GProdId As String = (16)
            Dim cmd28G As New SqlCommand
            ' Get Quantity Number
            Dim my28GQuantity As String = CInt(0)
            cmd28G.Connection = con
            cmd28G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my28GProdId + "', '" + my28GQuantity + "')"
            cmd28G.ExecuteNonQuery()

            ' Update Current Stock 28G
            Dim Quantity28G As String = "SELECT Quantity from CurrentStock WHERE Id = 16"
            Dim Stock28G As New SqlCommand(Quantity28G, FreshlinkToDB)
            Dim CS28G As Integer = CInt(Stock28G.ExecuteScalar())
            Dim calc28G As String = CInt(CS28G - my28GQuantity)

            Dim update28G As New SqlCommand
            update28G.Connection = con
            update28G.CommandText = "Update CurrentStock SET Quantity = ('" + calc28G + "') WHERE ([Id] = 16)"
            update28G.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my28GProdId As String = (16)
            Dim cmd28G As New SqlCommand
            ' Get Quantity Number
            Dim my28GQuantity As String = CInt(Request.Form("stockline28G"))
            cmd28G.Connection = con
            cmd28G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my28GProdId + "', '" + my28GQuantity + "')"
            cmd28G.ExecuteNonQuery()

            ' Update Current Stock 28G
            Dim Quantity28G As String = "SELECT Quantity from CurrentStock WHERE Id = 16"
            Dim Stock28G As New SqlCommand(Quantity28G, FreshlinkToDB)
            Dim CS28G As Integer = CInt(Stock28G.ExecuteScalar())
            Dim calc28G As String = CInt(CS28G - my28GQuantity)

            Dim update28G As New SqlCommand
            update28G.Connection = con
            update28G.CommandText = "Update CurrentStock SET Quantity = ('" + calc28G + "') WHERE ([Id] = 16)"
            update28G.ExecuteNonQuery()

        End If

        '   Start of Stock Out Line for 26"

        Dim check26 = Request.Form("stockline26")
        If Request.Form("stockline26") = String.Empty Then
            ' Declare Product Id
            Dim my26ProdId As String = (17)
            Dim cmd26 As New SqlCommand
            ' Get Quantity Number
            Dim my26Quantity As String = CInt(0)
            cmd26.Connection = con
            cmd26.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my26ProdId + "', '" + my26Quantity + "')"
            cmd26.ExecuteNonQuery()

            ' Update Current Stock 26
            Dim Quantity26 As String = "SELECT Quantity from CurrentStock WHERE Id = 17"
            Dim Stock26 As New SqlCommand(Quantity26, FreshlinkToDB)
            Dim CS26 As Integer = CInt(Stock26.ExecuteScalar())
            Dim calc26 As String = CInt(CS26 - my26Quantity)

            Dim update26 As New SqlCommand
            update26.Connection = con
            update26.CommandText = "Update CurrentStock SET Quantity = ('" + calc26 + "') WHERE ([Id] = 17)"
            update26.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my26ProdId As String = (17)
            Dim cmd26 As New SqlCommand
            ' Get Quantity Number
            Dim my26Quantity As String = CInt(Request.Form("stockline26"))
            cmd26.Connection = con
            cmd26.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my26ProdId + "', '" + my26Quantity + "')"
            cmd26.ExecuteNonQuery()

            ' Update Current Stock 26
            Dim Quantity26 As String = "SELECT Quantity from CurrentStock WHERE Id = 17"
            Dim Stock26 As New SqlCommand(Quantity26, FreshlinkToDB)
            Dim CS26 As Integer = CInt(Stock26.ExecuteScalar())
            Dim calc26 As String = CInt(CS26 - my26Quantity)

            Dim update26 As New SqlCommand
            update26.Connection = con
            update26.CommandText = "Update CurrentStock SET Quantity = ('" + calc26 + "') WHERE ([Id] = 17)"
            update26.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 26B"

        Dim check26B = Request.Form("stockline26B")
        If Request.Form("stockline26B") = String.Empty Then
            ' Declare Product Id
            Dim my26BProdId As String = (18)
            Dim cmd26B As New SqlCommand
            ' Get Quantity Number
            Dim my26BQuantity As String = CInt(0)
            cmd26B.Connection = con
            cmd26B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my26BProdId + "', '" + my26BQuantity + "')"
            cmd26B.ExecuteNonQuery()

            ' Update Current Stock 26B
            Dim Quantity26B As String = "SELECT Quantity from CurrentStock WHERE Id = 18"
            Dim Stock26B As New SqlCommand(Quantity26B, FreshlinkToDB)
            Dim CS26B As Integer = CInt(Stock26B.ExecuteScalar())
            Dim calc26B As String = CInt(CS26B - my26BQuantity)

            Dim update26B As New SqlCommand
            update26B.Connection = con
            update26B.CommandText = "Update CurrentStock SET Quantity = ('" + calc26B + "') WHERE ([Id] = 18)"
            update26B.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my26BProdId As String = (18)
            Dim cmd26B As New SqlCommand
            ' Get Quantity Number
            Dim my26BQuantity As String = CInt(Request.Form("stockline26B"))
            cmd26B.Connection = con
            cmd26B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my26BProdId + "', '" + my26BQuantity + "')"
            cmd26B.ExecuteNonQuery()

            ' Update Current Stock 26B
            Dim Quantity26B As String = "SELECT Quantity from CurrentStock WHERE Id = 18"
            Dim Stock26B As New SqlCommand(Quantity26B, FreshlinkToDB)
            Dim CS26B As Integer = CInt(Stock26B.ExecuteScalar())
            Dim calc26B As String = CInt(CS26B - my26BQuantity)

            Dim update26B As New SqlCommand
            update26B.Connection = con
            update26B.CommandText = "Update CurrentStock SET Quantity = ('" + calc26B + "') WHERE ([Id] = 18)"
            update26B.ExecuteNonQuery()

        End If

        '   Start of Stock Out Line for 26P"

        Dim check26P = Request.Form("stockline26P")
        If Request.Form("stockline26P") = String.Empty Then
            ' Declare Product Id
            Dim my26PProdId As String = (19)
            Dim cmd26P As New SqlCommand
            ' Get Quantity Number
            Dim my26PQuantity As String = CInt(0)
            cmd26P.Connection = con
            cmd26P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my26PProdId + "', '" + my26PQuantity + "')"
            cmd26P.ExecuteNonQuery()

            ' Update Current Stock 26P
            Dim Quantity26P As String = "SELECT Quantity from CurrentStock WHERE Id = 19"
            Dim Stock26P As New SqlCommand(Quantity26P, FreshlinkToDB)
            Dim CS26P As Integer = CInt(Stock26P.ExecuteScalar())
            Dim calc26P As String = CInt(CS26P - my26PQuantity)

            Dim update26P As New SqlCommand
            update26P.Connection = con
            update26P.CommandText = "Update CurrentStock SET Quantity = ('" + calc26P + "') WHERE ([Id] = 19)"
            update26P.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my26PProdId As String = (19)
            Dim cmd26P As New SqlCommand
            ' Get Quantity Number
            Dim my26PQuantity As String = CInt(Request.Form("stockline26P"))
            cmd26P.Connection = con
            cmd26P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my26PProdId + "', '" + my26PQuantity + "')"
            cmd26P.ExecuteNonQuery()

            ' Update Current Stock 26P
            Dim Quantity26P As String = "SELECT Quantity from CurrentStock WHERE Id = 19"
            Dim Stock26P As New SqlCommand(Quantity26P, FreshlinkToDB)
            Dim CS26P As Integer = CInt(Stock26P.ExecuteScalar())
            Dim calc26P As String = CInt(CS26P - my26PQuantity)

            Dim update26P As New SqlCommand
            update26P.Connection = con
            update26P.CommandText = "Update CurrentStock SET Quantity = ('" + calc26P + "') WHERE ([Id] = 19)"
            update26P.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 26G"

        Dim check26G = Request.Form("stockline26G")
        If Request.Form("stockline26G") = String.Empty Then
            ' Declare Product Id
            Dim my26GProdId As String = (20)
            Dim cmd26G As New SqlCommand
            ' Get Quantity Number
            Dim my26GQuantity As String = CInt(0)
            cmd26G.Connection = con
            cmd26G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my26GProdId + "', '" + my26GQuantity + "')"
            cmd26G.ExecuteNonQuery()

            ' Update Current Stock 26G
            Dim Quantity26G As String = "SELECT Quantity from CurrentStock WHERE Id = 20"
            Dim Stock26G As New SqlCommand(Quantity26G, FreshlinkToDB)
            Dim CS26G As Integer = CInt(Stock26G.ExecuteScalar())
            Dim calc26G As String = CInt(CS26G - my26GQuantity)

            Dim update26G As New SqlCommand
            update26G.Connection = con
            update26G.CommandText = "Update CurrentStock SET Quantity = ('" + calc26G + "') WHERE ([Id] = 20)"
            update26G.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my26GProdId As String = (20)
            Dim cmd26G As New SqlCommand
            ' Get Quantity Number
            Dim my26GQuantity As String = CInt(Request.Form("stockline26G"))
            cmd26G.Connection = con
            cmd26G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my26GProdId + "', '" + my26GQuantity + "')"
            cmd26G.ExecuteNonQuery()

            ' Update Current Stock 26G
            Dim Quantity26G As String = "SELECT Quantity from CurrentStock WHERE Id = 20"
            Dim Stock26G As New SqlCommand(Quantity26G, FreshlinkToDB)
            Dim CS26G As Integer = CInt(Stock26G.ExecuteScalar())
            Dim calc26G As String = CInt(CS26G - my26GQuantity)

            Dim update26G As New SqlCommand
            update26G.Connection = con
            update26G.CommandText = "Update CurrentStock SET Quantity = ('" + calc26G + "') WHERE ([Id] = 20)"
            update26G.ExecuteNonQuery()

        End If

        '   Start of Stock Out Line for 24"

        Dim check24 = Request.Form("stockline24")
        If Request.Form("stockline24") = String.Empty Then
            ' Declare Product Id
            Dim my24ProdId As String = (21)
            Dim cmd24 As New SqlCommand
            ' Get Quantity Number
            Dim my24Quantity As String = CInt(0)
            cmd24.Connection = con
            cmd24.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my24ProdId + "', '" + my24Quantity + "')"
            cmd24.ExecuteNonQuery()

            ' Update Current Stock 24
            Dim Quantity24 As String = "SELECT Quantity from CurrentStock WHERE Id = 21"
            Dim Stock24 As New SqlCommand(Quantity24, FreshlinkToDB)
            Dim CS24 As Integer = CInt(Stock24.ExecuteScalar())
            Dim calc24 As String = CInt(CS24 - my24Quantity)

            Dim update24 As New SqlCommand
            update24.Connection = con
            update24.CommandText = "Update CurrentStock SET Quantity = ('" + calc24 + "') WHERE ([Id] = 21)"
            update24.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my24ProdId As String = (21)
            Dim cmd24 As New SqlCommand
            ' Get Quantity Number
            Dim my24Quantity As String = CInt(Request.Form("stockline24"))
            cmd24.Connection = con
            cmd24.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my24ProdId + "', '" + my24Quantity + "')"
            cmd24.ExecuteNonQuery()

            ' Update Current Stock 24
            Dim Quantity24 As String = "SELECT Quantity from CurrentStock WHERE Id = 21"
            Dim Stock24 As New SqlCommand(Quantity24, FreshlinkToDB)
            Dim CS24 As Integer = CInt(Stock24.ExecuteScalar())
            Dim calc24 As String = CInt(CS24 - my24Quantity)

            Dim update24 As New SqlCommand
            update24.Connection = con
            update24.CommandText = "Update CurrentStock SET Quantity = ('" + calc24 + "') WHERE ([Id] = 21)"
            update24.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 24B"

        Dim check24B = Request.Form("stockline24B")
        If Request.Form("stockline24B") = String.Empty Then
            ' Declare Product Id
            Dim my24BProdId As String = (22)
            Dim cmd24B As New SqlCommand
            ' Get Quantity Number
            Dim my24BQuantity As String = CInt(0)
            cmd24B.Connection = con
            cmd24B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my24BProdId + "', '" + my24BQuantity + "')"
            cmd24B.ExecuteNonQuery()

            ' Update Current Stock 24B
            Dim Quantity24B As String = "SELECT Quantity from CurrentStock WHERE Id = 22"
            Dim Stock24B As New SqlCommand(Quantity24B, FreshlinkToDB)
            Dim CS24B As Integer = CInt(Stock24B.ExecuteScalar())
            Dim calc24B As String = CInt(CS24B - my24BQuantity)

            Dim update24B As New SqlCommand
            update24B.Connection = con
            update24B.CommandText = "Update CurrentStock SET Quantity = ('" + calc24B + "') WHERE ([Id] = 22)"
            update24B.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my24BProdId As String = (22)
            Dim cmd24B As New SqlCommand
            ' Get Quantity Number
            Dim my24BQuantity As String = CInt(0)
            cmd24B.Connection = con
            cmd24B.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my24BProdId + "', '" + my24BQuantity + "')"
            cmd24B.ExecuteNonQuery()

            ' Update Current Stock 24B
            Dim Quantity24B As String = "SELECT Quantity from CurrentStock WHERE Id = 22"
            Dim Stock24B As New SqlCommand(Quantity24B, FreshlinkToDB)
            Dim CS24B As Integer = CInt(Stock24B.ExecuteScalar())
            Dim calc24B As String = CInt(CS24B - my24BQuantity)

            Dim update24B As New SqlCommand
            update24B.Connection = con
            update24B.CommandText = "Update CurrentStock SET Quantity = ('" + calc24B + "') WHERE ([Id] = 22)"
            update24B.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 24P"

        Dim check24P = Request.Form("stockline24P")
        If Request.Form("stockline24P") = String.Empty Then
            ' Declare Product Id
            Dim my24PProdId As String = (23)
            Dim cmd24P As New SqlCommand
            ' Get Quantity Number
            Dim my24PQuantity As String = CInt(0)
            cmd24P.Connection = con
            cmd24P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my24PProdId + "', '" + my24PQuantity + "')"
            cmd24P.ExecuteNonQuery()

            ' Update Current Stock 24P
            Dim Quantity24P As String = "SELECT Quantity from CurrentStock WHERE Id = 23"
            Dim Stock24P As New SqlCommand(Quantity24P, FreshlinkToDB)
            Dim CS24P As Integer = CInt(Stock24P.ExecuteScalar())
            Dim calc24P As String = CInt(CS24P - my24PQuantity)

            Dim update24P As New SqlCommand
            update24P.Connection = con
            update24P.CommandText = "Update CurrentStock SET Quantity = ('" + calc24P + "') WHERE ([Id] = 23)"
            update24P.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my24PProdId As String = (23)
            Dim cmd24P As New SqlCommand
            ' Get Quantity Number
            Dim my24PQuantity As String = CInt(Request.Form("stockline24P"))
            cmd24P.Connection = con
            cmd24P.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my24PProdId + "', '" + my24PQuantity + "')"
            cmd24P.ExecuteNonQuery()

            ' Update Current Stock 24P
            Dim Quantity24P As String = "SELECT Quantity from CurrentStock WHERE Id = 23"
            Dim Stock24P As New SqlCommand(Quantity24P, FreshlinkToDB)
            Dim CS24P As Integer = CInt(Stock24P.ExecuteScalar())
            Dim calc24P As String = CInt(CS24P - my24PQuantity)

            Dim update24P As New SqlCommand
            update24P.Connection = con
            update24P.CommandText = "Update CurrentStock SET Quantity = ('" + calc24P + "') WHERE ([Id] = 23)"
            update24P.ExecuteNonQuery()


        End If

        '   Start of Stock Out Line for 24G"

        Dim check24G = Request.Form("stockline24G")
        If Request.Form("stockline24G") = String.Empty Then
            ' Declare Product Id
            Dim my24GProdId As String = (24)
            Dim cmd24G As New SqlCommand
            ' Get Quantity Number
            Dim my24GQuantity As String = CInt(0)
            cmd24G.Connection = con
            cmd24G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my24GProdId + "', '" + my24GQuantity + "')"
            cmd24G.ExecuteNonQuery()

            ' Update Current Stock 24G
            Dim Quantity24G As String = "SELECT Quantity from CurrentStock WHERE Id = 24"
            Dim Stock24G As New SqlCommand(Quantity24G, FreshlinkToDB)
            Dim CS24G As Integer = CInt(Stock24G.ExecuteScalar())
            Dim calc24G As String = CInt(CS24G - my24GQuantity)

            Dim update24G As New SqlCommand
            update24G.Connection = con
            update24G.CommandText = "Update CurrentStock SET Quantity = ('" + calc24G + "') WHERE ([Id] = 24)"
            update24G.ExecuteNonQuery()
        Else
            ' Declare Product Id
            Dim my24GProdId As String = (24)
            Dim cmd24G As New SqlCommand
            ' Get Quantity Number
            Dim my24GQuantity As String = CInt(Request.Form("stockline24G"))
            cmd24G.Connection = con
            cmd24G.CommandText = "Insert INTO StockOutLine(date, StockOutID, ProductID, Quantity) VALUES ('" + myDate + "', '" + myGetRecordID + "', '" + my24GProdId + "', '" + my24GQuantity + "')"
            cmd24G.ExecuteNonQuery()

            ' Update Current Stock 24G
            Dim Quantity24G As String = "SELECT Quantity from CurrentStock WHERE Id = 24"
            Dim Stock24G As New SqlCommand(Quantity24G, FreshlinkToDB)
            Dim CS24G As Integer = CInt(Stock24G.ExecuteScalar())
            Dim calc24G As String = CInt(CS24G - my24GQuantity)

            Dim update24G As New SqlCommand
            update24G.Connection = con
            update24G.CommandText = "Update CurrentStock SET Quantity = ('" + calc24G + "') WHERE ([Id] = 24)"
            update24G.ExecuteNonQuery()


        End If

        Server.Transfer("Reports.aspx")
        con.Close()
        linkToDB.Close()
        FreshlinkToDB.Close()


    End Sub

End Class
