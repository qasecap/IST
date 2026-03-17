<%@ Page Title="Web questionnaire" ClientIDMode="Static" Language="VB" AutoEventWireup="true" MasterPageFile="MasterPage.master" CodeFile="MainTable.aspx.vb"
    Inherits="MainTable" MaintainScrollPositionOnPostback="false" %>

<asp:Content ID="headMaster" ContentPlaceHolderID="head" runat="Server">
    <link href="static/css/default.css" rel="stylesheet" type="text/css" />
    <script src="static/js/html2pdf.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="bodyMaster" ContentPlaceHolderID="bodyMainTable" runat="Server">
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>
    <p id="snackbar" name="snackbar" runat="server"></p>
    
    <asp:Label ID="DBConnectionString" Font-Size="Small" runat="server" Width="400px" ForeColor="#990000" Visible="False"></asp:Label>
    <asp:Label ID="ISTConnectionString" Font-Size="Small" runat="server" Width="400px" ForeColor="#990000" Visible="False"></asp:Label>
    <asp:Label ID="lblUser" runat="server" Font-Size="Small" Width="100px" ForeColor="#990000" Visible="False"></asp:Label>
    <asp:Label ID="lblDG" Font-Size="Small" runat="server" Width="1000px" Font-Bold="false" Visible="false"></asp:Label>
    <%--//mora inace ne radi enter--%>
    <%--<asp:Button ID="cmdPPP" runat="server" Text="." Width="12px"  BorderStyle="None" ForeColor="White"></asp:Button>--%>
    <%--//mora inace ne radi enter--%>

    <asp:Button ID="cmdPP" runat="server" Text="Prepiši" Width="100px" Visible="False"></asp:Button>

    <%--//mora --%>
    <asp:Label ID="lblInsertUpdate" Font-Size="Small" runat="server" Width="100px" Font-Bold="False" Visible="False"></asp:Label>

    <asp:Label ID="lblappcode" Font-Size="Small" runat="server" Width="400px" Visible="False"></asp:Label>
    <asp:Label ID="lblgg" Font-Size="Small" runat="server" Width="400px" Visible="False"></asp:Label>
    <asp:Label ID="lblmm" Font-Size="Small" runat="server" Width="400px" Visible="False"></asp:Label>

    <div id="mySidenav" class="sidenav-background sidenav big margin-top">
        <nav class="navigation" runat="server" id="sideNav">
            <asp:PlaceHolder ID="PlaceHolderNav" runat="server"></asp:PlaceHolder>
        </nav>
    </div>

    <div id="main" class="mainBig margin-top">
        <%--<div class="m-b-15">
            <asp:LinkButton ID="trnslt_backButton" CssClass="backBtn" runat="server" Text="< nazad"></asp:LinkButton>
        </div>--%>
       <div  style="display: flex; justify-content: center; align-items: center; height: 20px;">  <h4 ><u  id="trnslt_shapka1" text="" runat="server" >РАСМИЙ СТАТИСТИКАЛЫК ОТЧЕТТУУЛУК</u></h4></div>
       <div id="trnslt_shapka2" text="" runat="server" style="display: flex; justify-content: center; align-items: center; height: 15px;">  Кыргыз Республикасынын «Расмий статистика жөнүндө» Мыйзамына ылайык</div>
       <div id="trnslt_shapka3" text="" runat="server" style="display: flex; justify-content: center; align-items: center; height: 15px;">  Купуялуулугуна кепилдик  берилет</div>
       <div style="display: flex; justify-content: center; align-items: center; height: 15px;">  <h6  id="trnslt_shapka4" text="" runat="server">Маалыматтарды берүү тартибин, мөөнөтүн бузуу, аны бурмалап берү, купуялуулугун сактабагандыгы Кыргыз Республикасынын</h6> </div>
        
       <div style="display: flex; justify-content: center; align-items: center; height: 15px;"> <h6  text="" id="trnslt_shapka5" runat="server">мыйзамдарында бекитилген жоопкерчиликти тартууга алып келет</h6></div>

        <asp:Panel ID="PanelSave" runat="server"></asp:Panel>
        <asp:PlaceHolder ID="phGridView" runat="server"></asp:PlaceHolder>

        <asp:Panel ID="MyPanel" runat="server"></asp:Panel>
        <asp:Panel ID="PanelGrid" runat="server">
        </asp:Panel>
        <%--<div runat="server" id="draggable" style="position: absolute; top: 100px; left: 100px; width: 200px; padding: 10px; background-color: lightblue; border: 1px solid #ccc; cursor: move;">
            TEST!
        </div>--%>
    </div>

    <script type="text/javascript">

        //function generatePDF() {
        //    const combined = document.createElement('div');
        //    let panelIndex = 1;

        //    while (true) {
        //        const panel = document.getElementById("MyPanel" + panelIndex);
        //        if (!panel) break;

        //        const clone = panel.cloneNode(true);
        //        clone.style.display = 'block';
        //        combined.appendChild(clone);
        //        panelIndex++;
        //    }

        //    const opt = {
        //        margin: 0,
        //        filename: 'Upitnik.pdf',
        //        image: { type: 'jpeg', quality: 0.98 },
        //        html2canvas: { scale: 2, useCORS: true },
        //        jsPDF: { unit: 'in', format: 'a4', orientation: 'portrait' }
        //    };

        //    html2pdf().set(opt).from(combined).save();
        //}


        //document.addEventListener("DOMContentLoaded", function () {
        //    let index = 1;

        //    while (true) {
        //        const panel = document.getElementById("MyPanel" + index);
        //        if (!panel) break;

        //        panel.addEventListener("click", function () {
        //            generatePDF();
        //        });

        //        index++;
        //    }
        //});






        //function generatePDF() {
        //    const combined = document.createElement('div');
        //    let panelIndex = 1;

        //    while (true) {
        //        const panel = document.getElementById("MyPanel" + panelIndex);
        //        if (!panel) break;

        //        const clone = panel.cloneNode(true);
        //        clone.style.display = 'block';
        //        combined.appendChild(clone);
        //        panelIndex++;
        //    }

        //    const opt = {
        //        margin: 0,
        //        filename: 'Upitnik.pdf',
        //        image: { type: 'jpeg', quality: 0.98 },
        //        html2canvas: { scale: 2, useCORS: true },
        //        jsPDF: { unit: 'in', format: 'a4', orientation: 'portrait' }
        //    };

        //    html2pdf().set(opt).from(combined).save();
        //}

        function generatePDF() {
            const combined = document.createElement('div');
            let panelIndex = 1;

            // === 1. Dinamički pronađi naslov (bilo koji ID koji počinje sa LB_Title) ===
            const titleEl = [...document.querySelectorAll('[id^="LB_Title"]')].find(el => el.offsetParent !== null);
            if (titleEl) {
                const clone = titleEl.cloneNode(true);
                clone.style.display = 'block';
                clone.style.textAlign = 'center';
                clone.style.fontSize = '22px';
                clone.style.fontWeight = 'bold';
                clone.style.marginBottom = '20px';
                combined.appendChild(clone);
            }

            // === 2. Dodaj ime korisnika (Label Nalog) ===
            const user = document.getElementById("Nalog");
            if (user && user.innerText.trim() !== '') {
                const userInfo = document.createElement('div');
                userInfo.textContent = "Korisnik: " + user.innerText.trim();
                userInfo.style.fontSize = '14px';
                userInfo.style.marginBottom = '10px';
                combined.appendChild(userInfo);
            }

            // === 3. Dodaj napomenu ===
            const note = document.createElement('div');
            note.textContent = "Napomena: Ovaj dokument je generisan iz informacionog sistema Republičkog zavoda za statistiku.";
            note.style.fontSize = '12px';
            note.style.fontStyle = 'italic';
            note.style.marginBottom = '20px';
            combined.appendChild(note);

            // === 4. Dodaj prikazane greške (ako ih ima) ===
            ['lblResult', 'lblDG'].forEach(id => {
                const el = document.getElementById(id);
                if (el && el.offsetParent !== null) {
                    const clone = el.cloneNode(true);
                    clone.style.display = 'block';
                    clone.style.color = 'red';
                    clone.style.fontWeight = 'bold';
                    clone.style.marginBottom = '10px';
                    combined.appendChild(clone);
                }
            });

            // === 5. Dodaj sve panele bez page breakova ===
            while (true) {
                const panel = document.getElementById("MyPanel" + panelIndex);
                if (!panel) break;

                const wrapper = document.createElement('div');
                wrapper.style.position = 'relative';

                // Watermark slika
                const watermark = document.createElement('img');
                watermark.src = 'static/images/rzs.png';
                watermark.alt = 'Republički zavod za statistiku';
                watermark.style.position = 'absolute';
                watermark.style.top = '50%';
                watermark.style.left = '50%';
                watermark.style.transform = 'translate(-50%, -50%) rotate(-30deg)';
                watermark.style.opacity = '0.05';
                watermark.style.zIndex = '0';
                watermark.style.width = '70%';
                watermark.style.pointerEvents = 'none';
                wrapper.appendChild(watermark);

                // Klonirani panel
                const clone = panel.cloneNode(true);
                clone.style.display = 'block';
                clone.style.position = 'relative';
                clone.style.zIndex = '1';

                // Stilizacija tabele
                clone.querySelectorAll('table').forEach(table => {
                    table.style.overflow = 'visible';
                    table.style.width = '100%';
                    table.style.maxWidth = '100%';
                    table.style.tableLayout = 'fixed';
                    table.style.wordBreak = 'break-word';
                    table.style.fontSize = '11px';
                });

                // Stilizacija redova i ćelija
                clone.querySelectorAll('tr').forEach(tr => {
                    tr.style.pageBreakInside = 'avoid';
                    tr.style.breakInside = 'avoid';
                });

                clone.querySelectorAll('td, th').forEach(cell => {
                    cell.style.wordBreak = 'break-word';
                    cell.style.whiteSpace = 'normal';
                    cell.style.overflowWrap = 'break-word';
                    cell.style.padding = '4px';
                    cell.style.fontSize = '11px';
                    cell.style.pageBreakInside = 'avoid';
                    cell.style.breakInside = 'avoid';
                });



                wrapper.appendChild(clone);
                combined.appendChild(wrapper);

                panelIndex++;
            }

            // === 6. Generiši PDF ===
            const opt = {
                margin: 0.5,
                filename: 'Upitnik.pdf',
                image: { type: 'jpeg', quality: 0.98 },
                html2canvas: { scale: 2, useCORS: true },
                jsPDF: { unit: 'in', format: 'a4', orientation: 'portrait' }
            };

            html2pdf().set(opt).from(combined).save();
        }

        document.addEventListener('DOMContentLoaded', function () {
            var inputs = document.querySelectorAll('input');

            const buttons = document.querySelectorAll('.preventPostback a');
            buttons.forEach(button => {
                button.addEventListener('click', function (event) {
                    event.preventDefault(); // Prevents the postback
                    console.log("Download button clicked!"); // Your custom logic here
                });
            });

            inputs.forEach(function (input) {
                input.initialValue = input.value;

                input.addEventListener('keydown', function (event) {

                    if (event.key === 'Enter' || event.key === 'ArrowDown') {

                        // trick to always do textchanged
                        //input.value += ' '
                        if (input.value.endsWith('\u200B')) {
                            /*input.value = input.value.trim();*/
                            input.value = input.value.replace(/\u200B/g, '');
                        }
                        // Add a space to the end if it doesn't end with a space
                        else {
                            input.value += '\u200B';
                        }
                        navigateToNextInput(inputs, input, event);

                    } else if (event.key === 'ArrowUp') {
                        navigateToPreviousInput(inputs, input, event);
                    } else if (event.key === 'Tab') {
                        //event.preventDefault();
                    }
                });

            });
        });

        function navigateToNextInput(inputs, currentInput, event) {
            /* alert('AAAA');*/
            if (currentInput.hasAttribute('data-skip-js-navigation')) {
                if (currentInput.value !== currentInput.initialValue) {
                    return;
                }
            }
            event.preventDefault();
            var nextInput = getNextInput(inputs, currentInput);

            while (nextInput && nextInput.disabled) {
                nextInput = getNextInput(inputs, nextInput);
            }

            if (nextInput) {
                nextInput.focus();

            }
        }

        function navigateToPreviousInput(inputs, currentInput, event) {
            if (currentInput.hasAttribute('data-skip-js-navigation')) {
                if (currentInput.value !== currentInput.initialValue) {
                    return;
                }
            }
            event.preventDefault();
            var prevInput = getPreviousInput(inputs, currentInput);

            while (prevInput && prevInput.disabled) {
                prevInput = getPreviousInput(inputs, prevInput);
            }

            if (prevInput) {
                prevInput.focus();
            }
        }

        function getNextInput(inputs, currentInput) {
            for (var i = 0; i < inputs.length; i++) {
                if (inputs[i] === currentInput) {
                    return inputs[i + 1] || null;
                }
            }
            return null;
        }

        function getPreviousInput(inputs, currentInput) {
            for (var i = 0; i < inputs.length; i++) {
                if (inputs[i] === currentInput) {
                    return inputs[i - 1] || null;
                }
            }
            return null;
        }


    </script>

    <script type="text/javascript">
        // Add a dummy history entry
        history.pushState(null, null, location.href);

        // Listen for the popstate event
        window.onpopstate = function () {
            // Refresh the form or the page
            location.reload();
        };

        //NE TREBA ZA FORWARD SE NIKAD NE POJAVLJUJE JER STALNO ZOVEMO ISTU STRANU
        //let stateIndex = history.state ? history.state.index : 0;

        //// Update state index whenever you push a new state
        //history.pushState({ index: ++stateIndex }, '');

        //window.addEventListener('popstate', function (event) {
        //    if (event.state) {
        //        if (event.state.index > stateIndex) {
        //            // Detected forward navigation
        //            location.reload();
        //        }
        //        stateIndex = event.state.index;
        //    }
        //});  float: right;

    </script>

    <script type="text/javascript">
        function updateCheckedItems(checkbox, hiddenFieldId) {
            var spanElement = checkbox.parentNode;
            // Get the 'data-myvalue' attribute from the <span>
            var checkBoxValue = spanElement.getAttribute('data-myvalue');
            //alert(checkBoxValue);
            var hiddenField = document.getElementById(hiddenFieldId);
            var checkedValues = hiddenField.value ? hiddenField.value.split(',') : [];

            if (checkbox.checked) {
                checkedValues.push(checkBoxValue); // Add value to the array
            } else {
                var index = checkedValues.indexOf(checkBoxValue);
                if (index > -1) {
                    checkedValues.splice(index, 1); // Remove value from the array
                }
            }

            hiddenField.value = checkedValues.join(','); // Update the hidden field value
        }
    </script>

    <%--draggable--%>
    <script>
        // Get the draggable element
        const draggable = document.getElementById('draggable');

        // Track mouse events
        draggable.onmousedown = function (e) {
            let offsetX = e.clientX - draggable.offsetLeft;
            let offsetY = e.clientY - draggable.offsetTop;

            // Mousemove event to move the div
            document.onmousemove = function (e) {
                draggable.style.left = e.clientX - offsetX + 'px';
                draggable.style.top = e.clientY - offsetY + 'px';
            };

            // Stop moving the div when mouse is released
            document.onmouseup = function () {
                document.onmousemove = null;
                document.onmouseup = null;
            };
        };
    </script>

    <%--skrivanje fiktvnih polja koja sluze samo za racun--%>
    <script>
        document.querySelectorAll("td, th").forEach(function (cell) {
            const span = cell.querySelector("span");
            if (span) {
                const style = window.getComputedStyle(span);
                if (style.display === "none") {
                    cell.classList.add("td-hidden-child");
                }
            }
        });
    </script>

    <%--side menu go to top after scroll--%>
    <script>
        window.addEventListener('scroll', function () {
            const sideNav = document.querySelector('.sidenav');
            const scrollTop = window.scrollY;

            if (scrollTop > 70) {
                sideNav.classList.add('top');
                sideNav.style.position = 'fixed';
            } else {
                sideNav.classList.remove('top');
            }
        });
    </script>
</asp:Content>
