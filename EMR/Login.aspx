<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EMR.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

   <h3>Login Page </h3>
    <div class="con" style="margin-left: 255px">
      <div class="row">
         <div class="col-md-6 mx-auto" style="left: 136px; top: 7px; margin-top: 0px">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           
                            <img src="images/adminlogo.png" width="60px"/>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Login</h3>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <label>Usernname</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtUser" runat="server" placeholder="Username"></asp:TextBox>
                        </div>
                         <br />
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtPass" runat="server" placeholder="Password" TextMode="Password" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                        </div>
                          <br />
                      
                        
                        <%-- <label>Role</label> 
                      <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtRole" runat="server" placeholder="Role"  OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                       </div>
                          <br /> --%>

                         
                        
                        <div class="form-group">
                            <br />
                        </div>
                     </div>
                  </div>
               </div>
            </div>
           <br><br>
           <asp:Button class="btn btn-primary btn-block w-100" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" />
         </div>
      </div>
   </div>
    
</asp:Content>
