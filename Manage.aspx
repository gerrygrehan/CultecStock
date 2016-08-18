<%@ Page Title="Manage Site" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Manage.aspx.vb" Inherits="Manage" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server"> 
  <!--
    Manage.aspx
    Date 20-7-16
    @author Gerry Grehan, 14104911

     -->  
<div class="row">   
    <div class="col-md-8 col-md-offset-2">
        <br /> 
        <a runat="server" href="~/ManageCustomers" class="btn btn-primary btn-lg btn-block" >Manage Customers</a>
        <br />
        <a runat="server" href="~/EditCurrentStock" class="btn btn-primary btn-lg btn-block" >Manage Current Stock</a>
        <br />
        <a runat="server" href="~/ManagePurchaseOrders" class="btn btn-primary btn-lg btn-block" >Manage Purchase Orders</a>
    </div>
</div> 
</asp:Content>

