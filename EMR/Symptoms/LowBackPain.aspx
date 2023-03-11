<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LowBackPain.aspx.cs" Inherits="EMR.LowBackPain" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        ::placeholder{
             text-align:center;
         }
        #headingdiv{
             float: left;
            width: 100%;
            height: 60px;
        }

        #leftdiv {
            float: left;
            width: 25%;
            height: 200px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
         #left2div {
            float: left;
            width: 25%;
             height: 200px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
        #left3div {
            float: left;
            width: 50%;
            height: 200px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
         #left4div {
             float: left;
             width: 75%;
             height: 200px;
             border: 2px solid blue;
             border-style: inset;
             border-collapse: collapse
         }


         #middlediv {
             float: left;
             width: 75%;
             height: 200px;
             border: 2px solid blue;
             border-style: inset;
             border-collapse: collapse
         }
   

        #rightdiv {
            float: left;
            width: 30%;
            height: 200px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
        #right2div {
            float: left;
            width: 20%;
            height: 200px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
           
      

        }

        #space {
            float: left;
            width: 100%;
            height: 25px;
        }


        #lastdiv {
            float: left;
            width: 100%;
            height: 25px;
        }#txtspace{
              
                float: left;
            width: 100%;
            height: 100px;
            
           }


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
  background-color: blue;
  border-radius: 50%;
}
   input[type="checkbox"]:checked {
            background-color: red;
       }

    </style>
    
    <div id="headingdiv" align="center" >
        <h2>
            <b>
Low Back Pain
            </b>
        </h2>
    </div>
    <div align="center">
            <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged">    </asp:TextBox>                 
            </div>
    <br />
    <br />
     <div align="left" id="leftdiv" >

    <table align="center" >

        <tr  >
            <td align="center" height="40px" colspan="2" >
            <h4><b> Low Back Pain is</b></h4> 
             
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                
               <b> Began suddenly</b>
            </td>
            </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox2" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Gradually worsens over time</b>
            </td>

        </tr>
        </table>
        
       
           </div>
    
    <div id="leftdiv">
        <table align="center">
            <tr>
                <td  height="40px" align="center" >
                   <h4> <b>Triggered by</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox3" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Everyday activities</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox4" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Injury</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox5" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Overuse</b>
                </td>
            </tr>
            
        </table>
    </div>
     <div id="left3div">
        <table align="center">
            <tr>
           <td  align="center" height="40px">
              <h4><b>Relieved by</b></h4>
           </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox6" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Bending over or leaning for something for support</b>
                </td>
               
            </tr>
            </table>
        </div>
    <div id="left2div">
        <table align="center">
            <tr>
                <td align="center" height="40px">
                   <h4> <b>Worsened by</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox7" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Movement</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox8" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Prolonged sitting or standing</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox9" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Prolonged rest or inactivity</b>
                </td>
            </tr>
           
        </table>
    </div>
   
          <div id="left4div">
        <table align="center">
            <tr>
           <td  align="center" height="40px" colspan="2">
              <h4><b>Accompanied by</b></h4>
           </td>
            </tr>
           
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox10" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Change in bowl or bladder function</b>
                </td>
                     <td>
                    <asp:CheckBox ID="CheckBox11" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Knot or tight spot in black muscle</b>
                </td>
            </tr>
           
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox12" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Leg or foot pain</b>
                </td>
                    <td>
                    <asp:CheckBox ID="CheckBox13" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Stiffness in lower back</b>
                </td>
            </tr>
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox14" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Swelling</b>
                </td>
                     <td>
                    <asp:CheckBox ID="CheckBox15" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Weakness, numbness or tingling in leg or foot</b>
                </td>
            </tr>
 
</table>
    </div>
 <div id="space"></div>
    <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-primary btn-lg" runat="server" Text="DONE" Width="84px" Height="41px" OnClick="btnSubmit_Click" visible="false" ></asp:Button>
                     </div>
    <div id="space"></div>
     <div id="txtspace" align="center">
         <table>
             <tr>
                 
                 <td>
          <asp:TextBox ID="txtAbdom" runat="server" TextMode="MultiLine"   BorderWidth="2px" BorderColor="Black" Width="675" Rows="5" visible="false"></asp:TextBox>
            </td></tr> </table>
    </div>
    <div id="lastdiv" align="right">
        <asp:Button ID="btnAdd" runat="server" Height="35px" Width="120px" Text="Add" BackColor="#9999ff" BorderColor="Black" BorderWidth="2px" Font-Bold="true" Font-Size="Medium" OnClick="btnAdd_Click" visible="false" />
</asp:Content>
