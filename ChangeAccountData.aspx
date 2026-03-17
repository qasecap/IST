<%@ Page Language="VB" AutoEventWireup="false" Async="true" MasterPageFile="MasterPage.master" CodeFile="ChangeAccountData.aspx.vb" Inherits="ChangeAccountData" %>

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
     
    <br /><br /><br /><br />

    
    <div class="flex">
        <div style="height:670px" class="border-shadow">
            <div class="formContainer panel">
                

   


                <asp:FormView ID="fvUserDetails"  runat="server" DataKeyNames="APPUser" DefaultMode="Insert" display="flex" flex-direction="column" gap="30px"
    OnItemInserting="fvUserDetails_ItemInserting">
    <InsertItemTemplate>

         <asp:Label  ID="trnslt_dbregistrChange" CssClass="label11" runat="server"  Text="Данные из Бизнес регистр:"  Font-Bold="True" style="display: block; text-align: center;"/><br />

        <%--<asp:Label ID="trnslt_dbregistr2" CssClass="1form" runat="server" Text="ОКПО Код Предпиятий"  Font-Bold="True"/>
                <asp:TextBox ID="trnslt_dbregistr3" CssClass="form1" runat="server" Placeholder="Введите ОКПО  Предпиятий " Text='<%# Bind("APPUser") %>' />--%>

                <asp:Label ID="trnslt_INN_user21" CssClass="1form" runat="server" Text="ИНН:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_INN_user2" CssClass="form1" runat="server" Placeholder="ИНН" />

                <asp:Label ID="trnslt_LabelNameCompany21" CssClass="1form" runat="server" Text="Наименование организации:" style="font-size:14px"  Font-Bold="True"/>
                <asp:TextBox ID="trnslt_TextNameCompany2" CssClass="form1" runat="server" Placeholder="Введите название компании"  />

             <%--   <asp:Label ID="trnslt_K_NPU_ter121" CssClass="1form" runat="server" Text="КОД Территория организации:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_K_NPU_ter2" CssClass="form1" runat="server" Placeholder="КОД Территория организации" />--%>

                <asp:Label ID="trnslt_ADRESS_Company21" CssClass="1form" runat="server" Text="adsress:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_ADRESS_Company2" CssClass="form1" runat="server" Placeholder="adress"  />

                <asp:Label ID="trnslt_T_ON22" CssClass="1form" runat="server" Text="Phone:"   Font-Bold="True"/>
                <asp:TextBox ID="trnslt_T_ON2" CssClass="form1" runat="server" Placeholder="Phone"  />

                <asp:Label ID="trnslt_Email_company21" CssClass="1form" runat="server" Text="Email организации:" Font-Bold="True" />
                <asp:TextBox ID="trnslt_Email_company2" CssClass="form1" runat="server" Placeholder="Введите email" />

                <asp:Label ID="trnslt_FirstName_company21" CssClass="1form" runat="server" Text="Имя Фамилия Руководителя:" Font-Bold="True" />
                <asp:TextBox ID="trnslt_FirstName_company2" CssClass="form1" runat="server" Placeholder="Введите имя руководителя" />

              <%--  <asp:Label ID="trnslt_Oked_3_com21" CssClass="1form" runat="server" Text="Вид экономической деятелности:"  Font-Bold="True"/>
                <asp:TextBox ID="trnslt_Oked_3_com2" CssClass="form1" runat="server" Placeholder="Вид экономической деятелности" />--%>


       <%-- <asp:Label ID="trnslt_Oked_3_com21" CssClass="1form" runat="server" Text="Вид экономической деятельности:" Font-Bold="True" />
<asp:TextBox ID="trnslt_Oked_3_com2" CssClass="form1" runat="server" Placeholder="Введите вид экономической деятельности" AutoPostBack="true" OnTextChanged="trnslt_Oked_3_com2_TextChanged" />
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:DropDownList ID="ddlOked" CssClass="form-control" runat="server"></asp:DropDownList>
    </ContentTemplate>
</asp:UpdatePanel>--%>


       <%--<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <asp:TextBox ID="trnslt_Oked_3_com2" runat="server" AutoPostBack="true" OnTextChanged="Trnslt_Oked_3_com2_TextChanged" />
        <asp:DropDownList ID="ddlOked" runat="server"></asp:DropDownList>
    </ContentTemplate>
</asp:UpdatePanel>--%>



<%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:DropDownList ID="ddlOked" runat="server"></asp:DropDownList>
    </ContentTemplate>
</asp:UpdatePanel>--%>

        
       



        <asp:ScriptManager ID="ScriptManager1" runat="server" />

<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <asp:Label ID="trnslt_Oked_3_com21" CssClass="1form" runat="server" Text="Вид экономической деятельности:" Font-Bold="True" />
        <asp:TextBox ID="trnslt_Oked_3_com221" CssClass="form1" runat="server" AutoPostBack="True" OnTextChanged="txtSearch_TextChanged" placeholder="Введите для поиска..." onkeyup="triggerSearch();" />
        <asp:DropDownList ID="trnslt_Oked_3_com22" runat="server" CssClass="dropdown" style="display;">
            <asp:ListItem ID="trnslt_Oked_3_com2" class="values"  Text="Выберите вид деятельности" Value="" />
        </asp:DropDownList>
    </ContentTemplate>
</asp:UpdatePanel>


    


       

