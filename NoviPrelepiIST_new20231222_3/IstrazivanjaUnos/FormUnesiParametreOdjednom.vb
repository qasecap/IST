Option Strict Off

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Windows.Forms.AxHost

Public Class FormUnesiParametreOdjednom

    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents LParametar As System.Windows.Forms.Label
    Friend WithEvents PanelTop As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents panelKontrole As Panel
    Friend WithEvents PanelFooter As Panel
    Friend WithEvents ButtonOK As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents b3 As Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUnesiParametreOdjednom))
        Me.LParametar = New System.Windows.Forms.Label()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.b3 = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelKontrole = New System.Windows.Forms.Panel()
        Me.PanelFooter = New System.Windows.Forms.Panel()
        Me.ButtonOK = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTop.SuspendLayout()
        Me.panelKontrole.SuspendLayout()
        Me.PanelFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'LParametar
        '
        Me.LParametar.AutoSize = True
        Me.LParametar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LParametar.Location = New System.Drawing.Point(8, 16)
        Me.LParametar.Name = "LParametar"
        Me.LParametar.Size = New System.Drawing.Size(0, 17)
        Me.LParametar.TabIndex = 9999
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.b3)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(794, 40)
        Me.PanelTop.TabIndex = 10000010
        '
        'b3
        '
        Me.b3.BackColor = System.Drawing.Color.Transparent
        Me.b3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b3.FlatAppearance.BorderSize = 0
        Me.b3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.b3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.ForeColor = System.Drawing.Color.DarkOrange
        Me.b3.Location = New System.Drawing.Point(10, 4)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(240, 32)
        Me.b3.TabIndex = 183
        Me.b3.TabStop = False
        Me.b3.Text = "."
        Me.b3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.b3.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(754, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'panelKontrole
        '
        Me.panelKontrole.AutoScroll = True
        Me.panelKontrole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelKontrole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelKontrole.Controls.Add(Me.PanelFooter)
        Me.panelKontrole.Location = New System.Drawing.Point(0, 41)
        Me.panelKontrole.Name = "panelKontrole"
        Me.panelKontrole.Size = New System.Drawing.Size(407, 29)
        Me.panelKontrole.TabIndex = 10000007
        '
        'PanelFooter
        '
        Me.PanelFooter.AutoScroll = True
        Me.PanelFooter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PanelFooter.Controls.Add(Me.ButtonOK)
        Me.PanelFooter.Controls.Add(Me.ButtonCancel)
        Me.PanelFooter.Location = New System.Drawing.Point(76, 4)
        Me.PanelFooter.Name = "PanelFooter"
        Me.PanelFooter.Size = New System.Drawing.Size(326, 42)
        Me.PanelFooter.TabIndex = 10000010
        '
        'ButtonOK
        '
        Me.ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonOK.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.ButtonOK.FlatAppearance.BorderSize = 0
        Me.ButtonOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ButtonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonOK.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOK.ForeColor = System.Drawing.Color.Black
        Me.ButtonOK.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonOK.Location = New System.Drawing.Point(10, 8)
        Me.ButtonOK.Name = "ButtonOK"
        Me.ButtonOK.Size = New System.Drawing.Size(150, 26)
        Me.ButtonOK.TabIndex = 10000008
        Me.ButtonOK.Text = "OK"
        Me.ButtonOK.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonCancel.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.FlatAppearance.BorderSize = 0
        Me.ButtonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.Black
        Me.ButtonCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCancel.Location = New System.Drawing.Point(167, 8)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(150, 26)
        Me.ButtonCancel.TabIndex = 10000009
        Me.ButtonCancel.Text = "Cancel"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'FormUnesiParametreOdjednom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = False
        Me.CancelButton = Me.ButtonCancel
        Me.ClientSize = New System.Drawing.Size(794, 500)
        Me.Controls.Add(Me.panelKontrole)
        Me.Controls.Add(Me.LParametar)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormUnesiParametreOdjednom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTop.ResumeLayout(False)
        Me.panelKontrole.ResumeLayout(False)
        Me.PanelFooter.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    '*******
    Private originalExStyle As Integer = -1
    Private enableFormLevelDoubleBuffering As Boolean = True
    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            If originalExStyle = -1 Then originalExStyle = MyBase.CreateParams.ExStyle
            Dim cp As CreateParams = MyBase.CreateParams

            If enableFormLevelDoubleBuffering Then
                cp.ExStyle = cp.ExStyle Or &H2000000
            Else
                cp.ExStyle = originalExStyle
            End If
            Return cp
        End Get
    End Property
    Public Sub TurnOffFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = False
        'Me.MaximizeBox = True
    End Sub
    Public Sub TurnOnFormLevelDoubleBuffering()
        enableFormLevelDoubleBuffering = True
        ' Me.MaximizeBox = True
    End Sub
    Private Sub Form_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        TurnOnFormLevelDoubleBuffering()
    End Sub

    Private Sub Form_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        TurnOffFormLevelDoubleBuffering()
    End Sub
    '*******
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Public VrednostParametra() As String = {}
    Public VrednostDodParametra() As String = {}
    Public ppolja() As String = {}
    Private DBConnectionString As String 'connection string
    Private mvt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka  ' vremenska tacka, odatle GOD i MES
    Private pizraz() As String = {}
    Dim jezik As String
    Dim txtmode As String
    Dim CAPIServer As String
    Dim CAPIBaza As String

    Public Sub New(ByVal DBConnectionString As String, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
    ByVal lbls() As String, ByVal polja() As String, ByVal jezik As String, ByVal txtMode As String,
                    ByVal txt_CAPIServer As String, ByVal txt_CAPIBaza As String, ByVal sifist As String)
        Me.New()
        Me.DBConnectionString = DBConnectionString
        Me.mvt = vt
        Me.txtmode = txtMode
        Me.CAPIServer = txt_CAPIServer
        Me.CAPIBaza = txt_CAPIBaza

        b3.Text = sifist + "    " + String.Format("{0:d2}", Me.mvt.M) + " / " + Me.mvt.G.ToString
        Call sklopiUnosParametara(lbls, polja)
        Polje1FocusPanel()
        Me.jezik = jezik
        Call SetLang()
    End Sub

    Private Sub SetLang()
        'Dim dt As System.Data.DataTable = getDTVBText(dtLang, "IstrazivanjaZadaci")
    End Sub
    Dim nizpoljefilter As String() = {}
    Dim nizcbofilter As Control() = {}
    Dim nizizrazfilter As String() = {}
    Dim nizvrednostfilter As String() = {}
    Dim nizDGV As DataGridView() = {}
    Dim nizDGVime As String() = {}
    Dim inddgv As Integer = -1
    Dim ind As Integer = -1
    Sub sklopiUnosParametara(ByVal lbls() As String, ByVal polja() As String)
        ReDim VrednostParametra(polja.GetUpperBound(0))
        ReDim VrednostDodParametra(polja.GetUpperBound(0))
        ReDim ppolja(polja.GetUpperBound(0))
        ReDim pizraz(polja.GetUpperBound(0))

        'Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Dim visina As Integer = 2
        Dim maxsirina As Integer = 0
        For i As Integer = 0 To lbls.GetUpperBound(0)
            Dim ltxt As New System.Windows.Forms.Label
            Dim tbox As New System.Windows.Forms.TextBox
            tbox.Width = 200
            Dim CBox As New System.Windows.Forms.ComboBox
            CBox.Width = 200
            Dim dgvIST As New System.Windows.Forms.DataGridView
            dgvIST.Width = 200
            dgvIST.Height = 200

            Dim imahide As Boolean = False
            If Not polja(i) Is Nothing AndAlso polja(i).ToUpper.IndexOf("*ISTHIDE") >= 0 Then
                imahide = True
                'polja(i) = polja(i).Replace("*ISTHIDE", "")
                polja(i) = NZ(Replace(polja(i), "*isthide", "", 1, , CompareMethod.Text)).Trim()
            End If

            'zamenaGGGMMM
            Dim tt() As String = Split(polja(i), "{")
            ppolja(i) = tt(0).Replace("CBO", "").Replace("CLBOX", "").ToUpper

            If lbls(i).Length > 50 Then
                visina = 3 * tbox.Height
            Else
                visina = tbox.Height
            End If
            Dim control As Control
            Dim lblcontrol As Label

            If tt.Length = 1 Then    'P3:unesi_opstinu
                'TP
                pizraz(i) = ""
                tbox.Name = "TP" & tt(0)
                tbox.TabIndex = i + 1

                If imahide = True Then
                    tbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
                End If
                If i = 1 Then tbox.Focus()
                Dim lpx As Integer = panelKontrole.Width - tbox.Width  '400
                Dim lpy As Integer = panelKontrole.Height
                Dim lsx As Integer = panelKontrole.Width - tbox.Width - 50
                ltxt = labelo(tt(0), lbls(i), panelKontrole.Width - tbox.Width - 20, lpy, lsx, visina)

                panelKontrole.Controls.Add(ltxt)
                panelKontrole.Height = panelKontrole.Height + ltxt.Height + 5
                tbox.Location = New System.Drawing.Point(panelKontrole.Width - tbox.Width - 20, panelKontrole.Height)
                panelKontrole.Controls.Add(tbox)

                control = tbox
                If maxsirina < tbox.Width + 50 Then
                    maxsirina = tbox.Width + 50
                End If
                AddHandler tbox.KeyPress, AddressOf Me.pp_KeyPress
                AddHandler tbox.Enter, AddressOf Me.pp_Enter
                AddHandler tbox.Validating, AddressOf Me.pp_Validating
                AddHandler tbox.KeyDown, AddressOf Me.pp_KeyDown
            Else
                pizraz(i) = tt(1)
                If tt(0).IndexOf("CBO") >= 0 Then
                    'P1CBO{IZVOR=select * from vSif_Investitor;PRIKAZI=Naziv;UBAZU=Sifra;WIDTH=800}:UnesiteLabela1...

                    If pizraz(i).Trim.ToUpper.IndexOf("WIDTH") >= 0 Then
                        Dim rr() As String = pizraz(i).Split(";")
                        Dim s As String = ""

                        For r As Integer = 0 To rr.GetUpperBound(0)
                            If rr(r).Trim.ToUpper.IndexOf("WIDTH") = 0 Then
                                rr(r) = rr(r).Replace("}", "")
                                Try
                                    Dim m As String = rr(r).Split("=")(1)
                                    If IsNumeric(m) Then CBox.Width = m
                                Catch ex As Exception
                                    ISTMessageBox.Show("Error in syntax at combobox width!")
                                End Try
                            Else
                                s = s + rr(r) + ";"
                            End If
                        Next
                        pizraz(i) = s
                    End If
                    If pizraz(i).Trim.ToUpper.IndexOf("FILTER") >= 0 Then
                        CBox.AccessibleName = "FILTER"
                    End If

                    If CBox.Width >= panelKontrole.Width Then panelKontrole.Width = CBox.Width + 200

                    tt(0) = tt(0).Trim.ToUpper.Replace("CBO", "")
                    CBox.Name = "CB" & tt(0)
                    CBox.TabIndex = i + 1
                    CBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown

                    If pizraz(i).Trim.ToUpper.IndexOf("FILTER") >= 0 Then
                        If pizraz(i).Length > 0 Then
                            Dim pom As String = pizraz(i).Replace(";", "; ")
                            Dim aaa() As String = razkvantaj(pom)
                            For j As Integer = 0 To aaa.Length() - 1
                                If aaa(j).Length() > 1 AndAlso aaa(j).Substring(0, 2).ToUpper = "D." Then
                                    Dim pp As String = aaa(j).Substring(2).ToUpper().Replace(";", "")
                                    ind = ind + 1
                                    ReDim Preserve nizpoljefilter(ind)
                                    nizpoljefilter(ind) = pp.Trim
                                    ReDim Preserve nizcbofilter(ind)
                                    nizcbofilter(ind) = CBox
                                    ReDim Preserve nizizrazfilter(ind)
                                    nizizrazfilter(ind) = pizraz(i)
                                    ReDim Preserve nizvrednostfilter(ind)
                                    nizvrednostfilter(ind) = ""
                                End If
                            Next
                        End If
                    End If
                    'CBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    'CBox.AutoCompleteSource = AutoCompleteSource.ListItems
                    'CBox.DropDownHeight = 1

                    cbpp_popuni(CBox, pizraz(i))
                    AddHandler CBox.Validating, AddressOf Me.cbpp_Validating
                    AddHandler CBox.KeyDown, AddressOf Me.cbpp_KeyDown
                    AddHandler CBox.Enter, AddressOf Me.cbpp_Enter
                    AddHandler CBox.SelectionChangeCommitted, AddressOf Me.cbpp_SelectionChangeCommitted
                    AddHandler CBox.TextChanged, AddressOf Me.cbpp_TextChanged

                    If i = 1 Then CBox.Focus()

                    Dim lpx As Integer = panelKontrole.Width - CBox.Width  '400
                    Dim lpy As Integer = panelKontrole.Height
                    Dim lsx As Integer = panelKontrole.Width - CBox.Width - 50
                    ltxt = labelo(tt(0), lbls(i), panelKontrole.Width - CBox.Width - 20, lpy, lsx, visina)

                    If maxsirina < CBox.Width + 50 Then
                        maxsirina = CBox.Width + 50
                    End If
                    panelKontrole.Controls.Add(ltxt)
                    panelKontrole.Height = panelKontrole.Height + ltxt.Height + 5
                    CBox.Location = New System.Drawing.Point(panelKontrole.Width - CBox.Width - 20, panelKontrole.Height)
                    panelKontrole.Controls.Add(CBox)
                    control = CBox
                ElseIf tt(0).IndexOf("CLBOX") >= 0 Then
                    'LAZNI LISTCHECKBOX - DGV
                    'P1CLBOX{IZVOR=select * from vSif_Investitor;PRIKAZI=Naziv;UBAZU=Sifra;WIDTH=800}:UnesiteLabela1...
                    control = sklopiDGV(dgvIST, pizraz(i), tt(0), ltxt, lbls(i), visina)
                    inddgv = inddgv + 1
                    ReDim Preserve nizDGV(inddgv)
                    ReDim Preserve nizDGVime(inddgv)
                    nizDGV(inddgv) = DirectCast(control, DataGridView)
                    nizDGVime(inddgv) = control.Name

                    If maxsirina < dgvIST.Width + 50 Then
                        maxsirina = dgvIST.Width + 50
                    End If
                    DirectCast(control, DataGridView).Columns("upisi").Visible = False
                    If Not DirectCast(control, DataGridView).Tag Is Nothing AndAlso DirectCast(control, DataGridView).Tag <> "" AndAlso
                            IsNumeric(DirectCast(control, DataGridView).Tag) = True Then
                        DirectCast(control, DataGridView).Columns("prikazi").Width = CInt(DirectCast(control, DataGridView).Tag)
                    End If
                    control.TabIndex = i + 1
                    If i = 1 Then control.Focus()
                Else
                    'P2{DA=numeric, NE=0}:UnesiteLabela2...
                    tbox.Name = "TP" & tt(0)
                    tbox.TabIndex = i + 1
                    If i = 1 Then tbox.Focus()
                    Dim lpx As Integer = panelKontrole.Width - tbox.Width  '400
                    Dim lpy As Integer = panelKontrole.Height
                    Dim lsx As Integer = panelKontrole.Width - tbox.Width - 50
                    ltxt = labelo(tt(0), lbls(i), panelKontrole.Width - tbox.Width - 20, lpy, lsx, visina)

                    If maxsirina < tbox.Width + 50 Then
                        maxsirina = tbox.Width + 50
                    End If
                    panelKontrole.Controls.Add(ltxt)
                    AddHandler tbox.KeyPress, AddressOf Me.pp_KeyPress
                    AddHandler tbox.Enter, AddressOf Me.pp_Enter
                    AddHandler tbox.Validating, AddressOf Me.pp_Validating
                    AddHandler tbox.KeyDown, AddressOf Me.pp_KeyDown
                    panelKontrole.Height = panelKontrole.Height + ltxt.Height + 5
                    CBox.Location = New System.Drawing.Point(panelKontrole.Width - tbox.Width - 20, panelKontrole.Height)
                    panelKontrole.Controls.Add(tbox)
                    control = tbox
                End If

            End If


            lblcontrol = ltxt
            If lbls(i).Length > 50 Then
                panelKontrole.Height = panelKontrole.Height + 3 * control.Height + 10
            Else
                panelKontrole.Height = panelKontrole.Height + control.Height + 10
            End If
            If control.Width > panelKontrole.Width \ 2 AndAlso lbls(i).Length > 25 Then
                panelKontrole.Width = 1.5 * panelKontrole.Width
                lblcontrol.Width = 3 * 1.5 * lblcontrol.Width
                control.Left = lblcontrol.Left + lblcontrol.Width + 10
            End If
        Next

        Me.Height = panelKontrole.Height + PanelFooter.Height + 100
        If Me.Height > 0.85 * Screen.PrimaryScreen.WorkingArea.Height Then
            'panelKontrole.Height = 0.85 * Screen.PrimaryScreen.WorkingArea.Height - 50
            Me.Height = 0.86 * Screen.PrimaryScreen.WorkingArea.Height
        End If

        Me.Width = maxsirina + 100

        If Me.Width > Screen.PrimaryScreen.WorkingArea.Width Then
            Me.Width = Screen.PrimaryScreen.WorkingArea.Width
            panelKontrole.Width = Screen.PrimaryScreen.WorkingArea.Width - 180
            PanelFooter.Width = Screen.PrimaryScreen.WorkingArea.Width - 180
        End If

        'For Each cntl As Control In panelKontrole.Controls
        '    NE RADI
        '    cntl.Anchor = AnchorStyles.None
        '    cntl.Anchor = AnchorStyles.Top
        'Next

        For i As Integer = panelKontrole.Controls.Count - 1 To 0 Step -1
            If Not TypeOf (panelKontrole.Controls(i)) Is Label Then
                panelKontrole.Controls(i).Left = (Me.ClientSize.Width - panelKontrole.Controls(i).Width) / 2
            Else
                panelKontrole.Controls(i).Left = panelKontrole.Controls(i + 1).Left
            End If
        Next

        For i As Integer = 0 To nizDGV.GetUpperBound(0)
            Call resizeDGV(nizDGV(i))
        Next

        PanelFooter.Dock = DockStyle.Bottom
        panelKontrole.Dock = DockStyle.Fill

        Me.CenterToScreen()

    End Sub
    Sub resizeDGV(ByVal dgvIST As DataGridView)
        dgvIST.AutoResizeColumns()
        dgvIST.AllowUserToOrderColumns = True
        dgvIST.AllowUserToResizeColumns = True
    End Sub
    Function sklopiDGV(ByVal dgvIST As DataGridView, ByVal pizraz As String, ByVal tt As String, ByVal ltxt As System.Windows.Forms.Label, ByVal lbls As String, ByVal visina As Integer) As DataGridView

        'LAZNI LISTCHECKBOX - DGV
        'P1CLBOX{IZVOR=select * from vSif_Investitor;PRIKAZI=Naziv;UBAZU=Sifra;WIDTH=800;HEIGHT=800}:UnesiteLabela1...

        If pizraz.Trim.ToUpper.IndexOf("WIDTH") >= 0 Then
            Dim rr() As String = pizraz.Split(";")
            Dim s As String = ""

            For r As Integer = 0 To rr.GetUpperBound(0)
                If rr(r).Trim.ToUpper.IndexOf("WIDTH") = 0 Then
                    rr(r) = rr(r).Replace("}", "")
                    Try
                        Dim m As String = rr(r).Split("=")(1)
                        If IsNumeric(m) Then dgvIST.Width = m
                    Catch ex As Exception
                        ISTMessageBox.Show("Error in syntax at list check box width!")
                    End Try
                Else
                    s = s + rr(r) + ";"
                End If
            Next
            pizraz = s
        End If

        If pizraz.Trim.ToUpper.IndexOf("HEIGHT") >= 0 Then
            Dim rr() As String = pizraz.Split(";")
            Dim s As String = ""

            For r As Integer = 0 To rr.GetUpperBound(0)
                If rr(r).Trim.ToUpper.IndexOf("HEIGHT") = 0 Then
                    rr(r) = rr(r).Replace("}", "")
                    Try
                        Dim m As String = rr(r).Split("=")(1)
                        If IsNumeric(m) Then dgvIST.Height = m
                    Catch ex As Exception
                        ISTMessageBox.Show("Error in syntax at list check box height!")
                    End Try
                Else
                    s = s + rr(r) + ";"
                End If
            Next
            pizraz = s
        End If
        If pizraz.Trim.ToUpper.IndexOf("COLUMNWIDTH") >= 0 Then
            Dim rr() As String = pizraz.Split(";")
            Dim s As String = ""

            For r As Integer = 0 To rr.GetUpperBound(0)
                If rr(r).Trim.ToUpper.IndexOf("COLUMNWIDTH") = 0 Then
                    rr(r) = rr(r).Replace("}", "")
                    Try
                        Dim m As String = rr(r).Split("=")(1)
                        If IsNumeric(m) Then dgvIST.Tag = CStr(m)
                    Catch ex As Exception
                        ISTMessageBox.Show("Error in syntax at list check box display column width!")
                    End Try
                Else
                    s = s + rr(r) + ";"
                End If
            Next
            pizraz = s
        End If

        If pizraz.Trim.ToUpper.IndexOf("MULTICHECKED") >= 0 Then
            Dim rr() As String = pizraz.Split(";")
            Dim s As String = ""

            For r As Integer = 0 To rr.GetUpperBound(0)
                If rr(r).Trim.ToUpper.IndexOf("MULTICHECKED") = 0 Then
                    rr(r) = rr(r).Replace("}", "").Replace(";", "")
                    Try
                        Dim m As String = rr(r).Split("=")(1)
                        If m.Trim.ToUpper = "TRUE" Then dgvIST.AccessibleDescription = "MULTICHECKED"
                    Catch ex As Exception
                        ISTMessageBox.Show("Error in syntax at list check box display column width!")
                    End Try
                Else
                    s = s + rr(r) + ";"
                End If
            Next
            pizraz = s
        End If

        If pizraz.Trim.ToUpper.IndexOf("FILTER") >= 0 Then
            dgvIST.AccessibleName = "FILTER"
        End If

        If dgvIST.Width >= panelKontrole.Width Then panelKontrole.Width = dgvIST.Width + 200

        tt = tt.Trim.ToUpper.Replace("CLBOX", "")
        dgvIST.Name = "DG" & tt

        If pizraz.Trim.ToUpper.IndexOf("FILTER") >= 0 Then
            If pizraz.Length > 0 Then
                Dim pom As String = pizraz.Replace(";", "; ")
                Dim aaa() As String = razkvantaj(pom)
                For j As Integer = 0 To aaa.Length() - 1
                    Dim pp As String = ""
                    If aaa(j).Length() > 1 AndAlso aaa(j).Substring(0, 2).ToUpper = "D." Then   'OrElse aaa(j).Substring(0, 3).ToUpper = "%D."
                        pp = aaa(j).Substring(2).ToUpper().Replace(";", "")
                        ind = ind + 1
                        ReDim Preserve nizpoljefilter(ind)
                        nizpoljefilter(ind) = pp.Trim
                        ReDim Preserve nizcbofilter(ind)
                        nizcbofilter(ind) = dgvIST
                        ReDim Preserve nizizrazfilter(ind)
                        nizizrazfilter(ind) = pizraz
                        ReDim Preserve nizvrednostfilter(ind)
                        nizvrednostfilter(ind) = ""
                    ElseIf aaa(j).Replace("N'", "").Replace("'", "").Length() > 2 AndAlso aaa(j).Replace("N'", "").Replace("'", "").Substring(0, 3).ToUpper = "%D." Then
                        pp = aaa(j).Replace("N'", "").Replace("'", "").Replace("%", "").Substring(2).ToUpper().Replace(";", "")
                        ind = ind + 1
                        ReDim Preserve nizpoljefilter(ind)
                        nizpoljefilter(ind) = pp.Trim
                        ReDim Preserve nizcbofilter(ind)
                        nizcbofilter(ind) = dgvIST
                        ReDim Preserve nizizrazfilter(ind)
                        nizizrazfilter(ind) = pizraz
                        ReDim Preserve nizvrednostfilter(ind)
                        nizvrednostfilter(ind) = ""
                    End If

                Next
            End If
        End If

        dgv_popuni(dgvIST, pizraz)

        AddHandler dgvIST.CellContentClick, AddressOf Me.dgvIST_CellContentClick
        AddHandler dgvIST.KeyPress, AddressOf Me.dgvIST_KeyPress   'quick search

        Dim lpx As Integer = panelKontrole.Width - dgvIST.Width  '400
        Dim lpy As Integer = panelKontrole.Height
        Dim lsx As Integer = panelKontrole.Width - dgvIST.Width - 50

        ltxt = labelo(tt(0), lbls, panelKontrole.Width - dgvIST.Width - 20, lpy, lsx, visina)

        panelKontrole.Controls.Add(ltxt)
        panelKontrole.Height = panelKontrole.Height + ltxt.Height + 5
        dgvIST.Location = New System.Drawing.Point(panelKontrole.Width - dgvIST.Width - 20, panelKontrole.Height)
        panelKontrole.Controls.Add(dgvIST)


        dgvIST.MultiSelect = False
        dgvIST.AllowUserToAddRows = False
        dgvIST.AllowUserToDeleteRows = False
        'dgvIST.BackgroundColor = dgvIST.Parent.BackColor
        dgvIST.BackgroundColor = System.Drawing.Color.Gainsboro
        dgvIST.BorderStyle = System.Windows.Forms.BorderStyle.None
        dgvIST.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        dgvIST.ColumnHeadersHeight = 22
        dgvIST.ColumnHeadersVisible = False
        dgvIST.GridColor = System.Drawing.Color.Gainsboro
        dgvIST.Margin = New System.Windows.Forms.Padding(0)
        'dgvIST.ReadOnly = True
        dgvIST.Columns("check").ReadOnly = False
        dgvIST.Columns("upisi").ReadOnly = False
        dgvIST.Columns("prikazi").ReadOnly = True
        dgvIST.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        dgvIST.RowTemplate.Height = 25
        Return dgvIST
    End Function
    Private Sub dgvIST_KeyPress(sender As Object, e As KeyPressEventArgs)
        Dim dgvIST As DataGridView = DirectCast(sender, DataGridView)
        Dim ch As Char = Char.ToUpper(e.KeyChar) ' Convert the key to uppercase for case-insensitivity
        If ch <> "" AndAlso IsNumeric(ch) = False Then ch = FormTemplate.konverzijaCirLat(ch)
        For i As Integer = 0 To dgvIST.Rows.Count - 1
            If Not dgvIST.Rows(i).IsNewRow AndAlso dgvIST.Rows(i).Cells(1).Value IsNot Nothing AndAlso
           Char.ToUpper(FormTemplate.konverzijaCirLat(dgvIST.Rows(i).Cells("prikazi").Value.ToString())(0)) = ch Then
                dgvIST.CurrentCell = dgvIST.Rows(i).Cells("prikazi") ' Set the current cell to the found cell
                Exit Sub
            End If
        Next
    End Sub

    Private Sub dgvIST_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs)
        Dim dgvIST As DataGridView = DirectCast(sender, DataGridView)
        If Not dgvIST.AccessibleDescription Is Nothing AndAlso dgvIST.AccessibleDescription <> "" AndAlso dgvIST.AccessibleDescription = "MULTICHECKED" Then
            '  multicheck
            If dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("check").Index).Value = False Then
                dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("check").Index).Value = True
            Else
                dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("check").Index).Value = False
            End If
        Else
            ' samo jedan (not multicheck)
            If dgvIST.Rows.Count > 0 Then
                For i As Integer = 0 To dgvIST.Rows.Count - 1
                    dgvIST.Rows(i).Cells(dgvIST.Columns("check").Index).Value = False
                Next
                dgvIST.Rows(e.RowIndex).Cells(dgvIST.Columns("check").Index).Value = True
            End If
        End If

        Dim plj As String = Mid(dgvIST.Name.Trim.ToUpper, 3)
        Dim vrednost As String = dgvupisi(dgvIST)

        For i As Integer = 0 To nizpoljefilter.GetUpperBound(0)
            If nizpoljefilter(i).Trim.ToUpper = plj.Trim.ToUpper Then
                nizvrednostfilter(i) = vrednost
            End If
        Next

        Call filterfilter(plj)


    End Sub
    'Private Sub dgvIST_Validating(sender As Object, e As CancelEventArgs)
    '    Dim dgvIST As System.Windows.Forms.DataGridView = DirectCast(sender, DataGridView)
    '    Dim plj As String = Mid(dgvIST.Name.Trim.ToUpper, 3)

    '    Dim vrednost As String = dgvupisi(dgvIST)

    '    For i As Integer = 0 To nizpoljefilter.GetUpperBound(0)
    '        If nizpoljefilter(i).Trim.ToUpper = plj.Trim.ToUpper Then
    '            nizvrednostfilter(i) = vrednost
    '        End If
    '    Next

    '    Call filterfilter(plj)
    'End Sub

    Private Sub dgv_popuni(ByRef dgvist As System.Windows.Forms.DataGridView, ByVal izraz As String, Optional filter As String = "",
                            Optional ByVal bezFilteraIakoGaIma As Boolean = False)
        Dim plj As String = Mid(dgvist.Name.Trim.ToUpper, 3)
        Dim sta As String = izraz.Trim.ToUpper

        Dim ds As System.Data.DataSet = dspopuni("DG", plj, sta, filter, bezFilteraIakoGaIma)

        If ds Is Nothing Then
            Exit Sub
        End If

        dgvist.DataSource = ds.Tables("tabela")
        Call resizeDGV(dgvist)
    End Sub

    Private Sub cbpp_popuni(ByRef cbo As System.Windows.Forms.ComboBox, ByVal izraz As String, Optional filter As String = "",
                            Optional ByVal bezFilteraIakoGaIma As Boolean = False)
        Dim plj As String = Mid(cbo.Name.Trim.ToUpper, 3)
        Dim sta As String = izraz.Trim.ToUpper

        Dim ds As System.Data.DataSet = dspopuni("CBO", plj, sta, filter, bezFilteraIakoGaIma)

        If ds Is Nothing Then
            Exit Sub
        End If

        cbo.DisplayMember = "prikazi"
        cbo.ValueMember = "upisi"
        cbo.DataSource = ds.Tables("tabela")
    End Sub
    Private Function dspopuni(ByVal what As String, ByVal plj As String, ByVal sta As String, Optional filter As String = "", Optional ByVal bezFilteraIakoGaIma As Boolean = False) As DataSet

        Dim ds As System.Data.DataSet = New System.Data.DataSet

        Dim dt As New System.Data.DataTable
        Dim izvor As String = ""
        Dim prikazi As String = ""
        Dim upisi As String = ""
        Dim prenesi As String = ""
        Dim filterX As String = ""
        sta = sta.Replace("CBO{", "").Replace("CLBOX{", "")
        sta = sta.Substring(0, sta.Length - 1)
        'sta = sta.Replace("}", "")
        Dim nizCB As String() = Microsoft.VisualBasic.Split(sta, ";")
        For ii As Integer = 0 To nizCB.GetUpperBound(0)
            If nizCB(ii).Trim.ToUpper.IndexOf("IZVOR=") >= 0 Then
                izvor = nizCB(ii).Trim.ToUpper.Replace("IZVOR=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("PRIKAZI=") >= 0 Then
                prikazi = nizCB(ii).Trim.ToUpper.Replace("PRIKAZI=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("UBAZU=") >= 0 Then
                upisi = nizCB(ii).Trim.ToUpper.Replace("UBAZU=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                izvor = nizCB(ii).Trim.ToUpper.Replace("DATASOURCE=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("DISPLAYMEMBER=") >= 0 Then
                prikazi = nizCB(ii).Trim.ToUpper.Replace("DISPLAYMEMBER=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("VALUEMEMBER=") >= 0 Then
                upisi = nizCB(ii).Trim.ToUpper.Replace("VALUEMEMBER=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("FILTER=") >= 0 Then
                filterX = nizCB(ii).Trim.ToUpper.Replace("FILTER=", "")
            End If
        Next


        Dim sqlFilter As String = "2=2"
        If filterX.Length > 0 Then
            Dim aaa() As String = razkvantaj(filterX)
            For i As Integer = 0 To aaa.Length() - 1
                Dim pp As String = ""
                If aaa(i).Length() > 1 AndAlso aaa(i).Substring(0, 2).ToUpper = "D." Then
                    pp = aaa(i).Substring(2).ToUpper()
                    Dim vrednost As String = ""
                    Dim cntl As Control = nadjiCNTL(pp)
                    If TypeOf cntl Is ComboBox Then
                        Dim cb As ComboBox = DirectCast(cntl, ComboBox)
                        If Not cb Is Nothing AndAlso Not (cb.SelectedValue) Is Nothing Then
                            vrednost = cb.SelectedValue.ToString.Trim
                        End If
                        aaa(i) = "'" & vrednost & "'"
                    End If
                    If TypeOf cntl Is TextBox Then
                        Dim tb As TextBox = DirectCast(cntl, TextBox)
                        If Not tb Is Nothing AndAlso Not (tb.Text) Is Nothing Then vrednost = tb.Text.Trim
                        aaa(i) = "'" & vrednost & "'"
                    End If
                    If TypeOf cntl Is DataGridView Then
                        Dim dg As DataGridView = DirectCast(cntl, DataGridView)
                        vrednost = dgvupisi(dg)
                        Dim xx() As String = vrednost.Split(",")
                        vrednost = ""
                        For m As Integer = 0 To xx.GetUpperBound(0)
                            vrednost = vrednost + "" + xx(m) + ","
                        Next
                        vrednost = vrednost.TrimEnd(",")
                        aaa(i) = "'" + vrednost + "'"
                    End If
                    'ElseIf aaa(i).Replace("N'", "").Replace("'", "").Length() > 2 AndAlso aaa(i).Replace("N'", "").Replace("'", "").Substring(0, 3).ToUpper = "%D." Then
                    '    pp = aaa(i).Replace("N'", "").Replace("'", "").Replace("%", "").Substring(2).ToUpper().Replace(";", "")
                    '    Dim vrednost As String = ""
                    '    Dim cntl As Control = nadjiCNTL(pp)
                    '    If TypeOf cntl Is ComboBox Then
                    '        Dim cb As ComboBox = DirectCast(cntl, ComboBox)
                    '        If Not cb Is Nothing AndAlso Not (cb.SelectedValue) Is Nothing Then
                    '            vrednost = cb.SelectedValue.ToString.Trim
                    '        End If
                    '        aaa(i) = "'" & vrednost & "'"
                    '    End If
                    '    If TypeOf cntl Is TextBox Then
                    '        Dim tb As TextBox = DirectCast(cntl, TextBox)
                    '        If Not tb Is Nothing AndAlso Not (tb.Text) Is Nothing Then vrednost = tb.Text.Trim
                    '        aaa(i) = "'" & vrednost & "'"
                    '    End If
                    '    If TypeOf cntl Is DataGridView Then
                    '        Dim dg As DataGridView = DirectCast(cntl, DataGridView)
                    '        vrednost = dgvupisi(dg)
                    '        Dim xx() As String = vrednost.Split(",")
                    '        vrednost = ""
                    '        For m As Integer = 0 To xx.GetUpperBound(0)
                    '            vrednost = vrednost + "N'%" + xx(m) + "%',"
                    '        Next
                    '        vrednost = vrednost.TrimEnd(",")
                    '        aaa(i) = vrednost
                    '    End If
                End If
            Next
            sqlFilter = sqlFilter & " and " & ustringaj(aaa).ToUpper
        End If


        'zamena GGGMMM
        Dim sql As String = ""
        sql = izvor.Trim.ToUpper
        sql = ZameniGGGMMM(sql, Me.mvt.G.ToString, Me.mvt.M, Me.mvt.vtwhere(""), Me.mvt.GWhere(""), Me.mvt.mWhere(""), Me.mvt.YWhere(""))
        sql = zameniCAPIUSER(sql, txtmode, CAPIServer, CAPIBaza)
        If bezFilteraIakoGaIma = False Then
            If filterX.Length > 0 Then
                If sql.Trim.ToUpper.IndexOf("WHERE") >= 0 Then
                    izvor = sql.Replace(";", "") & " and " & sqlFilter
                Else
                    izvor = sql & " where " & sqlFilter
                End If
            Else
                izvor = sql
            End If
        Else
            izvor = sql
        End If

        dt = izvrsiSQLvratiDT(izvor, Me.DBConnectionString, Me.jezik)
        If prikazi = "" OrElse upisi = "" Then
            ISTMessageBox.Show("Syntax for combobox/checklistbox is NOT correct! Please check!")
            Exit Function
        End If

        If what = "CBO" Then
            ds.Tables.Add("tabela")
            ds.Tables("tabela").Columns.Add("prikazi", GetType(String))
            ds.Tables("tabela").Columns.Add("upisi", GetType(String))

            'ubaci prazan
            Dim dr0 As DataRow = ds.Tables("tabela").NewRow()
            dr0("prikazi") = ""
            dr0("upisi") = ""
            ds.Tables("tabela").Rows.Add(dr0)

            For i As Integer = 0 To dt.Rows.Count - 1
                Dim dr As System.Data.DataRow = ds.Tables("tabela").NewRow()
                dr("prikazi") = dt.Rows(i).Item(prikazi)
                dr("upisi") = dt.Rows(i).Item(upisi)
                ds.Tables("tabela").Rows.Add(dr)
            Next
        End If

        If what = "DG" Then
            ds.Tables.Add("tabela")
            ds.Tables("tabela").Columns.Add("check", GetType(Boolean))
            ds.Tables("tabela").Columns.Add("upisi", GetType(String))
            ds.Tables("tabela").Columns.Add("prikazi", GetType(String))
            For i As Integer = 0 To dt.Rows.Count - 1
                Dim dr As System.Data.DataRow = ds.Tables("tabela").NewRow()
                dr("check") = 0
                dr("upisi") = dt.Rows(i).Item(upisi)
                dr("prikazi") = dt.Rows(i).Item(prikazi)
                ds.Tables("tabela").Rows.Add(dr)
            Next
        End If

        Return ds
    End Function
    Private Sub pp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)

        Dim tbox As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)
        Dim plj As String = Mid(tbox.Name.Trim.ToUpper, 3)

        ''POCETAK PROVERA KOD SAMOG POLJA
        ''''''''''''''''''''''''''''''
        Dim indeks As Integer = Array.IndexOf(ppolja, plj)
        Dim pomOD As String = pizraz(indeks)
        'primer {Min=0;Max=7;DA=0,1;NE=;OBAVEZNOAKO=NAZIV<>'' and (KD2010<>'' or ADRESA<>'')}
        'primer {Min=0;Max=7;DA= ,0,1;NE=5,6;OBAVEZNOAKO=NAZIV<>'' and (KD2010<>'' or ADRESA<>'')}
        'primer {Min=0;Max=7;DA= ,0,1;NE=5,6;OBAVEZNOAKO=NAZIV<>'' and (KD2010<>'' or ADRESA<>'')}
        'primer {UPOZORENJE;Min=0;Max=7;DA= ,0,1;NE=5,6;OBAVEZNOAKO=NAZIV<>'' and (KD2010<>'' or ADRESA<>'')}
        'primer {UPOZORENJE;DA=alphanumeric;NE=000;OBAVEZNOAKO=K01ImePrezime<>''}
        '        u DA moze numeric, alpha, alphanumeric (ove funkcije propustaju blanko!)

        Dim nizProvera() As String = {}
        Dim minV As String = ""
        Dim maxV As String = ""
        Dim minL As String = ""
        Dim maxL As String = ""
        Dim daV As String = ""
        Dim nizdaV() As String = {}
        Dim neV As String = ""
        Dim nizneV() As String = {}
        Dim obaveznaV As String = ""
        Dim nizobaveznaV() As String = {}
        Dim upozorenje As Boolean = False

        Dim skociNA As String = ""
        Dim nizskociNA() As String = {}
        Dim skociAKO As String = ""
        Dim nizskociAKO() As String = {}
        'readOnly
        Dim samoCita As String = ""
        Dim nizsamoCita() As String = {}
        Dim samoCitaAKO As String = ""
        Dim nizsamoCitaAKO() As String = {}
        Dim porukaJe As String = ""
        Dim porukaPreDodeleJe As String = ""
        Dim nizporukaJE() As String = {}
        Dim nizporukaPreDodeleJE() As String = {}
        Dim porukaAKO As String = ""
        Dim porukaPreDodeleAKO As String = ""
        Dim nizporukaAKO() As String = {}
        Dim nizporukaPreDodeleAKO() As String = {}
        Dim dodeliKome As String = ""
        Dim nizdodeliKome() As String = {}
        Dim dodeliSta As String = ""
        Dim nizdodeliSta() As String = {}
        Dim dodeliAko As String = ""
        Dim nizdodeliAko() As String = {}

        Dim bojiU As String = ""
        Dim nizBojiU() As String = {}
        Dim bojiAKO As String = ""
        Dim nizbojiAKO() As String = {}
        Dim bojiSta As String = ""
        Dim nizbojiSta() As String = {}

        If pomOD.Length > 0 AndAlso pomOD.Trim.IndexOf("}") > 0 Then
            pomOD = pomOD.Replace("}", "")
            pomOD = pomOD.Replace(vbCrLf, "")

            nizProvera = Microsoft.VisualBasic.Split(pomOD, ";")
            For i As Integer = 0 To nizProvera.GetUpperBound(0)

                nizProvera(i) = nizProvera(i).Trim.ToUpper

                If nizProvera(i).IndexOf("UPOZORENJE") = 0 Then upozorenje = True

                If nizProvera(i).IndexOf("MIN=") = 0 Then minV = nizProvera(i).Replace("MIN=", "").Trim
                If nizProvera(i).IndexOf("MAX=") = 0 Then maxV = nizProvera(i).Replace("MAX=", "").Trim

                If nizProvera(i).IndexOf("MNDUZINA=") = 0 Then minL = nizProvera(i).Replace("MNDUZINA=", "")
                If nizProvera(i).IndexOf("MXDUZINA=") = 0 Then maxL = nizProvera(i).Replace("MXDUZINA=", "")

                If nizProvera(i).IndexOf("DA=") = 0 Then
                    daV = nizProvera(i).Replace("DA=", "").Trim
                    nizdaV = Microsoft.VisualBasic.Split(daV, ",")
                End If
                If nizProvera(i).IndexOf("NE=") = 0 Then
                    neV = nizProvera(i).Replace("NE=", "").Trim
                    nizneV = Microsoft.VisualBasic.Split(neV, ",")
                End If

                If nizProvera(i).IndexOf("OBAVEZNOAKO=") = 0 Then obaveznaV = nizProvera(i).Replace("OBAVEZNOAKO=", "").Trim

                If nizProvera(i).IndexOf("SKOCINA=") = 0 Then
                    skociNA = nizProvera(i).Replace("SKOCINA=", "")
                    nizskociNA = Microsoft.VisualBasic.Split(skociNA, "$")
                End If
                If nizProvera(i).IndexOf("SKOCIAKO=") = 0 Then
                    skociAKO = nizProvera(i).Replace("SKOCIAKO=", "")
                    nizskociAKO = Microsoft.VisualBasic.Split(skociAKO, "$")
                End If

                If nizProvera(i).IndexOf("PORUKAJE=") = 0 Then
                    porukaJe = nizProvera(i).Replace("PORUKAJE=", "")
                    nizporukaJE = Microsoft.VisualBasic.Split(porukaJe, "$")
                End If
                If nizProvera(i).IndexOf("PORUKAAKO=") = 0 Then
                    porukaAKO = (nizProvera(i).Replace("PORUKAAKO=", ""))
                    nizporukaAKO = Microsoft.VisualBasic.Split(porukaAKO, "$")
                End If
                If nizProvera(i).IndexOf("PORUKAPREDODELEJE=") = 0 Then
                    porukaPreDodeleJe = nizProvera(i).Replace("PORUKAPREDODELEJE=", "")
                    nizporukaPreDodeleJE = Microsoft.VisualBasic.Split(porukaPreDodeleJe, "$")
                End If
                If nizProvera(i).IndexOf("PORUKAPREDODELEAKO=") = 0 Then
                    porukaPreDodeleAKO = (nizProvera(i).Replace("PORUKAPREDODELEAKO=", ""))
                    nizporukaPreDodeleAKO = Microsoft.VisualBasic.Split(porukaPreDodeleAKO, "$")
                End If

                If nizProvera(i).IndexOf("READONLY=") = 0 Then
                    samoCita = nizProvera(i).Replace("READONLY=", "")
                    nizsamoCita = Microsoft.VisualBasic.Split(samoCita, "$")
                End If
                If nizProvera(i).IndexOf("READONLYAKO=") = 0 Then
                    samoCitaAKO = (nizProvera(i).Replace("READONLYAKO=", ""))
                    nizsamoCitaAKO = Microsoft.VisualBasic.Split(samoCitaAKO, "$")
                End If

                If nizProvera(i).IndexOf("DODELIKOME=") = 0 Then
                    dodeliKome = nizProvera(i).Replace("DODELIKOME=", "")
                    nizdodeliKome = Microsoft.VisualBasic.Split(dodeliKome, "$")
                End If
                If nizProvera(i).IndexOf("DODELISTA=") = 0 Then
                    dodeliSta = nizProvera(i).Replace("DODELISTA=", "")
                    nizdodeliSta = Microsoft.VisualBasic.Split(dodeliSta, "$")
                End If
                If nizProvera(i).IndexOf("DODELIAKO=") = 0 Then
                    dodeliAko = (nizProvera(i).Replace("DODELIAKO=", ""))
                    nizdodeliAko = Microsoft.VisualBasic.Split(dodeliAko, "$")
                End If
                If nizProvera(i).IndexOf("BOJIU=") = 0 Then
                    bojiU = nizProvera(i).Replace("BOJIU=", "")
                    nizBojiU = Microsoft.VisualBasic.Split(bojiU, "$")
                End If
                If nizProvera(i).IndexOf("BOJIAKO=") = 0 Then
                    bojiAKO = nizProvera(i).Replace("BOJIAKO=", "")
                    nizbojiAKO = Microsoft.VisualBasic.Split(bojiAKO, "$")
                End If
                If nizProvera(i).IndexOf("BOJISTA=") = 0 Then
                    bojiSta = nizProvera(i).Replace("BOJISTA=", "")
                    nizbojiSta = Microsoft.VisualBasic.Split(bojiSta, "$")
                End If
                '*****************************
                If nizProvera(i).IndexOf("WARNING") = 0 Then upozorenje = True
                If nizProvera(i).IndexOf("MNLENGTH=") = 0 Then minL = nizProvera(i).Replace("MNLENGTH=", "")
                If nizProvera(i).IndexOf("MXLENGTH=") = 0 Then maxL = nizProvera(i).Replace("MXLENGTH=", "")

                If nizProvera(i).IndexOf("YES=") = 0 Then
                    daV = nizProvera(i).Replace("YES=", "").Trim
                    nizdaV = Microsoft.VisualBasic.Split(daV, ",")
                End If
                If nizProvera(i).IndexOf("NO=") = 0 Then
                    neV = nizProvera(i).Replace("NO=", "").Trim
                    nizneV = Microsoft.VisualBasic.Split(neV, ",")
                End If

                If nizProvera(i).IndexOf("REQUIREDIF=") = 0 Then obaveznaV = nizProvera(i).Replace("REQUIREDIF=", "").Trim

                If nizProvera(i).IndexOf("SKIPTO=") = 0 Then
                    skociNA = nizProvera(i).Replace("SKIPTO=", "")
                    nizskociNA = Microsoft.VisualBasic.Split(skociNA, "$")
                End If
                If nizProvera(i).IndexOf("SKIPIF=") = 0 Then
                    skociAKO = nizProvera(i).Replace("SKIPIF=", "")
                    nizskociAKO = Microsoft.VisualBasic.Split(skociAKO, "$")
                End If

                If nizProvera(i).IndexOf("MSGIS=") = 0 Then
                    porukaJe = nizProvera(i).Replace("MSGIS=", "")
                    nizporukaJE = Microsoft.VisualBasic.Split(porukaJe, "$")
                End If
                If nizProvera(i).IndexOf("MSGIF=") = 0 Then
                    porukaAKO = (nizProvera(i).Replace("MSGIF=", ""))
                    nizporukaAKO = Microsoft.VisualBasic.Split(porukaAKO, "$")
                End If
                If nizProvera(i).IndexOf("MSGBEFOREASSIGNMENTIS=") = 0 Then
                    porukaPreDodeleJe = nizProvera(i).Replace("MSGBEFOREASSIGNMENTIS=", "")
                    nizporukaPreDodeleJE = Microsoft.VisualBasic.Split(porukaPreDodeleJe, "$")
                End If
                If nizProvera(i).IndexOf("MSGBEFOREASSIGNMENTIF=") = 0 Then
                    porukaPreDodeleAKO = (nizProvera(i).Replace("MSGBEFOREASSIGNMENTIF=", ""))
                    nizporukaPreDodeleAKO = Microsoft.VisualBasic.Split(porukaPreDodeleAKO, "$")
                End If

                If nizProvera(i).IndexOf("READONLYIF=") = 0 Then
                    samoCitaAKO = (nizProvera(i).Replace("READONLYIF=", ""))
                    nizsamoCitaAKO = Microsoft.VisualBasic.Split(samoCitaAKO, "$")
                End If

                If nizProvera(i).IndexOf("ASSIGNTO=") = 0 Then
                    dodeliKome = nizProvera(i).Replace("ASSIGNTO=", "")
                    nizdodeliKome = Microsoft.VisualBasic.Split(dodeliKome, "$")
                End If
                If nizProvera(i).IndexOf("ASSIGNWHAT=") = 0 Then
                    dodeliSta = nizProvera(i).Replace("ASSIGNWHAT=", "")
                    nizdodeliSta = Microsoft.VisualBasic.Split(dodeliSta, "$")
                End If
                If nizProvera(i).IndexOf("ASSIGNIF=") = 0 Then
                    dodeliAko = (nizProvera(i).Replace("ASSIGNIF=", ""))
                    nizdodeliAko = Microsoft.VisualBasic.Split(dodeliAko, "$")
                End If
                If nizProvera(i).IndexOf("COLORTO=") = 0 Then
                    bojiU = nizProvera(i).Replace("COLORTO=", "")
                    nizBojiU = Microsoft.VisualBasic.Split(bojiU, "$")
                End If
                If nizProvera(i).IndexOf("COLORIF=") = 0 Then
                    bojiAKO = nizProvera(i).Replace("COLORIF=", "")
                    nizbojiAKO = Microsoft.VisualBasic.Split(bojiAKO, "$")
                End If
                If nizProvera(i).IndexOf("COLORWHAT=") = 0 Then
                    bojiSta = nizProvera(i).Replace("COLORWHAT=", "")
                    nizbojiSta = Microsoft.VisualBasic.Split(bojiSta, "$")
                End If
            Next
        End If

        tbox.BackColor = System.Drawing.SystemColors.ControlLightLight
        'AKCIJE
        If nizProvera.Length > 0 Then
            Dim ok As Boolean = False
            If nizdaV.Length > 0 Then
                For k As Integer = 0 To nizdaV.GetUpperBound(0)
                    Select Case nizdaV(k).Trim
                        Case "NUMERIC"
                            'pusti i prazno
                            ok = jisNumeric(tbox.Text.Trim)
                        Case "INTEGER"
                            'NUMERIC SAMO INTEGER (u polju dozvoljeni samo brojevi, ne i deimalna .)
                            ok = jisInteger(tbox.Text.Trim)
                        Case "ALPHA"
                            'mora da je sastavljeno samo od slova
                            ok = Not (IsNumeric(tbox.Text.Trim))
                        Case "ALPHANUMERIC"
                            'mora da je sastavljeno od samo od brojeva i slova; prazno je ok
                            ok = isAlphaNumeric(tbox.Text.Trim)
                        Case "DATUM"
                            'mora da je datum ; prazno je ok
                            ok = jisDate(tbox.Text.Trim)
                        Case Else
                            If tbox.Text.ToUpper.Trim <> nizdaV(k).Trim Then
                                ok = False
                            Else
                                ok = True
                            End If
                    End Select
                    If ok = True Then Exit For
                Next
                If ok = False Then
                    ''msg 27
                    Dim msgtxt As String = getMessageText(dtMessages, "27", Me.jezik)
                    ISTMessageBox.Show(msgtxt, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'ISTMessageBox.Show("Nedozvoljena vrednost!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If upozorenje = False Then
                        tbox.Focus()
                    Else
                        tbox.BackColor = System.Drawing.Color.LemonChiffon
                    End If
                    Exit Sub
                End If
            End If
            If nizneV.Length > 0 Then
                For k As Integer = 0 To nizneV.GetUpperBound(0)
                    If tbox.Text.ToUpper.Trim = nizneV(k).Trim Then
                        ''msg 27
                        Dim msgtxt As String = getMessageText(dtMessages, "27", Me.jezik)
                        ISTMessageBox.Show(msgtxt, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        'ISTMessageBox.Show("Nedozvoljena vrednost!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        If upozorenje = False Then
                            tbox.Focus()
                        Else
                            tbox.BackColor = System.Drawing.Color.LemonChiffon
                        End If
                        Exit Sub
                    End If
                Next
            End If
            If IsNumeric(tbox.Text.Trim) Then
                If minV <> "" AndAlso tbox.Text.Trim.Length > 0 AndAlso CDbl(tbox.Text.Trim) < CDbl(minV) Then
                    ''msg 28
                    Dim msgtxt As String = getMessageText(dtMessages, "28", Me.jezik)
                    ISTMessageBox.Show(msgtxt + minV + "", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'ISTMessageBox.Show("Manje od dozvoljenog! Min je " + minV + "", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If upozorenje = False Then
                        tbox.Focus()
                    Else
                        tbox.BackColor = System.Drawing.Color.LemonChiffon
                    End If
                    Exit Sub
                End If
                If maxV <> "" AndAlso tbox.Text.Trim.Length > 0 AndAlso CDbl(tbox.Text.Trim) > CDbl(maxV) Then
                    ''msg 29
                    Dim msgtxt As String = getMessageText(dtMessages, "29", Me.jezik)
                    ISTMessageBox.Show(msgtxt + maxV + "", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    'ISTMessageBox.Show("Vece od dozvoljenog! Max je " + maxV + "", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    If upozorenje = False Then
                        tbox.Focus()
                    Else
                        tbox.BackColor = System.Drawing.Color.LemonChiffon
                    End If
                    Exit Sub
                End If
            End If
            If minL <> "" AndAlso tbox.Text.Trim.Length > 0 AndAlso CDbl(tbox.Text.Trim.Length) < CDbl(minL) Then
                ''msg 30
                Dim msgtxt As String = getMessageText(dtMessages, "30", Me.jezik)
                ISTMessageBox.Show(msgtxt + minL + "!", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'ISTMessageBox.Show("Minimalna dužina polja je " + minL + "!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If upozorenje = False Then
                    tbox.Focus()
                Else
                    tbox.BackColor = System.Drawing.Color.LemonChiffon
                End If
                Exit Sub
            End If
            If maxL <> "" AndAlso tbox.Text.Trim.Length > 0 AndAlso CDbl(tbox.Text.Trim.Length) > CDbl(maxL) Then
                ''msg 31
                Dim msgtxt As String = getMessageText(dtMessages, "31", Me.jezik)
                ISTMessageBox.Show(msgtxt + maxL + "!", "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'ISTMessageBox.Show("Maksimalna dužina polja je " + maxL + "!", "Greška!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                If upozorenje = False Then
                    tbox.Focus()
                Else
                    tbox.BackColor = System.Drawing.Color.LemonChiffon
                End If
                Exit Sub
            End If

            'samo za TP, ne treba za kljuc vezati!
        End If ' If nizProvera.Length > 0 Then
        '''''''''''''''''''''''''''''''
        ''OSTALO PREBACENO NA KRAJ ZBOG FALSOVA
        '''''''''''''''''''''''''''''''
        '''''''''''''Nevena OVO DOLE NE RADI, NAPRAVLJENO NOVO 20230527
        'Dim nizCBnaCb As String() = Microsoft.VisualBasic.Split(CBnaCB, ";")
        'If nizCBnaCb.Length > 0 Then
        '    For i As Integer = 0 To nizCBnaCb.Length - 1
        '        Dim cbvb As String() = Microsoft.VisualBasic.Split(nizCBnaCb(i), ",")
        '        'ovo ako ima filter preko ovog TextBoxa, a ne drugog comboboxa
        '        If cbvb(0).Trim.ToUpper = plj Then
        '            For Each k As System.Windows.Forms.Control In Me.panel.Controls
        '                If Mid(k.Name, 1, 1) = "C" AndAlso Mid(k.Name, 3).Trim.ToUpper = cbvb(1).Trim.ToUpper Then
        '                    Dim index As Integer = Array.IndexOf(ppolja, Mid(k.Name, 3).Trim.ToUpper)
        '                    cbpp_popuni(k, pizraz(index - 1), True, SE(plj))
        '                    If SE(plj) Is System.DBNull.Value Then
        '                        CType(k, System.Windows.Forms.ComboBox).SelectedIndex = 0
        '                    Else
        '                        CType(k, System.Windows.Forms.ComboBox).SelectedValue = SE(plj).ToString.Trim
        '                    End If
        '                    Exit For
        '                End If
        '            Next
        '        End If

        '    Next
        'End If

        For i As Integer = 0 To nizpoljefilter.GetUpperBound(0)
            If nizpoljefilter(i).Trim.ToUpper = plj.Trim.ToUpper Then
                nizvrednostfilter(i) = tbox.Text.Trim
            End If
        Next

        Call filterfilter(plj)

    End Sub

    Private Sub pp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) 'Handles TKGOD.KeyPress
        Dim trt As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(27)
                Me.ButtonCancel.Focus()
            Case Microsoft.VisualBasic.ChrW(13) 'Enter
                'DGTabele(DGi(GlavnaTabela)).Rows(0).Item(Mid(trt.Name.Trim.ToUpper, 3)) = SE(Mid(trt.Name.Trim.ToUpper, 3))
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case Else
        End Select
    End Sub

    Private Sub pp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim trt As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)
        Select Case e.KeyCode
            Case Keys.Up
                System.Windows.Forms.SendKeys.Send("+{TAB}")
            Case Keys.Down
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case Keys.End
                Me.ButtonOK.Focus()
        End Select
    End Sub

    Private Sub pp_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim trt As System.Windows.Forms.TextBox = CType(sender, System.Windows.Forms.TextBox)
        trt.BackColor = System.Drawing.Color.Thistle
        trt.SelectAll()
    End Sub

    Public CBnaCB As String = ""
    Public CBGFvrednost As String
    Public cboIndexNaEnter As Integer
    Public promenaCBO As Boolean = False
    Public promenaCBOnaEnter As Boolean = False
    Public indexCBOnaLeave As Integer

    Private Sub cbpp_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'ISTMessageBox.Show("cbpp_TextChanged", MsgBoxStyle.Information)
        'System.Windows.Forms.SendKeys.Send("{F4}")
        Dim trt As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        If trt.SelectedValue Is Nothing OrElse trt.SelectedValue = "" Then
        Else
            'If trt.Text.Length = 1 Then
            '    System.Windows.Forms.SendKeys.Send("{F4}")
            'End If
        End If
    End Sub

    Private Sub cbpp_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        'ISTMessageBox.Show("cbpp_SelectionChangeCommitted", MsgBoxStyle.Information)
        promenaCBO = True
        Dim trt As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        Call cbpp_uradiNaPromenu(trt)
    End Sub

    Private Sub cbpp_uradiNaPromenu(ByVal cbo As System.Windows.Forms.ComboBox)

        For Each k As Control In panelKontrole.Controls
            If TypeOf k Is ComboBox Then
                'ko nema filter ovo se ne radi, i kome je vec uradjen filter
                If Not k.AccessibleName Is Nothing AndAlso k.AccessibleName.Trim.ToUpper = "FILTER" AndAlso cbo.TabIndex < k.TabIndex Then
                    Dim indeks As Integer = Array.IndexOf(ppolja, Mid(k.Name, 3).Trim.ToUpper)
                    cbpp_popuni(k, pizraz(indeks), True)
                End If
            End If
        Next
        System.Windows.Forms.SendKeys.Send("{TAB}")
    End Sub

    Private Sub cbpp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim trt As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        'ISTMessageBox.Show("cbpp_KeyDown", MsgBoxStyle.Information)
        Select Case e.KeyCode
            Case Keys.Escape
                'Me.BtnIzlaz.Focus()
            Case Keys.Enter  'Enter
                Dim aaa As String = trt.Name
                If Not (trt.SelectedValue) Is Nothing Then
                    'ako je poslednji nema gde dole!!!!
                    If cboIndexNaEnter <> trt.SelectedIndex Then
                        If trt.SelectedValue = CType(CType(trt.Items(trt.Items.Count - 1), Object), System.Data.DataRowView).Item(1) Then
                            System.Windows.Forms.SendKeys.Send("{UP}")
                            System.Windows.Forms.SendKeys.Send("{DOWN}")
                        Else
                            System.Windows.Forms.SendKeys.Send("{DOWN}")
                            System.Windows.Forms.SendKeys.Send("{UP}")
                        End If
                    End If
                Else

                    'dodato 11022013
                    'pre bilo samo System.Windows.Forms.SendKeys.Send("{DOWN}") umesto if then else
                    If trt.Text.Trim.Length > 0 AndAlso trt.SelectedText.Trim.Length = 0 Then
                        System.Windows.Forms.SendKeys.Send("{DOWN}")
                        System.Windows.Forms.SendKeys.Send("{DOWN}")
                        'ako nije poslednji
                        Dim dt As DataTable = CType(CType(trt.DataSource, Object), System.Data.DataTable)
                        Dim sqlText As String = "2=2 AND prikazi LIKE '" & trt.Text.Trim.ToUpper & "%'"
                        Dim red01 As System.Data.DataRow() = dt.Select(sqlText)
                        Dim poslednjiPrikazi As String = CType(CType(trt.Items(trt.Items.Count - 1), Object), System.Data.DataRowView).Item(0).ToString.Trim.ToUpper
                        If red01.Length = 1 AndAlso red01(0).Item("prikazi").ToString.Trim.ToUpper = poslednjiPrikazi Then
                            'POSLEDNJI
                        Else
                            System.Windows.Forms.SendKeys.Send("{UP}")
                        End If
                    Else
                        System.Windows.Forms.SendKeys.Send("{DOWN}")
                    End If
                End If
                System.Windows.Forms.SendKeys.Send("{TAB}")
            Case Keys.Up
            Case Keys.Down
            Case Keys.Left
            Case Keys.Right
            Case Keys.Back
            Case Keys.Delete
            Case Keys.F4
            Case Else
                If trt.DroppedDown = False Then trt.DroppedDown = True
        End Select
    End Sub

    Private Sub cbpp_Enter(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim trt As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)
        trt.BackColor = System.Drawing.Color.Thistle
        Try
            If trt.SelectedValue Is Nothing OrElse trt.SelectedValue.ToString.Trim = "" Then
                'da otvara kada uđe u polje ako je prazno; neću, predomislila sam se
                'System.Windows.Forms.SendKeys.Send("{F4}")
                'trt.DroppedDown = True 'NIKAKO izaziva  SelectionChangeCommitted
            Else
                cboIndexNaEnter = trt.SelectedIndex
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbpp_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim cbox As System.Windows.Forms.ComboBox = CType(sender, System.Windows.Forms.ComboBox)

        Dim plj As String = Mid(cbox.Name.Trim.ToUpper, 3)
        Dim indeks As Integer = Array.IndexOf(ppolja, plj)
        Dim pomIzraz As String = pizraz(indeks)

        cbox.BackColor = System.Drawing.SystemColors.ControlLightLight

        Dim dt As New System.Data.DataTable
        Dim izvorCBO As String = ""
        Dim upisiCBO As String = ""
        Dim filterCBO As String = ""

        pomIzraz = pomIzraz.Trim
        pomIzraz = pomIzraz.Replace("CBO{", "")
        pomIzraz = pomIzraz.Substring(0, pomIzraz.Length - 1)
        'pomIzraz = pomIzraz.Replace("}", "")

        Dim nizCB As String() = Microsoft.VisualBasic.Split(pomIzraz, ";")
        For ii As Integer = 0 To nizCB.GetUpperBound(0)
            If nizCB(ii).Trim.ToUpper.IndexOf("UBAZU=") >= 0 Then
                upisiCBO = nizCB(ii).Trim.ToUpper.Replace("UBAZU=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("IZVOR=") >= 0 Then
                izvorCBO = nizCB(ii).Trim.ToUpper.Replace("IZVOR=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("FILTER=") >= 0 Then
                filterCBO = nizCB(ii).Trim.ToUpper.Replace("FILTER=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("VALUEMEMBER=") >= 0 Then
                upisiCBO = nizCB(ii).Trim.ToUpper.Replace("VALUEMEMBER=", "")
            End If
            If nizCB(ii).Trim.ToUpper.IndexOf("DATASOURCE=") >= 0 Then
                izvorCBO = nizCB(ii).Trim.ToUpper.Replace("DATASOURCE=", "")
            End If
        Next

        For i As Integer = 0 To nizpoljefilter.GetUpperBound(0)
            If nizpoljefilter(i).Trim.ToUpper = plj.Trim.ToUpper Then
                If Not cbox.SelectedValue Is Nothing Then
                    nizvrednostfilter(i) = cbox.SelectedValue.ToString.Trim
                End If
            End If
        Next

        Call filterfilter(plj)

    End Sub
    Sub filterfilter(ByVal plj As String, Optional vrednost As String = "")
        '''''''''' OVO RADi TREBA DODATi I ZA CBO 20230527 NEVENA
        If nizpoljefilter.Length = nizcbofilter.Length AndAlso nizpoljefilter.Length = nizizrazfilter.Length Then
            For i As Integer = 0 To nizpoljefilter.Length - 1
                If plj = nizpoljefilter(i) Then
                    If nizcbofilter(i).Name.Substring(0, 2).ToUpper = "CB" Then
                        'cbpp_popuni(nizcbofilter(i), nizizrazfilter(i))
                        cbpp_popuni(nizcbofilter(i), nizizrazfilter(i), nizvrednostfilter(i))
                    End If
                    If nizcbofilter(i).Name.Substring(0, 2).ToUpper = "DG" Then
                        'dgv_popuni(nizcbofilter(i), nizizrazfilter(i))
                        dgv_popuni(nizcbofilter(i), nizizrazfilter(i), nizvrednostfilter(i))
                    End If
                End If
            Next
        End If
    End Sub
    Private Function SE(ByVal polje As String, Optional ByVal iFals As Boolean = False) As String
        For Each k As System.Windows.Forms.Control In panelKontrole.Controls
            If Mid(k.Name, 1, 1) = "T" Then
                If Mid(k.Name, 3).Trim.ToUpper = polje.Trim.ToUpper Then Return k.Text.Trim
            End If
            If Mid(k.Name, 1, 1) = "C" Then
                If Mid(k.Name, 3).Trim.ToUpper = polje.Trim.ToUpper Then Return CType(k, System.Windows.Forms.ComboBox).SelectedValue.ToString.Trim
            End If
            If iFals Then
                If Mid(k.Name, 1, 2) = "FP" Then
                    If Mid(k.Name, 3).Trim.ToUpper = polje.Trim.ToUpper Then Return k.Text.Trim
                End If
            End If
        Next
        Return ""
    End Function
    Function nadjiCNTL(ByVal pime As String) As Control
        nadjiCNTL = Nothing
        For Each k As Control In panelKontrole.Controls
            If Not TypeOf k Is Label AndAlso Mid(k.Name, 3).Trim.ToUpper = pime.Trim.ToUpper Then
                nadjiCNTL = k
                Exit For
            End If
        Next
    End Function


    Function nadjiCB(ByVal pime As String) As ComboBox
        nadjiCB = Nothing
        For Each k As Control In panelKontrole.Controls
            If TypeOf k Is ComboBox AndAlso Mid(k.Name, 3).Trim.ToUpper = pime.Trim.ToUpper Then
                nadjiCB = k
                Exit For
            End If
        Next
    End Function

    Function nadjiTB(ByVal pime As String) As TextBox
        nadjiTB = Nothing
        For Each k As Control In panelKontrole.Controls
            If TypeOf k Is TextBox AndAlso Mid(k.Name, 3).Trim.ToUpper = pime.Trim.ToUpper Then
                nadjiTB = k
                Exit For
            End If
        Next
    End Function

    Function nadjiDGV(ByVal pime As String) As DataGridView
        nadjiDGV = Nothing
        For Each k As Control In panelKontrole.Controls
            If TypeOf k Is DataGridView AndAlso Mid(k.Name, 3).Trim.ToUpper = pime.Trim.ToUpper Then
                nadjiDGV = k
                Exit For
            End If
        Next
    End Function

    Private Function labelo(ByVal ime As String, ByVal tekst As String, ByVal LX As Integer, ByVal LY As Integer, ByVal SX As Integer, ByVal SY As Integer) As System.Windows.Forms.Label
        Dim lbl As New System.Windows.Forms.Label
        lbl.Text = tekst.Trim
        lbl.Size = New System.Drawing.Size(10, SY)
        lbl.Font = New Font(Me.Font, FontStyle.Bold)
        lbl.AutoSize = True
        lbl.Location = New System.Drawing.Point(LX - lbl.Width - 5, LY)
        'lbl.Size = New System.Drawing.Size(SX, SY)
        lbl.Name = "L" & ime.Trim
        lbl.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Return lbl
    End Function

    Private Sub Polje1FocusPanel()
        For Each k As System.Windows.Forms.Control In panelKontrole.Controls
            If k.Name.Substring(0, 2).ToUpper = "TP" Then
                If k.TabStop = True Then
                    k.Focus()
                    Exit Sub
                End If
            End If
        Next
    End Sub

    Private Sub ButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        For i As Integer = 0 To ppolja.GetUpperBound(0)
            For Each k As System.Windows.Forms.Control In panelKontrole.Controls
                Dim plj As String = Mid(k.Name.Trim.ToUpper, 3)
                If plj.Trim.ToUpper = ppolja(i).Trim.ToUpper Then
                    If k.Name.Substring(0, 2).ToUpper = "TP" Then VrednostParametra(i) = k.Text
                    If k.Name.Substring(0, 2).ToUpper = "CB" Then
                        VrednostParametra(i) = CType(k, ComboBox).SelectedValue
                        VrednostDodParametra(i) = CType(k, ComboBox).Text
                    End If
                    If k.Name.Substring(0, 2).ToUpper = "DG" Then
                        VrednostParametra(i) = dgvupisi(k)
                        VrednostDodParametra(i) = dgvprikazi(k)
                    End If
                End If
            Next
        Next

        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Function dgvupisi(ByVal dgvIST As DataGridView) As String
        dgvupisi = ""
        Dim checkValue As Boolean
        Dim memberValue As String = ""
        If dgvIST.Rows.Count > 0 Then
            For i As Integer = 0 To dgvIST.Rows.Count - 1
                checkValue = dgvIST.Rows(i).Cells(dgvIST.Columns("check").Index).Value
                If checkValue = True Then
                    dgvupisi = dgvupisi + dgvIST.Rows(i).Cells(dgvIST.Columns("upisi").Index).Value.ToString + ","
                End If
            Next
            dgvupisi = dgvupisi.TrimEnd(",")
        End If
        Return dgvupisi
    End Function
    Function dgvprikazi(ByVal dgvIST As DataGridView) As String
        dgvprikazi = ""
        Dim checkValue As Boolean
        Dim memberValue As String = ""
        If dgvIST.Rows.Count > 0 Then
            For i As Integer = 0 To dgvIST.Rows.Count - 1
                checkValue = dgvIST.Rows(i).Cells(dgvIST.Columns("check").Index).Value
                If checkValue = True Then
                    dgvprikazi = dgvprikazi + dgvIST.Rows(i).Cells(dgvIST.Columns("prikazi").Index).Value.ToString + ","
                End If
            Next
            dgvprikazi = dgvprikazi.TrimEnd(",")
        End If
        Return dgvprikazi
    End Function
    Public Function jisNumeric(ByVal tekst As String) As Boolean

        jisNumeric = False
        If tekst.Trim.Length = 0 Then
            jisNumeric = True
        Else
            If IsNumeric(tekst) Then jisNumeric = True
        End If
    End Function

    Public Function jisDate(ByVal tekst As String) As Boolean

        jisDate = False
        If tekst.Trim.Length = 0 Then
            jisDate = True
        Else
            If IsDate(tekst) Then jisDate = True
        End If
    End Function

    Public Function jisInteger(ByVal tekst As String) As Boolean

        jisInteger = False
        If tekst.Trim.Length = 0 Then
            jisInteger = True
        Else
            If IsNumeric(tekst) AndAlso tekst.Trim.IndexOf(".") < 0 Then jisInteger = True
        End If
    End Function

    Public Function isAlphaNumeric(ByVal tekst As String) As Boolean

        Dim strCompare As String
        Dim strInput As String
        isAlphaNumeric = False
        If tekst.Trim.Length = 0 Then
            isAlphaNumeric = True
        Else
            For i As Integer = 1 To tekst.Trim.Length
                strCompare = Mid(tekst, i, 1)
                strInput = Mid(tekst, i + 1, tekst.Trim.Length)
                If strCompare Like ("[A-Z]") Or strCompare Like ("[a-z]") Or strCompare Like ("#") Or strCompare Like ("-") Then
                    isAlphaNumeric = True
                Else
                    isAlphaNumeric = False
                    Exit Function
                End If
            Next i
        End If
    End Function

    Private Sub FormUnesiParametreOdjednom_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call setTheme(GetTheme())

    End Sub
    Sub setTheme(ByVal theme As String)
        If theme = "L" Then
            ISTTheme.ChosenTheme("Light")

            PanelTop.BackColor = ISTTheme.PanelParent
        Else
            ISTTheme.ChosenTheme("Dark")

            PanelTop.BackColor = ISTTheme.PanelParent
        End If
    End Sub


    Dim MoveForm As Boolean
    Dim MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseDown

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
    '*****************************
End Class