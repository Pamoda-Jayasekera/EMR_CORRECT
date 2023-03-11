<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ROSAll.aspx.cs" Inherits="EMR.ROSAll" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   <style>
          .space {
            float: left;
            width: 100%;
            height: 10px;
        }
          .tabledivh {
            float: left;
            width: 98%;
            
        }
          .tabledivth {
            float: left;
            width: 49%;
            
        }
          .tabledivh {
            float: left;
            width: 98%;
            
        }
          .tabledivx {
            float: left;
            width: 46%;
            
        }

          .tablediv {
            float: left;
            width: 23%;
            
        }
         .tabledivspace{
              float: left;
            width: 2%;
            padding: 10px;
         }
          .tablediv1 {
            float: left;
            width: 23%;
            
        }
          
          .tablediv2 {
            float: left;
            width: 23%;
            
        }
          .tablediv3 {
            float: left;
            width: 23%;
            
        }
           .tablediv4 {
            float: left;
            width: 63%;
            
        }
           
           .tablediv5 {
            float: left;
            width: 33%;
            
        }
           .tablediv5N {
            float: left;
            width: 30%;
            
        }
           .tablediv4N {
            float: left;
            width: 66%;
            
        }
       .yes input[type="checkbox"] {
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
  ::placeholder{
             text-align:center;
         }
    </style>
    <div class="heading">
        <h3 align="center"><b>ROS ALL</b></h3>
    </div>
  <div class="space"> </div>
     <div class="centerblock" align="center">
        <asp:TextBox ID="txtHOM" runat="server"  ClientIdMode="Static" spellcheck="false" Width="800px" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged" autocomplete="off"></asp:TextBox>
     </div>

    
    <div class="tablediv" align="center">
         <div class="heading">
        <h3 align="center"><b>General</b></h3>
    </div>

    <div class="space"> </div>
         <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label1" runat="server" Text="Label"> <b>Weight loss or gain</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox1" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color: yellow">
                    <asp:Label ID="Label2" runat="server" Text="Label"> <b>Fever or chills</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox2" runat="server" CssClass="yes" />
                </td>
</tr>
           
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label4" runat="server" Text="Label"> <b>Trouble sleeping</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox4" runat="server" CssClass="yes" />
                </td>
</tr>
           
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label3" runat="server" Text="Label"> <b>Fatigue</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox3" runat="server" CssClass="yes" />
                </td>
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label5" runat="server" Text="Label"> <b>Weakness
</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox5" runat="server" CssClass="yes" />
                </td>
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label12" runat="server" Text="Label"> <b>
</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox12" runat="server" CssClass="yes" />
                </td>
</tr>

            
           
            
            
                     
    </table>
        </div>
    <div class="tabledivspace">

    </div>
    <div class="tablediv2">
         <div class="heading">
        <h3 align="center"><b>Skin</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label6" runat="server" Text="Label"> <b>Rashes</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox6" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label7" runat="server" Text="Label"> <b>Itching</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox7" runat="server" CssClass="yes" />
                </td>
</tr>
           
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label8" runat="server" Text="Label"> <b>Color changes</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox8" runat="server" CssClass="yes" />
                </td>
</tr>
           
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label9" runat="server" Text="Label"> <b>Lumps</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox9" runat="server" CssClass="yes" />
                </td>
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label10" runat="server" Text="Label"> <b>Dryness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox10" runat="server" CssClass="yes" />
                </td>
</tr>
               <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label11" runat="server" Text="Label"> <b>Hair and nail changes</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox11" runat="server" CssClass="yes" />
                </td>
</tr>

            
           
            
            
                     
    </table>
    </div>
    <div class="tabledivspace"></div>
    <div class="tablediv3">
         <div class="heading">
        <h3 align="center"><b>Head</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label13" runat="server" Text="Label"> <b>Headache</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox13" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label14" runat="server" Text="Label"> <b>Head injury</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox14" runat="server" CssClass="yes" />
                </td>
</tr>
              
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label15" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox15" runat="server" CssClass="yes" />
                </td>
</tr>
                   
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label16" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox16" runat="server" CssClass="yes" />
                </td>
</tr>
                   
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label17" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox17" runat="server" CssClass="yes" />
                </td>
</tr>
                   
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label18" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox18" runat="server" CssClass="yes" />
                </td>
</tr>
           
           
            
           
            
            
                     
    </table>
    </div>
     <div class="tabledivspace"></div>
    <div class="tablediv3">
         <div class="heading">
        <h3 align="center"><b>Ears</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label19" runat="server" Text="Label"> <b>Decreased hearing</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox19" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label20" runat="server" Text="Label"> <b>Earache</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox20" runat="server" CssClass="yes" />
                </td>
</tr>
              
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label21" runat="server" Text="Label"> <b>Ringing in ears (tinnitus)</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox21" runat="server" CssClass="yes" />
                </td>
</tr>
                   
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label22" runat="server" Text="Label"> <b>Drainage</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox22" runat="server" CssClass="yes" />
                </td>
</tr>
                   
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label23" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox23" runat="server" CssClass="yes" />
                </td>
</tr>
                   
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label24" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox24" runat="server" CssClass="yes" />
                </td>
</tr>
           
           
            
           
            
            
                     
    </table>
    </div>
   
   
    <div class="tablediv4">
         <div class="heading">
        <h3 align="center"><b>Eyes</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label25" runat="server" Text="Label"> <b>Vision</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox25" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label31" runat="server" Text="Label"> <b>Blurry or double vision</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox31" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label32" runat="server" Text="Label"> <b>Cataracts</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox32" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label26" runat="server" Text="Label"> <b>Glasses or contacts</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox26" runat="server" CssClass="yes" />
                </td>
                  <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label33" runat="server" Text="Label"> <b>Flashing lights</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox33" runat="server" CssClass="yes" />
                </td>
                  <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label34" runat="server" Text="Label"> <b>Last eye exam</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox34" runat="server" CssClass="yes" />
                </td>
</tr>
              
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label27" runat="server" Text="Label"> <b>Pain</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox27" runat="server" CssClass="yes" />
                </td>
                 
           

                <td height="30px" width="450px" style="background-color:yellow" colspan="3">
                    <asp:Label ID="Label35" runat="server" Text="Label"> <b>Specks</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox35" runat="server" CssClass="yes" />
                </td>
                       

</tr>
                   
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label28" runat="server" Text="Label"> <b>Redness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox28" runat="server" CssClass="yes" />
                </td>
                 
                <td height="30px" width="450px" style="background-color:yellow" colspan="3">
                    <asp:Label ID="Label29" runat="server" Text="Label"> <b>Glaucoma</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox29" runat="server" CssClass="yes" />
                </td>
               
</tr>              
    </table>
    </div>
    <div class="tabledivspace"></div>
    <div class="tablediv5">
         <div class="heading">
        <h3 align="center"><b>Nose</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label30" runat="server" Text="Label"> <b>Stuffiness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox30" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label36" runat="server" Text="Label"> <b>Itching</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox123" runat="server" CssClass="yes" />
                </td>
            
               
</tr>
               <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label37" runat="server" Text="Label"> <b>Nosebleeds</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox36" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label38" runat="server" Text="Label"> <b>Discharge</b></asp:Label>
                   
                </td>
                   <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox126" runat="server" CssClass="yes" />
                </td>
            
               
</tr>
               <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label39" runat="server" Text="Label"> <b>Hay fever</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox37" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label40" runat="server" Text="Label"> <b>Sinus pain</b></asp:Label>
                   
                </td>
                   <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox130" runat="server" CssClass="yes" />
                </td>
            
               
</tr>
                <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label41" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox38" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label42" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                    <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox131" runat="server" CssClass="yes" />
                </td>
            
               
</tr>
              </table>
    </div>
<div class="tablediv4">
     <div class="heading">
        <h3 align="center"><b>Throat</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label43" runat="server" Text="Label"> <b>Teeth</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox39" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label44" runat="server" Text="Label"> <b>Sore tongue</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox40" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label45" runat="server" Text="Label"> <b>Thrush</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox41" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label46" runat="server" Text="Label"> <b>Gums</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox42" runat="server" CssClass="yes" />
                </td>
                  <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label47" runat="server" Text="Label"> <b>Dry mouth</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox43" runat="server" CssClass="yes" />
                </td>
                  <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label48" runat="server" Text="Label"> <b>Non-healing sores</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox44" runat="server" CssClass="yes" />
                </td>
</tr>
              
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label49" runat="server" Text="Label"> <b>Bleeding</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox45" runat="server" CssClass="yes" />
                </td>
                 
           

                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label50" runat="server" Text="Label"> <b>Sore throat</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox46" runat="server" CssClass="yes" />
                </td>
                 
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label61" runat="server" Text="Label"> <b>Last dental exam</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox53" runat="server" CssClass="yes" />
                </td>
                       

</tr>
                   
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label51" runat="server" Text="Label"> <b>Dentures</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox47" runat="server" CssClass="yes" />
                </td>
                 
                <td height="30px" width="450px" style="background-color:yellow" colspan="3">
                    <asp:Label ID="Label52" runat="server" Text="Label"> <b>Hoarseness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox48" runat="server" CssClass="yes" />
                </td>
               
</tr>              
    </table>
    </div>
    <div class="tabledivspace"></div>
    <div class="tablediv5">
         <div class="heading">
        <h3 align="center"><b>Neck</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label53" runat="server" Text="Label"> <b>Lumps</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox49" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label54" runat="server" Text="Label"> <b>Pain</b></asp:Label>
                   
                </td>
            <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox132" runat="server" CssClass="yes" />
                </td>
            
               
</tr>
               <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label55" runat="server" Text="Label"> <b>Swollen glands</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox50" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label56" runat="server" Text="Label"> <b>Stiffness</b></asp:Label>
                   
                </td>
                   <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox133" runat="server" CssClass="yes" />
                </td>
            
               
</tr>
               <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label57" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox51" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label58" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                   <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox134" runat="server" CssClass="yes" />
                </td>
            
               
</tr>
                <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label59" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox52" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label60" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                    <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox135" runat="server" CssClass="yes" />
                </td>
            
               
</tr>
              </table>
    </div>
    <div class="tablediv5">
<div class="heading">
        <h3 align="center"><b>Breasts</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label62" runat="server" Text="Label"> <b>Lumps</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox54" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label63" runat="server" Text="Label"> <b>Discharge</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox55" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label64" runat="server" Text="Label"> <b>Breast-feeding</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox56" runat="server" CssClass="yes" />
                </td>
               
</tr>
              
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label65" runat="server" Text="Label"> <b>Pain</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox57" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" colspan="3">
                    <asp:Label ID="Label66" runat="server" Text="Label"> <b>Self-exams</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox58" runat="server" CssClass="yes" />
                </td>
            
               
               
</tr>
              
              </table>
    </div>
    <div class="tabledivspace"></div>
      <div class="tablediv4">
<div class="heading">
        <h3 align="center"><b>Respiratory</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label67" runat="server" Text="Label"> <b> Cough (dry or wet,
productive)</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox59" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label68" runat="server" Text="Label"> <b>Coughing up blood
(hemoptysis)</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox60" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label69" runat="server" Text="Label"> <b>Wheezing</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox61" runat="server" CssClass="yes" />
                </td>
               
