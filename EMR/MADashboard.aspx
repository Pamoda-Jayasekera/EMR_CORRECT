 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MADashboard.aspx.cs" Inherits="EMR.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 
    <style>
        ::placeholder{
             text-align:center;
         }
        .leftdiv1 {
            float: left;
            width: 180px;
            height:auto;
            
        }
        .leftdiv2 {
            float: left;
            width: 200px;
            height: auto;
        }
           .leftdiv3 {
            float:left;
            width: 180px;
            height: 100px;
            background-color:lightyellow;
        }
           .leftdiv1n {
            float: left;
            width: 100px;
            height: auto;
        }

        input[type="checkbox"] {
            /* remove standard background appearance */
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            /* create custom radiobutton appearance */
            display: inline-block;
            width: 15px;
            height: 15px;
            /* background-color only for content */
            background-clip: content-box;
            border: 2px solid #bbbbbb;
            background-color: white;
            border-radius: 50%;
        }
        .CM {
            float: left;
            width: 340px;
            height: auto;
            position:center;
        }
        .PI {
            float: left;
            width: 210px;
            height: auto;
        }

        /* appearance for checked radiobutton */
        .gr input[type="checkbox"]:checked {
            background-color: green;
        }

        .re input[type="checkbox"]:checked {
            background-color: red;
        }

        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style8 {
            float: left;
            width: 222px;
            height: auto;
        }
        .auto-style9 {
            float: left;
            width: 167px;
            height: auto;
            margin-left: 11px;
        }
        .auto-style10 {
            float: left;
            width: 251px;
            height: 47px;
            position: center;
        }
        .auto-style12 {
            width: 123px;
        }
        .auto-style16 {
            float: left;
            width: 217px;
            height: 45px;
        }
        .auto-style20 {
            margin-left: 0;
        }
        .auto-style40 {
            width: 160px;
        }
        .auto-style41 {
            width: 194px;
        }
        .auto-style45 {
            width: 225px;
        }
        .auto-style46 {
            margin-bottom: 19;
        }
        .auto-style49 {
            width: 201px;
        }
        .auto-style50 {
            width: 215px;
        }
        .auto-style53 {
            width: 108px;
        }
        .auto-style60 {
            float: left;
            width: 361px;
            height: auto;
        }
        .auto-style65 {
            height: 98px;
            width: 143px;
        }
        .auto-style66 {
            height: 98px;
            width: 63px;
        }
        .auto-style67 {
            height: 98px;
            width: 111px;
        }
        .auto-style68 {
            height: 98px;
            width: 18px;
        }
        .auto-style69 {
            height: 98px;
            width: 171px;
        }
        .auto-style70 {
            height: 98px;
            width: 196px;
        }
        .auto-style71 {
            height: 98px;
        }
        .auto-style74 {
            height: 91px;
            width: 143px;
        }
        .auto-style75 {
            height: 91px;
            width: 63px;
        }
        .auto-style76 {
            height: 91px;
            width: 111px;
        }
        .auto-style77 {
            height: 91px;
            width: 18px;
        }
        .auto-style78 {
            height: 91px;
            width: 171px;
        }
        .auto-style79 {
            height: 91px;
            width: 196px;
        }
        .auto-style80 {
            height: 91px;
        }
        .auto-style81 {
            height: 93px;
            width: 196px;
        }
        .auto-style82 {
            height: 93px;
        }
        .auto-style83 {
            height: 93px;
            width: 143px;
        }
        .auto-style84 {
            width: 167px;
        }
        .auto-style86 {
            width: 157px;
        }
        .auto-style87 {
            width: 176px;
        }
        .auto-style90 {
            height: 93px;
            width: 6px;
        }
        .auto-style91 {
            height: 98px;
            width: 6px;
        }
        .auto-style92 {
            height: 91px;
            width: 6px;
        }
        .auto-style93 {
            margin-top: 0px;
        }
         .bold-big-text {
        font-weight: bold;
        font-size: 18px;
    }
        .auto-style94 {
            width: 169px;
        }
        .auto-style95 {
            width: 101px;
        }
        .auto-style96 {
            width: 1338px;
        }
        .auto-style97 {
            float: left;
            width: 169px;
            height: auto;
        }
        .auto-style98 {
            float: left;
            width: 203px;
            height: auto;
        }
        .auto-style99 {
            width: 205px;
        }
    </style>
    <body>
     <div class="centerblock">
    <h2><b>MEDICAL ASSISTANT DASHBOARD- VITALS</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<input type="text" id="t1" name="txtDate" style="width:356px;border:none" autocomplete="off"/>        </h2>  </div>
    <br />
    <table>
            <tr>
              <div style="position: fixed" align="center">
            <asp:TextBox ID="txtRBMA" runat="server" AutoPostBack="true" OnTextChanged="txtRBMA_TextChanged" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE HERE/MRN/ADD/CLR/DEL/LOGOUT/PRD-Prediction">    </asp:TextBox>                 
        
                  </div>
                </tr>
                    
                </table>
     <br /> <br /> <br /><br />
        <br /> <br /><br />
               <table>
            <tr>
               <div align="center" >
                  <asp:Button ID="Button1" class="btn btn-primary btn-lg"  runat="server" Text="ADD" Width="90px" OnClick="Button1_Click" visible="false"/>
                  <asp:Button ID="btnClear" class="btn btn-primary btn-lg"  runat="server" Text="CLEAR" Width="90px" OnClick="Button2_Click" visible="false" />
                  <asp:Button ID="Button3" class="btn btn-primary btn-lg"  runat="server" Text="DELETE" Width="95px" OnClick="Button3_Click" visible="false"/> 
                  <asp:Button ID="btnOut"  class="btn btn-primary btn-lg"  runat="server" Text="LOG OUT" Width="110px" OnClick="btnLogOut_Click" visible="false"/>

                  <asp:Button ID="btnSearch" Visible="false" class="btn btn-primary btn-lg" runat="server" Text="SEARCH"  />  
                   </div>
                </tr>
            </table>
           <br />
    

     <table class="data" style="width: 1321px">
       <tr>
            <td class="auto-style70">
        <p class="auto-style41" >
         <asp:Label ID="Label2" runat="server" colspan="3" BackColor="#D1D7D8" Width="203px" Height="48px" > <b >Name<span style="color:red;">(PTN):</span></b></asp:Label>
        <asp:TextBox ID="txtPTN" runat="server" Width="191px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
        <td class="auto-style91"> <p class="auto-style86">
        <asp:Label ID="Label1" runat="server" BackColor="#D1D7D8" Width="198px" Height="44px" CssClass="auto-style93" ><b>AppointmentCode<span style="color:red;">(APC):</span></b></asp:Label>
         <asp:TextBox ID="txtApCode" runat="server" Width="147px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
       <td class="auto-style65">
           <p class="auto-style50">
        <asp:Label ID="Label3" runat="server" BackColor="#D1D7D8" Width="224px" Height="49px" ><b>Medical Record Number<span style="color:red;">(MRN):</span></b></asp:Label>
       <asp:TextBox ID="txtMRN" runat="server" Width="160px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center" CssClass="auto-style46"></asp:TextBox></p>
       </td>
        <td class="auto-style66"><p>
        <asp:Label ID="Label11" runat="server" BackColor="#D1D7D8" Width="122px" Height="52px"  ><b>Vital ID<span style="color:red;">(VID):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtVID" runat="server"  Width="104px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>   
           <td class="auto-style67">
                <p >
        <asp:Label ID="Label12" runat="server" BackColor="#D1D7D8" Width="143px" Height="48px" ><b>Age:</b></asp:Label>
          
        <asp:TextBox  ID="txtAge" runat="server" Width="119px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true"  Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
          <td class="auto-style68"><p >
        <asp:Label ID="Label13" runat="server" BackColor="#D1D7D8" Width="128px" Height="50px" ><b>District<span style="color:red;">(DIS):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtDistrict" runat="server"  Width="100" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        
        </td>
           <td class="auto-style69"><p >
        <asp:Label ID="Label14" runat="server" BackColor="#D1D7D8" Width="151px" Height="51px" ><b>Gender<span style="color:red;">(GEN):</span></b></asp:Label>
             
        <asp:TextBox  ID="txtGen" runat="server"  Width="100" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox> </p>
        </td>
             <td class="auto-style71"><p>
          
        <asp:Label ID="Label17" runat="server" BackColor="#D1D7D8" Width="160px" Height="50px" ><b>BMI<span style="color:red;">(BMI):</span></b></asp:Label>
        <asp:TextBox  ID="txtBMI" runat="server"  Width="110px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>  
       
                </tr><tr>
           <td class="auto-style79"><p  >
               <asp:Label ID="Label4" runat="server"  BackColor="#D1D7D8" Width="204px" Height="51px" ><b>BloodPressure (mmHg)<span style="color:red;">(BP):</span></b></asp:Label> 
        <asp:TextBox ID="txtBP" runat="server" Width="198px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
                    <td class="auto-style92"><p class="auto-style87" >
                <asp:Label ID="Label7" runat="server" BackColor="#D1D7D8" Width="200px" Height="50px"  ><b>Pulse (BPM)<span style="color:red;">(PUL):</span></b></asp:Label> 
                <asp:TextBox ID="txtPulse" runat="server" Width="139px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
        </td>
           <td class="auto-style74"><p class="auto-style49">
        <asp:Label ID="Label8" runat="server" BackColor="#D1D7D8" Width="226px" Height="50px" ><b>Temperature (°C)<span style="color:red;">(TEM):</span></b></asp:Label>
        <asp:TextBox ID="txtTemp" runat="server" Width="123px"  autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center" CssClass="auto-style20"></asp:TextBox></p>
                   
        </td>
         <td class="auto-style75"><p class="auto-style53" >
         <asp:Label ID="Label6" runat="server" BackColor="#D1D7D8" Width="127px" Height="51px"  ><b>Height (cm)<span style="color:red;">(HEI):</span></b></asp:Label>
          <asp:TextBox ID="txtHei" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center" CssClass="auto-style20"></asp:TextBox></p>
       </td>
                    <td class="auto-style76">
                     <p  >
        <asp:Label ID="Label5" runat="server" BackColor="#D1D7D8" Width="143px" Height="48px" ><b>Weight(Kg)<span style="color:red;">(WEI):</span></b></asp:Label>
        <asp:TextBox ID="txtWei" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>
                     <td class="auto-style77"><p>
            <asp:Label ID="Label9" runat="server"   BackColor="#D1D7D8" Width="126px" Height="50px"><b>PO2<span style="color:red;">(PO2):</span></b></asp:Label>
       <asp:TextBox ID="txtPO2" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
          <td class="auto-style78"><p>
          <asp:Label ID="Label18" runat="server"  BackColor="#D1D7D8" Width="153px" Height="49px" ><b>BloodGroup<span style="color:red;">(BGP):</span></b></asp:Label>
        <asp:TextBox  ID="txtBGP" runat="server"  Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </p>
        </td>
             <td class="auto-style80" colspan="2"><p>
        <asp:Label ID="Label21" runat="server"  BackColor="#D1D7D8" Width="160px" Height="50px" ><b>DOB<span style="color:red;">(DOB):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtDOB" runat="server" Width="108px" autocomplete="off" placeholder="yyyy/mm/dd" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>       
  
    
           </tr>
        <tr>
