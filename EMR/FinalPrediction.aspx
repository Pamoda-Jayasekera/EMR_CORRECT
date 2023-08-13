<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FinalPrediction.aspx.cs" Inherits="EMR.FinalPrediction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .space {
            float: left;
            width: 100%;
            height: 20px;
        }

        ::placeholder {
            text-align: center;
        }

       

       

        .label-container {
            text-align: left;
            margin-bottom: 10px;
        }

        .label-title {
            font-size: 18px;
            font-weight: bold;
            margin-right: 10px;
        }

        .link-label {
            font-size: 16px;
            color: #007BFF;
        }

      
    </style>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <link rel="stylesheet" href="/resources/demos/style.css">
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

    <script type="text/javascript" language="javascript">

        $(document).ready(function () {
            $("#<%= txtHOM.ClientID %>").autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: 'webservicePrediction.asmx/GetSymptomNames',
                        method: 'post',
                        contentType: 'application/json;charset=utf-8',
                        data: JSON.stringify({ term: request.term }),
                        dataType: "json",
                        success: function (data) {
                            response(data.d);
                        },
                        error: function (err) {
                            alert(err);
                        }
                    });
                }
            });

            // ... Your other scripts ...
        });

    </script>

    <div class="centerblock">
        <h1 align="center"><b>Symptom Prediction</b></h1>
    </div>
    <div class="space"></div>
    <br />

     <div class="textbox1" align="center">
        <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE HOM" OnTextChanged="txtRef_TextChanged">
        </asp:TextBox>
    </div>
    <br />

    <div class="label-container">
        <span class="label-title">Predicted Illness:</span>
        <asp:TextBox ID="txtPrediction" runat="server" CssClass="link-label" ReadOnly="true"></asp:TextBox>
    </div>
    <br />
    <div class="label-container">
        <span class="label-title">Diagnosis&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</span>
        <asp:HyperLink ID="hlDiagnosis" runat="server" CssClass="link-label">Diagnosis Details         </asp:HyperLink>
    </div>
      <br />
    <div class="label-container">
        <span class="label-title">Treatment Order:</span>
        <asp:HyperLink ID="hlTreatmentOrder" runat="server" CssClass="link-label">Treatment Order Details</asp:HyperLink>
    </div>
      <br />
    <div class="label-container">
        <span class="label-title">Treatment Basis:</span>
        <asp:HyperLink ID="hlTreatmentBasis" runat="server" CssClass="link-label">Treatment Basis Details</asp:HyperLink>
    </div>
      <br />
    <!-- ... other markup ... -->
</asp:Content>
