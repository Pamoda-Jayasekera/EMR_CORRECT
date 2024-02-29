<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocSummary.aspx.cs" Inherits="EMR.DocSummary" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HiddenField ID="predictionIdHidden" runat="server" />

  <script type="text/javascript">
      function checkForPIDAndEnterKey(txtBox, event) {
          if (event.keyCode === 13) {
              if (txtBox.value.endsWith(" PID")) {
                  // If Enter key is pressed and the text ends with PID
                  __doPostBack('<%= txtHOM.ClientID %>', '');
                return false;
            } else if (txtBox.value.endsWith(" ORD")) {
                __doPostBack('<%= txtHOM.ClientID %>', '');
                  return false;
              }
              else if (txtBox.value.endsWith(" RST")) {
                  __doPostBack('<%= txtHOM.ClientID %>', '');
                  return false;
              }
              else if (txtBox.value.endsWith(" MDN")) {
                  __doPostBack('<%= txtHOM.ClientID %>', '');
                  return false;
              }
              else if (txtBox.value.endsWith(" TPS")) {
                  __doPostBack('<%= txtHOM.ClientID %>', '');
                  return false;
              }
          }
          return true;
      }
  </script>


    <style>
        body, html, form {
            margin: 0;
            padding: 0;
        }
        .wrap-text {
    word-wrap: break-word; /* Allow long words to be able to break and wrap onto the next line */
    white-space: normal; /* Override the default nowrap */
}

        .diagnosis-table {
            border-collapse: collapse;
            width: 40%;
            background-color: #e0f2f1;
            border: 1px solid #00acc1;
            border-radius: 5px;
        }
        .fit-text {
    overflow-wrap: break-word; /* This will wrap long words onto the next line */
    resize: none; /* This will prevent the user from resizing the textarea */
}

        .diagnosis-table th, .diagnosis-table td {
            padding: 5px;
            text-align: left;
            border-bottom: 1px solid #00acc1;
            font-size: 15px;
        }

        .diagnosis-table th {
            background-color: #00acc1;
            color: white;
        }

        .diagnosis-container {
            background-color: #e0f2f1;
            padding: 5px;
            border-radius: 10px;
            margin-top: 20px;
        }

        .prediction-label {
            display: block;
            margin-top: 20px;
            font-size: 18px;
            font-weight: bold;
            color: black;
        }

        #btnSubmitDiagnosis {
            font-size: 11px;
        }

        .left-content {
            float: left;
            width: 53.5%;
            border-right: 1px solid #00FFFF;
        }

        .right-content {
            float: right;
            width: 45.5%;
            border-left: 1px solid #00FFFF;
        }

        .move-right {
            margin-left: 5px;
        }
        .auto-style1 {
            background-color: #e0f2f1;
            padding: 5px;
            border-radius: 10px;
            margin-top: 20px;
            width: 550px;
        }
        .auto-style2 {
            width: 300px;
        }



        .gridview-style {
    margin: auto;
    border-collapse: separate; /* This is changed to handle rounded corners */
    border-spacing: 0;
    border: 1px solid #5F9EA0;
}

.gridview-style th {
    background-color: #5F9EA0;
    color: white;
    padding: 10px;
    
}

.gridview-style th:first-child {
    border-top-left-radius: 20px; /* Rounded corners for the first header cell */
}

.gridview-style th:last-child {
    border-top-right-radius: 20px; /* Rounded corners for the last header cell */
}

.gridview-style td {
    padding: 10px;
    text-align: left;
    border-bottom: 1px solid #5F9EA0;
}

.gridview-style tr:last-child td:first-child {
    border-bottom-left-radius: 20px; /* Rounded corners for the bottom cells */
}

.gridview-style tr:last-child td:last-child {
    border-bottom-right-radius: 20px; /* Rounded corners for the bottom cells */
}

.gridview-style tr:nth-child(odd) {
    background-color: #E0FFFF;
}

.gridview-style tr:nth-child(even) {
    background-color: #AFEEEE;
}
@media screen and (max-width: 768px) {
            .left-content, .right-content {
                width: 100%;
                float: none;
                border: none;
            }
        }

    </style>
    <br />
    <br />
    <br />
   <div style="text-align:center;">
       <asp:TextBox ID="txtHOM" runat="server"  onkeydown="return checkForPIDAndEnterKey(this, event);" AutoPostBack="true" spellcheck="false" Width="850px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE HOM/SHOW DETAILS-PID (ex:-PID 123)/ORDERS-ORD/RESULTS-RST/MEDICATION-MDN/TRATMENT PLANS-TPS " OnTextChanged="txtHOM_TextChanged"></asp:TextBox>
