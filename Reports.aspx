<%@ Page Title="Reports" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Reports.aspx.vb" Inherits="Reports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!--
    ManagePurchaseOrders.aspx
    Date 20-7-16
    @author Gerry Grehan, 14104911

     -->
    <div class="row">
        <br />
        <a class="btn btn-primary btn-lg btn-block" href="CustomReport">Generate Custom Reports</a>
    </div>
    

    <div class="row">
        
        <div class="col-md-12">
            <div>
                <h3>
                    Stock Out Records for Last Month
                </h3>
                <table class="table table-bordered">
                    <thead>
                    <tr>
                        <!--<td><strong>Id</strong></td>-->
                        <td><strong>Date</strong></td>
                        <td><strong>Customer</strong></td>
                        <td><strong>36</strong></td>
                        <td><strong>35</strong></td>
                        <td><strong>34</strong></td>
                        <td><strong>33</strong></td>
                        <td><strong>32</strong></td>
                        <td class="blue"><strong>32B</strong></td>
                        <td class="danger"><strong>32B</strong></td>
                        <td class="success"><strong>32B</strong></td>
                        <td><strong>30</strong></td>
                        <td class="blue"><strong>30B</strong></td>
                        <td class="danger"><strong>30P</strong></td>
                        <td class="success"><strong>30G</strong></td>
                        <td><strong>28</strong></td>
                        <td class="blue"><strong>28B</strong></td>
                        <td class="danger"><strong>28P</strong></td>
                        <td class="success"><strong>28G</strong></td>
                        <td><strong>26</strong></td>
                        <td class="blue"><strong>26B</strong></td>
                        <td class="danger"><strong>26P</strong></td>
                        <td class="success"><strong>26G</strong></td>
                        <td><strong>24</strong></td>
                        <td class="blue"><strong>24B</strong></td>
                        <td class="danger"><strong>24P</strong></td>
                        <td class="success"><strong>24G</strong></td>
                        <td><strong>TOTALS</strong></td>
                    </tr>
                </thead>
                    <%= createTable()%>
                </table>
            </div>
        </div>
    </div>

    </asp:Content>

