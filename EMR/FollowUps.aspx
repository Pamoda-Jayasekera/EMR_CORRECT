<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FollowUps.aspx.cs" Inherits="EMR.FollowUps" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
     <style>
         ::placeholder{
             text-align:center;
         }
          .space {
            float: left;
            width: 100%;
            height: 10px;
        }
         .space1 {
             float: left;
             width: 100%;
             height: 30px;
         }
           .tablediv {
            float: left;
            width: 100%;
            
        }
             .timediv {
            float: left;
            width: 100%;
            
        }
         </style>


   <div class="centerblock">
            <h1 align="center"><b>FollowUps</b></h1>
     </div>
    <div class="space"></div>
    <div align="center">
        <asp:TextBox ID="txtRBox" runat="server" AutoPostBack="true"  spellcheck="false" Width="800px" autocomplete="off" Height="70px" BorderColor="#CC0000" BorderWidth="4px" placeholder="HOM" OnTextChanged="txtRBox_TextChanged">    </asp:TextBox>                 
    </div>
    <br />
    <div class="timediv" align="center">
        <table border="2px">
            <tr align="left">
                <td height="20px" width="150px" >
                    <asp:Label ID="Label3" runat="server" Text="Label"><h4><b>Date:</b></h4></asp:Label></td>
                <td height="20px" width="150px" >
                    <asp:TextBox ID="txtDate" runat="server" BorderWidth="0" AutoComplete="off" SpellCheck="false" style="text-align: center"></asp:TextBox> </td>
            </tr>

        </table>
    </div>
    <div class="space1"></div>
    <div class="tablediv" align="center">
        <table border="2px">
            <tr align="left">
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"><h4>Patient Name</h4></asp:Label></td>
                <td>
                <asp:TextBox ID="TextBox1" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
            </tr>
             <tr align="left">
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Label"><h4>MRN</h4></asp:Label></td>
                <td>
               <asp:TextBox ID="TextBox2" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox> </td>
            </tr>
             <tr align="left">
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Label"><h4>Call for Appointment</h4></asp:Label></td>
                <td>
            <asp:TextBox ID="TextBox3" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox> </td>
            </tr>
             <tr align="left">
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Label"><h4>Follow-Up Date</h4></asp:Label></td>
                <td>
                     <asp:TextBox ID="TextBox4" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
            </tr>
             <tr align="left">
                <td>
                    <asp:Label ID="Label11" runat="server" Text="Label"><h4>Follow-Up Physician</h4></asp:Label></td>
                <td>
                     <asp:TextBox ID="TextBox5" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
            </tr>
             <tr align="left">
                <td>
                    <asp:Label ID="Label13" runat="server" Text="Label"><h4>Follow-Up with MA</h4></asp:Label></td>
                <td>
                     <asp:TextBox ID="TextBox6" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
            </tr>
             <tr align="left">
                <td>
                    <asp:Label ID="Label15" runat="server" Text="Label"><h4>Follow-Up with Specialist</h4></asp:Label></td>
                <td>
                     <asp:TextBox ID="TextBox7" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
            </tr>
             <tr align="left">
                <td>
                    <asp:Label ID="Label17" runat="server" Text="Label"><h4>Follow-Up with Physiotherapist</h4></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox8" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
            </tr>
             <tr align="left">
                <td>
                    <asp:Label ID="Label19" runat="server" Text="Label"><h4>Follow-Up with Dietician</h4></asp:Label></td>
                <td>
                     <asp:TextBox ID="TextBox9" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
            </tr>
             <tr align="left">
                <td>
                    <asp:Label ID="Label21" runat="server" Text="Label"><h4>Submit Lab Reports to</h4></asp:Label></td>
                <td>
                    <asp:TextBox ID="TextBox10" runat="server" BorderWidth="0" AutoComplete="off" Width="450px" SpellCheck="false"></asp:TextBox></td>
            </tr>

        </table>
    </div>
    <div class="space1"></div>
    <div align="center">
        <asp:Button ID="Button1" runat="server" Text="Submit" Width="137px" Height="51px" class="btn btn-success btn-lg" OnClick="Button1_Click"/>
    </div>
</asp:Content>
