<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PelvicPainFemale.aspx.cs" Inherits="EMR.PelvicPainFemale" %>
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
           height: 200px;
           border: 2px solid blue;
           border-style: inset;
           border-collapse: collapse
       }
         #left2div {
            float: left;
            width: 50%;
             height: 200px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
        #left3div {
            float: left;
            width: 100%;
            height: 250px;
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
Pelvic Pain: Female
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
            <h4><b>Pelvic Pain</b></h4> 
             
            </td>
        </tr>
         <tr>
            <td>
                <asp:CheckBox ID="CheckBox31" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                
               <b>Begin suddenly</b>
            </td>
              <td>
                <asp:CheckBox ID="CheckBox14" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Ongoing</b>
            </td>
            </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                
               <b>Cyclical or recurrent</b>
            </td>
              <td>
                <asp:CheckBox ID="CheckBox16" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Sharp or crampy</b>
            </td>
            </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox2" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Different from usual menstrual cramps</b>
            </td>
               <td>
                <asp:CheckBox ID="CheckBox4" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Dull or achy</b>
            </td>
        </tr>
      
           <tr>
            <td>
                <asp:CheckBox ID="CheckBox13" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Itching or burning around genitals, buttocks or inner thighs</b>
            </td>

        </tr>
     
      
          
        </table>
        
       
           </div>
    <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px">
                    <h4><b>Worsened by</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox11" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Lifting or straining</b>
             
                </td>
            </tr>
              <tr>
                <td>
                <asp:CheckBox ID="CheckBox5" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Menstrual cycle</b>
             
                </td>
            </tr>
              <tr>
                <td>
                <asp:CheckBox ID="CheckBox6" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Movement or physical activity</b>
             
                </td>
            </tr>
                <tr>
                <td>
                <asp:CheckBox ID="CheckBox3" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
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
                    <b>Abnormal vaginal bleeding</b>
                </td>
           
                     <td>
                    <asp:CheckBox ID="CheckBox8" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Black or bloody stools</b>
                         </td>
                          <td>
                    <asp:CheckBox ID="CheckBox9" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Bloating, constipation or diarrhea</b>
                </td>
                           <td>
                    <asp:CheckBox ID="CheckBox15" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Change in vaginal discharge</b>
                </td>
               
                   
            </tr>
           
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox18" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Increased waist size</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox12" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Fever</b>
                </td>
          
                 
                     <td>
                    <asp:CheckBox ID="CheckBox19" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Excessive menstrual bleeding</b>
                </td>
                    <td>
                    <asp:CheckBox ID="CheckBox10" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Bumps, blisters or open sores</b>
                </td>
                   
            </tr>
        
               <tr>
                    <td>
                    <asp:CheckBox ID="CheckBox21" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Lightheadedness or fainting</b>
                </td>
                   
                     <td>
                    <asp:CheckBox ID="CheckBox22" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Low back pain</b>
                </td>
              
                     <td>
                    <asp:CheckBox ID="CheckBox20" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Irregular periods</b>
                </td>
                 
                     <td>
                    <asp:CheckBox ID="CheckBox17" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Frequent urination or urge to urinate</b>
                </td>
            </tr>
               
         
               <tr>
                    <td>
                    <asp:CheckBox ID="CheckBox25" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Painful bowel movements</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox23" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Mood swings</b>
                </td>
                
                     <td>
                    <asp:CheckBox ID="CheckBox24" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Nausea or vomiting</b>
                </td>
                    <td>
                    <asp:CheckBox ID="CheckBox27" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Painful sexual intercourse</b>
                </td>
            </tr>
               <tr>
                <td>
                    <asp:CheckBox ID="CheckBox30" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Weight gain</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox29" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Unintended weight loss</b>
                </td>
               
                     <td>
                    <asp:CheckBox ID="CheckBox28" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Skin rash</b>
                </td>
               
                     <td>
                    <asp:CheckBox ID="CheckBox26" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Painful or difficult urination</b>
                </td></tr>
       
          
              
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
        <asp:Button ID="btnAdd" runat="server" Height="35px" Width="120px" Text="Add" BackColor="#9999ff" BorderColor="Black" BorderWidth="2px" Font-Bold="true" Font-Size="Medium" OnClick="btnAdd_Click"  visible="false"/>
</asp:Content>
