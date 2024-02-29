<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LabReports.aspx.cs" Inherits="EMR.LabReports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .centerblock {
            text-align: center;
        }
         .label-left {
            float: left;
            margin-right: 10px; /* Adjust the margin as needed */
        }

        .table {
            width: 80%;
            margin: 0 auto;
        }
        .auto-style1 {
            display: block;
            width: 37%;
            height: 34px;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
            box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075);
            -webkit-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            -webkit-transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
        }
    </style>

    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
    <link rel="stylesheet" href="/resources/demos/style.css">
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

    <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#<%= txtHOM.ClientID  %>").autocomplete({

                source: function (request, response) {
                    $.ajax({
                        url: 'WebServiceLabs.asmx/GetLabNames',
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
                },

            });

            var table = $("#testTable tbody");
            $("#addRowButton").click(function () {
                var newRow = $("<tr>");
                newRow.append('<td><input type="text" class="form-control" placeholder="Test Name"></td>');
                newRow.append('<td><input type="text" class="form-control" placeholder="Test Results"></td>');
                table.append(newRow);
            });

            $("#btnSave").click(function () {
                // Retrieve values
                var predictionId = $("#txtPredictionId").val();
                var summary = $("#txtSummary").val();
                var testRows = [];

                $("#testTable tbody tr").each(function () {
                    var testName = $(this).find("input:eq(0)").val();
                    var testResults = $(this).find("input:eq(1)").val();
                    testRows.push({ testName: testName, testResults: testResults });
                });

                // Send data to server using AJAX or form submission
                // Handle server-side processing in your code-behind
                // ...

                // Clear form fields
                $("#txtPredictionId").val("");
                $("#txtSummary").val("");
                $("#testTable tbody").empty();
            });
        });
    </script>

    <div class="centerblock">
        <h1 align="center"><b>Lab Reports</b></h1>
    </div>
    <br />
    <br />
    <div class="centerblock" align="center">
        <asp:TextBox ID="txtHOM" runat="server" autocomplete="off" AutoPostBack="true" spellcheck="false" Width="800px" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE LAB NAME/HOM" OnTextChanged="txtLabName_TextChanged"></asp:TextBox>
        <table class="my-table">
            <tr>
                <td><a href="LabReportDataEnter.aspx">Profile Liver</a></td>
            </tr>
            <tr>
                <td><a href="LabReportDataEnterRenal5.aspx">Profile Renal</a></td>
            </tr>
            <tr>
                <td><a href="LabReportDataEnter.aspx">Complete Blood Count</a></td>
            </tr>
            <tr>
                <td><a href="LabReportDataEnterRenal5.aspx">Lipid Profile</a></td>
            </tr>
        </table>
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" ForeColor="#3366ff" />
        <asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" ForeColor="#3366ff" />
        <div>

              <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT patient_id,Lab_name,Content_Type,Lab_Report,convert(nvarchar(10), datestamp, 120) as datestamp FROM [Lab_Reports] ORDER BY [datestamp]">
        <SelectParameters>
            <asp:SessionParameter Name="patient_id" SessionField="smrn" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

              
    <asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#7779AF" HeaderStyle-ForeColor="white" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Lab_Name" HeaderText="File Name" />
            <asp:TemplateField ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" OnClick="DownloadFile" CommandArgument='<%# Eval("patient_id") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="datestamp" HeaderText="Date" />
        </Columns>
    </asp:GridView>

<br />
 <br />



            <label for="txtPredictionId" class="label-left"><strong>Prediction_id:</strong></label>
            <asp:TextBox ID="txtPredictionId" runat="server"  class="auto-style1" placeholder="Enter Prediction_id"></asp:TextBox>
        </div>
        <br />
        <table id="testTable" class="table" runat="server" clientidmode="Static">
            <thead>
                <tr>
                    <th>Test Name</th>
                    <th>Test Results</th>
                </tr>
            </thead>
            <tbody>
                <!-- Rows will be added dynamically here -->
            </tbody>
        </table>
        <br />
        <button type="button" id="addRowButton" class="btn btn-primary">Add Row</button>
        <br />
        <br />
        <br />
       <asp:TextBox ID="txtSummary" runat="server" CssClass="form-control" placeholder="Enter Summary" TextMode="MultiLine" Rows="4"></asp:TextBox>
        <br />
        <button type="button" id="btnSave" class="btn btn-success">Save</button>
    </div>


</asp:Content>
