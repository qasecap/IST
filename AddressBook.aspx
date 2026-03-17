<%@ Page Title="Web questionnaire" Language="VB" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeFile="AddressBook.aspx.vb" Inherits="AddressBook" %>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>

    <div class="gridContainer">
        <div class="m-b-15">
            <asp:LinkButton ID="trnslt_backButton" CssClass="backBtn" runat="server" Text="< nazad"></asp:LinkButton>
        </div>
        <asp:Label ID="DBConnectionString" Font-Size="Small" runat="server" Width="400px" ForeColor="#990000" Visible="False"></asp:Label>

        <span id="contGodina" runat="server" class="m-r-10" >
            <asp:Label ID="trnslt_godIstrazivanja" runat="server">GOD</asp:Label>
            <asp:DropDownList ID="DDLGOD" style="width:auto" runat="server" CssClass="dropdownlist" AutoPostBack="true">
            </asp:DropDownList>
        </span>

        <span class="m-r-10">
            <asp:Label ID="trnslt_tipIstrazivanja" runat="server" Text="Izaberite tip istraživanja"></asp:Label>
            <asp:DropDownList ID="DDLTIP" runat="server" AutoPostBack="true" style="width:auto" OnSelectedIndexChanged="DDLTIP_SelectedIndexChanged" CssClass="dropdownlist m-b-20"></asp:DropDownList>
        </span>

        <span id="contMesec" runat="server" visible="false" class="m-r-10">
            <asp:Label ID="trnslt_mesIstrazivanja" runat="server" Text="Izaberite mesec"></asp:Label>
            <asp:DropDownList ID="DDLMES" AutoPostBack="true" style="width:auto" runat="server" CssClass="dropdownlist"></asp:DropDownList>
        </span>

        <span id="contKvartal" runat="server" visible="false" class="m-r-10">
            <asp:Label ID="trnslt_kvaIstrazivanja" runat="server" Text="Izaberite kvartal"></asp:Label>
            <asp:DropDownList ID="DDLKVA" AutoPostBack="true" style="width:auto" runat="server" CssClass="dropdownlist">
                <asp:ListItem>--</asp:ListItem>
                <asp:ListItem>01</asp:ListItem>
                <asp:ListItem>02</asp:ListItem>
                <asp:ListItem>03</asp:ListItem>
                <asp:ListItem>04</asp:ListItem>
            </asp:DropDownList>
        </span>

        <div id="panelAdresar" runat="server" visible="false">
            <div class="table-responsive">
                <asp:GridView ID="gvCatalog" runat="server" AutoGenerateColumns="True" RowStyle-Wrap="false"
                    AllowPaging="True" AllowSorting="true" PageSize="25" CssClass="table" AlternatingRowStyle-BackColor="WhiteSmoke"
                    EnableModelValidation="True" OnRowCommand="gvAddressBook_RowCommand"> <%--gvAddressBook--%>
                    <PagerStyle CssClass="bs-pagination" />
                    <%--<RowStyle Wrap="False" />--%>
                    <Columns>
                        <asp:CommandField ShowSelectButton="true" SelectText="izaberi" HeaderText="..." />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

    <div id="ModalLoader" class="modal-containerP" style="display: none;">
        <asp:Panel ID="PanelLoader" runat="server">
            <div class="loaderP" style="z-index: 1001;"></div>
        </asp:Panel>
        <section class="modalP">
        </section>
    </div>

</asp:Content>
