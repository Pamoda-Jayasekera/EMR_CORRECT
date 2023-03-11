<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UrinaryProblem.aspx.cs" Inherits="EMR.UrinaryProblem" %>
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
            width: 50%;
            height: 270px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
         #left2div {
            float: left;
            width: 25%;
             height: 270px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
        #left2.1div {
            float: left;
            width: 20%;
            height: 270px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }

        #left3div {
            float: left;
            width: 100%;
            height: 200px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
      

         #middlediv {
             float: left;
             width: 50%;
             height: 240px;
             border: 2px solid blue;
             border-style: inset;
             border-collapse: collapse
         }
   

        #rightdiv {
            float: left;
            width: 30%;
            height: 240px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
        #right2div {
            float: left;
            width: 20%;
            height: 240px;
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
Urinary Problem
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
            <h4><b>Urinary problem is</b></h4> 
             
            </td>
        </tr>
         <tr>
            <td>
                <asp:CheckBox ID="CheckBox31" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Blood in urine</b>
               
            </td>
              <td>
                <asp:CheckBox ID="CheckBox2" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Change in urine color</b>
            </td>
            </tr>
        <tr>
             <td>
                <asp:CheckBox ID="CheckBox4" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Cloudy urine</b>
            </td>
             <td>
                <asp:CheckBox ID="CheckBox16" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Frequent urination</b>
            </td>
             <tr>
            <td>
                <asp:CheckBox ID="CheckBox32" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Involuntary loss of urine</b>
            </td>

            <td>
                <asp:CheckBox ID="CheckBox33" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Pain or burning when urinating</b>
            </td>

        </tr>
      
           <tr>
           
<td>
                <asp:CheckBox ID="CheckBox1" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                
               <b>Awaking two or more times in the night to urinate</b>
            </td>
                 <td>
                <asp:CheckBox ID="CheckBox34" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Strong, persistent urge to urinate</b>
            </td>
        </tr>
           <tr>
            <td>
                <asp:CheckBox ID="CheckBox13" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Difficulty emptying bladder or weak urine stream</b>
            </td>
   <td>
                <asp:CheckBox ID="CheckBox14" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Difficulty starting urination</b>
            </td>
        </tr>
 
        </table>
        
       
           </div>
    <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px">
                    <h4><b>Related pain involves</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox11" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Itching or burning around genitals, buttocks or inner thighs</b>
             
                </td>
            </tr>
              <tr>
                <td>
                <asp:CheckBox ID="CheckBox5" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b> Pain in back or side</b>
             
                </td>
            </tr>
              <tr>
                <td>
                <asp:CheckBox ID="CheckBox6" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Pain in lower abdomen or groin</b>
             
                </td>
            </tr>
                <tr>
                <td>
                <asp:CheckBox ID="CheckBox3" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Painful ejaculation</b>
             
                </td>
            </tr>
               </tr>
                <tr>
                <td>
                <asp:CheckBox ID="CheckBox35" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Painful sexual intercourse</b>
             
                </td>
            </tr>
          </table>  
    </div>
     <div id="left2div">
        <table align="center">
            <tr>
           <td  align="center" height="40px">
              <h4><b>Worsened by</b></h4>
           </td>
            </tr>
           
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox36" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Menstrual cycle</b>
                </td>
                   </tr>
            <tr>
          
                     <td>
                    <asp:CheckBox ID="CheckBox37" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Stress</b>
                </td>
                   
            </tr>
            </table>
         </div>
          <div id="left3div">
        <table align="center">
            <tr>
           <td  align="center" height="40px" colspan="4">
              <h4><b>Accompanied by</b></h4>
           </td>
            </tr>
           
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox7" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Blurred vision</b>
                </td>
                           <td>
                    <asp:CheckBox ID="CheckBox8" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Bumps, blisters or open sores around genitals</b>
                </td>
                    <td>
                    <asp:CheckBox ID="CheckBox9" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Change in vaginal discharge</b>
                </td>
                   </tr>
         
           
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox15" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Extreme thirst or hunger</b>
                </td>
                    <td>
                    <asp:CheckBox ID="CheckBox19" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Fatigue</b>
                </td>
                    <td>
                    <asp:CheckBox ID="CheckBox10" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Clear discharge from penis</b>
                </td>
                           </tr>
           
              
           
               <tr>
                    <td>
                    <asp:CheckBox ID="CheckBox18" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b> Pus-filled discharge from penis</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox12" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Fever</b>
                </td>
                   
                     <td>
                    <asp:CheckBox ID="CheckBox17" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Nausea or vomiting</b>
                </td>
                           </tr>
           
               <tr>
               
                     <td>
                    <asp:CheckBox ID="CheckBox21" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Vaginal odor</b>
                </td>
                    <td>
                    <asp:CheckBox ID="CheckBox20" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Unintended weight loss</b>
                </td>
                           </tr>
           
            
              
</table>
    </div>
     <div id="space"></div>
    <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-primary btn-lg" runat="server" Text="DONE" Width="84px" Height="41px" OnClick="btnSubmit_Click" Visible="false"  ></asp:Button>
                     </div>
    <div id="space"></div>
     <div id="txtspace" align="center">
         <table>
             <tr>
                 
                 <td>
          <asp:TextBox ID="txtAbdom" runat="server" TextMode="MultiLine"   BorderWidth="2px" BorderColor="Black" Width="675" Rows="5" Visible="false" ></asp:TextBox>
            </td></tr> </table>
    </div>
    <div id="lastdiv" align="right">
        <asp:Button ID="btnAdd" runat="server" Height="35px" Width="120px" Text="Add" BackColor="#9999ff" BorderColor="Black" BorderWidth="2px" Font-Bold="true" Font-Size="Medium" OnClick="btnAdd_Click" Visible="false"  />
</asp:Content>
