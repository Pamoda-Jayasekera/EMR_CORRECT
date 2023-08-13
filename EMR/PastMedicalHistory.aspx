<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PastMedicalHistory.aspx.cs" Inherits="EMR.PastMedicalHistory" %>
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
  background-color: green;
}
        .re input[type="checkbox"]:checked {
            background-color: red;
        }

        .auto-style1 {
            margin-right: 0;
        }
        .auto-style2 {
            width: 127px;
        }
        .auto-style4 {
            margin-left: 21px;
        }
        .auto-style6 {
            margin-left: 16;
        }
        .auto-style7 {
            width: 64px;
        }
        .auto-style8 {
            margin-left: 21px;
            width: 132px;
        }
        .auto-style9 {
            width: 132px;
        }
        .auto-style10 {
            margin-left: 21px;
            width: 107px;
        }
        </style>

    <body>
    <div class="centerblock">
            <h1 align="center"><b>Past Medical History</b></h1>
            <br />
             <div align="center">
      <asp:TextBox ID="txtHOM" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtHOM_TextChanged">    </asp:TextBox>               
            </div>
        <br />
            <table align="center">
               
                    <td class="auto-style8" >
<asp:Label runat="server" ><b>Diabates</b></asp:Label></td>
                    
                <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox1" runat="server"  />

                   </td>
                  <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date Since</b></asp:Label></td> 

                    <td class="auto-style2">
                        <asp:TextBox ID="txtDiabNotes" runat="server"  Width="100px" autocomplete="off" placeholder="Date Since" BorderWidth="0"></asp:TextBox>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                <td>
                                 <asp:Label ID="Label2" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                                <tr>
                                    
                    <td class="auto-style9" >
<asp:Label runat="server" ><b>Hypertension</b></asp:Label></td>
                    <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox3" runat="server" />

                   </td>
                    <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date Since</b></asp:Label></td> 
                                    

                   
                    <td class="auto-style2">
                        <asp:TextBox ID="txtHyperNotes" runat="server"  Width="100px" autocomplete="off" placeholder="Date Since" BorderWidth="0"></asp:TextBox>

                    </td>
                                    <td>
                        <asp:TextBox ID="TextBox3" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                                    <td>
                                 <asp:Label ID="Label3" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                            <tr>
                    <td class="auto-style9">
<asp:Label runat="server" ><b>MI</b></asp:Label></td>
                    <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox5" runat="server"  />

                   </td>
                   
                 
                      <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date</b></asp:Label></td>               

                   
                    <td class="auto-style2">
                        <asp:TextBox ID="txtMINotes" runat="server"  Width="100px" autocomplete="off" placeholder="Date" CssClass="auto-style6" BorderWidth="0"></asp:TextBox>

                    </td>
                                <td>
                        <asp:TextBox ID="TextBox4" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4"  BorderWidth="0"></asp:TextBox>
                    </td>
                                <td>
                                 <asp:Label ID="Label4" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                            <tr>
                    <td class="auto-style9">
<asp:Label runat="server" ><b>Stroke</b></asp:Label></td>
                    <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox7" runat="server" />

                   </td>
                   
                 <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date</b></asp:Label></td> 
                                    

                    
                    <td class="auto-style2">
                        <asp:TextBox ID="txtStrokeNotes" runat="server"  Width="100px" autocomplete="off" placeholder="Date" BorderWidth="0"></asp:TextBox>

                    </td>
                                <td>
                        <asp:TextBox ID="TextBox5" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0" ></asp:TextBox>
                    </td>
                                <td>
                                 <asp:Label ID="Label5" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                            <tr>
                    <td class="auto-style9">
<asp:Label runat="server" ><b>Hepatitis</b></asp:Label></td>
                   <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox9" runat="server"  />

                   </td>
                   
                 
                   <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date Since</b></asp:Label></td>                  

                                       
                    <td class="auto-style2" >
                        <asp:TextBox ID="txtHepaNotes" runat="server" Width="100px" autocomplete="off" placeholder="Date Since" BorderWidth="0"></asp:TextBox>

                    </td>
                                <td>
                        <asp:TextBox ID="TextBox6" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                                <td>
                                 <asp:Label ID="Label6" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                            <tr>
                    <td class="auto-style9">
<asp:Label runat="server" ><b>Kidney Stones</b></asp:Label></td>
                   <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox11" runat="server" />

                   </td>
                    
                <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date</b></asp:Label></td>  
                                    

                    
                    <td class="auto-style2">
                        <asp:TextBox ID="txtKidStoNotes" runat="server" Width="100px" autocomplete="off" placeholder="Date" BorderWidth="0"></asp:TextBox>

                    </td>
                                <td>
                        <asp:TextBox ID="TextBox7" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                                <td>
                                 <asp:Label ID="Label7" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                            <tr>
                    <td class="auto-style9" >
