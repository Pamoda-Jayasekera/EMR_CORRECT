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

        .auto-style2 {
            height: 36px;
        }

        .auto-style3 {
            height: 20px;
        }

        .auto-style4 {
            height: 10px;
        }

        .auto-style5 {
            margin-left: 0px;
        }
        .auto-style6 {
            width: 1283px;
        }
        .auto-style7 {
            width: 1278px;
        }
    </style>
    <body onload=display_ct();>
     <div class="centerblock">
    <h2><b>MA DASHBOARD- VITALS</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<input type="text" id="t1" name="txtDate" style="width:356px;border:none" autocomplete="off"/>        </h2>  </div>
    <br />
    <table>
            <tr>
                <div align="center" >
            <asp:TextBox ID="txtRBMA" runat="server" AutoPostBack="true" OnTextChanged="txtRBMA_TextChanged" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE HERE/MRN/ADD/CLR/DEL/LOGOUT">    </asp:TextBox>                 
            </div>
                </tr>
                    
                </table>
     <br />
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
     <table class="data">
       <tr>
            <td class="auto-style3">
        <p >
         <asp:Label ID="Label2" runat="server" colspan="3" BackColor="#D1D7D8" Width="247px" Height="30px" > <b >Name<span style="color:red;">(PTN):</span></b></asp:Label>
        <asp:TextBox ID="txtPTN" runat="server" Width="245px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
        <td class="auto-style3"> <p>
        <asp:Label ID="Label1" runat="server" BackColor="#D1D7D8" Width="180px" Height="30px" ><b>AppointmentCode<span style="color:red;">(APC):</span></b></asp:Label>
         <asp:TextBox ID="txtApCode" runat="server" Width="180px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
       <td class="auto-style3">
           <p>
        <asp:Label ID="Label3" runat="server" BackColor="#D1D7D8" Width="180px" Height="30px" ><b>MRN<span style="color:red;">(MRN):</span></b></asp:Label>
       <asp:TextBox ID="txtMRN" runat="server" Width="180px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
        <td class="auto-style3"><p>
        <asp:Label ID="Label11" runat="server" BackColor="#D1D7D8" Width="104px" Height="30px"  ><b>Vital ID<span style="color:red;">(VID):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtVID" runat="server"  Width="104px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>   
           <td class="auto-style3">
                <p >
        <asp:Label ID="Label12" runat="server" BackColor="#D1D7D8" Width="119px" Height="30px" ><b>Age:</b></asp:Label>
          
        <asp:TextBox  ID="txtAge" runat="server" Width="119px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true"  Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
          <td class="auto-style3"><p >
        <asp:Label ID="Label13" runat="server" BackColor="#D1D7D8" Width="120px" Height="30px" ><b>District<span style="color:red;">(DIS):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtDistrict" runat="server"  Width="100" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        
        </td>
           <td class="auto-style3"><p >
        <asp:Label ID="Label14" runat="server" BackColor="#D1D7D8" Width="128px" Height="30px" ><b>Gender<span style="color:red;">(GEN):</span></b></asp:Label>
             
        <asp:TextBox  ID="txtGen" runat="server"  Width="100" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox> </p>
        </td>
             <td class="auto-style2"><p>
          
        <asp:Label ID="Label17" runat="server" BackColor="#D1D7D8" Width="123px" Height="30px" ><b>BMI<span style="color:red;">(BMI):</span></b></asp:Label>
        <asp:TextBox  ID="txtBMI" runat="server"  Width="110px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>  
       
                </tr><tr>
           <td><p  >
               <asp:Label ID="Label4" runat="server"  BackColor="#D1D7D8" Width="248px" Height="30px" ><b>BloodPressure<span style="color:red;">(BP):</span></b></asp:Label> 
        <asp:TextBox ID="txtBP" runat="server" Width="240px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
                    <td class="auto-style2"><p >
                <asp:Label ID="Label7" runat="server" BackColor="#D1D7D8" Width="180px" Height="30px"  ><b>Pulse<span style="color:red;">(PUL):</span></b></asp:Label> 
                <asp:TextBox ID="txtPulse" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
        </td>
           <td class="auto-style2"><p>
        <asp:Label ID="Label8" runat="server" BackColor="#D1D7D8" Width="180px" Height="30px" ><b>Temperature<span style="color:red;">(TEM):</span></b></asp:Label>
        <asp:TextBox ID="txtTemp" runat="server" Width="100px"  autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
                   
        </td>
         <td class="auto-style2"><p >
         <asp:Label ID="Label6" runat="server" BackColor="#D1D7D8" Width="104px" Height="30px"  ><b>Height<span style="color:red;">(HEI):</span></b></asp:Label>
          <asp:TextBox ID="txtHei" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
                    <td class="auto-style2">
                     <p  >
        <asp:Label ID="Label5" runat="server" BackColor="#D1D7D8" Width="119px" Height="30px" ><b>Weight<span style="color:red;">(WEI):</span></b></asp:Label>
        <asp:TextBox ID="txtWei" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>
                     <td class="auto-style2"><p>
            <asp:Label ID="Label9" runat="server"   BackColor="#D1D7D8" Width="120px" Height="30px"><b>PO2<span style="color:red;">(PO2):</span></b></asp:Label>
       <asp:TextBox ID="txtPO2" runat="server" Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
          <td class="auto-style2"><p>
          <asp:Label ID="Label18" runat="server"  BackColor="#D1D7D8" Width="128px" Height="30px" ><b>BloodGroup<span style="color:red;">(BGP):</span></b></asp:Label>
        <asp:TextBox  ID="txtBGP" runat="server"  Width="100px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox>
       </p>
        </td>
             <td class="auto-style3" colspan="2"><p>
        <asp:Label ID="Label21" runat="server"  BackColor="#D1D7D8" Width="123px" Height="30px" ><b>DOB<span style="color:red;">(DOB):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtDOB" runat="server" Width="108px" autocomplete="off" placeholder="yyyy/mm/dd" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>       
  
    
           </tr>
        <tr>
