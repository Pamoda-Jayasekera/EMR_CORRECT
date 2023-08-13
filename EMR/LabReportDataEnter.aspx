<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LabReportDataEnter.aspx.cs" Inherits="EMR.LabReportDataEnter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
  
    body {
        font-family: "Arial", sans-serif;
        font-size: 16px;
    }
    ::placeholder {
        text-align: center;
    }
    .space {
        float: left;
        width: 100%;
        height: 10px;
    }
    .space1 {
        float: left;
        width: 100%;
        height: 30px;
    }
    .tablediv {
        float: left;
        width: 100%;
        margin-top: 30px;
        text-align: left; /* Add this line to align tables to the left */
    }
    .timediv {
        float: left;
        width: 100%;
        margin-top: 30px;
    }
    .staticspace {
        float:right;
        width: 100%;
        position: fixed;
        align-content: left;
    }

    table {
        border-collapse: collapse;
        position:left;
        text-align: left;
        padding: 3px;
    }
    th, td {
        padding: 10px;
        font-size: 15px;
        font-weight: bold;
        text-align: left;
        vertical-align: middle;
    }
    th {
        background-color: #ddd;
    }
    
        .auto-style4 {
           
             font-size: 15px;
        }
        .auto-style5 {
            font-size: 15px;
            height: 53px;
        }
        .auto-style6 {
            font-size: 15px;
            height: 3px;
        }
        .auto-style8 {
            font-size: 15px;
            height: 11px;
        }
        .auto-style9 {
            height: 11px;
        }
        .auto-style10 {
            font-size: 15px;
            height: 6px;
        }
        .auto-style11 {
            height: 6px;
        }
        .auto-style12 {
            height: 298px;
        }
    </style>


    <div class="centerblock">
        <h3 align="left"><b>Laboratory Report</b></h3>
    </div>
    <div class="staticspace">
        <div align="center">
            
            <asp:TextBox ID="txtRBox" runat="server" AutoPostBack="true" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtRBox_TextChanged"></asp:TextBox>
        </div>
    </div>
    <br />
    <br />
    <div class="tablediv" align="center">

        <table class="auto-style12">
        <tr align="left">
            <td class="auto-style4">
                <asp:Label ID="Label25" runat="server" Text="Label"><h5><b>Medical Record Number  </b><span style="color:red;">(MRN):</span></h5></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtMRN" runat="server" BorderWidth="0" AutoComplete="off" SpellCheck="false" style="text-align: left"></asp:TextBox>
            </td>
        </tr>
        <tr align="left">
            <td class="auto-style6">
                <asp:Label ID="Label3" runat="server" Text="Label"><h5><b>Date:</b></h5></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:TextBox ID="txtDate" runat="server" BorderWidth="0" AutoComplete="off" SpellCheck="false" style="text-align: left"></asp:TextBox>
            </td>
        </tr>
        <tr align="left">
            <td class="auto-style8">
                <asp:Label ID="Label2" runat="server" Text="Label"><h5><b>Patient  </b><span style="color:red;">(PTN):</span></h5></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:TextBox ID="txtPTN" runat="server" BorderWidth="0" AutoComplete="off" SpellCheck="false" style="text-align: left"></asp:TextBox>
            </td>
        </tr>
        <tr align="left">
            <td class="auto-style4">
                <asp:Label ID="Label4" runat="server" Text="Label"><h5><b>Refered By  </b><span style="color:red;">(DCN):</span></h5></asp:Label>
            </td>
            <td class="auto-style4">
                <asp:TextBox ID="txtDocName" runat="server" BorderWidth="0" AutoComplete="off" SpellCheck="false" style="text-align: left"></asp:TextBox>
            </td>
        </tr>
        <tr align="left">
            <td class="auto-style10">
                <asp:Label ID="Label10" runat="server" Text="Label"><h5><b>Age  </b><span style="color:red;">(AGE):</span></h5></asp:Label></td>
            <td class="auto-style11" >
                <asp:TextBox ID="txtAge" runat="server" BorderWidth="0" AutoComplete="off" SpellCheck="false" style="text-align: left"></asp:TextBox> </td>
        </tr>
        <tr align="left">
            <td >
                <asp:Label ID="Labe4" runat="server" Text="Label"><h5><b>Test:</b></h5></asp:Label></td>
            <td class="auto-style5" >
                <asp:Label ID="Label8" runat="server" Text="Label"><h5><b>Profile Liver</b></h5></asp:Label></td>
        </tr>
    </table>
  
    <div class="tablediv" align="center">

        <table border="2px">
            <thead>
                <td class="auto-style2">Test</td>
                <td class="auto-style1">Result</td>
                <td class="auto-style3">Flag Reference Value</td>
            </thead>
            <tr align="left">
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Label">Total Protein<span style="color:red;">(TPR):</span></asp:Label></td>
                <td class="auto-style1">
                <asp:TextBox ID="txtTP" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
                 <td class="auto-style3">
                    <asp:Label ID="Label12" style="text-align:center;" runat="server" Text="Label">60.0 - 85.0</asp:Label></td>
                
            </tr>

              <tr align="left">
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Label">Albumin<span style="color:red;">(ALB):</span></asp:Label></td>
                <td class="auto-style1">
                <asp:TextBox ID="txtAl" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
                 <td class="auto-style3">
                    <asp:Label ID="Label7" style="text-align:center;" runat="server" Text="Label">35.0 - 54.0</asp:Label></td>
               
            </tr>

              <tr align="left">
                <td class="auto-style2">
                    <asp:Label ID="Label9" runat="server" Text="Label">Globulin<span style="color:red;">(GLO):</span></asp:Label></td>
                <td class="auto-style1">
                <asp:TextBox ID="txtGl" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
                 <td class="auto-style3">
                    <asp:Label ID="Label11" runat="server" Text="Label">25.0 - 35.0</asp:Label></td>
                
            </tr>

              <tr align="left">
                <td class="auto-style2">
                    <asp:Label ID="Label13" runat="server" Text="Label">A/G Ratio<span style="color:red;">(RAT):</span></asp:Label></td>
                <td class="auto-style1">
                <asp:TextBox ID="txtRa" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
                 <td class="auto-style3">
                    <asp:Label ID="Label14" runat="server" Text="Label">0.8 - 2.3</asp:Label></td>
             
            </tr>

              <tr align="left">
                <td class="auto-style2">
                    <asp:Label ID="Label15" runat="server" Text="Label">Bilirubin - Total<span style="color:red;">(BIL):</span></asp:Label></td>
                <td class="auto-style1">
                <asp:TextBox ID="txtBi" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
                 <td class="auto-style3">
                    <asp:Label ID="Label16" runat="server" Text="Label">0.20 - 1.40</asp:Label></td>
                
            </tr>

              <tr align="left">
                <td class="auto-style2">
                    <asp:Label ID="Label17" runat="server" Text="Label">ALK.Phosphatase<span style="color:red;">(PHO):</span></asp:Label></td>
                <td class="auto-style1">
                <asp:TextBox ID="txtALK" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
                 <td class="auto-style3">
                    <asp:Label ID="Label18" runat="server" Text="Label">98.0 - 279.0</asp:Label></td>
             
            </tr>

              <tr align="left">
                <td class="auto-style2">
                    <asp:Label ID="Label19" runat="server" Text="Label">ALT (S.G.P.T)<span style="color:red;">(ALT):</span></asp:Label></td>
                <td class="auto-style1">
                <asp:TextBox ID="txtALT" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
                 <td class="auto-style3">
                    <asp:Label ID="Label20" runat="server" Text="Label">0.1 - 40.0</asp:Label></td>
                
            </tr>

             <tr align="left">
                <td class="auto-style2">
                    <asp:Label ID="Label21" runat="server" Text="Label">AST (S.G.O.T)<span style="color:red;">(AST):</span></asp:Label></td>
                <td class="auto-style1">
                <asp:TextBox ID="txtAST" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
                 <td class="auto-style3">
                    <asp:Label ID="Label22" runat="server" Text="Label">0.1 - 40.0</asp:Label></td>
              
            </tr>

             <tr align="left">
                <td class="auto-style2">
                    <asp:Label ID="Label23" runat="server" Text="Label">GAMMA-GT<span style="color:red;">(GAM):</span></asp:Label></td>
                <td class="auto-style1">
                <asp:TextBox ID="txtGam" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
                 <td class="auto-style3">
                    <asp:Label ID="Label24" runat="server" Text="Label">7.0 - 50.0</asp:Label></td>
              
            </tr>


        </table>
     <a href="LabReports.aspx">Go Back</a>
    </div>
</asp:Content>