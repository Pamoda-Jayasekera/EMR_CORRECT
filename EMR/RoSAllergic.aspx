<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RoSAllergic.aspx.cs" Inherits="EMR.RoSAllergic" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
         ::placeholder{
             text-align:center;
         }
          .space {
            float: left;
            width: 100%;
            height: 30px;
        }
        .tablediv {
            float: left;
            width: 100%;
        }
          .yes input[type="checkbox"]{
  
  /* remove standard background appearance */
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none;
  /* create custom radiobutton appearance */
  display: inline-block;
  width: 40px;
  height: 40px;
  
  
  /* background-color only for content */
  background-clip: content-box;
  border: 2px solid #bbbbbb;
  background-color: forestgreen;
 
}.yes input[type="checkbox"]:checked{
  background-color: red;
}

    </style>
     <div class="heading">
        <h3 align="center"><b>ALLERGIC/IMMUNOLOGIC</b></h3>
    </div>
  <div class="space"> </div>
     <div class="centerblock" align="center">
        <asp:TextBox ID="txtHOM" runat="server"  ClientIdMode="Static" spellcheck="false" Width="800px" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged" autocomplete="off"></asp:TextBox>
     </div>
    <br />
    <div class="tablediv" align="center">
         <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label1" runat="server" Text="Label"> <b>RUNNY NOSE</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox1" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label2" runat="server" Text="Label"> <b>ITCHING EYES</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox2" runat="server" CssClass="yes" />
                </td>
</tr>
           
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label4" runat="server" Text="Label"> <b> SINUS PRESSURE
</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox3" runat="server" CssClass="yes" />
                </td>
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label3" runat="server" Text="Label"> <b>HIVES</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox4" runat="server" CssClass="yes" />
                </td>
</tr>
             
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label5" runat="server" Text="Label"> <b>FREQUENT SNEEZING</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox5" runat="server" CssClass="yes" />
                </td>
</tr>      
    </table><div class="space"></div>
      <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="SUBMIT" Width="100px" Height="45px" OnClick="btnSubmit_Click" ></asp:Button>
                     </div>
            <br />
        <asp:TextBox ID="txtAllergic" runat="server" TextMode="MultiLine" Visible="false" ></asp:TextBox>
      
</asp:Content>
