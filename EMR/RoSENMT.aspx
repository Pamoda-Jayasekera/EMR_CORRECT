<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RoSENMT.aspx.cs" Inherits="EMR.RoSENMT" %>
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
        <h3 align="center"><b>ENMT</b></h3>
    </div>
     
    <div class="space"> </div>
    <div class="centerblock" align="center">
        <asp:TextBox ID="txtHOM" runat="server" autocomplete="off"  ClientIdMode="Static" spellcheck="false" Width="800px" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged"></asp:TextBox>
     </div>
    <br />
    <div class="heading">
        <h4 align="center"><b>EAR</b></h4></div>
    <div class="tablediv" align="center">
         <table border="2px">
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label1" runat="server" Text="Label"> <b>DIFFICULTY HEARING</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox1" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label2" runat="server" Text="Label"> <b>EAR PAIN</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox2" runat="server" CssClass="yes" />
                </td>

            
            
    </table>
       
           </div>
    <div class="space"> </div>
     <div class="heading">
        <h4 align="center"><b>NOSE</b></h4>
    </div>
    <div class="tablediv" align="center">
         <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label5" runat="server" Text="Label"> <b>FREQUENT NOSE BLEEDING</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox5" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label6" runat="server" Text="Label"> <b>STUFFY NOSE</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox6" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label7" runat="server" Text="Label"> <b>SINUS PROBLEMS</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox7" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label8" runat="server" Text="Label"> <b>OTHER</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox8" runat="server" CssClass="yes" />
                </td>
</tr>
            
    </table>
       
           </div>
         <div class="space"> </div>
     <div class="heading">
        <h4 align="center"><b>MOUTH/THROAT</b></h4>
    </div>
         
    <div class="tablediv" align="center">
         <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label3" runat="server" Text="Label"> <b>SORE THROAT</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox3" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label4" runat="server" Text="Label"> <b>BLEEDING GUMS</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox4" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label9" runat="server" Text="Label"> <b>DRY MOUTH</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox9" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label10" runat="server" Text="Label"> <b>SNORING</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox10" runat="server" CssClass="yes" />
                </td>
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label11" runat="server" Text="Label"> <b>ORAL ABNOMALITIES</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox11" runat="server" CssClass="yes" />
                </td>
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label12" runat="server" Text="Label"> <b>MOUTH ULCERS</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox12" runat="server" CssClass="yes" />
                </td>
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label13" runat="server" Text="Label"> <b>TEETH ABNOMALITIES</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox13" runat="server" CssClass="yes" />
                </td>
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label14" runat="server" Text="Label"> <b>MOUTH BLEEDING</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox14" runat="server" CssClass="yes" />
                </td>
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label15" runat="server" Text="Label"> <b>OTHER</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox15" runat="server" CssClass="yes" />
                </td>
</tr>
            
    </table><div class="space"></div>
      <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="SUBMIT" Width="100px" Height="45px" OnClick="btnSubmit_Click" ></asp:Button>
                     </div>
            <br />
                      <div class="centerblock" align="center">
                      <asp:Label ID="Label16" runat="server" Text="Label" ><a  href="javascript:history.back(-1);"><b>Go Back</b></a></asp:Label> 
 
                     </div>
         <asp:TextBox ID="txtENMT" runat="server" TextMode="MultiLine" Visible="false" ></asp:TextBox>
</asp:Content>
