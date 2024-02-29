<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CurrentMedications.aspx.cs" Inherits="EMR.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="/resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script type="text/javascript" >
        $(document).ready(function () {
            $("#<%= txtHOM.ClientID  %>").autocomplete({

                source: 'Handler1.ashx'

            });

        });
    </script>
    <style>
         ::placeholder{
             text-align:center;
         }
    </style>
    <body>
    <div class="centerblock">
       
            <h1 align="center"><b>Current Medications</b></h1>
    </div>
    <br />
         <div style="font-family:Arial" align="center">
           
            
             <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true" autocomplete="off" spellcheck="false" Width="800px" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE MEDICATIONS/HOM" OnTextChanged="txtHOM_TextChanged"></asp:TextBox>
         

        <br />
             <br />
             <div style="font-family:Arial" align="center">
             <asp:Label ID="Label4" runat="server" > <b >Dosage:</b></asp:Label>
             <asp:TextBox ID="txtDosage" ClientIdMode="Static" runat="server" Width="200px" Height="20px" BorderColor="#CC0000" spellcheck="false"></asp:TextBox>
        <br />
                 <br />
           <asp:Label ID="Label3" runat="server" > <b >Date:</b></asp:Label>
       
            <asp:Calendar ID="Calendar1" SelectedDate="<%# DateTime.Today %>" runat="server" Visible="false" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="#000000" BorderColor="#33cc33" ForeColor="White" SelectedDayStyle-BackColor="#009933" ></asp:Calendar>
    
        <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Date" OnClick="Button1_Click" BackColor="#669900" ForeColor="White" BorderColor="White" BorderStyle="Groove"/>
        <br />
       
    </div>
    <br />
        <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="Add" Width="137px" Height="51px" OnClick="btnSubmit_Click" ></asp:Button>
        </div>
    <br />
   
   <div align="center">
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT patient_id,type,description,dosage,convert(nvarchar(10), datestamp, 120) as datestamp FROM [Order] WHERE ([patient_id] = @patient_id) and type='Med' ORDER BY [datestamp]">
         <SelectParameters>
             <asp:SessionParameter Name="patient_id" SessionField="smrn" Type="String" />
         </SelectParameters>
       </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"  OnRowDeleting="GridView1_RowDeleting" HeaderStyle-BackColor="#99cc00" HeaderStyle-ForeColor="White">
         <Columns>
             <asp:TemplateField HeaderText="Date">
               
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("datestamp") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Medication">  
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("description") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Dosage">  
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("dosage") %>'></asp:Label>
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
                      
    </body>
</asp:Content>
