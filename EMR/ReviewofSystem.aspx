<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReviewofSystem.aspx.cs" Inherits="EMR.ReviewofSystem" %>
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
                        url: 'WebServiceRoSList.asmx/GetRoSTypes',
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
    <style>

        .space {
            float: left;
            width: 100%;
            height: 30px;
        }
    </style>
    <div class="centerblock">
            <h1 align="center"><b>Review of System</b></h1>
     </div>
    <div class="space"></div>
    <div class="centerblock" align="center">
        <asp:TextBox ID="txtHOM" runat="server" autocomplete="off"  ClientIdMode="Static" spellcheck="false" Width="800px" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="SELECT SPECIALITY" OnTextChanged="txtHOM_TextChanged"></asp:TextBox>
     </div>
    <br />
    <br />
    <div align="center">
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT note,convert(nvarchar(10), datestamp, 120) as datestamp FROM [Review_of_System] WHERE ([patient_id] = @patient_id) ORDER BY [datestamp]">
         <SelectParameters>
             <asp:SessionParameter Name="patient_id" SessionField="smrn" Type="String" />
         </SelectParameters>
       </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  HeaderStyle-BackColor="#99cc00" HeaderStyle-ForeColor="White">
         <Columns>
              <asp:TemplateField HeaderText="Date">
               
                
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("datestamp") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Description">
               
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("note") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
   </div>
</asp:Content>
