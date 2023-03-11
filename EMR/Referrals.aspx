<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Referrals.aspx.cs" Inherits="EMR.Referrals" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
     
          .space {
            float: left;
            width: 100%;
            height: 20px;
        }
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
                        url: 'WebServiceReferrals.asmx/GetDoctorNames',
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
            <h1 align="center"><b>Referrals</b></h1>
     </div>
 <div class="space"></div>
    <br />
   
   <div class="textbox1" align="center"><asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE SPECIALITY/HOM" OnTextChanged="txtRef_TextChanged">    </asp:TextBox></div>
<br />
         <div class="centerblock" align="center">
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT [speciality_code], [description] FROM [Specialization]"></asp:SqlDataSource>
             <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT [name], [doc_Id], [speciality_code] FROM [Doctor]"></asp:SqlDataSource>           
            
             <br />
              <div class="space"></div>

             <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="Add" Width="137px" Height="51px" OnClick="btnSubmit_Click"></asp:Button>
             <br />
             <br />
             <div align="center" class="centerblock">
     <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT * FROM [Referrals] ORDER BY [datestamp]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  OnRowDeleting="GridView1_RowDeleting">
         <Columns>
            <asp:TemplateField HeaderText="Speciality">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("speciality") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Doctor Name">
               
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("doc_name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
              <asp:TemplateField HeaderText="Date" SortExpression="Date">
               
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("datestamp") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Delete">
                
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandName="Delete">Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
   </div>
       
    </div>
                <asp:TextBox ID="txtName" ClientIdMode="Static" runat="server" spellcheck="false" Width="250px" Visible="false"></asp:TextBox>

</asp:Content>
