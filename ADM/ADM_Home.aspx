<%@ Page Title="ADM PAGE" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="ADM_Home.aspx.vb" Inherits="ADM_Home" %>

<asp:Content ID="headMaster" ContentPlaceHolderID="head" runat="Server">

</asp:Content>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <div class="gridContainer">
        <div class="table-responsive">
            <asp:Label runat="server" ID="rola" Text="rola je: "></asp:Label>
            <asp:HyperLink runat="server" NavigateUrl="~/adm/registration.aspx" ID="gotoRegistration" Text="go to registration"></asp:HyperLink>
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
