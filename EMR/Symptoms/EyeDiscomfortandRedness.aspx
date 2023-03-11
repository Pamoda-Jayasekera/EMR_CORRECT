<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EyeDiscomfortandRedness.aspx.cs" Inherits="EMR.EyeDiscomfortandRedness" %>
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
            width: 40%;
            height: 235px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
         #left2div {
            float: left;
            width: 60%;
             height: 235px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
         #middlediv {
            float: left;
            width: 25%;
             height: 230px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
          #rightdiv {
            float: left;
            width: 25%;
             height: 230px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
           #right2div {
            float: left;
            width: 25%;
             height: 230px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }  #right3div {
            float: left;
            width: 25%;
             height: 230px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
           #space{
              float: left;
            width: 100%;
             height: 25px;
         }
        
             
         #lastdiv{
               float: left;
            width: 100%;
            height: 100px;
             
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
Eye Discomfort and Redness
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
            <h4><b> Eye discomfort best described as</b></h4> 
             
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                
               <b> Achy</b>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox2" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Dry or itchy</b>
            </td>

        </tr>

        <tr>
            <td>
                <asp:CheckBox ID="CheckBox3" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Gritty sensation</b>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox4" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Redness without actual discomfort</b>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox5" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Sensitivity to light</b>

            </td>
            <td>
                <asp:CheckBox ID="CheckBox6" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Severe pain</b>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox7" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Stinging or burning sensation</b>
            </td>
            
            
        </tr>
        

       
           
      



            
    </table>
       
           </div>
    <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px" colspan="2">
                    <h4><b>Appearance of eye includes</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox8" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Bleeding on the surface of the white of the eye</b>
                  
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox9" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Crusted eyelashes after sleeping</b>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox10" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Excessive tearing</b>
                  
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox11" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Red, painful lump on the eyelid</b>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox12" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Redness</b>
                  
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox13" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Stringy mucus in or around the eye</b>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                <asp:CheckBox ID="CheckBox14" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Swelling around the eye</b>
                  
                </td>
               
            </tr>
           
        </table>

    </div>
    <div id="middlediv">
        <table align="center">
            <tr>
                <td  height="40px" align="center" >
                   <h4> <b>Vision problem includes</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox15" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Blurred vision</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox16" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Dark, floating spots in vision</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox17" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Vision loss</b>
                </td>
            </tr>
            
        </table>
    </div>
    <div id="rightdiv">
        <table align="center">
            <tr>
                <td align="center" height="40px">
                   <h4> <b>Triggered by</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox18" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Allergens or other irritants</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox19" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Injury or trauma</b>
                </td>
            </tr>
            
           
        </table>
    </div>
    <div id="right2div">
        <table align="center">
            <tr>
           <td  align="center" height="40px">
              <h4><b>Worsened by</b></h4>
           </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox20" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Dry, warm air</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox21" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Eye movement</b>
                </td>
            </tr>

        </table>

    </div>
    <div id="right3div">
        <table align="center">
            <tr>
           <td  align="center" height="40px">
              <h4><b>Accompanied by</b></h4>
           </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox22" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Runny or stuffy nose</b>
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
