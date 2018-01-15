<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" MasterPageFile="~/MasterPage.master"%>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
    
        Login Page<table class="auto-style1">
            <tr>
                <td class="auto-style2">UserName:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4"><strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="auto-style5" ErrorMessage="Enter user name" ControlToValidate="TextBoxUserName"></asp:RequiredFieldValidator>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4"><strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="auto-style5" ErrorMessage="Enter password" ControlToValidate="TextBoxPassword"></asp:RequiredFieldValidator>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                </td>
                <td class="auto-style4">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/register.aspx">New User Register</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
            </tr>
        </table>
    
    </div>
    
</asp:Content>

