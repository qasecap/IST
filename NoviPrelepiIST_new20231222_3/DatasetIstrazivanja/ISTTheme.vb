Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Drawing

Public MustInherit Class ISTTheme
    Public Shared PanelParent As Color
    Public Shared ActivateButtons As Color
    Public Shared nizButtons As Color
    Public Shared UnosControls As Color
    '********
    'Private Shared ReadOnly PanelParentC As Color = Color.FromArgb(35, 94, 97) (43, 87, 154)
    Private Shared ReadOnly PanelParentLight As Color = Color.FromArgb(28, 110, 140)
    Private Shared ReadOnly nizButtonsLight As Color = Color.FromArgb(233, 151, 30)
    Private Shared ReadOnly ActivateButtonsLight As Color = Color.FromArgb(233, 151, 30)
    Private Shared ReadOnly UnosLight As Color = Color.FromArgb(28, 110, 140)
    '********
    Private Shared ReadOnly PanelParentDark As Color = Color.FromArgb(3, 10, 26)
    Private Shared ReadOnly nizButtonsDark As Color = Color.FromArgb(233, 151, 30)
    Private Shared ReadOnly ActivateButtonsDark As Color = Color.FromArgb(233, 151, 30)
    Private Shared ReadOnly UnosDark As Color = Color.FromArgb(3, 10, 26) 'bilo Color.SteelBlue
    '********
    Public Shared PanelPadre As Color
    Public Shared PanelBotones As Color
    Public Shared BarraTitulo As Color
    Public Shared TextBusqueda As Color
    Public Shared FuenteIconos As Color
    Private Shared ReadOnly PanelPadreA1 As Color = Color.FromArgb(66, 36, 52)
    Private Shared ReadOnly PanelBotonesA1 As Color = Color.FromArgb(122, 35, 56)
    Private Shared ReadOnly BarraTituloA1 As Color = Color.FromArgb(186, 54, 85)
    Private Shared ReadOnly UnosA1 As Color = Color.FromArgb(66, 36, 52)
    Private Shared ReadOnly FuenteIconosA1 As Color = Color.White

    Private Shared ReadOnly PanelPadreA2 As Color = Color.FromArgb(125, 79, 80)
    Private Shared ReadOnly PanelBotonesA2 As Color = Color.FromArgb(74, 101, 102)
    Private Shared ReadOnly BarraTituloA2 As Color = Color.FromArgb(115, 156, 158)
    Private Shared ReadOnly UnosA2 As Color = Color.FromArgb(125, 79, 80)
    Private Shared ReadOnly FuenteIconosA2 As Color = Color.White

    Private Shared ReadOnly PanelPadreA3 As Color = Color.FromArgb(0, 61, 58)
    Private Shared ReadOnly PanelBotonesA3 As Color = Color.FromArgb(94, 65, 97)
    Private Shared ReadOnly BarraTituloA3 As Color = Color.FromArgb(164, 64, 173)
    Private Shared ReadOnly UnosA3 As Color = Color.FromArgb(0, 61, 58)
    Private Shared ReadOnly FuenteIconosA3 As Color = Color.White

    Private Shared ReadOnly PanelPadreA4 As Color = Color.FromArgb(0, 102, 97)
    Private Shared ReadOnly PanelBotonesA4 As Color = Color.FromArgb(121, 173, 0)
    Private Shared ReadOnly BarraTituloA4 As Color = Color.FromArgb(157, 224, 0)
    Private Shared ReadOnly UnosA4 As Color = Color.FromArgb(0, 102, 97)
    Private Shared ReadOnly FuenteIconosA4 As Color = Color.White

    Private Shared ReadOnly PanelPadreA5 As Color = Color.FromArgb(17, 47, 51)
    Private Shared ReadOnly PanelBotonesA5 As Color = Color.FromArgb(33, 92, 99)
    Private Shared ReadOnly BarraTituloA5 As Color = Color.FromArgb(37, 115, 125)
    Private Shared ReadOnly UnosA5 As Color = Color.FromArgb(17, 47, 51)
    Private Shared ReadOnly FuenteIconosA5 As Color = Color.White

    Private Shared ReadOnly PanelPadreA6 As Color = Color.FromArgb(74, 78, 105)
    Private Shared ReadOnly PanelBotonesA6 As Color = Color.FromArgb(99, 68, 6)
    Private Shared ReadOnly BarraTituloA6 As Color = Color.FromArgb(125, 85, 4)
    Private Shared ReadOnly UnosA6 As Color = Color.FromArgb(74, 78, 105)
    Private Shared ReadOnly FuenteIconosA6 As Color = Color.White

    Private Shared ReadOnly PanelPadreA7 As Color = Color.FromArgb(8, 59, 114)
    Private Shared ReadOnly PanelBotonesA7 As Color = Color.FromArgb(30, 11, 99)
    Private Shared ReadOnly BarraTituloA7 As Color = Color.FromArgb(35, 10, 125)
    Private Shared ReadOnly UnosA7 As Color = Color.FromArgb(8, 59, 114)
    Private Shared ReadOnly FuenteIconosA7 As Color = Color.White




    Public Shared Sub ChosenTheme(ByVal theme As String)

        If theme.Trim.ToUpper = "LIGHT" Then
            PanelParent = PanelParentLight
            nizButtons = nizButtonsLight
            ActivateButtons = ActivateButtonsLight
            UnosControls = UnosLight
        End If

        If theme.Trim.ToUpper = "DARK" Then
            PanelParent = PanelParentDark
            nizButtons = nizButtonsDark
            ActivateButtons = ActivateButtonsDark
            UnosControls = UnosDark
        End If


        If theme.Trim.ToUpper = "A1" Then
            PanelParent = PanelPadreA1
            nizButtons = nizButtonsDark
            ActivateButtons = ActivateButtonsLight
            UnosControls = UnosA1

        End If

        If theme.Trim.ToUpper = "A2" Then
            PanelParent = PanelPadreA2
            nizButtons = nizButtonsDark
            ActivateButtons = ActivateButtonsLight
            UnosControls = UnosA2

        End If

        If theme.Trim.ToUpper = "A3" Then
            PanelParent = PanelPadreA3
            nizButtons = nizButtonsDark
            ActivateButtons = ActivateButtonsLight
            UnosControls = UnosA3

        End If

        If theme.Trim.ToUpper = "A4" Then
            PanelParent = PanelPadreA4
            nizButtons = nizButtonsDark
            ActivateButtons = ActivateButtonsLight
            UnosControls = UnosA4

        End If

        If theme.Trim.ToUpper = "A5" Then
            PanelParent = PanelPadreA5
            nizButtons = nizButtonsDark
            ActivateButtons = ActivateButtonsLight
            UnosControls = UnosA5

        End If

        If theme.Trim.ToUpper = "A6" Then
            PanelParent = PanelPadreA6
            nizButtons = nizButtonsDark
            ActivateButtons = ActivateButtonsLight
            UnosControls = UnosA6

        End If

        If theme.Trim.ToUpper = "A7" Then
            PanelParent = PanelPadreA7
            nizButtons = nizButtonsDark
            ActivateButtons = ActivateButtonsLight
            UnosControls = UnosA7

        End If


    End Sub



End Class

