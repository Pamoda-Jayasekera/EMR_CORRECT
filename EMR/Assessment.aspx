<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Assessment.aspx.cs" Inherits="EMR.Assessment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
         <style>

         .findings {
            float: left;
            width: 50%;
        }
            
            .plans{
             float: left;
            width: 50%;
            
           
        }
             ::placeholder{
             text-align:center;
         }
       

             .textbox1 {
                 float: left;
                 width: 100%;
             }

             .button {
                 float: left;
                 width: 100%;
             }
          .textbox2{
             float: left;
            width: 50%;
            
           
        }
          .textbox{
             float: left;
            width: 50%;
            
        }
           .lefttextbox{
             float: left;
            width: 25%;
            
           
        }
             .righttextbox {
                 float: left;
                 width: 25%;
             }

           .space{
             float: left;
            width: 100%;
            height:10px;
           
        }
        .auto-style1 {
            margin-left: 0;
        }

    </style>
    <body>
      <div class="heading" align="center"><h2><b>ASSESMENT</b> </h2></div><br />
   <div class="textbox1" align="center"><asp:TextBox ID="txtAss" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="FIN/PLA/HOM" OnTextChanged="txtAss_TextChanged">    </asp:TextBox> </div>
<br />
        <div class="button"  align="center">
            <asp:Button ID="btnSubmit" runat="server" Text="Add" Visible="false"  OnClick="btnSubmit_Click" class="btn btn-success btn-lg" /></div>
        
        <div class="space"></div>
        <div class="findings" align="right">
        <asp:Label ID="Label1" runat="server" Text="Label"><h4><b>FINDINGS:</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h4></asp:Label></div>
    <div class="plans" align="left">
        <asp:Label ID="Label2" runat="server" Text="Label"><h4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>PLANS:</b></h4></asp:Label></div>
    <div class="textbox2" align="right"><asp:TextBox ID="txtFin" runat="server"  TextMode="MultiLine" Rows="10"  CssClass="auto-style1" Width="300px" ></asp:TextBox></div>
      <div class="textbox" align="left">
          <asp:TextBox ID="txtPla" runat="server" TextMode="MultiLine" Rows="10"  CssClass="auto-style1" Width="300px" ></asp:TextBox></div>
        <br />
          <div align="center" class="centerblock">
     <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT ap_code,patient_id,findings,plans,convert(nvarchar(10), datestamp, 120) as datestamp FROM [Assessment] ORDER BY [datestamp]">
    <SelectParameters>
             <asp:SessionParameter Name="patient_id" SessionField="smrn" Type="String" />
         </SelectParameters>
       </asp:SqlDataSource>
              <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="#99cc00" HeaderStyle-ForeColor="White">
         <Columns>
             <asp:TemplateField HeaderText="Date">
               
                <ItemTemplate>
                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("datestamp") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Findings">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("findings") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Plans">
               
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("plans") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
   </div>
 
</body>
    </asp:Content>