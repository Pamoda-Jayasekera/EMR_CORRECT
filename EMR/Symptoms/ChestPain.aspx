<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChestPain.aspx.cs" Inherits="EMR.ChestPain" %>
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
              height: 220px;
              border: 2px solid blue;
              border-style: inset;
              border-collapse: collapse
          }
         #left2div {
            float: left;
            width: 30%;
             height: 220px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
          #rightdiv {
            float: left;
            width: 30%;
             height: 220px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
         #middlediv {
            float: left;
            width: 35%;
             height: 260px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
         
           #right2div {
            float: left;
            width: 65%;
             height: 260px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }#space{
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
            height: 50px;
            
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

          .auto-style4 {
              height: 11px;
          }

    </style>
    <div id="headingdiv" align="center" >
        <h2>
            <b>
Chest pain
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
            <h4><b> Pain best described as</b></h4> 
             
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                
               <b> Achy or gnawing</b>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox2" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Burning</b>
            </td>

        </tr>

        <tr>
            <td>
                <asp:CheckBox ID="CheckBox3" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Severe</b>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox4" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Sharp</b>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox5" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Squeezing or pressure</b>

            </td>
            <td>
                <asp:CheckBox ID="CheckBox6" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Sudden</b>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:CheckBox ID="CheckBox7" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Tight</b>
            </td>
           
            
        </tr>
       

       
           
      



            
    </table>
       
           </div>
    <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px">
                    <h4><b>Problem is</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox11" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>New or recent</b>
                    
                    
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox12" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Ongoing or recurrent</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox13" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Preceded by upper respiratory illness</b>
                </td>
            </tr>
           
        </table>

    </div>
    <div id="rightdiv">
        <table align="center">
            <tr>
                <td align="center" height="40px">
                   <h4> <b>Relieved by</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox21" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Antacids</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox22" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Bending forward</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox23" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Rest</b>
                </td>
            </tr>
            
            
        </table>
    </div>
    <div id="middlediv">
        <table align="center">
            <tr>
                <td  height="40px" align="center" colspan="2">
                   <h4> <b>Triggered or worsened by</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox16" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Allergens or irritants</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox8" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Mild to moderate exertion</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox17" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Eating or drinking</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox9" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Pressing on chest wall</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox18" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Exertion</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox10" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Smoking</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox19" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Exposure to cold air</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox14" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Stress</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox20" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    
<b>Lying down for a long period</b>                </td>
                <td>
                    <asp:CheckBox ID="CheckBox15" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Taking a deep breath</b>
                </td>
            </tr>
        </table>
    </div>
    
    <div id="right2div">
        <table align="center">
            <tr>
           <td  align="center" height="40px" colspan="3">
              <h4><b>Accompanied by</b></h4>
           </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox27" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Anxiety</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox24" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Belching</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox25" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Cough with blood or phlegm</b>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:CheckBox ID="CheckBox26" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Difficult or painful swallowing</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox28" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Dry cough</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox29" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Fainting or dizziness</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox30" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Fever</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox31" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Headache</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox32" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Nausea or vomiting</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox33" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Pain in neck, jaw, arms, shoulders or back</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox34" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Rapid or irregular heartbeat</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox35" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Shortness of breath</b>
                </td>
            </tr>
             <tr>
                <td>
                    <asp:CheckBox ID="CheckBox36" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Sweating</b>
                </td>
                <td colspan="2">
                    <asp:CheckBox ID="CheckBox37" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Unexplained fatigue</b>
                </td>
                
            </tr>

        </table>

    </div>
    
    <div class="auto-style4"></div>
    <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-primary btn-lg" runat="server" Text="DONE" Width="84px" Height="41px" OnClick="btnSubmit_Click" Visible="false"></asp:Button>
                     </div>
    <div class="auto-style4" ></div>
     <div id="txtspace" align="center">
         <table>
             <tr>
                 
                 <td>
          <asp:TextBox ID="txtChestPain" runat="server" TextMode="MultiLine"   BorderWidth="2px" BorderColor="Black" Width="675" Rows="5" Visible="false"></asp:TextBox>
            </td></tr> </table>
    </div>
    <div id="lastdiv" align="right">
        <asp:Button ID="btnAdd" runat="server" Height="35px" Width="120px" Text="Add" BackColor="#9999ff" BorderColor="Black" BorderWidth="2px" Font-Bold="true" Font-Size="Medium" OnClick="btnAdd_Click" Visible="false"  />
      </div>
</asp:Content>


