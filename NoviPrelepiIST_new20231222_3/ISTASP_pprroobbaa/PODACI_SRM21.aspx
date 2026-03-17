<%@ Page Language="VB" AutoEventWireup="true" CodeFile="PODACI_SRM21.aspx.vb" Inherits="PODACI_SRM21"   MaintainScrollPositionOnPostback="true"  %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Dynamic Controls</title>
		<%--<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">--%>
		<%--<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">--%>
     
	</HEAD>
	<body  >
		<form id="Form1" method="post" runat="server">
             
			<asp:Label ID="DBConnectionString" style="Z-INDEX: 101; LEFT: 336px; POSITION: absolute; TOP: 24px" runat="server" Width="136px"  ForeColor="#990000"></asp:Label>
            <asp:Label ID="ISTConnectionString" style="Z-INDEX: 101; LEFT: 336px; POSITION: absolute; TOP: 48px" runat="server" Width="136px"  ForeColor="#990000"></asp:Label>
            <asp:Label ID="lblUser" style="Z-INDEX: 102; LEFT: 336px; POSITION: absolute; TOP: 72px" runat="server" Width="136px" ForeColor="#009933"></asp:Label>
			<asp:button id="cmdAdd" style="Z-INDEX: 103; LEFT: 48px; POSITION: absolute; TOP: 24px" runat="server" Text="Add Button" Width="136px"></asp:button>		
			<asp:label id="lblResult" style="Z-INDEX: 105; LEFT: 336px; POSITION: absolute; TOP: 96px" runat="server" Width="136px"></asp:label>
			<asp:label id="lblText" style="Z-INDEX: 106; LEFT: 336px; POSITION: absolute; TOP: 118px" runat="server" Width="136px"></asp:label>			
			<br />		
			<asp:label id="xxx" text="zzzz" style="Z-INDEX: 105; LEFT: 336px; POSITION: absolute; TOP: 144px" runat="server"	Width="136px"></asp:label>
         	<br />		
            <asp:Panel ID="Panel1" style="Z-INDEX: 108; LEFT: 48px; POSITION: absolute; TOP: 192px" runat="server"	Width="236px" BackColor="#FFFFCC"></asp:Panel>  

        </form>
	</body>
</HTML>
