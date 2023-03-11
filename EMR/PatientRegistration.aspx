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
            padding:0px 0px 0px 4px;
           
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

    <table >
            <tr>
                <div class="centerblock" align="center" >
                   
                        <asp:Button ID="btnAdd" class="btn btn-primary btn-lg" runat="server" Text="ADD" Width="90px" OnClick="Button1_Click"/>
                      
                 
                        <asp:Button class="btn btn-primary btn-lg" ID="btnClear" runat="server" Text="CLEAR" Width="90px" onClick="btnClear_Click" visibility="false"/>
                     
                        <asp:Button class="btn btn-primary btn-lg" ID="btnDelete" runat="server" Text="DELETE" Width="100px" OnClick="btnDelete_Click" visibility="false" />
                     <asp:Button class="btn btn-primary btn-lg" ID="btnLogOut" runat="server" Text="LOG OUT" Width="110px" OnClick="btnLogOut_Click" visibility="false"/>
                        <asp:Button class="btn btn-primary btn-lg" ID="btnSearch" Visible="false" runat="server" Text="SEARCH"  Width="100px" visibility="false"/>
                      
                   </div>
                </tr>
            </table>
    <br />
          
    <table  class="data" >
       <tr> 
            <td>
                <p style=" width: 310px">
        <asp:Label ID="Label3" runat="server" CssClass="disableCursor" style="background:#A7C7E7;"><b>Name<span style="color:red;">(PTN):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtName" runat="server" background-color="blue" CssClass="disableCursor" Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
       </td>
        <td>
        <p style="width:300px">
        <asp:Label ID="Label1" runat="server" CssClass="disableCursor" style="background:#A7C7E7; margin-right: 39px;" Width="132px" ><b>Medical Record Number<span style="color:red;">(MRN):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtMRN" runat="server" CssClass="disableCursor"  Width="121px"  autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
       </td>
       <td><p style="width: 300px">
        <asp:Label ID="Label2" runat="server"  CssClass="disableCursor" style="background:#A7C7E7;" Width="75"><b>NIC<span style="color:red;">(NIC):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtNIC" runat="server" CssClass="disableCursor" Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
       </td>
           <td><p style="width: 300px">
               <asp:Label ID="Label12" CssClass="disableCursor" style="background:#A7C7E7;" runat="server" ><b>District<span style="color:red;">(DIS):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtDistrict" CssClass="disableCursor"  runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
        
        </td>
          
            </tr>
            <tr>
          
           <td><p style="width: 310px">
        <asp:Label ID="Label5" CssClass="disableCursor" runat="server" style="background:#A7C7E7;" ><b>Contact<span style="color:red;">(CON) :</span></b></asp:Label>
           
        <asp:TextBox  ID="txtContact" CssClass="disableCursor" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
       </td>
           <td><p style="width: 300px">
        <asp:Label ID="Label6" CssClass="disableCursor" runat="server" style="background:#A7C7E7;"  ><b>Email<span style="color:red;">(EML):</span></b></asp:Label>
          
        <asp:TextBox CssClass="disableCursor"  ID="txtEmail" runat="server" Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
       </td>
                 <td><p style="width: 300px">
        <asp:Label ID="Label7" CssClass="disableCursor" style="background:#A7C7E7;" runat="server"  ><b>DOB<span style="color:red;">(DOB):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtDOB" CssClass="disableCursor" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
        </td>
                <td><p style="width: 300px">
        <asp:Label ID="Label8" CssClass="disableCursor" style="background:#A7C7E7;" runat="server"><b>Gender<span style="color:red;">(GEN):</span></b></asp:Label>
             
        <asp:TextBox  ID="txtGen" CssClass="disableCursor" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
        </td>
                </tr><tr>
          
           
        
  <td><p style="width: 300px">
        <asp:Label ID="Label9" CssClass="disableCursor" style="background:#A7C7E7;" runat="server"  Width="100"><b>BloodGroup<span style="color:red;">(BGP):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtBlGp" CssClass="disableCursor" runat="server"  Width="200" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox>
       </td>
                     
        <td><p style="width: 300px">
          
        <asp:Label ID="Label10" runat="server" CssClass="disableCursor" style="background:#A7C7E7;"  Width="75"><b>Occupation<span style="color:red;">(OCC):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtOccupation" CssClass="disableCursor" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
        </td>
           <td colspan="2"><p >
        <asp:Label ID="Label4" CssClass="disableCursor" runat="server" style="background:#A7C7E7;" Width="126px" ><b>Address<span style="color:red;">(ADR):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtAddress" CssClass="disableCursor" runat="server"  Width="580px" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
           </td>
              
            </tr>
        <tr>
  <td><p style="width: 300px">
        <asp:Label ID="Label11" CssClass="disableCursor" runat="server" style="background:#A7C7E7;"  Width="100"><b>Primary Care Physician<span style="color:red;">(PCP):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtPCP" CssClass="disableCursor" runat="server"  Width="310" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox>
       </td>
                     
        <td><p style="width: 300px">
          
        <asp:Label ID="Label13" CssClass="disableCursor" runat="server" style="background:#A7C7E7;" Width="75"><b>Emergency Contact<span style="color:red;">(ECN):</span></b></asp:Label>
           
        <asp:TextBox  ID="txtECN" CssClass="disableCursor" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"> </asp:TextBox></p>
        </td>
           <td ><p >
        <asp:Label ID="Label14" CssClass="disableCursor" runat="server" style="background:#A7C7E7;" Width="100" ><b>Pharmacy Fax No.<span style="color:red;">(PFX):</span></b></asp:Label>
          
        <asp:TextBox  ID="txtPFX" CssClass="disableCursor" runat="server"  Width="300" autocomplete="off" BorderWidth="0" ForeColor="#000066" Font-Bold="true" Font-Size="Large" style="text-align: center; background:#A7C7E7;"></asp:TextBox></p>
           </td>
              
            </tr>
        </table>
        
   </body>
    
</asp:Content>
