<%@ Page Title="Manage Purchase Orders" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="ManagePurchaseOrders.aspx.vb" Inherits="ManagePurchaseOrders" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!--
    ManagePurchaseOrders.aspx
    Date 20-7-16
    @author Gerry Grehan, 14104911

     --><br /> 
    <div class="row">
		<div class="col-md-8 col-md-offset-2">
            <div class="row">
                <h2>Change Order from in Production to Shipped</h2>
            <div class="col-md-4">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [POId] FROM [PurchaseOrder] WHERE ([Status] = @Status)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="1" Name="Status" Type="Int32" />
                </SelectParameters>
                </asp:SqlDataSource>
                <asp:Label ID="Label1" runat="server" Text="Select a Purchase Order"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="POId" DataValueField="POId" CssClass="btn btn-default btn-lg btn-block">
                </asp:DropDownList>
            </div>
            <div class="col-md-4">
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Status] FROM [Status] WHERE ([Id] = @Id)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="2" Name="Id" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:Label ID="Label2" runat="server" Text="Select a Status"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Status" DataValueField="Status" CssClass="btn btn-default btn-lg btn-block">
                </asp:DropDownList>
                <br />
            </div>
            <div class="col-md-4">
                <asp:Label ID="Label3" runat="server" Text="Change Status"></asp:Label>
                <asp:Button ID="Button1" runat="server" Text="Update" OnClick="changeStatusShipped" CssClass="btn btn-default btn-lg btn-block" />
            </div>
            
            </div>
            <div class="row">
                <h2>Change Order from Shipped to Delivered</h2>
            <div class="col-md-4">
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [POId] FROM [PurchaseOrder] WHERE ([Status] = @Status)">
                <SelectParameters>
                    <asp:Parameter DefaultValue="2" Name="Status" Type="Int32" />
                </SelectParameters>
                </asp:SqlDataSource>
                <asp:Label ID="Label4" runat="server" Text="Select a Purchase Order"></asp:Label>
                <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="POId" DataValueField="POId" CssClass="btn btn-default btn-lg btn-block">
                </asp:DropDownList>
            </div>
            <div class="col-md-4">
                <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Status] FROM [Status] WHERE ([Id] = @Id)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="3" Name="Id" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:Label ID="Label5" runat="server" Text="Select a Status"></asp:Label>
                <br />
                <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource4" DataTextField="Status" DataValueField="Status" CssClass="btn btn-default btn-lg btn-block">
                </asp:DropDownList>
                <br />
            </div>
            <div class="col-md-4">
                <asp:Label ID="Label6" runat="server" Text="Change Status"></asp:Label>
                <asp:Button ID="Button2" runat="server" Text="Update" OnClick="changeStatusDelivered" CssClass="btn btn-default btn-lg btn-block" />
            </div>
            
            </div>
        </div>
     </div>
</asp:Content>

