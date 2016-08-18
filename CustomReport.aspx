<%@ Page Title="Custom Reports" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="CustomReport.aspx.vb" Inherits="CustomReport" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">

   <!--
    CustomReport.aspx
    Date 20-7-16
    @author Gerry Grehan, 14104911

     -->
        <div class="row">
                <h2>Generate Custom Reports from Stock Out</h2>
            <div class="col-md-3">
                <asp:Label ID="Label1" runat="server" Text="Select a Customer / Category"></asp:Label>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" SelectCommand="SELECT [Name] FROM [Customer] ORDER BY [Name]"></asp:SqlDataSource>
                <asp:DropDownList ID="selectCustomer" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name" CssClass="btn btn-default btn-lg btn-block">
                </asp:DropDownList>
            </div>
            <div class="col-md-3">
                <asp:Label ID="Label2" runat="server" Text="Start Date"></asp:Label>
                <div class="form-group ">
                        <input class="btn btn-default btn-lg btn-block" ID="startDate" name="startDate" type="date" value="<%: DateTime.Now.AddMonths(-1).ToString("yyyy/MM/dd")%>"/>
                        <!-- @reference StackOverFlow (2016) HTML5 input type date -- default value to today? Available at: http://stackoverflow.com/questions/6982692/html5-input-type-date-default-value-to-today (Accessed: 15 July 2016) -->
                        <!-- @reference StackOverFlow (2016) How to add months to a date in JavaScript? Available at: http://stackoverflow.com/questions/6982692/html5-input-type-date-default-value-to-today (Accessed: 15 July 2016) -->
                    <script type="text/javascript">
                        var CurrentDateBackMonth = new Date();
                        CurrentDateBackMonth.setMonth(CurrentDateBackMonth.getMonth()-1);
                        document.getElementById('startDate').valueAsDate = CurrentDateBackMonth;
                    </script> 
                </div>
            </div>
            <div class="col-md-3">
                <asp:Label ID="Label3" runat="server" Text="End Date"></asp:Label>
                <div class="form-group ">
                        <!-- @reference StackOverFlow (2016) HTML5 input type date -- default value to today? Available at: http://stackoverflow.com/questions/6982692/html5-input-type-date-default-value-to-today (Accessed: 15 July 2016) -->
                        <!-- @reference StackOverFlow (2016) How to add months to a date in JavaScript? Available at: http://stackoverflow.com/questions/6982692/html5-input-type-date-default-value-to-today (Accessed: 15 July 2016) -->
                        <input class="btn btn-default btn-lg btn-block" ID="endDate"  name="endDate" type="date" value="<%: DateTime.Now.ToString("yyyy/MM/dd")%>"/>
                        <script type="text/javascript">
                        var CurrentDate = new Date();
                        CurrentDate.setMonth(CurrentDate.getMonth());
                        document.getElementById('endDate').valueAsDate = CurrentDate;
                    </script> 
                </div>
            </div>
            <div class="col-md-3">
                <asp:Label ID="Label4" runat="server" Text="Go For it!!"></asp:Label>
                <asp:Button ID="Button2" OnClick="generateReport" runat="server" Text="Generate" CssClass="btn btn-default btn-lg btn-block" />
            </div>
        </div>
        <div id="reportTable">
                <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                <asp:PlaceHolder ID="PlaceHolder6" runat="server"></asp:PlaceHolder>
                <asp:PlaceHolder ID="PlaceHolder7" runat="server"></asp:PlaceHolder>
                <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
                <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
                <asp:PlaceHolder ID="PlaceHolder5" runat="server"></asp:PlaceHolder>
        </div>

</asp:Content>