<td class="auto-style81"><p>
        <asp:Label ID="Label19" runat="server" colspan="3" BackColor="#D1D7D8" Width="204px" Height="51px"><b>Pharmacy Fax<span style="color:red;">(PFX):</span></b></asp:Label>

           
        <asp:TextBox  ID="txtPFX" runat="server"  Width="190px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td> 
             <td class="auto-style90"><p class="auto-style84" >
        <asp:Label ID="Label20" runat="server"  BackColor="#D1D7D8" Width="196px" Height="49px"><b>Primary Care Physician<span style="color:red;">(PCP):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtPCP" runat="server"  Width="160px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
           </td>

              <td class="auto-style83" ><p class="auto-style45" >
        <asp:Label ID="Label22" runat="server"  BackColor="#D1D7D8" Width="226px" Height="49px"><b>HbA1c<span style="color:red;">(HBA):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtHBA" runat="server"  Width="217px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
           </td>


            <td class="auto-style82" colspan="2"><p>
          
        <asp:Label ID="Label10" runat="server"  BackColor="#D1D7D8" Width="271px" Height="51px" ><b>Emergency Contact<span style="color:red;">(ECN):</span></b></asp:Label>
        <asp:TextBox  ID="txtECN" runat="server"  Width="207px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>
            
            <td class="auto-style82" colspan="2"><p>
        <asp:Label ID="Label15" runat="server"   BackColor="#D1D7D8" Width="283px" Height="52px"><b>Email<span style="color:red;">(EML):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtEmail" runat="server" Width="245px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
            <td class="auto-style82"><p class="auto-style40">
        <asp:Label ID="Label16" runat="server"  BackColor="#D1D7D8" Width="160px" Height="53px"><b>Contact<span style="color:red;">(CON) :</span></b></asp:Label>
           
        <asp:TextBox  ID="txtContact" runat="server"  Width="142px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center" OnTextChanged="txtContact_TextChanged"></asp:TextBox></p>
       </td>
        </tr>
        </table>
        <br />

    <br />
    <br />
    <div>
 




        <table style="border: 3px solid darkblue;">
            
        <tr >
            <td style="border: 3px solid darkblue;">
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Width="180" BackColor="#ffff66" CssClass="auto-style5">

           <b>Past Medical History <br />
           <span style="color:red;">(PMH)</span> </b>
        </asp:Panel></td>
            <td style="border: 3px solid darkblue;">
                <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center" Width="219px" BackColor="#ffff66">
                <b>Family History <br />
                <span style="color:red;">(FH)</span> </b>
                </asp:Panel>
            </td>
             <td style="border: 3px solid darkblue;">
                <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" Width="190px" BackColor="#ffff66">
                <b>Social History <br />
           <span style="color:red;">(SH)</span> </b>
                </asp:Panel>
            </td>
             <td style="border: 3px solid darkblue;">
                <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center" Width="240px" BackColor="#ffff66" CssClass="auto-style5">
                <b>Allergies <br />
           <span style="color:red;">(ALL)</span> </b>
                </asp:Panel>
            </td>
             <td style="border: 3px solid darkblue;">
                <asp:Panel ID="Panel5" runat="server" HorizontalAlign="Center" Width="271px" BackColor="#ffff66">
                <b>Current Medications <br />
           <span style="color:red;">(CM)</span> </b>
                </asp:Panel>
            </td>
            <td style="border: 3px solid darkblue;" class="auto-style95">
                <asp:Panel ID="Panel6" runat="server" HorizontalAlign="Center" Width="218px" BackColor="#ffff66" CssClass="auto-style5">
                <b>Lab Reports <br />
           <span style="color:red;">(LR)</span> </b>
                </asp:Panel>
            </td>
          
              
         </tr>
        </table>
          
    </div>
        <table style="border: 3px solid darkblue;" class="auto-style96">
            <tr >
                <td style="border: 3px solid darkblue;">
                    <div class="auto-style97" align="center">
                        
                         <asp:CheckBoxList ID="CheckBoxList2" runat="server" CssClass="re" ></asp:CheckBoxList>
                                   
                                 
                          
                    </div>
                </td>
                <td style="border: 3px solid darkblue;">
                    <div class="auto-style98" align="center">
                      <asp:CheckBoxList ID="CheckBoxList3" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>
                </td>
                <td style="border: 3px solid darkblue;">
                    <div class="auto-style9" align="center">
                       <asp:CheckBoxList ID="CheckBoxList4" runat="server" CssClass="re" ></asp:CheckBoxList>  
                    </div>
                </td>
                <td style="border: 3px solid darkblue;">
                    <div class="auto-style8" align="center">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>
                </td>
                <td style="border: 3px solid darkblue;">
                    <div class="auto-style10" id="addControl" runat="server" align="center">

                    </div>
                </td>
                <td style="border: 3px solid darkblue;" class="auto-style99">
                    <div class="auto-style16">               
                        </div>
                        <div ID="addControlLab" runat="server" align="center" spellcheck="false" class="auto-style94" >
                    </div>
                </td>
               
            </tr>
        </table>
        <br />
        <table style="border: 3px solid darkblue;">
            <tr style="border: 3px solid darkblue;">
                <td style="border: 3px solid darkblue;" class="auto-style12">
                     <asp:Panel ID="Panel8" runat="server" HorizontalAlign="center" BackColor="#ffff66" Width="380px">
                <b>Presenting Illness<br />
           <span style="color:red;">(PI)</span> </b>
                </asp:Panel>
                </td>

                <td style="border: 3px solid darkblue;" class="auto-style12">
                     <asp:Panel ID="Panel9" runat="server" HorizontalAlign="center" BackColor="#ffff66" Width="380px">
                <b>Review of System<br />
           <span style="color:red;">(ROS)</span> </b>
                </asp:Panel>
                </td>

                <td style="border: 3px solid darkblue;">
                <asp:Panel ID="Panel10" runat="server" HorizontalAlign="Center" Width="180" BackColor="#ffff66">
                <b>Vaccination Status <br />
           <span style="color:red;">(VC)</span> </b>
                </asp:Panel>
            </td>
            </tr>
            <tr style="border: 3px solid darkblue;">
                <td style="border: 3px solid darkblue;" class="auto-style12">
                   <div class="auto-style60" align="center">
                         <asp:CheckBoxList ID="CheckBoxList5" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>                </td>

                 <td style="border: 3px solid darkblue;" class="auto-style12">
                   <div class="auto-style60" align="center">
                         <asp:CheckBoxList ID="CheckBoxList7" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>                </td>

                 <td style="border: 3px solid darkblue;" class="auto-style12">
                   <div class="leftdiv1" align="center">
                         <asp:CheckBoxList ID="CheckBoxList6" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>                </td>
           

                  </tr>
        </table>
 </asp:Content>
