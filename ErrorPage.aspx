<%@ Page Language="VB" AutoEventWireup="false" MasterPageFile="MasterPage.master" CodeFile="ErrorPage.aspx.vb" Inherits="ErrorPage" %>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <!-- CONTENT_AREA -->
    <div class="content">
        <div runat="server" id="ErrorForm" class="col-md-8 col-lg-4" style="margin: auto; padding: 10px; float: none;">
            <div class="panel panel-body login-form " style="box-shadow: 2px 2px 5px lightgray; border: none; width: auto; margin: 0px;">
                <div class="alert alert-info alert-styled-left alert-arrow-left alert-component border-indigo text-indigo-800 pt-10 pb-10">
                    <h2>Sorry, an error occurred while processing your request.</h2>
                    <asp:LinkButton runat="server" ID="backToDefault" Text="go back to login page"></asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
    <!-- /CONTENT_AREA -->
</asp:Content>

