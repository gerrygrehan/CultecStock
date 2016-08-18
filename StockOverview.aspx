<%@ Page Title="Stock Overview" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="StockOverview.aspx.vb" Inherits="StockOverview" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
<!--
    StockOut.aspx
    Date 20-7-16
    @author Gerry Grehan, 14104911
-->
    <div class="row">
		<div class="col-md-12">
			<h1>
				Stock Overview</h1>
        </div>
        <div class="row">
                <%= createOrderedTable()%>
        </div>   
        <div class="row">
                <%= createShippedTable()%>
        </div> 
            <div class="row">
                <div class="col-md-8 col-md-offset-2">
                    <h3>Create Purchase Order</h3>
                    <div class="row">
                            <div class="col-md-4">
                                <div class="form-group ">
                                    <h6>PO Number</h6>
                                    <input class="btn btn-default btn-block" name="purchaseOrderId" type="text"/>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="form-group ">
                                    <h6>Order Create Date</h6>
                                    <input class="btn btn-default btn-block" name="purchaseOrderDate" type="text" value="<%: DateTime.Now.ToString("MM/dd/yyyy")%>"/>
                                </div>
                            </div>
                            <div class="col-md-4">
                            <div class="form-group ">
                                    <h6> Est. Production Date</h6>
                                    <input class="btn btn-default btn-block" name="productionFinishDate" type="text" value="<%: DateTime.Now.AddMonths(+1).ToString("MM/dd/yyyy")%>"/>
                            </div>
                        </div>
                
                    </div>
			<table class="table">
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
                       
					</tr>
				</thead>
				<tbody>
					<tr>
						<td>
							<strong>36</strong>
						</td>
						<td>
							<input class="form-control" id="stockline36" name="stockline36" type="text" onBlur="validateStockOut36()"/>
                            
						</td>
						<td class="grey">
						</td>
						<td class="grey">
						</td>
                        <td class="grey">
						</td>
					</tr>
					<tr>
						<td>
							<strong>35</strong>
						</td>
						<td>
							<input class="form-control" name="stockline35" type="text" id="stockline35" onBlur="validateStockOut35()" />
						</td>
						<td class="grey">
						</td>
						<td class="grey">
						</td>
                        <td class="grey">
						</td>
					</tr>
					<tr>
						<td>
							<strong>34</strong>
						</td>
						<td>
							<input class="form-control" name="stockline34" type="text" id="stockline34" onBlur="validateStockOut34()" />
						</td>
						<td class="grey">
						</td>
						<td class="grey">
						</td>
                        <td class="grey">
						</td>
					</tr>
					<tr>
						<td>
							<strong>33</strong>
						</td>
						<td>
							<input class="form-control" name="stockline33" type="text" id="stockline33" onBlur="validateStockOut33()" />
						</td>
						<td class="grey">
						</td>
						<td class="grey">
						</td>
                        <td class="grey">
						</td>
					</tr>
                    <tr>
						<td>
							<strong>32</strong>
						</td>
						<td>
							<input class="form-control" name="stockline32" type="text" id="stockline32" onBlur="validateStockOut32()" />
						</td>
						<td class="blue">
                            <input class="form-control" name="stockline32B" type="text" id="stockline32B" onBlur="validateStockOut32B()" />
						</td>
						<td class="danger">
                            <input class="form-control" name="stockline32P" type="text" id="stockline32P" onBlur="validateStockOut32P()" />
						</td>
                        <td class="success">
                            <input class="form-control" name="stockline32G" type="text" id="stockline32G" onBlur="validateStockOut32G()" />
						</td>
					</tr>
                    <tr>
						<td>
							<strong>30</strong>
						</td>
						<td>
							<input class="form-control" name="stockline30" type="text" id="stockline30" onBlur="validateStockOut30()"/>
						</td>
						<td class="blue">
                            <input class="form-control" name="stockline30B" type="text" id="stockline30B" onBlur="validateStockOut30B()"/>
						</td>
						<td class="danger">
                            <input class="form-control" name="stockline30P" type="text" id="stockline30P" onBlur="validateStockOut30P()"/>
						</td>
                        <td class="success">
                           <input class="form-control" name="stockline30G" type="text" id="stockline30G" onBlur="validateStockOut30G()" />
						</td>
					</tr>
                    <tr>
						<td>
							<strong>28</strong>
						</td>
						<td>
							<input class="form-control" name="stockline28" type="text" id="stockline28" onBlur="validateStockOut28()" />
						</td>
						<td class="blue">
                            <input class="form-control" name="stockline28B" type="text" id="stockline28B" onBlur="validateStockOut28B()"  />
						</td>
						<td class="danger">
                            <input class="form-control" name="stockline28P" type="text" id="stockline28P" onBlur="validateStockOut28P()" />
						</td>
                        <td class="success">
                            <input class="form-control" name="stockline28G" type="text" id="stockline28G" onBlur="validateStockOut28G()" />
						</td>
                     </tr>
                     <tr>
						<td>
							<strong>26</strong>
						</td>
						<td>
							<input class="form-control" name="stockline26" type="text" id="stockline26" onBlur="validateStockOut26()" />
						</td>
						<td class="blue">
                            <input class="form-control" name="stockline26B" type="text" id="stockline26B" onBlur="validateStockOut26B()" />
						</td>
						<td class="danger">
                            <input class="form-control" name="stockline26P" type="text" id="stockline26P" onBlur="validateStockOut26P()" />
						</td>
                        <td class="success">
                            <input class="form-control" name="stockline26G" type="text" id="stockline26G" onBlur="validateStockOut26G()" />
						</td>
                    </tr>
                    <tr>
                        <td>
							<strong>24</strong>
						</td>
						<td>
							<input class="form-control" name="stockline24" type="text" id="stockline24" onBlur="validateStockOut24()" />
						</td>
						<td class="blue">
                            <input class="form-control" name="stockline24B" type="text" id="stockline24B" onBlur="validateStockOut24B()" />
						</td>
						<td class="danger">
                            <input class="form-control" name="stockline24P" type="text" id="stockline24P" onBlur="validateStockOut24P()" />
						</td>
                        <td class="success">
                            <input class="form-control" name="stockline24G" type="text" id="stockline24G" onBlur="validateStockOut24G()"  />
						</td>
					</tr>
                 </tbody>
					
				
			</table> 
                <asp:Button ID="Button1" runat="server" Text="Create Purchase Order" OnClick="CreatePurchaseOrder"   CssClass="btn btn-primary btn-lg btn-block" />
		        </div>
                
            </div>
    </div>
    <!-- Validate input functions Orginally place in scripts/webforms/bootstrap.js but not being called -->
    <script type="text/javascript">
        function validateStockOut36() {

            var input36 = document.getElementById('stockline36');
            if (input36.value == "") {

            } else {

                if (isNaN(input36.value)) {
                    document.getElementById('stockline36').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut35() {

            var input35 = document.getElementById('stockline35');
            if (input35.value == "") {

            } else {

                if (isNaN(input35.value)) {
                    document.getElementById('stockline35').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut34() {

            var input34 = document.getElementById('stockline34');
            if (input34.value == "") {

            } else {

                if (isNaN(input34.value)) {
                    document.getElementById('stockline34').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut33() {

            var input33 = document.getElementById('stockline33');
            if (input33.value == "") {

            } else {

                if (isNaN(input33.value)) {
                    document.getElementById('stockline33').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut32() {

            var input32 = document.getElementById('stockline32');
            if (input32.value == "") {

            } else {

                if (isNaN(input32.value)) {
                    document.getElementById('stockline32').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut32B() {

            var input32B = document.getElementById('stockline32B');
            if (input32B.value == "") {

            } else {

                if (isNaN(input32B.value)) {
                    document.getElementById('stockline32B').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }


        function validateStockOut32P() {

            var input32P = document.getElementById('stockline32P');
            if (input32P.value == "") {

            } else {

                if (isNaN(input32P.value)) {
                    document.getElementById('stockline32P').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut32G() {

            var input32G = document.getElementById('stockline32G');
            if (input32G.value == "") {

            } else {

                if (isNaN(input32G.value)) {
                    document.getElementById('stockline32G').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut30() {

            var input30 = document.getElementById('stockline30');
            if (input30.value == "") {

            } else {

                if (isNaN(input30.value)) {
                    document.getElementById('stockline30').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut30B() {

            var input30B = document.getElementById('stockline30B');
            if (input30B.value == "") {

            } else {

                if (isNaN(input30B.value)) {
                    document.getElementById('stockline30B').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }


        function validateStockOut30P() {

            var input30P = document.getElementById('stockline30P');
            if (input30P.value == "") {

            } else {

                if (isNaN(input30P.value)) {
                    document.getElementById('stockline30P').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut30G() {

            var input30G = document.getElementById('stockline30G');
            if (input30G.value == "") {

            } else {

                if (isNaN(input30G.value)) {
                    document.getElementById('stockline30G').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut28() {

            var input28 = document.getElementById('stockline28');
            if (input28.value == "") {

            } else {

                if (isNaN(input28.value)) {
                    document.getElementById('stockline28').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut28B() {

            var input28B = document.getElementById('stockline28B');
            if (input28B.value == "") {

            } else {

                if (isNaN(input28B.value)) {
                    document.getElementById('stockline28B').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }


        function validateStockOut28P() {

            var input28P = document.getElementById('stockline28P');
            if (input28P.value == "") {

            } else {

                if (isNaN(input28P.value)) {
                    document.getElementById('stockline28P').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut28G() {

            var input28G = document.getElementById('stockline28G');
            if (input28G.value == "") {

            } else {

                if (isNaN(input28G.value)) {
                    document.getElementById('stockline28G').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut26() {

            var input26 = document.getElementById('stockline26');
            if (input26.value == "") {

            } else {

                if (isNaN(input26.value)) {
                    document.getElementById('stockline26').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut26B() {

            var input26B = document.getElementById('stockline26B');
            if (input26B.value == "") {

            } else {

                if (isNaN(input26B.value)) {
                    document.getElementById('stockline26B').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }


        function validateStockOut26P() {

            var input26P = document.getElementById('stockline26P');
            if (input26P.value == "") {

            } else {

                if (isNaN(input26P.value)) {
                    document.getElementById('stockline26P').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut26G() {

            var input26G = document.getElementById('stockline26G');
            if (input26G.value == "") {

            } else {

                if (isNaN(input26G.value)) {
                    document.getElementById('stockline26G').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut24() {

            var input24 = document.getElementById('stockline24');
            if (input24.value == "") {

            } else {

                if (isNaN(input24.value)) {
                    document.getElementById('stockline24').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut24B() {

            var input24B = document.getElementById('stockline24B');
            if (input24B.value == "") {

            } else {

                if (isNaN(input24B.value)) {
                    document.getElementById('stockline24B').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }


        function validateStockOut24P() {

            var input24P = document.getElementById('stockline24P');
            if (input24P.value == "") {

            } else {

                if (isNaN(input24P.value)) {
                    document.getElementById('stockline24P').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

        function validateStockOut24G() {

            var input24G = document.getElementById('stockline24G');
            if (input24G.value == "") {

            } else {

                if (isNaN(input24G.value)) {
                    document.getElementById('stockline24G').style.backgroundColor = "#ff9999";
                    alert("That's not a Number!!");
                } else {
                }
            }
        }

    </script>
</asp:Content>