<style>
    .dropdown {
        display: block;
        width: 100%;
        max-height: 150px; /* Ограничение высоты списка */
        overflow-y: auto;  /* Скролл, если элементов много */
    }
      .autocomplete-container {
        position: relative;
        width: 300px;
    }

    .dropdown-results {
        position: absolute;
        top: 100%;
        left: 0;
        right: 0;
        border: 1px solid #ccc;
        background-color: #fff;
        max-height: 200px;
        overflow-y: auto;
        z-index: 1000;
    }

    .dropdown-results div {
        padding: 8px;
        cursor: pointer;
    }

    .dropdown-results div:hover {
        background-color: #f0f0f0;
    }
</style>






       <%-- <input type="text" id="trnslt_Oked_3_com2" placeholder="Вид экономической деятельности" class="form1" />
<div id="suggestions"></div>--%>
        <!-- Ваши элементы ввода данных -->
        <%--<asp:Label ID="LabelFirstYear" CssClass="1form" runat="server" Text="Год (Первый):" Font-Bold="True" />
        <asp:TextBox ID="txtFirstYear" CssClass="txtFirstYear" runat="server" Placeholder="Введите год" />

        <asp:Label ID="LabelKpred" CssClass="1form" runat="server" Text="ОКПО:" Font-Bold="True" />
        <asp:TextBox ID="txtKpred" CssClass="txtKpred" runat="server" Placeholder="Введите ОКПО"/>

        <asp:Label ID="LabelNameCompany" CssClass="1form" runat="server" Text="Наименование организации:" Font-Bold="True" />
        <asp:TextBox ID="txtNameCompany" runat="server" Placeholder="Введите название компании"/>

        <asp:Label ID="LabelFullName" CssClass="1form" runat="server" Text="Имя и фамилия:" Font-Bold="True" />
        <asp:TextBox ID="txtFullName" runat="server" Placeholder="Введите имя и фамилию" />--%>

        <asp:Label ID="trnslt_LabelTerritoryCode" CssClass="1form" runat="server" Text="Код территории:" Font-Bold="True" />
        <%--<asp:DropDownList ID="ddlTerritoryCode" runat="server" />--%>
        <%--<asp:DropDownList ID="ddlTerritoryCode" runat="server" AutoPostBack="True">
</asp:DropDownList>--%>
        <%--<asp:DropDownList CssClass="dropdown-content" ID="trnslt_ddlTerritoryCode" runat="server">
    <asp:ListItem Text="Выберите территорию" Value="" />
</asp:DropDownList>--%>


        <asp:DropDownList ID="trnslt_ddlRegion" runat="server" OnSelectedIndexChanged="trnslt_ddlRegion_SelectedIndexChanged" style="width:100%;margin:5px 0" AutoPostBack="True" CssClass="dropdown-content">
    <asp:ListItem   Text="Выберите область" Value="" />
</asp:DropDownList> <br />

        <asp:Label ID="trnslt_LabelTerritoryCode2" CssClass="1form" runat="server" Text="Код территории:" Font-Bold="True" />

<asp:DropDownList ID="trnslt_ddlDistrict" runat="server" OnSelectedIndexChanged="trnslt_ddlDistrict_SelectedIndexChanged" style="width:100%;margin:5px 0"  AutoPostBack="True" CssClass="dropdown-content">
    <asp:ListItem Text="Район" Value="" />
</asp:DropDownList><br />

        <asp:Label ID="trnslt_LabelTerritoryCode3" CssClass="1form" runat="server" Text="Код территории:" Font-Bold="True" />

<asp:DropDownList ID="trnslt_ddlSettlement" style="width:100%;margin:5px 0"  runat="server" CssClass="dropdown-content">
    <asp:ListItem Text="Населенный пункт" Value="" />
</asp:DropDownList><br />



         


            <%--<asp:Label ID="trnslt_lblMessage" Text="" runat="server"  CssClass="error-message" />--%>
        <%--<asp:Label ID="trnslt_lblMessage" Text="" runat="server" CssClass="error-message" Visible="False" />--%>
        <asp:Label ID="trnslt_lblMessage" Text="test3" runat="server" CssClass="error-message" Visible="false" />
        <asp:Label ID="trnslt_lblErrorMessage" runat="server" CssClass="error-message" ForeColor="Red" Visible="False"></asp:Label>



        <asp:Button ID="trnslt_btnSubmit" CssClass="save" runat="server" Text="Отправить" CommandName="Insert" OnClientClick="return validateForm()"  />
    </InsertItemTemplate>
</asp:FormView>



       

            </div>
        </div>
    </div>

    <%--<style>
        .dropdown-content {
    display: none;
    position: absolute;
    background-color: #f9f9f9;
    min-width: 160px;
    box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
    z-index: 1;
    top: 100%; /* Раскрытие вниз от кнопки */
    left: 0; /* Раскрытие по горизонтали от кнопки */
}
    </style>--%>
    
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


    

    
   

<script type="text/javascript">
    const god = document.querySelector('.txtFirstYear')
    const pred = document.querySelector('.txtKpred')
    const values = document.getElementsByClassName('dropdown')
    console.log(pred.value, 'пустой ')
    function validateForm() {

        //if (god.value.trim() === "") {
        //    alert("Пожалуйста, заполните поле 'Год'.");
        //    return false;
        //} 

        if (pred.value.trim() === "") {
            alert("Пожалуйста, заполните поле 'ОКПО'.");
            return false;
        }

        return true;
    }


    document.querySelector('#trnslt_Oked_3_com221').addEventListener('click', () => {
        values.style.display = 'block'
    })

   






</script>
</asp:Content>