<asp:Label runat="server" ><b>Asthma-COPD</b></asp:Label></td>
                     <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox13" runat="server"  />

                   </td>
                   
                 
                            <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date Since</b></asp:Label></td>         

                   
                    <td class="auto-style2">
                        <asp:TextBox ID="txtAsthNotes" runat="server" Width="100px" autocomplete="off" placeholder="Date Since" BorderWidth="0"></asp:TextBox>

                    </td>
                                <td>
                        <asp:TextBox ID="TextBox8" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                                <td>
                                 <asp:Label ID="Label8" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                         <tr>
                    <td class="auto-style9">
<asp:Label runat="server"><b>Kidney Disease</b></asp:Label></td>
                    <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox15" runat="server"  />

                   </td>
                   
                 <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date</b></asp:Label></td> 
                                    

                    
                    <td class="auto-style2">
                        <asp:TextBox ID="txtKidDisNotes" runat="server" Width="100px" autocomplete="off" placeholder="Date" BorderWidth="0"></asp:TextBox>

                    </td>
                             <td>
                        <asp:TextBox ID="TextBox9" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                             <td>
                                 <asp:Label ID="Label9" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                         <tr>
                    <td class="auto-style9" >
<asp:Label runat="server"><b>Prostate Cancer</b></asp:Label></td>
                  <td class="auto-style7" >
                       <asp:CheckBox class="re" ID="CheckBox17" runat="server"  />

                   </td>
                              
<td class="auto-style10" >
             <asp:Label runat="server" ><b>Date</b></asp:Label></td> 
                    <td class="auto-style2">
                        <asp:TextBox ID="txtProsCanNotes" runat="server" Width="100px" autocomplete="off" placeholder="Date" BorderWidth="0"></asp:TextBox>

                    </td>
                             <td>
                        <asp:TextBox ID="TextBox10" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                             <td>
                                 <asp:Label ID="Label10" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                         <tr>
                    <td class="auto-style9">
<asp:Label runat="server" ><b>Urinary Cancer</b></asp:Label></td>
                    <td class="auto-style7" >
                       <asp:CheckBox class="re" ID="CheckBox19" runat="server"  />

                   </td><td class="auto-style10" >
             <asp:Label runat="server" ><b>Date</b></asp:Label></td> 
                                           <td class="auto-style2"> <asp:TextBox ID="txtUriNotes" runat="server" Width="100px" autocomplete="off" placeholder="Date" BorderWidth="0"></asp:TextBox></td>
                             <td>
                        <asp:TextBox ID="TextBox11" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                    <td>
                                 <asp:Label ID="Label11" runat="server" Text="yrs"></asp:Label>
                             </td>
                    
                   
                    </tr>
                         <tr>
                    <td class="auto-style9">
<asp:Label runat="server" ><b>Epilpsy</b></asp:Label></td>
                    <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox21" runat="server" />

                   </td>
                   
                                <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date Since</b></asp:Label></td>     

                    <td class="auto-style2">
                        <asp:TextBox ID="txtEpilNotes" runat="server" Width="100px" autocomplete="off" placeholder="Date Since" BorderWidth="0"></asp:TextBox>

                    </td>
                             <td>
                        <asp:TextBox ID="TextBox12" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                             <td>
                                 <asp:Label ID="Label12" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                         <tr>
                    <td class="auto-style9">
<asp:Label runat="server"><b>Cancer</b></asp:Label></td>
                  <td class="auto-style7">
                       <asp:CheckBox class="re" ID="CheckBox23" runat="server"  />

                   </td>
                   <td class="auto-style10" >
             <asp:Label runat="server" ><b>Date</b></asp:Label></td> 
                  
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCanNotes" runat="server" Width="100px" autocomplete="off" CssClass="auto-style1" placeholder="Date" BorderWidth="0"></asp:TextBox>

                    </td>
                             <td>
                        <asp:TextBox ID="TextBox13" runat="server"  Width="30px" autocomplete="off" CssClass="auto-style4" BorderWidth="0"></asp:TextBox>
                    </td>
                             <td>
                                 <asp:Label ID="Label1" runat="server" Text="yrs"></asp:Label>
                             </td>
                    </tr>
                       
   </table>
<br />
                      <div class="centerblock" align="center">
                      <asp:Button ID="btnSubmit" class="btn btn-success btn-lg"  runat="server" Text="SUBMIT" Width="137px" Height="51px" OnClick="btnSubmit_Click"></asp:Button>
                          <br />
                          <br />
                      <asp:Button ID="btnYear" runat="server" Text="Button"  Visible="false"  />

                          </div></body>
</asp:Content>
