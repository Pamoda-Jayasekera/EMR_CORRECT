<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="90DaySnap.aspx.cs" Inherits="EMR._90DaySnap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="centerblock">
            <h1 align="center"><b>90Day Snap Shot</b></h1>
          <br />
     
          <div align="center">
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT findings,plans,convert(nvarchar(10), datestamp, 120) as datestamp  FROM [Assessment] WHERE ([patient_id] = @patient_id) ORDER BY [datestamp]">
         <SelectParameters>
             <asp:SessionParameter Name="patient_id" SessionField="smrn" Type="String" />
         </SelectParameters>
              </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HeaderStyle-BackColor="#99cc00" HeaderStyle-ForeColor="White">
         <Columns>
            <asp:TemplateField HeaderText="Finding">
               
                
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("findings") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Plan" >
               
                <ItemTemplate>
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("plans") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Date" >
               
                <ItemTemplate>
                    <ItemStyle width="100px" />
                    <asp:Label ID="Label2" runat="server" Text='<%# Eval("datestamp") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>
    </asp:GridView>
   </div>
    </div>
    <br />
    <br />
     <div class="centerblock" align="center">
                      <asp:Label ID="Label2" runat="server" Text="Label" ><a  href="javascript:history.back(-1);"><b>Go Back</b></a></asp:Label>  
     </div>
</asp:Content>
