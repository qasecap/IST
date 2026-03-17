<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeFile="Verification.aspx.vb" Inherits="Verification" %>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <!-- CONTENT_AREA -->
    <div class="content">
        <div runat="server" id="RegistrationForm" class="col-md-8 col-lg-4" style="margin: auto; padding: 10px; float: none;">
            <div class="panel panel-body login-form " style="box-shadow: 2px 2px 5px lightgray; border: none; width: auto; margin: 0px;">
                <!-- INFO_ALERT -->
                <div class="alert alert-info alert-styled-left alert-arrow-left alert-component border-indigo text-indigo-800 pt-10 pb-10">
                    <h4 class="alert-heading text-size-base" id="trnslt_uspesnaverifikacijatext" runat="server">Успешно сте верификовали Ваш налог...</h4>
                    <asp:HyperLink runat="server" NavigateUrl="~/default.aspx" id="trnslt_uspesnaverifikacijalink" Text="Вратите се на страну за логовање"></asp:HyperLink>
                    <h4 class="alert-heading text-size-base"></h4>
                </div>
                <!-- /INFO_ALERT -->
            </div>
        </div>
    </div>
    <!-- /CONTENT_AREA -->
</asp:Content>
