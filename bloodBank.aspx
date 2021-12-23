<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="bloodBank.aspx.cs" Inherits="HospitalManagementSys.bloodBank" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1>Donate Blood </h1></center>
    <div class="container-fluid">
    <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col-md">
                            <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        Donor ID:
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col">
                                    <div class="form-group">
                                        Blood Type:<asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md">
                                    <div class="form-group">
                                        Quantity:&nbsp; <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                            <br />
                              <asp:Button class="btn btn-success btn-block btn-lg w-100" ID="Button1" runat="server" Text="Donate" OnClick="Button1_Click" />
                            <br />
                      </div>
                   </div>
               </div>
            </div>
             <br />
             <br />
         </div>
    </div>
    </div>
</asp:Content>
