 <%@ Page Language="c#" AutoEventWireup="true" CodeFile="DynamicControls.aspx.cs" Inherits="DynamicControls"    MaintainScrollPositionOnPostback="true" %>


<%--<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderInNestedMP" Runat="Server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" EnablePageMethods="true" runat="server">
        </asp:ToolkitScriptManager>--%>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Dynamic Controls</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:button id="cmdAdd" style="Z-INDEX: 101; LEFT: 48px; POSITION: absolute; TOP: 48px" runat="server"
				Text="Add Button"></asp:button>
			<asp:textbox id="TextBox1" style="Z-INDEX: 102; LEFT: 128px; POSITION: absolute; TOP: 96px" runat="server"></asp:textbox><asp:button id="Button1" style="Z-INDEX: 103; LEFT: 48px; POSITION: absolute; TOP: 96px" runat="server"
				Text="Button 1"></asp:button><asp:label id="lblResult" style="Z-INDEX: 104; LEFT: 336px; POSITION: absolute; TOP: 40px"
				runat="server" Width="136px"></asp:label><asp:label id="lblText" style="Z-INDEX: 105; LEFT: 336px; POSITION: absolute; TOP: 72px" runat="server"
				Width="136px"></asp:label>
			<asp:Label id="Label1" style="Z-INDEX: 106; LEFT: 336px; POSITION: absolute; TOP: 112px" runat="server"
				Width="272px" Height="88px" Font-Size="Larger" ForeColor="Blue">Click "Add Button" to add controls.<br>
			Click buttons and type some text to check event handlers</asp:Label></form>
	</body>
</HTML>
	</asp:Content><%--  --%>