<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FamilyHistory.aspx.cs" Inherits="EMR.FamHistory" %>
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
         ::placeholder{
             text-align:center;
         }

/* appearance for checked radiobutton */
.gr input[type="checkbox"]:checked{
  background-color:greenyellow;
}
        .re input[type="checkbox"]:checked {
            background-color: red;
        }
    </style>
        <div class="centerblock">
            <h1 align="center"><b>Family History</b></h1>
            <br />
            <div align="center">
     
                <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged">    </asp:TextBox>                  
            </div>
            <br />
            <table align="center">
                <tr>
                    <td class="auto-style4" style="width: 169px" ></td>
                    <td class="auto-style3"  style="width: 100px"><asp:Label ID="lb1" runat="server"><b>Yes</b> </asp:Label> </td>
                    <td class="auto-style3"  style="width: 100px"><asp:Label ID="Lb2" runat="server"><b>Father</b> </asp:Label></td>
                    <td class="auto-style3"  style="width: 100px"><asp:Label ID="Lb3" runat="server"><b>Mother</b> </asp:Label></td>
                    <td class="auto-style3"  style="width: 100px"><asp:Label ID="Label1" runat="server"><b>Sibling</b> </asp:Label></td>
                </tr>
                    <tr>
                    <td class="auto-style4" style="width: 169px" >
<asp:Label runat="server" ><b>Diabates</b></asp:Label></td>
                    
                <td >
                       <asp:CheckBox class="re" ID="CheckBox1" runat="server"/>

                   </td>
                     <td >
                       <asp:CheckBox class="re" ID="CheckBox2" runat="server"  />

                   </td>
                     <td >
                       <asp:CheckBox class="re" ID="CheckBox3" runat="server"/>

                   </td>
                     <td>
                       <asp:CheckBox class="re" ID="CheckBox4" runat="server"  />

                   </td>
                    
                    </tr>
                                <tr>
                    <td style="width: 163px" >
<asp:Label runat="server" ><b>Hypertension</b></asp:Label></td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox5" runat="server"/>

                   </td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox6" runat="server"/>

                   </td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox7" runat="server"/>

                   </td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox8" runat="server"/>

                   </td>

                    
                 
                                    

                    
                    </tr>
                            <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>MI</b></asp:Label></td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox9" runat="server"/>

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox10" runat="server"/>

                   </td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox11" runat="server"/>

                   </td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox12" runat="server"/>

                   </td>
                     
                    
                    
                    
                    
                    
                    </tr>
                            <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Stroke</b></asp:Label></td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox13" runat="server"/>

                   </td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox14" runat="server" />

                   </td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox15" runat="server"/>

                   </td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox16" runat="server"/>

                   </td>
                   
                 
                                    

                    
                    
                    </tr>
                            <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Hepatitis</b></asp:Label></td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox17" runat="server"/>

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox18" runat="server"/>

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox19" runat="server"/>

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox20" runat="server"/>

                   </td>
                   
                 
                                    

                      
                    </tr>
                            <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Kidney Stones</b></asp:Label></td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox21" runat="server" />

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox22" runat="server"/>

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox23" runat="server"/>

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox24" runat="server"/>

                   </td>
                    
                 
                                    

                    
                    </tr>
                            <tr>
                    <td style="width: 163px" >
<asp:Label runat="server" ><b>Lung Disease</b></asp:Label></td>
                     <td>
                       <asp:CheckBox class="re" ID="CheckBox25" runat="server" />

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox26" runat="server"/>

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox27" runat="server"/>

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox28" runat="server"/>

                   </td>
                    
                    </tr>
                         <tr>
                    <td style="width: 163px">
<asp:Label runat="server"><b>Kidney Disease</b></asp:Label></td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox29" runat="server"/>

                   </td>
                   <td>
                       <asp:CheckBox class="re" ID="CheckBox30" runat="server" />

                   </td>
                             <td>
                       <asp:CheckBox class="re" ID="CheckBox31" runat="server"/>

                   </td>
                    <td>
                       <asp:CheckBox class="re" ID="CheckBox32" runat="server"/>

                   </td>  </tr>
                         <tr>
                    <td style="width: 163px" >
<asp:Label runat="server"><b>Prostate Cancer</b></asp:Label></td>
                  <td >
                       <asp:CheckBox class="re" ID="CheckBox33" runat="server"/>

                   </td>
                   <td >
                       <asp:CheckBox class="re" ID="CheckBox34" runat="server"/>

                   </td>
                   <td >
                       <asp:CheckBox class="re" ID="CheckBox35" runat="server"/>

                   </td>
                   <td >
                       <asp:CheckBox class="re" ID="CheckBox36" runat="server"/>

                    </tr>
                         <tr>
                    <td style="width: 163px">
<asp:Label runat="server" ><b>Cancer</b></asp:Label></td>
                    <td >
                       <asp:CheckBox class="re" ID="CheckBox37" runat="server"/>

                   </td>
                   <td >
                       <asp:CheckBox class="re" ID="CheckBox38" runat="server"/>

                   </td>
                   <td >
                       <asp:CheckBox class="re" ID="CheckBox39" runat="server" />

                   </td>
                    <td >
                       <asp:CheckBox class="re" ID="CheckBox40" runat="server"/>

                   </td>
                    
                    </tr>
   </table>
<br />
                      <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="SUBMIT" Width="137px" Height="51px" OnClick="btnSubmit_Click"></asp:Button>
                     </div>
            <br />
            </body>
</asp:Content>

