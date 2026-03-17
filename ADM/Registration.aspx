<%@ Page Title="ADM PAGE" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="Registration.aspx.vb" Inherits="ADM_Registration" %>

<asp:Content ID="headMaster" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <div class="gridContainer">
        <div class="table-responsive">
            <asp:Panel runat="server" ID="panelDistrictReg" Visible="false">
                <h3>Registracija district zaposlenih <span>admini</span></h3>
                <asp:Button ID="districtRegistration" runat="server" Text="Registracija zaposlenih" />
            </asp:Panel>
            <asp:Panel runat="server" ID="panelRespondentsReg" Visible="false">
                <h3>Registracija pravnih lica <span>admini i district zaposleni</span></h3>
                <asp:Button ID="respondentsRegistration" runat="server" Text="Registracija pravnih lica" />
            </asp:Panel>

            <p>district mogu da vide pravna lica filtrirana po teritoriji</p>
            <p>nakon automatske dodele usera(k_pred) i lozinke ide slanje na mail - aktivacija usera i dodela odgovarajucih istrazivanja</p>
        </div>

        <div class="table-responsive">
                <asp:GridView ID="gvDistrictReg" Visible="false" runat="server" AutoGenerateColumns="true">
        <Columns>
            <asp:CommandField ShowSelectButton="true" SelectText="EDIT" HeaderText="..." />
            <%--<asp:BoundField DataField="god" HeaderText="god" SortExpression="god" />
            <asp:BoundField DataField="PO" HeaderText="PO" SortExpression="PO" />
            <asp:BoundField DataField="PIG" HeaderText="PIG" SortExpression="PIG" />
            <asp:BoundField DataField="RBR" HeaderText="RBR" SortExpression="RBR" />--%>
        </Columns>
    </asp:GridView>

    <asp:GridView ID="gvRespondentReg" Visible="false" runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:CommandField ShowSelectButton="true" SelectText="EDIT" HeaderText="..." />
        <asp:BoundField DataField="god" HeaderText="god" SortExpression="god" />
        <asp:BoundField DataField="PO" HeaderText="PO" SortExpression="PO" />
        <asp:BoundField DataField="PIG" HeaderText="PIG" SortExpression="PIG" />
        <asp:BoundField DataField="RBR" HeaderText="RBR" SortExpression="RBR" />
    </Columns>
</asp:GridView>
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
