<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TestDisease.aspx.cs" Inherits="EMR.TestDisease" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <style>
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
  background-color: white;
  border-radius: 50%;
}

/* appearance for checked radiobutton */
.gr input[type="checkbox"]:checked{
  background-color: green;
}
.re input[type="checkbox"]:checked {
  background-color:red;
}

/* optional styles, I'm using this for centering radiobuttons */
       ::placeholder{
             text-align:center;
         }
         .auto-style1 {
             width: 169px;
             height: 40px;
         }
         .auto-style2 {
             width: 100px;
             height: 40px;
         }

         .auto-style3 {
             width: 100px;
         }
         .auto-style4 {
             width: 169px;
             height: 40px;
         }
         .auto-style5 {
             width: 169px;
             height: 40px;
         }
         .auto-style6 {
             width: 100px;
             height: 42px;
         }

          /* Checkbox style */
        input[type="checkbox"] {
            -webkit-appearance: none;
            -moz-appearance: none;
            appearance: none;
            display: inline-block;
            width: 25px;
            height: 25px;
            background-clip: content-box;
            border: 2px solid #bbbbbb;
            background-color: white;
            border-radius: 50%;
        }
        
        .green-checkbox input[type="checkbox"]:checked {
            background-color: green;
        }
    </style>
   
    <style>
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
  background-color: white;
  border-radius: 50%;
}

/* appearance for checked radiobutton */
.gr input[type="checkbox"]:checked{
  background-color: green;
}
.re input[type="checkbox"]:checked {
  background-color:red;
}

/* optional styles, I'm using this for centering radiobuttons */
       ::placeholder{
             text-align:center;
         }
         .auto-style1 {
             width: 169px;
             height: 40px;
         }
         .auto-style2 {
             width: 100px;
             height: 40px;
         }

         .auto-style3 {
             width: 100px;
         }
         .auto-style4 {
             width: 169px;
             height: 40px;
         }
         .auto-style5 {
             width: 169px;
             height: 40px;
         }
         .auto-style6 {
             width: 100px;
             height: 42px;
         }

    </style>
   
    <body>
    <div class="centerblock">
            <h1 align="center"><b>Test Assigned to Patients</b></h1>
            <br />
            <br /><div align="center">
                <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged">    </asp:TextBox>        </div>
            <table align="center">
                <tr>
                    <td class="auto-style1" >
<asp:Label runat="server" ><b>Blood Test</b></asp:Label></td>
                    
                <td class="auto-style2">
                       <asp:CheckBox class="gr" ID="BloodTesty" runat="server" Text=" Yes" />

                   </td>
                    <td class="auto-style2">
                        <asp:CheckBox ID="BloodTestn" class="re" runat="server" Text="No" />

                
                    </tr>
                 <tr>
                    <td class="auto-style5" >
<asp:Label runat="server" ><b>Urine Test</b></asp:Label></td>
                    
                <td class="auto-style6">
                       <asp:CheckBox class="gr" ID="UrineTesty" runat="server"  Text="Yes"   />

                   </td>
                    <td class="auto-style6">
                        <asp:CheckBox class="re" ID="UrineTestn" runat="server" GroupName="smo" Text="No" />

                
                    </tr>
                
                      <tr>
                    <td class="auto-style4" style="width: 169px" >
<asp:Label runat="server" ><b>Ultrasound</b></asp:Label></td>
                    
                <td class="auto-style3">
                       <asp:CheckBox class="gr" ID="Ultrasoundy" runat="server"  Text="Yes"   />

                   </td>
                    <td class="auto-style3"  style="width: 100px">
                        <asp:CheckBox  class="re" ID="Ultrasoundn" runat="server"  Text="No" />

                
                    </tr> 
                
                  <tr>
                    <td class="auto-style4" style="width: 169px" >
<asp:Label runat="server" ><b>CT Scan</b></asp:Label></td>
                    
                <td class="auto-style3">
                       <asp:CheckBox class="gr" ID="CTScany" runat="server"  Text="Yes"   />

                   </td>
                    <td class="auto-style3"  style="width: 100px">
                        <asp:CheckBox  class="re" ID="CTScann" runat="server"  Text="No" />

                
                    </tr> 

                  <tr>
                    <td class="auto-style4" style="width: 169px" >
<asp:Label runat="server" ><b>MRI</b></asp:Label></td>
                    
                <td class="auto-style3">
                       <asp:CheckBox class="gr" ID="MRIy" runat="server"  Text="Yes"   />

                   </td>
                    <td class="auto-style3"  style="width: 100px">
                        <asp:CheckBox  class="re" ID="MRIn" runat="server"  Text="No" />

                
                    </tr> 

                  <tr>
                    <td class="auto-style4" style="width: 169px" >
<asp:Label runat="server" ><b>ECG</b></asp:Label></td>
                    
                <td class="auto-style3">
                       <asp:CheckBox class="gr" ID="ECGy" runat="server"  Text="Yes"   />

                   </td>
                    <td class="auto-style3"  style="width: 100px">
                        <asp:CheckBox  class="re" ID="ECGn" runat="server"  Text="No" />

                
                    </tr> 
       
   </table>
        </div>
<br />
                      <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="SUBMIT" Width="137px" Height="51px" OnClick="btnSubmit_Click"></asp:Button>
                      </div>
           
    </body>
</asp:Content>

