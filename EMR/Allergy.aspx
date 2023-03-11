<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Allergy.aspx.cs" Inherits="EMR.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >
    <style>
        input[type="checkbox"] {
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
        .gr input[type="checkbox"]:checked {
            background-color: green;
        }

        .re input[type="checkbox"]:checked {
            background-color: red;
        }

        .auto-style1 {
            width: 163px;
            height: 25px;
        }

        .auto-style2 {
            height: 25px;
        }
         ::placeholder{
             text-align:center;
         }
    </style>

    
    <div class="centerblock">
            <h1 align="center"><b>Allergies</b></h1>
            <br />
            <div class="centerblock" align="center">
        
                <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged">    </asp:TextBox>                 

        </div>
        <br />
            <table align="center">
                <tr>
                    <td class="auto-style4" style="width: 169px" >
<asp:Label runat="server" ><b>Penicillin</b></asp:Label></td>
                    
                <td >
                       
                                           
                    <asp:CheckBox ID="ChkPen" runat="server" class="re"/>
                   </td>
                   
                    </tr>
                                <tr>
                    <td style="width: 163px" >
<asp:Label runat="server" ><b>Betedine</b></asp:Label></td>
                    <td>
                        <asp:CheckBox ID="ChkBet" runat="server" class="re"/>
                       

                   </td>
                    
                    </tr>
                            <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Sulpha</b></asp:Label></td>
                    <td>
                       <asp:CheckBox  ID="ChkSul" runat="server" class="re"/>

                   </td>
                    
                    </tr>
                            <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Demerol</b></asp:Label></td>
                    <td>
                       <asp:CheckBox  ID="ChkDem" runat="server" class="re"/>

                   </td>
                   
                    </tr>
                            <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Morphine</b></asp:Label></td>
                   <td>
                       <asp:CheckBox class="re" ID="ChkMor" runat="server"/>

                   </td>
                    
                    </tr>
                            <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Latex</b></asp:Label></td>
                   <td>
                       <asp:CheckBox class="re" ID="ChkLat" runat="server"/>

                   </td>
                   
                    </tr>
                            <tr>
                    <td style="width: 163px" >
<asp:Label runat="server" ><b>Tetracycline</b></asp:Label></td>
                     <td>
                       <asp:CheckBox class="re" ID="ChkTet" runat="server"/>

                   </td>
                   
                    </tr>
                         <tr>
                    <td class="auto-style1">
<asp:Label runat="server"><b>Codeine</b></asp:Label></td>
                    <td class="auto-style2">
                       <asp:CheckBox class="re" ID="ChkCod" runat="server"/>

                   </td>
                    
                    </tr>
                         <tr>
                    <td style="width: 163px" >
<asp:Label runat="server"><b>Cipro</b></asp:Label></td>
                  <td >
                       <asp:CheckBox class="re" ID="ChkCip" runat="server"/>

                   </td>
                   
                    </tr>
                         <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Contrast Dye</b></asp:Label></td>
                    <td >
                       <asp:CheckBox class="re" ID="ChkCon" runat="server"/>

                   </td>
                    
                    </tr>
                         <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Food</b></asp:Label></td>
                    <td>
                       <asp:CheckBox class="re" ID="ChkFoo" runat="server"/>

                   </td>
                    
                    </tr>
                         <tr>
                    <td style="width: 163px">
<asp:Label runat="server"><b>Medicine</b></asp:Label></td>
                  <td>
                       <asp:CheckBox class="re" ID="ChkMed" runat="server"/>

                   </td>
                    
                    </tr>
                <tr>
                    <td style="width: 163px">
<asp:Label runat="server"><b>Other</b></asp:Label></td>
                  <td>
                      <asp:TextBox ID="txtOther" runat="server" Width="200px"></asp:TextBox>

                   </td>
                    
                    </tr>
                       
   </table>
<br />
                      <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="SUBMIT" Width="137px" Height="51px" OnClick="btnSubmit_Click"></asp:Button>
 
                     </div>
        <br />
                      <div class="centerblock" align="center">
                      <asp:Label ID="Label2" runat="server" Text="Label" ><a  href="javascript:history.back(-1);"><b>Go Back</b></a></asp:Label> 
 
                     </div>
        </div>
   
 
 
   

</asp:Content>
