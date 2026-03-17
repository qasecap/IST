Option Strict Off

Imports System
Imports System.Collections.Generic
Imports System.Data.OleDb
Imports System.Drawing
Imports System.Globalization
Imports System.Windows.Forms

Public Class FormQDParametersDialog

    ' ** Fields
    Private _dateStyle As DateTimeStyles

    Private _focus As Control
    Private _invariant As CultureInfo
    Private _numberStyle As NumberStyles

    ' ** ctors
    Public Sub New()
        Me._invariant = CultureInfo.InvariantCulture
        Me._dateStyle = (DateTimeStyles.AssumeLocal Or DateTimeStyles.AllowWhiteSpaces)
        Me._numberStyle = NumberStyles.Any
        Me.components = Nothing
        Me.InitializeComponent()
    End Sub

    Public Sub New(ByVal parms As List(Of OleDbParameter))
        Me.New()
        Dim height As Integer = Me._panel.Height
        Dim p As OleDbParameter
        For Each p In parms

            ' create label
            Dim lbl As New Label
            lbl.Text = FormQDParametersDialog.CleanupName(p.ParameterName)
            lbl.AutoSize = False
            lbl.Dock = DockStyle.Fill
            lbl.TextAlign = ContentAlignment.MiddleRight
            Me._panel.Controls.Add(lbl)
            Me._panel.SetRow(lbl, (Me._panel.RowCount - 1))

            ' create input control
            Dim ctl As Control = Me.GetControl(p)
            ctl.Tag = p
            ctl.AutoSize = False
            ctl.Dock = DockStyle.Fill
            Me._panel.Controls.Add(ctl)
            Me._panel.SetRow(ctl, (Me._panel.RowCount - 1))
            Me._panel.SetColumn(ctl, 1)
            If (Me._focus Is Nothing) Then
                Me._focus = ctl
            End If

            ' add another row to the panel
            Me._panel.RowCount += 1
            Dim style As New RowStyle(SizeType.AutoSize)
            Me._panel.RowStyles.Add(style)
        Next

        ' adjust form height
        MyBase.Height = (MyBase.Height + (Me._panel.Height - height))
    End Sub

    ' ** Event Handlers

    ' copy values in fields back to parameters
    Private Sub _btnOK_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim ctl As Control
        For Each ctl In Me._panel.Controls
            Dim p As OleDbParameter = TryCast(ctl.Tag, OleDbParameter)
            If (Not p Is Nothing) Then
                Dim chk As CheckBox = TryCast(ctl, CheckBox)
                If (Not chk Is Nothing) Then
                    p.Value = chk.Checked.ToString
                    Continue For
                End If
                Dim dtp As DateTimePicker = TryCast(ctl, DateTimePicker)
                If (Not dtp Is Nothing) Then
                    p.Value = dtp.Value.ToString(Me._invariant)
                    Continue For
                End If
                p.Value = ctl.Text
            End If
        Next
    End Sub

    ' ** Implementation

    ' clean up a name (remove brackets etc)
    Private Shared Function CleanupName(ByVal name As String) As String
        name = name.Replace("_"c, " "c)
        name = name.Trim
        Dim pos As Integer = name.LastIndexOf("!"c)
        If (pos > -1) Then
            name = name.Substring((pos + 1))
        End If
        If (((name.Length > 1) AndAlso (name.Chars(0) = "["c)) AndAlso (name.Chars((name.Length - 1)) = "]"c)) Then
            name = name.Substring(1, (name.Length - 2))
        End If
        Return name
    End Function

    ' creates a control of appropriate type for the parameter.
    ' note: parameter values are stored as invariant strings.
    Private Function GetControl(ByVal p As OleDbParameter) As Control
        Dim value As String = TryCast(p.Value, String)
        Dim type As Type = OleDbSchema.GetNetType(p.OleDbType)
        If OleDbSchema.IsNumeric(type) Then
            Dim num As New NumericUpDown
            num.Minimum = Decimal.MinValue
            num.Maximum = Decimal.MaxValue
            num.ThousandsSeparator = True
            Dim dec As Decimal = 0
            If Not String.IsNullOrEmpty(value) Then
                Decimal.TryParse(value, Me._numberStyle, Me._invariant, dec)
            End If
            num.Value = dec
            Return num
        End If
        If (type Is GetType(DateTime)) Then
            Dim dtp As New DateTimePicker
            dtp.Format = IIf((p.OleDbType = OleDbType.Filetime), DateTimePickerFormat.Time, DateTimePickerFormat.Short)
            Dim dt As DateTime = DateTime.Now
            If Not String.IsNullOrEmpty(value) Then
                DateTime.TryParse(value, Me._invariant, Me._dateStyle, dt)
            End If
            dtp.Value = dt
            Return dtp
        End If
        If (type Is GetType(Boolean)) Then
            Dim chk As New CheckBox
            Dim b As Boolean = False
            If Not String.IsNullOrEmpty(value) Then
                Boolean.TryParse(value, b)
            End If
            chk.Checked = b
            Return chk
        End If
        Dim tb As New TextBox
        tb.Text = value
        Return tb
    End Function

End Class