</tr>
              
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label70" runat="server" Text="Label"> <b>Sputum (color and
amount)</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox62" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label71" runat="server" Text="Label"> <b>Shortness of breath
(dyspnea)</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox63" runat="server" CssClass="yes" />
                </td>
             <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label72" runat="server" Text="Label"> <b>Painful breathing</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox64" runat="server" CssClass="yes" />
                </td>
               
               
</tr>
              
              </table>
    </div>
    <div class="tabledivh">
        <div class="heading">
        <h3 align="center"><b>Cardiovascular</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label73" runat="server" Text="Label"> <b> Chest pain or discomfort</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox65" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label74" runat="server" Text="Label"> <b>Difficulty breathing
lying down (orthopnea)</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox66" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label75" runat="server" Text="Label"> <b>Sudden awakening from
sleep with shortness of
breath (Paroxysmal</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox67" runat="server" CssClass="yes" />
                </td>
               
</tr>
              
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label76" runat="server" Text="Label"> <b>Tightness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox68" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label77" runat="server" Text="Label"> <b>Swelling (edema)</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox69" runat="server" CssClass="yes" />
                </td>
             <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label78" runat="server" Text="Label"> <b>Palpitations</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox70" runat="server" CssClass="yes" />
                </td>
               
               
</tr>
                      
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" colspan="5">
                    <asp:Label ID="Label79" runat="server" Text="Label"> <b>Shortness of breath with
activity (dyspnea)</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox71" runat="server" CssClass="yes" />
                </td>
            
               
               
</tr>
              
              </table>
    </div>
    <div class="tablediv4">
        <div class="heading">
        <h3 align="center"><b>Gastrointestinal</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label80" runat="server" Text="Label"> <b> Swallowing difficulties</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox72" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label81" runat="server" Text="Label"> <b>Change in bowel habits</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox73" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label82" runat="server" Text="Label"> <b>Yellow eyes or skin
(jaundice)</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox74" runat="server" CssClass="yes" />
                </td>
               
</tr>
              
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label83" runat="server" Text="Label"> <b>Heartburn</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox75" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label84" runat="server" Text="Label"> <b>Rectal bleeding</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox76" runat="server" CssClass="yes" />
                </td>
             <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label85" runat="server" Text="Label"> <b>Change in appetite</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox77" runat="server" CssClass="yes" />
                </td>
               
               
</tr>
                      
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label86" runat="server" Text="Label"> <b>Constipation</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox78" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label87" runat="server" Text="Label"> <b>Nausea</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox79" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label88" runat="server" Text="Label"> <b>Diarrhea</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox80" runat="server" CssClass="yes" />
                </td>
            
               
               
</tr>
              
              </table>
    </div>
    <div class="tabledivspace"></div>
    <div class="tablediv5">
        <div class="heading">
        <h3 align="center"><b>Urinary</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label89" runat="server" Text="Label"> <b> Frequency</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox81" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label90" runat="server" Text="Label"> <b>Blood in urine
(hematuria)</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox82" runat="server" CssClass="yes" />
                </td>
            
                
               
</tr>
              
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label92" runat="server" Text="Label"> <b>Change in urinary
strength</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox84" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label93" runat="server" Text="Label"> <b>Urgency</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox85" runat="server" CssClass="yes" />
                </td>
            
               
               
</tr>
                      
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label95" runat="server" Text="Label"> <b>Burning or pain</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox87" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label96" runat="server" Text="Label"> <b>Incontinence</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox88" runat="server" CssClass="yes" />
                </td>
            
            
               
               
</tr>
              
              </table>
    </div>
    <div class="space"></div>
    <div class="heading">
        <h3 align="center"><b>Genital</b></h3>
    </div>
    <div class="tablediv4">
         
          <table border="2px">

              <tr align="center">
                   <td height="30px" width="450px" colspan="6">
                    <asp:Label ID="Label101" runat="server" Text="Label"> <h4><b> Male</b></h4></asp:Label>
                   
                </td>
              </tr>

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label91" runat="server" Text="Label"> <b> Pain with sex</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox83" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label94" runat="server" Text="Label"> <b>Sores</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox86" runat="server" CssClass="yes" />
                </td>
             <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label102" runat="server" Text="Label"> <b>STD’s</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox93" runat="server" CssClass="yes" />
                </td>
                
               
</tr>
              
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label97" runat="server" Text="Label"> <b>Hernia</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox89" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label98" runat="server" Text="Label"> <b>Masses or pain</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox90" runat="server" CssClass="yes" />
                </td>
            <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label103" runat="server" Text="Label"> <b>Penile discharge</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox94" runat="server" CssClass="yes" />
                </td>
            
               
               
</tr>
                      
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow"colspan="5" >
                    <asp:Label ID="Label99" runat="server" Text="Label"> <b>Erectile dysfunction</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox91" runat="server" CssClass="yes" />
                </td>            
</tr>
              
              </table>
    </div>
    <div class="tabledivspace"></div>
     <div class="tablediv5">
         
          <table border="2px">

              <tr align="center">
                   <td height="30px" width="450px" colspan="4">
                    <asp:Label ID="Label100" runat="server" Text="Label"> <h4><b> Female</b></h4></asp:Label>
                   
                </td>
              </tr>

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label104" runat="server" Text="Label"> <b> Pain with sex</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox92" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label105" runat="server" Text="Label"> <b>Hot flashes</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox95" runat="server" CssClass="yes" />
                </td>
             
                
               
</tr>
              
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label107" runat="server" Text="Label"> <b>Itching or rash</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox97" runat="server" CssClass="yes" />
                </td>
            
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label108" runat="server" Text="Label"> <b>Vaginal dryness</b></asp:Label>
                   
                </td>
              <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox98" runat="server" CssClass="yes" />
                </td>             
</tr>
                      
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label110" runat="server" Text="Label"> <b>Vaginal discharge</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox100" runat="server" CssClass="yes" />
                </td>
              <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label106" runat="server" Text="Label"> <b>STD’s</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox96" runat="server" CssClass="yes" />
                </td>              
            
</tr>
              
              </table>
    </div>
    <div class="tablediv5N">
        <div class="heading">
        <h3 align="center"><b>Vascular</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" colspan="2">
                    <asp:Label ID="Label109" runat="server" Text="Label"> <b>Calf pain with walking
(Claudication)</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox99" runat="server" CssClass="yes" />
                </td>        
</tr>
              <tr><td height="30px" width="450px" style="background-color:yellow" colspan="2">
                    <asp:Label ID="Label111" runat="server" Text="Label"> <b>Leg cramping</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox104" runat="server" CssClass="yes" />
                </td>

              </tr>
              
             
              </table>
    </div>
    <div class="tabledivspace"></div>
   
    <div class="tablediv4N">
 
        <div class="heading">
        <h3 align="center"><b>Musculoskeletal</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">
                <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label112" runat="server" Text="Label"> <b>Muscle or joint pain</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox101" runat="server" CssClass="yes" />
                </td>
              <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label113" runat="server" Text="Label"> <b>Back pain</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox102" runat="server" CssClass="yes" />
                </td>   
                    <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label114" runat="server" Text="Label"> <b>Swelling of joints</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox103" runat="server" CssClass="yes" />
                </td> 
            
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label115" runat="server" Text="Label"> <b>Stiffness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox105" runat="server" CssClass="yes" />
                </td>
              <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label116" runat="server" Text="Label"> <b>Redness of joints</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox106" runat="server" CssClass="yes" />
                </td>   
                    <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label117" runat="server" Text="Label"> <b>Trauma</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox107" runat="server" CssClass="yes" />
                </td> 
            
</tr>
          </table>
    </div>
    <div class="tablediv5">
        <div class="heading">
        <h3 align="center"><b>Hematologic</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">
                <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" colspan="2">
                    <asp:Label ID="Label118" runat="server" Text="Label"> <b>Ease of bruising</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox108" runat="server" CssClass="yes" />
                </td>
            
            
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" colspan="2">
                    <asp:Label ID="Label121" runat="server" Text="Label"> <b>Ease of bleeding</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox111" runat="server" CssClass="yes" />
                </td>
             
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" colspan="2">
                    <asp:Label ID="Label127" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox117" runat="server" CssClass="yes" />
                </td>
             
</tr>
          </table>
    </div>
      <div class="tabledivspace"></div>
   
    <div class="tablediv4">
 
        <div class="heading">
        <h3 align="center"><b>Neurologic</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">
                <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label119" runat="server" Text="Label"> <b>Dizziness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox109" runat="server" CssClass="yes" />
                </td>
              <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label120" runat="server" Text="Label"> <b>Weakness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox110" runat="server" CssClass="yes" />
                </td>   
                    <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label122" runat="server" Text="Label"> <b>Tremor</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox112" runat="server" CssClass="yes" />
                </td> 
            
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label123" runat="server" Text="Label"> <b>Fainting</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox113" runat="server" CssClass="yes" />
                </td>
              <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label124" runat="server" Text="Label"> <b>Numbness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox114" runat="server" CssClass="yes" />
                </td>   
                    <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label125" runat="server" Text="Label"> <b>Seizures</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox115" runat="server" CssClass="yes" />
                </td> 
            
</tr>
                 <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" colspan="5">
                    <asp:Label ID="Label126" runat="server" Text="Label"> <b>Tingling</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox116" runat="server" CssClass="yes" />
                </td>
             
            
</tr>
          </table>
    </div>
     <div class="tablediv5">
        <div class="heading">
        <h3 align="center"><b>Psychiatric</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">
                <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label128" runat="server" Text="Label"> <b>Nervousness</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox118" runat="server" CssClass="yes" />
                </td>
                     <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label138" runat="server" Text="Label"> <b>Memory loss</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox128" runat="server" CssClass="yes" />
                </td>
            
            
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label129" runat="server" Text="Label"> <b>Stress</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox119" runat="server" CssClass="yes" />
                </td>
                  
                <td height="30px" width="450px" style="background-color:yellow" >
                    <asp:Label ID="Label139" runat="server" Text="Label"> <b>Depression</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox129" runat="server" CssClass="yes" />
                </td>
             
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" colspan="3">
                    <asp:Label ID="Label130" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox120" runat="server" CssClass="yes" />
                </td>
             
</tr>
          </table>
    </div>
      <div class="tabledivspace"></div>
   
    <div class="tablediv4">
 
        <div class="heading">
        <h3 align="center"><b>Endocrine</b></h3>
    </div>
    <div class="space"> </div>
          <table border="2px">
                <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label131" runat="server" Text="Label"> <b>Head or cold intolerance</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox121" runat="server" CssClass="yes" />
                </td>
              <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label132" runat="server" Text="Label"> <b>Frequent urination
(polyuria)</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox122" runat="server" CssClass="yes" />
                </td>   
                    
            
</tr>
              <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label134" runat="server" Text="Label"> <b>Change in appetite
(polyphagia)</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox124" runat="server" CssClass="yes" />
                </td>
              <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label135" runat="server" Text="Label"> <b>Sweating</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox125" runat="server" CssClass="yes" />
                </td>   
                    
            
</tr>
                 <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow" colspan="3">
                    <asp:Label ID="Label137" runat="server" Text="Label"> <b>Thirst (polydypsia)</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox127" runat="server" CssClass="yes" />
                </td>
             
            
</tr>
          </table>
        
    </div>
  <br />
    <br />
    <div class="space"></div>
      <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="SUBMIT" Width="100px" Height="45px" OnClick="btnSubmit_Click" ></asp:Button>
                     </div>
    <asp:TextBox ID="TextBox1" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox2" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox3" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox4" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox5" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox6" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox7" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox8" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox9" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox10" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox11" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox12" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox13" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox14" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox15" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox16" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox17" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox18" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox19" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox20" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     <asp:TextBox ID="TextBox21" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
     
     </asp:Content>

               

               