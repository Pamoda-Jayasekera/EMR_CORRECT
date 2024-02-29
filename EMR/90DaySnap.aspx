<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="90DaySnap.aspx.cs" Inherits="EMR._90DaySnap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .centerblock {
            width: 100%;
            text-align: center;
            margin-top: 20px;
        }
        #GridView1 {
            width: 90%;
            margin: auto;
            border-collapse: collapse;
            font-family: Arial, sans-serif;
        }
        #GridView1 th {
            background-color: rgb(4, 184, 160); /* Custom Aqua Blue */
            color: white;
            font-size: 16px;
        }
        #GridView1 td {
            background-color: white;
            color: black;
            padding: 10px;
            border: 1px solid #ddd; /* Light grey border */
            text-align: center;
            font-size: 14px;
        }
        #GridView1 tr:nth-child(even) {
            background-color: #f2f2f2; /* Zebra stripes */
        }
    </style>

    <div class="centerblock">
        <h1 align="center"><b>90Day Snap Shot</b></h1>
        <br />

        <div align="center">
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:con %>" 
               
                 SelectCommand="SELECT Prediction.symptom, orders, results, medication FROM Prediction WHERE Prediction.patient_id = @patient_id AND (ISNULL(orders, '') <> '' OR ISNULL(results, '') <> '')">
                <SelectParameters>
                    <asp:SessionParameter Name="patient_id" SessionField="smrn" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="symptom" HeaderText="Symptom" ItemStyle-Width="25%" />
                    <asp:BoundField DataField="orders" HeaderText="Orders" ItemStyle-Width="25%" />
                    <asp:BoundField DataField="results" HeaderText="Lab Results" ItemStyle-Width="25%" />
                    <asp:BoundField DataField="medication" HeaderText="Medication" ItemStyle-Width="25%" />
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <br />
        <div class="centerblock" align="center">
            <asp:Label ID="Label2" runat="server" Text="Label"><a href="javascript:history.back(-1);"><b>Go Back</b></a></asp:Label>
        </div>
    </div>
</asp:Content>
