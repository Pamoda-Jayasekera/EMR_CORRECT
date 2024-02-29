<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PatientRegistration.aspx.cs" Inherits="EMR.WebForm1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        ::placeholder{
             text-align:center;
         }
        centerblock{
            border-radius:5px 5px;
        }
        table.data{
            background:#A7C7E7;
        
           
        }
      
        .auto-style2 {
            width: 499px;
        }
        .auto-style4 {
            width: 498px;
        }
        .auto-style5 {
            width: 374px;
        }
        .auto-style6 {
            width: 363px;
        }
      
        .auto-style7 {
            width: 304px;
        }
      
    </style>

    <body>
         
     <div class="centerblock">
    <h2><b>PATIENT REGISTRATION</b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<input type="text" id="t1" name="txtDate" style="width:356px;border:none" autocomplete="off"/>        </h2>  </div>
    <br />
        <table>
            <tr >
              <div  class="centerblock" align="center" >
            <asp:TextBox ID="txtRBClerk" runat="server" AutoPostBack="true" OnTextChanged="txtRBClerk_TextChanged" spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="TYPE HERE/ADD/SER/CLR/DEL/LOGOUT">    </asp:TextBox>                 
            </div> 
                 </tr></table>
   
    <br />

   <table class="data" style="border-collapse: collapse; width: 100%; max-width: 900px; margin: 0 auto;">
    <tr>
        <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style6">
            <p style="margin: 0;">
                <asp:Label ID="Label3" runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Name<span style="color: red;">(PTN):</span></b></asp:Label>
                <asp:TextBox ID="txtName" runat="server" CssClass="disableCursor" Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="large" style="text-align: center; background-color: #A7C7E7;"></asp:TextBox>
            </p>
        </td>
        <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;" class="auto-style7">
                <asp:Label ID="Label1" runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block; margin-right: 10px;" Width="147px"><b>Medical Record Number<span style="color: red;">(MRN):</span></b></asp:Label>
                <asp:TextBox ID="txtMRN" runat="server" CssClass="disableCursor" Width="121px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="large" style="text-align: center; background-color:#A7C7E7;"></asp:TextBox>
            </p>
        </td>
       <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style4">
            <p style="margin: 0;">
                <asp:Label ID="Label2" runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>NIC<span style="color: red;">(NIC):</span></b></asp:Label>
                <asp:TextBox ID="txtNIC" runat="server" CssClass="disableCursor" Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="large" style="text-align: center; background-color: #A7C7E7;"></asp:TextBox>
            </p>
        </td>
           <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style5">
            <p style="margin: 0;">
               <asp:Label ID="Label12" runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>District<span style="color:red;">(DIS):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtDistrict" runat="server" CssClass="disableCursor" Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="large" style="text-align: center; background-color: #A7C7E7;"></asp:TextBox>
        
        </td>
          
            </tr>
            <tr>
          
           <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
        <asp:Label ID="Label5"  runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Contact<span style="color:red;">(CON) :</span></b></asp:Label>
           
        <asp:TextBox  ID="txtContact" runat="server" CssClass="disableCursor" Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="large" style="text-align: center; background-color: #A7C7E7;"></asp:TextBox>
            <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
        <asp:Label ID="Label6" runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Email<span style="color:red;">(EML):</span></b></asp:Label>
          
        <asp:TextBox CssClass="disableCursor"  ID="txtEmail" runat="server" Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
       </td>
                  <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
        <asp:Label ID="Label7"  runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Date Of Birth<span style="color:red;">(DOB):</span></b></asp:Label>
           
      <asp:TextBox ID="txtDOB" CssClass="disableCursor" runat="server" Width="200" autocomplete="off" placeholder="yyyy/mm/dd" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center;  background: #A7C7E7;"></asp:TextBox>
</p>
        </td>
                 <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
        <asp:Label ID="Label8"  runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Gender<span style="color:red;">(GEN):</span></b></asp:Label>
             
        <asp:TextBox  ID="txtGen" CssClass="disableCursor" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
        </td>
                </tr><tr>
          
           
        
   <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
        <asp:Label ID="Label9"  runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>BloodGroup<span style="color:red;">(BGP):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtBlGp" CssClass="disableCursor" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox>
       </td>
                     
        <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
          
        <asp:Label ID="Label10"  runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Occupation<span style="color:red;">(OCC):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtOccupation" CssClass="disableCursor" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
        </td>
           <td colspan="2" style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
        <asp:Label ID="Label4"  runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Address<span style="color:red;">(ADR):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtAddress" CssClass="disableCursor" runat="server"  Width="580px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
           </>
              
            </tr>
        <tr>
   <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
        <asp:Label ID="Label11"  runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Primary Care Physician<span style="color:red;">(PCP):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtPCP" CssClass="disableCursor" runat="server"  Width="310" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox>
       </td>
                     
         <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
          
        <asp:Label ID="Label13"  runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Emergency Contact<span style="color:red;">(ECN):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtECN" CssClass="disableCursor" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"> </asp:TextBox></p>
        </td>
           <td style="padding: 20px; border: 3px solid #ffffff; border-radius: 5px;" class="auto-style2">
            <p style="margin: 0;">
        <asp:Label ID="Label14"  runat="server" CssClass="disableCursor" style="background-color: #a7c7e7; padding: 5px; border-radius: 3px; display: inline-block;"><b>Pharmacy Fax No.<span style="color:red;">(PFX):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtPFX" CssClass="disableCursor" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
           </td>
              
            </tr>
        </table>
        
   </body>
    
</asp:Content>
