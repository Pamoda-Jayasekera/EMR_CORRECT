﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinalPrediction.aspx.cs" Inherits="EMR.FinalPrediction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        /* Your styles here */

        /* Example styling for table */
        .diagnosis-table {
            border-collapse: collapse;
            width: 100%;
        }

        .diagnosis-table th, .diagnosis-table td {
            border: 1px solid #ddd;
            padding: 8px;
            text-align: left;
        }

        .diagnosis-table th {
            background-color: #f2f2f2;
        }


         .diagnosis-container {
            background-color: #e0f2f1;
            padding: 20px;
            border-radius: 10px;
            margin-top: 20px;
        }
        
        /* Example styling for the table */
        .diagnosis-table {
            width: 100%;
            border-collapse: collapse;
            background-color: #e0f2f1; /* Light Aqua Blue */
            border: 1px solid #00acc1;
            border-radius: 5px;
        }

        .diagnosis-table th, .diagnosis-table td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #00acc1;
        }

        .diagnosis-table th {
            background-color: #00acc1;
            color: white;
        }
      
       .diagnosis-table th, .diagnosis-table td {
            /* ... (existing styles) */
            font-size: 18px;
        }
         .prediction-label {
                display: block;
                margin-top: 20px;
                font-size: 24px;
                font-weight: bold;
                color: black;
            }
       
        .auto-style7 {
            width: 398px;
            height: 95px;
        }
        .auto-style8 {
            width: 1207px;
            height: 95px;
        }
       
    </style>

    <h2>More Details about the Prediction</h2>
     <div class="textbox1" align="center">
            <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE HOM" OnTextChanged="txtRef_TextChanged"></asp:TextBox>
        </div>
        <br />
   
       <br />
    
    <div class="diagnosis-container">
         <asp:Label ID="lblPrediction" runat="server" CssClass="prediction-label"></asp:Label>
         <asp:Label ID="lblPredictionID" runat="server" CssClass="prediction-label"></asp:Label>
        
     <table class="diagnosis-table">
   <tr>
        <th class="auto-style7">Orders</th>
        <td class="auto-style8">
            <asp:TextBox ID="txtDiagnosis" runat="server" Height="60px" OnTextChanged="txtDiagnosis_TextChanged" Width="737px"></asp:TextBox>
            <asp:Button ID="btnSubmitDiagnosis" runat="server" Text="Submit" OnClick="btnSubmitDiagnosis_Click" />
        </td>
    </tr>
    <tr>
        <th class="auto-style7">Treatment Basis</th>
        <td class="auto-style8"><asp:Label ID="lblTreatmentBasis" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <th class="auto-style7">Results</th>
        <td>
       <asp:HyperLink ID="hlOrders" runat="server">
            <asp:Label ID="lblOrders" runat="server"></asp:Label>
        </asp:HyperLink></td>
    </tr>
    <tr>
        <th class="auto-style7">Treatment Options</th>
        <td>
            <asp:HyperLink ID="hlTreatmentOptions" runat="server">
            <asp:Label ID="lblTreatmentOptions" runat="server"></asp:Label>
        </asp:HyperLink></td>
    </tr>
</table>

        
       
    </div>
</asp:Content>
