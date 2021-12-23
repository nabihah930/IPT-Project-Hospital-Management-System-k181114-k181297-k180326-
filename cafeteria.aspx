<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cafeteria.aspx.cs" Inherits="HospitalManagementSys.cafeteria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center><h1>Welcome to the Cafeteria 🍱</h1></center>
    <div class="container-fluid">
    <div class="row">
         <div class="col-md-6 mx-auto">
            <div class="card">
               <div class="card-body">
                   <div class="row">
                            <div class="col">
                                <center><h3>Cafeteria Menu</h3></center>
                            </div>
                   </div>
                   <div class="row">
                            <div class="col">
                                    <hr>
                            </div>
                   </div>
                   <div class="row">    
                        <center>
                            <asp:GridView class="table table-striped table-bordered" HeaderStyle-BackColor="#FFA500" HeaderStyle-ForeColor="White"
                    RowStyle-BackColor="#FFA500" AlternatingRowStyle-BackColor="White" ItemStyle-Width="100px" ID="GridView1"  runat="server" Height="124px" Width="624px">                                        
                            </asp:GridView>     
                        </center>
                   </div>          
                   <div class="row">
                            <div class="col">
                                    <hr>
                            </div>
                   </div>
                   <center><h3>Place an Order </h3></center>
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                Biryani:<br />
                                Quantity:
                                <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" Text ="0"></asp:TextBox>
                                Subtotal:
                                <asp:Label ID="Label4" runat="server" Text="-"></asp:Label>
                            </div>
                         </div>
                         <div class="col-md-6">
                            <div class="form-group">
                                Cheese Cake:<br />
                                Quantity:
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" Text="0"></asp:TextBox>
                                Subtotal:
                                <asp:Label ID="Label5" runat="server" Text="-"></asp:Label>
                            </div>
                         </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                Daal Chawal:<br />
                                Quantity:<asp:TextBox CssClass="form-control" ID="TextBox4" runat="server"  Text="0"></asp:TextBox>
                                Subtotal:<asp:Label ID="Label6" runat="server" Text="-"></asp:Label>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                Ice Cream:<br />
                                Quantity: <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" Text="0"></asp:TextBox>
                                SubTotal: <asp:Label ID="Label7" runat="server" Text="-"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                Kheer:<br />
                                Quantity:<asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" Text="0"></asp:TextBox>
                                Subtotal:<asp:Label ID="Label18" runat="server" Text="-"></asp:Label>
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                Mexican Soup:<br />
                                Quantity: <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" Text="0"></asp:TextBox>
                                SubTotal: <asp:Label ID="Label9" runat="server" Text="-"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-6">
                            <div class="form-group">
                                Roti:<br />
                                Quantity:
                                <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" Text="0"></asp:TextBox>
                                SubTotal: <asp:Label ID="Label10" runat="server" Text="-"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <br />
                    <br />
                    Total Payment: <asp:Label ID="Label11" runat="server" Text="-"></asp:Label>
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;<asp:Button class="btn btn-primary btn-block btn-lg" ID="Button2" runat="server" Text="Place Order" OnClick="Button2_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                    <br />
                    <br />
                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button3" runat="server" Text="Confirm Order" OnClick="Button3_Click1" />
                    <br />
                    <br />
               </div>
            </div>
             <br />
             <br />
        </div>
     </div>
     </div>
    <asp:Label ID="Label12" runat="server" Text="-"></asp:Label>
</asp:Content>
