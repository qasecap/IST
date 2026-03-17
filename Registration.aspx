<%@ Page Language="VB" AutoEventWireup="false" Async="true" MasterPageFile="MasterPage.master" CodeFile="Registration.aspx.vb" Inherits="Registration" %>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <!-- CONTENT_AREA -->
    <div class="content">
        <!-- LOGIN_FORM -->

        <div runat="server" id="RegistrationForm" class="col-md-8 col-lg-4" style="margin: auto; padding: 10px; float: none;">
            <div class="panel panel-body login-form " style="box-shadow: 2px 2px 5px lightgray; border: none; width: auto; margin: 0px;">
                <div class="text-center">
                    <div class="icon-object border-slate-300 text-danger-700"><i class="icon-newspaper"></i></div>
                    <h5 id="trnslt_Registracija" runat="server" class="content-group">Регистрација
                    </h5>
                    <small id="trnslt_logtext" runat="server" class="display-block text-slate">У поља испод унесите Ваше податке</small>
                </div>
                <div class="input-icons">
                    <i class="fa fa-light fa-building icon"></i>
                    <asp:TextBox type="text" ID="trnslt_ImeFirma" runat="server" CssClass="form-control" Style="width: 100%; padding-left: 35px; border-radius: 20px;" autocomplete="off" AutoPostBack="false" placeholder="Naziv firme" name="ioj"></asp:TextBox>
                    <div class="form-control-feedback">
                        <i class="icon-user text-slate-300"></i>
                    </div>
                    <span style="" class="" id="imeFirmaValid" runat="server"></span>
                </div>
                <div class="input-icons">
                    <i class="fa fa-light fa-address-card icon"></i>
                    <asp:TextBox type="text" ID="trnslt_mbr" runat="server" autocomplete="off" AutoPostBack="false" MaxLength="8" CssClass="form-control" Style="width: 100%; padding-left: 35px; border-radius: 20px;" placeholder="Матични број правног лица" name="mbr"></asp:TextBox>
                    <div class="form-control-feedback">
                        <i class="icon-profile text-slate-300"></i>
                    </div>
                    <span style="" class="" id="mbrValid" runat="server"></span>
                </div>
                <div class="input-icons">
                    <i class="fa fa-light fa-user icon"></i>
                    <asp:TextBox type="text" ID="trnslt_Ime" runat="server" autocomplete="off" AutoPostBack="false" CssClass="form-control" Style="width: 100%; padding-left: 35px; border-radius: 20px;" placeholder="Име" name="Име"></asp:TextBox>
                    <div class="form-control-feedback">
                        <i class="icon-user text-slate-300"></i>
                    </div>
                    <span style="" class="" id="ImeValid" runat="server"></span>
                </div>

                <div class="input-icons">
                    <i class="fa fa-light fa-user icon"></i>
                    <asp:TextBox type="text" ID="trnslt_Prezime" runat="server" autocomplete="off" AutoPostBack="false" CssClass="form-control" Style="width: 100%; padding-left: 35px; border-radius: 20px;" placeholder="Презиме" name="Prezime"></asp:TextBox>
                    <div class="form-control-feedback">
                        <i class="icon-user text-slate-300"></i>
                    </div>
                    <span style="" class="" id="PrezimeValid" runat="server"></span>
                </div>

                <div class="input-icons">
                    <i class="fa fa-light fa-envelope icon"></i>
                    <asp:TextBox type="text" ID="trnslt_Email" runat="server" autocomplete="off" AutoPostBack="false" CssClass="form-control" Style="width: 100%; padding-left: 35px; border-radius: 20px;" placeholder="Имејл" name="Email"></asp:TextBox>
                    <div class="form-control-feedback">
                        <i class="icon-envelop3 text-slate-300"></i>
                    </div>
                    <span style="" class="" id="EmailValid" runat="server"></span>
                </div>

                <div class="input-icons" style="clear: both">
                    <i class="fa fa-light fa-lock icon"></i>
                    <input type="password" id="trnslt_Lozinka" runat="server" autocomplete="off" class="form-control" style="width: 100%; padding-left: 35px; border-radius: 20px;" placeholder="Лозинка" name="Lozinka" />
                    <div class="form-control-feedback">
                        <i class="icon-lock2 text-slate-300"></i>
                    </div>
                    <span style="" class="" id="LozinkaValid" runat="server"></span>
                </div>

                <div class="input-icons">
                    <i class="fa fa-light fa-lock icon"></i>
                    <input type="password" id="trnslt_LozinkaPotvrda" autocomplete="off" runat="server" class="form-control" style="width: 100%; padding-left: 35px; border-radius: 20px;" placeholder="Потврди лозинку" name="LozinkaPotvrda" />
                    <div class="form-control-feedback">
                        <i class="icon-lock2 text-slate-300"></i>
                    </div>
                    <span style="" class="" id="LozinkaPotvrdaValid" runat="server"></span>
                </div>

                <div id="LogPoruke" runat="server" class="text-left pt-0 pb-10">
                    <span id="PorukaUspesno" runat="server" class="validation-success-label"></span>
                    <span id="PorukaNeuspesno" runat="server" class="validation-error-label"></span>
                </div>

                <div class="form-group">
                    <asp:Button ID="trnslt_RegisterButton" runat="server" CssClass="btn btn-xs bg-indigo btn-block text-size-mini" />
                </div>

                <asp:TextBox CssClass="hidden" ID="TBUIKID" runat="server"></asp:TextBox>
            </div>
        </div>

        <!-- /LOGIN_FORM -->
        <div class="content">
            <div runat="server" id="msgPanel" visible="false" class="col-md-4" style="margin: auto; padding: 10px; float: none;">
                <div class="panel panel-body login-form " style="box-shadow: 2px 2px 5px lightgray; border: none; width: auto; margin: 0px;">
                    <!-- INFO_ALERT -->
                    <div id="infoMsg" runat="server" class="alert alert-info alert-styled-left alert-arrow-left alert-component border-indigo text-indigo-800 pt-10 pb-10">
                        <h6 class="alert-heading text-size-base"></h6>
                    </div>
                    <!-- /INFO_ALERT -->
                </div>
            </div>
        </div>
    </div>
    <!-- /CONTENT_AREA -->

    <%--URL masking--%>
    <script type="text/javascript">
        history.pushState(null, null, 'default.aspx');
        window.addEventListener('popstate', function (event) {
            history.pushState(null, null, 'default.aspx');
        });
    </script>
</asp:Content>
