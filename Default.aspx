<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<!--
    Default.aspx
    Date 20-7-16
    @author Gerry Grehan, 14104911

     -->
<div class="row">
		<div class="col-md-6">
			<h3>
				Current Stock
			</h3>
			<table class="table table-bordered">
				<thead>
					<tr>
						<th>
							Size
						</th>
						<th>
							Plain 
						</th>
						<th>
							Blue
						</th>
						<th>
							Pink
						</th>
                        <th>
							Green
						</th>
                        <th>
							TOTALS
						</th>
					</tr>
				</thead>
				<tbody>
                    <%= createCurrentStockTable()%>
                </tbody> 
			</table> 
            <a runat="server" href="~/EditCurrentStock" class="btn btn-default" >Edit</a>
		</div>
		<div class="col-md-6">
			<h3>
				Stock Used Monthly
			</h3>
			<table class="table table-bordered">
				<thead>
					<tr>
						<th>
							Size
						</th>
						<th>
							Plain 
						</th>
						<th>
							Blue
						</th>
						<th>
							Pink
						</th>
                        <th>
							Green
						</th>
                        <th>
							TOTALS
						</th>
					</tr>
				</thead>
				<tbody>
					<tr>
						<td>
							<strong>36</strong>
						</td>
						<td>
							<%Response.Write(Session("UM36"))%>
						</td>
						<td class="grey">
						</td>
						<td class="grey">
						</td>
                        <td class="grey">
						</td>
                        <td>
                            <strong><%Response.Write(Session("UM36"))%></strong> <!-- Calculates all sizes on this line -->
						</td>
					</tr>
					<tr>
						<td>
							<strong>35</strong>
						</td>
						<td>
							<%Response.Write(Session("UM35"))%>
						</td>
						<td class="grey">
						</td>
						<td class="grey">
						</td>
                        <td class="grey">
						</td>
                        <td>
                            <strong><%Response.Write(Session("UM35"))%></strong> 
						</td>
					</tr>
					<tr>
						<td>
							<strong>34</strong>
						</td>
						<td>
							<%Response.Write(Session("UM34"))%>
						</td>
						<td class="grey">
						</td>
						<td class="grey">
						</td>
                        <td class="grey">
						</td>
                        <td>
                            <strong><%Response.Write(Session("UM34"))%></strong> 
						</td>
					</tr>
					<tr>
						<td>
							<strong>33</strong>
						</td>
						<td>
							<%Response.Write(Session("UM33"))%>
						</td>
						<td class="grey">
						</td>
						<td class="grey">
						</td>
                        <td class="grey">
						</td>
                        <td>
                            <strong><%Response.Write(Session("UM33"))%></strong> <!-- Calculates all sizes on this line -->
						</td>
					</tr>
                    <tr>
						<td>
							<strong>32</strong>
						</td>
						<td>
							<%Response.Write(Session("UM32"))%>
						</td>
						<td class="blue">
                            <%Response.Write(Session("UM32B"))%>
						</td>
						<td class="danger">
                            <%Response.Write(Session("UM32P"))%>
						</td>
                        <td class="success">
                            <%Response.Write(Session("UM32G"))%>
						</td>
                        <td>
                            <strong><%Response.Write(Session("TotalUM32"))%></strong> <!-- Calculates all sizes on this line -->
						</td>
					</tr>
                    <tr>
						<td>
							<strong>30</strong>
						</td>
						<td>
							<%Response.Write(Session("UM30"))%>
						</td>
						<td class="blue">
                            <%Response.Write(Session("UM30B"))%>
						</td>
						<td class="danger">
                            <%Response.Write(Session("UM30P"))%>
						</td>
                        <td class="success">
                            <%Response.Write(Session("UM30G"))%>
						</td>
                        <td>
                            <strong><%Response.Write(Session("TotalUM30"))%></strong>
						</td>
					</tr>
                    <tr>
						<td>
							<strong>28</strong>
						</td>
						<td>
							<%Response.Write(Session("UM28"))%>
						</td>
						<td class="blue">
                            <%Response.Write(Session("UM28B"))%>
						</td>
						<td class="danger">
                            <%Response.Write(Session("UM28P"))%>
						</td>
                        <td class="success">
                            <%Response.Write(Session("UM28G"))%>
						</td>
                        <td>
                            <strong><%Response.Write(Session("TotalUM30"))%></strong> <!-- Calculates all sizes on this line -->
						</td>
                     </tr>
                     <tr>
						<td>
							<strong>26</strong>
						</td>
						<td>
							<%Response.Write(Session("UM26"))%>
						</td>
						<td class="blue">
                            <%Response.Write(Session("UM26B"))%>
						</td>
						<td class="danger">
                            <%Response.Write(Session("UM26P"))%>
						</td>
                        <td class="success">
                            <%Response.Write(Session("UM26G"))%>
						</td>
                        <td>
                            <strong><%Response.Write(Session("TotalUM28"))%></strong> 
						</td>
                    </tr>
                    <tr>
                        <td>
							<strong>24</strong>
						</td>
						<td>
							<%Response.Write(Session("UM24"))%>
						</td>
						<td class="blue">
                            <%Response.Write(Session("UM24B"))%>
						</td>
						<td class="danger">
                            <%Response.Write(Session("UM24P"))%>
						</td>
                        <td class="success">
                            <%Response.Write(Session("UM24G"))%>
						</td>
                        <td>
                            <strong><%Response.Write(Session("TotalUM24"))%></strong> 
						</td>
					</tr>
                    <tr>
                        <td>
                            <strong>TOTALS</strong>
                        </td>
                        <td>
                            <strong><%Response.Write(Session("TotUsePlain"))%></strong>
                        </td>
                        <td>
                            <strong><%Response.Write(Session("TotUseBlue"))%></strong>
                        </td>
                        <td>
                            <strong><%Response.Write(Session("TotUsePink"))%></strong>
                        </td>
                        <td>
                            <strong><%Response.Write(Session("TotUseGreen"))%></strong>
                        </td>
                        <td>
                            <strong><%Response.Write(Session("TotUsedMonthly"))%></strong>
                        </td>
                    </tr>
					
				</tbody>
			</table> 
			<button type="button" class="btn btn-default">
				Default
			</button>
		</div>
	</div>  
    
    <%Response.Write(Session("comMonthly36"))%>
</asp:Content>
