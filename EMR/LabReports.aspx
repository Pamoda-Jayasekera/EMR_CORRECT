<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LabReports.aspx.cs" Inherits="EMR.LabReports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        ::placeholder{
             text-align:center;
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
        });


    </script>
    <div class="centerblock">
            <h1 align="center"><b>Lab Reports</b></h1></div>
    <br />
         <br />
        <div class="centerblock" align="center">
         <asp:TextBox ID="txtHOM" runat="server" autocomplete="off"  AutoPostBack="true"  spellcheck="false" Width="800px" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE LAB NAME/HOM" OnTextChanged="txtLabName_TextChanged">    </asp:TextBox>                 
        <br />
        <br />
   <asp:FileUpload ID="FileUpload1" runat="server" ForeColor="#3366ff"/>
<asp:Button ID="btnUpload" runat="server" Text="Upload" OnClick="Upload" ForeColor="#3366ff"/>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT patient_id,Lab_name,Content_Type,Lab_Report,convert(nvarchar(10), datestamp, 120) as datestamp FROM [Lab_Reports] ORDER BY [datestamp]">
    <SelectParameters>
             <asp:SessionParameter Name="patient_id" SessionField="smrn" Type="String" />
         </SelectParameters>
       </asp:SqlDataSource>
<asp:GridView ID="GridView1" runat="server" HeaderStyle-BackColor="#7779AF" HeaderStyle-ForeColor="white"
     AutoGenerateColumns="false" >
    <Columns>
        <asp:BoundField DataField="Lab_Name" HeaderText="File Name"/>
        <asp:TemplateField ItemStyle-HorizontalAlign = "Center">
            <ItemTemplate>
                <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" OnClick="DownloadFile"
                    CommandArgument='<%# Eval("patient_id") %>'></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="datestamp" HeaderText="Date"/>
         
    </Columns>
</asp:GridView>
            </div>
     
</asp:Content>
