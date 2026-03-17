<%@ Page Title="Web questionnaire" Language="VB" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeFile="PersonalAccount.aspx.vb" Inherits="PersonalAccount" %>

<asp:Content ID="headMaster" ContentPlaceHolderID="head" runat="Server">

</asp:Content>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <div class="gridContainer">
        <div class="table-responsive">
            <h3>spisak formi na koje imaju pravo</h3> 
            <h3>status popunjenih formi i info o predstojecim rokovima za predaju upitnika</h3>
            <h3>update podataka - slanje district levelu na unos???</h3>
            
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
