<%@ Page Language="VB" MasterPageFile="./MasterPageISTR3.master" AutoEventWireup="false"
    CodeFile="IzborUpitnikaZaUnos.aspx.vb" Inherits="IzborUpitnikaZaUnos" Title="Izbor Upitnika Za Unos" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderInNestedMP" Runat="Server">
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
            <td class="IST13CB">
                <asp:Label ID="FP_imetab" runat="server" Width="500px" Visible="True" Text="KAPETANIJE"

                    Style="text-align: center" BorderColor="#FBFBFB" BorderStyle="Solid" BorderWidth="1px"></asp:Label>
            </td>
        </tr>
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

    <table>

<tr>
        <td class="IST11L">
        <br />
                <asp:Label ID="lblIzbor" runat="server" Text="Избор упитника за унос" Font-Bold="True"></asp:Label>&nbsp;&nbsp;
                <br />
                        <asp:Panel ID="PNLPretraga" runat="server" Width="109px" 
                            DefaultButton="lbtnPretraga" Visible="True">
                           <table class="style1" width="80%">
                                <tr>
                                    <td nowrap="nowrap">
                                        Претраживање по:&nbsp;
                                    </td>
                                    <td nowrap="nowrap">
                                        <asp:RadioButton ID="rbMbr" runat="server" GroupName="adresar" Text="Матичном броју" Checked="True" />
                                        <br />
                                        <asp:RadioButton ID="rbNaziv" runat="server" GroupName="adresar" Text="Пословном имену" /> 
                                    </td>
                                    <td nowrap="nowrap">
                                        &nbsp; <asp:TextBox ID="txtPretraga" runat="server" Width="500px"></asp:TextBox>
                                    </td>
                                    <td nowrap="nowrap">
                                        &nbsp;<asp:LinkButton ID="lbtnPretraga" runat="server">Претражи</asp:LinkButton>
                                        &nbsp;&nbsp;<asp:LinkButton ID="lbtnPonistavanjePretrage" runat="server">Поништи претрагу</asp:LinkButton>
                                    </td>
                                </tr>
                            </table>
                    </asp:Panel>
        </td>
    </tr>



        <tr>
            <td class="tabelaRedPoRed"> 
                <br />
                <asp:Label ID="Label1" runat="server" Text="Избор упитника за унос"></asp:Label>
                <br />
                <br />
                <asp:GridView ID="gvKAPETANIJE" runat="server" AutoGenerateColumns="true" RowStyle-Wrap="false"
                    AllowPaging="True" PageSize="100" AllowSorting="true" DataKeyNames="Kapetanija"
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


