<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Image.aspx.cs" Inherits="EMR.Images" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="centerblock">
            <h1 align="center"><b>Images</b></h1></div>
        <style>
            ::placeholder{
             text-align:center;
         }
    .abc{
    text-align : center;
    font-size : 60px;
    }
    .Gridview
{
font-family:Verdana;
font-size:10pt;
font-weight:normal;
color:black;
width:500px;
}
    </style>
   
<div>
    <br />
         
        <div class="centerblock" align="center">
        
                <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE IMAGE NAME/HOM" OnTextChanged="txtImName_TextChanged">    </asp:TextBox>                 

        </div>
        <br />
    
<table align="center">

<tr>
<td>
<b>Upload Image:</b>
</td>
<td>
<asp:FileUpload ID="fileuploadImage" runat="server" ForeColor="#3366ff" />
</td>
</tr>
<tr>
<td>
</td>
<td>
<asp:Button ID="btnUpload" ForeColor="#3366ff" runat="server" Text="Upload" OnClick="btnUpload_Click"/>
</td>
</tr>
</table>
</div>
<div align="center">
         <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:con %>" SelectCommand="SELECT patient_id,image_name,image,convert(nvarchar(10), datestamp, 120) as datestamp FROM [Images] ORDER BY [datestamp]">
    <SelectParameters>
             <asp:SessionParameter Name="patient_id" SessionField="smrn" Type="String" />
         </SelectParameters>
       </asp:SqlDataSource>
<asp:GridView ID="gvImages" class="Gridview" runat="server" AutoGenerateColumns="False"
HeaderStyle-BackColor="#7779AF" HeaderStyle-ForeColor="white"  HeaderStyle-Wrap="false">
<Columns>
<asp:BoundField  DataField="image_name" HeaderText="Image Name"   ItemStyle-Wrap="false"/>
<asp:TemplateField HeaderText="Image">
    <ItemTemplate>
        <asp:Image ID="Image1" runat="server" ImageUrl=<%#"data:Image/png;base64,"+Convert.ToBase64String((byte[])Eval("image")) %>/>
    </ItemTemplate>
</asp:TemplateField>
    <asp:BoundField  DataField="datestamp" HeaderText="Date"   ItemStyle-Wrap="false"/>
   
</Columns>
</asp:GridView>
</div>
</asp:Content>
