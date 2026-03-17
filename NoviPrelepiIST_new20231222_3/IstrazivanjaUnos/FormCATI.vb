Option Strict Off

Public Class FormCATI
    Inherits FormTemplate

#Region " Windows Form Designer generated code "

    Private Sub New()
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
    Friend WithEvents lblNaziv As System.Windows.Forms.Label

    Friend WithEvents GBGODC As System.Windows.Forms.GroupBox
    Friend WithEvents TKMES As System.Windows.Forms.TextBox
    Friend WithEvents TKGOD As System.Windows.Forms.TextBox
    Friend WithEvents lblCNapomena As System.Windows.Forms.Label
    Friend WithEvents btnCIzlaz As System.Windows.Forms.Button
    Friend WithEvents txtNapomena As System.Windows.Forms.TextBox
    Public WithEvents gbRezultat As GroupBox
    Friend WithEvents txtMM As System.Windows.Forms.TextBox
    Friend WithEvents rb5 As System.Windows.Forms.RadioButton
    Friend WithEvents rb4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb7 As System.Windows.Forms.RadioButton
    Friend WithEvents rb3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb1 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtInstrukcije As System.Windows.Forms.TextBox
    Friend WithEvents txtT As System.Windows.Forms.TextBox
    Friend WithEvents dgCALLS As System.Windows.Forms.DataGrid
    Public WithEvents btnCCall As Button
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblC As System.Windows.Forms.TextBox
    Friend WithEvents lblH As System.Windows.Forms.TextBox
    Friend WithEvents lblKljuc As System.Windows.Forms.TextBox
    Friend WithEvents lblPokusaj As System.Windows.Forms.TextBox
    Friend WithEvents lblStratum As System.Windows.Forms.TextBox
    Friend WithEvents lblCNapomena1 As Label
    Friend WithEvents txtKomentarAnketara As TextBox
    Friend WithEvents rb12 As RadioButton
    Friend WithEvents rb11 As RadioButton
    Friend WithEvents rb10 As RadioButton
    Friend WithEvents rb9 As RadioButton
    Friend WithEvents rb8 As RadioButton
    Friend WithEvents rb6 As RadioButton
    Friend WithEvents cboHour As ComboBox
    Friend WithEvents dtp2 As DateTimePicker2
    Friend WithEvents llEMAIL As LinkLabel
    Friend WithEvents txtEMAIL As TextBox
    Friend WithEvents txtNovaAdresa As TextBox
    Friend WithEvents dgHistory As DataGrid
    Friend WithEvents rb99 As RadioButton
    Friend WithEvents llAPR As LinkLabel
    Friend WithEvents LLBeleStrane As LinkLabel
    Friend WithEvents btnHangU As Button
    Friend WithEvents llNBS As LinkLabel
    Friend WithEvents ButtonCUneti As Button
    Friend WithEvents rb71 As RadioButton
    Friend WithEvents ButtonCUnos As Button
    Friend WithEvents llZakazani As LinkLabel
    Friend WithEvents rb14 As RadioButton
    Friend WithEvents llPregledEmail As LinkLabel
    Friend WithEvents panelEmails As Panel
    Friend WithEvents ButtonClose As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnEmails14PM As Button
    Friend WithEvents panelpregledZamena As Panel
    Friend WithEvents dgvPZ As DataGridView
    Friend WithEvents ButtonClosePZ As Button
    Friend WithEvents llPZ As LinkLabel
    Friend WithEvents cbST As CheckBox
    Friend WithEvents llRZ As LinkLabel
    Friend WithEvents panelpregledPozivaZamena As Panel
    Friend WithEvents dgvRZ As DataGridView
    Friend WithEvents ButtonCloseRZ As Button
    Friend WithEvents llPZ1 As LinkLabel
    Friend WithEvents rb98 As RadioButton
    Friend WithEvents pamti98 As TextBox
    Friend WithEvents nizpamti98 As TextBox
    Friend WithEvents lblLogovanA As System.Windows.Forms.TextBox
    Friend WithEvents rb16 As System.Windows.Forms.RadioButton

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCATI))
        Me.lblNaziv = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GBGODC = New System.Windows.Forms.GroupBox()
        Me.TKMES = New System.Windows.Forms.TextBox()
        Me.TKGOD = New System.Windows.Forms.TextBox()
        Me.btnCIzlaz = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.btnEmails14PM = New System.Windows.Forms.Button()
        Me.ButtonCUnos = New System.Windows.Forms.Button()
        Me.ButtonCUneti = New System.Windows.Forms.Button()
        Me.btnHangU = New System.Windows.Forms.Button()
        Me.txtNovaAdresa = New System.Windows.Forms.TextBox()
        Me.dgHistory = New System.Windows.Forms.DataGrid()
        Me.lblCNapomena1 = New System.Windows.Forms.Label()
        Me.txtKomentarAnketara = New System.Windows.Forms.TextBox()
        Me.lblLogovanA = New System.Windows.Forms.TextBox()
        Me.lblStratum = New System.Windows.Forms.TextBox()
        Me.lblPokusaj = New System.Windows.Forms.TextBox()
        Me.lblKljuc = New System.Windows.Forms.TextBox()
        Me.lblH = New System.Windows.Forms.TextBox()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.lblCNapomena = New System.Windows.Forms.Label()
        Me.txtNapomena = New System.Windows.Forms.TextBox()
        Me.dgCALLS = New System.Windows.Forms.DataGrid()
        Me.gbRezultat = New System.Windows.Forms.GroupBox()
        Me.nizpamti98 = New System.Windows.Forms.TextBox()
        Me.pamti98 = New System.Windows.Forms.TextBox()
        Me.rb98 = New System.Windows.Forms.RadioButton()
        Me.llPZ1 = New System.Windows.Forms.LinkLabel()
        Me.cbST = New System.Windows.Forms.CheckBox()
        Me.llPregledEmail = New System.Windows.Forms.LinkLabel()
        Me.llZakazani = New System.Windows.Forms.LinkLabel()
        Me.rb14 = New System.Windows.Forms.RadioButton()
        Me.rb71 = New System.Windows.Forms.RadioButton()
        Me.llNBS = New System.Windows.Forms.LinkLabel()
        Me.llAPR = New System.Windows.Forms.LinkLabel()
        Me.LLBeleStrane = New System.Windows.Forms.LinkLabel()
        Me.rb99 = New System.Windows.Forms.RadioButton()
        Me.llEMAIL = New System.Windows.Forms.LinkLabel()
        Me.txtEMAIL = New System.Windows.Forms.TextBox()
        Me.cboHour = New System.Windows.Forms.ComboBox()
        Me.dtp2 = New DateTimePicker2()
        Me.rb6 = New System.Windows.Forms.RadioButton()
        Me.rb12 = New System.Windows.Forms.RadioButton()
        Me.rb11 = New System.Windows.Forms.RadioButton()
        Me.rb10 = New System.Windows.Forms.RadioButton()
        Me.rb9 = New System.Windows.Forms.RadioButton()
        Me.rb8 = New System.Windows.Forms.RadioButton()
        Me.txtMM = New System.Windows.Forms.TextBox()
        Me.rb5 = New System.Windows.Forms.RadioButton()
        Me.rb4 = New System.Windows.Forms.RadioButton()
        Me.rb7 = New System.Windows.Forms.RadioButton()
        Me.rb3 = New System.Windows.Forms.RadioButton()
        Me.rb2 = New System.Windows.Forms.RadioButton()
        Me.rb16 = New System.Windows.Forms.RadioButton()
        Me.rb1 = New System.Windows.Forms.RadioButton()
        Me.llPZ = New System.Windows.Forms.LinkLabel()
        Me.llRZ = New System.Windows.Forms.LinkLabel()
        Me.btnCCall = New System.Windows.Forms.Button()
        Me.lblC = New System.Windows.Forms.TextBox()
        Me.txtInstrukcije = New System.Windows.Forms.TextBox()
        Me.panelEmails = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.panelpregledZamena = New System.Windows.Forms.Panel()
        Me.dgvPZ = New System.Windows.Forms.DataGridView()
        Me.ButtonClosePZ = New System.Windows.Forms.Button()
        Me.panelpregledPozivaZamena = New System.Windows.Forms.Panel()
        Me.dgvRZ = New System.Windows.Forms.DataGridView()
        Me.ButtonCloseRZ = New System.Windows.Forms.Button()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBGODC.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.dgHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCALLS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRezultat.SuspendLayout()
        Me.panelEmails.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelpregledZamena.SuspendLayout()
        CType(Me.dgvPZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelpregledPozivaZamena.SuspendLayout()
        CType(Me.dgvRZ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNaziv
        '
        Me.lblNaziv.BackColor = System.Drawing.Color.Transparent
        Me.lblNaziv.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblNaziv.ForeColor = System.Drawing.Color.DarkRed
        Me.lblNaziv.Location = New System.Drawing.Point(16, 64)
        Me.lblNaziv.Name = "lblNaziv"
        Me.lblNaziv.Size = New System.Drawing.Size(110, 20)
        Me.lblNaziv.TabIndex = 92
        Me.lblNaziv.Text = "."
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(20, 88)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 30)
        Me.Panel1.TabIndex = 95
        '
        'GBGODC
        '
        Me.GBGODC.Controls.Add(Me.TKMES)
        Me.GBGODC.Controls.Add(Me.TKGOD)
        Me.GBGODC.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.GBGODC.Location = New System.Drawing.Point(20, 0)
        Me.GBGODC.Name = "GBGODC"
        Me.GBGODC.Size = New System.Drawing.Size(113, 60)
        Me.GBGODC.TabIndex = 2
        Me.GBGODC.TabStop = False
        Me.GBGODC.Text = "God    Mes"
        '
        'TKMES
        '
        Me.TKMES.AcceptsReturn = True
        Me.TKMES.BackColor = System.Drawing.SystemColors.Window
        Me.TKMES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TKMES.Enabled = False
        Me.TKMES.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TKMES.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TKMES.Location = New System.Drawing.Point(52, 16)
        Me.TKMES.Name = "TKMES"
        Me.TKMES.Size = New System.Drawing.Size(32, 22)
        Me.TKMES.TabIndex = 3
        '
        'TKGOD
        '
        Me.TKGOD.AcceptsReturn = True
        Me.TKGOD.BackColor = System.Drawing.SystemColors.Window
        Me.TKGOD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TKGOD.Enabled = False
        Me.TKGOD.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.TKGOD.Location = New System.Drawing.Point(7, 16)
        Me.TKGOD.Name = "TKGOD"
        Me.TKGOD.Size = New System.Drawing.Size(42, 22)
        Me.TKGOD.TabIndex = 1
        '
        'btnCIzlaz
        '
        Me.btnCIzlaz.BackColor = System.Drawing.Color.Transparent
        Me.btnCIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCIzlaz.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCIzlaz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCIzlaz.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCIzlaz.Location = New System.Drawing.Point(1521, 20)
        Me.btnCIzlaz.Name = "btnCIzlaz"
        Me.btnCIzlaz.Size = New System.Drawing.Size(159, 28)
        Me.btnCIzlaz.TabIndex = 10000019
        Me.btnCIzlaz.TabStop = False
        Me.btnCIzlaz.Text = "Излаз"
        Me.btnCIzlaz.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.btnEmails14PM)
        Me.panel2.Controls.Add(Me.ButtonCUnos)
        Me.panel2.Controls.Add(Me.ButtonCUneti)
        Me.panel2.Controls.Add(Me.btnHangU)
        Me.panel2.Controls.Add(Me.txtNovaAdresa)
        Me.panel2.Controls.Add(Me.dgHistory)
        Me.panel2.Controls.Add(Me.lblCNapomena1)
        Me.panel2.Controls.Add(Me.txtKomentarAnketara)
        Me.panel2.Controls.Add(Me.lblLogovanA)
        Me.panel2.Controls.Add(Me.lblStratum)
        Me.panel2.Controls.Add(Me.lblPokusaj)
        Me.panel2.Controls.Add(Me.lblKljuc)
        Me.panel2.Controls.Add(Me.lblH)
        Me.panel2.Controls.Add(Me.txtT)
        Me.panel2.Controls.Add(Me.lblCNapomena)
        Me.panel2.Controls.Add(Me.txtNapomena)
        Me.panel2.Controls.Add(Me.dgCALLS)
        Me.panel2.Controls.Add(Me.gbRezultat)
        Me.panel2.Controls.Add(Me.btnCCall)
        Me.panel2.Controls.Add(Me.lblC)
        Me.panel2.Location = New System.Drawing.Point(610, 88)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(1070, 704)
        Me.panel2.TabIndex = 124
        '
        'btnEmails14PM
        '
        Me.btnEmails14PM.BackColor = System.Drawing.Color.Transparent
        Me.btnEmails14PM.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEmails14PM.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnEmails14PM.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEmails14PM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnEmails14PM.Location = New System.Drawing.Point(729, 7)
        Me.btnEmails14PM.Name = "btnEmails14PM"
        Me.btnEmails14PM.Size = New System.Drawing.Size(118, 22)
        Me.btnEmails14PM.TabIndex = 10000017
        Me.btnEmails14PM.TabStop = False
        Me.btnEmails14PM.Text = "Grupni email"
        Me.btnEmails14PM.UseVisualStyleBackColor = False
        Me.btnEmails14PM.Visible = False
        '
        'ButtonCUnos
        '
        Me.ButtonCUnos.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCUnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCUnos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonCUnos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonCUnos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCUnos.Location = New System.Drawing.Point(602, 7)
        Me.ButtonCUnos.Name = "ButtonCUnos"
        Me.ButtonCUnos.Size = New System.Drawing.Size(90, 22)
        Me.ButtonCUnos.TabIndex = 10000016
        Me.ButtonCUnos.TabStop = False
        Me.ButtonCUnos.Text = "Dodatni"
        Me.ButtonCUnos.UseVisualStyleBackColor = False
        '
        'ButtonCUneti
        '
        Me.ButtonCUneti.BackColor = System.Drawing.Color.Transparent
        Me.ButtonCUneti.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCUneti.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ButtonCUneti.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonCUneti.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCUneti.Location = New System.Drawing.Point(500, 7)
        Me.ButtonCUneti.Name = "ButtonCUneti"
        Me.ButtonCUneti.Size = New System.Drawing.Size(97, 22)
        Me.ButtonCUneti.TabIndex = 10000015
        Me.ButtonCUneti.TabStop = False
        Me.ButtonCUneti.Text = "Pregled"
        Me.ButtonCUneti.UseVisualStyleBackColor = False
        '
        'btnHangU
        '
        Me.btnHangU.BackColor = System.Drawing.Color.Crimson
        Me.btnHangU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHangU.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnHangU.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnHangU.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnHangU.Location = New System.Drawing.Point(312, 535)
        Me.btnHangU.Name = "btnHangU"
        Me.btnHangU.Size = New System.Drawing.Size(77, 22)
        Me.btnHangU.TabIndex = 10000015
        Me.btnHangU.Text = "Hang up"
        Me.btnHangU.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnHangU.UseVisualStyleBackColor = False
        Me.btnHangU.Visible = False
        '
        'txtNovaAdresa
        '
        Me.txtNovaAdresa.Location = New System.Drawing.Point(395, 535)
        Me.txtNovaAdresa.Name = "txtNovaAdresa"
        Me.txtNovaAdresa.Size = New System.Drawing.Size(94, 22)
        Me.txtNovaAdresa.TabIndex = 10000014
        Me.txtNovaAdresa.Visible = False
        '
        'dgHistory
        '
        Me.dgHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgHistory.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.dgHistory.CaptionForeColor = System.Drawing.SystemColors.ControlText
        Me.dgHistory.DataMember = ""
        Me.dgHistory.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.dgHistory.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgHistory.Location = New System.Drawing.Point(8, 289)
        Me.dgHistory.Name = "dgHistory"
        Me.dgHistory.ReadOnly = True
        Me.dgHistory.Size = New System.Drawing.Size(199, 48)
        Me.dgHistory.TabIndex = 154
        Me.dgHistory.TabStop = False
        '
        'lblCNapomena1
        '
        Me.lblCNapomena1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCNapomena1.Location = New System.Drawing.Point(418, 230)
        Me.lblCNapomena1.Name = "lblCNapomena1"
        Me.lblCNapomena1.Size = New System.Drawing.Size(320, 16)
        Me.lblCNapomena1.TabIndex = 153
        Me.lblCNapomena1.Text = "Komentar anketara"
        '
        'txtKomentarAnketara
        '
        Me.txtKomentarAnketara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKomentarAnketara.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtKomentarAnketara.Location = New System.Drawing.Point(418, 246)
        Me.txtKomentarAnketara.Multiline = True
        Me.txtKomentarAnketara.Name = "txtKomentarAnketara"
        Me.txtKomentarAnketara.Size = New System.Drawing.Size(384, 40)
        Me.txtKomentarAnketara.TabIndex = 152
        Me.txtKomentarAnketara.Visible = False
        '
        'lblLogovanA
        '
        Me.lblLogovanA.AcceptsReturn = True
        Me.lblLogovanA.BackColor = System.Drawing.SystemColors.Control
        Me.lblLogovanA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLogovanA.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.lblLogovanA.Location = New System.Drawing.Point(60, 538)
        Me.lblLogovanA.MaxLength = 1
        Me.lblLogovanA.Name = "lblLogovanA"
        Me.lblLogovanA.Size = New System.Drawing.Size(24, 22)
        Me.lblLogovanA.TabIndex = 151
        Me.lblLogovanA.Visible = False
        '
        'lblStratum
        '
        Me.lblStratum.AcceptsReturn = True
        Me.lblStratum.BackColor = System.Drawing.SystemColors.Control
        Me.lblStratum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStratum.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.lblStratum.Location = New System.Drawing.Point(33, 538)
        Me.lblStratum.MaxLength = 1
        Me.lblStratum.Name = "lblStratum"
        Me.lblStratum.Size = New System.Drawing.Size(24, 22)
        Me.lblStratum.TabIndex = 150
        Me.lblStratum.Visible = False
        '
        'lblPokusaj
        '
        Me.lblPokusaj.AcceptsReturn = True
        Me.lblPokusaj.BackColor = System.Drawing.SystemColors.Control
        Me.lblPokusaj.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblPokusaj.Enabled = False
        Me.lblPokusaj.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.lblPokusaj.Location = New System.Drawing.Point(500, 14)
        Me.lblPokusaj.MaxLength = 1
        Me.lblPokusaj.Name = "lblPokusaj"
        Me.lblPokusaj.Size = New System.Drawing.Size(93, 15)
        Me.lblPokusaj.TabIndex = 149
        '
        'lblKljuc
        '
        Me.lblKljuc.AcceptsReturn = True
        Me.lblKljuc.BackColor = System.Drawing.SystemColors.Control
        Me.lblKljuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblKljuc.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.lblKljuc.Location = New System.Drawing.Point(6, 538)
        Me.lblKljuc.MaxLength = 1
        Me.lblKljuc.Name = "lblKljuc"
        Me.lblKljuc.Size = New System.Drawing.Size(24, 22)
        Me.lblKljuc.TabIndex = 148
        Me.lblKljuc.Visible = False
        '
        'lblH
        '
        Me.lblH.AcceptsReturn = True
        Me.lblH.BackColor = System.Drawing.SystemColors.Control
        Me.lblH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblH.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.lblH.Location = New System.Drawing.Point(183, 535)
        Me.lblH.MaxLength = 1
        Me.lblH.Name = "lblH"
        Me.lblH.Size = New System.Drawing.Size(24, 22)
        Me.lblH.TabIndex = 147
        Me.lblH.Visible = False
        '
        'txtT
        '
        Me.txtT.BackColor = System.Drawing.SystemColors.Window
        Me.txtT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtT.Enabled = False
        Me.txtT.Location = New System.Drawing.Point(8, 8)
        Me.txtT.Name = "txtT"
        Me.txtT.Size = New System.Drawing.Size(337, 22)
        Me.txtT.TabIndex = 137
        '
        'lblCNapomena
        '
        Me.lblCNapomena.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblCNapomena.ForeColor = System.Drawing.Color.Red
        Me.lblCNapomena.Location = New System.Drawing.Point(8, 230)
        Me.lblCNapomena.Name = "lblCNapomena"
        Me.lblCNapomena.Size = New System.Drawing.Size(248, 16)
        Me.lblCNapomena.TabIndex = 136
        Me.lblCNapomena.Text = "Komentar za anketara"
        '
        'txtNapomena
        '
        Me.txtNapomena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNapomena.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtNapomena.ForeColor = System.Drawing.Color.Red
        Me.txtNapomena.Location = New System.Drawing.Point(8, 246)
        Me.txtNapomena.Multiline = True
        Me.txtNapomena.Name = "txtNapomena"
        Me.txtNapomena.ReadOnly = True
        Me.txtNapomena.Size = New System.Drawing.Size(369, 40)
        Me.txtNapomena.TabIndex = 135
        Me.txtNapomena.TabStop = False
        '
        'dgCALLS
        '
        Me.dgCALLS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCALLS.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.dgCALLS.CaptionForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCALLS.DataMember = ""
        Me.dgCALLS.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.dgCALLS.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCALLS.Location = New System.Drawing.Point(8, 393)
        Me.dgCALLS.Name = "dgCALLS"
        Me.dgCALLS.ReadOnly = True
        Me.dgCALLS.Size = New System.Drawing.Size(199, 48)
        Me.dgCALLS.TabIndex = 134
        Me.dgCALLS.TabStop = False
        '
        'gbRezultat
        '
        Me.gbRezultat.Controls.Add(Me.nizpamti98)
        Me.gbRezultat.Controls.Add(Me.pamti98)
        Me.gbRezultat.Controls.Add(Me.rb98)
        Me.gbRezultat.Controls.Add(Me.llPZ1)
        Me.gbRezultat.Controls.Add(Me.cbST)
        Me.gbRezultat.Controls.Add(Me.llPregledEmail)
        Me.gbRezultat.Controls.Add(Me.llZakazani)
        Me.gbRezultat.Controls.Add(Me.rb14)
        Me.gbRezultat.Controls.Add(Me.rb71)
        Me.gbRezultat.Controls.Add(Me.llNBS)
        Me.gbRezultat.Controls.Add(Me.llAPR)
        Me.gbRezultat.Controls.Add(Me.LLBeleStrane)
        Me.gbRezultat.Controls.Add(Me.rb99)
        Me.gbRezultat.Controls.Add(Me.llEMAIL)
        Me.gbRezultat.Controls.Add(Me.txtEMAIL)
        Me.gbRezultat.Controls.Add(Me.cboHour)
        Me.gbRezultat.Controls.Add(Me.dtp2)
        Me.gbRezultat.Controls.Add(Me.rb6)
        Me.gbRezultat.Controls.Add(Me.rb12)
        Me.gbRezultat.Controls.Add(Me.rb11)
        Me.gbRezultat.Controls.Add(Me.rb10)
        Me.gbRezultat.Controls.Add(Me.rb9)
        Me.gbRezultat.Controls.Add(Me.rb8)
        Me.gbRezultat.Controls.Add(Me.txtMM)
        Me.gbRezultat.Controls.Add(Me.rb5)
        Me.gbRezultat.Controls.Add(Me.rb4)
        Me.gbRezultat.Controls.Add(Me.rb7)
        Me.gbRezultat.Controls.Add(Me.rb3)
        Me.gbRezultat.Controls.Add(Me.rb2)
        Me.gbRezultat.Controls.Add(Me.rb16)
        Me.gbRezultat.Controls.Add(Me.rb1)
        Me.gbRezultat.Controls.Add(Me.llPZ)
        Me.gbRezultat.Controls.Add(Me.llRZ)
        Me.gbRezultat.Location = New System.Drawing.Point(8, 35)
        Me.gbRezultat.Name = "gbRezultat"
        Me.gbRezultat.Size = New System.Drawing.Size(845, 192)
        Me.gbRezultat.TabIndex = 133
        Me.gbRezultat.TabStop = False
        Me.gbRezultat.Text = "Rezultat"
        '
        'nizpamti98
        '
        Me.nizpamti98.AcceptsReturn = True
        Me.nizpamti98.BackColor = System.Drawing.SystemColors.Control
        Me.nizpamti98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nizpamti98.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.nizpamti98.Location = New System.Drawing.Point(245, 107)
        Me.nizpamti98.MaxLength = 1
        Me.nizpamti98.Name = "nizpamti98"
        Me.nizpamti98.Size = New System.Drawing.Size(26, 22)
        Me.nizpamti98.TabIndex = 10000029
        Me.nizpamti98.Visible = False
        '
        'pamti98
        '
        Me.pamti98.AcceptsReturn = True
        Me.pamti98.BackColor = System.Drawing.SystemColors.Control
        Me.pamti98.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pamti98.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.pamti98.Location = New System.Drawing.Point(245, 44)
        Me.pamti98.MaxLength = 1
        Me.pamti98.Name = "pamti98"
        Me.pamti98.Size = New System.Drawing.Size(26, 22)
        Me.pamti98.TabIndex = 10000018
        Me.pamti98.Visible = False
        '
        'rb98
        '
        Me.rb98.AutoEllipsis = True
        Me.rb98.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb98.Location = New System.Drawing.Point(615, 124)
        Me.rb98.Name = "rb98"
        Me.rb98.Size = New System.Drawing.Size(180, 24)
        Me.rb98.TabIndex = 10000028
        Me.rb98.Text = "98 Sledeći stratum"
        Me.rb98.Visible = False
        '
        'llPZ1
        '
        Me.llPZ1.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.llPZ1.AutoEllipsis = True
        Me.llPZ1.AutoSize = True
        Me.llPZ1.BackColor = System.Drawing.Color.Transparent
        Me.llPZ1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llPZ1.LinkColor = System.Drawing.Color.RoyalBlue
        Me.llPZ1.Location = New System.Drawing.Point(658, 46)
        Me.llPZ1.Name = "llPZ1"
        Me.llPZ1.Size = New System.Drawing.Size(87, 13)
        Me.llPZ1.TabIndex = 10000027
        Me.llPZ1.TabStop = True
        Me.llPZ1.Tag = ""
        Me.llPZ1.Text = "Replacements"
        Me.llPZ1.Visible = False
        '
        'cbST
        '
        Me.cbST.AutoSize = True
        Me.cbST.Font = New System.Drawing.Font("Verdana", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cbST.Location = New System.Drawing.Point(2, 165)
        Me.cbST.Name = "cbST"
        Me.cbST.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbST.Size = New System.Drawing.Size(72, 14)
        Me.cbST.TabIndex = 10000025
        Me.cbST.Text = "ceo stratum"
        Me.cbST.UseVisualStyleBackColor = True
        Me.cbST.Visible = False
        '
        'llPregledEmail
        '
        Me.llPregledEmail.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.llPregledEmail.AutoEllipsis = True
        Me.llPregledEmail.AutoSize = True
        Me.llPregledEmail.BackColor = System.Drawing.Color.Transparent
        Me.llPregledEmail.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llPregledEmail.LinkColor = System.Drawing.Color.RoyalBlue
        Me.llPregledEmail.Location = New System.Drawing.Point(794, 130)
        Me.llPregledEmail.Name = "llPregledEmail"
        Me.llPregledEmail.Size = New System.Drawing.Size(44, 13)
        Me.llPregledEmail.TabIndex = 10000022
        Me.llPregledEmail.TabStop = True
        Me.llPregledEmail.Tag = ""
        Me.llPregledEmail.Text = "Emails"
        '
        'llZakazani
        '
        Me.llZakazani.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.llZakazani.AutoEllipsis = True
        Me.llZakazani.AutoSize = True
        Me.llZakazani.BackColor = System.Drawing.Color.Transparent
        Me.llZakazani.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llZakazani.LinkColor = System.Drawing.Color.RoyalBlue
        Me.llZakazani.Location = New System.Drawing.Point(751, 11)
        Me.llZakazani.Name = "llZakazani"
        Me.llZakazani.Size = New System.Drawing.Size(30, 13)
        Me.llZakazani.TabIndex = 10000021
        Me.llZakazani.TabStop = True
        Me.llZakazani.Tag = ""
        Me.llZakazani.Text = "..6.."
        '
        'rb14
        '
        Me.rb14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb14.Location = New System.Drawing.Point(552, 124)
        Me.rb14.Name = "rb14"
        Me.rb14.Size = New System.Drawing.Size(156, 24)
        Me.rb14.TabIndex = 10000020
        Me.rb14.Text = "14 Primljen email "
        '
        'rb71
        '
        Me.rb71.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb71.Location = New System.Drawing.Point(364, 46)
        Me.rb71.Name = "rb71"
        Me.rb71.Size = New System.Drawing.Size(311, 24)
        Me.rb71.TabIndex = 10000018
        Me.rb71.Text = "71 Ažuriranje broja (telefon tačan)"
        '
        'llNBS
        '
        Me.llNBS.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.llNBS.AutoEllipsis = True
        Me.llNBS.AutoSize = True
        Me.llNBS.BackColor = System.Drawing.Color.Transparent
        Me.llNBS.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llNBS.LinkColor = System.Drawing.Color.RoyalBlue
        Me.llNBS.Location = New System.Drawing.Point(751, 66)
        Me.llNBS.Name = "llNBS"
        Me.llNBS.Size = New System.Drawing.Size(31, 13)
        Me.llNBS.TabIndex = 10000017
        Me.llNBS.TabStop = True
        Me.llNBS.Tag = "nediraj"
        Me.llNBS.Text = "NBS"
        '
        'llAPR
        '
        Me.llAPR.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.llAPR.AutoEllipsis = True
        Me.llAPR.AutoSize = True
        Me.llAPR.BackColor = System.Drawing.Color.Transparent
        Me.llAPR.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llAPR.LinkColor = System.Drawing.Color.RoyalBlue
        Me.llAPR.Location = New System.Drawing.Point(751, 47)
        Me.llAPR.Name = "llAPR"
        Me.llAPR.Size = New System.Drawing.Size(30, 13)
        Me.llAPR.TabIndex = 10000016
        Me.llAPR.TabStop = True
        Me.llAPR.Tag = "nediraj"
        Me.llAPR.Text = "APR"
        '
        'LLBeleStrane
        '
        Me.LLBeleStrane.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.LLBeleStrane.AutoEllipsis = True
        Me.LLBeleStrane.AutoSize = True
        Me.LLBeleStrane.BackColor = System.Drawing.Color.Transparent
        Me.LLBeleStrane.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LLBeleStrane.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LLBeleStrane.Location = New System.Drawing.Point(751, 28)
        Me.LLBeleStrane.Name = "LLBeleStrane"
        Me.LLBeleStrane.Size = New System.Drawing.Size(72, 13)
        Me.LLBeleStrane.TabIndex = 10000015
        Me.LLBeleStrane.TabStop = True
        Me.LLBeleStrane.Tag = "nediraj"
        Me.LLBeleStrane.Text = "Bele strane"
        '
        'rb99
        '
        Me.rb99.AutoEllipsis = True
        Me.rb99.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb99.Location = New System.Drawing.Point(552, 145)
        Me.rb99.Name = "rb99"
        Me.rb99.Size = New System.Drawing.Size(243, 24)
        Me.rb99.TabIndex = 10000014
        Me.rb99.Text = "99 Sledeći telefon iz adresara"
        '
        'llEMAIL
        '
        Me.llEMAIL.AutoSize = True
        Me.llEMAIL.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llEMAIL.Location = New System.Drawing.Point(699, 80)
        Me.llEMAIL.Name = "llEMAIL"
        Me.llEMAIL.Size = New System.Drawing.Size(44, 14)
        Me.llEMAIL.TabIndex = 10000013
        Me.llEMAIL.TabStop = True
        Me.llEMAIL.Text = "SEND"
        Me.llEMAIL.Visible = False
        '
        'txtEMAIL
        '
        Me.txtEMAIL.Location = New System.Drawing.Point(552, 99)
        Me.txtEMAIL.Name = "txtEMAIL"
        Me.txtEMAIL.Size = New System.Drawing.Size(246, 22)
        Me.txtEMAIL.TabIndex = 10000012
        Me.txtEMAIL.Visible = False
        '
        'cboHour
        '
        Me.cboHour.FormattingEnabled = True
        Me.cboHour.Location = New System.Drawing.Point(277, 148)
        Me.cboHour.Name = "cboHour"
        Me.cboHour.Size = New System.Drawing.Size(73, 22)
        Me.cboHour.TabIndex = 153
        Me.cboHour.Visible = False
        '
        'dtp2
        '
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(159, 148)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(112, 22)
        Me.dtp2.TabIndex = 152
        Me.dtp2.Visible = False
        '
        'rb6
        '
        Me.rb6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb6.Location = New System.Drawing.Point(8, 143)
        Me.rb6.Name = "rb6"
        Me.rb6.Size = New System.Drawing.Size(163, 24)
        Me.rb6.TabIndex = 151
        Me.rb6.Text = "6 Zakazan razgovor"
        '
        'rb12
        '
        Me.rb12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb12.Location = New System.Drawing.Point(552, 75)
        Me.rb12.Name = "rb12"
        Me.rb12.Size = New System.Drawing.Size(135, 24)
        Me.rb12.TabIndex = 149
        Me.rb12.Text = "12 Poslat email "
        '
        'rb11
        '
        Me.rb11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb11.Location = New System.Drawing.Point(364, 143)
        Me.rb11.Name = "rb11"
        Me.rb11.Size = New System.Drawing.Size(176, 24)
        Me.rb11.TabIndex = 148
        Me.rb11.Text = "11 Netačna delatnost "
        '
        'rb10
        '
        Me.rb10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb10.Location = New System.Drawing.Point(364, 118)
        Me.rb10.Name = "rb10"
        Me.rb10.Size = New System.Drawing.Size(225, 24)
        Me.rb10.TabIndex = 147
        Me.rb10.Text = "10 Stečaj/likvidacija"
        '
        'rb9
        '
        Me.rb9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb9.Location = New System.Drawing.Point(364, 94)
        Me.rb9.Name = "rb9"
        Me.rb9.Size = New System.Drawing.Size(221, 24)
        Me.rb9.TabIndex = 146
        Me.rb9.Text = "9 Miruje/ne posluje"
        '
        'rb8
        '
        Me.rb8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb8.Location = New System.Drawing.Point(364, 70)
        Me.rb8.Name = "rb8"
        Me.rb8.Size = New System.Drawing.Size(224, 24)
        Me.rb8.TabIndex = 145
        Me.rb8.Text = "8 Zatvoreno/ugašeno"
        '
        'txtMM
        '
        Me.txtMM.AcceptsReturn = True
        Me.txtMM.BackColor = System.Drawing.SystemColors.Control
        Me.txtMM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMM.Enabled = False
        Me.txtMM.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.txtMM.Location = New System.Drawing.Point(129, 114)
        Me.txtMM.MaxLength = 2
        Me.txtMM.Name = "txtMM"
        Me.txtMM.Size = New System.Drawing.Size(42, 15)
        Me.txtMM.TabIndex = 132
        '
        'rb5
        '
        Me.rb5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb5.Location = New System.Drawing.Point(8, 118)
        Me.rb5.Name = "rb5"
        Me.rb5.Size = New System.Drawing.Size(314, 24)
        Me.rb5.TabIndex = 129
        Me.rb5.Text = "5 Ne javlja se"
        '
        'rb4
        '
        Me.rb4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb4.Location = New System.Drawing.Point(8, 94)
        Me.rb4.Name = "rb4"
        Me.rb4.Size = New System.Drawing.Size(314, 24)
        Me.rb4.TabIndex = 128
        Me.rb4.Text = "4 Zauzet"
        '
        'rb7
        '
        Me.rb7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb7.Location = New System.Drawing.Point(364, 22)
        Me.rb7.Name = "rb7"
        Me.rb7.Size = New System.Drawing.Size(297, 24)
        Me.rb7.TabIndex = 127
        Me.rb7.Text = "7 Neispravan broj (telefon netačan)"
        '
        'rb3
        '
        Me.rb3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb3.Location = New System.Drawing.Point(8, 70)
        Me.rb3.Name = "rb3"
        Me.rb3.Size = New System.Drawing.Size(314, 24)
        Me.rb3.TabIndex = 119
        Me.rb3.Text = "3 Prekinut, zvati odmah"
        '
        'rb2
        '
        Me.rb2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb2.Location = New System.Drawing.Point(8, 46)
        Me.rb2.Name = "rb2"
        Me.rb2.Size = New System.Drawing.Size(314, 24)
        Me.rb2.TabIndex = 118
        Me.rb2.Text = "2 Odbilo da učestvuje u anketi"
        '
        'rb16
        '
        Me.rb16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb16.Location = New System.Drawing.Point(364, 165)
        Me.rb16.Name = "rb16"
        Me.rb16.Size = New System.Drawing.Size(320, 24)
        Me.rb16.TabIndex = 154
        Me.rb16.Text = "16 Nije moguće uspostaviti kontakt"
        '
        'rb1
        '
        Me.rb1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.rb1.Location = New System.Drawing.Point(8, 22)
        Me.rb1.Name = "rb1"
        Me.rb1.Size = New System.Drawing.Size(314, 24)
        Me.rb1.TabIndex = 116
        Me.rb1.Text = "1 Učestvuje u anketi"
        '
        'llPZ
        '
        Me.llPZ.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.llPZ.AutoEllipsis = True
        Me.llPZ.AutoSize = True
        Me.llPZ.BackColor = System.Drawing.Color.Transparent
        Me.llPZ.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llPZ.LinkColor = System.Drawing.Color.RoyalBlue
        Me.llPZ.Location = New System.Drawing.Point(751, 47)
        Me.llPZ.Name = "llPZ"
        Me.llPZ.Size = New System.Drawing.Size(87, 13)
        Me.llPZ.TabIndex = 10000024
        Me.llPZ.TabStop = True
        Me.llPZ.Tag = ""
        Me.llPZ.Text = "Replacements"
        Me.llPZ.Visible = False
        '
        'llRZ
        '
        Me.llRZ.ActiveLinkColor = System.Drawing.Color.RoyalBlue
        Me.llRZ.AutoEllipsis = True
        Me.llRZ.AutoSize = True
        Me.llRZ.BackColor = System.Drawing.Color.Transparent
        Me.llRZ.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.llRZ.LinkColor = System.Drawing.Color.RoyalBlue
        Me.llRZ.Location = New System.Drawing.Point(752, 66)
        Me.llRZ.Name = "llRZ"
        Me.llRZ.Size = New System.Drawing.Size(103, 13)
        Me.llRZ.TabIndex = 10000026
        Me.llRZ.TabStop = True
        Me.llRZ.Tag = ""
        Me.llRZ.Text = "Calls for stratum"
        Me.llRZ.Visible = False
        '
        'btnCCall
        '
        Me.btnCCall.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCCall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCCall.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnCCall.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCCall.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btnCCall.Location = New System.Drawing.Point(350, 8)
        Me.btnCCall.Name = "btnCCall"
        Me.btnCCall.Size = New System.Drawing.Size(127, 22)
        Me.btnCCall.TabIndex = 138
        Me.btnCCall.Text = "Pozovi"
        Me.btnCCall.UseVisualStyleBackColor = False
        '
        'lblC
        '
        Me.lblC.AcceptsReturn = True
        Me.lblC.BackColor = System.Drawing.SystemColors.Control
        Me.lblC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblC.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.lblC.Location = New System.Drawing.Point(87, 538)
        Me.lblC.MaxLength = 1
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(24, 22)
        Me.lblC.TabIndex = 145
        Me.lblC.Visible = False
        '
        'txtInstrukcije
        '
        Me.txtInstrukcije.BackColor = System.Drawing.SystemColors.Control
        Me.txtInstrukcije.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInstrukcije.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.txtInstrukcije.ForeColor = System.Drawing.Color.Red
        Me.txtInstrukcije.Location = New System.Drawing.Point(140, 10)
        Me.txtInstrukcije.Multiline = True
        Me.txtInstrukcije.Name = "txtInstrukcije"
        Me.txtInstrukcije.ReadOnly = True
        Me.txtInstrukcije.Size = New System.Drawing.Size(1365, 68)
        Me.txtInstrukcije.TabIndex = 137
        Me.txtInstrukcije.TabStop = False
        '
        'panelEmails
        '
        Me.panelEmails.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelEmails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelEmails.Controls.Add(Me.dgv)
        Me.panelEmails.Controls.Add(Me.ButtonClose)
        Me.panelEmails.Location = New System.Drawing.Point(29, 573)
        Me.panelEmails.Name = "panelEmails"
        Me.panelEmails.Size = New System.Drawing.Size(411, 219)
        Me.panelEmails.TabIndex = 10000052
        Me.panelEmails.Visible = False
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.GridColor = System.Drawing.Color.DarkGray
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgv.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.RowTemplate.Height = 25
        Me.dgv.Size = New System.Drawing.Size(409, 211)
        Me.dgv.TabIndex = 10000055
        '
        'ButtonClose
        '
        Me.ButtonClose.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonClose.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonClose.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonClose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonClose.Location = New System.Drawing.Point(0, 211)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(409, 6)
        Me.ButtonClose.TabIndex = 10000054
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = False
        '
        'panelpregledZamena
        '
        Me.panelpregledZamena.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelpregledZamena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpregledZamena.Controls.Add(Me.dgvPZ)
        Me.panelpregledZamena.Controls.Add(Me.ButtonClosePZ)
        Me.panelpregledZamena.Location = New System.Drawing.Point(30, 332)
        Me.panelpregledZamena.Name = "panelpregledZamena"
        Me.panelpregledZamena.Size = New System.Drawing.Size(411, 219)
        Me.panelpregledZamena.TabIndex = 10000053
        Me.panelpregledZamena.Visible = False
        '
        'dgvPZ
        '
        Me.dgvPZ.AllowUserToAddRows = False
        Me.dgvPZ.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPZ.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPZ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPZ.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPZ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPZ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPZ.GridColor = System.Drawing.Color.DarkGray
        Me.dgvPZ.Location = New System.Drawing.Point(0, 0)
        Me.dgvPZ.Name = "dgvPZ"
        Me.dgvPZ.ReadOnly = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.dgvPZ.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvPZ.RowTemplate.Height = 25
        Me.dgvPZ.Size = New System.Drawing.Size(409, 211)
        Me.dgvPZ.TabIndex = 10000055
        '
        'ButtonClosePZ
        '
        Me.ButtonClosePZ.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonClosePZ.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonClosePZ.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonClosePZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonClosePZ.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonClosePZ.Location = New System.Drawing.Point(0, 211)
        Me.ButtonClosePZ.Name = "ButtonClosePZ"
        Me.ButtonClosePZ.Size = New System.Drawing.Size(409, 6)
        Me.ButtonClosePZ.TabIndex = 10000054
        Me.ButtonClosePZ.Text = "Close"
        Me.ButtonClosePZ.UseVisualStyleBackColor = False
        '
        'panelpregledPozivaZamena
        '
        Me.panelpregledPozivaZamena.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelpregledPozivaZamena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelpregledPozivaZamena.Controls.Add(Me.dgvRZ)
        Me.panelpregledPozivaZamena.Controls.Add(Me.ButtonCloseRZ)
        Me.panelpregledPozivaZamena.Location = New System.Drawing.Point(172, 274)
        Me.panelpregledPozivaZamena.Name = "panelpregledPozivaZamena"
        Me.panelpregledPozivaZamena.Size = New System.Drawing.Size(411, 219)
        Me.panelpregledPozivaZamena.TabIndex = 10000054
        Me.panelpregledPozivaZamena.Visible = False
        '
        'dgvRZ
        '
        Me.dgvRZ.AllowUserToAddRows = False
        Me.dgvRZ.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Beige
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRZ.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRZ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRZ.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvRZ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRZ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRZ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRZ.GridColor = System.Drawing.Color.DarkGray
        Me.dgvRZ.Location = New System.Drawing.Point(0, 0)
        Me.dgvRZ.Name = "dgvRZ"
        Me.dgvRZ.ReadOnly = True
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Bisque
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dgvRZ.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvRZ.RowTemplate.Height = 25
        Me.dgvRZ.Size = New System.Drawing.Size(409, 211)
        Me.dgvRZ.TabIndex = 10000055
        '
        'ButtonCloseRZ
        '
        Me.ButtonCloseRZ.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCloseRZ.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonCloseRZ.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.ButtonCloseRZ.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCloseRZ.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ButtonCloseRZ.Location = New System.Drawing.Point(0, 211)
        Me.ButtonCloseRZ.Name = "ButtonCloseRZ"
        Me.ButtonCloseRZ.Size = New System.Drawing.Size(409, 6)
        Me.ButtonCloseRZ.TabIndex = 10000054
        Me.ButtonCloseRZ.Text = "Close"
        Me.ButtonCloseRZ.UseVisualStyleBackColor = False
        '
        'FormCATI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1284, 749)
        Me.Controls.Add(Me.panelpregledPozivaZamena)
        Me.Controls.Add(Me.panelpregledZamena)
        Me.Controls.Add(Me.panelEmails)
        Me.Controls.Add(Me.panel2)
        Me.Controls.Add(Me.btnCIzlaz)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblNaziv)
        Me.Controls.Add(Me.GBGODC)
        Me.Controls.Add(Me.txtInstrukcije)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        
        Me.Name = "FormCATI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CATI - "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBGODC.ResumeLayout(False)
        Me.GBGODC.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.dgHistory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCALLS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRezultat.ResumeLayout(False)
        Me.gbRezultat.PerformLayout()
        Me.panelEmails.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelpregledZamena.ResumeLayout(False)
        CType(Me.dgvPZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelpregledPozivaZamena.ResumeLayout(False)
        CType(Me.dgvRZ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "raznorazno"


    Private Function razCASTi(ByVal s As String, Optional ByVal tabela As String = "") As String

        Dim kk() As String = razkvantaj(s)
        Dim trt As String = ""
        Dim i As Integer = 0
        While i <= kk.GetUpperBound(0)
            If kk(i).Trim = "CAST" Or kk(i).Trim = "CHARINDEX" Or kk(i).Trim = "INSTR" Or kk(i).Trim = "ISDATE" Or
            kk(i).Trim = "ISNUMERIC" Or kk(i).Trim = "LTRIM" Or kk(i).Trim = "RTRIM" Or kk(i).Trim = "LEFT" Or
            kk(i).Trim = "RIGHT" Or kk(i).Trim = "LEN" Or kk(i).Trim = "FLOOR" Then
                Dim brz As Integer = 1 : Dim pC As Integer = i + 2 : Dim kC As Integer = 0
                Dim Fja As String = kk(i).Trim
                Dim ZnakRazdvajanja As String = IIf(kk(i).Trim = "CAST", "AS", ",")
                i += 1
                While brz > 0
                    i += 1
                    If kk(i) = "(" Then brz += 1
                    If kk(i) = ")" Then brz -= 1
                    If kk(i) = ZnakRazdvajanja Then kC = i - 1 'If kk(i) = "AS" Then kC = i - 1
                End While

                Dim frazla As String = ""
                Dim drugiP As String = ""
                Dim parm As Integer = 0
                Select Case Fja
                    Case "CAST", "INSTR" '1-vi parametar
                        frazla = ustringaj(kk, pC, kC).ToUpper
                    Case "CHARINDEX" '2-gi parametar
                        frazla = ustringaj(kk, kC + 2, i - 1)
                    Case "LEFT", "RIGHT" '1 i 2-gi parametar
                        frazla = ustringaj(kk, pC, kC).ToUpper
                        drugiP = ustringaj(kk, kC + 2, i - 1)
                        parm = CType(drugiP, Int32)
                    Case "ISDATE" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "ISNUMERIC" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "RTRIM" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "LTRIM" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "LEN" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                    Case "FLOOR" 'samo 1 parametar
                        frazla = ustringaj(kk, pC, i - 1)
                End Select
                If frazla.IndexOf("CAST") >= 0 Or frazla.IndexOf("CHARINDEX") >= 0 Or
                frazla.IndexOf("INSTR") >= 0 Or frazla.IndexOf("ISDATE") >= 0 Or
                frazla.IndexOf("ISNUMERIC") >= 0 Or frazla.IndexOf("LTRIM") >= 0 Or
                frazla.IndexOf("RTRIM") >= 0 Or frazla.IndexOf("LEFT") >= 0 Or
                frazla.IndexOf("RIGHT") >= 0 Or frazla.IndexOf("LEN") >= 0 Or
                frazla.IndexOf("FLOOR") >= 0 Then
                    frazla = razCASTi(frazla)
                End If

                Dim pomkol As New System.Data.DataColumn("pomKol")
                pomkol.Expression = frazla
                Dim mrt As Object = Nothing
                'ako je stiglo iz panela ima kao parametar i tabelu
                If tabela.Length > 0 Then
                    'panel
                Else
                    DGTabele(0).Columns.Add(pomkol)
                    mrt = NZ(DGTabele(0).Compute("MAX(pomKol)", ""))
                    DGTabele(0).Columns.Remove(pomkol)
                End If
                Dim bezNavodnika As String = Replace(Replace(kk(pC), "'", ""), """", "")
                Select Case Fja
                    Case "CAST"
                        Select Case kk(kC + 2)
                            Case "DATE", "DATETIME", "CHAR", "STRING"
                                mrt = "'" & CType(mrt, System.String).Trim & "'"
                            Case "INT", "INTEGER", "DOUBLE", "REAL", "FLOAT", "DECIMAL", "NUMBER"
                                If mrt.GetType Is GetType(System.DBNull) OrElse
                                CType(mrt, System.String).Trim = "" OrElse
                                IsNumeric(mrt) = False Then mrt = "0"
                            Case Else
                        End Select
                    Case "CHARINDEX"
                        mrt = InStr(mrt, bezNavodnika)
                    Case "INSTR"
                        mrt = InStr(bezNavodnika, mrt)
                    Case "ISDATE"
                        If IsDate(mrt) Then mrt = " 2=3 " Else mrt = " 2=2 "
                    Case "ISNUMERIC"
                        If IsNumeric(mrt) = True Then
                            mrt = " 2=2 "
                        Else
                            mrt = " 2=3 "
                        End If
                    Case "LTRIM"
                        mrt = "'" & CType(mrt, System.String).Trim & "'"
                    Case "RTRIM"
                        mrt = "'" & CType(mrt, System.String).Trim & "'"
                    Case "LEN"
                        mrt = "'" & CType(mrt, System.String).Trim.Length & "'"
                    Case "FLOOR"
                        If mrt.GetType Is GetType(System.DBNull) OrElse CType(mrt, System.String).Trim = "" OrElse IsNumeric(mrt) = False Then
                            mrt = "0"
                        Else
                            'mrt je the largest integer less than or equal
                            mrt = CType(mrt, Double)
                            mrt = Math.Floor(mrt)
                        End If
                        'mrt = "'" & CType(mrt, System.String).Trim & "'"
                    Case "LEFT"
                        If mrt.trim.length >= parm Then
                            mrt = "'" & mrt.Substring(0, parm).ToString.Trim.ToUpper & "'"
                        Else
                            mrt = "'" & mrt.trim & "'"
                        End If
                    Case "RIGHT"
                        If mrt.trim.length >= parm Then
                            mrt = "'" & mrt.substring(mrt.trim.length - parm) & "'"
                        Else
                            mrt = "'" & mrt.trim & "'"
                        End If
                End Select
                trt = trt + " " & mrt
            Else
                trt = trt + " " & kk(i)
            End If
            trt = trt.Replace(" ' ", "'")
            i = i + 1
        End While
        Return trt
    End Function

    Public nizFP() As System.Windows.Forms.Control
    Public nizFPPK() As System.Windows.Forms.Control
    Public nizFPnPK() As System.Windows.Forms.Control
    Public nizFPMEM() As System.Windows.Forms.Control

    Private Sub DodajFalsove(ByVal red As DataRow, Optional ByVal iPolja As Boolean = False, Optional ByVal iSlog As Boolean = False, Optional ByVal koja As String = "")
        If koja = "FPPK" AndAlso Not (nizFPPK Is Nothing) Then
            For i As Integer = 0 To nizFPPK.GetUpperBound(0)
                dodajFalsovePom(red, nizFPPK(i), iPolja, iSlog)
            Next
        End If
        If koja = "FPnPK" AndAlso Not (nizFPnPK Is Nothing) Then
            For i As Integer = 0 To nizFPnPK.GetUpperBound(0)
                dodajFalsovePom(red, nizFPnPK(i), iPolja, iSlog)
            Next
        End If
        If koja = "FPMEM" AndAlso Not (nizFPMEM Is Nothing) Then
            For i As Integer = 0 To nizFPMEM.GetUpperBound(0)
                dodajFalsovePom(red, nizFPMEM(i), iPolja, iSlog)
            Next
        End If
        If koja = "" AndAlso Not (nizFP Is Nothing) Then
            For i As Integer = 0 To nizFP.GetUpperBound(0)
                dodajFalsovePom(red, nizFP(i), iPolja, iSlog)
            Next
        End If
    End Sub

    Private DGTabele() As System.Data.DataTable = {} 'u ovaj se "unosi"

    Private Sub NapraviDGTabele(ByVal adresar As String)

        ReDim Me.DGTabele(-1)

        Dim i As Integer = Me.DGTabele.GetUpperBound(0) + 1
        ReDim Preserve Me.DGTabele(i)
        Dim sql As String = "select * from " & adresar & " where 2=3"
        Me.DGTabele(i) = New System.Data.DataTable
        Try
            Me.DGTabele(i) = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
            Me.DGTabele(i).TableName = adresar
        Finally
        End Try
        For Each c As System.Data.DataColumn In Me.DGTabele(i).Columns
            If c.DataType.Name.ToUpper = "BOOLEAN" Then
                c.DataType = GetType(System.Int16)
            End If
        Next
    End Sub

    Private Sub dodajFalsovePom(ByVal red As DataRow, ByVal k As System.Windows.Forms.Control, ByVal iPolja As Boolean, ByVal iSlog As Boolean)
        Dim tabela As String = adresarCati
        k.Tag.izraz = SrediPMGK(k.Tag.izraz)
        'zamena GGGMMM
        Dim sql As String
        sql = k.Tag.izraz
        sql = strrpl(sql, "{GGG}", "'" + tacv.G.ToString + "'")
        sql = strrpl(sql, "{MMM}", "'" + String.Format("{0:d2}", Me.tacv.M) + "'")
        sql = strrpl(sql, "{YYY}", "'" + tacv.G.ToString + "'")

        sql = GGMMGoreDole(sql, Me.tacv.G, tacv.M)
        sql = strrpl(sql, "VRTACKA", Me.tacv.vtwhere(""))
        sql = strrpl(sql, "GGG", Me.tacv.GWhere(""))
        sql = strrpl(sql, "MMM", Me.tacv.mWhere(""))
        sql = strrpl(sql, "YYY", Me.tacv.YWhere(""))

        sql = sql.Replace(ChrW(26), "")
        k.Tag.izraz = sql
        ''''
        If k.Tag.rel(0) = "#" AndAlso (CStr(k.Tag.izraz).Trim.ToUpper.IndexOf("SELECT ") >= 0 OrElse CStr(k.Tag.izraz).Trim.ToUpper.IndexOf("DBO.F_") >= 0) Then 'ovde bi trebao upitic...
            'ovi ne idu uvek. Za sada S u tag.rel(1) oznacava da se menja samo kad se ceo slog ucitava, a
            'P [polje] kad se promeni polje, jedino sto nikako ne mogu znati da se neko polje promenilo. Ili...
            If (k.Tag.rel(1) Is Nothing) OrElse (k.Tag.rel(1).trim <> "P" And k.Tag.rel(1).trim <> "S") OrElse (k.Tag.rel(1).trim = "P" And iPolja) OrElse (k.Tag.rel(1).trim = "S" And iSlog) Then 'ovo ne valja....
                Dim zzz As String = k.Tag.Izraz.ToString.Trim
                ''FP
                If CStr(zzz).Trim.ToUpper.IndexOf("#FP{") >= 0 Then
                    Dim bbb() As String = razkvantaj(k.Tag.izraz)
                    For mm As Integer = 0 To bbb.GetUpperBound(0)
                        If bbb(mm).Trim.IndexOf("#FP{") = 0 Then
                            'sa ekrana pokupi fiktivno polje
                            Dim FPtrt As String = bbb(mm).Replace("#FP{", "").ToString.Trim
                            FPtrt = FPtrt.Replace("}", "")
                            If IsNumeric(FPtrt) Then
                                bbb(mm) = "" + SE(FPtrt, True).Trim + ""
                            Else
                                bbb(mm) = "'" + SE(FPtrt, True).Trim + "'"
                            End If
                        End If
                    Next
                    Dim zzz1 As String = ustringaj(bbb).ToUpper
                    zzz1 = razCASTi(zzz1)
                    zzz = zzz1

                End If
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            End If 'uslovi
        Else
            If CStr(k.Tag.Izraz).Trim.ToUpper.IndexOf("CASE ") >= 0 Then
                k.Tag.Izraz = CASE2IIF(CStr(k.Tag.izraz).Trim.ToUpper.Replace("D.", ""))
            End If

            Dim zzz As String = k.Tag.Izraz.ToString.Trim
            ''FP
            If CStr(zzz).Trim.ToUpper.IndexOf("#FP{") >= 0 Then
                Dim bbb() As String = razkvantaj(k.Tag.izraz)
                For mm As Integer = 0 To bbb.GetUpperBound(0)
                    If bbb(mm).Trim.IndexOf("#FP{") = 0 Then
                        'saekrana pokupi fiktivno polje
                        Dim FPtrt As String = bbb(mm).Replace("#FP{", "").ToString.Trim
                        FPtrt = FPtrt.Replace("}", "")
                        If IsNumeric(FPtrt) Then
                            bbb(mm) = "" + SE(FPtrt, True).Trim + ""
                        Else
                            bbb(mm) = "'" + SE(FPtrt, True).Trim + "'"
                        End If
                    End If
                Next
                Dim zzz1 As String = ustringaj(bbb).ToUpper
                zzz1 = razCASTi(zzz1)
                zzz = zzz1
            End If
            ''
            If CStr(zzz).Trim.ToUpper.IndexOf("POWER") >= 0 Or CStr(zzz).Trim.ToUpper.IndexOf("ROUND") >= 0 Then
                Dim x1 As Integer
                Dim PozZarez As Integer
                Dim Fja As String
                If CStr(zzz).Trim.ToUpper.IndexOf("POWER") >= 0 Then
                    x1 = CStr(zzz).ToUpper.IndexOf("POWER") + 5
                    PozZarez = GdeJeZarez(zzz, "POWER")
                    Fja = "POWER"
                Else
                    x1 = CStr(zzz).ToUpper.IndexOf("ROUND") + 5
                    PozZarez = GdeJeZarez(zzz, "ROUND")
                    Fja = "ROUND"
                End If
                Dim par1 As String = CStr(zzz).Substring(x1, PozZarez - x1).Trim
                par1 = par1.Substring(1)
                Dim par2 As String = CStr(zzz).Substring(PozZarez + 1).Trim

                Dim brz As Integer = 0
                Dim KrajPar2 As Integer = Len(par2) - 1
                For ii As Integer = 1 To Len(par2)
                    If par2.Substring(ii, 1) = "(" Then brz += 1
                    If par2.Substring(ii, 1) = ")" Then brz -= 1
                    If brz = -1 Then
                        KrajPar2 = ii
                        Exit For
                    End If
                Next
                par2 = par2.Substring(0, KrajPar2)
                Dim pomkol1 As New System.Data.DataColumn("pomKol1")
                pomkol1.Expression = CStr(par1).Trim.ToUpper.Replace("D.", "")
                DGTabele(0).Columns.Add(pomkol1)
                Dim xxx1 = NZ(DGTabele(0).Compute("MAX(pomKol1)", ""))
                Dim pomkol2 As New System.Data.DataColumn("pomKol2")
                pomkol2.Expression = CStr(par2).Trim.ToUpper.Replace("D.", "")
                DGTabele(0).Columns.Add(pomkol2)
                Dim xxx2 = NZ(DGTabele(0).Compute("MAX(pomKol2)", ""))
                DGTabele(0).Columns.Remove(pomkol1)
                DGTabele(0).Columns.Remove(pomkol2)
                Select Case Fja
                    Case "POWER"
                        k.Text = CStr(CDbl(xxx1) ^ CDbl(xxx2)).Trim
                    Case "ROUND"
                        k.Text = CStr(Math.Round(CDbl(xxx1), CInt(xxx2))).Trim
                    Case Else
                End Select
            Else
                Try
                    Dim pomkol As New System.Data.DataColumn("pomKol")
                    If zzz.ToString.Trim.IndexOf("{") = 0 Then
                        Dim kojaTabela As String = ""
                        zzz = zzz.Replace("{", "")
                        zzz = zzz.Replace("}", "")
                        kojaTabela = zzz.Substring(0, zzz.IndexOf("."))
                        pomkol.Expression = zzz.Substring(zzz.IndexOf(".") + 1)
                        'za obicno ovako, za panele malo drugacije
                        k.Text = DGTabele(1).Rows(0).Item(pomkol.Expression)
                    Else
                        'da ne podiže slova na velika
                        'pomkol.Expression =  CStr(k.Tag.Izraz).ToUpper.Trim.Replace("D.", "")
                        'zamenjeno sa
                        zzz = zzz.Replace("D.", "")
                        zzz = zzz.Replace("d.", "")
                        pomkol.Expression = zzz
                        '''''
                        DGTabele(0).Columns.Add(pomkol)
                        Dim xxx As Object = NZ(DGTabele(0).Compute("MAX(pomKol)", ""))
                        DGTabele(0).Columns.Remove(pomkol)
                        k.Text = CStr(xxx).Trim
                    End If
                Catch ex As Exception
                    Beep()
                    k.Text = ""
                Finally
                End Try
            End If 'power
        End If
    End Sub

    Private Function SEK(ByVal polje As String) As String
        For Each k1 As System.Windows.Forms.Control In Me.Controls
            If Mid(k1.Name, 1, 2).Trim.ToUpper = "GB" Then
                For Each k As System.Windows.Forms.Control In k1.Controls
                    If Mid(k.Name, 1, 1) = "T" Then
                        If Mid(k.Name, 3).Trim.ToUpper = polje.Trim.ToUpper Then Return k.Text.Trim
                    End If
                    If Mid(k.Name, 1, 1) = "C" Then
                        If Mid(k.Name, 3).Trim.ToUpper = polje.Trim.ToUpper Then Return CType(k, System.Windows.Forms.ComboBox).SelectedValue
                    End If
                Next
            End If
        Next
        Return ""
    End Function

    Private Function SE(ByVal polje As String, Optional ByVal iFals As Boolean = False) As String
        For Each k As System.Windows.Forms.Control In Me.Panel1.Controls
            If Mid(k.Name, 1, 1) = "T" Then
                If Mid(k.Name, 3).Trim.ToUpper = polje.Trim.ToUpper Then Return k.Text.Trim
            End If
            If Mid(k.Name, 1, 1) = "C" Then
                If Mid(k.Name, 3).Trim.ToUpper = polje.Trim.ToUpper Then Return CType(k, System.Windows.Forms.ComboBox).SelectedValue
            End If
            If iFals Then
                If Mid(k.Name, 1, 2) = "FP" Then
                    If Mid(k.Name, 3).Trim.ToUpper = polje.Trim.ToUpper Then Return k.Text.Trim
                End If
            End If
        Next
        Return ""
    End Function

    Private Function GdeJeZarez(ByVal s As String, ByVal n As String) As Integer
        s = s.ToUpper '.Trim
        n = n.Trim.ToUpper
        Dim trt As Integer = 0
        Dim brz As Integer = 0
        Dim poc As Integer = InStr(s.Trim.ToUpper, n.Trim.ToUpper) + Len(n.Trim.ToUpper)
        For i As Integer = poc To Len(s)
            If Mid(s, i, 1) = "(" Then brz += 1
            If Mid(s, i, 1) = ")" Then brz -= 1
            If Mid(s, i, 1) = "," AndAlso brz = 1 Then
                Return i - 1
            End If
        Next
    End Function

    Private Function SrediPMGK(ByVal izr As String) As String
        While izr.IndexOf("PM.") >= 0
            Dim g As Integer = izr.IndexOf("PM.")
            Dim j As Integer = g + 3
            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
            Do While j <= izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                j += 1
                If j < izr.Length Then c = izr.Substring(j, 1).ToCharArray()(0)
            Loop
            Dim ostatak As String = ""
            If j < izr.Length Then ostatak = izr.Substring(j)
            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g), adresarCati.Trim) & ") " & ostatak
        End While

        While izr.IndexOf("PK.") >= 0
            Dim g As Integer = izr.IndexOf("PK.")
            Dim j As Integer = g + 3
            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
            Do While j <= izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                j += 1
                If j < izr.Length Then c = izr.Substring(j, 1).ToCharArray()(0)
            Loop
            Dim ostatak As String = ""
            If j < izr.Length Then ostatak = izr.Substring(j)
            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g), adresarCati.Trim) & ") " & ostatak
        End While

        While izr.IndexOf("PG.") >= 0
            Dim g As Integer = izr.IndexOf("PG.")
            Dim j As Integer = g + 3
            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
            Do While j <= izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                j += 1
                If j < izr.Length Then c = izr.Substring(j, 1).ToCharArray()(0)
            Loop
            Dim ostatak As String = ""
            If j < izr.Length Then ostatak = izr.Substring(j)
            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g), adresarCati.Trim) & ") " & ostatak
        End While

        While izr.IndexOf("PP.") >= 0
            Dim g As Integer = izr.IndexOf("PP.")
            Dim j As Integer = g + 3
            Dim c As Char = izr.Substring(j, 1).ToCharArray()(0)
            Do While j <= izr.Length - 1 AndAlso (Char.IsLetterOrDigit(c) Or c = "_")
                j += 1
                If j < izr.Length Then c = izr.Substring(j, 1).ToCharArray()(0)
            Loop
            Dim ostatak As String = ""
            If j < izr.Length Then ostatak = izr.Substring(j)
            izr = izr.Substring(0, g) & " (" & USelektajPM(izr.Substring(g, j - g), adresarCati.Trim) & ") " & ostatak
        End While

        Return izr
    End Function

    Private Function USelektajPM(ByVal s As String, ByVal t As String) As String
        Dim kljNiz() As String = {}
        Dim ImaM As Boolean = False
        Dim ImaME As Boolean = False
        Dim ImaKV As Boolean = False
        For Each r As DatasetIstrazivanja.ISTPOLJARow In istPolja
            If r.TABELA.Trim.ToUpper = t.Trim.ToUpper Then
                If Not r.IsKLJUCNull AndAlso r.KLJUC.Trim.ToUpper = "P" Then
                    If (r.POLJE.Trim.ToUpper = "MES") Then ImaM = True
                    If (r.POLJE.Trim.ToUpper = "ISTMONTH") Then ImaME = True
                    If r.POLJE.Trim.ToUpper <> "GOD" AndAlso r.POLJE.Trim.ToUpper <> "MES" _
                        AndAlso r.POLJE.Trim.ToUpper <> "ISTYEAR" AndAlso r.POLJE.Trim.ToUpper <> "ISTMONTH" Then
                        ReDim Preserve kljNiz(kljNiz.GetUpperBound(0) + 1)
                        kljNiz(kljNiz.GetUpperBound(0)) = r.POLJE.Trim.ToUpper
                    End If
                End If
            End If
        Next
        Dim trt As String = "SELECT "
        Dim n() As String = s.Split("."c)
        trt += n(1) & " FROM " & t & " P where "
        For i As Integer = 0 To kljNiz.GetUpperBound(0)
            trt += "P." & kljNiz(i) & " = D." & kljNiz(i) & " AND "
        Next

        Dim GG1 As String = CStr(Me.tacv.G - 1)
        Dim MM1 As String = CStr(Me.tacv.M - 1).Trim.PadLeft(2, "0"c)
        If Me.tacv.M = 1 Then MM1 = "12"
        Dim GGM1 As String = CStr(Me.tacv.G)
        If Me.tacv.M = 1 Then GGM1 = GG1
        Dim GGM3 As String = CStr(Me.tacv.G)
        If Me.tacv.M < 4 Then GGM3 = GG1
        Dim MM3 As String = CStr(Me.tacv.M - 3).Trim.PadLeft(2, "0"c)
        If Me.tacv.M < 4 Then MM3 = CStr(Me.tacv.M + 9).Trim.PadLeft(2, "0"c)

        'prethodno polugođe
        Dim GGM4 As String = CStr(Me.tacv.G)
        If Me.tacv.M < 6 Then GGM4 = GG1 'prethodna godina
        Dim MM4 As String = CStr(Me.tacv.M - 6).Trim.PadLeft(2, "0"c)
        If tacv.M < 6 Then MM4 = CStr(Me.tacv.M + 6).Trim.PadLeft(2, "0"c)

        Select Case n(0)
            Case "PM"
                trt = trt + "(P.mes = '" & MM1 & "' AND P.god='" & GGM1 & "' )"
            Case "PMonth"
                trt = trt + "(P.ISTMonth = '" & MM1 & "' AND P.ISTYEAR='" & GGM1 & "' )"
            Case "PK"
                trt = trt + "(P.mes = '" & MM3 & "' AND P.god='" & GGM3 & "' )"
            Case "PQuarter"
                trt = trt + "(P.ISTMonth = '" & MM3 & "' AND P.ISTYEAR='" & GGM3 & "' )"
            Case "PG"
                If ImaM = True Then
                    trt = trt + "(P.mes= '" & CStr(Me.tacv.M).Trim.PadLeft(2, "0"c) & "' AND P.God='" & GG1 & "' )"
                Else
                    trt = trt + "(P.God='" & GG1 & "' )"
                End If
            Case "PYear"
                If ImaM = True Then
                    trt = trt + "(P.ISTMonth= '" & CStr(Me.tacv.M).Trim.PadLeft(2, "0"c) & "' AND P.ISTYEAR='" & GG1 & "' )"
                Else
                    trt = trt + "(P.ISTYEAR='" & GG1 & "' )"
                End If
            Case "PP"
                trt = trt + "(P.mes = '" & MM4 & "' AND P.god='" & GGM4 & "' )"
            Case "PHalfYear"
                trt = trt + "(P.ISTMonth = '" & MM4 & "' AND P.ISTYEAR='" & GGM4 & "' )"
        End Select
        Return trt
    End Function

    Private Function CASE2IIF(ByVal s As String) As String
        Dim trt() As String = razkvantaj(s)
        Dim prvi As Integer = Array.IndexOf(trt, "CASE")
        Dim brw() As Integer = {}
        Dim URadu As Integer
        For i As Integer = prvi To trt.GetUpperBound(0)
            Select Case trt(i).Trim.ToUpper
                Case "CASE"
                    ReDim Preserve brw(1 + brw.GetUpperBound(0))
                    brw(brw.GetUpperBound(0)) = 0
                    URadu = brw.GetUpperBound(0)
                    trt(i) = ""
                Case "WHEN"
                    brw(URadu) += 1
                    If brw(URadu) > 1 Then trt(i) = " ,Iif(" Else trt(i) = " Iif("
                Case "THEN"
                    trt(i) = " , "
                Case "ELSE"
                    trt(i) = " , "
                Case "END"
                    Dim mrt As String = ""
                    For j As Integer = 1 To brw(URadu)
                        mrt = mrt & ")"
                    Next
                    trt(i) = mrt
                    URadu -= 1
                Case Else
            End Select
        Next
        Return ustringaj(trt)
    End Function

#End Region

    Dim m_f As FormTemplate
    Dim DSBrisanjeDEPO As String
    Dim DSBrisanjeServer As String
    Dim DSBrisanjeBaza As String
    Dim CATIServer As String
    Dim CATIBaza As String
    Dim praviServer As String
    Dim pravaBaza As String
    Dim ri As DatasetIstrazivanja.ISTRow
    Dim tacv As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Dim GG As String
    Dim MM As String

    Dim anketar As String
    Dim vremeLogovanja As String
    Dim txtInst As String
    Dim dtAdr As System.Data.DataTable
    Dim dtCALLS As System.Data.DataTable
    Dim dtHistory As System.Data.DataTable
    Dim adresarCati As String
    Dim adr As String
    Dim istPolja As DatasetIstrazivanja.ISTPOLJADataTable
    Dim istTabele As DatasetIstrazivanja.ISTTABELEDataTable
    Dim istLK As DatasetIstrazivanja.ISTLKDataTable
    Dim logOnA As String
    Dim mfold As String
    Dim sifist As String
    Dim nazivIst As String
    Dim tabela As String

    Dim jezik As String
    Public catiZoviSledeci As Integer
    Dim lokalno As Boolean
    Dim txtpismo As String = ""
    Dim dIst As DatasetIstrazivanja
    Dim txtMode As String

    Dim sqlISTGM As String = ""
    Dim txtZoiper As String
    Dim mdtAWL As DataTable
    Dim mdtQE As DataTable
    Dim mdtLabel As DataTable
    Dim mdtMessage As DataTable

    Dim ISTConnectionString As String
    Dim DBConnectionString As String
    Dim CATIConnectionString As String
    Dim connectionString As String
    Dim catiprefix As String

    Public Sub New(ByVal dsIST As DatasetIstrazivanja, ByVal mdtLabel As DataTable, ByVal mdtAWL As DataTable, ByVal mdtQE As DataTable, ByVal mdtMessage As DataTable, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka,
                        ByVal fold As String,
                        ByVal DBConnectionString As String, ByVal ri As DatasetIstrazivanja.ISTRow,
                        ByVal istTabele As DatasetIstrazivanja.ISTTABELEDataTable,
                        ByVal istPolja As DatasetIstrazivanja.ISTPOLJADataTable, ByVal istLK As DatasetIstrazivanja.ISTLKDataTable,
                        ByVal txtInst As String, ByVal txtPismo As String,
                        ByVal txt_DSBrisanjeDEPO As String, ByVal txt_DSBrisanjeServer As String, ByVal txt_DSBrisanjeBaza As String,
                        ByVal txt_CATIServer As String, ByVal txt_CATIBaza As String,
                        ByVal anketar As String, ByVal adresarcati As String, ByVal vremeLogovanja As String,
                        ByVal sifist As String, ByVal nazivIst As String,
                        ByVal tabela As String, ByVal jezik As String, ByVal ISTConnectionString As String, ByVal txtmode As String, ByVal txtZoiper As String)
        Me.New()
        Me.mfold = fold
        Me.ISTConnectionString = ISTConnectionString
        Me.DSBrisanjeDEPO = txt_DSBrisanjeDEPO
        Me.DSBrisanjeServer = txt_DSBrisanjeServer
        Me.DSBrisanjeBaza = txt_DSBrisanjeBaza
        Me.CATIServer = txt_CATIServer
        Me.CATIBaza = txt_CATIBaza
        Me.txtMode = txtmode
        Me.txtZoiper = txtZoiper
        Me.mdtAWL = mdtAWL
        Me.mdtQE = mdtQE
        Me.mdtMessage = mdtMessage
        Me.mdtLabel = mdtLabel
        Me.catiprefix = "dbo."
        Me.CATIConnectionString = getConnectionString(Me.CATIServer.Trim, Me.CATIBaza.Trim, txtmode, "")
        Me.ri = ri
        Me.txtInst = txtInst
        Me.dIst = dsIST

        Me.tacv = vt
        Me.GG = CStr(Me.tacv.G)
        Me.MM = CStr(Me.tacv.M).Trim.PadLeft(2, "0"c)

        Me.TKGOD.Text = Me.GG
        Me.TKMES.Text = Me.MM
        Me.DBConnectionString = DBConnectionString
        Dim bazaist As String = ""
        Me.anketar = anketar
        Me.vremeLogovanja = vremeLogovanja
        Me.sifist = sifist
        Me.nazivIst = nazivIst

        Me.tabela = tabela

        Me.jezik = jezik
        Call SetLang()

        Dim tt() As String = Me.DBConnectionString.Trim.ToUpper.Split(";")
        For i As Integer = 0 To tt.GetUpperBound(0)
            If tt(i).IndexOf("DATA SOURCE=") = 0 Then
                Dim pp() As String = tt(i).Replace("DATA SOURCE=", "").Trim.Split(".")
                praviServer = pp(0)
            End If
            If tt(i).IndexOf("INITIAL CATALOG=") = 0 Then
                pravaBaza = tt(i).Replace("INITIAL CATALOG=", "").Trim
            End If
        Next

        Me.adresarCati = adresarcati

        If Me.txtMode.Trim.ToUpper.IndexOf("CLOUD") = 0 Then
            Me.adr = adresarcati + " as adr"
            Me.connectionString = Me.DBConnectionString
            Me.catiprefix = "cati."
        End If
        If Me.txtMode.Trim.ToUpper.IndexOf("CLOUD") < 0 Then

            If adresarcati.IndexOf(".") < 0 Then
                Me.adr = "[" + praviServer + "].[" + pravaBaza + "].[dbo].[" + adresarcati + "] as adr"
            Else
                Me.adr = "[" + praviServer + "].[" + pravaBaza + "]." + adresarcati + " as adr"
            End If


            Me.connectionString = Me.CATIConnectionString
        End If

        Me.istTabele = istTabele
        Me.istPolja = istPolja
        Me.istLK = istLK

        '--2014-10-27 16:40:33:000
        'logOnA = trenutnoDatumVremeSaServera()
        logOnA = vremeLogovanja
        Me.lblLogovanA.Text = anketar + " - on:" + logOnA
        'izvuci ono sto treba za ovog anketara
        'dtAdresarCatiAnketar
        '''''
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Call Podesi_Formu()

        '
    End Sub

    Dim rb1Ztext As String
    Dim rb1text As String
    Dim dt As System.Data.DataTable

    Private Sub SetLang()
        ''
        dt = getDTVBText(dtLang, "formCATI")
        btnCIzlaz.Text = getControlText2(dt, "btnCIzlaz", Me.jezik)
        GBGODC.Text = getControlText2(dt, "GBGODC", Me.jezik)
        btnCCall.Text = getControlText2(dt, "btnCCall", Me.jezik)
        ButtonCUneti.Text = getControlText2(dt, "ButtonCUneti", Me.jezik)
        ButtonCUnos.Text = getControlText2(dt, "ButtonCUnos", Me.jezik)
        btnCIzlaz.Text = getControlText2(dt, "btnCIzlaz", Me.jezik)
        gbRezultat.Text = getControlText2(dt, "gbRezultat", Me.jezik)
        lblCNapomena1.Text = getControlText2(dt, "lblCNapomena1", Me.jezik)
        lblCNapomena.Text = getControlText2(dt, "lblCNapomena", Me.jezik)
        LLBeleStrane.Text = getControlText2(dt, "LLBeleStrane", Me.jezik)
        llAPR.Text = getControlText2(dt, "llAPR", Me.jezik)
        llNBS.Text = getControlText2(dt, "llNBS", Me.jezik)
        rb2.Text = getControlText2(dt, "rb2", Me.jezik)
        rb3.Text = getControlText2(dt, "rb3", Me.jezik)
        rb4.Text = getControlText2(dt, "rb4", Me.jezik)
        rb5.Text = getControlText2(dt, "rb5", Me.jezik)
        rb6.Text = getControlText2(dt, "rb6", Me.jezik)
        rb7.Text = getControlText2(dt, "rb7", Me.jezik)
        rb8.Text = getControlText2(dt, "rb8", Me.jezik)
        rb9.Text = getControlText2(dt, "rb9", Me.jezik)
        rb10.Text = getControlText2(dt, "rb10", Me.jezik)
        rb11.Text = getControlText2(dt, "rb11", Me.jezik)
        rb12.Text = getControlText2(dt, "rb12", Me.jezik)
        rb14.Text = getControlText2(dt, "rb14", Me.jezik)
        rb99.Text = getControlText2(dt, "rb99", Me.jezik)
        rb98.Text = getControlText2(dt, "rb98", Me.jezik)
        rb71.Text = getControlText2(dt, "rb71", Me.jezik)
        rb16.Text = getControlText2(dt, "rb16", Me.jezik)

        rb1Ztext = getControlText2(dt, "rb1Z", Me.jezik)
        rb1text = getControlText2(dt, "rb1", Me.jezik)
        rb1.Text = rb1text

        dgHistory.CaptionText = getControlText2(dt, "dgHistory", Me.jezik)

        'cbST.Text = getControlText2(dt, "cbST", Me.jezik)
        btnEmails14PM.Text = getControlText2(dt, "btnEmails14PM", Me.jezik)

    End Sub

    Dim proveraIspunjenostiKvotePoStratumu As Boolean

    Private Sub FormCATI_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'Me.dgCALLS.Controls(0).Enabled = True
        'Me.dgCALLS.Controls(1).Enabled = True
        Me.LLBeleStrane.TabStop = False
        Me.llZakazani.TabStop = False
        Me.llPZ.TabStop = False
        Me.llPZ1.TabStop = False
        Me.llRZ.TabStop = False
        Me.llNBS.TabStop = False

        Me.llPregledEmail.TabStop = False
        Me.llAPR.TabStop = False
        proveraIspunjenostiKvotePoStratumu = False
        If catiDef() = False Then
            Call pisiLogOff()
            Me.Close()
        Else
            If observationunitID = 3 Then   'domacinstvo
                'rb8.Visible = False
                rb8.Text = getControlText2(dt, "rb8D", Me.jezik)
                rb9.Visible = False
                rb10.Visible = False
                rb11.Visible = False
                rb12.Visible = False
                rb14.Visible = False
                rb71.Visible = False
                'rb99.Visible = False
                rb98.Visible = True
                Me.pamti98.Text = ""
                llPregledEmail.Visible = False
                ButtonCUneti.Visible = True
                ButtonCUnos.Visible = False
                btnEmails14PM.Visible = False
                llAPR.Visible = False
                llNBS.Visible = False
                llPZ.Visible = True
                'llRZ.Visible = False
                proveraIspunjenostiKvotePoStratumu = True
                'cbST.Visible = True
            End If

            If observationunitID = 2 Then   'gazdinstva
                'rb8.Visible = False
                'rb8.Text = getControlText2(dt, "rb8D", Me.jezik)
                'rb9.Visible = False
                rb10.Visible = False
                rb11.Visible = False
                rb12.Visible = False
                rb14.Visible = False
                rb71.Visible = False
                rb98.Visible = False
                Me.pamti98.Text = ""
                llPregledEmail.Visible = False
                'ButtonCUneti.Visible = False
                ButtonCUnos.Visible = False
                btnEmails14PM.Visible = False
                llAPR.Visible = False
                llNBS.Visible = False
                llPZ.Visible = False

                'llRZ.Visible = False
                'proveraIspunjenostiKvotePoStratumu = True
                'cbST.Visible = True
            End If

            Call popunicboCATI(cboHour, Me.CATIConnectionString)
            Call adresarUdtAdr()
            Me.Text = "CATI " & Me.txtInst & " - " & nazivIst & " " + anketar + " - on:" + logOnA
            Call sklopiAdresarI()
            NapraviDGTabele(adresarCati)

            'obrisi rezultat=0, jer nicemu ne sluzi!!
            Call obrisiRez0()

            Call sledeci()
            Me.lblNaziv.Text = sifist
            '''''

            lokalno = False
            If Me.DSBrisanjeDEPO.Trim.ToUpper = "FALSE" Then lokalno = True

            Me.txtInstrukcije.Text = Me.instrukcije

            disableGB(gbRezultat, rb7, rb14)

            If nizTelefona.Length = 0 Then
                Me.txtT.Enabled = True
                Me.txtT.Focus()
                Me.txtT.BackColor = Color.Thistle
            Else

                Me.btnCCall.Focus()
            End If

        End If
    End Sub

    Private Sub obrisiRez0()

        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"

        Dim sql As String = "delete from " + Me.catiprefix + "istcatilog where  2=2 and " +
        " rezultat=0 " + sqlISTGM + " and anketar='" + anketar + "'  and sifist='" + sifist + "' and tabela='" + tabela.Trim + "'"

        Dim odg As String = izvrsiSQL(sql, Me.CATIConnectionString)
        If odg = "nok" Then
            ''msg 174
            Dim msgtxt174 As String = getMessageText(dtMessages, "174", Me.jezik)
            Dim ppp As String = msgtxt174
            ISTMessageBox.Show(ppp, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
    End Sub

    Private Sub UpisiUISTLogKoriscenjaProcesa(ByVal proces As String, Optional ByVal izvestaj As String = "", Optional ByVal upit As String = "")
        Dim sifist As String = Me.ri.SIFIST
        Dim god As String = Me.tacv.G.ToString
        Dim mes As String = String.Format("{0:d2}", Me.tacv.M)
        Dim strSQL As String = "insert into ISTLogKoriscenjaProcesa" _
                & "(SifIst,god,mes,proces,izvestaj,upit,ko_insert,datum_insert) " _
                & " values( " _
                & "N'" & sifist & "','" & god & "','" & mes & "'," _
                & "'" & proces & "','" + izvestaj & "','" + upit & "'," _
                & "N'" & m_f.GetUserName.ToString.Trim & "'," _
                & "" & "(select top 1 GETDATE())" & ");" + nvrd

        Dim konDepo As String = getConnectionString(Me.DSBrisanjeServer.Trim, Me.DSBrisanjeBaza.Trim, txtMode, Me.ISTConnectionString)

        Dim ok As String = m_f.izvrsiSQL(strSQL, konDepo)
        If ok = "nok" Then
            ISTMessageBox.Show(strSQL + nvrd + nvrd + "is not executed! ER72", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub popunicboCATI(ByVal cbo As System.Windows.Forms.ComboBox, ByVal kkon As String, Optional ByVal saPraznim As Boolean = True)

        Dim trenutnisatminut As String = trenutnoDatumVremeSaServeraDT().ToString("HH:mm")

        Dim str As String = "select satMinut as displaymember, satMinut as valuemember from " + Me.catiprefix + "vreme3 where satminut>='" + vremeZvanjaOd + "' and satminut<='" + vremeZvanjaDo + "'"   ' and satminut>'" + trenutnisatminut + "'"
        Dim dt As New System.Data.DataTable
        dt.Clear()
        dt = izvrsiSQLvratiDT(str, kkon, Nothing)

        Dim ds As System.Data.DataSet = New System.Data.DataSet
        ds.Tables.Add("tabela")
        ds.Tables("tabela").Columns.Add("displaymember", GetType(String))
        ds.Tables("tabela").Columns.Add("valuemember", GetType(String))

        If saPraznim = True Then
            'ubaci prazan
            Dim dr0 As System.Data.DataRow = ds.Tables("tabela").NewRow()
            dr0("displaymember") = ""
            dr0("valuemember") = ""
            ds.Tables("tabela").Rows.Add(dr0)
        End If

        For i As Integer = 0 To dt.Rows.Count - 1
            Dim dr As System.Data.DataRow = ds.Tables("tabela").NewRow()
            dr("displaymember") = dt.Rows(i).Item("displaymember")
            dr("valuemember") = dt.Rows(i).Item("valuemember")
            ds.Tables("tabela").Rows.Add(dr)
        Next

        cbo.DisplayMember = "displaymember"
        cbo.ValueMember = "valuemember"
        cbo.DataSource = ds.Tables("tabela")
    End Sub

    Dim Vklj(,) As String = Nothing
    Dim frm As IstrazivanjaUnos.FormIstUnos

    Sub unosIST()
        'daj UNOS po kljucu
        'frmunos open ......
        'i na open odmah rbr=rbr
        'kao kod azuriranja kad se klikne 2 puta
        Dim postojislog As Boolean = False
        Dim izscati As Boolean = True
        Dim izazur As Boolean = True
        Dim modereplacementCATI As String = ""

        If llPZ.Visible = True Then
            If llPZ.Tag <> "" Then
                modereplacementCATI = "1" + tableReplacementColumn
            Else
                modereplacementCATI = "2" + tableReplacementColumn
            End If
        End If

        Try
            Dim cctmixmode As Boolean = False
            Dim IndikatorT1 As String = ""
            Dim ind As Boolean = False
            For Each t As DatasetIstrazivanja.ISTTABELERow In dIst.ISTTABELE.Rows
                If t.Tabela.Trim.ToUpper = tabela.Trim.ToUpper Then
                    Dim nizIndikatorT1() As String = {}
                    IndikatorT1 = IIf(t.Item("T1") Is System.DBNull.Value, "", t.Item("T1").ToString.Trim)
                    If IndikatorT1.Trim.ToUpper.Length > 0 Then nizIndikatorT1 = IndikatorT1.Split(";")

                    For k As Integer = 0 To nizIndikatorT1.GetUpperBound(0)
                        If nizIndikatorT1(k) = "CLOUDCATIMIXMODE" Then
                            cctmixmode = True
                            Exit For
                        End If
                    Next
                    ind = True
                End If
                If ind = True Then Exit For
            Next


            If sifist.ToLower.Trim = "arspilot" Then ' And SE("GOD") = "2021" And SE("MES") = "10" Then
                Call procesARS()
            End If

            If sifist.ToLower.Trim <> "arspilot" Then
                '"MIXMODE", "CLOUDMIXMODE"
                If cctmixmode = True OrElse txtMode.IndexOf("MIXMODE") >= 0 Then 'ukljucujuci i CLOUDCATIMIXMODE
                    Try
                        Vklj = spremiKljucMIXMODEString(tabela, Vklj)
                        If Not (frm Is Nothing OrElse frm.IsDisposed) Then
                            frm.Close()
                            frm = Nothing
                        End If
                        frm = New IstrazivanjaUnos.FormIstUnos(dIst, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.tacv, tabela,
                                izazur, Me.txtInst, Me.txtpismo, "MIXMODE", Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                                Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, False,, Vklj,, postojislog,,,,,
                                False, False,,,, True, False,,,,, modereplacementCATI, , , , , , , , , anketar)

                        frm.Show()
                        frm.myCaller = Me
                        frm.BringToFront()
                    Catch ex As Exception
                        If Not (frm Is Nothing OrElse frm.IsDisposed) Then
                            frm.Close()
                            frm = Nothing
                        End If
                        Me.Cursor = System.Windows.Forms.Cursors.Default
                        Exit Sub
                    End Try
                End If
                'CATI, CLOUDCATI
                If cctmixmode = False AndAlso (txtMode.IndexOf("CATI") = 0 OrElse txtMode.IndexOf("CLOUDCATI") = 0) Then

                    If (frm Is Nothing OrElse frm.IsDisposed) Then
                        frm = New IstrazivanjaUnos.FormIstUnos(dIst, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.tacv, tabela,
                    izazur, Me.txtInst, Me.txtpismo, Me.txtMode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                    Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, False, , Vklj,, postojislog,,,,,
                    False, False,,,, True, False,,,,, modereplacementCATI, , , , , , , , , anketar)

                        frm.Show()
                        frm.myCaller = Me
                        frm.BringToFront()
                        frm.TopMost = True 'MORA
                    Else
                        'prosledi kljuc
                        'Vklj
                        frm.myCaller = Me
                        frm.catiZoviSledeci = 0
                        frm.newOstalaPodesavanja(True, False, False, Vklj, 1, modereplacementCATI)
                        frm.BringToFront()
                    End If

                    'varijanta 2 
                    'frm = New IstrazivanjaUnos.FormIstUnos(dIst, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.tacv, tabela,
                    'izazur, Me.txtInst, Me.txtpismo, Me.txtMode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                    'Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, False, , Vklj,, postojislog,,,,,
                    'False, False,,,, True, False,,,,, modereplacementCATI, , , , , , , , , anketar)
                    'Try
                    '    frm.myCaller = Me
                    '    frm.ShowDialog()
                    '    'frm.BringToFront()
                    '    '    frm.TopMost = True 'MORA
                    'Catch ex As Exception
                    '    ISTMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Finally
                    '    frm.Dispose()
                    'End Try

                End If
            End If


        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

        End Try

    End Sub
    Sub procesARS(Optional ByVal dodunos As Boolean = False)
        Dim a As String = Me.DBConnectionString
        catiZoviSledeci = 0
        Dim TIPANKETE As String = SE("TIPANKETE")
        Dim anketar As String = SE("anketar")
        Dim ggod As String = SE("GOD")
        Dim mmes As String = SE("MES")
        Dim hHHNUM As String = SE("HHNUM")

        If anketar.Trim = "" Then anketar = Me.anketar
        If TIPANKETE.Trim = "" AndAlso anketar.Substring(3, 2).Trim.ToUpper = "ST" Then TIPANKETE = "4"
        If ggod.Trim = "" Then ggod = Me.GG
        If mmes.Trim = "" Then mmes = Me.MM
        Dim sql As String = ""
        If dodunos = True Then
            hHHNUM = "pregled"
        Else
            sql = "begin transaction;"
            sql = sql + "delete from arscatiZoviSledeci where god='" + ggod + "' and mes='" + mmes + "' and hhnum=" + Str(hHHNUM).Trim + ";"
            sql = sql + "insert into arscatiZoviSledeci (god,mes,hhnum,catiZoviSledeci) values('" + ggod + "','" + mmes + "'," + Str(hHHNUM).Trim + ",0);"
            sql = sql + "commit;"

            Dim ok1 As String = izvrsiSQL(sql, Me.CATIConnectionString)
            If ok1 <> "ok" Then
                ISTMessageBox.Show(sql + nvrd + nvrd + "is not executed! ER40", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If

        a = TIPANKETE + " " + anketar + " " + ggod + mmes + "P " + hHHNUM

        Dim pInfo As New System.Diagnostics.ProcessStartInfo

        Dim putanja As String = dIst.IST.Rows(0).Item("progunos").ToString.Trim
        pInfo.FileName = putanja
        'pInfo.Verb = "runas"
        Dim pm() As String = putanja.Split("\")
        Dim wd As String = ""
        For i As Integer = 0 To pm.GetUpperBound(0) - 1
            wd = wd + pm(i) + "\"
        Next
        wd = wd.TrimEnd("\")
        pInfo.WorkingDirectory = wd

        'pInfo.FileName = "C:\ARSAPP\ARSAPP.EXE"
        'pInfo.WorkingDirectory = "C:\ARSAPP"
        pInfo.Arguments = a
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
        Try
            Dim p As Process = New Process
            p.StartInfo = pInfo
            p.Start()
            p.WaitForExit()

            If p.HasExited = True Then
                If dodunos = False Then
                    sql = "select catiZoviSledeci from arscatiZoviSledeci where god='" + ggod + "' and mes='" + mmes + "' and hhnum=" + Str(hHHNUM).Trim + ";"
                    Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.CATIConnectionString, Nothing)
                    If dt.Rows.Count > 0 Then catiZoviSledeci = dt.Rows(0).Item("catiZoviSledeci").ToString.Trim

                    If catiZoviSledeci = 1 Then
                        Call komentarNeVisible()
                        Call adresaNeVisible()
                        Call pCuvaj(1)
                        txtT.Enabled = False
                        Me.Focus()
                        btnCCall.Focus()
                    Else
                        catiZoviSledeci = 0
                        Call ponistirezultat(Me.gbRezultat)
                        Me.Focus()
                    End If
                End If

            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub


    Public Sub externiUnos(ByVal fn As String, ByVal b As Boolean, ByVal wd As String, ByVal a As String)
        Dim p As New System.Diagnostics.ProcessStartInfo
        p.FileName = fn
        p.UseShellExecute = b
        If p.UseShellExecute Then
            p.WindowStyle = System.Diagnostics.ProcessWindowStyle.Maximized
        Else
            p.WorkingDirectory = wd
            p.Arguments = a
        End If
        Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(1033)
        Try
            System.Diagnostics.Process.Start(p)
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
    End Sub

    Sub sklopiAdresarI()
        'NEMA CBO,LL, SAMO TEXTBOX,FP  (ako hoce da ode da vidi upitnik ili već nešto)
        Dim iFP As Integer = -1
        Dim iFPPK As Integer = -1
        Dim iFPnPK As Integer = -1
        Dim iFPMEM As Integer = -1
        Dim pIzraz As String = ""
        Dim combo As Boolean = False
        Dim LinkLabel As Boolean = False
        Dim i As Integer = 0
        Panel1.Height = 5
        For Each p As DatasetIstrazivanja.ISTPOLJARow In istPolja.Rows
            If Not p.IsIzrazNull Then pIzraz = p.Izraz.ToUpper.Trim
            If p.TABELA.ToUpper.Trim = adresarCati.Trim.ToUpper Then
                combo = False
                LinkLabel = False
                If (Not p.IsFormaNull) AndAlso p.Forma.Trim <> "" AndAlso p.Forma.Trim.Substring(0, 1).ToUpper = "N" Then 'namerno izbaceni....
                Else
                    Dim pOpis As String = ""
                    Dim pOpisNLBL As String = ""
                    Dim pOD As String = ""
                    If Not p.IsVSNull AndAlso p.VS.Trim.Length = 0 Then p.VS = 100
                    Dim lblmultiLINE As Boolean = False
                    Dim TTfontBold As Boolean = False
                    Dim TTfontSize As Integer = 0
                    Dim TTLCENTARP As Boolean = False
                    Dim TTLDESNOP As Boolean = False
                    Dim TTPDESNOP As Boolean = False
                    Dim TTSAMOLABELA As Boolean = False
                    Dim CATI As Boolean = False
                    Dim pomIzraz As String = ""
                    If Not p.IsOpisNull Then
                        '''''''''''
                        Dim pOpisPom As String = System.Text.RegularExpressions.Regex.Replace(p.Opis.Trim, "([Ww][Ee][Bb][Ss][Tt][Rr])", "")
                        Dim ii As Integer = pOpisPom.IndexOf("#")
                        If ii > 0 Then
                            pOpis = pOpisPom.Substring(0, ii)
                            pOpisNLBL = pOpisPom.Substring(ii)
                        Else
                            pOpis = pOpisPom
                        End If
                        '''''''''''
                        'KAKO
                        Dim kako() As String = pOpis.Split("$")
                        If kako.Length > 0 Then
                            For iii As Integer = 0 To kako.Length - 1
                                kako(iii) = kako(iii).Trim.ToUpper
                                If kako(iii).IndexOf("MULTILINE") >= 0 Then
                                    lblmultiLINE = True
                                ElseIf kako(iii).IndexOf("FONTBOLD") >= 0 Then
                                    TTfontBold = True
                                ElseIf kako(iii).IndexOf("FONTSIZE") >= 0 Then
                                    kako(iii) = kako(iii).Trim.ToUpper.Replace("FONTSIZE", "")
                                    If IsNumeric(kako(iii)) = True Then TTfontSize = CInt(kako(iii))
                                ElseIf kako(iii).IndexOf("PDESNOP") >= 0 Then
                                    TTPDESNOP = True
                                ElseIf kako(iii).IndexOf("LDESNOP") >= 0 Then
                                    TTLDESNOP = True
                                ElseIf kako(iii).IndexOf("LCENTARP") >= 0 Then
                                    TTLCENTARP = True
                                ElseIf kako(iii).IndexOf("FRIGHTA") >= 0 Then
                                    TTPDESNOP = True
                                ElseIf kako(iii).IndexOf("LRIGHTA") >= 0 Then
                                    TTLDESNOP = True
                                ElseIf kako(iii).IndexOf("LCENTERA") >= 0 Then
                                    TTLCENTARP = True
                                End If
                            Next
                        End If
                        If pOpis.Trim.ToUpper.IndexOf("FONTSIZE") >= 0 AndAlso pOpis.Substring(pOpis.Trim.ToUpper.IndexOf("FONTSIZE")).Trim.ToUpper.IndexOf("$") > 0 Then
                            pOpis = pOpis.Replace(Mid(pOpis.Substring(pOpis.Trim.ToUpper.IndexOf("FONTSIZE")).Trim.ToUpper, 1 + 8, InStr(pOpis.Substring(pOpis.Trim.ToUpper.IndexOf("FONTSIZE") + 8).Trim.ToUpper, "$")), "")
                            pOpis = Replace(pOpis, "fontsize", "", 1, , CompareMethod.Text)
                        End If
                        pOpis = Replace(pOpis, "multiline", "", 1, , CompareMethod.Text)
                        pOpis = Replace(pOpis, "fontbold", "", 1, , CompareMethod.Text)
                        pOpis = Replace(pOpis, "pdesnop", "", 1, , CompareMethod.Text)
                        pOpis = Replace(pOpis, "ldesnop", "", 1, , CompareMethod.Text)
                        pOpis = Replace(pOpis, "lcentarp", "", 1, , CompareMethod.Text)
                        pOpis = Replace(pOpis, "frighta", "", 1, , CompareMethod.Text)
                        pOpis = Replace(pOpis, "lrighta", "", 1, , CompareMethod.Text)
                        pOpis = Replace(pOpis, "lcentera", "", 1, , CompareMethod.Text)

                        If pOpis Is Nothing Then pOpis = ""
                        If pOpis.Trim.IndexOf("$") = 0 Then TTSAMOLABELA = True
                        pOpis = Replace(pOpis, "$", "", 1, , CompareMethod.Text)
                        If pOpis Is Nothing Then pOpis = ""
                    End If

                    If Not p.IsODNull Then pOD = p.OD.Trim
                    Dim trt As New System.Windows.Forms.TextBox
                    Dim multiLINE As Boolean = False
                    If p.IsIzrazNull = False Then
                        If p.Izraz.Trim.ToUpper.IndexOf("READONLY") >= 0 Then
                            pomIzraz = Replace(p.Izraz.Trim, "readonly", "", 1, , CompareMethod.Text)
                        Else
                            pomIzraz = p.Izraz.Trim
                        End If
                    Else
                        pomIzraz = ""
                    End If
                    If pomIzraz Is Nothing Then pomIzraz = ""
                    If Not p.IsKLJUCNull AndAlso p.KLJUC.Trim.Length > 0 AndAlso p.KLJUC.Trim = "P" Then
                        TTfontBold = True
                        pomIzraz = "fontbold$" & pomIzraz
                    End If

                    If pomIzraz = "" Then
                    Else
                        If pomIzraz.Trim.ToUpper.IndexOf("MULTILINE") >= 0 Then
                            pomIzraz = Replace(pomIzraz.Trim, "multiline", "", 1, , CompareMethod.Text)
                            multiLINE = True
                        End If
                        If pomIzraz.Trim.ToUpper.IndexOf("FONTBOLD") >= 0 Then
                            trt.Font = New Font(Me.Font, FontStyle.Bold)
                            pomIzraz = Replace(pomIzraz.Trim, "fontbold", "", 1, , CompareMethod.Text)
                        End If
                        'default 3D
                        pomIzraz = "BORDERNONE"
                        If pomIzraz.Trim.ToUpper.IndexOf("BORDERFIXED") >= 0 Then
                            trt.BorderStyle = BorderStyle.FixedSingle
                            pomIzraz = Replace(pomIzraz.Trim, "borderfixed", "", 1, , CompareMethod.Text)
                        End If
                        If pomIzraz.Trim.ToUpper.IndexOf("BORDERNONE") >= 0 Then
                            trt.BorderStyle = BorderStyle.None
                            pomIzraz = Replace(pomIzraz.Trim, "bordernone", "", 1, , CompareMethod.Text)
                        End If
                        If pomIzraz.Trim.ToUpper.IndexOf("PDESNOP") >= 0 Then
                            trt.TextAlign = HorizontalAlignment.Right
                            pomIzraz = Replace(pomIzraz.Trim, "pdesnop", "", 1, , CompareMethod.Text)
                        End If
                        If pomIzraz.Trim.ToUpper.IndexOf("FRIGHTA") >= 0 Then
                            trt.TextAlign = HorizontalAlignment.Right
                            pomIzraz = Replace(pomIzraz.Trim, "frighta", "", 1, , CompareMethod.Text)
                        End If
                        If pomIzraz.Trim.ToUpper.IndexOf("$") >= 0 Then
                            pomIzraz = pomIzraz.Trim.Replace("$", "")
                        End If
                    End If
                    If pomIzraz Is Nothing Then pomIzraz = ""
                    'TEXTBOX
                    If pomIzraz = "" Then
                        If Not p.IsKLJUCNull AndAlso p.KLJUC.Trim.Length > 0 AndAlso p.KLJUC.Trim = "P" Then
                            trt.Name = "TK" & p.POLJE.Trim.ToUpper
                        Else
                            trt.Name = "TP" & p.POLJE.Trim.ToUpper
                        End If

                        trt.TabIndex = i + 1
                        If pOD.Trim.ToUpper.IndexOf("NOTABSTOP") > -1 Then
                            trt.TabStop = False
                        Else
                            trt.TabStop = True
                        End If
                        If multiLINE = True Then
                            trt.Multiline = True
                            ' Add vertical scroll bars to the TextBox control.
                            trt.ScrollBars = ScrollBars.Vertical
                            ' Allow the TAB key to be entered in the TextBox control.
                            trt.AcceptsReturn = True
                            ' Allow the TAB key to be entered in the TextBox control.
                            trt.AcceptsTab = True
                            ' Set WordWrap to true to allow text to wrap to the next line.
                            trt.WordWrap = True
                        End If

                        trt.ReadOnly = True
                        trt.TabStop = False
                        trt.BorderStyle = BorderStyle.None
                        trt.Height = 20
                        'duzina
                        If Not (p.IsduzinaNull OrElse p.duzina = "") Then
                            If p.duzina.Trim <> "001" And Val(p.duzina.Trim) > 0 Then trt.MaxLength = Val(p.duzina.Trim)
                        End If
                    Else 'fals polje
                        If pomIzraz.Length > 3 AndAlso pomIzraz.ToUpper.Substring(0, 2) = "CB" Then
                            'nista NEMA CBO
                        ElseIf pomIzraz.Length >= 9 AndAlso pomIzraz.ToUpper.Substring(0, 9) = "LINKLABEL" Then
                            'nista NEMA LL
                        Else
                            'FALS POLJE
                            'ako izraz pocinje sa filter ne ubacuje se u unos
                            combo = False
                            LinkLabel = False
                            trt.Name = "FP" & p.POLJE.Trim.ToUpper
                            'trt.TabIndex = i + 1
                            trt.ReadOnly = True
                            trt.TabStop = False
                            trt.BorderStyle = BorderStyle.None
                            If multiLINE = True Then trt.Multiline = True
                            trt.Tag.Tip = "F"
                            If InStr(pomIzraz, "#") > 0 Then
                                trt.Tag.rel(0) = "#"
                                Dim zzz As String = pomIzraz.ToUpper
                                If zzz.Substring(0, 2) = "#{" Then zzz = zzz.Substring(2)
                                If zzz.Substring(zzz.Length - 1) = "}" Then zzz = zzz.Substring(0, zzz.Length - 1)
                                If InStr(zzz, ":") <> 0 Then
                                    Dim yyy As String = zzz.Substring(zzz.IndexOf(":") + 1)
                                    trt.Tag.rel(1) = yyy.Substring(0, 1).ToUpper
                                    If yyy.Length > 1 Then trt.Tag.rel(2) = yyy.Substring(1).Trim.ToUpper
                                    trt.Tag.izraz = zzz.Substring(0, zzz.IndexOf(":"))
                                Else
                                    trt.Tag.izraz = zzz
                                End If
                            Else
                                trt.Tag.Izraz = pomIzraz
                            End If
                            iFP = iFP + 1
                            ReDim Preserve nizFP(iFP)
                            nizFP(iFP) = trt
                            If pomIzraz.Trim.ToUpper.IndexOf(":PK") >= 0 Then
                                iFPPK = iFPPK + 1
                                ReDim Preserve nizFPPK(iFPPK)
                                nizFPPK(iFPPK) = trt
                            End If
                            If pomIzraz.Trim.ToUpper.IndexOf(":PK") < 0 Then
                                iFPnPK = iFPnPK + 1
                                ReDim Preserve nizFPnPK(iFPnPK)
                                nizFPnPK(iFPnPK) = trt
                            End If
                            If pomIzraz.Trim.ToUpper.IndexOf(" MEM ") >= 0 Then
                                iFPMEM = iFPMEM + 1
                                ReDim Preserve nizFPMEM(iFPMEM)
                                nizFPMEM(iFPMEM) = trt
                            End If
                            If pomIzraz.Trim = "''" Then trt.Visible = False
                            ''''''kraj fals
                        End If 'kraj COMBO il false
                    End If 'kraj pravog polja

                    Dim lsx As Integer = 0
                    If Not p.IsVSNull AndAlso p.VS.Trim.IndexOf(";") < 0 Then
                        trt.Width = Val(p.VS.Trim) / 100 * trt.Width
                    End If
                    If Not p.IsVSNull AndAlso p.VS.Trim.IndexOf(";") >= 0 Then
                        If Val(Microsoft.VisualBasic.Split(p.VS.Trim, ";")(0)) Then trt.Width = Val(Microsoft.VisualBasic.Split(p.VS.Trim, ";")(0)) / 100 * trt.Width
                        If Microsoft.VisualBasic.Split(p.VS.Trim, ";")(1).Trim <> "" Then lsx = Microsoft.VisualBasic.Split(p.VS.Trim, ";")(1)
                    End If

                    trt.Location = New System.Drawing.Point(Panel1.Width - trt.Width - 20, Panel1.Height)

                    Dim xx As Integer = Panel1.Width - trt.Width
                    Dim yy As Integer = Panel1.Height
                    If lsx = 0 Then lsx = Panel1.Width - trt.Width - 25
                    Dim ltxt As New System.Windows.Forms.Label

                    If TTSAMOLABELA = False Then pOpis = (p.POLJE.Trim & "-" & pOpis)
                    ltxt = labelo(p.POLJE.Trim.ToUpper, pOpis, 0, yy, lsx, trt.Height)
                    If TTLDESNOP = True Then
                        ltxt = labelo(p.POLJE.Trim.ToUpper, pOpis, xx - 25 - lsx, yy, lsx, trt.Height)
                        ltxt.TextAlign = ContentAlignment.TopRight
                    ElseIf TTLCENTARP = True Then
                        ltxt = labelo(p.POLJE.Trim.ToUpper, pOpis, xx - 25 - lsx, yy, lsx, trt.Height)
                        ltxt.TextAlign = ContentAlignment.TopCenter
                    End If
                    If TTPDESNOP = True Then
                        trt.TextAlign = HorizontalAlignment.Right
                    End If

                    If lblmultiLINE = True Then ltxt.Height = 2 * ltxt.Height
                    'samo Bold
                    Dim ffss As Integer = 8
                    If TTfontBold = True AndAlso TTfontSize = 0 Then ltxt.Font = New Font(Me.Font.Name, 8, FontStyle.Bold)
                    If TTfontBold = True AndAlso TTfontSize > 0 Then ltxt.Font = New Font(Me.Font.Name, TTfontSize, FontStyle.Bold)
                    If TTfontBold = False AndAlso TTfontSize > 0 Then ltxt.Font = New Font(Me.Font.Name, TTfontSize, FontStyle.Regular)
                    If TTfontBold = True AndAlso TTfontSize > 0 Then ltxt.Font = New Font(Me.Font.Name, TTfontSize, FontStyle.Bold)
                    If TTfontBold = False AndAlso TTfontSize = 0 Then ltxt.Font = New Font(Me.Font.Name, 8, FontStyle.Regular)
                    Panel1.Controls.Add(ltxt)
                    Panel1.Height = Panel1.Height + ltxt.Height  '+10 zbog bordernone
                    If combo = False AndAlso LinkLabel = False Then
                        Panel1.Controls.Add(trt)
                        If multiLINE = True Then trt.Height = 4 * trt.Height
                        Panel1.Height = Panel1.Height + trt.Height - 5
                    End If
                End If 'N na pocetku forme, tj. N da Ne ide to polje
            End If
        Next
        Panel1.Height = Panel1.Height + 20
    End Sub

    Private Function labelo(ByVal ime As String, ByVal tekst As String,
    ByVal LX As Integer, ByVal LY As Integer,
    ByVal SX As Integer, ByVal SY As Integer) As System.Windows.Forms.Label
        Dim linija As New System.Windows.Forms.Label
        linija.Location = New System.Drawing.Point(LX, LY)
        linija.Size = New System.Drawing.Size(SX, SY)
        linija.Name = "L" & ime.Trim
        linija.Text = tekst.Trim
        Return linija
    End Function

    '**********************
    'IST
    Sub adresarUdtAdr()

        'adresar koji je CATI i ide iz konkretnog istrazivanja mora da bude opisan u ISTPoljima
        Dim gma As String = ""
        Dim kljuc As String = ""

        gma = imaGMAnketar(adresarCati)
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        kljuc = dajPKLJUC()

        If kljuc = "" Then
            ''msg 169
            Dim msgtxt169 As String = getMessageText(dtMessages, "169", Me.jezik)
            ''msg 170
            Dim msgtxt170 As String = getMessageText(dtMessages, "170", Me.jezik)
            ISTMessageBox.Show(msgtxt169 + adresarCati + msgtxt170)
        Else
            Dim s As String = ""
            Dim sqlW As String = " where 2=2 "
            Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
            Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
            If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
            If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
            If gma.Substring(2, 1) = "T" Then
                sqlW = sqlW + " and anketar='" + anketar + "'"
                sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
            End If

            'podaci iz adresara:OVO MI TREBA SAMO DA IZLISTAM DETALJE IZ ADRESARA
            'KANDIDATI:
            'nema u logu da se ne zovu vise
            'ako je S da stratumIST nije već gotov

            Dim sqlAdr As String = ""
            sqlAdr = "select * from " +
            " (select " + dajPSTRATUM() + " as stratumIST," + kljuc + " as kljuc, * from " + adr + sqlW + ") as A " +
            " where not exists (select * from " + Me.catiprefix + "[ISTCATILog]" +
            " where 2=2 " + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "'" +
            " and kljuc=A.kljuc and neZvatiVise=1)"
            If uzorak = "P" Then
                'prost uzorakm
            ElseIf uzorak = "K" Then
                'kvota uzorak
            ElseIf uzorak = "S" Then
                Dim ostatak As String = ""
                If poljeUAdr_kvotaPoStratumu <> "" Then
                    ostatak = " and imaUpitnik=1 group by stratumIST having count(*) >= (select max(" + poljeUAdr_kvotaPoStratumu + ") from " +
                        adr + sqlW + " and stratum=b.stratumist)) "
                Else
                    ostatak = " and imaUpitnik = 1 group by stratumIST having count(*) >=" + CStr(stratumISTBroj).Trim + ")"
                End If

                sqlAdr = sqlAdr + " and A.stratumIST not in (select isnull(stratumIST,'') as stratumIST from " + Me.catiprefix + "[ISTCATILog] b" +
                " where 2=2 " + sqlISTGM + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" +
               ostatak
            End If

            dtAdr = izvrsiSQLvratiDT(sqlAdr, Me.connectionString, Nothing)

            'If Me.txtMode.Trim.ToUpper.IndexOf("CLOUD") = 0 Then
            '    dtAdr = IzvrsiSQLVratiDT(sqlAdr, Me.DBConnectionString,Nothing)
            'End If
            'If Me.txtMode.Trim.ToUpper.IndexOf("CLOUD") < 0 Then
            '    dtAdr = IzvrsiSQLVratiDT(sqlAdr, Me.CATIConnectionString,Nothing)
            'End If

        End If

    End Sub

    Sub adresarUdtAdrZamena()

        'adresar koji je CATI i ide iz konkretnog istrazivanja mora da bude opisan u ISTPoljima
        Dim gma As String = ""
        Dim kljuc As String = ""

        gma = imaGMAnketar(adresarCati)
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        kljuc = dajPKLJUC()

        If kljuc = "" Then
            ''msg 169
            Dim msgtxt169 As String = getMessageText(dtMessages, "169", Me.jezik)
            ''msg 170
            Dim msgtxt170 As String = getMessageText(dtMessages, "170", Me.jezik)
            ISTMessageBox.Show(msgtxt169 + adresarCati + msgtxt170)
        Else
            Dim s As String = ""
            Dim sqlW As String = " where 2=2 "
            Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
            Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
            If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
            If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
            If gma.Substring(2, 1) = "T" Then
                sqlW = sqlW + " and anketar='" + anketar + "'"
                sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
            End If

            'podaci iz adresara:OVO MI TREBA SAMO DA IZLISTAM DETALJE IZ ADRESARA
            'KANDIDATI:
            'samo iz tog stratuma llPZ.tag

            Dim sqlAdr As String = ""
            sqlAdr = "select * from " +
            " (select " + dajPSTRATUM() + " as stratumIST," + kljuc + " as kljuc, * from " + adr + sqlW + ") as A " +
            " where stratumIST='" + llPZ.Tag + "'"
            If uzorak = "P" Then
                'prost uzorak
            ElseIf uzorak = "K" Then
                'kvota uzorak
            ElseIf uzorak = "S" Then
            End If
            dtAdr = izvrsiSQLvratiDT(sqlAdr, Me.connectionString, Nothing)
        End If

    End Sub

    Function imaGMAnketar(ByVal tabela As String) As String
        Dim imaG As String = "F"
        Dim imaM As String = "F"
        Dim imaA As String = "F"
        Dim imaGE As String = "F"
        Dim imaME As String = "F"

        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        'bolje iz tabele, ne iz periodike
        Dim dvG As New System.Data.DataView(istPolja)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = "T"
        Dim dvM As New System.Data.DataView(istPolja)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = "T"
        Dim dvGE As New System.Data.DataView(istPolja)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = "T"
        Dim dvME As New System.Data.DataView(istPolja)
        dvME.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = "T"
        Dim dvA As New System.Data.DataView(istPolja)
        dvA.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ANKETAR'"
        If dvA.Count = 1 Then imaA = "T"

        imaGMAnketar = imaG + imaM + imaA + imaGE + imaME
    End Function

    Function imaGM(ByVal tabela As String) As String
        Dim imaG As String = "F"
        Dim imaM As String = "F"
        Dim imaGE As String = "F"
        Dim imaME As String = "F"

        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        'bolje iz tabele, ne iz periodike
        Dim dvG As New System.Data.DataView(istPolja)
        dvG.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='GOD'"
        If dvG.Count = 1 Then imaG = "T"
        Dim dvM As New System.Data.DataView(istPolja)
        dvM.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='MES'"
        If dvM.Count = 1 Then imaM = "T"
        Dim dvGE As New System.Data.DataView(istPolja)
        dvGE.RowFilter = "2=2 and TABELA='" + tabela.Trim + "' and polje='ISTYEAR'"
        If dvGE.Count = 1 Then imaGE = "T"
        Dim dvME As New System.Data.DataView(istPolja)
        dvME.RowFilter = "2=2 And TABELA='" + tabela.Trim + "' and polje='ISTMONTH'"
        If dvME.Count = 1 Then imaME = "T"

        imaGM = imaG + imaM + imaGE + imaME
    End Function

    Function spremiKljucMIXMODEString(ByVal tab As String, ByVal Vklj(,) As String) As String(,)
        Dim kljucJe As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dv As New System.Data.DataView(istPolja)
        dv.RowFilter = "2=2 and TABELA='" + tab.Trim + "' and isnull(KLJUC,'')='P' "
        dv.Sort = "rbr ASC"

        Vklj = Nothing
        ReDim Vklj(dv.Count - 1, 1)
        For i As Integer = 0 To dv.Count - 1
            Vklj(i, 0) = dv(i).Item("polje").ToString.Trim
            Vklj(i, 1) = SE(Vklj(i, 0).Trim.ToUpper)
        Next
        spremiKljucMIXMODEString = Vklj

    End Function

    Function spremiKljucString(ByVal tab As String) As String
        Dim kljucJe As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim dv As New System.Data.DataView(istPolja)
        dv.RowFilter = "2=2 and TABELA='" + tab.Trim + "' and isnull(KLJUC,'')='P' and polje<>'GOD' and polje<>'MES' and polje<>'ISTYEAR' and polje<>'ISTMONTH'"
        dv.Sort = "rbr ASC"

        If dv.Count = 0 Then
            spremiKljucString = ""
        Else
            For i As Integer = 0 To dv.Count - 1
                Dim polje As String = dv(i).Item("polje").ToString.Trim
                kljucJe = kljucJe + polje + ","
            Next
            kljucJe = kljucJe + ")"
            spremiKljucString = kljucJe.Replace(",)", "")
        End If

    End Function

    Function dajPSTRATUM() As String
        Dim pstratum As String = ""
        Dim ppstratum() As String = Microsoft.VisualBasic.Split(stratumIST, ",")
        For i As Integer = 0 To ppstratum.GetUpperBound(0)
            pstratum = pstratum + " ltrim(rtrim(cast(" + ppstratum(i) + " as char))) +"
        Next
        pstratum = pstratum + "$"
        pstratum = pstratum.Replace("+$", "")
        dajPSTRATUM = pstratum
    End Function

    Function dajPKLJUC() As String
        Dim pkljuc As String = ""
        If spremiKljucString(adresarCati) = "" Then
            dajPKLJUC = ""
        Else
            Dim ppkljuc() As String = Microsoft.VisualBasic.Split(spremiKljucString(adresarCati), ",")
            For i As Integer = 0 To ppkljuc.GetUpperBound(0)
                pkljuc = pkljuc + " ltrim(rtrim(cast(adr." + ppkljuc(i) + " as char))) +"
            Next
            pkljuc = pkljuc + "$"
            pkljuc = pkljuc.Replace("+$", "")
            dajPKLJUC = pkljuc
        End If
    End Function

    Function dajPKLJUCSaZarezom() As String
        Dim pkljuc As String = ""
        If spremiKljucString(adresarCati) = "" Then
            dajPKLJUCSaZarezom = ""
        Else
            Dim ppkljuc() As String = Microsoft.VisualBasic.Split(spremiKljucString(adresarCati), ",")
            For i As Integer = 0 To ppkljuc.GetUpperBound(0)
                pkljuc = pkljuc + " " + ppkljuc(i) + ","
            Next
            dajPKLJUCSaZarezom = pkljuc
        End If
    End Function

    Sub dajLog(Optional rez As Integer = 0, Optional zamenastratuma As Integer = 0)
        'adresar koji je CATI mora da bude opisan u ISTPoljima da bi se povukao sa leve strane ekrana
        Dim s As String = ""
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
        Dim gma As String = ""
        Dim dajkljuc As String = ""
        Dim ubaciRez As String = " and 2=2 "
        Dim ubaciRS98 As String = " and 2=2 "
        Dim ubaciRS98adr As String = ""
        Dim ubaciRS98log As String = ""
        If rez <> 0 AndAlso rez <> 98 AndAlso zamenastratuma <> 198 Then
            ubaciRez = " and rezultat=" + rez.ToString.Trim + ""
        ElseIf rez <> 98 AndAlso zamenastratuma = 198 AndAlso Me.pamti98.Text <> "" Then
            Dim dt As DataTable = CType(dgCALLS.DataSource, System.Data.DataTable)
            Dim stratumIST As String = dajVrIzDG(dgCALLS, dt, 0, "stratumIST")
            If dt.Rows.Count > 1 Then
                ubaciRS98 = " and A.stratumIST = '" + Me.pamti98.Text + "'"
            Else
                ubaciRS98 = " and A.stratumIST not in " + Me.nizpamti98.Text + ""
            End If
        End If

        If rez = 98 Then
            Dim ostaojedan As Boolean = False
            Dim dt As DataTable = CType(dgCALLS.DataSource, System.Data.DataTable)
            Dim stratumIST As String = dajVrIzDG(dgCALLS, dt, 0, "stratumIST")
            ostaojedan = proverijedan(dt, "stratumIST")
            If ostaojedan = False Then
                ubaciRS98 = " and A.stratumIST not in " + Me.nizpamti98.Text + ""
            Else
                ubaciRS98 = " and 2=2 "
                Me.nizpamti98.Text = "''"
            End If

            'ako je ostao samo 1 daj ispocetka
        End If

        gma = imaGMAnketar(adresarCati)
        dajkljuc = dajPKLJUC()

        If dajkljuc = "" Then
        Else
            sqlISTGM = " And ISTyear ='" + GG + "' and ISTmonth='" + MM + "'"
            Dim sqlW As String = " where 2=2 "
            If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
            If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
            If gma.Substring(2, 1) = "T" Then
                sqlW = sqlW + " and anketar='" + anketar + "'"
                sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
            End If
            If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
            If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"

            Dim sqlLogAdr As String
            'KANDIDATI:
            'If observationunitID = 1 Then
            'nema u logu da se ne zovu vise
            'nema u logu zakazan poziv
            'ako je S da stratumIST nije već gotov
            Dim pinto As String = "  "
            If replacementDisplay = 1 Then pinto = " into #qqq1 "

            If numberOfvisibleRecordsOfQueue = -1 Then
                sqlLogAdr = "select * " + pinto
            Else
                sqlLogAdr = "select  top " + CStr(numberOfvisibleRecordsOfQueue) + " * " + pinto
            End If

            Dim posebnoDodati As String = ""
            Dim posebnoDodatiLog As String = ""
            If poljeuAdr_dodatnaPoljaZaGrid.Trim <> "" Then
                posebnoDodati = poljeuAdr_dodatnaPoljaZaGrid.TrimEnd(",").TrimStart(",")
                Dim pp() As String = posebnoDodati.Split(",")
                For i As Integer = 0 To pp.GetUpperBound(0)
                    posebnoDodatiLog = ", Null" + posebnoDodatiLog
                Next
                posebnoDodati = ",adr." + posebnoDodati
            End If


            Dim sqlISTGMLog As String = sqlISTGM.Replace("anketar", "a.anketar")

            sqlLogAdr = sqlLogAdr + " from (select * from (select " + dajkljuc + " As kljuc,null As pokusaj," + nvrd +
                poljeUAdr_Telefon1 + " as telefon, null As pozivStart,null As pozivEnd,null As rezultat," + nvrd +
                " CONVERT(varchar, GETDATE(), 120) As zvatiU," + nvrd +
                " N'' as komentarAnketara, N'' as novitelefon," + dajPSTRATUM() + " as stratumIST,anketar " + posebnoDodati + nvrd +
                " from " + adr + sqlW + " ) as A " + nvrd +
                " where 2=2 " + ubaciRez + ubaciRS98 + " and not exists (select * from " + Me.catiprefix + "[ISTCATILog]" + nvrd +
                " where 2=2 " + sqlISTGMLog + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" + nvrd +
                " and kljuc=A.kljuc and neZvatiVise=1)" + nvrd +
                " AND not exists (select * from " + Me.catiprefix + "[ISTCATILog]" + nvrd +
                " where 2=2 " + sqlISTGMLog + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" + nvrd +
                " and kljuc=A.kljuc and neZvatiVise=0 and pokusaj>0)"

            Dim ostatak As String = ""
            If uzorak = "P" Then
                'prost uzorak
            ElseIf uzorak = "K" Then
                'kvota uzorak
            ElseIf uzorak = "S" Then
                'oni gde je vec popunjena kvota po stratumu

                If poljeUAdr_kvotaPoStratumu <> "" Then
                    ostatak = " and imaUpitnik=1 group by stratumIST having count(*) >= (select max(" + poljeUAdr_kvotaPoStratumu + ") from " + nvrd +
                        adr + sqlW + " And stratum=b.stratumist)) "
                Else
                    ostatak = " and imaUpitnik = 1 group by stratumIST having count(*) >=" + CStr(stratumISTBroj).Trim + ")"
                End If

                'sqlLogAdr = sqlLogAdr + " and A.stratumIST not in (select isnull(stratumIST,'') as stratumIST from " + Me.catiprefix + "[ISTCATILog] b" + nvrd +
                '" where 2=2 " + sqlISTGM + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" + ostatak

                sqlLogAdr = sqlLogAdr + " and not exists (select * from " + Me.catiprefix + "[ISTCATILog] b" + nvrd +
               " where 2=2 " + sqlISTGMLog + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "' and A.stratumIST=isnull(stratumIST,'') " + ostatak


            End If

            'ISTCATILog ima uvek god,mes,sifist,tabela,anketar

            Dim sqlCATILog As String = ""
            sqlCATILog = " select  " +
                " kljuc," +
                " pokusaj,telefon,CONVERT(varchar,pozivStart, 120),CONVERT(varchar,pozivEnd, 120),rezultat," + nvrd +
                " case When isnull(zvatiU,0)=0 Then CONVERT(varchar, GETDATE(), 120) Else CONVERT(varchar, zvatiU, 120) End As zvatiU ," + nvrd +
                " komentarAnketara, novitelefon,stratumIST As stratumIST,A.anketar " + posebnoDodati + nvrd +
                " from " + Me.catiprefix + "[ISTCATILog] A " + nvrd +
                " inner join (select * from " + adr + sqlW + " ) as Adr " + nvrd +
                " on A.kljuc=" + dajkljuc + nvrd +
                " where 2=2 " + ubaciRez + sqlISTGMLog + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" + nvrd +
                " and isnull(zvatiU,0)<>0  and neZvatiVise=0" + nvrd +
                " and pokusaj=(select max (pokusaj) from " + Me.catiprefix + "[ISTCATILog] where 2=2 " + sqlISTGMLog + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "' and kljuc=A.kljuc)" + nvrd +
                " and not exists (select * from " + Me.catiprefix + "[ISTCATILog]" + nvrd +
                " where 2=2 " + sqlISTGMLog + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" + nvrd +
                " and kljuc=A.kljuc and neZvatiVise=1)"

            '17 - dodeljen drugom
            'sqlCATILog = sqlCATILog + " and A.stratumIST not in (select isnull(stratumIST,'') as stratumIST from " + Me.catiprefix + "[ISTCATILog] b" + nvrd +
            '    " where 2=2 " + sqlISTGM + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" + ostatak


            sqlCATILog = sqlCATILog + " and not exists (select * from " + Me.catiprefix + "[ISTCATILog] b" + nvrd +
               " where 2=2 " + sqlISTGMLog + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "' and A.stratumIST=isnull(stratumIST,'') " + ostatak

            sqlCATILog = sqlLogAdr + " UNION " + sqlCATILog + ") AAA "

            Dim orderBy As String = "order by zvatiU, rezultat desc,stratumIST, kljuc"
            sqlCATILog = sqlCATILog + orderBy

            'Dim conn As String = ""
            'If Me.txtMode.Trim.ToUpper.IndexOf("CLOUD") = 0 Then
            '    conn = Me.DBConnectionString
            'End If
            'If Me.txtMode.Trim.ToUpper.IndexOf("CLOUD") < 0 Then
            '    conn = Me.CATIConnectionString
            'End If

            If replacementDisplay <> 1 Then
                dtCALLS = izvrsiSQLvratiDT(sqlCATILog, connectionString, Nothing)
            Else

                Dim sqlKPS As String = "select max(isnull(" + poljeUAdr_kvotaPoStratumu + ",'0')) as KPS from " + adr + sqlW + ""
                Dim dtKPS As DataTable = izvrsiSQLvratiDT(sqlKPS, connectionString, Nothing)
                If dtKPS.Rows.Count > 0 AndAlso dtKPS.Rows(0).Item("KPS").ToString.Trim = "0" Then
                    MsgBox("Field KVOTAPOSTATUMU In ADRRESSBOOK Is empty!!!!!", vbInformation, "Possible error!")
                End If

                Dim sqlpom As String =
                " Select * FROM ( " +
                " Select *, ROW_NUMBER () OVER (PARTITION BY STRATUMIST ORDER BY ZAMENE) As RBRpOZIVA " +
                " from ( Select q.*, ZAMENE, " + poljeUAdr_kvotaPoStratumu + "- " +
                "(Select  count(*) As bb from " + Me.catiprefix + "[ISTCATILog] ILOG   where 2=2 " + sqlISTGM + " and sifist='" + sifist.Trim +
                "' and tabela='" + tabela.Trim + "' and imaupitnik=1 " +
                " And stratumIST=q.stratumIST) As PREOSTALAKVOTAPOSTRATUMU " +
                " from #qqq1 q inner join " +
                " (select " + dajkljuc + " As kljuc, ZAMENE, " + poljeUAdr_kvotaPoStratumu + " from " + adr + sqlW + ") adr22 On q.kljuc=adr22.kljuc " +
                ") bb ) As A  WHERE RBRpOZIVA<=PREOSTALAKVOTAPOSTRATUMU " + orderBy

                'drugaciji prikaz, ovde se prikazuju
                Dim sql As String = "begin transaction;" + nvrd + sqlCATILog + ";" + nvrd + sqlpom + ";" + nvrd + " commit; "
                dtCALLS = izvrsiSQLvratiDT(sql, connectionString, Nothing)

            End If

            dgCALLS.DataSource = dtCALLS
            Call srediGrid(dgCALLS, dtCALLS)

            dgCALLS.CaptionText = dajCaption(dtCALLS, sqlISTGM, sqlW)

            Call prikaziPokusaje()

        End If

    End Sub

    Function dajVrIzDG(ByVal dgr As DataGrid, ByVal dt As DataTable, ByVal gdeSamUGridu As Integer, ByVal kolona As String) As String
        dajVrIzDG = ""
        If Not dgr.Item(gdeSamUGridu, dt.Columns.IndexOf(kolona)).ToString.Trim Is System.DBNull.Value Then
            dajVrIzDG = dgr.Item(gdeSamUGridu, dt.Columns.IndexOf(kolona)).ToString.Trim
        End If
    End Function

    Function proverijedan(ByVal dt As DataTable, ByVal kolona As String) As Boolean
        proverijedan = True
        Dim prvi As String = ""
        Dim st As String = ""
        If dt.Rows.Count > 0 Then
            prvi = dt.Rows(0).Item(kolona).ToString.Trim
            For i As Integer = 1 To dt.Rows.Count() - 1
                st = dt.Rows(i).Item(kolona).ToString.Trim
                If st <> prvi Then
                    proverijedan = False
                    Exit For
                End If
            Next
        End If
    End Function

    Function dajCaption(ByVal dtCALLS As DataTable, ByVal sqlISTGM As String, ByVal sqlW As String) As String

        ' ukupan broj sa upitnikom - u svim stratumima koji pripadaju anketaru
        Dim str As String = "select count(distinct kljuc) As koliko " +
           " from " + Me.catiprefix + "[ISTCATILog]" +
           " where 2=2 " + sqlISTGM + " And anketar='" + anketar + "' and sifist='" + sifist.Trim +
           "' and tabela='" + tabela.Trim + "' and imaupitnik=1 and nezvativise=1 "    'and rezultat in (1,61)"
        Dim dt As New DataTable
        dt = izvrsiSQLvratiDT(str, Me.CATIConnectionString, Nothing)
        Dim a As String = ""
        If dt.Rows.Count > 0 Then a = dt.Rows(0).Item("koliko").ToString.Trim
        If a = "" Then a = "0"

        'zavrseni bez upitnika  po stratumu
        Dim strb As String = "select count(distinct kljuc) As koliko " +
         " from " + Me.catiprefix + "[ISTCATILog]" +
           " where 2=2 " + sqlISTGM + " And anketar='" + anketar + "' and sifist='" + sifist.Trim +
           "' and tabela='" + tabela.Trim + "' and ISNULL(kljuc,'')<>'' and imaupitnik=0 and nezvativise=1 "
        Dim dtb As New DataTable
        dtb = izvrsiSQLvratiDT(strb, Me.CATIConnectionString, Nothing)
        Dim ab As String = ""
        If dtb.Rows.Count > 0 Then ab = dtb.Rows(0).Item("koliko").ToString.Trim
        If ab = "" Then ab = "0"

        ''msg 171
        Dim msgtxt171 As String = getMessageText(dtMessages, "171", Me.jezik)
        ''msg 172
        Dim msgtxt172 As String = getMessageText(dtMessages, "172", Me.jezik)
        dajCaption = msgtxt171 & a & msgtxt172 & ab

    End Function

    Sub prikaziPokusaje()
        Dim gma As String = imaGMAnketar(adresarCati)
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        Dim sqlW As String = " where 2=2 "
        If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
        If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
        If gma.Substring(2, 1) = "T" Then
            sqlW = sqlW + " and anketar='" + anketar + "'"
            sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
        End If
        If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
        If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"
        If Not dtCALLS Is Nothing AndAlso dtCALLS.Rows.Count > 0 Then
            Dim kljuc As String = dtCALLS.Rows(0).Item("kljuc").ToString.Trim
            Dim strHistory As String = "SELECT anketar,kljuc,pokusaj,CONVERT(varchar,pozivStart, 120) as pozivStart,CONVERT(varchar,pozivEnd, 120) as pozivEnd,hostName,telefon,rezultat " +
           " from " + Me.catiprefix + "[ISTCATILog]" +
           " where 2=2 " + sqlISTGM + " and sifist='" + sifist.Trim +
           "' and tabela='" + tabela.Trim + "' and kljuc='" + kljuc + "'"
            dtHistory = izvrsiSQLvratiDT(strHistory, Me.CATIConnectionString, Nothing)
            dgHistory.DataSource = dtHistory
            Call srediGrid(dgHistory, dtHistory)
            'dgHistory.CaptionText = "Prethodni pokušaji..."
        End If
    End Sub

    Sub srediGrid(ByVal dg As DataGrid, ByVal dt As DataTable)
        'sredi grid
        Dim ts As New System.Windows.Forms.DataGridTableStyle
        ts.MappingName = CType(dg.DataSource, System.Data.DataTable).TableName

        dg.TableStyles.Clear()
        dg.TableStyles.Add(ts)
        Dim g As System.Drawing.Graphics = System.Drawing.Graphics.FromHwnd(dg.Handle)
        Dim sf As System.Drawing.StringFormat = New System.Drawing.StringFormat(System.Drawing.StringFormat.GenericTypographic)
        Dim size As System.Drawing.SizeF
        Dim width As Single
        Dim row, col As Integer
        Dim totalRows As Integer = CType(dg.DataSource, System.Data.DataTable).Rows.Count
        Dim countRows As Integer = totalRows
        Dim countColumns As Integer = CType(dg.DataSource, System.Data.DataTable).Columns.Count
        Dim caption As String
        If countColumns > 0 Then
            For col = 0 To countColumns - 1
                caption = CType(dg.DataSource, System.Data.DataTable).Columns(col).Caption.ToString
                size = g.MeasureString(caption, dg.HeaderFont, 200, sf)
                width = size.Width + 15
                If countRows > 0 Then
                    For row = 0 To countRows - 1
                        size = g.MeasureString(dg(row, col).ToString, dg.Font, 200, sf)
                        If (size.Width + 15 > width) Then
                            width = size.Width + 15
                        End If
                    Next
                    dg.TableStyles(ts.MappingName).GridColumnStyles(col).Width = CType(width, Integer)
                    dg.TableStyles(ts.MappingName).GridColumnStyles(col).NullText = ""
                End If
            Next
        End If
        ts = Nothing
        g.Dispose()
        'dg.CaptionText = "...."
    End Sub

    Private Sub btnIzlaz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCIzlaz.Click

        Call otvorenaFormaZatvori("FormIstUnos")

        If Me.txtKomentarAnketara.Visible = True AndAlso Me.txtKomentarAnketara.Enabled = True Then
            Dim rez As Integer = rezultat(Me.gbRezultat)
            If rez <> 0 Then
                Call potvrdaCuvanja()
            Else
                ''msg 173
                Dim msgtxt173 As String = getMessageText(dtMessages, "173", Me.jezik)
                ISTMessageBox.Show(msgtxt173)
                Me.gbRezultat.Focus()
            End If
        End If

        Call pisiLogOff()
        Me.Close()

    End Sub

    Sub otvorenaFormaZatvori(ByVal ime As String)

        Dim iimmee As String = ""
        Dim brojotvorenih As Integer = Application.OpenForms.Count
        For i As Integer = 0 To brojotvorenih - 1
            iimmee = Application.OpenForms.Item(i).Name
            If iimmee.Trim.ToUpper = ime.Trim.ToUpper Then
                Application.OpenForms.Item(i).Dispose()
                Exit For
            End If
        Next
    End Sub

    Sub pisiLogOff()

        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"

        Dim vremeLogOff As String = trenutnoDatumVremeSaServera()
        Dim sql As String = "update " + Me.catiprefix + "[ISTCATILog] set logOff= '" + vremeLogOff + "'" +
        " where 2=2 " + sqlISTGM + " and anketar='" + anketar + "'  and sifist='" + sifist + "'" +
        " and logon='" + logOnA.ToString.Trim + "'"

        Dim odg As String = izvrsiSQL(sql, Me.CATIConnectionString)
        If odg = "nok" Then
            ''msg 174
            Dim msgtxt174 As String = getMessageText(dtMessages, "174", Me.jezik)
            Dim ppp As String = msgtxt174
            ISTMessageBox.Show(ppp, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim sqlCATILogovanje As String = "insert into " + Me.catiprefix + "[ISTCATILogovanje] (sifist,tabela,anketar,onoff,vreme) " _
                      + " values('" & sifist & "','" + tabela & "','" + anketar + "','off','" + vremeLogOff + "')"
        odg = izvrsiSQL(sqlCATILogovanje, Me.CATIConnectionString)
        If odg = "nok" Then
            ''msg 175
            Dim msgtxt175 As String = getMessageText(dtMessages, "175", Me.jezik)
            Dim ppp As String = msgtxt175
            ISTMessageBox.Show(ppp, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Me.lblLogovanA.Text = ""
    End Sub

    Dim uzorak As String
    Dim kvota As Integer
    Dim stratumIST As String
    Dim stratumISTBroj As Integer
    Dim instrukcije As String
    Dim pozivZauzet As String
    Dim pozivNeJavljaSe As String
    Dim vremeZvanjaOd As String
    Dim vremeZvanjaDo As String
    Dim pozivNijeKodKuce As String
    Dim subject As String
    Dim bcc As String
    Dim attach1 As String
    Dim attach2 As String
    Dim attach3 As String
    Dim attach4 As String
    Dim attach5 As String
    Dim poljeUAdr_KomentarZaAnketara As String
    Dim poljeUAdr_Telefon1 As String
    Dim poljeUAdr_Telefon2 As String
    Dim poljeUAdr_Telefon3 As String
    Dim poljeuAdr_dodatnaPoljaZaGrid As String
    Dim poljeUAdr_kvotaPoStratumu As String
    Dim poljeUAdr_nazivPreduzeca As String
    Dim poljeUAdr_Kontakt As String
    Dim poljeUAdr_Email As String
    Dim tableReplacementColumn As String
    Dim replacementDisplay As Integer = 0
    Dim body As String
    Dim brojPozivaPrePrelaskaNaTelefon2 As Integer
    Dim observationunitID As Integer
    Dim brojPozivaPrePrelaskaNaTelefon3 As Integer
    Dim progUnosCATIS As String
    Dim numberOfvisibleRecordsOfQueue As Integer

    Function postojiPolje(ByVal adresar As String, ByVal poljeUAdr_kvotaPoStratumu As String) As Boolean
        postojiPolje = False
        Dim sql As String = "select * from " & adresar & " where 2=3"
        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)

        For Each c As System.Data.DataColumn In dt.Columns
            If c.ColumnName.Trim.ToUpper = poljeUAdr_kvotaPoStratumu.Trim.ToUpper Then
                postojiPolje = True
                Exit For
            End If
        Next
    End Function

    Function catiDef() As Boolean
        catiDef = True
        Dim sqlcatidef As String = "select * from " + Me.catiprefix + "[ISTCatiDef] where sifist='" + sifist + "' and tabela='" + tabela + "' and ISTYear='" + Me.GG + "' and ISTMonth='" + Me.MM + "'"
        Dim dt As New System.Data.DataTable
        dt = izvrsiSQLvratiDT(sqlcatidef, Me.CATIConnectionString, Nothing)

        poljeUAdr_KomentarZaAnketara = ""

        If dt.Rows.Count = 1 Then
            'sve ok
            If Not (dt.Rows(0).Item("uzorak")) Is Nothing Then uzorak = dt.Rows(0).Item("uzorak").ToString.Trim 'P,S,K
            'p - prost
            's - stratumIST
            'k - kvota uzorak
            If Not (dt.Rows(0).Item("kvota")) Is Nothing Then kvota = CInt(dt.Rows(0).Item("kvota").ToString.Trim)
            If Not (dt.Rows(0).Item("stratumIST")) Is Nothing Then stratumIST = dt.Rows(0).Item("stratumIST").ToString.Trim
            If stratumIST <> "" Then
                stratumISTBroj = 5 'default
                If Not (dt.Rows(0).Item("stratumISTBroj")) Is Nothing Then
                    stratumISTBroj = CInt(dt.Rows(0).Item("stratumISTBroj").ToString.Trim)
                End If
            End If
            If Not (dt.Rows(0).Item("instrukcije")) Is Nothing Then instrukcije = dt.Rows(0).Item("instrukcije").ToString.Trim
            If Not (dt.Rows(0).Item("pozivZauzet")) Is Nothing Then pozivZauzet = dt.Rows(0).Item("pozivZauzet").ToString.Trim
            If Not (dt.Rows(0).Item("pozivNeJavljaSe")) Is Nothing Then pozivNeJavljaSe = dt.Rows(0).Item("pozivNeJavljaSe").ToString.Trim
            If Not (dt.Rows(0).Item("vremeZvanjaOd")) Is Nothing Then vremeZvanjaOd = dt.Rows(0).Item("vremeZvanjaOd").ToString.Trim
            If Not (dt.Rows(0).Item("vremeZvanjaDo")) Is Nothing Then vremeZvanjaDo = dt.Rows(0).Item("vremeZvanjaDo").ToString.Trim
            If Not (dt.Rows(0).Item("pozivNijeKodKuce")) Is Nothing Then pozivNijeKodKuce = dt.Rows(0).Item("pozivNijeKodKuce").ToString.Trim
            If Not (dt.Rows(0).Item("body")) Is Nothing Then body = dt.Rows(0).Item("body").ToString.Trim
            If Not (dt.Rows(0).Item("subject")) Is Nothing Then subject = dt.Rows(0).Item("subject").ToString.Trim
            If Not (dt.Rows(0).Item("bcc")) Is Nothing Then bcc = dt.Rows(0).Item("bcc").ToString.Trim
            If Not (dt.Rows(0).Item("attach1")) Is Nothing Then attach1 = dt.Rows(0).Item("attach1").ToString.Trim
            If Not (dt.Rows(0).Item("attach2")) Is Nothing Then attach2 = dt.Rows(0).Item("attach2").ToString.Trim
            If Not (dt.Rows(0).Item("attach3")) Is Nothing Then attach3 = dt.Rows(0).Item("attach3").ToString.Trim
            If Not (dt.Rows(0).Item("attach4")) Is Nothing Then attach4 = dt.Rows(0).Item("attach4").ToString.Trim
            If Not (dt.Rows(0).Item("attach5")) Is Nothing Then attach5 = dt.Rows(0).Item("attach5").ToString.Trim
            If Not (dt.Rows(0).Item("poljeUAdr_KomentarZaAnketara")) Is Nothing Then poljeUAdr_KomentarZaAnketara = dt.Rows(0).Item("poljeUAdr_KomentarZaAnketara").ToString.Trim.ToUpper
            If Not (dt.Rows(0).Item("poljeUAdr_Telefon1")) Is Nothing Then poljeUAdr_Telefon1 = dt.Rows(0).Item("poljeUAdr_Telefon1").ToString.Trim.ToUpper
            If Not (dt.Rows(0).Item("poljeUAdr_Telefon2")) Is Nothing Then poljeUAdr_Telefon2 = dt.Rows(0).Item("poljeUAdr_Telefon2").ToString.Trim.ToUpper
            If Not (dt.Rows(0).Item("poljeUAdr_Telefon3")) Is Nothing Then poljeUAdr_Telefon3 = dt.Rows(0).Item("poljeUAdr_Telefon3").ToString.Trim.ToUpper
            If Not (dt.Rows(0).Item("poljeuAdr_dodatnaPoljaZaGrid")) Is Nothing Then poljeuAdr_dodatnaPoljaZaGrid = dt.Rows(0).Item("poljeuAdr_dodatnaPoljaZaGrid").ToString.Trim.ToUpper

            If Not (dt.Rows(0).Item("brojPozivaPrePrelaskaNaTelefon2")) Is Nothing AndAlso
              (Not (dt.Rows(0).Item("brojPozivaPrePrelaskaNaTelefon2").GetType Is GetType(System.DBNull))) Then
                brojPozivaPrePrelaskaNaTelefon2 = CInt(dt.Rows(0).Item("brojPozivaPrePrelaskaNaTelefon2").ToString.Trim)
            Else
                brojPozivaPrePrelaskaNaTelefon2 = 10
            End If
            If Not (dt.Rows(0).Item("brojPozivaPrePrelaskaNaTelefon3")) Is Nothing AndAlso
                (Not (dt.Rows(0).Item("brojPozivaPrePrelaskaNaTelefon3").GetType Is GetType(System.DBNull))) Then
                brojPozivaPrePrelaskaNaTelefon3 = CInt(dt.Rows(0).Item("brojPozivaPrePrelaskaNaTelefon3").ToString.Trim)
            Else
                brojPozivaPrePrelaskaNaTelefon3 = 10
            End If

            If Not (dt.Rows(0).Item("poljeUAdr_kvotaPoStratumu")) Is Nothing Then poljeUAdr_kvotaPoStratumu = dt.Rows(0).Item("poljeUAdr_kvotaPoStratumu").ToString.Trim.ToUpper

            If poljeUAdr_kvotaPoStratumu <> "" AndAlso postojiPolje(adresarCati, poljeUAdr_kvotaPoStratumu) = False Then
                ISTMessageBox.Show("Nije u redu definicija u ISTCatiDef, polje koje predstavlja 'Broj upitnika po stratumu' ne postoji u tabeli koja je Adresar!!!!!")
                catiDef = False
            End If

            If Not (dt.Rows(0).Item("poljeUAdr_nazivPreduzeca")) Is Nothing Then poljeUAdr_nazivPreduzeca = dt.Rows(0).Item("poljeUAdr_nazivPreduzeca").ToString.Trim.ToUpper
            If Not (dt.Rows(0).Item("poljeUAdr_kontakt")) Is Nothing Then poljeUAdr_Kontakt = dt.Rows(0).Item("poljeUAdr_kontakt").ToString.Trim.ToUpper
            If Not (dt.Rows(0).Item("poljeUAdr_Email")) Is Nothing Then poljeUAdr_Email = dt.Rows(0).Item("poljeUAdr_Email").ToString.Trim.ToUpper
            If Not (dt.Rows(0).Item("observationunitID")) Is Nothing Then observationunitID = dt.Rows(0).Item("observationunitID").ToString.Trim.ToUpper
            If Not (dt.Rows(0).Item("tableReplacementColumn")) Is Nothing Then tableReplacementColumn = dt.Rows(0).Item("tableReplacementColumn").ToString.Trim.ToUpper

            If poljeUAdr_nazivPreduzeca = "" Then poljeUAdr_nazivPreduzeca = "''"
            If poljeUAdr_Kontakt = "" Then poljeUAdr_Kontakt = "''"
            If poljeUAdr_Email = "" Then poljeUAdr_Email = "''"
            If poljeUAdr_KomentarZaAnketara = "" Then poljeUAdr_KomentarZaAnketara = "''"

            If Not (dt.Rows(0).Item("replacementDisplay")) Is Nothing AndAlso (Not (dt.Rows(0).Item("replacementDisplay").GetType Is GetType(System.DBNull))) Then
                replacementDisplay = CInt(dt.Rows(0).Item("replacementDisplay").ToString.Trim)
            Else
                replacementDisplay = 0
            End If

        End If

        Dim sqlCATIUsersPass As String = "select * from " + Me.catiprefix + "[ISTCATIUsersPass]" _
               + " where sifist='" + sifist + "' and tabela='" + tabela + "' and anketar='" + anketar + "'"
        Dim dt1 As New System.Data.DataTable
        dt1 = izvrsiSQLvratiDT(sqlCATIUsersPass, Me.CATIConnectionString, Nothing)
        If dt1.Rows.Count = 1 Then
            If Not (dt1.Rows(0).Item("numberOfvisibleRecordsOfQueue")) Is Nothing AndAlso dt1.Rows(0).Item("numberOfvisibleRecordsOfQueue").ToString.Trim.ToUpper() <> "" Then
                numberOfvisibleRecordsOfQueue = CInt(dt1.Rows(0).Item("numberOfvisibleRecordsOfQueue").ToString.Trim.ToUpper())
            Else
                numberOfvisibleRecordsOfQueue = -1
            End If
        End If

    End Function

    Private Sub FormCATI_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If Me.txtKomentarAnketara.Visible = True AndAlso Me.txtKomentarAnketara.Enabled = True Then
            Dim rez As Integer = rezultat(Me.gbRezultat)
            If rez <> 0 Then
                Call potvrdaCuvanja()
            Else
                ''msg 173
                Dim msgtxt173 As String = getMessageText(dtMessages, "173", Me.jezik)
                ISTMessageBox.Show(msgtxt173, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.gbRezultat.Focus()
            End If
        End If

        'If Me.txtKomentarAnketara.Visible = True Then Call potvrdaCuvanja()
        If Me.lblLogovanA.Text <> "" Then Call pisiLogOff()
    End Sub

    Private Sub zakazaniPromena()
        If llZakazani.Text = "..6.." Then
            llZakazani.Text = ".All."
            Call sledeci(6)
        Else
            llZakazani.Text = "..6.."
            Call sledeci()
        End If
    End Sub

    Sub sledeci(Optional rez As Integer = 0)

        If llPZ.Visible = True AndAlso llPZ.Text = "Regular" Then
            'provera da li je ispunjena kvottaPoStratumu
            If llPZ.Tag <> "" Then

                Dim strsaUpitnikomManjeODKvote As String = "select count(*) from " + Me.catiprefix + "ISTCATILog where 2=2 " + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "'" +
                    " and rezultat=1  and stratumIST='" + llPZ.Tag + "' group by stratumIST having count(*) < " + CStr(stratumISTBroj).Trim
                Dim dt As New DataTable
                dt = izvrsiSQLvratiDT(strsaUpitnikomManjeODKvote, Me.connectionString, Nothing)
                Dim a As String = ""
                If dt.Rows.Count >= 0 Then 'ima jos
                    Call dajLogStratum(llPZ.Tag)
                    Call adresarUdtAdrZamena()
                End If

                '''''''''
                Dim strsaUpitnikomOK As String = "select count(*) from " + Me.catiprefix + "ISTCATILog where 2=2 " + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "'" +
                    " and rezultat=1  and stratumIST='" + llPZ.Tag + "' group by stratumIST having count(*) = " + CStr(stratumISTBroj).Trim
                Dim dtOK As New DataTable
                dtOK = izvrsiSQLvratiDT(strsaUpitnikomOK, Me.connectionString, Nothing)
                If dtOK.Rows.Count > 0 Then
                    'vrati SE na regularno
                    llPZ.Text = "Replacements"
                    rb1.Text = rb1text
                    llPZ.Tag = ""
                    llRZ.Visible = False
                    Call dajLog(rez)
                    Call adresarUdtAdr()
                End If
            End If

        ElseIf Not kljucIzDGVA Is Nothing AndAlso kljucIzDGVA.Trim <> "" Then
            kljucIzDGVA = ""
        ElseIf rez <> 98 AndAlso Me.pamti98.Text <> "" Then
            'daj prvi sledeci iz tekuceg stratuma
            Dim dt As DataTable = CType(dgCALLS.DataSource, System.Data.DataTable)
            Dim stratumIST As String = dajVrIzDG(dgCALLS, dt, 0, "stratumIST")

            If stratumIST = Me.pamti98.Text Then
                'ima, daj sledeci iz istog stratuma
                Call dajLog(rez, 198)
                Call adresarUdtAdr()
            Else
                'nema vise
                Call dajLog(98)
                Call adresarUdtAdr()
            End If

            'If stratumIST <> Me.pamti98.Text Then
            '    'nema vise
            '    Call dajLog(98)
            '    Call adresarUdtAdr()
            'Else
            '    'ima, daj sledeci iz istog stratuma
            '    Call dajLog(rez, 198)
            '    Call adresarUdtAdr()
            'End If

        ElseIf rez = 98 Then
            Call dajLog(rez)
            Call adresarUdtAdr()
        Else
            rez = 0 'svi
            If llZakazani.Text = ".All." Then rez = 6 'u modu sam za zakazane
            Call dajLog(rez)
            Call adresarUdtAdr()
        End If

        'osvezi dtCALLSbtn
        If Not dtCALLS Is Nothing AndAlso dtCALLS.Rows.Count > 0 Then
            Dim red As DataRow = dtCALLS.Rows(0)
            'ucitaj iz adresara podatke u deo za ....
            Dim kljuc As String = dtCALLS.Rows(0).Item("kljuc").ToString.Trim

            ReDim Vklj(0, 1)
            Vklj(0, 0) = spremiKljucString(adresarCati).Trim.ToUpper
            Vklj(0, 1) = kljuc.Trim.ToUpper

            Dim pokusaj As String = "0"
            Me.lblPokusaj.Text = "0"
            pokusaj = dtCALLS.Rows(0).Item("pokusaj").ToString.Trim()
            Dim stratumIST As String = dtCALLS.Rows(0).Item("stratumIST").ToString.Trim
            Dim novitelefon As String = dtCALLS.Rows(0).Item("novitelefon").ToString.Trim
            Dim komentarAnketara As String = dtCALLS.Rows(0).Item("komentarAnketara").ToString.Trim

            Me.lblKljuc.Text = kljuc.Trim
            Me.lblStratum.Text = stratumIST.Trim
            If pokusaj.Trim = "" Then pokusaj = "0"
            Me.lblPokusaj.Text = pokusaj.Trim

            Me.txtKomentarAnketara.Text = ""

            If komentarAnketara <> "" Then
                Me.txtKomentarAnketara.Visible = True
                Me.txtKomentarAnketara.Enabled = False
                Me.txtKomentarAnketara.Text = komentarAnketara
            End If

            Dim dv As New System.Data.DataView(dtAdr)
            dv.RowFilter = "kljuc='" & kljuc & "'"
            If dv.Count > 0 Then
                Dim redv As DataRow = dv(0).Row
                DGTabele(0).ImportRow(redv)
                dajPodatkeIzAdr(redv, novitelefon)
            End If
            If nizTelefona.Length = 0 Then
                Me.txtT.Enabled = True
                Me.txtT.Focus()
                Me.txtT.BackColor = Color.Thistle
            Else
                Me.btnCCall.Focus()
            End If
        Else
            If rez <> 6 Then
                ''msg 176
                Dim msgtxt176 As String = getMessageText(dtMessages, "176", Me.jezik)
                ISTMessageBox.Show(nvrd + nvrd + msgtxt176 + nvrd + nvrd)
                rez = 999999999
                Call ponistiPoljaAdresar()
            Else
                ''msg 177
                Dim msgtxt177 As String = getMessageText(dtMessages, "177", Me.jezik)
                ISTMessageBox.Show(nvrd + nvrd + msgtxt177 + nvrd + nvrd)
                Call zakazaniPromena()
            End If
        End If

    End Sub

    Public nizTelefona As String() = {}

    Sub ponistiPoljaAdresar()
        For Each k As System.Windows.Forms.Control In Me.Panel1.Controls
            If TypeOf k Is TextBox AndAlso Mid(k.Name.ToString.Trim.ToUpper, 1, 1) = "T" Then
                k.Text = ""
            End If
        Next
        Me.txtT.Text = ""
    End Sub

    Sub dajPodatkeIzAdr(ByVal red As DataRow, ByVal novitelefon As String)
        Dim ur As System.Data.DataRow = red 'jer bi morao biti samo jedan?
        'DODELA VREDNOSTI
        Dim i As Integer = -1
        nizTelefona = {}
        For Each k As System.Windows.Forms.Control In Me.Panel1.Controls
            If TypeOf k Is TextBox AndAlso Mid(k.Name.ToString.Trim.ToUpper, 1, 1) = "T" Then
                If ur.Item(Mid(k.Name.Trim.ToUpper, 3)) Is System.DBNull.Value Then
                    k.Text = ""
                Else
                    Dim plj As String = (Mid(k.Name.Trim.ToUpper, 3))
                    k.Text = ""
                    k.Text = ur.Item(Mid(k.Name.Trim.ToUpper, 3))
                    k.Text = k.Text.Trim

                    If poljeUAdr_Telefon1 <> "" AndAlso plj = poljeUAdr_Telefon1 Then
                        i = i + 1
                        ReDim Preserve nizTelefona(i)
                        nizTelefona(i) = k.Text
                    End If
                    If poljeUAdr_Telefon2 <> "" AndAlso plj = poljeUAdr_Telefon2 Then
                        i = i + 1
                        ReDim Preserve nizTelefona(i)
                        nizTelefona(i) = k.Text
                    End If
                    If poljeUAdr_Telefon3 <> "" AndAlso plj = poljeUAdr_Telefon3 Then
                        i = i + 1
                        ReDim Preserve nizTelefona(i)
                        nizTelefona(i) = k.Text
                    End If
                End If
            ElseIf TypeOf k Is TextBox AndAlso Mid(k.Name.ToString.Trim.ToUpper, 1, 2) = "FP" Then
            End If 'T ili grid
        Next 'for kontrole

        'napomena TREBA učitati su samo one koji imaju telefone!!!
        Dim prviKojiPostoji As Integer = 0
        For ii As Integer = 0 To nizTelefona.GetUpperBound(0)
            If Not nizTelefona(ii) Is Nothing AndAlso nizTelefona(ii).Trim <> "" Then
                prviKojiPostoji = ii
                Exit For
            End If
        Next

        Me.txtT.Text = ""
        If novitelefon <> "" Then
            'ako je nov telefon idu podaci iz Log-a
            Me.txtT.Text = novitelefon
        Else
            If nizTelefona.Length = 0 Then
                Me.txtT.Text = ""
            Else
                Me.txtT.Text = nizTelefona(prviKojiPostoji)
            End If
        End If

        Dim t As TextBox = NadjiKontroluSkr(Me.Panel1, poljeUAdr_KomentarZaAnketara, 2)
        If Not t Is Nothing Then Me.txtNapomena.Text = t.Text
        DodajFalsove(red, True, True)

    End Sub

    Private Sub Podesi_Formu()

        Dim ww As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width 'Me.Width
        Dim hh As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height 'Me.Height

        btnCIzlaz.Location = New System.Drawing.Point(ww - btnCIzlaz.Width - 2 * 20, 8 - 2)

        Dim ww3 As Integer = ww * 30 / 100
        Me.Panel1.Width = ww3 - 2 * 20
        Panel1.Location = New System.Drawing.Point(15, Me.txtInstrukcije.Location.Y + Me.txtInstrukcije.Height + 20)

        Me.panel2.Width = (ww - ww3) - 2 * 20
        panel2.Location = New System.Drawing.Point(Me.Panel1.Location.X + Panel1.Width + 20, Me.Panel1.Location.Y)
        panel2.Height = hh - (Me.txtInstrukcije.Location.Y + Me.txtInstrukcije.Height) - 6 * 20
        Me.gbRezultat.Width = panel2.Width - 20
        Me.txtNapomena.Width = gbRezultat.Width / 2 - 5
        Me.txtKomentarAnketara.Location = New Point(Me.txtNapomena.Location.X + Me.txtNapomena.Width + 5, Me.txtNapomena.Location.Y)
        Me.lblCNapomena1.Location = New Point(Me.txtNapomena.Location.X + Me.txtNapomena.Width + 5, Me.lblCNapomena.Location.Y)
        Me.txtKomentarAnketara.Width = gbRezultat.Width / 2 - 5

        txtInstrukcije.Location = New System.Drawing.Point(Me.GBGODC.Location.X + Me.GBGODC.Width + 20, 20)
        Me.txtInstrukcije.Width = ww - (Me.GBGODC.Location.X + Me.GBGODC.Width + btnCIzlaz.Width + 3 * 20)

        Me.dgHistory.Width = panel2.Width - 40
        Me.dgCALLS.Width = panel2.Width - 40
        dgHistory.Height = 1 * (panel2.Height - 20) / 3 - 30
        Me.dgCALLS.Location = New Point(dgHistory.Location.X, dgHistory.Location.Y + dgHistory.Height + 5)

        dgCALLS.Height = 2 * (panel2.Height - 20) / 4 - 150
        dgCALLS.Dock = DockStyle.Bottom

    End Sub

    Private Sub btnCCall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCCall.Click
        Call zCALL()
        Me.txtT.Enabled = False
        Me.txtT.BackColor = SystemColors.Window
    End Sub

    Private Sub btnHangUp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnHangU.Click
        'Call zHANGUP()
    End Sub

    Sub zCALL()
        enableGB(gbRezultat, rb7)
        Me.txtNapomena.ReadOnly = True
        Me.lblC.Text = trenutnoDatumVremeSaServera()
        If Me.lblPokusaj.Text = "" Then Me.lblPokusaj.Text = "0"
        Me.lblPokusaj.Text = (CInt(Me.lblPokusaj.Text.Trim) + 1).ToString.Trim
        If (Me.txtT.Text.Trim().Length > 0) Then

            If txtZoiper = "FALSE" Then
            Else
                Me.MakePhoneCall(Me.txtT.Text)
            End If

        End If
        Me.btnCCall.Enabled = False
        Me.btnCCall.BackColor = Color.Gray
    End Sub

    Private Sub MakePhoneCall(ByVal phoneNumber As String)

        Try
            phoneNumber = phoneNumber.Replace("/", "").Replace("\", "").Replace("-", "").Replace(" ", "").Replace(".", "").Replace("_", "").Trim

            Dim a As Boolean = CheckIfRunning()

            Dim info As New ProcessStartInfo("C:\Zoiper\zoiper.exe")
            Dim p As String = "dial_string=" + phoneNumber
            info.WindowStyle = ProcessWindowStyle.Maximized
            info.UseShellExecute = True
            info.Arguments = p

            'za XP ovo ne treba

            'Windows XP 64-Bit Edition	5.2
            'Windows XP	5.1
            If Environment.OSVersion.Version.Major = 5 AndAlso
                (Environment.OSVersion.Version.Minor = 1 OrElse Environment.OSVersion.Version.Minor = 2) Then
                'xp
            Else
                info.Verb = "runas"

            End If
            Process.Start(info)
        Catch ex As Exception

        End Try

        'RunIt(info)
    End Sub

    Dim p() As Process

    Private Function CheckIfRunning() As Boolean
        p = Process.GetProcessesByName("zoiper")
        If p.Length > 0 Then
            ' Process is running
        Else
            ' Process is not running
        End If
    End Function

    'Private WithEvents MyProcess As Process
    'Private Sub MyProcess_Exited(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyProcess.Exited
    '    MyProcess = Nothing
    'End Sub
    'Private Sub RunIt(info)
    '    MyProcess = Process.Start(info)
    'End Sub
    'Private Sub StopIt()
    '    If MyProcess IsNot Nothing Then

    '        '' Close process by sending a close message to its main window.
    '        'MyProcess.CloseMainWindow()
    '        '' Free resources associated with process.
    '        'MyProcess.Close()

    '        Dim proc = Process.GetProcessesByName("zoiper")
    '        For i As Integer = 0 To proc.length - 1
    '            'proc(i).CloseMainWindow()
    '            proc(i).kill
    '            proc(i).waitforexit(5000)
    '        Next i

    '    End If
    'End Sub
    'Sub zHANGUP()
    '    'HANGUP
    '    Me.gbRezultat.Enabled = True
    '    Me.txtNapomena.Enabled = True
    '    StopIt()

    '    Try
    '        'Dim info As New ProcessStartInfo("Taskkill /F /IM Zoiper.exe")
    '        'info.UseShellExecute = True
    '        'info.Verb = "runas"
    '        'Process.Start(info)
    '    Catch ex As Exception

    '    End Try
    'End Sub
    Private Sub btnH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lblH.Text = trenutnoDatumVremeSaServera()
    End Sub

    Sub pCuvaj(Optional rez As Integer = 0)

        Me.lblH.Text = trenutnoDatumVremeSaServera()
        Try
            If Me.lblH.Text.Trim = "" Then Me.lblH.Text = trenutnoDatumVremeSaServera()
            If rez = 0 Then rez = rezultat(Me.gbRezultat)
            Call zCuvaj()

            If rez = 3 Then
                Call prikaziPokusaje()
                Call zCALL()
                Me.gbRezultat.Focus()
            ElseIf rez = 7 Then
                Call prikaziPokusaje()
            ElseIf rez = 71 Then
                Call prikaziPokusaje()
            ElseIf rez = 99 Then
                Call prikaziPokusaje()
                Me.txtT.Text = SlBrojIzAdr(Me.txtT.Text)
                Call zCALL()
                Me.gbRezultat.Focus()
            End If
            Call ponistirezultat(Me.gbRezultat)
            If rez <> 3 AndAlso rez <> 7 AndAlso rez <> 99 Then
                Me.btnCCall.Enabled = True
                Me.btnCCall.BackColor = Color.MediumSeaGreen
            End If
            If rez <> 3 AndAlso rez <> 7 AndAlso rez <> 71 AndAlso rez <> 99 Then
                Call sledeci()
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Function SlBrojIzAdr(ByVal tel As String) As String
        SlBrojIzAdr = tel
        For ii As Integer = 0 To nizTelefona.GetUpperBound(0)
            If Not nizTelefona(ii) Is Nothing AndAlso nizTelefona(ii).Trim <> "" AndAlso nizTelefona(ii).Trim <> "." Then
                If Me.txtT.Text.Trim = nizTelefona(ii) Then
                    If ii + 1 <= nizTelefona.GetUpperBound(0) AndAlso Not nizTelefona(ii + 1) Is Nothing AndAlso nizTelefona(ii + 1).Trim <> "" Then
                        SlBrojIzAdr = nizTelefona(ii + 1).Trim()
                    ElseIf ii + 2 <= nizTelefona.GetUpperBound(0) AndAlso Not nizTelefona(ii + 2) Is Nothing AndAlso nizTelefona(ii + 2).Trim <> "" Then
                        SlBrojIzAdr = nizTelefona(ii + 2).Trim()
                    Else
                        'vraca se na prvi
                        SlBrojIzAdr = nizTelefona(0).Trim()
                    End If
                    'Exit For
                End If
            End If
        Next
        Return SlBrojIzAdr
    End Function

    Function postojiTelefonUAdr(ByVal tel As String) As Boolean
        postojiTelefonUAdr = False
        For ii As Integer = 0 To nizTelefona.GetUpperBound(0)
            If Not nizTelefona(ii) Is Nothing AndAlso nizTelefona(ii).Trim <> "" Then
                If tel = nizTelefona(ii) Then
                    postojiTelefonUAdr = True
                    Exit For
                End If
            End If
        Next
        Return postojiTelefonUAdr
    End Function

    Sub zCuvaj(Optional rr As Integer = -5, Optional catikljuc As String = "")
        Dim replacement As String = ""
        Dim sentEmailAddress As String = ""
        Dim rez As Integer = rezultat(Me.gbRezultat)
        If rez = 1 And llPZ.Tag <> "" Then replacement = "R"
        If rr <> -5 Then rez = rr
        If (rez = 0 OrElse rez = 7) AndAlso Me.txtKomentarAnketara.Visible = True AndAlso Me.txtKomentarAnketara.Text.Trim.Length > 0 _
            AndAlso Me.txtKomentarAnketara.Text.Trim <> "" AndAlso Me.txtT.Text.Trim = "" Then
            rez = 13
            Dim pom As Integer = Me.lblPokusaj.Text.Trim
            pom = pom + 1
            Me.lblPokusaj.Text = pom
        ElseIf rez = 7 Then
            Dim pom As Integer = Me.lblPokusaj.Text.Trim
            pom = pom + 1
            Me.lblPokusaj.Text = pom
        ElseIf rez = 0 Then
            Dim pom As Integer = Me.lblPokusaj.Text.Trim
            pom = pom + 1
            Me.lblPokusaj.Text = pom
        End If

        Dim b As String = zvatiU(rez)
        Dim neZvatiVise As Integer = 0
        If b = "0" Then
            b = "Null" 'nema više zvanja
            neZvatiVise = 1
        Else
            b = "'" + b + "'"
        End If

        Dim imaupitnik As Integer = 0
        If rez = 1 Then imaupitnik = 1
        If rez = 0 Then imaupitnik = 0 : neZvatiVise = 0
        If rez = 13 Then neZvatiVise = 1
        If rez = 12 Then neZvatiVise = 1 : sentEmailAddress = txtEMAIL.Text
        If rez = 14 Then imaupitnik = 1 : neZvatiVise = 1 : Me.lblKljuc.Text = catikljuc

        If rez = 61 Then imaupitnik = 1 : neZvatiVise = 1 : Me.lblKljuc.Text = catikljuc
        Dim sql As String = ""
        'insert into ISTCATILog

        Dim hostName As String = GetHostName()
        Dim novitelefon As String = ""
        If rezultat(Me.gbRezultat).ToString.Trim = 99 Then 'sledeciTelefon
            If postojiTelefonUAdr(Me.txtT.Text.Trim) = False Then novitelefon = Me.txtT.Text.Trim
        Else
            If postojiTelefonUAdr(Me.txtT.Text.Trim) = False Then novitelefon = Me.txtT.Text.Trim
        End If

        If Me.lblC.Text.Trim.Length = 0 Then Me.lblC.Text = trenutnoDatumVremeSaServera()
        If Me.lblH.Text.Trim.Length = 0 Then Me.lblH.Text = trenutnoDatumVremeSaServera()

        Dim pokussajj As String = Me.lblPokusaj.Text.Trim
        Dim tteelleeffoonn As String = Me.txtT.Text.Trim

        If rez = 14 Then tteelleeffoonn = "" : pokussajj = "99"
        If rez = 61 Then tteelleeffoonn = "" : pokussajj = "99"

        Dim sqllog As String = "select max(pokusaj) as mp from " + Me.catiprefix + "istcatilog where " +
            " ISTyear='" + Me.GG + "' and ISTmonth='" + Me.MM + "' and sifist='" + sifist + "' and tabela='" +
                tabela + "' and kljuc='" + Me.lblKljuc.Text.Trim + "'"
        Dim dt1 As New DataTable
        dt1 = izvrsiSQLvratiDT(sqllog, Me.connectionString, Nothing)
        If dt1.Rows.Count > 0 AndAlso dt1.Rows(0).Item("mp").ToString.Trim <> "" Then
            If IsNumeric(dt1.Rows(0).Item("mp").ToString.Trim) AndAlso CInt(dt1.Rows(0).Item("mp").ToString.Trim) > 0 Then
                pokussajj = CInt(dt1.Rows(0).Item("mp").ToString.Trim) + 1
            End If
        End If

        Dim gma As String = imaGMAnketar(adresarCati)
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        Dim sqlW As String = " where 2=2 "
        If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
        If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
        If gma.Substring(2, 1) = "T" Then
            sqlW = sqlW + " and anketar='" + anketar + "'"
            sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
        End If
        If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
        If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"

        ''Me.lblStratum.Text.Trim()
        Dim sqlstratum As String = "select " + dajPKLJUC() + " As kljuc," + dajPSTRATUM() + " as stratumIST  from " + adr + sqlW + " and " + dajPKLJUC() + "='" + Me.lblKljuc.Text.Trim + "'"
        Dim dt8 As New System.Data.DataTable
        dt8 = izvrsiSQLvratiDT(sqlstratum, Me.DBConnectionString, Nothing)

        If dt8.Rows.Count > 0 Then
            Me.lblStratum.Text = dt8.Rows(0).Item("stratumIST")
        End If

        sql = sql & "insert into " + Me.catiprefix + "[ISTCATILog] (ISTyear,ISTmonth,sifist,tabela,anketar,logOn," +
            " kljuc,pokusaj,hostName,telefon,pozivStart,pozivEnd," +
            " rezultat,zvatiU,imaUpitnik,neZvatiVise,stratumIST,novaAdresa,noviTelefon,komentarAnketara,replacement,sentEmailAddress) values " +
            "('" + Me.GG + "','" + Me.MM + "','" + sifist + "','" + tabela + "','" + anketar + "','" + logOnA + "','" +
            Me.lblKljuc.Text.Trim + "','" + pokussajj + "','" + hostName + "','" + tteelleeffoonn + "','" + Me.lblC.Text.Trim + "','" + Me.lblH.Text.Trim + "'," +
            rez.ToString.Trim + "," + b + "," + imaupitnik.ToString.Trim + "," + neZvatiVise.ToString.Trim + ",'" + Me.lblStratum.Text.Trim +
            "','" + Me.txtNovaAdresa.Text.Trim + "','" + novitelefon + "','" + Me.txtKomentarAnketara.Text.Trim + "','" + replacement + "','" + sentEmailAddress + "');"
        'End If

        Dim odg As String = izvrsiSQL(sql, Me.CATIConnectionString)
        If odg = "nok" Then
            ''msg 178
            Dim msgtxt178 As String = getMessageText(dtMessages, "178", Me.jezik)
            Dim ppp As String = msgtxt178
            ISTMessageBox.Show(ppp + nvrd + sql, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If uzorak = "P" Then
            'prost uzorak
        ElseIf uzorak = "K" Then
            'kvota uzorak
        ElseIf uzorak = "S" Then
            'stratumski;kolona koja je stratumIST;stratumISTBroj
            'ako je došao do stratumISTBroj sa ispunjenim upitnicima onda update taj stratumIST na nezvativise=1
            sql = "select count(*) as broj from " + Me.catiprefix + "[ISTCATILog] A" +
            " where 2=2 " + sqlISTGM + " and sifist='" + sifist + "'  and tabela='" + tabela + "'" +
            " and imaUpitnik=1 and stratumIST='" + Me.lblStratum.Text + "'"

            If poljeUAdr_kvotaPoStratumu <> "" Then
                'postoji poljeUAdr_kvotaPoStratumu
                'procitaj ga iz adresara
                Dim sql1 As String = "select max(" + poljeUAdr_kvotaPoStratumu + ") as broj from " +
                " (select " + poljeUAdr_kvotaPoStratumu + "," + dajPSTRATUM() + " as stratumIST  from " + adr + sqlW + ") as A " +
                " where stratumIST ='" + Me.lblStratum.Text + "'"

                Dim dt0 As New System.Data.DataTable
                dt0 = izvrsiSQLvratiDT(sql1, Me.DBConnectionString, Nothing)
                If dt0.Rows.Count > 0 AndAlso Not dt0.Rows(0).Item("broj") Is Nothing Then
                    Dim kvotaPostratumu As Integer = CInt(dt0.Rows(0).Item("broj").ToString.Trim)
                    stratumISTBroj = kvotaPostratumu
                End If
            Else
                'stratumISTBroj je stratumISTBroj iz ISTCATIDef
            End If

            Dim dt As New System.Data.DataTable
            dt = izvrsiSQLvratiDT(sql, Me.connectionString, Nothing)
            If dt.Rows.Count > 0 AndAlso Not dt.Rows(0).Item("broj") Is Nothing AndAlso CInt(dt.Rows(0).Item("broj").ToString.Trim) >= stratumISTBroj Then
                sql = "update A set neZvatiVise=1 " +
                " FROM " + Me.catiprefix + "[ISTCATILog] A " +
                " where 2=2 " + sqlISTGM + " and sifist='" + sifist + "'  and tabela='" + tabela + "'" +
                " and neZvatiVise=0 and stratumIST='" + Me.lblStratum.Text + "'"

                odg = izvrsiSQL(sql, Me.CATIConnectionString)
                If odg = "nok" Then
                    ''msg 179
                    Dim msgtxt179 As String = getMessageText(dtMessages, "179", Me.jezik)
                    Dim ppp As String = msgtxt179
                    ISTMessageBox.Show(ppp + nvrd + sql, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
                Call adresarUdtAdr()
            End If
        End If

        'Me.gbRezultat.Enabled = False
        disableGB(gbRezultat, rb7, rb14)

        Me.lblC.Text = ""
        Me.lblH.Text = ""
    End Sub

    Function sklopiSQLCEOStratum(ByVal stratumist As String, ByVal zvatiU As String, ByVal hostname As String, ByVal pokussajj As String) As String

        Call adresarUdtAdr()
        Dim sql As String = ""
        Dim dv As New System.Data.DataView(dtAdr)
        dv.RowFilter = "stratumIST='" & stratumist & "'"
        If dv.Count > 0 Then
            For i As Integer = 0 To dv.Count - 1
                'pokusaj je deo kljuca
                Dim redv As DataRow = dv(i).Row
                Dim kljuc As String = redv("kljuc").ToString.Trim
                Dim sqllog As String = "select max(pokusaj) as mp from " + Me.catiprefix + "istcatilog where ISTyear='" + Me.GG + "' and ISTmonth='" + Me.MM + "' and sifist='" + sifist + "' and tabela='" +
                tabela + "' and kljuc='" + kljuc + "'"
                Dim dt As New DataTable
                dt = izvrsiSQLvratiDT(sqllog, Me.connectionString, Nothing)
                If dt.Rows.Count > 0 AndAlso dt.Rows(0).Item("mp").ToString.Trim <> "" Then
                    If IsNumeric(dt.Rows(0).Item("mp").ToString.Trim) AndAlso CInt(dt.Rows(0).Item("mp").ToString.Trim) > 0 Then
                        pokussajj = CInt(dt.Rows(0).Item("mp").ToString.Trim) + 1
                    End If
                End If

                sql = sql & "insert into " + Me.catiprefix + "[ISTCATILog] (ISTyear,ISTmonth,sifist,tabela,anketar,logOn," +
            "kljuc,pokusaj,hostName,telefon,pozivStart,pozivEnd," +
            " rezultat,zvatiU,imaUpitnik,neZvatiVise,stratumIST,novaAdresa,noviTelefon,komentarAnketara,replacement,napomena) values " +
            "('" + Me.GG + "','" + Me.MM + "','" + sifist + "','" + tabela + "','" + anketar + "','" + logOnA + "','" +
            kljuc + "','" + pokussajj + "','" + hostname + "','','','',6 ," + zvatiU + ", 0, 0 ,'" + stratumist +
            "','','','" + Me.txtKomentarAnketara.Text.Trim + "','','zakazan sa celim stratumom');" + nvrd
            Next
        End If
        sklopiSQLCEOStratum = sql
    End Function

    Public Function zvatiU(ByVal rezultat As Integer) As String
        Dim um As Integer = 1
        If Me.txtMM.Text.Trim <> "" Then
            If CInt(Me.txtMM.Text.Trim) = 2880 Then um = 2
        End If
        'vremeZvanjaOd
        'vremeZvanjaDo
        Dim danaspom As String = trenutnoDatumVremeSaServeraDT().ToString("yyyy.MM.dd")
        danaspom = danaspom + " " + vremeZvanjaDo
        'ISTMessageBox.Show(danaspom)
        Dim danas As DateTime = CDate(danaspom)
        Dim sutrapomOD As String = CDate(danaspom).AddDays(um).ToString("yyyy.MM.dd")
        Dim sutrapomDO As String = CDate(danaspom).AddDays(um).ToString("yyyy.MM.dd")

        sutrapomOD = sutrapomOD + " " + vremeZvanjaOd
        sutrapomDO = sutrapomDO + " " + vremeZvanjaDo
        Dim sutraOD As DateTime = CDate(sutrapomOD)
        Dim sutraDO As DateTime = CDate(sutrapomDO)
        Dim brojMinuta As Integer = (sutraDO - sutraOD).Hours * 60

        If Me.txtMM.Text.Trim = "" Then zvatiU = trenutnoDatumVremeSaServera()
        zvatiU = "0"
        Dim novoVreme As DateTime = trenutnoDatumVremeSaServeraDT()
        Dim sada As DateTime = trenutnoDatumVremeSaServeraDT()
        Select Case rezultat
            Case 1, 2, 8, 9, 10, 11, 12, 13, 61, 14
                'nema vise zvanja
                zvatiU = "0"
            Case 3, 7, 71, 99
                zvatiU = trenutnoDatumVremeSaServera()
            Case 4, 5
                'cita MM i vodi računa da nije otišlo preko datog vremena vremeDO
                If Me.txtMM.Text.Trim <> "" Then novoVreme = novoVreme.AddMinutes(CInt(Me.txtMM.Text.Trim))

                If novoVreme > danas Then
                    'bilooooo    novoVreme = sutraOD
                    Dim rnd As New Random
                    Dim i As Integer = rnd.Next(1, brojMinuta)
                    Dim dt As Date = sutraOD.AddMinutes(i)
                    novoVreme = dt
                End If
                zvatiU = novoVreme.ToString("yyyy.MM.dd HH:mm")
            Case 6
                Dim dd As String = dtp2.Value.ToString("yyyy.MM.dd")
                Dim HHmm As String = Me.cboHour.Text
                zvatiU = dd & " " & HHmm 'novoVreme.ToString("yyyy.MM.dd HH:mm")
                If txtMode = "CLOUDCATI" Then
                    zvatiU = CDate(zvatiU).AddHours(-1).ToString("yyyy.MM.dd HH:mm")
                End If

        End Select
    End Function

    Private Function rezultat(ByVal grp As GroupBox) As Integer
        Dim rbtn As RadioButton
        Dim rbtnName As String = String.Empty
        Try
            Dim ctl As Control
            For Each ctl In grp.Controls
                If TypeOf ctl Is RadioButton Then
                    rbtn = DirectCast(ctl, RadioButton)
                    If rbtn.Checked Then
                        rbtnName = rbtn.Name.Trim.ToUpper.Replace("RB", "")
                        rezultat = CInt(rbtnName)
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            Dim stackframe As New Diagnostics.StackFrame(1)
            Throw New Exception("An error occurred in routine, '" & stackframe.GetMethod.ReflectedType.Name & "." & System.Reflection.MethodInfo.GetCurrentMethod.Name & "'." & Environment.NewLine & "  Message was: '" & ex.Message & "'")
        End Try
        If rbtnName = "" Then rezultat = 0
    End Function

    Public Sub ponistirezultat(ByVal grp As GroupBox)
        Call odcekirajRB(grp)
        Me.txtEMAIL.Text = ""
        Me.txtKomentarAnketara.Text = ""
        Me.txtMM.Text = ""

        Me.txtKomentarAnketara.Visible = False
        Call zakazivanjeNeVisible()
    End Sub

    Public Sub ponistirezultat6(ByVal grp As GroupBox)
        Call odcekirajRB(grp)
        Me.txtEMAIL.Text = ""
        Me.txtKomentarAnketara.Text = ""
        Me.txtMM.Text = ""

        Me.txtKomentarAnketara.Visible = False
        Call zakazivanjeNeVisible()
    End Sub

    Private Sub disableGB(ByVal grp As GroupBox, ByVal rb1 As RadioButton, ByVal rb2 As RadioButton)

        Dim rbtnName As String = String.Empty
        Try
            Dim ctl As Control
            For Each ctl In grp.Controls
                If TypeOf ctl Is RadioButton AndAlso ctl.Name.Trim.ToUpper <> rb1.Name.Trim.ToUpper AndAlso ctl.Name.Trim.ToUpper <> rb2.Name.Trim.ToUpper Then
                    DirectCast(ctl, RadioButton).Enabled = False
                End If
            Next
        Catch ex As Exception
            Dim stackframe As New Diagnostics.StackFrame(1)
            Throw New Exception("An error occurred in routine, '" & stackframe.GetMethod.ReflectedType.Name & "." & System.Reflection.MethodInfo.GetCurrentMethod.Name & "'." & Environment.NewLine & "  Message was: '" & ex.Message & "'")
        End Try

    End Sub

    Private Sub enableGB(ByVal grp As GroupBox, ByVal rb As RadioButton)
        Dim rbtnName As String = String.Empty
        Try
            Dim ctl As Control
            For Each ctl In grp.Controls
                If TypeOf ctl Is RadioButton Then
                    DirectCast(ctl, RadioButton).Enabled = True
                End If
            Next
        Catch ex As Exception
            Dim stackframe As New Diagnostics.StackFrame(1)
            Throw New Exception("An error occurred in routine, '" & stackframe.GetMethod.ReflectedType.Name & "." & System.Reflection.MethodInfo.GetCurrentMethod.Name & "'." & Environment.NewLine & "  Message was: '" & ex.Message & "'")
        End Try

    End Sub

    Sub odcekirajRB(ByVal grp As GroupBox)
        Dim rbtn As RadioButton
        Dim rbtnName As String = String.Empty
        Try
            Dim ctl As Control
            For Each ctl In grp.Controls
                If TypeOf ctl Is RadioButton Then
                    rbtn = DirectCast(ctl, RadioButton)
                    If rbtn.Checked Then
                        rbtn.Checked = False
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            Dim stackframe As New Diagnostics.StackFrame(1)
            Throw New Exception("An error occurred in routine, '" & stackframe.GetMethod.ReflectedType.Name & "." & System.Reflection.MethodInfo.GetCurrentMethod.Name & "'." & Environment.NewLine & "  Message was: '" & ex.Message & "'")
        End Try

    End Sub

    Sub enableRB(ByVal grp As GroupBox, ByVal rb As RadioButton)
        Dim rbtn As RadioButton
        Dim rbtnName As String = String.Empty
        Try
            Dim ctl As Control
            For Each ctl In grp.Controls
                If TypeOf ctl Is RadioButton Then
                    rbtn = DirectCast(ctl, RadioButton)
                    rbtnName = rbtn.Name.Trim.ToUpper.Replace("RB", "")
                    If rbtnName = rb.Name.Trim.ToUpper Then

                    End If
                    rbtn.Enabled = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            Dim stackframe As New Diagnostics.StackFrame(1)
            Throw New Exception("An error occurred in routine, '" & stackframe.GetMethod.ReflectedType.Name & "." & System.Reflection.MethodInfo.GetCurrentMethod.Name & "'." & Environment.NewLine & "  Message was: '" & ex.Message & "'")
        End Try
    End Sub

    Function trenutnoDatumVremeSaServera() As String
        Dim sql As String = "select CONVERT(varchar, GETDATE(), 120) as dv"
        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
        If dt.Rows.Count > 0 Then
            trenutnoDatumVremeSaServera = dt.Rows(0).Item("dv").ToString.Trim
        Else
            trenutnoDatumVremeSaServera = System.DateTime.Now.ToString("yyyy.MM.dd HH:mm")
        End If
    End Function

    Function trenutnoVremeSaServera() As String
        Dim sql As String = "select CONVERT(varchar, GETDATE(), 108) as dv"
        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
        If dt.Rows.Count > 0 Then
            trenutnoVremeSaServera = dt.Rows(0).Item("dv").ToString.Trim
        Else
            trenutnoVremeSaServera = System.DateTime.Now.ToString("HH:mm")
        End If
    End Function

    Function trenutnoDatumVremeSaServeraDT() As DateTime
        Dim sql As String = "select  GETDATE() as dv"
        Dim dt As System.Data.DataTable = izvrsiSQLvratiDT(sql, Me.DBConnectionString, Nothing)
        If dt.Rows.Count > 0 Then
            trenutnoDatumVremeSaServeraDT = dt.Rows(0).Item("dv")
        Else
            trenutnoDatumVremeSaServeraDT = System.DateTime.Now
        End If
    End Function

    Private lineName As String = ""

    Private Sub rb1_KeyDown(sender As Object, e As KeyEventArgs) Handles rb1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call unosIST()
            Me.Cursor = System.Windows.Forms.Cursors.Default
            'Dim rbtn As System.Windows.Forms.RadioButton = CType(sender, System.Windows.Forms.RadioButton)
        End If
    End Sub

    Private Sub rb14_KeyDown(sender As Object, e As KeyEventArgs) Handles rb14.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call dodunos("U14")
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub rb1_Click(sender As Object, e As EventArgs) Handles rb1.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb14_Click(sender As Object, e As EventArgs) Handles rb14.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb2_KeyDown(sender As Object, e As KeyEventArgs) Handles rb2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call komentarVisible()
            Call adresaNeVisible()
            Me.txtKomentarAnketara.Focus()
            txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
        End If
    End Sub

    Private Sub rb16_KeyDown(sender As Object, e As KeyEventArgs) Handles rb16.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call komentarVisible()
            Call adresaNeVisible()
            Me.txtKomentarAnketara.Focus()
            txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
        End If
    End Sub

    Private Sub rb2_Click(sender As Object, e As EventArgs) Handles rb2.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb16_Click(sender As Object, e As EventArgs) Handles rb16.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb3_KeyDown(sender As Object, e As KeyEventArgs) Handles rb3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rbtn As System.Windows.Forms.RadioButton = CType(sender, System.Windows.Forms.RadioButton)
            Call komentarNeVisible()
            Call adresaNeVisible()
            Call pCuvaj(RB(rbtn))
        End If
    End Sub

    Private Sub rb3_Click(sender As Object, e As EventArgs) Handles rb3.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb4_KeyDown(sender As Object, e As KeyEventArgs) Handles rb4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rbtn As System.Windows.Forms.RadioButton = CType(sender, System.Windows.Forms.RadioButton)
            'Call komentarNeVisible()
            Call komentarVisible()
            Me.txtKomentarAnketara.Focus()
            txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
            Call adresaNeVisible()
            'Call pCuvaj(RB(rbtn))
        End If
    End Sub

    Private Sub rb4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb4.CheckedChanged
        If rb4.Checked = True Then
            Me.txtMM.Text = pozivZauzet.Trim
        Else
            Me.txtMM.Text = ""
        End If
    End Sub

    Private Sub rb4_Click(sender As Object, e As EventArgs) Handles rb4.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb5_KeyDown(sender As Object, e As KeyEventArgs) Handles rb5.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rbtn As System.Windows.Forms.RadioButton = CType(sender, System.Windows.Forms.RadioButton)
            'Call komentarNeVisible()
            Call komentarVisible()
            Me.txtKomentarAnketara.Focus()
            txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
            Call adresaNeVisible()
            'Call pCuvaj(RB(rbtn))
        End If
    End Sub

    Private Sub rb5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb5.CheckedChanged
        If rb5.Checked = True Then
            Me.txtMM.Text = pozivNeJavljaSe.Trim
        Else
            Me.txtMM.Text = ""
        End If
    End Sub

    Private Sub rb5_Click(sender As Object, e As EventArgs) Handles rb5.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb6_Click(sender As Object, e As EventArgs) Handles rb6.Click
        Call zakazivanjeVisible()
        Call komentarNeVisible()
        Call mailNeVisible()
        Call adresaNeVisible()
        Me.dtp2.Focus()
    End Sub

    Private Sub rb7_KeyDown(sender As Object, e As KeyEventArgs) Handles rb7.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rbtn As System.Windows.Forms.RadioButton = CType(sender, System.Windows.Forms.RadioButton)
            Call adresaVisible()
            txtKomentarAnketara.Visible = False
            Call pCuvaj(RB(rbtn))
        End If
    End Sub

    Private Sub rb7_Click(sender As Object, e As EventArgs) Handles rb7.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb71_KeyDown(sender As Object, e As KeyEventArgs) Handles rb71.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call adresaVisible()
            txtKomentarAnketara.Visible = False
            pCuvaj(71)
        End If
    End Sub

    Private Sub rb71_Click(sender As Object, e As EventArgs) Handles rb71.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb8_KeyDown(sender As Object, e As KeyEventArgs) Handles rb8.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rbtn As System.Windows.Forms.RadioButton = CType(sender, System.Windows.Forms.RadioButton)
            Call komentarVisible()
            Call adresaNeVisible()
            Me.txtKomentarAnketara.Focus()
            txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
        End If
    End Sub

    Private Sub rb8_Click(sender As Object, e As EventArgs) Handles rb8.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb9_KeyDown(sender As Object, e As KeyEventArgs) Handles rb9.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rbtn As System.Windows.Forms.RadioButton = CType(sender, System.Windows.Forms.RadioButton)
            Call komentarVisible()
            Call adresaNeVisible()
            Me.txtKomentarAnketara.Focus()
            txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
        End If
    End Sub

    Private Sub rb9_Click(sender As Object, e As EventArgs) Handles rb9.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb10_KeyDown(sender As Object, e As KeyEventArgs) Handles rb10.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rbtn As System.Windows.Forms.RadioButton = CType(sender, System.Windows.Forms.RadioButton)
            Call komentarVisible()
            Call adresaNeVisible()
            Me.txtKomentarAnketara.Focus()
            txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
        End If
    End Sub

    Private Sub rb10_Click(sender As Object, e As EventArgs) Handles rb10.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb11_KeyDown(sender As Object, e As KeyEventArgs) Handles rb11.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rbtn As System.Windows.Forms.RadioButton = CType(sender, System.Windows.Forms.RadioButton)
            Call komentarVisible()
            Call adresaNeVisible()
            Me.txtKomentarAnketara.Focus()
            txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
        End If
    End Sub

    Private Sub rb11_Click(sender As Object, e As EventArgs) Handles rb11.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb12_Click(sender As Object, e As EventArgs) Handles rb12.Click
        Call mailVisible()
        Call komentarVisible()
        Call zakazivanjeNeVisible()
        Call adresaNeVisible()
        Me.txtEMAIL.Focus()
    End Sub

    Private Sub rb99_KeyDown(sender As Object, e As KeyEventArgs) Handles rb99.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call komentarNeVisible()
            Call adresaNeVisible()
            Call pCuvaj(99)
        End If
    End Sub

    Dim pp98 As String = "''"

    Private Sub rb98_KeyDown(sender As Object, e As KeyEventArgs) Handles rb98.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call komentarNeVisible()
            Call adresaNeVisible()
            Call odcekirajRB(gbRezultat)
            disableGB(gbRezultat, rb7, rb14)
            Dim dt As DataTable = CType(dgCALLS.DataSource, System.Data.DataTable)
            Dim stratumIST As String = dajVrIzDG(dgCALLS, dt, 0, "stratumIST")
            '****************************************
            pp98 = pp98 + ",'" + stratumIST + "'"
            Me.nizpamti98.Text = "(" + pp98 + ")"
            '****************************************
            Call sledeci(98)
            '****************************************
            stratumIST = dajVrIzDG(dgCALLS, dt, 0, "stratumIST")
            Me.pamti98.Text = stratumIST
            '****************************************
            Me.btnCCall.Enabled = True
            Me.btnCCall.BackColor = Color.MediumSeaGreen
            Me.btnCCall.Focus()
        End If
    End Sub

    Private Sub rb98_Click(sender As Object, e As EventArgs) Handles rb1.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub rb99_Click(sender As Object, e As EventArgs) Handles rb99.Click
        Call zakazivanjeNeVisible()
        Call mailNeVisible()
    End Sub

    Private Sub cboHour_KeyDown(sender As Object, e As KeyEventArgs) Handles cboHour.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call mailNeVisible()
            Call adresaNeVisible()
            Call komentarVisible()
            Me.txtKomentarAnketara.Focus()
            txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
            'pCuvaj(6)
        End If
    End Sub

    Private Sub txtKomentarAnketara_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKomentarAnketara.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim rez As Integer = rezultat(Me.gbRezultat)
            e.SuppressKeyPress = True
            If rez <> 0 Then
                If Me.txtKomentarAnketara.Text.Trim.Length = 0 AndAlso rez <> 6 AndAlso rez <> 4 AndAlso rez <> 5 Then
                    Me.txtKomentarAnketara.Focus()
                    txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
                Else
                    Call potvrdaCuvanja()
                End If
            Else
                ''msg 173
                Dim msgtxt173 As String = getMessageText(dtMessages, "173", Me.jezik)
                ISTMessageBox.Show(msgtxt173)
                Me.gbRezultat.Focus()
            End If
        End If
    End Sub

    Private Sub txtKomentarAnketara_Enter(sender As Object, e As EventArgs) Handles txtKomentarAnketara.Enter
        ' ISTMessageBox.Show(txtKomentarAnketara.Text)
        If txtKomentarAnketara.Text.Trim = "" Then
            txtKomentarAnketara.Text = txtNapomena.Text

        End If

    End Sub

    Sub potvrdaCuvanja()
        Dim rez As Integer = rezultat(Me.gbRezultat)
        If rez <> 7 AndAlso rb1.Enabled = True OrElse rez = 7 And rb7.Enabled = True Then
            ''msg 180
            Dim msgtxt180 As String = getMessageText(dtMessages, "180", Me.jezik)
            ''msg 181
            Dim msgtxt181 As String = getMessageText(dtMessages, "181", Me.jezik)
            Dim ppp As DialogResult = ISTMessageBox.Show(msgtxt180, msgtxt181, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            Select Case ppp
                Case DialogResult.Yes
                    If rez = 7 Then
                        rez = 13   'oznaka za sve sam iscrpeo, ne zovi vise
                        Call pCuvaj(13)
                    Else
                        Call pCuvaj()
                    End If
                    Me.btnCCall.Focus()
                Case DialogResult.Cancel
                    Me.DialogResult = DialogResult.None
                    Me.txtKomentarAnketara.Focus()
                    txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
                Case DialogResult.No
            End Select
        End If
    End Sub

    Sub komentarVisible()
        Me.lblCNapomena1.Visible = True
        Me.txtKomentarAnketara.Visible = True
        Me.txtKomentarAnketara.Enabled = True

    End Sub

    Sub komentarNeVisible()
        Me.lblCNapomena1.Visible = False
        Me.txtKomentarAnketara.Visible = False

    End Sub

    Sub zakazivanjeNeVisible()
        Me.dtp2.Visible = False
        Me.cboHour.Visible = False
        'Me.cbST.Visible = False
        'Me.cbST.Checked = False
    End Sub

    Sub zakazivanjeVisible()

        Dim danaspom As String = trenutnoDatumVremeSaServeraDT().ToString("yyyy.MM.dd")
        danaspom = danaspom + " " + vremeZvanjaDo
        Dim danasDo As DateTime = CDate(danaspom)

        Dim sadapom As String = trenutnoDatumVremeSaServeraDT().ToString("yyyy.MM.dd HH:mm")
        Dim sada As DateTime = CDate(sadapom)

        Dim sutrapom As String = CDate(danaspom).AddDays(1).ToString("yyyy.MM.dd")
        sutrapom = sutrapom + " " + vremeZvanjaOd
        Dim sutra As DateTime = CDate(sutrapom)

        Me.dtp2.Visible = True
        If sada > danasDo Then dtp2.Value = sutra
        Me.cboHour.Visible = True
        'If observationunitID = 3 Then cbST.Visible = True
    End Sub

    Sub mailVisible()
        Me.txtEMAIL.Visible = True
        Me.llEMAIL.Visible = True
    End Sub

    Sub mailNeVisible()
        Me.txtEMAIL.Visible = False
        Me.llEMAIL.Visible = False
    End Sub

    Sub adresaNeVisible()
        Me.txtT.Enabled = False
        Me.txtT.BackColor = SystemColors.Window
        Me.txtNovaAdresa.Visible = False
    End Sub

    Sub adresaVisible()
        Me.txtT.Enabled = True
        Me.txtT.Focus()
        Me.txtT.BackColor = Color.Thistle
        Me.txtNovaAdresa.Visible = False    'true
        Me.txtNovaAdresa.Enabled = True
    End Sub

    Private Function RB(ByVal rbtn As RadioButton) As Integer
        Dim rbtnName As String = rbtn.Name.Trim.ToUpper.Replace("RB", "")
        RB = CInt(rbtnName)
    End Function

    Private Sub llSend_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llEMAIL.LinkClicked
        If Me.txtEMAIL.Text = "" Then
            Me.txtEMAIL.Focus()
            Exit Sub
        End If
        Dim oApp As Microsoft.Office.Interop.Outlook._Application
        oApp = New Microsoft.Office.Interop.Outlook.Application

        Dim oMsg As Microsoft.Office.Interop.Outlook._MailItem
        oMsg = oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)

        If subject <> "" Then
            oMsg.Subject = subject
        Else
            ''msg 182
            Dim msgtxt182 As String = getMessageText(dtMessages, "182", Me.jezik)
            Dim por As String = msgtxt182 + nvrd
            ISTMessageBox.Show(por, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If body <> "" Then
            oMsg.Body = body & vbCr & vbCr
        Else
            ''msg 183
            Dim msgtxt183 As String = getMessageText(dtMessages, "183", Me.jezik)
            Dim por As String = msgtxt183 + nvrd
            ISTMessageBox.Show(por, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        oMsg.To = txtEMAIL.Text.Trim

        If bcc <> "" Then oMsg.BCC = bcc

        Dim sBodyLen As String = oMsg.Body.Length
        Dim oAttachs As Microsoft.Office.Interop.Outlook.Attachments = oMsg.Attachments
        Dim oAttach As Microsoft.Office.Interop.Outlook.Attachment = Nothing

        If attach1.Length > 0 Then Call dajAttach(attach1, oAttach, oAttachs, sBodyLen)
        If attach2.Length > 0 Then Call dajAttach(attach2, oAttach, oAttachs, sBodyLen)
        If attach3.Length > 0 Then Call dajAttach(attach3, oAttach, oAttachs, sBodyLen)

        oMsg.Display()
        'oMsg.Send()
        'Clean up
        oApp = Nothing
        oMsg = Nothing
        oAttach = Nothing
        oAttachs = Nothing

        Call pCuvaj(12)
        Call sledeci()

        Me.txtEMAIL.Text = ""
        Me.txtEMAIL.Visible = False
        Me.llEMAIL.Visible = False

        Me.txtT.Focus()

    End Sub

    Sub dajAttach(ByVal att As String, ByVal oAttach As Microsoft.Office.Interop.Outlook.Attachment, ByVal oAttachs As Microsoft.Office.Interop.Outlook.Attachments, ByVal sBodyLen As Integer)
        Dim put1 As String = att.Substring(0, att.LastIndexOf("\"))
        For i As Integer = 0 To System.IO.Directory.GetFiles(put1).Length - 1
            Dim fn As String = System.IO.Directory.GetFiles(put1)(i)
            Dim f As String = att.Substring(attach1.LastIndexOf("\") + 1)
            If (System.IO.Directory.Exists(put1)) AndAlso fn.Substring(fn.LastIndexOf("\") + 1).Trim.ToUpper = f.Trim.ToUpper Then
                oAttach = oAttachs.Add(System.IO.Directory.GetFiles(put1)(i), , sBodyLen + i, fn)
            End If
        Next
    End Sub

    Private Sub LLBeleStrane_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLBeleStrane.LinkClicked
        Call odcekirajRB(gbRezultat)
        System.Diagnostics.Process.Start("http://www.11811.rs/")
    End Sub

    Private Sub llAPR_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llAPR.LinkClicked
        Call odcekirajRB(gbRezultat)
        System.Diagnostics.Process.Start("http://pretraga2.apr.gov.rs/ObjedinjenePretrage/Search/Search")
    End Sub

    Sub dodunos(ByVal sta As String, Optional GlavneIliPomocne As String = Nothing)

        Dim postojislog As Boolean = False
        Dim izscati As Boolean = True
        Dim izazur As Boolean = False

        '**************
        Dim gma As String = imaGMAnketar(adresarCati)
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        Dim kljuc As String = dajPKLJUC()
        Dim kljusSaZarezom As String = dajPKLJUCSaZarezom()

        If kljuc = "" Then
            ''msg 169
            Dim msgtxt169 As String = getMessageText(dtMessages, "169", Me.jezik)
            ''msg 170
            Dim msgtxt170 As String = getMessageText(dtMessages, "170", Me.jezik)
            ISTMessageBox.Show(msgtxt169 + adresarCati + msgtxt170)
        Else
            Dim s As String = ""
            Dim sqlW As String = " where 2=2 "
            Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
            Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
            If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'" : kljusSaZarezom = kljusSaZarezom + "GOD,"
            If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'" : kljusSaZarezom = kljusSaZarezom + "MES,"
            If gma.Substring(2, 1) = "T" Then
                sqlW = sqlW + " and anketar='" + anketar + "'"
                sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
            End If
            If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
            If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"
            Dim sql As String = ""
            'pregled

            'XXXXXXXXXXXXXXXXXXX

            If sta = "P" Then

                If sifist.ToLower.Trim = "arspilot" Then 'And SE("GOD") = "2020" And SE("MES") = "10" Then
                    Call procesARS(True)
                End If

                If sifist.ToLower.Trim <> "arspilot" Then
                    sql = "select " + kljusSaZarezom + poljeUAdr_nazivPreduzeca + ", CONVERT (datetime, pozivStart, 126) as pozivStart" + "," + poljeUAdr_Kontakt + "," + poljeUAdr_Email +
                " From (select *," + kljuc + " as kljuc from " + adr + sqlW + ") A inner Join " +
                " (select * from " + Me.catiprefix + "[ISTCATILog] L" +
                " where 2=2 " + sqlISTGM + " And sifist='" + sifist + "' and tabela='" + tabela + "' and imaupitnik=1 and  pozivStart=(select max(pozivStart) from " + Me.catiprefix + "ISTCATILog " +
                " where 2=2 " + sqlISTGM + " And sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = L.kljuc)) B " +
                " On B.kljuc=A.kljuc And A.anketar=B.anketar" +
                " order by pozivStart desc"
                    Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.connectionString, Nothing)
                    Dim frm As New IstrazivanjaUnos.FormIstUnos(dIst, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.tacv, tabela,
                        izazur, Me.txtInst, Me.txtpismo, Me.txtMode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                        Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, False,,,,,,,,, False, False,,,, False, True, dt, False)
                    Try
                        frm.ShowDialog()
                    Catch ex As System.Exception
                        ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        frm.Dispose()
                    End Try
                    'unos
                End If

            ElseIf sta = "U" OrElse sta = "U14" Then
                If poljeUAdr_kvotaPoStratumu <> "" Then
                    'ovaj koristimo kada imamo definisanu kvotu po stratumu u istCatiDef-u'
                    sql = "select adresar.*,uradjenoPostratumu from ( " +
                    "select " + kljusSaZarezom + poljeUAdr_nazivPreduzeca + "," + poljeUAdr_Kontakt + "," + poljeUAdr_Email + "," +
                    "(select max(sentEmailAddress) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) as sentEmailAddress," +
                       " (select max(KomentarAnketara) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1 and pokusaj=(select max(pokusaj) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1 )) as CommentFromLog , " +
                    poljeUAdr_KomentarZaAnketara + " as CommentFromAdd ," +
                      "   (select max(telefon) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) as Phone , " +
                    poljeUAdr_Telefon1 + " as Phone1 ," + poljeUAdr_Telefon2 + " as Phone2 ," + poljeUAdr_Telefon3 + " as Phone3 " +
                    "," + poljeUAdr_kvotaPoStratumu + "," + stratumIST +
                    " From (select *," + kljuc + " as kljuc from " + adr + sqlW + ") A where not exists " +
                    " (select * from " + Me.catiprefix + "[ISTCATILog] " +
                    " where  2=2" + sqlISTGM + " And sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) " +
                    " union " +
                    " select " + kljusSaZarezom + poljeUAdr_nazivPreduzeca + "," + poljeUAdr_Kontakt + "," + poljeUAdr_Email + "," +
                    "(select max(sentEmailAddress) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) as sentEmailAddress," +
                       " (select max(KomentarAnketara) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1 and pokusaj=(select max(pokusaj) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1 )) as CommentFromLog , " +
                    poljeUAdr_KomentarZaAnketara + " as CommentFromAdd ," +
                    "   (select max(telefon) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) as Phone , " +
                    poljeUAdr_Telefon1 + " as Phone1 ," + poljeUAdr_Telefon2 + " as Phone2 ," + poljeUAdr_Telefon3 + " as Phone3 " +
                    "," + poljeUAdr_kvotaPoStratumu + "," + stratumIST +
                    " From (select *," + kljuc + " as kljuc from " + adr + sqlW + ") A where " +
                    " exists (select * from " + Me.catiprefix + "ISTCATILog where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and rezultat=12) " +
                    " and not exists (select * from " + Me.catiprefix + "ISTCATILog where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and rezultat=14) " +
                    " and not exists (select * from " + Me.catiprefix + "ISTCATILog where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and rezultat=61) " +
                    ") as adresar left join " + Me.catiprefix + "f_NumberOfResponsePerStratum('" + sifist + "' ,'" + tabela + "','" + GG + "','" + MM + "') as stratum 	on adresar.stratum=stratum.stratumIst" +
                    " order by 1"
                Else
                    'inace
                    sql = "select " + kljusSaZarezom + poljeUAdr_nazivPreduzeca + "," + poljeUAdr_Kontakt + "," + poljeUAdr_Email + "," +
                    "(select max(sentEmailAddress) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) as sentEmailAddress," +
                    " (select max(KomentarAnketara) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1 and pokusaj=(select max(pokusaj) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1 )) as CommentFromLog , " +
                    poljeUAdr_KomentarZaAnketara + " as CommentFromAdd ," +
                    " (select max(telefon) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) as Phone , " +
                    poljeUAdr_Telefon1 + " as Phone1 ," + poljeUAdr_Telefon2 + " as Phone2 ," + poljeUAdr_Telefon3 + " as Phone3 " +
                     "," + stratumIST +
                    " From (select *," + kljuc + " as kljuc from " + adr + sqlW + ") A where not exists " +
                    " (select * from " + Me.catiprefix + "[ISTCATILog] " +
                    " where  2=2" + sqlISTGM + " And sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) " +
                    " union " +
                    " select " + kljusSaZarezom + poljeUAdr_nazivPreduzeca + "," + poljeUAdr_Kontakt + "," + poljeUAdr_Email + "," +
                    "(select max(sentEmailAddress) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) as sentEmailAddress," +
                    " (select max(KomentarAnketara) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1 and pokusaj=(select max(pokusaj) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1 )) as CommentFromLog , " +
                      poljeUAdr_KomentarZaAnketara + " as CommentFromAdd ," +
                      "   (select max(telefon) from " + Me.catiprefix + "[ISTCATILog]  where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and neZvatiVise=1) as Phone , " +
                    poljeUAdr_Telefon1 + " as Phone1 ," + poljeUAdr_Telefon2 + " as Phone2 ," + poljeUAdr_Telefon3 + " as Phone3 " +
                     "," + stratumIST +
                    " From (select *," + kljuc + " as kljuc from " + adr + sqlW + ") A where " +
                    " exists (select * from " + Me.catiprefix + "ISTCATILog where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and rezultat=12) " +
                    " and not exists (select * from " + Me.catiprefix + "ISTCATILog where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and rezultat=14) " +
                    " and not exists (select * from " + Me.catiprefix + "ISTCATILog where  2=2" + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and  kljuc = A.kljuc and rezultat=61) " +
                    " order by 1"
                End If

                'Dim dt As DataTable = IzvrsiSQLVratiDT(sql, Me.CATIConnectionString)
                Dim dt As DataTable = izvrsiSQLvratiDT(sql, Me.connectionString, Nothing)
                Dim frm As New IstrazivanjaUnos.FormIstUnos(dIst, mdtLabel, mdtAWL, mdtQE, mdtMessage, Me.DBConnectionString, Me.tacv, tabela,
                    izazur, Me.txtInst, Me.txtpismo, Me.txtMode, Me.jezik, Me.ISTConnectionString, Me.DSBrisanjeDEPO.Trim.ToUpper,
                    Me.DSBrisanjeServer.Trim.ToUpper, Me.DSBrisanjeBaza.Trim.ToUpper, False,,,,,,,,, False, False,,,, False, True, dt, True,,,,,,, , ,,,,, ,,, True)
                Try
                    frm.ShowDialog()
                Catch ex As System.Exception
                    ISTMessageBox.Show(ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If sta = "U" AndAlso Not (frm.CATIKLJUC Is Nothing) AndAlso frm.CATIKLJUC.Trim <> "" Then
                        Call zCuvaj(61, frm.CATIKLJUC)
                        'idi na sledeci za svaki slucaj - jer će se neodrađeni vratiti sam iz spula
                        Call sledeci()
                    End If

                    If sta = "U14" AndAlso Not (frm.CATIKLJUC Is Nothing) AndAlso frm.CATIKLJUC.Trim <> "" Then
                        Call zCuvaj(14, frm.CATIKLJUC)
                        Call odcekirajRB(gbRezultat)
                        'idi na sledeci za svaki slucaj - jer će se neodrađeni vratiti sam iz spula
                        Call sledeci()
                    End If
                    frm.Dispose()
                End Try
            End If
        End If
    End Sub

    Private Sub txtT_KeyDown(sender As Object, e As KeyEventArgs) Handles txtT.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.txtT.Text.Length = 0 Then
                rb7.Checked = True
                Me.lblC.Text = trenutnoDatumVremeSaServera()
                Me.txtKomentarAnketara.Visible = True
                Me.txtKomentarAnketara.Enabled = True
                Me.txtKomentarAnketara.Focus()
                txtKomentarAnketara.Select(txtKomentarAnketara.Text.Length, 0)
            Else
                Me.btnCCall.Enabled = True
                Me.btnCCall.BackColor = Color.MediumSeaGreen
                Me.btnCCall.Focus()
            End If
        End If
    End Sub

    Private Sub llNBS_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llNBS.LinkClicked
        Call odcekirajRB(gbRezultat)
        System.Diagnostics.Process.Start("https://www.nbs.rs/internet/cirilica/67/rir.html")
    End Sub

    Private Sub ButtonUneti_Click(sender As Object, e As EventArgs) Handles ButtonCUneti.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call odcekirajRB(gbRezultat)
        Call dodunos("P")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub ButtonUnos_Click(sender As Object, e As EventArgs) Handles ButtonCUnos.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call odcekirajRB(gbRezultat)
        Call dodunos("U")
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub FormCATI_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        If catiZoviSledeci = 1 Then   'idi dalje
            Call komentarNeVisible()
            Call adresaNeVisible()
            Call pCuvaj(1)
        Else
            Call ponistirezultat(Me.gbRezultat)
        End If
    End Sub

    Private Sub dgCALLS_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgCALLS.MouseDoubleClick
        Dim imeTabele As String = CType(sender, System.Windows.Forms.DataGrid).Name.Trim.ToUpper
        Dim gdeSamUGridu As Integer = dgCALLS.CurrentRowIndex
        Try
            If gdeSamUGridu > -1 Then
                'Is System.DBNull.Value

                Dim dt As DataTable = CType(dgCALLS.DataSource, System.Data.DataTable)
                Dim kljuc As String = dajVrIzDG(dgCALLS, dt, gdeSamUGridu, "kljuc")
                Dim pokusaj As String = "0"
                Me.lblPokusaj.Text = "0"
                pokusaj = dajVrIzDG(dgCALLS, dt, gdeSamUGridu, "pokusaj")
                Dim stratumIST As String = dajVrIzDG(dgCALLS, dt, gdeSamUGridu, "stratumIST")
                Dim novitelefon As String = dajVrIzDG(dgCALLS, dt, gdeSamUGridu, "novitelefon")
                Dim komentarAnketara As String = dajVrIzDG(dgCALLS, dt, gdeSamUGridu, "komentarAnketara")
                Me.lblKljuc.Text = kljuc.Trim
                Me.lblStratum.Text = stratumIST.Trim
                If pokusaj.Trim = "" Then pokusaj = "0"
                Me.lblPokusaj.Text = pokusaj.Trim

                Me.txtKomentarAnketara.Text = ""

                If komentarAnketara <> "" Then
                    Me.txtKomentarAnketara.Visible = True
                    Me.txtKomentarAnketara.Enabled = False
                    Me.txtKomentarAnketara.Text = komentarAnketara
                End If

                Dim dv As New System.Data.DataView(dtAdr)
                dv.RowFilter = "kljuc='" & kljuc & "'"
                If dv.Count > 0 Then
                    Dim redv As DataRow = dv(0).Row
                    DGTabele(0).ImportRow(redv)
                    dajPodatkeIzAdr(redv, novitelefon)
                End If
                Call odcekirajRB(gbRezultat)
                disableGB(gbRezultat, rb7, rb14)
                If nizTelefona.Length = 0 Then
                    Me.txtT.Enabled = True
                    Me.txtT.Focus()
                    Me.txtT.BackColor = Color.Thistle
                Else
                    Me.btnCCall.Enabled = True
                    Me.btnCCall.BackColor = Color.MediumSeaGreen
                    Me.btnCCall.Focus()
                End If

                ReDim Vklj(0, 1)
                Vklj(0, 0) = spremiKljucString(adresarCati).Trim.ToUpper
                Vklj(0, 1) = kljuc.Trim.ToUpper

                If llPZ.Visible = True AndAlso llPZ.Text = "Regular" AndAlso llPZ.Tag <> "" Then   'u modu je za zamene
                    Me.txtT.Enabled = True
                    Me.txtT.Focus()
                    Me.txtT.BackColor = Color.Thistle
                End If
            End If
        Catch ex As System.Exception
            ISTMessageBox.Show("Greška kod dblclick!" + nvrd + ex.Message, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub llZakazani_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llZakazani.LinkClicked
        Call zakazaniPromena()
    End Sub

    Private Sub llPregledEmail_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPregledEmail.LinkClicked

        Call popuniListuEmailova()
        'Call centriraj(panelEmails)

        panelEmails.Width = 4 / 5 * Me.Width
        panelEmails.Height = Me.Height / 2

        Dim x As Integer = (Me.Width - panelEmails.Width) \ 2
        Dim y As Integer = (Me.Height - panelEmails.Height) \ 2
        panelEmails.Location = New Point(x, y)

        Dim sintX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim sintY As Integer = Screen.PrimaryScreen.Bounds.Height

        Me.panelEmails.Visible = True

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.panelEmails.Visible = False
    End Sub

    Sub popuniListuEmailova()

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim gma As String = ""
        gma = imaGMAnketar(adresarCati)
        Dim kljuc As String = dajPKLJUC()
        Dim kljusSaZarezom As String = dajPKLJUCSaZarezom()
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        Dim sqlW As String = " where 2=2 "
        If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
        If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
        If gma.Substring(2, 1) = "T" Then
            sqlW = sqlW + " and anketar='" + anketar + "'"
            sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
        End If
        If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
        If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

        Dim strSelectS As String = " select SENT," + poljeUAdr_nazivPreduzeca + ",b.komentarAnketara,b.telefon" + "," + poljeUAdr_Kontakt + ", sentEmailAddress from " +
                " (Select " + kljuc + " As SENT ," + poljeUAdr_nazivPreduzeca + "," + poljeUAdr_Kontakt + "," + poljeUAdr_Email + " from " + adr + sqlW + ") A inner join " +
                " (Select kljuc,komentarAnketara,telefon,sentEmailAddress From " + Me.catiprefix + "ISTCATILog where 2=2 " + sqlISTGM + " And sifist='" + sifist + "' and tabela='" + tabela + "' and rezultat=12) B on  B.kljuc=A.SENT "

        Dim strSelectR As String = " select RECEIVED," + poljeUAdr_nazivPreduzeca + ",b.komentarAnketara,b.telefon" + "," + poljeUAdr_Kontakt + ", sentEmailAddress from " +
                " (Select " + kljuc + " As RECEIVED ," + poljeUAdr_nazivPreduzeca + "," + poljeUAdr_Kontakt + "," + poljeUAdr_Email + " from " + adr + sqlW + ") A inner join " +
                " (Select kljuc,komentarAnketara,telefon,sentEmailAddress From " + Me.catiprefix + "ISTCATILog where 2=2 " + sqlISTGM + " And sifist='" + sifist + "' and tabela='" + tabela + "' and rezultat=14) B on  B.kljuc=A.RECEIVED "

        Dim strSelect As String = " select S.* , R.* " +
                                  " from" +
                                  " (" + strSelectS + ") S" +
                                  " Left Join" +
                                  " (" + strSelectR + ") R" +
                                  " On S.SENT=R.RECEIVED" +
                                  " union" +
                                  " Select S.*, R.*" +
                                  " from" +
                                  " (" + strSelectS + ") S" +
                                  " Right Join" +
                                  " (" + strSelectR + ") R" +
                                  " On S.SENT=R.RECEIVED  " +
                                  " order by 1 desc"

        Call popuniDGridView(dgv, Me.connectionString, strSelect, Me.jezik)
        'Call popuniDGridView(dgv, CATIConnectionString, strSelect, Me.jezik)

        Call srediGridView(dgv, True)
        dgv.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Verdana", 7.0!, FontStyle.Bold)
        dgv.RowHeadersWidth = 35

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnEmails14PM_Click(sender As Object, e As EventArgs) Handles btnEmails14PM.Click
        Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
        Dim nvd As String = Microsoft.VisualBasic.ChrW(34)

        Dim oApp As Microsoft.Office.Interop.Outlook._Application
        oApp = New Microsoft.Office.Interop.Outlook.Application

        Dim oMsg As Microsoft.Office.Interop.Outlook._MailItem
        oMsg = oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)

        If subject <> "" Then
            oMsg.Subject = subject
        Else
            ''msg 182
            Dim msgtxt182 As String = getMessageText(dtMessages, "182", Me.jezik)
            Dim por As String = msgtxt182 + nvrd
            ISTMessageBox.Show(por, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If body <> "" Then
            oMsg.Body = body & vbCr & vbCr
        Else
            ''msg 183
            Dim msgtxt183 As String = getMessageText(dtMessages, "183", Me.jezik)
            Dim por As String = msgtxt183 + nvrd
            ISTMessageBox.Show(por, "Error-Stop", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Dim gma As String = imaGMAnketar(adresarCati)
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        Dim kljuc As String = dajPKLJUC()
        Dim kljusSaZarezom As String = dajPKLJUCSaZarezom()

        Dim s As String = ""
        Dim sqlW As String = " where 2=2 "

        If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
        If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
        If gma.Substring(2, 1) = "T" Then
            sqlW = sqlW + " and anketar='" + anketar + "'"
            sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
        End If
        If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
        If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"
        Dim sql As String = ""

        'za emailove uzeti one koji imaju status 14 u prethodnom mesecu,
        'njihovi emailovi su u 12 za prethodni mesec

        Dim sentEmailAddresses = ""

        Dim odg As String = ""

        Dim pgod As String = ""
        Dim pmes As String = ""
        If Me.MM = "01" Then pmes = "12" : pgod = (Me.GG - 1).ToString
        If Me.MM <> "01" Then pmes = (Me.MM - 1).ToString.Trim.PadLeft(2, "0"c) : pgod = Me.GG

        'poslat prethodnog meseca i nije primljen odgovor ovog
        Dim sqlSEA As String = "select max(telefon) as telefon,kljuc,max(stratumist) as stratumist," +
        " max(novaAdresa) As novaAdresa,max( komentarAnketara ) As komentarAnketara, " +
        " max(isnull(sentEmailAddress,'')) as sentEmailAddress from " + Me.catiprefix + "istcatilog A  " +
        " where rezultat=12 and ISTYear='" + pgod + "' and ISTMonth='" + pmes + "' " +
        " and sifist='" + sifist + "' and tabela='" + tabela + "' and kljuc in (select " + dajPKLJUC() + " As kljuc from " + adr + sqlW + " ) " +
        " and not exists (select * from " + Me.catiprefix + "[ISTCATILog] where 2=2 and ISTYear='" + Me.GG + "' and ISTMonth='" + Me.MM + "'and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" +
        " and imaupitnik=1 and kljuc=a.kljuc) group by kljuc"

        Dim dtSEA As New System.Data.DataTable
        dtSEA = izvrsiSQLvratiDT(sqlSEA, Me.connectionString, Nothing)
        Dim telefonizloga As String = ""
        Dim kljucizloga As String = ""
        Dim stratumizloga As String = ""
        Dim novaAdresaizloga As String = ""
        Dim KomentarAnketaraizloga As String = ""
        Dim hostName As String = GetHostName()
        Dim sentEmailAddressIzLoga As String = ""
        If dtSEA.Rows.Count > 0 Then
            For i As Integer = 0 To dtSEA.Rows.Count - 1
                If Not dtSEA.Rows(i).Item("sentEmailAddress") Is Nothing Then sentEmailAddresses = sentEmailAddresses + dtSEA.Rows(i).Item("sentEmailAddress").ToString.Trim + ";"
                If Not dtSEA.Rows(i).Item("telefon") Is Nothing Then telefonizloga = dtSEA.Rows(i).Item("telefon").ToString.Trim
                If Not dtSEA.Rows(i).Item("sentEmailAddress") Is Nothing Then sentEmailAddressIzLoga = dtSEA.Rows(i).Item("sentEmailAddress").ToString.Trim
                If Not dtSEA.Rows(i).Item("kljuc") Is Nothing Then kljucizloga = dtSEA.Rows(i).Item("kljuc").ToString.Trim
                If Not dtSEA.Rows(i).Item("stratumIST") Is Nothing Then stratumizloga = dtSEA.Rows(i).Item("stratumIST").ToString.Trim
                If Not dtSEA.Rows(i).Item("novaAdresa") Is Nothing Then novaAdresaizloga = dtSEA.Rows(i).Item("novaAdresa").ToString.Trim
                If Not dtSEA.Rows(i).Item("komentarAnketara") Is Nothing Then KomentarAnketaraizloga = dtSEA.Rows(i).Item("komentarAnketara").ToString.Trim
                If KomentarAnketaraizloga.IndexOf("POSLAT GRUPNI EMAIL") < 0 Then
                    KomentarAnketaraizloga = "POSLAT GRUPNI EMAIL    " + KomentarAnketaraizloga
                End If

                Dim pokussajj As String = "1"
                Dim sqllog As String = "select max(pokusaj) as mp from " + Me.catiprefix + "istcatilog where " +
                " ISTyear='" + Me.GG + "' and ISTmonth='" + Me.MM + "' and sifist='" + sifist + "' and tabela='" +
                tabela + "' and kljuc='" + kljucizloga + "'"
                Dim dt As New DataTable
                dt = izvrsiSQLvratiDT(sqllog, Me.connectionString, Nothing)
                If dt.Rows.Count > 0 AndAlso dt.Rows(0).Item("mp").ToString.Trim <> "" Then
                    If IsNumeric(dt.Rows(0).Item("mp").ToString.Trim) AndAlso CInt(dt.Rows(0).Item("mp").ToString.Trim) > 0 Then
                        pokussajj = CInt(dt.Rows(0).Item("mp").ToString.Trim) + 1
                    End If
                End If

                'upisi u LOG kao 12
                sql = "insert into " + Me.catiprefix + "[ISTCATILog] (ISTyear,ISTmonth,sifist,tabela,anketar,logOn," &
                " kljuc,pokusaj,hostName,telefon,pozivStart,pozivEnd," +
                " rezultat,zvatiU,imaUpitnik,neZvatiVise,stratumIST,novaAdresa,noviTelefon,komentarAnketara,replacement,sentEmailAddress) values " &
                "('" + Me.GG + "','" + Me.MM + "','" & sifist & "','" & tabela & "','" & anketar & "','" & logOnA & "','" &
                kljucizloga & "','" + pokussajj + "','" & hostName & "','" & telefonizloga & "',null,null,12,null,0,1,'" & stratumizloga & "','" &
                novaAdresaizloga & "','','" & KomentarAnketaraizloga & "','','" & sentEmailAddressIzLoga & "');"
                odg = izvrsiSQL(sql, Me.connectionString)
                If odg = "nok" Then
                    'ne radi nista vec to postoji u logu, ovo je ako je hteo da posalji grupni mail, sve napisao i odustao pre senda
                End If
            Next
        End If

        oMsg.To = sentEmailAddresses

        If bcc <> "" Then oMsg.BCC = bcc

        Dim sBodyLen As String = oMsg.Body.Length
        Dim oAttachs As Microsoft.Office.Interop.Outlook.Attachments = oMsg.Attachments
        Dim oAttach As Microsoft.Office.Interop.Outlook.Attachment = Nothing

        If attach1.Length > 0 Then Call dajAttach(attach1, oAttach, oAttachs, sBodyLen)
        If attach2.Length > 0 Then Call dajAttach(attach2, oAttach, oAttachs, sBodyLen)
        If attach3.Length > 0 Then Call dajAttach(attach3, oAttach, oAttachs, sBodyLen)

        oMsg.Display()
        'oMsg.Send()
        'Clean up
        oApp = Nothing
        oMsg = Nothing
        oAttach = Nothing
        oAttachs = Nothing

    End Sub

    Private Sub ButtonClosePZ_Click(sender As Object, e As EventArgs) Handles ButtonClosePZ.Click
        Me.panelpregledZamena.Visible = False
    End Sub

    Sub popuniListuStratuma()

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim gma As String = ""
        gma = imaGMAnketar(adresarCati)
        Dim kljuc As String = dajPKLJUC()
        Dim kljusSaZarezom As String = dajPKLJUCSaZarezom()
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        Dim sqlW As String = " where 2=2 "
        If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
        If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
        If gma.Substring(2, 1) = "T" Then
            sqlW = sqlW + " and anketar='" + anketar + "'"
            sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
        End If
        If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
        If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"

        Dim siB As String = CStr(stratumISTBroj).Trim
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXX
        Dim strSelectAdr2 As String = "select stratumIST,count(*) as broj, " + siB + " as QuotaPerStrata, 0 as RespondedToTheSurvey, 0 as NumberOfReplacements,0 as Refused,count(*) as StrataRemainedToCall, 0 as NeedsReplacement " +
          " from (select " + dajPSTRATUM() + " as stratumIST from " + adr + sqlW + ") B  " +
          " where not exists (select * from " + Me.catiprefix + "ISTCATILog where 2=2 " + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and stratumIST=B.stratumIST)" +
          " group by stratumIST"

        Dim strSelectAdr As String = "(select count(*) from (select " + dajPSTRATUM() + " as stratumIST from " + adr + sqlW + ") D  where stratumIST=B.stratumIST group by stratumIST)"
        Dim strsaUpitnikom As String = "(select count(*) from " + Me.catiprefix + "ISTCATILog where 2=2 " + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and rezultat=1  and stratumIST=B.stratumIST group by stratumIST)"
        Dim strOdbijeni As String = "(select  count(distinct kljuc) from " + Me.catiprefix + "ISTCATILog A where 2=2 " + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and rezultat=2  " +
        " and not exists (select * from " + Me.catiprefix + "ISTCATILog where 2=2 " + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and rezultat=1 and kljuc=A.kljuc) and stratumist=B.stratumist group by stratumIST )"
        Dim strZamena As String = "(select count(distinct kljuc) from " + Me.catiprefix + "ISTCATILog where 2=2 " + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and rezultat=1 and replacement='R' and stratumIST=B.stratumIST group by stratumIST)"

        Dim strSelect As String = "select stratumIST,isnull(InStrata,0) as InStrata,isnull(QuotaPerStrata,0) as QuotaPerStrata,isnull(RespondedToTheSurvey,0) as RespondedToTheSurvey," +
        "isnull(NumberOfReplacements,0) as NumberOfReplacements ,isnull(Refused,0) as Refused ,isnull(InStrata,0)-isnull(RespondedToTheSurvey,0)-isnull(Refused,0) as StrataRemainedToCall, " +
        "case when isnull(Refused,0)-isnull(QuotaPerStrata,0)>0 then isnull(Refused,0)-isnull(QuotaPerStrata,0) else 0 end as NeedsReplacement " +
        " from " +
        "(select stratumIST," + strSelectAdr + " as InStrata, " + siB + " as QuotaPerStrata," + strsaUpitnikom + " as RespondedToTheSurvey," + strOdbijeni + " as Refused," + strZamena + " as NumberOfReplacements " +
        " from " + Me.catiprefix + "ISTCATILog B where 2=2 " + sqlISTGM + " And sifist='" + sifist + "' and tabela='" + tabela + "'" +
        " group by stratumIST) C " +
        " where isnull(RespondedToTheSurvey,0) < 5 and isnull(Refused,0)-isnull(QuotaPerStrata,0) > 0"

        Call popuniDGridView(dgvPZ, connectionString, strSelect, Me.jezik)

        Call srediGridView(dgvPZ, True)
        'dgvPZ.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Verdana", 7.0!)
        'dgvPZ.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 7.0!)
        dgvPZ.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Verdana", 7.0!, FontStyle.Bold)
        dgvPZ.RowHeadersWidth = 35

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub dgvPZ_DoubleClick(sender As Object, e As EventArgs) Handles dgvPZ.DoubleClick
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If dgvPZ.CurrentRow.Index > -1 Then
            Dim strZamena As String = dgvPZ.CurrentRow.Cells(7).Value.ToString.Trim
            Dim stratumIST As String = dgvPZ.CurrentRow.Cells(0).Value.ToString.Trim

            If CInt(strZamena) > 0 Then
                llPZ.Text = "Regular"
                llRZ.Visible = True
                Call dajLogStratum(stratumIST)
                llPZ.Tag = stratumIST
                Call adresarUdtAdrZamena()
                Call sledeci()

                'u modu je za zamene
                Me.txtT.Enabled = True
                Me.txtT.Focus()
                Me.txtT.BackColor = Color.Thistle
                'rb1.Text = "1 Učestvuje u anketi kao zamena"
                rb1.Text = rb1Ztext
            End If
        End If
        Me.panelpregledZamena.Visible = False
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub dajLogStratum(ByVal stratumIST As String)
        Dim gma As String = ""
        gma = imaGMAnketar(adresarCati)
        Dim kljuc As String = dajPKLJUC()
        Dim kljusSaZarezom As String = dajPKLJUCSaZarezom()
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        Dim sqlW As String = " where 2=2 "
        If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
        If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
        If gma.Substring(2, 1) = "T" Then
            sqlW = sqlW + " and anketar='" + anketar + "'"
            sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
        End If
        If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
        If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"

        'ISTCATILog ima uvek god,mes,sifist,tabela,anketar
        Dim sqlCATILog As String = ""
        sqlCATILog = " select  " +
            " kljuc," +
            " max(pokusaj) as pokusaj,max(telefon) as telefon,max(CONVERT(varchar,pozivStart, 120)) as pozivStart,max(CONVERT(varchar,pozivEnd, 120)) as pozivEnd,rezultat," +
            " max(case When isnull(zvatiU,0)=0 Then CONVERT(varchar, GETDATE(), 120) Else CONVERT(varchar, zvatiU, 120) End) As zvatiU ," +
            " max(komentarAnketara) as komentarAnketara, max(novitelefon) as novitelefon,stratumIST,anketar " +
            " from " + Me.catiprefix + "[ISTCATILog] A " +
            " where 2=2 " + sqlISTGM + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" +
            " and rezultat<>1 and neZvatiVise=1 and stratumIST='" + stratumIST + "'" +
            " and not exists (select * from " + Me.catiprefix + "[ISTCATILog] where 2=2 " + sqlISTGM + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "'" +
            " and rezultat=1 and stratumIST='" + stratumIST + "' and kljuc=a.kljuc)"

        Dim groupBy As String = " group by kljuc,stratumIST,anketar,rezultat"
        Dim orderBy As String = " order by pozivStart, rezultat desc,stratumIST, kljuc"
        sqlCATILog = sqlCATILog + groupBy + orderBy
        dtCALLS = izvrsiSQLvratiDT(sqlCATILog, Me.connectionString, Nothing)
        dgCALLS.DataSource = dtCALLS
        Call srediGrid(dgCALLS, dtCALLS)

        dgCALLS.CaptionText = dajCaption(dtCALLS, sqlISTGM, sqlW)

        Call prikaziPokusaje()

    End Sub

    Private Sub llPZ_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPZ.LinkClicked
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Call zamena()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub zamena()

        If llPZ.Text = "Regular" Then
            llPZ.Text = "Replacements"
            llPZ1.Visible = True
            rb1.Text = rb1text
            llPZ.Tag = ""
            llRZ.Visible = False
            llPZ1.Visible = False
            'Call dajLog(rez)
            'Call adresarUdtAdr()
            Call sledeci()
        Else
            llRZ.Visible = True
            llPZ1.Visible = True
            Call odcekirajRB(gbRezultat)
            Call PZ()
        End If

    End Sub

    Sub PZ()
        Call popuniListuStratuma()

        panelpregledZamena.Width = 4 / 5 * Me.Width
        panelpregledZamena.Height = Me.Height / 2

        Dim x As Integer = (Me.Width - panelpregledZamena.Width) \ 2
        Dim y As Integer = (Me.Height - panelpregledZamena.Height) \ 2
        panelpregledZamena.Location = New Point(x, y)

        Dim sintX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim sintY As Integer = Screen.PrimaryScreen.Bounds.Height

        Me.panelpregledZamena.Visible = True
    End Sub

    Private Sub ButtonCloseRZ_Click(sender As Object, e As EventArgs) Handles ButtonCloseRZ.Click
        Me.panelpregledPozivaZamena.Visible = False
    End Sub

    Sub popuniListuPoziva()

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim ttaabbeellaa As String = praviServer + "." + pravaBaza + "." + Me.catiprefix + Me.tabela
        Dim gma As String = ""
        gma = imaGMAnketar(adresarCati)
        Dim gmaT As String = ""
        gmaT = imaGMAnketar(Me.tabela)
        Dim kljuc As String = dajPKLJUC()
        Dim kljusSaZarezom As String = dajPKLJUCSaZarezom()
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"

        Dim sqlW As String = getCondition(gma)
        Dim sqlWT As String = getCondition(gmaT)

        If gma.Substring(2, 1) = "T" Then sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX

        Dim strSelectAdr As String = "select b.stratumIST,b.kljuc,prezime,ime,replacement,prezimeZamena,imeZamena,b.telefon as pozvaniTelefon,pozivStart,rezultat,komentaranketara " +
          " from (select * from " + Me.catiprefix + "ISTCATILog where 2=2 " + sqlISTGM + " and sifist='" + sifist + "' and tabela='" + tabela + "' and stratumIST='" + Me.llPZ.Tag + "') B left join " +
          " (select " + poljeUAdr_nazivPreduzeca + " as prezime," + poljeUAdr_Kontakt + " as ime," + dajPSTRATUM() + " as stratumIST," + kljuc + " as kljuc from " + adr + sqlW + ")  ADR22 on B.kljuc=ADR22.kljuc left join " +
          " (select " + kljuc + " as kljuc," + poljeUAdr_nazivPreduzeca + " as prezimeZamena," + poljeUAdr_Kontakt +
          " as imeZamena from " + ttaabbeellaa + sqlWT + ")  TAB on B.kljuc=TAB.kljuc "

        Call popuniDGridView(dgvRZ, Me.connectionString, strSelectAdr, Me.jezik)

        Call srediGridView(dgvRZ, True)
        'dgvRZ.AlternatingRowsDefaultCellStyle.Font = New System.Drawing.Font("Verdana", 7.0!)
        'dgvRZ.DefaultCellStyle.Font = New System.Drawing.Font("Verdana", 7.0!)
        dgvRZ.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Verdana", 7.0!, FontStyle.Bold)
        dgvRZ.RowHeadersWidth = 35

        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    '*****************************

    '*****************************
    Function getCondition(gma) As String
        Dim sqlW As String = " where 2=2 "
        If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
        If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
        If gma.Substring(2, 1) = "T" Then sqlW = sqlW + " and anketar='" + anketar + "'"
        If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
        If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"
        getCondition = sqlW
    End Function

    Private Sub llRZ_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llRZ.LinkClicked
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Call popuniListuPoziva()

        panelpregledPozivaZamena.Width = 4 / 5 * Me.Width
        panelpregledPozivaZamena.Height = Me.Height / 2

        Dim x As Integer = (Me.Width - panelpregledPozivaZamena.Width) \ 2
        Dim y As Integer = (Me.Height - panelpregledPozivaZamena.Height) \ 2
        panelpregledPozivaZamena.Location = New Point(x, y)

        Dim sintX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim sintY As Integer = Screen.PrimaryScreen.Bounds.Height

        Me.panelpregledPozivaZamena.Visible = True
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub llPZ1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llPZ1.LinkClicked
        Call PZ()
    End Sub

    Dim kljucIzDGVA As String

    Private Sub dgv_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgv.MouseDoubleClick
        Dim a As Integer = 1
        kljucIzDGVA = (dgv.SelectedRows(0).Cells("sent")).Value
        'Dim novitelefon As String = dgv.SelectedRows(0).Cells("sent").Value
        'Me.panelEmails.Visible = False
        'Dim dv As New System.Data.DataView(dtAdr)
        'dv.RowFilter = "kljuc='" & kljucIzDGVA & "'"
        'If dv.Count > 0 Then
        '    Dim redv As DataRow = dv(0).Row
        '    DGTabele(0).ImportRow(redv)
        '    dajPodatkeIzAdr(redv, novitelefon)
        'End If
        'Call odcekirajRB(gbRezultat)
        'disableGB(gbRezultat, rb7, rb14)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        If dgv.CurrentRow.Index > -1 Then
            kljucIzDGVA = (dgv.SelectedRows(0).Cells("sent")).Value

            If kljucIzDGVA <> "" Then
                'llPZ.Text = "Regular"
                'llRZ.Visible = True
                Call dajLogKljuc(kljucIzDGVA)
                'llPZ.Tag = stratumIST
                Call adresarSentMail()
                Call sledeci()

                'u modu je za zamene
                Me.txtT.Enabled = True
                Me.txtT.Focus()
                Me.txtT.BackColor = Color.Thistle
                'rb1.Text = "1 Učestvuje u anketi kao zamena"
                'rb1.Text = rb1Ztext
            End If
        End If
        Me.panelEmails.Visible = False
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Sub adresarSentMail()

        'adresar koji je CATI i ide iz konkretnog istrazivanja mora da bude opisan u ISTPoljima
        Dim gma As String = ""
        Dim kljuc As String = ""

        gma = imaGMAnketar(adresarCati)
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        kljuc = dajPKLJUC()

        If kljuc = "" Then
            ''msg 169
            Dim msgtxt169 As String = getMessageText(dtMessages, "169", Me.jezik)
            ''msg 170
            Dim msgtxt170 As String = getMessageText(dtMessages, "170", Me.jezik)
            ISTMessageBox.Show(msgtxt169 + adresarCati + msgtxt170)
        Else
            Dim s As String = ""
            Dim sqlW As String = " where 2=2 "
            Dim nvrd As String = Microsoft.VisualBasic.ChrW(13) + Microsoft.VisualBasic.ChrW(10)
            Dim nvd As String = Microsoft.VisualBasic.ChrW(34)
            If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
            If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
            If gma.Substring(2, 1) = "T" Then
                sqlW = sqlW + " and anketar='" + anketar + "'"
                sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
            End If

            'podaci iz adresara:OVO MI TREBA SAMO DA IZLISTAM DETALJE IZ ADRESARA
            'KANDIDATI:
            'samo iz za koje je poslat mail a nemamo odg

            Dim sqlAdr As String = ""
            'XXXXXXXXXXXXXXXXXXXXX
            sqlAdr = "select * from " +
            " (select *," + kljuc + " as kljuc from " + adr + sqlW + ") As A " +
            " where kljuc='" + kljucIzDGVA + "'"
            If uzorak = "P" Then
                'prost uzorak
            ElseIf uzorak = "K" Then
                'kvota uzorak
            ElseIf uzorak = "S" Then
            End If
            'dtAdr = IzvrsiSQLVratiDT(sqlAdr, Me.CATIConnectionString)
            dtAdr = izvrsiSQLvratiDT(sqlAdr, Me.connectionString, Nothing)
        End If

    End Sub

    Sub dajLogKljuc(ByVal kkljuc As String)
        Dim gma As String = ""
        gma = imaGMAnketar(adresarCati)
        Dim kljuc As String = dajPKLJUC()
        Dim kljusSaZarezom As String = dajPKLJUCSaZarezom()
        sqlISTGM = " and ISTyear='" + GG + "' and ISTmonth='" + MM + "'"
        Dim sqlW As String = " where 2=2 "
        If gma.Substring(0, 1) = "T" Then sqlW = sqlW + " and god='" + GG + "'"
        If gma.Substring(1, 1) = "T" Then sqlW = sqlW + " and mes='" + MM + "'"
        If gma.Substring(2, 1) = "T" Then
            sqlW = sqlW + " and anketar='" + anketar + "'"
            sqlISTGM = sqlISTGM + " and anketar='" + anketar + "'"
        End If
        If gma.Substring(3, 1) = "T" Then sqlW = sqlW + " and ISTYEAR='" + GG + "'"
        If gma.Substring(4, 1) = "T" Then sqlW = sqlW + " and ISTMONTH='" + MM + "'"

        'ISTCATILog ima uvek god,mes,sifist,tabela,anketar
        Dim sqlCATILog As String = ""
        sqlCATILog = " select  " +
            " kljuc," +
            " max(pokusaj) as pokusaj,max(telefon) as telefon,max(CONVERT(varchar,pozivStart, 120)) as pozivStart,max(CONVERT(varchar,pozivEnd, 120)) as pozivEnd,rezultat," +
            " max(case When isnull(zvatiU,0)=0 Then CONVERT(varchar, GETDATE(), 120) Else CONVERT(varchar, zvatiU, 120) End) As zvatiU ," +
            " max(komentarAnketara) as komentarAnketara, max(novitelefon) as novitelefon,stratumIST,anketar " +
            " from " + Me.catiprefix + "[ISTCATILog] A " +
            " where 2=2 " + sqlISTGM + " and sifist='" + sifist.Trim + "' and tabela='" + tabela.Trim + "' and imaupitnik<>1 and kljuc='" + kljucIzDGVA + "'"

        Dim groupBy As String = " group by kljuc,stratumIST,anketar,rezultat"
        Dim orderBy As String = " order by pozivStart, rezultat desc,stratumIST, kljuc"
        sqlCATILog = sqlCATILog + groupBy + orderBy
        dtCALLS = izvrsiSQLvratiDT(sqlCATILog, Me.connectionString, Nothing)
        dgCALLS.DataSource = dtCALLS
        Call srediGrid(dgCALLS, dtCALLS)

        dgCALLS.CaptionText = dajCaption(dtCALLS, sqlISTGM, sqlW)

        Call prikaziPokusaje()

    End Sub

End Class