<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="EMR.Orders" %>
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
            $("#<%= txtLab.ClientID  %>").autocomplete({

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
            <h1 align="center"><b>Orders</b></h1>
     </div>
    <div style="font-family:Arial" align="center">

            <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="Rx/Dx/HOM" OnTextChanged="txtOrd_TextChanged" >    </asp:TextBox>                 
                
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" > <b > Labs <span style="color: red;">(Dx)</span>: </b></asp:Label>
        <asp:TextBox ID="txtLab"  runat="server" Width="400px" spellcheck="false" ClientIdMode="Static" Height="30px"></asp:TextBox>
        <br />
        <br />
       <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="Add" Width="137px" Height="51px" OnClick="btnSubmit_Click" ></asp:Button>
        

        </div>
     <br />
   <div align="center">
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT patient_id,type,description,convert(nvarchar(10), datestamp, 120) as datestamp FROM [Order] WHERE ([patient_id] = @patient_id) ORDER BY [datestamp]">
         <SelectParameters>
             <asp:SessionParameter Name="patient_id" SessionField="smrn" Type="String" />
         </SelectParameters>
       </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  OnRowDeleting="GridView1_RowDeleting" HeaderStyle-BackColor="#99cc00" HeaderStyle-ForeColor="White">
         <Columns>
              <asp:TemplateField HeaderText="Type">
               
                
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("type") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Medication/Lab">
               
                
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Date">
               
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
     <br />          
        <br />
                      <div class="centerblock" align="center">
                      <asp:Label ID="Label3" runat="server" Text="Label" ><a  href="javascript:history.back(-1);"><b>Go Back</b></a></asp:Label> 
 
                     </div>
</asp:Content>
