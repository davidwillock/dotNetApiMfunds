<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" MasterPageFile="~/MasterPage.master"%>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <table class="auto-style1">
            <tr>
                <td class="auto-style2">User Name:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxUserName" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required User Name" ControlToValidate="TextBoxUserName"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">E-mail:   <td class="auto-style3">
                    <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="auto-style5" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required Email" ControlToValidate="TextBoxEmail"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter email address" ControlToValidate="TextBoxEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password: </td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxPassword" runat="server" Width="180px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required Password" ControlToValidate="TextBoxPassword"></asp:RequiredFieldValidator>
                    </td>
            </tr>
            <tr>
                <td class="auto-style2">Confirm Password:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxConfirmPassword" runat="server" CssClass="auto-style4" Width="180px" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required Confirm Password" ControlToValidate="TextBoxConfirmPassword"></asp:RequiredFieldValidator>
                    <strong>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword" CssClass="auto-style6" ErrorMessage="Both words must be the same"></asp:CompareValidator>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style2">Country:</td>
                <td class="auto-style3">
                    <asp:DropDownList ID="DropDownListCountry" runat="server" Width="180px">
                        <asp:ListItem>Select Country</asp:ListItem>
                        <asp:ListItem>Ireland</asp:ListItem>
                        <asp:ListItem>UK</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" CssClass="auto-style6" ErrorMessage="Required Country" ControlToValidate="DropDownListCountry"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click1" />
                    <input id="Reset1" type="reset" value="reset" /></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/login.aspx">Return to login page</asp:HyperLink>
                </td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
      
    </asp:Content>

