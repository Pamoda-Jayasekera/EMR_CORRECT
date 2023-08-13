<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vaccination.aspx.cs" Inherits="EMR.Vaccination" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <style>
        input[type="checkbox"]{
  /* remove standard background appearance */
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none;
  /* create custom radiobutton appearance */
  display: inline-block;
  width: 25px;
  height: 25px;
  
  /* background-color only for content */
  background-clip: content-box;
  border: 2px solid #bbbbbb;
  background-color: white;
  border-radius: 50%;
}

/* appearance for checked radiobutton */
.gr input[type="checkbox"]:checked{
  background-color: green;
}
.re input[type="checkbox"]:checked {
  background-color:red;
}

/* optional styles, I'm using this for centering radiobuttons */
       ::placeholder{
             text-align:center;
         }
         .auto-style1 {
             width: 169px;
             height: 40px;
         }
         .auto-style2 {
             width: 100px;
             height: 40px;
         }

         .auto-style3 {
             width: 100px;
         }
         .auto-style4 {
             width: 169px;
             height: 40px;
         }
         .auto-style5 {
             width: 169px;
             height: 40px;
         }
         .auto-style6 {
             width: 100px;
             height: 42px;
         }

    </style>
   
    <body>
    <div class="centerblock">
            <h1 align="center"><b>Vaccination Status</b></h1>
            <br />
            <br /><div align="center">
                <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged">    </asp:TextBox>        </div>
            <table align="center">
                <tr>
                    <td class="auto-style1" >
<asp:Label runat="server" ><b>AstraZeneca Dose 1</b></asp:Label></td>
                    
                <td class="auto-style2">
                       <asp:CheckBox class="gr" ID="Dose1y" runat="server" Text=" Yes" />

                   </td>
                    <td class="auto-style2">
                        <asp:CheckBox ID="Dose1n" class="re" runat="server" Text="No" />

                
                    </tr>
                 <tr>
                    <td class="auto-style5" >
<asp:Label runat="server" ><b>AstraZeneca Dose 2</b></asp:Label></td>
                    
                <td class="auto-style6">
                       <asp:CheckBox class="gr" ID="Dose2y" runat="server"  Text="Yes"   />

                   </td>
                    <td class="auto-style6">
                        <asp:CheckBox class="re" ID="Dose2n" runat="server" GroupName="smo" Text="No" />

                
                    </tr>
                
                      <tr>
                    <td class="auto-style4" style="width: 169px" >
<asp:Label runat="server" ><b>AstraZeneca Dose 3</b></asp:Label></td>
                    
                <td class="auto-style3">
                       <asp:CheckBox class="gr" ID="Dose3y" runat="server"  Text="Yes"   />

                   </td>
                    <td class="auto-style3"  style="width: 100px">
                        <asp:CheckBox  class="re" ID="Dose3n" runat="server"  Text="No" />

                
                    </tr>          
       
   </table>
        </div>
<br />
                      <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="SUBMIT" Width="137px" Height="51px" OnClick="btnSubmit_Click"></asp:Button>
                      </div>
           
    </body>
</asp:Content>


