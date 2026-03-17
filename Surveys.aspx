<%@ Page Title="Web questionnaire" Language="VB" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeFile="Surveys.aspx.vb" Inherits="Surveys" %>

<asp:Content ID="headMaster" ContentPlaceHolderID="head" runat="Server">

</asp:Content>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <div class="gridContainer">
        <div class="table-responsive">
            <%--AllowPaging="true" GridLines="None" PagerStyle-CssClass="paging"  PageSize="10" CssClass="myGridStyle" CssClass="table"--%>
            <%--<p><strong id="trnslt_Listform" text=""  >Список форм</strong></p>--%>
            <h3><span id="trnslt_Listform" runat="server">National Statistical Committee of the Kyrgyz Republic</span></h3>
            <asp:GridView ID="gvSurveys" runat="server" AutoGenerateColumns="False"
                
                AllowPaging="True" GridLines="None" PageSize="100" AllowSorting="True" CssClass="table" 
                EnableModelValidation="True" OnRowCommand="gvSurveys_RowCommand">
                <%--AlternatingRowStyle-BackColor="WhiteSmoke"--%>
                <PagerStyle CssClass="bs-pagination" />
                <RowStyle Wrap="False" />
                <Columns>
                    <asp:CommandField ShowSelectButton="true" SelectText="izaberi" HeaderText="..." />
                    <asp:BoundField DataField="sifist" HeaderText="Column 1" />
                    <asp:BoundField DataField="naziv" HeaderText="Column 2" />
                    <asp:BoundField DataField="keys" HeaderText="Column 3" />
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
