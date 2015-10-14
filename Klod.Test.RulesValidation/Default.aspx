<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Klod.Test.RulesValidation._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
	<title>Untitled Page</title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<table>
			<!--customer size-->
		<tr><td>Customer Size:</td><td><asp:TextBox ID="CustomerSizeTextBox" runat="server"></asp:TextBox></td></tr>
		<tr><td>Age Range:</td><td><asp:DropDownList ID="AgeRangeList" runat="server">
					<asp:ListItem>Baby</asp:ListItem>
					<asp:ListItem>Junior</asp:ListItem>
					<asp:ListItem>Adult</asp:ListItem>
					<asp:ListItem>Senior</asp:ListItem>
					<asp:ListItem></asp:ListItem>
				</asp:DropDownList></td>
		</tr>
		<tr><td>Type:</td><td><asp:DropDownList ID="CustomerTypeList" runat="server">
					<asp:ListItem>Silver</asp:ListItem>
					<asp:ListItem>Gold</asp:ListItem>
					<asp:ListItem>Platinum</asp:ListItem>
				</asp:DropDownList></td>
		</tr>
		<tr><td>Price:</td><td><asp:TextBox ID="PriceTextBox" runat="server"></asp:TextBox></td></tr>
		<tr><td colspan="2">Discount:</td></tr>
		<tr><td>&nbsp;&nbsp;Max Value:</td><td><asp:TextBox ID="MaxValueTextBox" runat="server"></asp:TextBox></td></tr>
		<tr><td>&nbsp;&nbsp;Min Value:</td><td><asp:TextBox ID="MinValueTextBox" runat="server"></asp:TextBox></td></tr>
		<tr><td>VIP Discount:</td><td><asp:TextBox ID="VipDiscountTextBox" runat="server"></asp:TextBox></td></tr>
		 </table>
		<hr/>
			Senior more than five percent discount:<br />         
		<asp:Button ID="ValidateButton" runat="server" OnClick="ValidateButton_Click" Text="Rule 1" />
		<br /><br />
		<asp:Label ID="lblGold" runat="server" Text="Gold customer"></asp:Label>
		<br />
		<asp:Button ID="ValidateButton2" runat="server" OnClick="ValidateButton2_Click" Text="Rule 2" />
		<br /><br />
		<asp:Label ID="lblVip" runat="server" 
			Text="Vip discount: platinum customer &amp; 15-35 VIP discount"></asp:Label>
		<br />
		<asp:Button ID="ValidateButton3" runat="server" OnClick="ValidateButton3_Click" Text="Rule 3" />
		<br /><br />
		<asp:Label ID="lblSize" runat="server" Text="Size verification (S|M|L|XL)"></asp:Label>
		<br />
		<asp:Button ID="ValidateButton4" runat="server" OnClick="ValidateButton4_Click" Text="Rule 4" />
		<br />
		<br />
		</div>
	</form>
</body>
</html>
