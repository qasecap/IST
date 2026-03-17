<%@ Page Language="VB" AutoEventWireup="false" Async="true" MasterPageFile="MasterPage.master" CodeFile="ProvideEmail.aspx.vb" Inherits="ProvideEmail" %>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <!-- CONTENT_AREA -->
    <div class="content">
        <!-- CONTENT_AREA -->
        <div class="content">
            <!-- LOGIN_FORM -->
            <div runat="server" id="PotvrdaIdentitetaForm" class="col-md-8 col-lg-4" style="margin: auto; padding: 10px; float: none;">
                <div class="panel panel-body login-form " style="box-shadow: 2px 2px 5px lightgray; border: none; width: auto; margin: 0px;">

                    <div class="panel-body login-form">
                        <div class="text-center">
                            <div class="icon-object border-slate-300 text-danger-700"><i class="icon-newspaper"></i></div>
                            <h5 id="trnslt_PromenaIdentiteta" runat="server" class="content-group">Потврда идентитета</h5>
                            <small id="trnslt_potvrdaidentitetatext" runat="server" class="display-block text-slate">У поље испод унесите Ваш имејл помоћу кога сте се регистровали како би сте могли да промените лозинку</small>
                        </div>

                        <div class="form-group has-feedback has-feedback-left">
                            <input type="text" id="trnslt_user" runat="server" class="form-control input-xs" placeholder="Имејл" name="User" />
                            <div class="form-control-feedback">
                                <i class="icon-envelop3 text-slate-300"></i>
                            </div>
                            <span class="validation-warning-label" id="userValid" runat="server"></span>
                        </div>

                        <div class="form-group has-feedback has-feedback-left">
                            <input type="text" id="trnslt_okpo" runat="server" class="form-control input-xs" placeholder="Имејл" name="OKPO" />
                            <div class="form-control-feedback">
                                <i class="icon-envelop3 text-slate-300"></i>
                            </div>
                            <span class="validation-warning-label" id="OKPOValid" runat="server"></span>
                        </div>

                        <div id="LogPoruke" runat="server" class="text-left pt-0 pb-10" style="margin-bottom:15px;">
                            <span id="PorukaUspesno" runat="server" class="validation-success-label"></span>
                            <span id="PorukaNeuspesno" runat="server" class="validation-error-label"></span>
                        </div>
                        <div class="form-group">
                            <asp:Button ID="trnslt_ResetMeilButton" runat="server" CssClass="btn btn-xs bg-indigo btn-block text-size-mini" Text="ПОТВРДИ" />
                        </div>
                    </div>
                    <asp:TextBox CssClass="hidden" ID="TBUIKID" runat="server"></asp:TextBox>
                </div>
            </div>
            <!-- /LOGIN_FORM -->
        </div>
    </div>
    <!-- /CONTENT_AREA -->
    <div class="content">
        <div class="col-md-4" id="ProvideEmailForm" runat="server" visible="false" style="margin: auto; padding: 10px; float: none;">
            <!-- INFO_ALERT -->
            <div class="panel panel-body login-form" style="box-shadow: 2px 2px 5px lightgray; border: none; width: auto; margin: 0px;">
                <h6 id="InfoMsg" runat="server" class="alert-heading text-size-base"></h6>
            </div>
            <!-- /INFO_ALERT -->
        </div>
    </div>

    <%--URL masking--%>
    <script type="text/javascript">
        history.pushState(null, null, 'default.aspx');
        window.addEventListener('popstate', function (event) {
            history.pushState(null, null, 'default.aspx');
        });
    </script>
</asp:Content>
