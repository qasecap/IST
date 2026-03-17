<%@ Page Language="VB" AutoEventWireup="false" Async="True" MasterPageFile="MasterPage.master" CodeFile="PassRess.aspx.vb" Inherits="PassRess" %>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <div runat="server" id="PassRessForm" class="col-md-8 col-lg-4" style="margin: auto; padding: 10px; float: none;">
        <div class="panel panel-body login-form " style="box-shadow: 2px 2px 5px lightgray; border: none; width: auto; margin: 0px;">
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <asp:Timer ID="Timer1" runat="server"></asp:Timer>
            <div class="text-center">
                <div class="icon-object border-slate-300 text-danger-700"><i class="icon-newspaper"></i></div>
                <h5 id="trnslt_PromenaLozinke" runat="server" class="content-group">Промена Лозинке </h5>
                <small id="trnslt_PromenaLozinkeText" runat="server" class="display-block text-slate">У поља испод унесите нову лозинку и потврдите је</small>
            </div>

            <div class="form-group has-feedback has-feedback-left">
                <input type="text" id="trnslt_Nalog" runat="server" class="form-control input-xs" disabled="disabled" placeholder="Кориснички налог" name="Nalog" />
                <div class="form-control-feedback">
                    <i class="icon-user-lock text-slate-300"></i>
                </div>
                <span class="validation-warning-label" id="NalogValid" runat="server"></span>
            </div>
            <div class="form-group has-feedback has-feedback-left">
                <input type="password" id="trnslt_Lozinka" runat="server" class="form-control" placeholder="Лозинка" name="Lozinka" />
                <div class="form-control-feedback">
                    <i class="icon-lock2 text-slate-300"></i>
                </div>
                <span class="validation-warning-label" id="LozinkaValid" runat="server"></span>
            </div>
            <div class="form-group has-feedback has-feedback-left">
                <input type="password" id="trnslt_LozinkaPotvrda" runat="server" class="form-control" placeholder="Потврди лозинку" name="LozinkaPotvrda" />
                <div class="form-control-feedback">
                    <i class="icon-lock2 text-slate-300"></i>
                </div>
                <span class="validation-warning-label" id="LozinkaPotvrdaValid" runat="server"></span>
            </div>
            <div id="LogPoruke" runat="server" class="text-left pt-0 pb-10">
                <span id="PorukaUspesno" runat="server" class="validation-success-label"></span>
                <span id="PorukaNeuspesno" runat="server" class="validation-error-label"></span>
            </div>
            <div class="form-group">
                <%--<button id="PromeniLozinkuButton" runat="server" class="btn btn-xs bg-indigo btn-block text-size-mini">САЧУВАЈ <i class="icon-arrow-right5 position-right"></i></button>--%>
                <asp:Button ID="trnslt_PromeniLozinkuButton" runat="server" CssClass="btn btn-xs bg-indigo btn-block text-size-mini" Text="" />


            </div>
        </div>
    </div>
    <div class="content">
        <div runat="server" id="msgPanel"  class="col-md-4" style="margin: auto; padding: 10px; float: none;display:none;">
            <div class="panel panel-body login-form " style="box-shadow: 2px 2px 5px lightgray; border: none; width: auto; margin: 0px;">
                <!-- INFO_ALERT -->
                <div class="alert alert-info alert-styled-left alert-arrow-left alert-component border-indigo text-indigo-800 pt-10 pb-10">
                    <h4 class="alert-heading text-size-base" id="trnslt_uspesnokreiranjelozinke" runat="server"></h4>
                    <asp:HyperLink runat="server" NavigateUrl="~/default.aspx" ID="trnslt_uspesnaverifikacijalink" Text=""></asp:HyperLink>
                    <h4 class="alert-heading text-size-base"></h4>
                </div>
                <!-- /INFO_ALERT -->
            </div>
        </div>
    </div>
</asp:Content>
