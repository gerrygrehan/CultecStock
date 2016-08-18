<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="EditCurrentStock.aspx.vb" Inherits="EditCurrentStock" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!--
    EditCurrentStock.aspx
    Date 20-7-16
    @author Gerry Grehan, 14104911

     --><br /> 
    <div class="row">
        <div class="col-md-8 col-md-offset-2">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" DeleteCommand="DELETE FROM [CurrentStock] WHERE [Id] = @Id" InsertCommand="INSERT INTO [CurrentStock] ([Name], [Quantity]) VALUES (@Name, @Quantity)" SelectCommand="SELECT * FROM [CurrentStock]" UpdateCommand="UPDATE [CurrentStock] SET [Name] = @Name, [Quantity] = @Quantity WHERE [Id] = @Id">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Quantity" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Name" Type="String" />
                    <asp:Parameter Name="Quantity" Type="String" />
                    <asp:Parameter Name="Id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" CssClass="table">
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
        </div>
    </div>
</asp:Content>

