<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="signUp.aspx.cs" Inherits="HospitalManagementSys.signUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
    <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col">
                         <center>
                           <img width="100px" src="images/user_avatar.png"/>
                        </center>
                         </div>
                      </div>
                   <div class="row">
                     <div class="col">
                        <center>
                           <h4>Sign Up</h4>
                        </center>
                     </div>
                  </div>
                   <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
             <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label>First Name</label>
                        <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Last Name</label>
                        <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>
                    </div>
                </div>
             </div>
            <div class="row">         
                   <div class="col-md-6">
                        <div class="form-group">
                            <label>Age</label>
                            <asp:TextBox  CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                        </div>
                    </div>
            </div>
            <div class="row">    
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Gender</label>
                        <asp:TextBox  CssClass="form-control" ID="TextBox3" runat="server"></asp:TextBox>
                        <br />
                        <br />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Phone Number</label>
                        <asp:TextBox  CssClass="form-control" ID="TextBox14" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">      
                <div class="col-md-6">
                        <div class="form-group">
                            <label>Current Address</label>
                            <asp:TextBox CssClass="form-control" ID="TextBox15" runat="server"></asp:TextBox>
                        </div>
                </div>
                <div class="col-md-6">
                        <div class="form-group">
                            <label>Blood Type</label>
                            <asp:TextBox CssClass="form-control" ID="TextBox16" runat="server"></asp:TextBox>
                        </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Patient Email</label>
                        <asp:TextBox  CssClass="form-control" ID="TextBox17" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="form-group">
                        <label>Patient Password</label>
                        <asp:TextBox CssClass="form-control" ID="TextBox18" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                </div>
            </div>
                   <br />
            <div class="form-group">
                <center>
            <asp:Button class="btn btn-success btn-block btn-lg w-100" ID="Button2" runat="server" Text="Sign Up" OnClick="Button2_Click" />
                    </center>
            </div>
               </div>
            </div>
             <br />
         </div>
    </div>
    </div>
</asp:Content>
