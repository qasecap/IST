<%@ Page Language="VB" MasterPageFile="./MasterPageISTR3.master" AutoEventWireup="false"
    CodeFile="pregledUnetihSlogova.aspx.vb" Inherits="pregledUnetihSlogova" Title="PREGLED UNETIH SLOGOVA" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderInNestedMP" runat="Server">
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" EnablePageMethods="true" runat="server">
        </asp:ToolkitScriptManager>
    <div>
        <table width="95%" cellpadding="0" cellspacing="0">
            <tr>
                <td class="IST11R">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="IST11L">
                    <asp:Label ID="lblKonekcija" runat="server" Text="" Visible="False"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <br />
    <br />

    <table width="95%" cellpadding="0" cellspacing="0">
       
        <tr>
            <td class="IST11R">
                <asp:RegularExpressionValidator ID="REV_TK_GOD" runat="server" ForeColor="#000099"
                    Display="Dynamic" ControlToValidate="TK_GOD" Text="Minimalna dužina polja je 4!"
                    ValidationExpression="^.{4,}$"> </asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="RFV_TK_GOD" Display="Dynamic" runat="server" Text="*"
                    ControlToValidate="TK_GOD"> </asp:RequiredFieldValidator>
                <asp:Label ID="LBL_GOD" runat="server" Width="200px" Visible="True" Text="god" Style="text-align: right"
                    BorderColor="#FBFBFB" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True"></asp:Label>
                <asp:TextBox ID="TK_GOD" runat="server" Visible="True" BorderColor="#999999" BorderStyle="Solid"
                    BorderWidth="1px" Style="font-family: Verdana" Font-Size="11px" Width="100px"
                    MaxLength="4" TabIndex="1">
                </asp:TextBox>
                <asp:FilteredTextBoxExtender ID="ftbeTK_GOD" runat="server" TargetControlID="TK_GOD"
                    FilterType="Custom" FilterMode="InvalidChars" InvalidChars="/" />
            </td>
        </tr>
         <tr>          
            <td class="IST11R">
                    <asp:RegularExpressionValidator ID="REV_TK_MES" runat="server" ForeColor="#000099"
                        Display="Dynamic" ControlToValidate="TK_MES" Text="Minimalna dužina polja je 1!"
                        ValidationExpression="^.{1,}$"> </asp:RegularExpressionValidator>
                    <asp:RangeValidator ID="RV_TK_MES" runat="server" ForeColor="#006600" Display="Dynamic"
                        Text="Vrednost mora biti između 1 i 12!" MinimumValue="1" MaximumValue="12" Type="Integer"
                        ControlToValidate="TK_MES">
                    </asp:RangeValidator>
                    <asp:RequiredFieldValidator ID="RFV_TK_MES" Display="Dynamic" runat="server" Text="*"
                        ControlToValidate="TK_MES"> </asp:RequiredFieldValidator>
                    <asp:Label ID="LBL_MES" runat="server" Width="200px" Visible="True" Text="mes" Style="text-align: right"
                        BorderColor="#FBFBFB" BorderStyle="Solid" BorderWidth="1px" Font-Bold="True"></asp:Label>
                    <asp:TextBox ID="TK_MES" runat="server" Visible="True" BorderColor="#999999" BorderStyle="Solid"
                        BorderWidth="1px" Style="font-family: Verdana" Font-Size="11px" Width="100px"
                        MaxLength="2" TabIndex="2">
                    </asp:TextBox>
                    <asp:FilteredTextBoxExtender ID="ftbeTK_MES" runat="server" TargetControlID="TK_MES"
                        FilterType="Custom" FilterMode="InvalidChars" InvalidChars="/" />
                </td>
  </tr>


  
       
        <tr>
            <td class="IST11R">
                <asp:Image ID="linija" runat="server" ImageUrl="~/Images/greyline.jpg" />
            </td>
        </tr>
    </table>


                <br />
                <asp:Label ID="Label1" runat="server" Text="Преглед унетих слогова"></asp:Label>
                <br />


<table>
    <tr>
        <td class="IST13CB">
            <asp:Label ID="lblPODACI_SRM21" runat="server" Width="500px" Visible="True" Text=""
                Style="text-align: center" BorderColor="#FBFBFB" BorderStyle="Solid" BorderWidth="1px"></asp:Label>
        </td>
    </tr>
  <%--  <tr>
       <td class="IST11LB">
            <asp:CheckBox ID="chbSK" runat="server" AutoPostBack="True" />
            <asp:Label ID="Label1" runat="server" Text="Све колоне"></asp:Label>
        </td>
    </tr> --%>

    

    <tr>
        <td class="tabelaRedPoRed">
            <br />
            <asp:GridView ID="gvPODACI_SRM21" runat="server" AutoGenerateColumns="true" RowStyle-Wrap="false"
                AllowPaging="True" AllowSorting="false" PageSize="10" DataKeyNames="GOD,MES,SIF,KAPETA,REDBRJ"
                OnRowDataBound="OnRowDataBound" Width="85%">
                <PagerStyle CssClass="cssPager" />
                <RowStyle Wrap="False" />
                <Columns>
                    <asp:CommandField ShowSelectButton="true" SelectText="изабери" HeaderText="..." />
                    
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>









</asp:Content>


