<%@ Page Title="Web questionnaire" Language="VB" MasterPageFile="MasterPage.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="headMaster" ContentPlaceHolderID="head" runat="Server">
</asp:Content>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <asp:UpdatePanel ID="UP_Login" runat="server">
        <ContentTemplate>
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
            </asp:ToolkitScriptManager>
            <div class="content">
                <div class="row">
                    <div class="col-md-12 text-center">
                        <h6 id="trnslt_welcomeMsg" runat="server" class="m-10 content-group text-semibold text-uppercase text-size-18"></h6>
                    </div>
                </div>

                <div class="login-wrapper">
                    <div class="form-group">
                        <h5 id="trnslt_Logovanje" runat="server" class="content-group"></h5>
                        <small id="trnslt_logtext" runat="server" class="display-block text-slate"></small>
                    </div>

                    <%--<form method="post">--%>
                    <input type="text" id="trnslt_Nalog" runat="server" class="login-input form-group" name="Nalog" />
                    <div class="input-wrap">
                        <input id="trnslt_Lozinka" name="Lozinka" type="password" runat="server" class="login-input has-eye" />
                        <button type="button"
                            class="eye-btn"
                            aria-label="Show password while pressed"
                            aria-pressed="false"
                            onpointerdown="peekPassword('<%= trnslt_Lozinka.ClientID %>', this, true)"
                            onpointerup="peekPassword('<%= trnslt_Lozinka.ClientID %>', this, false)"
                            onpointerleave="peekPassword('<%= trnslt_Lozinka.ClientID %>', this, false)"
                            onpointercancel="peekPassword('<%= trnslt_Lozinka.ClientID %>', this, false)"
                            onkeydown="if(event.code==='Space'||event.code==='Enter'){peekPassword('<%= trnslt_Lozinka.ClientID %>', this, true)}"
                            onkeyup="if(event.code==='Space'||event.code==='Enter'){peekPassword('<%= trnslt_Lozinka.ClientID %>', this, false)}">
                            <span class="login-icon">SHOW</span>
                        </button>
                    </div>
                    <div id="LogPoruke" runat="server" class="form-group">
                        <span id="PorukaUspesno" runat="server" class="validation-success-label"></span>
                        <div id="PorukaNeuspesno" runat="server" style="display: none; width: 60%; margin: 0 auto" class="alert alert-danger shadowBox" role="alert"></div>
                    </div>
                    <div class="login-actions">
                        <asp:Button ID="trnslt_LoginButton" runat="server" CssClass="btn-login" Text="ЛОГУЈТЕ СЕ" />
                        <asp:Button ID="trnslt_ForgotPassword" runat="server" CssClass="btn-reset" Text="ЛОГУЈТЕ СЕ" />
                    </div>
                    <asp:TextBox CssClass="hidden" ID="TBUIKID" runat="server"></asp:TextBox>
                    <%--</form>--%>
                </div>

                <div class="row">
                    <div class="col-md-4 col-md-push-4">
                        <div id="infoContainer" runat="server" class="">
                            <h6 id="infoMessage" runat="server" class="alert-heading text-size-base"></h6>
                        </div>
                    </div>
                </div>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
