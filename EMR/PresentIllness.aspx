<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PresentIllness.aspx.cs" Inherits="EMR.PresentIllness" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <style>
     ::placeholder{
             text-align:center;
         }
       .space {
            float: left;
            width: 100%;
            height: 20px;
            
        }
          #leftdiv {
              float: left;
              width: 100%;
              height: 460px;
              border: 2px solid red;
              border-style: inset;
              border-collapse: collapse
          }
        #leftdiv2 {
            float: left;
            width: 100%;
            height: 558px;
            border: 2px solid red;
            border-style: inset;
            border-collapse: collapse
             

        }
        #rightdiv {
            float: left;
            width: 100%;
            height: 628px;
             border: 2px solid red;
            border-style: inset;
            border-collapse: collapse 
           
        }
        #right2div {
            float: left;
            width: 100%;
            height: 453px;
             border: 2px solid red;
            border-style: inset;
            border-collapse: collapse 
           
        }
        .meddiv {
            float: left;
            width: 100%;
            height: 20px;
            
           
        }
        .med2div {
            float: left;
            width: 100%;
            height: 20px;
            
           
        }
      .pr input[type="checkbox"]{
  
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
       .pr input[type="checkbox"]:checked {
            background-color: red;
       }



    input[type="checkbox" ]{
  /* remove standard background appearance */
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none;
  /* create custom radiobutton appearance */
  
  width: 25px;
  height: 25px;
  
  /* background-color only for content */
 
  border: 2px solid #bbbbbb;
  background-color: blue;
  
}
       
   input[type="checkbox"]:checked {
            background-color: red;
       }
   
       
    
          .auto-style1 {
              height: 9px;
          }
   
       
    
      </style>
 
  <div class="centerblock">
            <h1 align="center"><b>Presenting Illness</b></h1>
            <br />
      </div><div align="center">
                <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true" OnTextChanged="txtHOM_TextChanged" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM">    </asp:TextBox>   </div>              
    <br />
    <p class ="a"> </p>
    <div><table border=1 cellpadding=2 id="table">
        <tr>
            
             
            <td  width="1500" height="5"   >
              
            <asp:CheckBox  ID="CheckBox1" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
           
                <asp:Label ID="Label3" runat="server" Text="Label" ><a  href="/Symptoms/AbdominalPain.aspx"><b>Abdominal Pain</b>  </a></asp:Label>
            </td>
            
        
           
             <td width="1500" height="5"  >
             <asp:CheckBox  ID="CheckBox2" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
              <asp:Label ID="Label4" runat="server" Text="Label" ><a  href="/Symptoms/BlackOrBloodyStools.aspx"><b>Black or Bloody Stools</b></a></asp:Label>
            </td>

        
            
             <td width="1500" height="5" >
                <asp:CheckBox  ID="CheckBox3" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"  />
                <asp:Label ID="Label6" runat="server" Text="Label"><a  href="/Symptoms/ChestPain.aspx"><b>Chest Pain</b></a></asp:Label>
            </td>

       
            
            <td width="1500" height="5">
                <asp:CheckBox  ID="CheckBox4" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"  />
                <asp:Label ID="Label8" runat="server" Text="Label"><a  href="/Symptoms/Constipation.aspx"><b>Constipation</b></a></asp:Label>
            </td>
             </tr>

             <tr>
       
            
             <td >
             <asp:CheckBox   ID="CheckBox5" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
             <asp:Label ID="Label10" runat="server" Text="Label"><a  href="/Symptoms/Cough.aspx"><b>Cough</b></a></asp:Label>
            </td>

       
            
            <td >
                <asp:CheckBox  ID="CheckBox6" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label12" runat="server" Text="Label"><a  href="/Symptoms/Diarrhea.aspx"><b>Diarrhea</b></asp:Label>
            </td>

       
            
            <td  >
              <asp:CheckBox  ID="CheckBox7" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
             <asp:Label ID="Label14" runat="server" Text="Label"><a  href="/Symptoms/DifficultySwallowing.aspx"><b>Difficulty Swallowing</b></a></asp:Label>
            </td>

            
            <td >
                <asp:CheckBox  ID="CheckBox8" runat="server"   onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <asp:Label ID="Label16" runat="server" Text="Label"><a  href="/Symptoms/Dizziness.aspx"><b>Dizziness</b></asp:Label>
            </td>
       </tr>
        <tr>
       
            <td >
                <asp:CheckBox  ID="CheckBox9" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <asp:Label ID="Label18" runat="server" Text="Label"><a  href="/Symptoms/EyeDiscomfortandRedness.aspx"><b>Eye Discomfort and Redness</b></a></asp:Label>
            </td>

       
            
            <td  >
                <asp:CheckBox  ID="CheckBox10" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label20" runat="server" Text="Label"><a  href="/Symptoms/FootPainorAnklePain.aspx"><b>Foot Pain or Ankle Pain</b></a></asp:Label>
            </td>

       
          
            <td >
                <asp:CheckBox  ID="CheckBox11" runat="server"   onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <asp:Label ID="Label22" runat="server" Text="Label"><a  href="/Symptoms/FootSwellingorLegSwelling.aspx"><b>Foot Swelling or Leg Swelling</b></a></asp:Label>
            </td>

            
            <td >
                <asp:CheckBox  ID="CheckBox12" runat="server"   onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <asp:Label ID="Label24" runat="server" Text="Label"><a  href="/Symptoms/Headache.aspx"><b>Headache</b></a></asp:Label>
            </td>
             </tr>
        <tr>

            
            <td >
                <asp:CheckBox  ID="CheckBox13" runat="server"   onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <asp:Label ID="Label26" runat="server" Text="Label"><a  href="/Symptoms/HeartPalpitations.aspx"><b>Heart Palpitations</b></a></asp:Label>
            </td>

      
            
            <td >
                <asp:CheckBox  ID="CheckBox14" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label28" runat="server" Text="Label"><a  href="/Symptoms/HipPain.aspx"><b>Hip Pain</b></a></asp:Label>
            </td>

       
            
            <td >
                <asp:CheckBox  ID="CheckBox15" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label30" runat="server" Text="Label"><a  href="/Symptoms/KneePain.aspx"><b>Knee pain</b></a></asp:Label>
            </td>

        
            
            <td >
                <asp:CheckBox  ID="CheckBox16" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label32" runat="server" Text="Label"><a  href="/Symptoms/LowBackPain.aspx"><b>Low Back Pain</b></a></asp:Label>
            </td>
            </tr>
        <tr>
       
            
            <td >
                <asp:CheckBox  ID="CheckBox17" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label34" runat="server" Text="Label"><a  href="/Symptoms/NasalCongestion.aspx"><b>Nasal Congestion</b></a></asp:Label>
            </td>

       
            
            <td >
                <asp:CheckBox  ID="CheckBox18" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label36" runat="server" Text="Label"><a  href="/Symptoms/NauseaorVomitting.aspx"><b>Nausea or Vomitting</b></a></asp:Label>
            </td>

        
            
            <td >
                <asp:CheckBox  ID="CheckBox19" runat="server"   onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <asp:Label ID="Label38" runat="server" Text="Label"><a  href="/Symptoms/NeckPain.aspx"><b>Neck pain</b></a></asp:Label>
            </td>

           
            <td >
                <asp:CheckBox  ID="CheckBox20" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label40" runat="server" Text="Label"><a  href="/Symptoms/NumbnessorTinglinginHands.aspx"><b>Numbness or Tingling in Hands</b></asp:Label>
            </td>
             </tr>
        <tr>
       
            
            <td >
                <asp:CheckBox  ID="CheckBox21" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label42" runat="server" Text="Label"><a  href="/Symptoms/PelvicPainFemale.aspx"><b>Pelvic Pain: Female</b></a></asp:Label>
            </td>

       
           
            <td >
                <asp:CheckBox  ID="CheckBox22" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label44" runat="server" Text="Label"><a  href="/Symptoms/PelvicPainMale.aspx"><b>Pelvic Pain: Male</b></a></asp:Label>
            </td>

        
            
            <td >
                <asp:CheckBox  ID="CheckBox23" runat="server"   onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <asp:Label ID="Label46" runat="server" Text="Label"><a  href="/Symptoms/ShortnessofBreath.aspx"><b>Shortness of Breath</b></asp:Label>
            </td>

       
            
            <td >
                <asp:CheckBox ID="CheckBox24" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label48" runat="server" Text="Label"><a  href="/Symptoms/ShoulderPain.aspx"><b>Shoulder Pain</b></a></asp:Label>
            </td>
             </tr>
        <tr>
       
            
            <td >
                <asp:CheckBox  ID="CheckBox25" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <asp:Label ID="Label50" runat="server" Text="Label"><a  href="/Symptoms/SoreThroat.aspx"><b>Sore throat</b></a></asp:Label>
            </td>

       
          
            <td >
                <asp:CheckBox  ID="CheckBox26" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <asp:Label ID="Label52" runat="server" Text="Label"><a  href="/Symptoms/UrinaryProblem.aspx"><b>Urinary Problem</b></a></asp:Label>
            </td>

            
            <td >
                <asp:CheckBox  ID="CheckBox27" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <asp:Label ID="Label54" runat="server" Text="Label"><a  href="/Symptoms/VisionProblem.aspx"><b>Vision Problem</b></a></asp:Label>
            </td>

       
            
            <td >
                <asp:CheckBox  ID="CheckBox28" runat="server"  onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
              <asp:Label ID="Label56" runat="server" Text="Label"><a  href="/Symptoms/Wheezing.aspx" onclick=""><b>Wheezing</b></a></asp:Label>
            </td>

        </tr>
        

         </table>

        </div>
    <br />
    <div align="center">
       <asp:TextBox ID="txtSymptoms" runat="server" Width="700px" TextMode="MultiLine" Rows="14"></asp:TextBox></div>
    
</asp:Content>