<td class="auto-style13"><p>
        <asp:Label ID="Label19" runat="server" BackColor="#D1D7D8" Width="247px" Height="30px"><b>Pharmacy Fax<span style="color:red;">(PFX):</span></b></asp:Label>

           
        <asp:TextBox  ID="txtPFX" runat="server"  Width="240px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td> 
             <td class="auto-style13" colspan="2"><p >
        <asp:Label ID="Label20" runat="server"  BackColor="#D1D7D8" Width="362px" Height="30px"><b>Primary Care Physician<span style="color:red;">(PCP):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtPCP" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
           </td>
            <td class="auto-style2" colspan="2"><p>
          
        <asp:Label ID="Label10" runat="server"  BackColor="#D1D7D8" Width="224px" Height="30px" ><b>Emergency Contact<span style="color:red;">(ECN):</span></b></asp:Label>
        <asp:TextBox  ID="txtECN" runat="server"  Width="110px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
        </td>
            
            <td class="auto-style3" colspan="2"><p>
        <asp:Label ID="Label15" runat="server"   BackColor="#D1D7D8" Width="249px" Height="30px"><b>Email<span style="color:red;">(EML):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtEmail" runat="server" Width="245px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
            <td class="auto-style3"><p>
        <asp:Label ID="Label16" runat="server"  BackColor="#D1D7D8" Width="123px" Height="30px"><b>Contact<span style="color:red;">(CON) :</span></b></asp:Label>
           
        <asp:TextBox  ID="txtContact" runat="server"  Width="120" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center"></asp:TextBox></p>
       </td>
        </tr>
        </table>
    <br />
    <br />
    <div>
        <table>
            
        <tr>
            <td>
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" Width="180" BackColor="#ffff66" CssClass="auto-style5">

           <b>Past Medical History <br />
           <span style="color:red;">(PMH)</span> </b>
        </asp:Panel></td>
            <td>
                <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center" Width="200" BackColor="#ffff66">
                <b>Family History <br />
                <span style="color:red;">(FH)</span> </b>
                </asp:Panel>
            </td>
             <td>
                <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" Width="180" BackColor="#ffff66">
                <b>Social History <br />
           <span style="color:red;">(SH)</span> </b>
                </asp:Panel>
            </td>
             <td>
                <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center" Width="180" BackColor="#ffff66">
                <b>Allergies <br />
           <span style="color:red;">(ALL)</span> </b>
                </asp:Panel>
            </td>
             <td>
                <asp:Panel ID="Panel5" runat="server" HorizontalAlign="Center" Width="340" BackColor="#ffff66">
                <b>Current Medications <br />
           <span style="color:red;">(CM)</span> </b>
                </asp:Panel>
            </td>
            <td>
                <asp:Panel ID="Panel6" runat="server" HorizontalAlign="Center" Width="100" BackColor="#ffff66">
                <b>Lab Reports <br />
           <span style="color:red;">(LR)</span> </b>
                </asp:Panel>
            </td>
            <td>
                <asp:Panel ID="Panel7" runat="server" HorizontalAlign="Center" Width="100" BackColor="#ffff66">
                <b>Images<br />
           <span style="color:red;">(IMG)</span> </b>
                </asp:Panel>
            </td>
         </tr>
        </table>
    </div>
        <table>
            <tr>
                <td>
                    <div class="leftdiv1" align="center">
                        
                         <asp:CheckBoxList ID="CheckBoxList2" runat="server" CssClass="re" ></asp:CheckBoxList>
                                   
                                 
                          
                    </div>
                </td>
                <td>
                    <div class="leftdiv2" align="center">
                      <asp:CheckBoxList ID="CheckBoxList3" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>
                </td>
                <td>
                    <div class="leftdiv1" align="center">
                       <asp:CheckBoxList ID="CheckBoxList4" runat="server" CssClass="re" ></asp:CheckBoxList>  
                    </div>
                </td>
                <td>
                    <div class="leftdiv1" align="center">
                        <asp:CheckBoxList ID="CheckBoxList1" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>
                </td>
                <td>
                    <div class="CM" id="addControl" runat="server" align="center">

                    </div>
                </td>
                <td>
                    <div class="leftdiv1n">               
                        <div width="105px" ID="addControlLab" runat="server" align="center" spellcheck="false" >
                    </div>
                </td>
                <td>
                      <div class="leftdiv1n">
                   <div width="100px" ID="addControlImg" runat="server" align="center" spellcheck="false" >

                    </div>
                </td>
            </tr>
        </table>
        <br />
        <table class="auto-style7">
            <tr>
                <td class="auto-style6">
                     <asp:Panel ID="Panel8" runat="server" HorizontalAlign="center" BackColor="#ffff66" Width="180px">
                <b>Presenting Illness<br />
           <span style="color:red;">(PI)</span> </b>
                </asp:Panel>
                </td>
            </tr>
            <tr><td class="auto-style6">
                   <div class="PI" align="center">
                         <asp:CheckBoxList ID="CheckBoxList5" runat="server" CssClass="re" ></asp:CheckBoxList>
                    </div>                </td>
            </tr>
        </table>
</asp:Content>
