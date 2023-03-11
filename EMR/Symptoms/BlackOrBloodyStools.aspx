<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BlackOrBloodyStools.aspx.cs" Inherits="EMR.BlackOrBloodyStools" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        ::placeholder{
             text-align:center;
         }        #headingdiv{
             float: left;
            width: 100%;
            height: 55px;
        }

        #leftdiv {
            float: left;
            width: 50%;
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
            width: 15%;
             height: 280px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }
           #right2div {
            float: left;
            width: 85%;
             height: 280px;
           
             border: 2px solid blue;
            border-style: inset;
            border-collapse: collapse 
           
        }#space{
              float: left;
            width: 100%;
             height: 10px;
         }
        
             
        #txtspace{
              
                float: left;
            width: 100%;
            height: 50px;
            
           } #addandbackdiv{
             float:left;
            width: 100%;
            height: 20px;
          
           
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

       .auto-style1 {
           height: 9px;
       }

    </style>
   
      
        
    
    <div id="headingdiv" align="center" >
        <h2>
            <b>
Black or Bloody stools
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
            <td align="center" height="10px" colspan="2" >
            
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                
               <b> Constipation</b>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox2" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Diarrhea</b>
            </td>

        </tr>

        <tr>
            <td>
                <asp:CheckBox ID="CheckBox3" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Fever</b>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox4" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Inability to move bowels in spite of urge</b>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox5" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Loose, watery stools</b>

            </td>
            <td>
                <asp:CheckBox ID="CheckBox6" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Nausea or vomiting</b>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox7" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Passing gas</b>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox8" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Pulsing sensation near the navel</b>
            </td>
            
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox9" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Rash</b>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox10" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Stomach growling or rumbling</b>
            </td>
        </tr>
        <tr>
            <td>
                <asp:CheckBox ID="CheckBox28" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>Unintended weight loss</b>
            </td>
            <td>
                <asp:CheckBox ID="CheckBox29" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                <b>Urgent need to have a bowel movement</b>
            </td>
        </tr>

       
           
      



            
    </table>
       
           </div>
    <div id="left2div" align="left">
        <table align="center">
            <tr>
                <td  align="center" height="40px">
                    <h4><b>Blood appears</b></h4>
                </td>
            </tr>
            <tr>
                <td>
                <asp:CheckBox ID="CheckBox11" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                <b>In or on the stool</b>
                    
                    
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox12" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>In toilet bowl or on toilet tissue</b>
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
                    <asp:CheckBox ID="CheckBox16" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Drinking alcohol or caffeine</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox17" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Eating certain foods</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox18" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Straining during bowel movements</b>
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
                    <b>Drinking more water</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox22" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Eating certain foods</b>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox23" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Eating more fiber</b>
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
                    <b>Abdominal pain or cramping</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox13" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Anal itching</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox14" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Change in bowel habits that lasts longer than four weeks</b>
                </td>

            </tr>
            <tr>
                
                <td>
                    <asp:CheckBox ID="CheckBox15" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Change in your bowel habits</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox19" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Constipation</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox20" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Diarrhea</b>
                </td>

            </tr>
            <tr>
                <td>
                    <asp:CheckBox ID="CheckBox24" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Fatigue or weakness</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox25" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Fever</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox26" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Frequent urge to have bowel movement</b>
                </td>
            </tr><tr>
                <td>
                    <asp:CheckBox ID="CheckBox30" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Narrow stools</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox31" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Nausea or vomiting</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox32" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Painful bowel movements</b>
                </td>
            </tr>
            <tr>
               <td>
                    <asp:CheckBox ID="CheckBox33" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Persistent abdominal discomfort, such as cramps, gas or pain</b>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBox34" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};"/>
                    <b>Rectal pain</b>
                </td> 
                 <td >
                    <asp:CheckBox ID="CheckBox35" runat="server" onClick= "if (parentNode.bgColor=='#F8F708'){parentNode.bgColor='#FFFFFF'} else {parentNode.bgColor='#F8F708'};" />
                    <b>Unintended weight loss</b>
                </td>
                
            </tr>
            



        </table>

    </div>
   <div id="space"></div>
    <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-primary btn-lg" runat="server" Text="DONE" Width="84px" Height="41px" OnClick="btnSubmit_Click" Visible="false" ></asp:Button>
                     </div>
    <div class="auto-style1" ></div>
     <div id="txtspace" align="center">
         <table>
             <tr>
                 
                 <td>
          <asp:TextBox ID="txtBloSt" runat="server" TextMode="MultiLine"   BorderWidth="2px" BorderColor="Black" Width="675" Rows="5" Visible="false"></asp:TextBox>
            </td></tr> </table>
    </div>
    <div id="lastdiv" align="right">
        <asp:Button ID="btnAdd" runat="server" Height="35px" Width="120px" Text="Add" BackColor="#9999ff" BorderColor="Black" BorderWidth="2px" Font-Bold="true" Font-Size="Medium" OnClick="btnAdd_Click" Visible="false"  />
</asp:Content>
