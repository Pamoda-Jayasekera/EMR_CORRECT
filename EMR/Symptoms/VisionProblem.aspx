<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VisionProblem.aspx.cs" Inherits="EMR.VisionProblem" %>
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
          height: 400px;
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
            width: 100%;
            height: 320px;
            border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse
        }
        #left4div {
            float: left;
            width: 100%;
            height: 150px;
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
Vision Problem
            </b>
        </h2>
    </div>
    <div align="center">
            <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged">    </asp:TextBox>                 
            </div>
    <br />
    <br />
     <div align="left" id="left3div" >

    <table align="center" >

        <tr  >
            <td align="center" height="40px" colspan="4" >
            <h4><b>Vision problem is</b></h4> 
             
            </td>
        </tr>
         </tr>
           
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Blurry distant objects</b>
                </td>
           
                     <td>
                    <asp:CheckBox ID="CheckBox2" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Blurry nearby objects</b>
                </td>
                   <td>
                    <asp:CheckBox ID="CheckBox4" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Blurry or blind spot in center of vision</b>
                </td>
                     <td>
                    <asp:CheckBox ID="CheckBox14" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Bright zigzag lines</b>
                </td>
            </tr>
           
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox24" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b> Flashes of light</b>
                </td>
        
                <td>
                    <asp:CheckBox ID="CheckBox22" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Double vision</b>
                </td>
         
                     <td>
                    <asp:CheckBox ID="CheckBox16" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Clouded, hazy or dim vision</b>
                </td>
         
                    <td>
                    <asp:CheckBox ID="CheckBox13" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Blurry vision at all distances</b>
                </td>
                   
            </tr>
              
               <tr>
                  
    
                     <td>
                    <asp:CheckBox ID="CheckBox23" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Fading of colors</b>
                </td>
                   
                     <td>
                    <asp:CheckBox ID="CheckBox26" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Halos around lights</b>
                </td>
        
                     <td>
                    <asp:CheckBox ID="CheckBox27" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Inability to distinguish certain shades of color</b>
                </td>
                     <td>
                    <asp:CheckBox ID="CheckBox25" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Glare with bright lights</b>
                </td>
            </tr>
             
            
               <tr>
                    <td>
                    <asp:CheckBox ID="CheckBox30" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b> Poor night vision</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox28" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Loss of side vision</b>
                </td>
         
                     <td>
                    <asp:CheckBox ID="CheckBox29" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Objects appear crooked or distorted</b>
                </td>
                    <td>
                    <asp:CheckBox ID="CheckBox34" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Shimmering spots or stars</b>
                </td>
            </tr>
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox38" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Spots or strings floating in field of vision</b>
                </td>
       
                     <td>
                    <asp:CheckBox ID="CheckBox39" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Tunnel vision</b>
                </td>
                   
       
                     <td>
                    <asp:CheckBox ID="CheckBox31" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Progressive expansion of shadow or curtain over visual field</b>
                </td>
                    <td>
                    <asp:CheckBox ID="CheckBox33" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Sensitivity to light</b>
                </td>
           
            </tr>
        
               <tr>
               
                     <td>
                    <asp:CheckBox ID="CheckBox32" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Seeing nonexistent things, or hallucinating</b>
                </td>
                     <td>
                    <asp:CheckBox ID="CheckBox40" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Vision loss, partial or total</b>
                </td>
          
            </tr>
           </table>
        
       
           </div>
    <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px">
                    <h4><b>Problem affects</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox11" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Both eyes</b>
             
                </td>
            </tr>
              <tr>
                <td>
                <asp:CheckBox ID="CheckBox5" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>One eye</b>
             
                </td>
            </tr>
             
            </table>
         </div>
     <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px" colspan="2">
                    <h4><b>Vision improves somewhat with</b></h4>
                </td>
        </tr>
              <tr>
                <td>
                <asp:CheckBox ID="CheckBox3" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Holding objects away from face</b>
             
                </td>
          
                <td>
                <asp:CheckBox ID="CheckBox6" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Holding objects close to face</b>
             
                </td>
            </tr>
              <tr>
                <td>
                <asp:CheckBox ID="CheckBox35" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b> Squinting</b>
             
                </td>
           
                <td>
                <asp:CheckBox ID="CheckBox36" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Use of bright lighting</b>
             
                </td>
            </tr>
             
            </table>
         </div>
        <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px" colspan="2">
                    <h4><b>Onset is</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox37" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Gradual or progressive</b>
             
                </td>
           
                <td>
                <asp:CheckBox ID="CheckBox41" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Recent (hours to days)</b>
             
                </td>
            </tr>
              <tr>
                <td>
                <asp:CheckBox ID="CheckBox46" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>  Sudden (seconds to minutes)</b>
             
                </td>
            </tr>
             
            </table>
         </div>
     <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px">
                    <h4><b>Duration is</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox42" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>A few minutes</b>
             
                </td>
            </tr>
              <tr>
                <td>
                <asp:CheckBox ID="CheckBox43" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Usually no longer than 30 minutes</b>
             
                </td>
            </tr>
            
            </table>
         </div>
          <div id="left4div">
        <table align="center">
            <tr>
           <td  align="center" height="40px" colspan="4">
              <h4><b>Accompanied by</b></h4>
           </td>
            </tr>
           
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox7" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Confusion or trouble talking</b>
                </td>
              
                     <td>
                    <asp:CheckBox ID="CheckBox8" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Dizziness or difficulty walking</b>
                </td>
       
                <td>
                    <asp:CheckBox ID="CheckBox9" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Eye pain or discomfort</b>
                </td>
        
                    <td>
                    <asp:CheckBox ID="CheckBox10" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Eye redness</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox15" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Eyestrain</b>
                </td>
        
                     <td>
                    <asp:CheckBox ID="CheckBox19" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Headache</b>
                </td>
                  
            
                <td>
                    <asp:CheckBox ID="CheckBox12" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Numbness or weakness on one side of the body</b>
                </td>
        
                     <td>
                    <asp:CheckBox ID="CheckBox17" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Other sensory disturbances</b>
                </td>
           </tr>
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox18" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b> Swelling around the eye</b>
                </td>
                           </tr>
           
</table>
    </div>
    <div id="space"></div>
    <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-primary btn-lg" runat="server" Text="DONE" Width="84px" Height="41px" OnClick="btnSubmit_Click" visible="false"  ></asp:Button>
                     </div>
    <div id="space"></div>
     <div id="txtspace" align="center">
         <table>
             <tr>
                 
                 <td>
          <asp:TextBox ID="txtAbdom" runat="server" TextMode="MultiLine"   BorderWidth="2px" BorderColor="Black" Width="675" Rows="5" visible="false" ></asp:TextBox>
            </td></tr> </table>
    </div>
    <div id="lastdiv" align="right">
        <asp:Button ID="btnAdd" runat="server" Height="35px" Width="120px" Text="Add" BackColor="#9999ff" BorderColor="Black" BorderWidth="2px" Font-Bold="true" Font-Size="Medium" OnClick="btnAdd_Click" visible="false" />
</asp:Content>
