<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FootSwellingorLegSwelling.aspx.cs" Inherits="EMR.FootSwellingorLegSwelling" %>
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
            width: 20%;
            height: 230px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
         #left2div {
            float: left;
            width: 25%;
             height: 230px;
           
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
            width: 30%;
             height: 230px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
           #right2div {
            float: left;
            width: 15%;
             height: 250px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 

           
        }
        #right3div {
            float: left;
            width: 85%;
            height: 250px;
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
                Foot Swelling or Leg Swelling
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
            <td align="center" height="40px"  >
            <h4><b> Pain best described as</b></h4> 
             
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                
               <b> Dull or achy</b>
            </td>
            

        </tr>

        <tr>
            <td>
                <asp:CheckBox ID="CheckBox2" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Gradually worsening</b>
            </td>
            
        </tr>
        
       
           
      



            
    </table>
       
           </div>
    <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px">
                    <h4><b>Swelling occurs</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox3" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Along whole limb</b>
                    
                    
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox4" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Around ankle or foot</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox5" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Around knee</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox6" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>In both limbs</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox7" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>In one limb</b>
                </td>
            </tr>
        </table>

    </div>
    <div id="middlediv">
        <table align="center">
            <tr>
                <td  height="40px" align="center" >
                   <h4> <b>Triggered or worsened by</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox8" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Activity or overuse</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox9" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Injury</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox10" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Movement</b>
                </td>
            </tr>
            
        </table>
    </div>
    <div id="rightdiv">
        <table align="center">
            <tr>
                <td align="center" height="40px">
                   <h4> <b>Preceded by</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox11" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Inactivity or long periods of rest</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox12" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Sitting or standing still for long periods</b>
                </td>
            </tr>
            
            
        </table>
    </div>
    <div id="right2div">
        <table align="center">
            <tr>
           <td  align="center" height="40px">
              <h4><b>Relieved by</b></h4>
           </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox13" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Walking</b>
                </td>
            </tr>

        </table>

    </div>
    <div id="right3div">
        <table align="center">
            <tr>
                <td align="center" height="40px" colspan="3">
                    <h4><b>Accompanied by</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                  <asp:CheckBox ID="CheckBox14" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Enlarged or purplish vein in affected leg</b>
                </td>
                <td>
                  <asp:CheckBox ID="CheckBox15" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Entire leg or calf being pale and cool</b>
                </td>
                <td>
                  <asp:CheckBox ID="CheckBox16" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Fatigue</b>
                </td>
            </tr>
            <tr>
                <td>
                  <asp:CheckBox ID="CheckBox17" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Hardening of skin in affected area</b>
                </td>
                <td>
                  <asp:CheckBox ID="CheckBox18" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Heaviness in affected limb</b>
                </td>
                <td>
                  <asp:CheckBox ID="CheckBox19" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Loss of appetite</b>
                </td>
            </tr>
             <tr>
                <td>
                  <asp:CheckBox ID="CheckBox20" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Nausea</b>
                </td>
                <td>
                  <asp:CheckBox ID="CheckBox21" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Pain, tenderness or aching in affected area</b>
                </td>
                <td>
                  <asp:CheckBox ID="CheckBox22" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Persistent cough</b>
                </td>
            </tr>
             <tr>
                <td>
                  <asp:CheckBox ID="CheckBox23" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Rapid or irregular heartbeat</b>
                </td>
                <td>
                  <asp:CheckBox ID="CheckBox24" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Redness and warmth in affected area</b>
                </td>
                <td>
                  <asp:CheckBox ID="CheckBox25" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Shortness of breath</b>
                </td>
            </tr>
            <tr>
                <td>
                  <asp:CheckBox ID="CheckBox26" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Stiffness or limited movement</b>
                </td>
                <td colspan="2">
                  <asp:CheckBox ID="CheckBox27" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Swelling in abdomen or other parts of body</b>
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
