<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="prediction.aspx.cs" CodeBehind="prediction.aspx.cs" Inherits="EMR.prediction" EnableViewState="true" %>



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

            $("#<%= btnAdd.ClientID %>").click(function () {
                var symptom = $("#<%= txtHOM.ClientID %>").val().trim();
                if (symptom !== "") {
                    var bigTextBox = $("#<%= bigTextBox.ClientID %>");
                    if (bigTextBox.val().trim() === "") {
                        // First symptom, just append without a comma
                        bigTextBox.val(symptom);
                    } else {
                        // Append with comma after the last symptom
                        bigTextBox.val(bigTextBox.val() + "," + symptom);
                    }
                    $("#<%= txtHOM.ClientID %>").val("");
                }
            });

           
        });

    </script>

    <div class="centerblock">
        <h1 align="center"><b>Symptom Prediction</b></h1>
    </div>
    <div class="space"></div>
    <br />

    <div class="textbox1" align="center">
        <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE SYMPTOMS/HOM" OnTextChanged="txtRef_TextChanged">
        </asp:TextBox>
    </div>
    <br />
    <!-- ... other markup ... -->

    <div class="centerblock" align="center">
        <!-- Add a TextArea control with ID "bigTextBox" -->
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" Width="100px" Height="40px" CssClass="btn btn-primary btn-lg" />
    </div>
    <br />
    <div class="centerblock" align="center">
        <asp:TextBox ID="bigTextBox" runat="server" TextMode="MultiLine" Rows="6" Width="800px" Height="150px"></asp:TextBox>
        <br />
        <asp:Button ID="btnEnter" runat="server" Text="Enter" Width="100px" Height="40px" OnClick="btnEnter_Click" CssClass="btn btn-primary btn-lg" />
    </div>

</asp:Content>
