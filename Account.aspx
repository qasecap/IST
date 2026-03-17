<%@ Page Language="VB" AutoEventWireup="false" Async="true" MasterPageFile="MasterPage.master" CodeFile="Account.aspx.vb" Inherits="Account" %>

<asp:Content ID="headMaster" ContentPlaceHolderID="head" runat="Server">

</asp:Content>
       

    <%--URL masking--%>
    
<asp:Content ID="bodyMaster" ContentPlaceHolderID="body" runat="Server">
    <div class="gridContainer">
        <div class="table-responsive">
            <%--AllowPaging="true" GridLines="None" PagerStyle-CssClass="paging"  PageSize="10" CssClass="myGridStyle" CssClass="table"--%>
           <%-- <asp:GridView ID="gvSurveys" runat="server" AutoGenerateColumns="False"
                AllowPaging="True" GridLines="None" PageSize="5" AllowSorting="True" CssClass="table" AlternatingRowStyle-BackColor="WhiteSmoke"
                EnableModelValidation="True" OnRowCommand="gvSurveys_RowCommand">
                <PagerStyle CssClass="pagination" />
                <RowStyle Wrap="False" />
                <Columns>
                    <asp:CommandField ShowSelectButton="true" SelectText="izaberi" HeaderText="..." />
                    <asp:BoundField DataField="sifist" HeaderText="Column 1" />
                    <asp:BoundField DataField="naziv" HeaderText="Column 2" />
                    <asp:BoundField DataField="keys" HeaderText="Column 3" />
                </Columns>
            </asp:GridView> --%>
            <asp:GridView ID="gvSurveys2"  AutoGenerateColumns="False"
                AllowPaging="True" GridLines="None" PageSize="5" AllowSorting="True" CssClass="table" AlternatingRowStyle-BackColor="WhiteSmoke"
                EnableModelValidation="True" OnRowCommand="gvSurveys_RowCommand">
                <PagerStyle CssClass="pagination" />
               <span></span>

                

            </asp:GridView>
        </div>
        </div>
     <%--<div class="gridContainer">
     <div class="table-responsive">
            <asp:GridView ID="gvSurveys2"   AutoGenerateColumns="False"
                AllowPaging="True" GridLines="None" PageSize="5" AllowSorting="True" CssClass="table" AlternatingRowStyle-BackColor="WhiteSmoke"
                EnableModelValidation="True" OnRowCommand="gvSurveys_RowCommand" OnSelectedIndexChanged="gvSurveys_SelectedIndexChanged">
                <PagerStyle CssClass="pagination" />
                <RowStyle Wrap="False" />
                <Columns>
                    <asp:CommandField ShowSelectButton="true" SelectText="Выбрать" />
                    <asp:BoundField DataField="NameCompany" HeaderText="Имя Компании" />
                    <asp:BoundField DataField="Email" HeaderText="email" />
                    <asp:BoundField DataField="Name" HeaderText="Имя" />                    
                    <asp:BoundField DataField="LastName" HeaderText="Имя Фамилия" />
                    <asp:BoundField DataField="Username" HeaderText="Логин" />
                </Columns>
            </asp:GridView>
        </div>
         </div>--%>
    <br /><br /><br /><br />

    <div class="flex">


    <div style="height:850px" class="border-shadow">

    <div style="display:flex,flex-direction:table-column,gap:30px" class="formContainer panel">
        <asp:FormView ID="fvUserDetails"   DataKeyNames="APPUser" DefaultMode="Edit" 
            OnItemUpdating="fvUserDetails_ItemUpdating">
            <EditItemTemplate class="edit">
                <asp:Label  ID="trnslt_dbregistr" CssClass="label11" runat="server" Text="Данные из Бизнес регистр:"  Font-Bold="True" style="display: block; text-align: center;"/><br />

                <asp:Label ID="trnslt_dbregistr2" CssClass="1form" runat="server" Text="ОКПО Код Предпиятий"  Font-Bold="True"/>
                <asp:TextBox ID="trnslt_dbregistr3" CssClass="form1" runat="server" Placeholder="Введите ОКПО  Предпиятий "   Text='<%# Bind("K_PRED") %>' />

                <asp:Label ID="trnslt_INN_user1" CssClass="1form" runat="server" Text="ИНН:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_INN_user" CssClass="form1" runat="server" Placeholder="ИНН"  Text='<%# Bind("NAME")  %>' />

                <asp:Label ID="trnslt_LabelNameCompany" CssClass="1form" runat="server" Text="Наименование организации:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_TextNameCompany" CssClass="form1" runat="server" Placeholder="Введите название компании"  Text='<%# Bind("NAME")  %>' />

                <asp:Label ID="trnslt_K_NPU_ter1" CssClass="1form" runat="server" Text="КОД Территория организации:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_K_NPU_ter" CssClass="form1" runat="server" Placeholder="КОД Территория организации"  Text='<%# Bind("NAME")  %>' />

                <asp:Label ID="trnslt_Name_oblast1" CssClass="1form" runat="server" Text="Область:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_Name_oblast" CssClass="form1" runat="server" Placeholder="Область"  Text='<%# Bind("NAME")  %>' />

                <asp:Label ID="trnslt_Name_raion1" CssClass="1form" runat="server" Text="Район:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_Name_raion" CssClass="form1" runat="server" Placeholder="Район"  Text='<%# Bind("NAME")  %>' />

                <asp:Label ID="trnslt_Name_punkt1" CssClass="1form" runat="server" Text="Населенный пункт:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_Name_punkt" CssClass="form1" runat="server" Placeholder="Населенный пункт"  Text='<%# Bind("NAME")  %>' />

                <asp:Label ID="trnslt_ADRESS_Company1" CssClass="1form" runat="server" Text="adsress:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_ADRESS_Company" CssClass="form1" runat="server" Placeholder="adress"  Text='<%# Bind("NAME")  %>' />

                <asp:Label ID="trnslt_T_ON2" CssClass="1form" runat="server" Text="Phone:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_T_ON" CssClass="form1" runat="server" Placeholder="Phone"  Text='<%# Bind("NAME")  %>' />

                <asp:Label ID="trnslt_Email_company1" CssClass="1form" runat="server" Text="Email организации:" Font-Bold="True" />
                <asp:TextBox ID="trnslt_Email_company" CssClass="form1" runat="server" Placeholder="Введите email" Text='<%# Bind("Email") %>' />

                <asp:Label ID="trnslt_FirstName_company1" CssClass="1form" runat="server" Text="Имя Фамилия Руководителя:" Font-Bold="True" />
                <asp:TextBox ID="trnslt_FirstName_company" CssClass="form1" runat="server" Placeholder="Введите имя руководителя" Text='<%# Bind("FIO") %>' />

                <asp:Label ID="trnslt_Oked_3_com1" CssClass="1form" runat="server" Text="Вид экономической деятелности:"  Font-Bold="True"/>
                <asp:TextBox ID="trnslt_Oked_3_com" CssClass="form1" runat="server" Placeholder="Вид экономической деятелности" Text='<%# Bind("FIO") %>' />

                <asp:Label ID="trnslt_Oked_3_kod1" CssClass="1form" runat="server" Text="Вид экономической деятелности:"  Font-Bold="True"/>
                <asp:TextBox ID="trnslt_Oked_3_kod" CssClass="form1" runat="server" Placeholder="Вид экономической деятелности" Text='<%# Bind("FIO") %>' />
                
                <asp:Label ID="trnslt_lblLastName" CssClass="1form" runat="server" Text="Фамилия Руководителя:"  Font-Bold="True"/>
                <asp:TextBox ID="txtLastName" CssClass="form1" runat="server" Placeholder="Введите фамилию руководителя" Text='<%# Bind("FIO") %>' />

                <asp:Label ID="trnslt_Label2" CssClass="1form" runat="server" Text="форма сопственности:"  Font-Bold="True"/>
                <asp:TextBox ID="TextBox1" CssClass="form1" runat="server" Placeholder="форма сопственности" Text='<%# Bind("FIO") %>' />

                

               <%--<asp:Button ID="btnUpdate" CssClass="save" runat="server" Text="Сохранить" CommandName="UpdateUserData" Font-Bold="True" />--%>
                <asp:Button ID="btnCancel" CssClass="save" runat="server" Text="отправить уведомление об изменение данных" CommandName="Cancel" Font-Bold="True" PostBackUrl="~/ChangeAccountData.aspx" />
                <%--<asp:LinkButton style=" background-color:#e2ecf8; CssClass="save" font-weight:bold " ID="LinkButton1" runat="server" Text="отправить уведомление об изменение данных" PostBackUrl="~/Surveys.aspx" />--%>
            </EditItemTemplate>
        </asp:FormView>
    </div>

    </div>
    </div>



    <style>
        .flex {
            display:flex;
            align-items:center;
            justify-content:center
        }
        .border-shadow {
            width:45%;
            height:400px;
           
                 margin-bottom: 20px;
        box-shadow: 2px 2px 5px lightgray;
   
    
    margin: 0px;

        }
        .label11 {
            position:absolute;
            top:252px;
            left:44%
        }
        .formContainer {
            width:60%;
            margin: 0 auto; /* Выравнивание по центру */
                margin-bottom: 20px;
        

        } 
        .edit {
                   margin-bottom: 20px;
        box-shadow: 2px 2px 5px lightgray;
   
    
    margin: 0px;
        }
        .lable1{
              position:absolute;
              left: 30%;
          }
        .form1 {
            height:30px;
            border-radius:2px;
            border:1px solid gray;
             padding: 0;
            line-height: 30px;
              padding-left:10px
           
          
        }
        .form1 label {
            margin-bottom: 5px;
   color: red;
   text-transform: uppercase;
   font-size: 12px;
   margin-left:10px;
 
        }
       
        .1form{
            color:#FAAB1B
        }
        .save {
            margin:5px 0;
            height:40px
        }
        .cont {
            background:#fff
        }
    </style>


    

    <div id="ModalLoader" class="modal-containerP" style="display: none;">
        <asp:Panel ID="PanelLoader" runat="server">
            <div class="loaderP" style="z-index: 1001;"></div>
        </asp:Panel>
        <section class="modalP">
        </section>
    </div>
</asp:Content>