<br />
        <br />
    </div>

    <div class="left-content">
       <asp:TextBox ID="txtDateP" runat="server" AutoPostBack="true" placeholder="YYYY-MM-DD" Width="200px"></asp:TextBox>
        <asp:Button ID="fetchDataButton" runat="server" Text="Fetch Data" OnClick="fetchDataButton_Click" />
        <br />
        <br />
       <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="206px" Width="81%"
    CssClass="gridview-style" GridLines="None" CellPadding="4">
    <Columns>
        <asp:BoundField DataField="Rank" HeaderText="Rank" ItemStyle-Width="50px" />
        <asp:BoundField DataField="prediction_id" HeaderText="Prediction ID" ItemStyle-Width="100px" />
       <asp:BoundField DataField="symptom" HeaderText="Symptom" ItemStyle-Width="100px" ItemStyle-CssClass="wrap-text" />
       <asp:BoundField DataField="prediction" HeaderText="Prediction" ItemStyle-Width="100px" ItemStyle-CssClass="wrap-text" />

    </Columns>
    <HeaderStyle BackColor="#5F9EA0" ForeColor="White" />
    <RowStyle BackColor="#E0FFFF" />
    <AlternatingRowStyle BackColor="#AFEEEE" />
</asp:GridView>
        <hr />
        <div>
          
            <hr />
             <asp:Label ID="resultLabel" runat="server" Visible="false"></asp:Label>
       
        </div>
        <div class="auto-style1">
            <asp:Label ID="lblPrediction" runat="server" CssClass="prediction-label" Width="580px"></asp:Label>
            <table class="diagnosis-table">
                <tr>
                    <th>Orders (ORD)</th>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDiagnosis" runat="server" Height="111px" Width="420px" TextMode="MultiLine" OnTextChanged="txtDiagnosis_TextChanged" CssClass="fit-text" placeholder="SUBMIT ORDERS ADD 'ORD' AT THE END OF THE TEXT " Font-Size="12px">
</asp:TextBox>

                      
                    </td>
                </tr>
                 <tr>
                    <th> Lab Results (RST)</th>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDiagnosisResults" runat="server" Height="111px" Width="420px" TextMode="MultiLine" OnTextChanged="txtDiagnosis_TextChanged" CssClass="fit-text" placeholder="SUBMIT RESULTS ADD 'RST' AT THE END OF THE TEXT " Font-Size="12px">
</asp:TextBox>

                      
                    </td>
                </tr>
                 <tr>
                    <th>Medication (MDN)</th>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDiagnosisMed" runat="server" Height="111px" Width="420px" TextMode="MultiLine" OnTextChanged="txtDiagnosis_TextChanged" CssClass="fit-text" placeholder="SUBMIT MEDICATION ADD 'MDN' AT THE END OF THE TEXT " Font-Size="12px">
</asp:TextBox>

                      
                    </td>
                </tr>
               <tr>
                    <th>Treatment Plans (TPS)</th>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDiagnosisTreatment" runat="server" Height="111px" Width="420px" TextMode="MultiLine" OnTextChanged="txtDiagnosis_TextChanged" CssClass="fit-text" placeholder="SUBMIT TREATMENT PLANS ADD 'TPS' AT THE END OF THE TEXT " Font-Size="12px">
</asp:TextBox>

                      
                    </td>
                </tr>
               
                <tr>
                    <th>Treatment Options</th>
                    <td class="auto-style2"><asp:Label ID="lblTreatmentOptions" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
    </div>

    <div class="right-content">
        
<br /><br />
        <asp:GridView ID="gvLabReports" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkSelect" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="image_name" HeaderText="Image Name" />
            </Columns>
        </asp:GridView>

        <br />

        <asp:Button ID="btnShowSelectedImages" runat="server" Text="Show Selected Images" OnClick="btnShowSelectedImages_Click" />
        <br />
        <br />
        <asp:PlaceHolder ID="phSelectedImages" runat="server"></asp:PlaceHolder>
    </div>

    <div style="clear:both;"></div>
</asp:Content>