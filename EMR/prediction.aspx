<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="prediction.aspx.cs" CodeBehind="prediction.aspx.cs" Inherits="EMR.prediction" EnableViewState="true" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <head>
     

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

            //changed code 
            checkForAddAndEnter = function (e) {
                var keyCode = e.keyCode || e.which;
                if (keyCode === 13) { // 13 is the Enter key code
                    var txtValue = $("#<%= txtHOM.ClientID %>").val().trim();
        if (txtValue.toUpperCase() === "HOM") {
            // If "HOM" is entered, do nothing and let the form submission handle the redirection
            return true;
        } else if (txtValue !== "") {
            // For other non-empty inputs, add them as symptoms

            // Directly use txtValue as the symptom
            var symptom = txtValue;

            // Append the symptom to txtSymptoms
            var txtSymptoms = $("#<%= txtSymptoms.ClientID %>");
            if (txtSymptoms.val().trim() === "") {
                // First symptom, just append without a comma
                txtSymptoms.val(symptom);
            } else {
                // Append with comma after the last symptom
                txtSymptoms.val(txtSymptoms.val() + "," + symptom);
            }
            
            // Clear the txtHOM
                        $("#<%= txtHOM.ClientID %>").val("");

                        // Prevent default form submission
                        e.preventDefault();
                    }
                }
            };

        });
    </script>

         <style>
              body {
                background-color: #e0f2f1; /* Light Aqua Blue */
            }
            .form-container {
                background-color: #e0f2f1;
                padding: 20px;
                border-radius: 10px;
            }
            .symptom-box {
                width: 50%;
                background-color: #e0f2f1;
                border: 2px solid #00acc1;
                padding: 10px;
                border-radius: 5px;
                margin-top: 10px;
            }
            .styled-button {
                display: inline-block;
                background-color: #00acc1;
                color: #fff;
                border: none;
                padding: 10px 20px;
                border-radius: 25px;
                cursor: pointer;
                font-size: 16px;
                text-align: center;
                text-decoration: none;
                transition: background-color 0.3s ease;
            }
            .styled-button:hover {
                background-color: #00acc1;
            }
            .predict-button {
                margin-top: 20px;
                
            }
           .prediction-label {
                display: block;
                margin-top: 20px;
                font-size: 24px;
                font-weight: bold;
                color: black;
            }
             h2 {
            color: black; /* Black Text */
            margin-top: 20px;
        }
        </style>
    </head>
    <body>
        <div align="center">
          <h2>Illness Prediction</h2>
        <div class="textbox1" align="center">
          <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE HOM" OnTextChanged="txtRef_TextChanged" onkeydown="checkForAddAndEnter(event);"></asp:TextBox>

        </div>
        <br />
       
     
             
          
       <br />
           
                   
            <br />
                   
            <br />
                   
            <br />
            </div>
             <div align="center">
          
            <asp:TextBox ID="txtSymptoms" runat="server" placeholder="Selected symptoms will appear here" autocomplete="off" Width="98%" Height="112px"></asp:TextBox>
            
        <br />
        <br />
        <br />
       
            <asp:Button ID="btnPredict" runat="server" Text="Predict Disease" CssClass="predict-button" OnClick="btnPredict_Click" Height="35px" Width="167px" />
                 <br />
    <asp:Label ID="lblPrediction" runat="server" CssClass="prediction-label"></asp:Label>

 <br />
                 <br />

<br />


        </div>
    </body>
</asp:Content>