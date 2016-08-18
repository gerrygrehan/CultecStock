Imports System.Data
Imports System.Data.SqlClient

Partial Class StockOverview
    Inherits System.Web.UI.Page

    Private Property poName As String


    '@reference Hamill, D. (2016) "Week 7 - Website Authentication & Site Links". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.Page.User.Identity.IsAuthenticated Then
            FormsAuthentication.RedirectToLoginPage()
        End If
    End Sub

    Sub CreatePurchaseOrder(Sender As Object, E As EventArgs)

        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
        ' Set Connection and Open
        Dim linkToDB As New SqlConnection()
        linkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        linkToDB.Open()

        ' Get Current Date 
        Dim myPOId As String
        Dim myPODate As String
        Dim myProdDate As String
        myPOId = Request.Form("purchaseOrderId")
        myPODate = Request.Form("purchaseOrderDate")
        myProdDate = Request.Form("productionFinishDate")

        
        '@reference Hamill, D. (2016) "Week 7 - Website Authentication & Site Links". [Lecture] Web Application Development.  National College of Ireland, Dublin, Ireland.
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand

        con.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        con.Open()

        cmd.Connection = con

        cmd.CommandText = "Insert INTO PurchaseOrder(POId, Date, ProductionFinish) VALUES ('" + myPOId + "', '" + myPODate + "', '" + myProdDate + "')"
        cmd.ExecuteNonQuery()


        'Start of the Purchase Order Line Entries
        'Open a new connection
        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
        Dim FreshlinkToDB As New SqlConnection()
        FreshlinkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        FreshlinkToDB.Open()

        ' Get Last Stock Id record   
        Dim sqlGetPORecordID As String = "Select top 1 [Id] from PurchaseOrder Order by [Id] desc"
        Dim dataActionID As New SqlCommand(sqlGetPORecordID, FreshlinkToDB)
        Dim myPORecordID As String = CInt(dataActionID.ExecuteScalar())

        ' @reference Patrick, T. (2010) Microsoft ADO.net Step by Step. California: O’Reilly Media (130-140)
        ' Start of PurchaseOrder Line for 36"
        If Request.Form("stockline36") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity36 As String = CInt(Request.Form("stockline36"))
            ' Declare Product Id
            Dim my36ProdId As String = (1)
            Dim cmd36 As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd36.Connection = con
            cmd36.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my36ProdId + "', '" + myPORecordID + "', '" + quantity36 + "')"
            cmd36.ExecuteNonQuery()

        End If

        If Request.Form("stockline35") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity35 As String = CInt(Request.Form("stockline35"))
            ' Declare Product Id
            Dim my35ProdId As String = (2)
            Dim cmd35 As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd35.Connection = con
            cmd35.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my35ProdId + "', '" + myPORecordID + "', '" + quantity35 + "')"
            cmd35.ExecuteNonQuery()

        End If

        If Request.Form("stockline34") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity34 As String = CInt(Request.Form("stockline34"))
            ' Declare Product Id
            Dim my34ProdId As String = (3)
            Dim cmd34 As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd34.Connection = con
            cmd34.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my34ProdId + "', '" + myPORecordID + "', '" + quantity34 + "')"
            cmd34.ExecuteNonQuery()

        End If

        If Request.Form("stockline33") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity33 As String = CInt(Request.Form("stockline33"))
            ' Declare Product Id
            Dim my33ProdId As String = (4)
            Dim cmd33 As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd33.Connection = con
            cmd33.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my33ProdId + "', '" + myPORecordID + "', '" + quantity33 + "')"
            cmd33.ExecuteNonQuery()

        End If

        If Request.Form("stockline32") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity32 As String = CInt(Request.Form("stockline32"))
            ' Declare Product Id
            Dim my32ProdId As String = (5)
            Dim cmd32 As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd32.Connection = con
            cmd32.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my32ProdId + "', '" + myPORecordID + "', '" + quantity32 + "')"
            cmd32.ExecuteNonQuery()

        End If

        If Request.Form("stockline32B") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity32B As String = CInt(Request.Form("stockline32B"))
            ' Declare Product Id
            Dim my32BProdId As String = (6)
            Dim cmd32B As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd32B.Connection = con
            cmd32B.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my32BProdId + "', '" + myPORecordID + "', '" + quantity32B + "')"
            cmd32B.ExecuteNonQuery()
        End If

        If Request.Form("stockline32P") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity32P As String = CInt(Request.Form("stockline32P"))
            ' Declare Product Id
            Dim my32PProdId As String = (7)
            Dim cmd32P As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd32P.Connection = con
            cmd32P.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my32PProdId + "', '" + myPORecordID + "', '" + quantity32P + "')"
            cmd32P.ExecuteNonQuery()
        End If

        If Request.Form("stockline32G") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity32G As String = CInt(Request.Form("stockline32G"))
            ' Declare Product Id
            Dim my32GProdId As String = (8)
            Dim cmd32G As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd32G.Connection = con
            cmd32G.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my32GProdId + "', '" + myPORecordID + "', '" + quantity32G + "')"
            cmd32G.ExecuteNonQuery()
        End If

        If Request.Form("stockline30") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity30 As String = CInt(Request.Form("stockline30"))
            ' Declare Product Id
            Dim my30ProdId As String = (9)
            Dim cmd30 As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd30.Connection = con
            cmd30.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my30ProdId + "', '" + myPORecordID + "', '" + quantity30 + "')"
            cmd30.ExecuteNonQuery()

        End If

        If Request.Form("stockline30B") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity30B As String = CInt(Request.Form("stockline30B"))
            ' Declare Product Id
            Dim my30BProdId As String = (10)
            Dim cmd30B As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd30B.Connection = con
            cmd30B.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my30BProdId + "', '" + myPORecordID + "', '" + quantity30B + "')"
            cmd30B.ExecuteNonQuery()
        End If

        If Request.Form("stockline30P") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity30P As String = CInt(Request.Form("stockline30P"))
            ' Declare Product Id
            Dim my30PProdId As String = (11)
            Dim cmd30P As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd30P.Connection = con
            cmd30P.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my30PProdId + "', '" + myPORecordID + "', '" + quantity30P + "')"
            cmd30P.ExecuteNonQuery()
        End If

        If Request.Form("stockline30G") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity30G As String = CInt(Request.Form("stockline30G"))
            ' Declare Product Id
            Dim my30GProdId As String = (12)
            Dim cmd30G As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd30G.Connection = con
            cmd30G.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my30GProdId + "', '" + myPORecordID + "', '" + quantity30G + "')"
            cmd30G.ExecuteNonQuery()
        End If

        If Request.Form("stockline28") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity28 As String = CInt(Request.Form("stockline28"))
            ' Declare Product Id
            Dim my28ProdId As String = (13)
            Dim cmd28 As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd28.Connection = con
            cmd28.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my28ProdId + "', '" + myPORecordID + "', '" + quantity28 + "')"
            cmd28.ExecuteNonQuery()

        End If

        If Request.Form("stockline28B") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity28B As String = CInt(Request.Form("stockline28B"))
            ' Declare Product Id
            Dim my28BProdId As String = (14)
            Dim cmd28B As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd28B.Connection = con
            cmd28B.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my28BProdId + "', '" + myPORecordID + "', '" + quantity28B + "')"
            cmd28B.ExecuteNonQuery()
        End If

        If Request.Form("stockline28P") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity28P As String = CInt(Request.Form("stockline28P"))
            ' Declare Product Id
            Dim my28PProdId As String = (15)
            Dim cmd28P As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd28P.Connection = con
            cmd28P.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my28PProdId + "', '" + myPORecordID + "', '" + quantity28P + "')"
            cmd28P.ExecuteNonQuery()
        End If

        If Request.Form("stockline28G") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity28G As String = CInt(Request.Form("stockline28G"))
            ' Declare Product Id
            Dim my28GProdId As String = (16)
            Dim cmd28G As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd28G.Connection = con
            cmd28G.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my28GProdId + "', '" + myPORecordID + "', '" + quantity28G + "')"
            cmd28G.ExecuteNonQuery()
        End If

        If Request.Form("stockline26") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity26 As String = CInt(Request.Form("stockline26"))
            ' Declare Product Id
            Dim my26ProdId As String = (17)
            Dim cmd26 As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd26.Connection = con
            cmd26.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my26ProdId + "', '" + myPORecordID + "', '" + quantity26 + "')"
            cmd26.ExecuteNonQuery()

        End If

        If Request.Form("stockline26B") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity26B As String = CInt(Request.Form("stockline26B"))
            ' Declare Product Id
            Dim my26BProdId As String = (18)
            Dim cmd26B As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd26B.Connection = con
            cmd26B.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my26BProdId + "', '" + myPORecordID + "', '" + quantity26B + "')"
            cmd26B.ExecuteNonQuery()
        End If

        If Request.Form("stockline26P") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity26P As String = CInt(Request.Form("stockline26P"))
            ' Declare Product Id
            Dim my26PProdId As String = (19)
            Dim cmd26P As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd26P.Connection = con
            cmd26P.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my26PProdId + "', '" + myPORecordID + "', '" + quantity26P + "')"
            cmd26P.ExecuteNonQuery()
        End If

        If Request.Form("stockline26G") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity26G As String = CInt(Request.Form("stockline26G"))
            ' Declare Product Id
            Dim my26GProdId As String = (20)
            Dim cmd26G As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd26G.Connection = con
            cmd26G.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my26GProdId + "', '" + myPORecordID + "', '" + quantity26G + "')"
            cmd26G.ExecuteNonQuery()
        End If

        If Request.Form("stockline24") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity24 As String = CInt(Request.Form("stockline24"))
            ' Declare Product Id
            Dim my24ProdId As String = (21)
            Dim cmd24 As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd24.Connection = con
            cmd24.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my24ProdId + "', '" + myPORecordID + "', '" + quantity24 + "')"
            cmd24.ExecuteNonQuery()

        End If

        If Request.Form("stockline24B") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity24B As String = CInt(Request.Form("stockline24B"))
            ' Declare Product Id
            Dim my24BProdId As String = (22)
            Dim cmd24B As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd24B.Connection = con
            cmd24B.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my24BProdId + "', '" + myPORecordID + "', '" + quantity24B + "')"
            cmd24B.ExecuteNonQuery()
        End If

        If Request.Form("stockline24P") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity24P As String = CInt(Request.Form("stockline24P"))
            ' Declare Product Id
            Dim my24PProdId As String = (23)
            Dim cmd24P As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd24P.Connection = con
            cmd24P.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my24PProdId + "', '" + myPORecordID + "', '" + quantity24P + "')"
            cmd24P.ExecuteNonQuery()
        End If

        If Request.Form("stockline24G") = String.Empty Then
        Else
            ' Get Quantity Number
            Dim quantity24G As String = CInt(Request.Form("stockline24G"))
            ' Declare Product Id
            Dim my24GProdId As String = (24)
            Dim cmd24G As New SqlCommand
            ' Insert PurchaseOrderLine
            cmd24G.Connection = con
            cmd24G.CommandText = "Insert INTO PurchaseOrderLine (ProductID, PurchaseOrderID, Quantity) VALUES ('" + my24GProdId + "', '" + myPORecordID + "', '" + quantity24G + "')"
            cmd24G.ExecuteNonQuery()
        End If


        ' Repeat for the rest of the sizes
        FreshlinkToDB.Close()
        Server.Transfer("StockOverview.aspx")

    End Sub

    Function createOrderedTable()

        Dim linkToDB As New SqlConnection()
        linkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        linkToDB.Open()

        'http://stackoverflow.com/questions/11652823/how-to-store-sql-query-value-into-array
        ' Find Status = 1 (Order in Production) 
        Dim sqlGetPOId As String = "SELECT Id from PurchaseOrder Where ([status] = 1) Order by [Id] desc"
        Dim comGetPOId As New SqlCommand(sqlGetPOId, linkToDB)
        Dim listId As New List(Of Integer)

        Using reader As SqlDataReader = comGetPOId.ExecuteReader()
            While reader.Read()
                listId.Add(reader.GetInt32(reader.GetOrdinal("Id")))
            End While
        End Using
        Dim maybe As String = String.Join(",", listId)

        For Each POId As String In listId

            Dim currentPOId = POId
            Dim sqlGetPurchaseOrderName As String = "SELECT POId from PurchaseOrder Where ([Id] = '" + currentPOId + "')"
            Dim comGetName As New SqlCommand(sqlGetPurchaseOrderName, linkToDB)
            Dim poName As String = CStr(comGetName.ExecuteScalar())

            Dim sqlGetPODate As String = "SELECT Date from PurchaseOrder Where ([Id] = '" + currentPOId + "')"
            Dim comGetPODate As New SqlCommand(sqlGetPODate, linkToDB)
            Dim poDate As String = CStr(comGetPODate.ExecuteScalar())

            Dim sqlGetFinishDate As String = "SELECT ProductionFinish from PurchaseOrder Where ([Id] = '" + currentPOId + "')"
            Dim comGetFinishDate As New SqlCommand(sqlGetFinishDate, linkToDB)
            Dim poFinishDate As String = CStr(comGetFinishDate.ExecuteScalar())

            Dim sqlGet36Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 1)"
            Dim comGet36Quant As New SqlCommand(sqlGet36Quant, linkToDB)
            Dim quant36 As Integer = CStr(comGet36Quant.ExecuteScalar())
            

            Dim sqlGet35Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 2)"
            Dim comGet35Quant As New SqlCommand(sqlGet35Quant, linkToDB)
            Dim quant35 As Integer = CStr(comGet35Quant.ExecuteScalar())

            Dim sqlGet34Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 3)"
            Dim comGet34Quant As New SqlCommand(sqlGet34Quant, linkToDB)
            Dim quant34 As Integer = CStr(comGet34Quant.ExecuteScalar())

            Dim sqlGet33Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 4)"
            Dim comGet33Quant As New SqlCommand(sqlGet33Quant, linkToDB)
            Dim quant33 As Integer = CStr(comGet33Quant.ExecuteScalar())

            Dim sqlGet32Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 5)"
            Dim comGet32Quant As New SqlCommand(sqlGet32Quant, linkToDB)
            Dim quant32 As Integer = CStr(comGet32Quant.ExecuteScalar())

            Dim sqlGet32BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 6)"
            Dim comGet32BQuant As New SqlCommand(sqlGet32BQuant, linkToDB)
            Dim quant32B As Integer = CStr(comGet32BQuant.ExecuteScalar())

            Dim sqlGet32PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 7)"
            Dim comGet32PQuant As New SqlCommand(sqlGet32PQuant, linkToDB)
            Dim quant32P As Integer = CStr(comGet32PQuant.ExecuteScalar())

            Dim sqlGet32GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 8)"
            Dim comGet32GQuant As New SqlCommand(sqlGet32GQuant, linkToDB)
            Dim quant32G As Integer = CStr(comGet32GQuant.ExecuteScalar())

            Dim sqlGet30Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 9)"
            Dim comGet30Quant As New SqlCommand(sqlGet30Quant, linkToDB)
            Dim quant30 As Integer = CStr(comGet30Quant.ExecuteScalar())

            Dim sqlGet30BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 10)"
            Dim comGet30BQuant As New SqlCommand(sqlGet30BQuant, linkToDB)
            Dim quant30B As Integer = CStr(comGet30BQuant.ExecuteScalar())

            Dim sqlGet30PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 11)"
            Dim comGet30PQuant As New SqlCommand(sqlGet30PQuant, linkToDB)
            Dim quant30P As Integer = CStr(comGet30PQuant.ExecuteScalar())

            Dim sqlGet30GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 12)"
            Dim comGet30GQuant As New SqlCommand(sqlGet30GQuant, linkToDB)
            Dim quant30G As Integer = CStr(comGet30GQuant.ExecuteScalar())

            Dim sqlGet28Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 13)"
            Dim comGet28Quant As New SqlCommand(sqlGet28Quant, linkToDB)
            Dim quant28 As Integer = CStr(comGet28Quant.ExecuteScalar())

            Dim sqlGet28BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 14)"
            Dim comGet28BQuant As New SqlCommand(sqlGet28BQuant, linkToDB)
            Dim quant28B As Integer = CStr(comGet28BQuant.ExecuteScalar())

            Dim sqlGet28PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 15)"
            Dim comGet28PQuant As New SqlCommand(sqlGet28PQuant, linkToDB)
            Dim quant28P As Integer = CStr(comGet28PQuant.ExecuteScalar())

            Dim sqlGet28GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 16)"
            Dim comGet28GQuant As New SqlCommand(sqlGet28GQuant, linkToDB)
            Dim quant28G As Integer = CStr(comGet28GQuant.ExecuteScalar())

            Dim sqlGet26Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 17)"
            Dim comGet26Quant As New SqlCommand(sqlGet26Quant, linkToDB)
            Dim quant26 As Integer = CStr(comGet26Quant.ExecuteScalar())

            Dim sqlGet26BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 18)"
            Dim comGet26BQuant As New SqlCommand(sqlGet26BQuant, linkToDB)
            Dim quant26B As Integer = CStr(comGet26BQuant.ExecuteScalar())

            Dim sqlGet26PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 19)"
            Dim comGet26PQuant As New SqlCommand(sqlGet26PQuant, linkToDB)
            Dim quant26P As Integer = CStr(comGet26PQuant.ExecuteScalar())

            Dim sqlGet26GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 20)"
            Dim comGet26GQuant As New SqlCommand(sqlGet26GQuant, linkToDB)
            Dim quant26G As Integer = CStr(comGet26GQuant.ExecuteScalar())

            Dim sqlGet24Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 21)"
            Dim comGet24Quant As New SqlCommand(sqlGet24Quant, linkToDB)
            Dim quant24 As Integer = CStr(comGet24Quant.ExecuteScalar())

            Dim sqlGet24BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 22)"
            Dim comGet24BQuant As New SqlCommand(sqlGet24BQuant, linkToDB)
            Dim quant24B As Integer = CStr(comGet24BQuant.ExecuteScalar())

            Dim sqlGet24PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 23)"
            Dim comGet24PQuant As New SqlCommand(sqlGet24PQuant, linkToDB)
            Dim quant24P As Integer = CStr(comGet24PQuant.ExecuteScalar())

            Dim sqlGet24GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 24)"
            Dim comGet24GQuant As New SqlCommand(sqlGet24GQuant, linkToDB)
            Dim quant24G As Integer = CStr(comGet24GQuant.ExecuteScalar())

            Dim total32 As Integer = quant32 + quant32B + quant32P + quant32G
            Dim total30 As Integer = quant30 + quant30B + quant30P + quant30G
            Dim total28 As Integer = quant28 + quant28B + quant28P + quant28G
            Dim total26 As Integer = quant26 + quant26B + quant26P + quant26G
            Dim total24 As Integer = quant24 + quant24B + quant24P + quant24G
            Dim totalPlain As Integer = quant36 + quant35 + quant34 + quant34 + quant33 + quant32 + quant30 + quant28 + quant26 + quant24
            Dim totalBlue As Integer = quant32B + quant30B + quant28B + quant26B + quant24B
            Dim totalPink As Integer = quant32P + quant30P + quant28P + quant26P + quant24P
            Dim totalGreen As Integer = quant32G + quant30G + quant28G + quant26G + quant24G
            Dim total As Integer = totalPlain + totalBlue + totalPink + totalGreen

            

            Response.Write("<div class=""col-md-6"">" _
                           & "<h3>Stock Ordered</h3>" _
                           & "<div class=""row"">" _
                                & "<div class=""col-md-4"">" _
                                   & "<div class=""form-group"">" _
                                      & "<h6>PO Number</h6>" _
                                        & "<p class=""btn btn-default btn-block"">" & poName & "</>" _
                                    & "</div>" _
                                & "</div>" _
                                & "<div class=""col-md-4"">" _
                                   & "<div class=""form-group"">" _
                                      & "<h6>PO Date</h6>" _
                                        & "<p class=""btn btn-default btn-block"">" & poDate & "</>" _
                                    & "</div>" _
                                & "</div>" _
                                & "<div class=""col-md-4"">" _
                                   & "<div class=""form-group"">" _
                                      & "<h6>Production Date</h6>" _
                                        & "<p class=""btn btn-default btn-block"">" & poFinishDate & "</>" _
                                    & "</div>" _
                                & "</div>" _
                           & "</div>" _
                           & "<table class=""table table-bordered"" id=""table"">" _
                                & "<thead>" _
                                    & "<tr>" _
                                        & "<td><strong>Size</strong></td>" _
                                        & "<td><strong>Plain</strong></td>" _
                                        & "<td><strong>Blue</strong></td>" _
                                        & "<td><strong>Pink</strong></td>" _
                                        & "<td><strong>Green</strong></td>" _
                                        & "<td><strong>Totals</strong></td>" _
                                    & "</tr>" _
                                & "</thead>" _
                                & "<tbody>" _
                                    & "<tr>" _
                                        & "<td><strong>36</strong></td>" _
                                        & "<td>" & quant36 & "</td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td><strong>" & quant36 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                    & "<td><strong>35</strong></td>" _
                                        & "<td>" & quant35 & "</td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td><strong>" & quant35 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                    & "<td><strong>34</strong></td>" _
                                        & "<td>" & quant34 & "</td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td><strong>" & quant34 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                    & "<td><strong>33</strong></td>" _
                                        & "<td>" & quant33 & "</td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td><strong>" & quant33 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>32</strong></td>" _
                                        & "<td>" & quant32 & "</td>" _
                                        & "<td class=""blue"">" & quant32B & "</td>" _
                                        & "<td class=""warning"">" & quant32P & "</td>" _
                                        & "<td class=""success"">" & quant32G & "</td>" _
                                        & "<td><strong>" & total32 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>30</strong></td>" _
                                        & "<td>" & quant30 & "</td>" _
                                        & "<td class=""blue"">" & quant30B & "</td>" _
                                        & "<td class=""warning"">" & quant30P & "</td>" _
                                        & "<td class=""success"">" & quant30G & "</td>" _
                                        & "<td><strong>" & total30 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>28</strong></td>" _
                                        & "<td>" & quant28 & "</td>" _
                                        & "<td class=""blue"">" & quant28B & "</td>" _
                                        & "<td class=""warning"">" & quant28P & "</td>" _
                                        & "<td class=""success"">" & quant28G & "</td>" _
                                        & "<td><strong>" & total28 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>26</strong></td>" _
                                        & "<td>" & quant26 & "</td>" _
                                        & "<td class=""blue"">" & quant26B & "</td>" _
                                        & "<td class=""warning"">" & quant26P & "</td>" _
                                        & "<td class=""success"">" & quant26G & "</td>" _
                                        & "<td><strong>" & total26 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>24</strong></td>" _
                                        & "<td>" & quant24 & "</td>" _
                                        & "<td class=""blue"">" & quant24B & "</td>" _
                                        & "<td class=""warning"">" & quant24P & "</td>" _
                                        & "<td class=""success"">" & quant24G & "</td>" _
                                        & "<td><strong>" & total24 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>Totals</strong></td>" _
                                        & "<td><strong>" & totalPlain & "</strong></td>" _
                                        & "<td><strong>" & totalBlue & "</strong></td>" _
                                        & "<td><strong>" & totalPink & "</strong></td>" _
                                        & "<td><strong>" & totalGreen & "</strong></td>" _
                                        & "<td><strong>" & total & "</strong></td>" _
                                    & "</tr>" _
                                & "</body>" _
                           & "</table>" _
                        & "</div>"
)

        Next

            linkToDB.Close()
    End Function

    Function createShippedTable()

        Dim linkToDB As New SqlConnection()
        linkToDB.ConnectionString = ConfigurationManager.ConnectionStrings("DefaultConnection").ToString()
        linkToDB.Open()

        'http://stackoverflow.com/questions/11652823/how-to-store-sql-query-value-into-array
        ' Find Status = 2 (Order Shipped) 
        Dim sqlGetPOId As String = "SELECT Id from PurchaseOrder Where ([status] = 2) Order by [Id] desc"
        Dim comGetPOId As New SqlCommand(sqlGetPOId, linkToDB)
        Dim listId As New List(Of Integer)

        Using reader As SqlDataReader = comGetPOId.ExecuteReader()
            While reader.Read()
                listId.Add(reader.GetInt32(reader.GetOrdinal("Id")))
            End While
        End Using
        Dim maybe As String = String.Join(",", listId)

        For Each POId As String In listId

            Dim currentPOId = POId
            Dim sqlGetPurchaseOrderName As String = "SELECT POId from PurchaseOrder Where ([Id] = '" + currentPOId + "')"
            Dim comGetName As New SqlCommand(sqlGetPurchaseOrderName, linkToDB)
            Dim poName As String = CStr(comGetName.ExecuteScalar())

            Dim sqlGetPODate As String = "SELECT Date from PurchaseOrder Where ([Id] = '" + currentPOId + "')"
            Dim comGetPODate As New SqlCommand(sqlGetPODate, linkToDB)
            Dim poDate As String = CStr(comGetPODate.ExecuteScalar())

            Dim sqlGetFinishDate As String = "SELECT ProductionFinish from PurchaseOrder Where ([Id] = '" + currentPOId + "')"
            Dim comGetFinishDate As New SqlCommand(sqlGetFinishDate, linkToDB)
            Dim poFinishDate As String = CStr(comGetFinishDate.ExecuteScalar())

            Dim sqlGet36Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 1)"
            Dim comGet36Quant As New SqlCommand(sqlGet36Quant, linkToDB)
            Dim quant36 As Integer = CStr(comGet36Quant.ExecuteScalar())


            Dim sqlGet35Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 2)"
            Dim comGet35Quant As New SqlCommand(sqlGet35Quant, linkToDB)
            Dim quant35 As Integer = CStr(comGet35Quant.ExecuteScalar())

            Dim sqlGet34Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 3)"
            Dim comGet34Quant As New SqlCommand(sqlGet34Quant, linkToDB)
            Dim quant34 As Integer = CStr(comGet34Quant.ExecuteScalar())

            Dim sqlGet33Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 4)"
            Dim comGet33Quant As New SqlCommand(sqlGet33Quant, linkToDB)
            Dim quant33 As Integer = CStr(comGet33Quant.ExecuteScalar())

            Dim sqlGet32Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 5)"
            Dim comGet32Quant As New SqlCommand(sqlGet32Quant, linkToDB)
            Dim quant32 As Integer = CStr(comGet32Quant.ExecuteScalar())

            Dim sqlGet32BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 6)"
            Dim comGet32BQuant As New SqlCommand(sqlGet32BQuant, linkToDB)
            Dim quant32B As Integer = CStr(comGet32BQuant.ExecuteScalar())

            Dim sqlGet32PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 7)"
            Dim comGet32PQuant As New SqlCommand(sqlGet32PQuant, linkToDB)
            Dim quant32P As Integer = CStr(comGet32PQuant.ExecuteScalar())

            Dim sqlGet32GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 8)"
            Dim comGet32GQuant As New SqlCommand(sqlGet32GQuant, linkToDB)
            Dim quant32G As Integer = CStr(comGet32GQuant.ExecuteScalar())

            Dim sqlGet30Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 9)"
            Dim comGet30Quant As New SqlCommand(sqlGet30Quant, linkToDB)
            Dim quant30 As Integer = CStr(comGet30Quant.ExecuteScalar())

            Dim sqlGet30BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 10)"
            Dim comGet30BQuant As New SqlCommand(sqlGet30BQuant, linkToDB)
            Dim quant30B As Integer = CStr(comGet30BQuant.ExecuteScalar())

            Dim sqlGet30PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 11)"
            Dim comGet30PQuant As New SqlCommand(sqlGet30PQuant, linkToDB)
            Dim quant30P As Integer = CStr(comGet30PQuant.ExecuteScalar())

            Dim sqlGet30GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 12)"
            Dim comGet30GQuant As New SqlCommand(sqlGet30GQuant, linkToDB)
            Dim quant30G As Integer = CStr(comGet30GQuant.ExecuteScalar())

            Dim sqlGet28Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 13)"
            Dim comGet28Quant As New SqlCommand(sqlGet28Quant, linkToDB)
            Dim quant28 As Integer = CStr(comGet28Quant.ExecuteScalar())

            Dim sqlGet28BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 14)"
            Dim comGet28BQuant As New SqlCommand(sqlGet28BQuant, linkToDB)
            Dim quant28B As Integer = CStr(comGet28BQuant.ExecuteScalar())

            Dim sqlGet28PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 15)"
            Dim comGet28PQuant As New SqlCommand(sqlGet28PQuant, linkToDB)
            Dim quant28P As Integer = CStr(comGet28PQuant.ExecuteScalar())

            Dim sqlGet28GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 16)"
            Dim comGet28GQuant As New SqlCommand(sqlGet28GQuant, linkToDB)
            Dim quant28G As Integer = CStr(comGet28GQuant.ExecuteScalar())

            Dim sqlGet26Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 17)"
            Dim comGet26Quant As New SqlCommand(sqlGet26Quant, linkToDB)
            Dim quant26 As Integer = CStr(comGet26Quant.ExecuteScalar())

            Dim sqlGet26BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 18)"
            Dim comGet26BQuant As New SqlCommand(sqlGet26BQuant, linkToDB)
            Dim quant26B As Integer = CStr(comGet26BQuant.ExecuteScalar())

            Dim sqlGet26PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 19)"
            Dim comGet26PQuant As New SqlCommand(sqlGet26PQuant, linkToDB)
            Dim quant26P As Integer = CStr(comGet26PQuant.ExecuteScalar())

            Dim sqlGet26GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 20)"
            Dim comGet26GQuant As New SqlCommand(sqlGet26GQuant, linkToDB)
            Dim quant26G As Integer = CStr(comGet26GQuant.ExecuteScalar())

            Dim sqlGet24Quant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 21)"
            Dim comGet24Quant As New SqlCommand(sqlGet24Quant, linkToDB)
            Dim quant24 As Integer = CStr(comGet24Quant.ExecuteScalar())

            Dim sqlGet24BQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 22)"
            Dim comGet24BQuant As New SqlCommand(sqlGet24BQuant, linkToDB)
            Dim quant24B As Integer = CStr(comGet24BQuant.ExecuteScalar())

            Dim sqlGet24PQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 23)"
            Dim comGet24PQuant As New SqlCommand(sqlGet24PQuant, linkToDB)
            Dim quant24P As Integer = CStr(comGet24PQuant.ExecuteScalar())

            Dim sqlGet24GQuant As String = "Select [Quantity] from PurchaseOrderLine WHERE ([PurchaseOrderID] = '" + currentPOId + "') AND ([ProductID] = 24)"
            Dim comGet24GQuant As New SqlCommand(sqlGet24GQuant, linkToDB)
            Dim quant24G As Integer = CStr(comGet24GQuant.ExecuteScalar())

            Dim total32 As Integer = quant32 + quant32B + quant32P + quant32G
            Dim total30 As Integer = quant30 + quant30B + quant30P + quant30G
            Dim total28 As Integer = quant28 + quant28B + quant28P + quant28G
            Dim total26 As Integer = quant26 + quant26B + quant26P + quant26G
            Dim total24 As Integer = quant24 + quant24B + quant24P + quant24G
            Dim totalPlain As Integer = quant36 + quant35 + quant34 + quant34 + quant33 + quant32 + quant30 + quant28 + quant26 + quant24
            Dim totalBlue As Integer = quant32B + quant30B + quant28B + quant26B + quant24B
            Dim totalPink As Integer = quant32P + quant30P + quant28P + quant26P + quant24P
            Dim totalGreen As Integer = quant32G + quant30G + quant28G + quant26G + quant24G
            Dim total As Integer = totalPlain + totalBlue + totalPink + totalGreen

            Response.Write("<div class=""col-md-6"">" _
                           & "<h3>Stock Shipped</h3>" _
                           & "<div class=""row"">" _
                                & "<div class=""col-md-4"">" _
                                   & "<div class=""form-group"">" _
                                      & "<h6>PO Number</h6>" _
                                        & "<p class=""btn btn-default btn-block"">" & poName & "</>" _
                                    & "</div>" _
                                & "</div>" _
                                & "<div class=""col-md-4"">" _
                                   & "<div class=""form-group"">" _
                                      & "<h6>PO Date</h6>" _
                                        & "<p class=""btn btn-default btn-block"">" & poDate & "</>" _
                                    & "</div>" _
                                & "</div>" _
                                & "<div class=""col-md-4"">" _
                                   & "<div class=""form-group"">" _
                                      & "<h6>Production Date</h6>" _
                                        & "<p class=""btn btn-default btn-block"">" & poFinishDate & "</>" _
                                    & "</div>" _
                                & "</div>" _
                           & "</div>" _
                           & "<table class=""table table-bordered"" id=""table"">" _
                                & "<thead>" _
                                    & "<tr>" _
                                        & "<td><strong>Size</strong></td>" _
                                        & "<td><strong>Plain</strong></td>" _
                                        & "<td><strong>Blue</strong></td>" _
                                        & "<td><strong>Pink</strong></td>" _
                                        & "<td><strong>Green</strong></td>" _
                                        & "<td><strong>Totals</strong></td>" _
                                    & "</tr>" _
                                & "</thead>" _
                                & "<tbody>" _
                                    & "<tr>" _
                                        & "<td><strong>36</strong></td>" _
                                        & "<td>" & quant36 & "</td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td><strong>" & quant36 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                    & "<td><strong>35</strong></td>" _
                                        & "<td>" & quant35 & "</td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td><strong>" & quant35 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                    & "<td><strong>34</strong></td>" _
                                        & "<td>" & quant34 & "</td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td><strong>" & quant34 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                    & "<td><strong>33</strong></td>" _
                                        & "<td>" & quant33 & "</td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td class=""grey""></td>" _
                                        & "<td><strong>" & quant33 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>32</strong></td>" _
                                        & "<td>" & quant32 & "</td>" _
                                        & "<td class=""blue"">" & quant32B & "</td>" _
                                        & "<td class=""warning"">" & quant32P & "</td>" _
                                        & "<td class=""success"">" & quant32G & "</td>" _
                                        & "<td><strong>" & total32 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>30</strong></td>" _
                                        & "<td>" & quant30 & "</td>" _
                                        & "<td class=""blue"">" & quant30B & "</td>" _
                                        & "<td class=""warning"">" & quant30P & "</td>" _
                                        & "<td class=""success"">" & quant30G & "</td>" _
                                        & "<td><strong>" & total30 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>28</strong></td>" _
                                        & "<td>" & quant28 & "</td>" _
                                        & "<td class=""blue"">" & quant28B & "</td>" _
                                        & "<td class=""warning"">" & quant28P & "</td>" _
                                        & "<td class=""success"">" & quant28G & "</td>" _
                                        & "<td><strong>" & total28 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>26</strong></td>" _
                                        & "<td>" & quant26 & "</td>" _
                                        & "<td class=""blue"">" & quant26B & "</td>" _
                                        & "<td class=""warning"">" & quant26P & "</td>" _
                                        & "<td class=""success"">" & quant26G & "</td>" _
                                        & "<td><strong>" & total26 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>24</strong></td>" _
                                        & "<td>" & quant24 & "</td>" _
                                        & "<td class=""blue"">" & quant24B & "</td>" _
                                        & "<td class=""warning"">" & quant24P & "</td>" _
                                        & "<td class=""success"">" & quant24G & "</td>" _
                                        & "<td><strong>" & total24 & "</strong></td>" _
                                    & "</tr>" _
                                    & "<tr>" _
                                        & "<td><strong>Totals</strong></td>" _
                                        & "<td><strong>" & totalPlain & "</strong></td>" _
                                        & "<td><strong>" & totalBlue & "</strong></td>" _
                                        & "<td><strong>" & totalPink & "</strong></td>" _
                                        & "<td><strong>" & totalGreen & "</strong></td>" _
                                        & "<td><strong>" & total & "</strong></td>" _
                                    & "</tr>" _
                                & "</body>" _
                           & "</table>" _
                        & "</div>"
)

        Next

        linkToDB.Close()
    End Function

End Class
