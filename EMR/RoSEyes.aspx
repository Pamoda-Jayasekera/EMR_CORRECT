<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RoSEyes.aspx.cs" Inherits="EMR.RoSEyes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
         ::placeholder{
             text-align:center;
         }
          .space {
            float: left;
            width: 100%;
            height: 30px;
        }
        .tablediv {
            float: left;
            width: 100%;
        }
           #leftdiv {
            float: left;
            width: 100%;
            
           
          
        }
         #rightdiv {
            float: left;
            width: 100%;
            
           
          
        }
           #last {
            float: left;
            width: 100%;
           
           
          
        }
          
          .yes input[type="checkbox"]{
  
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

    </style>
     <div class="heading">
        <h3 align="center"><b>EYES</b></h3>
    </div>
    <div class="space"> </div>
    <div class="centerblock" align="center">
        <asp:TextBox ID="txtHOM" runat="server" autocomplete="off" ClientIdMode="Static" spellcheck="false" Width="800px" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged"></asp:TextBox>
     </div>
    <br />
    <div class="tablediv" align="center">
         <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label1" runat="server" Text="Label"> <b>DRY EYES</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox1" runat="server" CssClass="yes" />
                </td>
</tr>
             <tr align="left">
           

                <td height="30px" width="450px" style="background-color:yellow">
                    <asp:Label ID="Label2" runat="server" Text="Label"> <b>IRRITATION</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox2" runat="server" CssClass="yes" />
                </td>
</tr> 
    </table>
       
           </div>
     <div class="space">
      
    </div>
    <div>
        <h4 align="center">
           <b>CORNEAS</b> 
        </h4>
    </div>
    
     <div align="center" id="leftdiv" >

    <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label3" runat="server" Text="Label"> <b>ABNORMAL MOLE</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox3" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label5" runat="server" Text="Label"> <b>JAUNDICE</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox5" CssClass="yes" runat="server" /></td>
               

</tr>
        <tr> 
                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label12" runat="server" Text="Label"> <b>RASH</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox6" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label13" runat="server" Text="Label"> <b>LACERATION</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox7" CssClass="yes" runat="server" /></td>
                
          </tr>
        <tr> 
                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label14" runat="server" Text="Label"> <b>ITCHING</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox8" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label15" runat="server" Text="Label"> <b>DRY SKIN</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox9" CssClass="yes" runat="server" /></td>
                
          </tr>
    </table>
       
           </div>
    <div class="space"></div>
    <div>
        <h4 align="center">
           <b>FUNDUSCOPIC</b> 
        </h4>
    </div>
     <div id="rightdiv" align ="center">

          <table border="2px" >

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label6" runat="server" Text="Label"> <b>GROSSLY NORMAL</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox11" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label8" runat="server" Text="Label"> <b>NORMAL VESSELS</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox13" CssClass="yes" runat="server" /></td>
               

</tr>
        <tr> 
                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label9" runat="server" Text="Label"> <b>NORMAL OPTIC DISCS</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox14" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label10" runat="server" Text="Label"> <b>HEMORRHAGES</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox15" CssClass="yes" runat="server" /></td>
                
          </tr>
        <tr> 
                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label11" runat="server" Text="Label"> <b>INCREASED CUPPING</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox16" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label18" runat="server" Text="Label"> <b>PAPLLEDEMA</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox17" CssClass="yes" runat="server" /></td>
                
          </tr>
        <tr> 
                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label19" runat="server" Text="Label"> <b>NARROWING OF ARTERIOLES</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox18" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label20" runat="server" Text="Label"> <b>A-V NICKING</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox19" CssClass="yes" runat="server" /></td>
                
          </tr>
              <tr> 
                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label21" runat="server" Text="Label"> <b>EXUDATES</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox20" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label22" runat="server" Text="Label"> <b>SOFT EXUDATES</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox21" CssClass="yes" runat="server" /></td>
                
          </tr>
               <tr> 
                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label23" runat="server" Text="Label"> <b>OPTIC DISC NOT WELL VISUALIZED</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox22" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label24" runat="server" Text="Label"> <b>HARD EXUDATES</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox23" CssClass="yes" runat="server" /></td>
                
          </tr>
               <tr> 
                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label25" runat="server" Text="Label"> <b>FUNDUS NOT WELL VISUALIZED</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox24" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label26" runat="server" Text="Label"> <b>BLURRED MARGINS</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox25" CssClass="yes" runat="server" /></td>
                
          </tr>
            
    </table>
     </div>
    <div class="space"></div>
    <div>
        <h4 align="center">
           <b>EOM</b> 
        </h4>
    </div>
    
     <div align="center" id="last" >

    <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label27" runat="server" Text="Label"> <b>EOMI</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox26" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label28" runat="server" Text="Label"> <b>DISCONJUGATED</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox27" CssClass="yes" runat="server" /></td>
               

</tr>
        <tr> 
                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label29" runat="server" Text="Label"> <b>STRABISMUS</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox28" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label30" runat="server" Text="Label"> <b>NYSTAGMUS</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox29" CssClass="yes" runat="server" /></td>
                
          </tr>
        
    </table>
       
           </div>
    <div class="space"></div>
     <div>
        <h4 align="center">
           <b>LENS</b> 
        </h4>
    </div>
    
     <div align="center" id="leftdiv" >

    <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label35" runat="server" Text="Label"> <b>CLEAR</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox34" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label36" runat="server" Text="Label"> <b>CATARACT</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox35" CssClass="yes" runat="server" /></td>
                
          

</tr>
            
    </table>
       
           </div>
    <div class="space"></div>
     <div>
        <h4 align="center">
           <b>SCLERA</b> 
        </h4>
    </div>
    
     <div align="center" id="rightdiv" >

    <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label37" runat="server" Text="Label"> <b>INJECTED</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox36" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label38" runat="server" Text="Label"> <b>ICTERIC</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox37" CssClass="yes" runat="server" /></td>
               

</tr>
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label39" runat="server" Text="Label"> <b>ABRASION</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center">
                    <asp:CheckBox ID="CheckBox38" runat="server" CssClass="yes" />
                </td>
              
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label40" runat="server" Text="Label"> <b></b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox39" CssClass="yes" runat="server" /></td>
               
               
</tr>    
        
    </table>
       
           </div>
    <div class="space"> </div>
     
    <div>
        <h4 align="center">
           <b>VISION</b> 
        </h4>
    </div>
    
     <div align="center" id="last" >

    <table border="2px">

        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label45" runat="server" Text="Label"> <b>ACUITY GROSSLY INTACT</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center" >
                    <asp:CheckBox ID="CheckBox44" runat="server" CssClass="yes" />
                </td>
                
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label46" runat="server" Text="Label"> <b>FIELD OUT</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox45" CssClass="yes" runat="server" /></td>
               

</tr>
        <tr align="left">
           

                <td height="30px" width="450px" style="background-color:#F8F708">
                    <asp:Label ID="Label47" runat="server" Text="Label"> <b>PREPHERAL VISON GROSSLY INTACT</b></asp:Label>
                   
                </td>
                <td height="30px" width="50px" align="center">
                    <asp:CheckBox ID="CheckBox46" runat="server" CssClass="yes" />
                </td>
              
                <td height="30px" width="450px" style="background-color:#F8F708">
                     <asp:Label ID="Label48" runat="server" Text="Label"> <b>ACUITY IMPAIRED</b></asp:Label>
                   
                </td>
                <td  height="30px" width="50px" align="center"><asp:CheckBox ID="CheckBox47" CssClass="yes" runat="server" /></td>
               
               

    </table>
       
           </div>
   <div class="space"></div>
      <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="SUBMIT" Width="100px" Height="45px" OnClick="btnSubmit_Click" ></asp:Button>
                     </div>
            <br />
                      <div class="centerblock" align="center">
                      <asp:Label ID="Label7" runat="server" Text="Label" ><a  href="javascript:history.back(-1);"><b>Go Back</b></a></asp:Label> 
 
                     </div>
     <asp:TextBox ID="txtEyes" runat="server" TextMode="MultiLine" Visible="false" ></asp:TextBox>
</asp:Content>
