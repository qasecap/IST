
Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Strings
Friend Class FormAzurirajFilterColumns

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
    Friend WithEvents tbtc As System.Windows.Forms.TextBox

    Friend WithEvents tt1 As System.Windows.Forms.ToolTip
    Friend WithEvents MDGLabel5 As System.Windows.Forms.Label
    Friend WithEvents MDGLabel1 As System.Windows.Forms.Label
    Friend WithEvents MDGLabel3 As System.Windows.Forms.Label
    Friend WithEvents ybacc As System.Windows.Forms.TextBox
    Friend WithEvents MDGLabel2 As System.Windows.Forms.Label
    Friend WithEvents tbdcc As System.Windows.Forms.TextBox
    Friend WithEvents MDGbmd As System.Windows.Forms.Button
    Friend WithEvents MDGbmu As System.Windows.Forms.Button
    Friend WithEvents lright As System.Windows.Forms.ListBox
    Friend WithEvents brre As System.Windows.Forms.Button
    Friend WithEvents baaa As System.Windows.Forms.Button
    Friend WithEvents lleft As System.Windows.Forms.ListBox
    Friend WithEvents bc As System.Windows.Forms.Button
    Friend WithEvents bok As System.Windows.Forms.Button
    Friend WithEvents baaaAll As System.Windows.Forms.Button
    Friend WithEvents brreAll As System.Windows.Forms.Button
    Friend WithEvents MDGLabel4 As System.Windows.Forms.Label
    Friend WithEvents MDGGroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MDGbPamtiKolone As System.Windows.Forms.Button
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents Logovan As System.Windows.Forms.Label
    Friend WithEvents PanelContext As System.Windows.Forms.Panel
    Friend WithEvents PanelBottom As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents meText As System.Windows.Forms.Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tv As TreeView
    Friend WithEvents MDGbVratiKolone As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAzurirajFilterColumns))
        Me.tbtc = New System.Windows.Forms.TextBox()
        Me.tt1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MDGbmd = New System.Windows.Forms.Button()
        Me.MDGbmu = New System.Windows.Forms.Button()
        Me.brre = New System.Windows.Forms.Button()
        Me.baaa = New System.Windows.Forms.Button()
        Me.baaaAll = New System.Windows.Forms.Button()
        Me.brreAll = New System.Windows.Forms.Button()
        Me.MDGLabel5 = New System.Windows.Forms.Label()
        Me.MDGLabel1 = New System.Windows.Forms.Label()
        Me.MDGLabel3 = New System.Windows.Forms.Label()
        Me.ybacc = New System.Windows.Forms.TextBox()
        Me.MDGLabel2 = New System.Windows.Forms.Label()
        Me.tbdcc = New System.Windows.Forms.TextBox()
        Me.lright = New System.Windows.Forms.ListBox()
        Me.lleft = New System.Windows.Forms.ListBox()
        Me.bc = New System.Windows.Forms.Button()
        Me.bok = New System.Windows.Forms.Button()
        Me.MDGLabel4 = New System.Windows.Forms.Label()
        Me.MDGGroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MDGbVratiKolone = New System.Windows.Forms.Button()
        Me.MDGbPamtiKolone = New System.Windows.Forms.Button()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.meText = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Logovan = New System.Windows.Forms.Label()
        Me.PanelContext = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tv = New System.Windows.Forms.TreeView()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MDGGroupBox1.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelContext.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbtc
        '
        Me.tbtc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbtc.Location = New System.Drawing.Point(23, 41)
        Me.tbtc.Name = "tbtc"
        Me.tbtc.Size = New System.Drawing.Size(246, 22)
        Me.tbtc.TabIndex = 21
        '
        'MDGbmd
        '
        Me.MDGbmd.BackColor = System.Drawing.Color.Transparent
        Me.MDGbmd.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.MDGbmd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MDGbmd.ImageIndex = 0
        Me.MDGbmd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MDGbmd.Location = New System.Drawing.Point(632, 207)
        Me.MDGbmd.Name = "MDGbmd"
        Me.MDGbmd.Size = New System.Drawing.Size(153, 24)
        Me.MDGbmd.TabIndex = 17
        Me.MDGbmd.Text = "Помери доле"
        Me.tt1.SetToolTip(Me.MDGbmd, "Pomeri izabranu kolonu ka dnu liste")
        Me.MDGbmd.UseVisualStyleBackColor = False
        '
        'MDGbmu
        '
        Me.MDGbmu.BackColor = System.Drawing.Color.Transparent
        Me.MDGbmu.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.MDGbmu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MDGbmu.ImageIndex = 0
        Me.MDGbmu.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MDGbmu.Location = New System.Drawing.Point(632, 175)
        Me.MDGbmu.Name = "MDGbmu"
        Me.MDGbmu.Size = New System.Drawing.Size(153, 24)
        Me.MDGbmu.TabIndex = 13
        Me.MDGbmu.Text = "Помери горе"
        Me.tt1.SetToolTip(Me.MDGbmu, "Pomeri izabranu kolonu ka vrhu liste")
        Me.MDGbmu.UseVisualStyleBackColor = False
        '
        'brre
        '
        Me.brre.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.brre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brre.ImageIndex = 0
        Me.brre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.brre.Location = New System.Drawing.Point(282, 139)
        Me.brre.Name = "brre"
        Me.brre.Size = New System.Drawing.Size(49, 26)
        Me.brre.TabIndex = 7
        Me.brre.Text = "<--"
        Me.tt1.SetToolTip(Me.brre, "Izbaci izabrane kolone")
        '
        'baaa
        '
        Me.baaa.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.baaa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.baaa.ImageIndex = 0
        Me.baaa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.baaa.Location = New System.Drawing.Point(282, 107)
        Me.baaa.Name = "baaa"
        Me.baaa.Size = New System.Drawing.Size(49, 26)
        Me.baaa.TabIndex = 4
        Me.baaa.Text = "-->"
        Me.tt1.SetToolTip(Me.baaa, "Dodaj izabrane kolone")
        '
        'baaaAll
        '
        Me.baaaAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.baaaAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.baaaAll.ImageIndex = 0
        Me.baaaAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.baaaAll.Location = New System.Drawing.Point(282, 203)
        Me.baaaAll.Name = "baaaAll"
        Me.baaaAll.Size = New System.Drawing.Size(49, 26)
        Me.baaaAll.TabIndex = 12
        Me.baaaAll.Text = "-->>"
        Me.tt1.SetToolTip(Me.baaaAll, "Dodaj sve kolone")
        '
        'brreAll
        '
        Me.brreAll.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.brreAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.brreAll.ImageIndex = 0
        Me.brreAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.brreAll.Location = New System.Drawing.Point(282, 235)
        Me.brreAll.Name = "brreAll"
        Me.brreAll.Size = New System.Drawing.Size(49, 26)
        Me.brreAll.TabIndex = 9
        Me.brreAll.Text = "<<--"
        Me.tt1.SetToolTip(Me.brreAll, "Izbaci sve kolone")
        '
        'MDGLabel5
        '
        Me.MDGLabel5.AutoSize = True
        Me.MDGLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MDGLabel5.Location = New System.Drawing.Point(23, 20)
        Me.MDGLabel5.Name = "MDGLabel5"
        Me.MDGLabel5.Size = New System.Drawing.Size(103, 14)
        Me.MDGLabel5.TabIndex = 20
        Me.MDGLabel5.Text = "Тражи колону:"
        '
        'MDGLabel1
        '
        Me.MDGLabel1.AutoSize = True
        Me.MDGLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MDGLabel1.Location = New System.Drawing.Point(23, 68)
        Me.MDGLabel1.Name = "MDGLabel1"
        Me.MDGLabel1.Size = New System.Drawing.Size(149, 14)
        Me.MDGLabel1.TabIndex = 15
        Me.MDGLabel1.Text = "Расположиве колоне:"
        '
        'MDGLabel3
        '
        Me.MDGLabel3.AutoSize = True
        Me.MDGLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MDGLabel3.Location = New System.Drawing.Point(346, 287)
        Me.MDGLabel3.Name = "MDGLabel3"
        Me.MDGLabel3.Size = New System.Drawing.Size(90, 14)
        Me.MDGLabel3.TabIndex = 14
        Me.MDGLabel3.Text = "Број колона:"
        '
        'ybacc
        '
        Me.ybacc.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ybacc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ybacc.Location = New System.Drawing.Point(153, 320)
        Me.ybacc.MaxLength = 0
        Me.ybacc.Name = "ybacc"
        Me.ybacc.ReadOnly = True
        Me.ybacc.Size = New System.Drawing.Size(153, 15)
        Me.ybacc.TabIndex = 16
        '
        'MDGLabel2
        '
        Me.MDGLabel2.AutoSize = True
        Me.MDGLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MDGLabel2.Location = New System.Drawing.Point(23, 287)
        Me.MDGLabel2.Name = "MDGLabel2"
        Me.MDGLabel2.Size = New System.Drawing.Size(90, 14)
        Me.MDGLabel2.TabIndex = 19
        Me.MDGLabel2.Text = "Број колона:"
        '
        'tbdcc
        '
        Me.tbdcc.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tbdcc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbdcc.Location = New System.Drawing.Point(471, 320)
        Me.tbdcc.MaxLength = 0
        Me.tbdcc.Name = "tbdcc"
        Me.tbdcc.ReadOnly = True
        Me.tbdcc.Size = New System.Drawing.Size(153, 15)
        Me.tbdcc.TabIndex = 18
        '
        'lright
        '
        Me.lright.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lright.HorizontalScrollbar = True
        Me.lright.ItemHeight = 14
        Me.lright.Location = New System.Drawing.Point(346, 92)
        Me.lright.Name = "lright"
        Me.lright.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lright.Size = New System.Drawing.Size(246, 184)
        Me.lright.TabIndex = 6
        '
        'lleft
        '
        Me.lleft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lleft.HorizontalScrollbar = True
        Me.lleft.ItemHeight = 14
        Me.lleft.Location = New System.Drawing.Point(23, 92)
        Me.lleft.Name = "lleft"
        Me.lleft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lleft.Size = New System.Drawing.Size(246, 184)
        Me.lleft.TabIndex = 5
        '
        'bc
        '
        Me.bc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bc.BackColor = System.Drawing.Color.Gainsboro
        Me.bc.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bc.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bc.Location = New System.Drawing.Point(461, 16)
        Me.bc.Name = "bc"
        Me.bc.Size = New System.Drawing.Size(153, 24)
        Me.bc.TabIndex = 8
        Me.bc.Text = "Одустани"
        Me.bc.UseVisualStyleBackColor = False
        '
        'bok
        '
        Me.bok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bok.BackColor = System.Drawing.Color.Gainsboro
        Me.bok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.bok.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.bok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bok.ImageIndex = 0
        Me.bok.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.bok.Location = New System.Drawing.Point(200, 16)
        Me.bok.Name = "bok"
        Me.bok.Size = New System.Drawing.Size(153, 24)
        Me.bok.TabIndex = 11
        Me.bok.Text = "Потврди"
        Me.bok.UseVisualStyleBackColor = False
        '
        'MDGLabel4
        '
        Me.MDGLabel4.AutoSize = True
        Me.MDGLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MDGLabel4.Location = New System.Drawing.Point(346, 67)
        Me.MDGLabel4.Name = "MDGLabel4"
        Me.MDGLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MDGLabel4.Size = New System.Drawing.Size(132, 14)
        Me.MDGLabel4.TabIndex = 10
        Me.MDGLabel4.Text = "Приказане колоне:"
        '
        'MDGGroupBox1
        '
        Me.MDGGroupBox1.Controls.Add(Me.MDGbVratiKolone)
        Me.MDGGroupBox1.Controls.Add(Me.MDGbPamtiKolone)
        Me.MDGGroupBox1.Location = New System.Drawing.Point(623, 31)
        Me.MDGGroupBox1.Name = "MDGGroupBox1"
        Me.MDGGroupBox1.Size = New System.Drawing.Size(172, 126)
        Me.MDGGroupBox1.TabIndex = 22
        Me.MDGGroupBox1.TabStop = False
        Me.MDGGroupBox1.Text = "Изабране колоне:"
        '
        'MDGbVratiKolone
        '
        Me.MDGbVratiKolone.BackColor = System.Drawing.Color.Transparent
        Me.MDGbVratiKolone.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.MDGbVratiKolone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MDGbVratiKolone.Location = New System.Drawing.Point(10, 64)
        Me.MDGbVratiKolone.Name = "MDGbVratiKolone"
        Me.MDGbVratiKolone.Size = New System.Drawing.Size(153, 24)
        Me.MDGbVratiKolone.TabIndex = 1
        Me.MDGbVratiKolone.Text = "Врати"
        Me.MDGbVratiKolone.UseVisualStyleBackColor = False
        '
        'MDGbPamtiKolone
        '
        Me.MDGbPamtiKolone.BackColor = System.Drawing.Color.Transparent
        Me.MDGbPamtiKolone.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.MDGbPamtiKolone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MDGbPamtiKolone.Location = New System.Drawing.Point(10, 32)
        Me.MDGbPamtiKolone.Name = "MDGbPamtiKolone"
        Me.MDGbPamtiKolone.Size = New System.Drawing.Size(153, 24)
        Me.MDGbPamtiKolone.TabIndex = 0
        Me.MDGbPamtiKolone.Text = "Памти"
        Me.MDGbPamtiKolone.UseVisualStyleBackColor = False
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.PanelTop.Controls.Add(Me.meText)
        Me.PanelTop.Controls.Add(Me.btnCerrar)
        Me.PanelTop.Controls.Add(Me.Logovan)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(817, 40)
        Me.PanelTop.TabIndex = 142
        '
        'meText
        '
        Me.meText.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.meText.BackColor = System.Drawing.Color.Transparent
        Me.meText.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.meText.ForeColor = System.Drawing.Color.DarkOrange
        Me.meText.Location = New System.Drawing.Point(4, 0)
        Me.meText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.meText.Name = "meText"
        Me.meText.Size = New System.Drawing.Size(348, 40)
        Me.meText.TabIndex = 62
        Me.meText.Tag = "nediraj"
        Me.meText.Text = "text"
        Me.meText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnCerrar.Location = New System.Drawing.Point(773, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 61
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Logovan
        '
        Me.Logovan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Logovan.BackColor = System.Drawing.Color.Transparent
        Me.Logovan.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Logovan.ForeColor = System.Drawing.Color.DarkOrange
        Me.Logovan.Location = New System.Drawing.Point(559, 0)
        Me.Logovan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Logovan.Name = "Logovan"
        Me.Logovan.Size = New System.Drawing.Size(200, 40)
        Me.Logovan.TabIndex = 59
        Me.Logovan.Tag = "nediraj"
        Me.Logovan.Text = "aleksandar.karadjordjevic"
        Me.Logovan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelContext
        '
        Me.PanelContext.BackColor = System.Drawing.Color.Transparent
        Me.PanelContext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelContext.Controls.Add(Me.Panel2)
        Me.PanelContext.Controls.Add(Me.tv)
        Me.PanelContext.Controls.Add(Me.PanelBottom)
        Me.PanelContext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContext.Location = New System.Drawing.Point(0, 40)
        Me.PanelContext.Name = "PanelContext"
        Me.PanelContext.Size = New System.Drawing.Size(817, 694)
        Me.PanelContext.TabIndex = 143
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MDGLabel5)
        Me.Panel2.Controls.Add(Me.MDGbmd)
        Me.Panel2.Controls.Add(Me.tbtc)
        Me.Panel2.Controls.Add(Me.brreAll)
        Me.Panel2.Controls.Add(Me.MDGbmu)
        Me.Panel2.Controls.Add(Me.MDGGroupBox1)
        Me.Panel2.Controls.Add(Me.MDGLabel4)
        Me.Panel2.Controls.Add(Me.baaaAll)
        Me.Panel2.Controls.Add(Me.lright)
        Me.Panel2.Controls.Add(Me.MDGLabel1)
        Me.Panel2.Controls.Add(Me.brre)
        Me.Panel2.Controls.Add(Me.MDGLabel3)
        Me.Panel2.Controls.Add(Me.MDGLabel2)
        Me.Panel2.Controls.Add(Me.lleft)
        Me.Panel2.Controls.Add(Me.baaa)
        Me.Panel2.Controls.Add(Me.ybacc)
        Me.Panel2.Controls.Add(Me.tbdcc)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 289)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(815, 347)
        Me.Panel2.TabIndex = 24
        Me.Panel2.Visible = False
        '
        'tv
        '
        Me.tv.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.tv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tv.Dock = System.Windows.Forms.DockStyle.Top
        Me.tv.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tv.ItemHeight = 25
        Me.tv.LineColor = System.Drawing.Color.DarkOrange
        Me.tv.Location = New System.Drawing.Point(0, 0)
        Me.tv.Name = "tv"
        Me.tv.Size = New System.Drawing.Size(815, 289)
        Me.tv.TabIndex = 10000087
        '
        'PanelBottom
        '
        Me.PanelBottom.Controls.Add(Me.bok)
        Me.PanelBottom.Controls.Add(Me.bc)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 636)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(815, 56)
        Me.PanelBottom.TabIndex = 23
        '
        'FormAzurirajFilterColumns
        '
        Me.AcceptButton = Me.bok
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.CancelButton = Me.bc
        Me.ClientSize = New System.Drawing.Size(817, 734)
        Me.Controls.Add(Me.PanelContext)
        Me.Controls.Add(Me.PanelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAzurirajFilterColumns"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dtMessages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtLang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MDGGroupBox1.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelContext.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage22(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTop_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTop.MouseMove
        ReleaseCapture()
        SendMessage22(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private mect As ect = ect.eec
    Public Enum ect
        eec
        emn
    End Enum
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
    Dim jezik As String
    Dim selectedindexchange As Integer = 0
    Dim niz_TColInfo() As TcolInfo
    Dim niz_dgv() As DataGridView
    Dim sveTabele() As String
    Dim sveTabeleSAPFX() As String
    Dim vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka
    Public indikator As Integer
    Public izabranatabela As String
    Dim mdtLabel As DataTable
    Dim txtmode As String
    Dim redoviMEMG() As DataRow
    Dim redoviMEM() As DataRow
    Dim redoviMEMD() As DataRow
    Dim redoviMEMAK() As DataRow
    Dim brojNodova As Integer = 0
    Dim onlyTableDescription As Boolean = False

    Public Sub New(ByVal ds As DatasetIstrazivanja, ByVal vt As IstrazivanjaVremenskaTackaControl.UserControlVremenskaTacka, ByVal niz_dgv() As DataGridView, ByVal niz_TColInfo() As TcolInfo,
                ByVal sveTabele() As String, ByVal sveTabeleSAPFX() As String, ByVal txtpismo As String, ByVal jezik As String,
                ByVal GlavneIliPomocne As String, ByVal txtmode As String, ByVal mdtLabel As DataTable, ByVal pomind As Integer, ByVal chbA As Boolean)
        Me.New()
        DD = 817 'Me.ClientSize.Width
        VV = 734 'Me.ClientSize.Height
        Me.jezik = jezik
        Me.niz_TColInfo = niz_TColInfo
        Me.niz_dgv = niz_dgv

        Me.sveTabele = sveTabele
        Me.sveTabeleSAPFX = sveTabeleSAPFX
        Me.vt = vt
        Me.txtmode = txtmode
        Me.mdtLabel = mdtLabel

        Call SetLang()
        Me.Logovan.Text = GetUserName.ToString.Trim

        Dim tOpis As String = ""
        Dim pomocne As Boolean = True
        If GlavneIliPomocne Is Nothing Then pomocne = False
        onlyTableDescription = False
        If Not (ds.IST.Rows(0).Item("ABAZA") Is System.DBNull.Value) AndAlso ds.IST.Rows(0).Item("ABAZA").ToString.Trim.ToUpper.IndexOf("ONLYTABLEDESCRIPTION") >= 0 Then
            onlyTableDescription = True
        End If

        redoviMEMG = ds.ISTTABELE.Select("isnull(DG,'G')='G' and isnull(baza,'')<>'0'", "baza ASC")
        redoviMEMD = ds.ISTTABELE.Select("isnull(DG,'G')='D'  and isnull(baza,'')<>'0'", "baza ASC")
        redoviMEMAK = ds.ISTTABELE.Select("(isnull(DG,'G')='A' or isnull(DG,'G')='K') and isnull(baza,'')<>'0'", "baza ASC")
        tv.Nodes.Clear()
        Dim nnode As TreeNode
        Dim red As DatasetIstrazivanja.ISTTABELERow
        brojNodova = 0
        If pomocne = False Then
            For r1 As Integer = 0 To redoviMEMG.GetUpperBound(0)
                red = redoviMEMG(r1)
                Dim rtTabela As String = red.Tabela
                'dodam glavnu
                nnode = tv.Nodes.Add(dajOpis(red))
                nnode.Tag = rtTabela
                brojNodova = brojNodova + 1
                podtabela(rtTabela, redoviMEMD, 1, nnode)
            Next
        End If
        'ISTMessageBox.Show(brojNodova.ToString)

        tv.ExpandAll()

        If pomocne = True Then
            For r1 As Integer = 0 To redoviMEMAK.GetUpperBound(0)
                red = redoviMEMAK(r1)
                Dim rtTabela As String = red.Tabela
                'dodam glavnu
                nnode = tv.Nodes.Add(dajOpis(red))
                nnode.Tag = rtTabela
                brojNodova = brojNodova + 1
                podtabela(rtTabela, redoviMEMD, 1, Nothing)
            Next
        End If


        If brojNodova > 0 Then
            If pomind = -1 Then ' OrElse chbA = True 
                Call bppclick1(Me.tv.Nodes(0))
                If brojNodova > 1 Then
                    Call fontRegularSelectedNode(tv)
                    Panel2.Visible = False
                Else
                    Panel2.Visible = True
                End If
            Else
                'prepisi
                Dim nn As TreeNode = SearchTheTreeView(tv, sveTabele(pomind).Trim.ToUpper)
                Call bppclick1(nn)
                Call dodaj(pomind)
                Panel2.Visible = True
            End If
        Else
            ''msg 228
            Dim msgtxt228 As String = getMessageText(dtMessages, "228", Me.jezik)
            ''msg 229
            Dim msgtxt229 As String = getMessageText(dtMessages, "229", Me.jezik)
            ISTMessageBox.Show(msgtxt228, msgtxt229, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Sub dodaj(ByVal pomind As Integer)

        If Not FormAzuriraj.niz_Left Is Nothing AndAlso Not FormAzuriraj.niz_Right Is Nothing Then
            If Not FormAzuriraj.niz_Left(pomind) Is Nothing AndAlso Not FormAzuriraj.niz_Right(pomind) Is Nothing Then
                Me.lleft.Items.Clear()
                Me.lright.Items.Clear()
                Dim l As String = FormAzuriraj.niz_Left(pomind)
                Dim r As String = FormAzuriraj.niz_Right(pomind)

                Dim ll() As String = l.Split(";")
                For i As Integer = 0 To ll.GetUpperBound(0)
                    Me.lleft.Items.Add(ll(i))
                Next

                Dim rr() As String = r.Split(";")
                For i As Integer = 0 To rr.GetUpperBound(0)
                    Me.lright.Items.Add(rr(i))
                Next
                Me.mset()
            End If
        End If
    End Sub

    Sub podtabela(ByVal rtTabela As String, ByVal redoviMEMD() As DataRow, ByVal nivo As Integer, Optional ByVal no As TreeNode = Nothing)
        For r As Integer = 0 To redoviMEMD.GetUpperBound(0)
            Dim rt As DatasetIstrazivanja.ISTTABELERow
            rt = redoviMEMD(r)
            If rt.IsNadTabelaNull = False AndAlso rt.NadTabela.Trim.ToUpper = rtTabela.Trim.ToUpper Then
                Dim nnode2 As TreeNode
                nnode2 = no.Nodes.Add(dajOpis(rt))
                nnode2.Tag = rt.Tabela
                brojNodova = brojNodova + 1
                Call podtabela(rt.Tabela, redoviMEMD, nivo + 1, nnode2)
            End If
        Next
    End Sub
    Sub tvNodeMouseDoubleClick(ByVal mySelectedNode As TreeNode)
        tv.ExpandAll()
        Call bppclick1(mySelectedNode)
    End Sub

    Sub bppclick1(ByVal nnode As TreeNode, Optional ByVal lk As Boolean = False)

        If Me.tv.Nodes.Count = 0 Then
            Return
        Else
            Dim tt() As String = ttTtt(nnode)
            Dim nadnadtabela As String = tt(0)
            izabranatabela = nnode.Tag.Trim.ToUpper
            If izabranatabela.IndexOf(".") < 0 Then izabranatabela = "DBO." + izabranatabela
            Dim tabela As String = izabranatabela.Trim.ToUpper

            Dim ppp As String = CStr(tabela)
            If ppp.IndexOf("DBO.") = 0 Then
                Dim dd() As String = ppp.Split(".")
                tabela = dd(0)
                If dd.Length > 0 Then tabela = dd(1)
            End If

            Call sselectedindexchange(tabela)
            Call fontRegularSelectedNode(tv)
            tv.SelectedNode = nnode
            tv.SelectedNode.NodeFont = New Font(tv.Font, FontStyle.Bold)
            Panel2.Visible = True
        End If
    End Sub


    Private Sub tv_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tv.NodeMouseClick

        Dim ClickPoint As Point = New Point(e.X, e.Y)
        Dim ClickNode As TreeNode = tv.GetNodeAt(ClickPoint)
        If ClickNode Is Nothing Then Return
        tv.SelectedNode = e.Node
        Dim mySelectedNode As TreeNode
        mySelectedNode = tv.SelectedNode
        Me.Cursor = Cursors.WaitCursor
        Call tvNodeMouseDoubleClick(mySelectedNode)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tv_NodeMouseDoubleClick(ByVal sender As Object,
                                           ByVal e As TreeNodeMouseClickEventArgs) Handles tv.NodeMouseDoubleClick

        Dim mySelectedNode As TreeNode
        mySelectedNode = tv.SelectedNode
        If Not mySelectedNode Is Nothing Then
            If e.Button = MouseButtons.Left Then
                Call tvNodeMouseDoubleClick(mySelectedNode)
            End If
        End If
    End Sub
    Function dajOpis(ByVal rt As DatasetIstrazivanja.ISTTABELERow) As String

        Dim rtTabela As String = rt.Tabela.Trim
        Dim topis As String = rt.Tabela.Trim
        Dim sropis As String = ""
        If rt.IsOpisNull OrElse rt.Opis.Trim = "" Then
        Else
            sropis = sredjenOpis(rt.Opis)
        End If

        If rt.IsOpisNull OrElse rt.Opis.Trim = "" Then
            'topis
        ElseIf rt.Opis.Trim.IndexOf("$") < 0 AndAlso onlyTableDescription = False Then
            If sropis <> "" Then topis = topis + "-" + sropis
        Else
            If sropis <> "" Then topis = sropis
        End If

        Dim MLopis As String = getMultilanguageLabel(mdtLabel, txtmode, rt.Tabela.Trim, "", "td", Me.jezik)
        If MLopis <> "" Then topis = MLopis
        dajOpis = topis + "                 "

    End Function
    Public colL_lbacc() As System.Data.DataColumn
    Public colR_lbacc() As System.Data.DataColumn

    Private Sub sselectedindexchange(ByVal tabela As String)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

        Dim ind As Integer = -1
        If tabela.IndexOf(".") > 0 Then
            ind = Array.IndexOf(sveTabeleSAPFX, tabela)
        Else
            ind = Array.IndexOf(sveTabele, tabela)
        End If

        indikator = ind

        Dim t3 As New System.Data.DataTable

        Me.lleft.Items.Clear()
        Me.lright.Items.Clear()

        Dim c As System.Data.DataColumn

        For Each c In niz_TColInfo(ind).ucol
            Dim bFound As Boolean = False
            Dim col2 As New System.Data.DataColumn(c.ColumnName, c.DataType)
            'If Not c.ExtendedProperties Is Nothing Then
            '    For Each k As Object In c.ExtendedProperties.Keys
            '        col2.ExtendedProperties.Add(k, c.ExtendedProperties.Item(k))
            '    Next
            'End If
            Me.lleft.Items.Add(col2.ColumnName)
        Next

        Me.mset()
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub

    Private Sub SetLang()
        ''
        Dim dt As System.Data.DataTable = getDTVBText(dtLang, "MyDataGrid")

        MDGLabel5.Text = getControlText2(dt, "MDGLabel5", Me.jezik)
        MDGbmd.Text = getControlText2(dt, "MDGbmd", Me.jezik)
        MDGbmu.Text = getControlText2(dt, "MDGbmu", Me.jezik)
        MDGLabel1.Text = getControlText2(dt, "MDGLabel1", Me.jezik)
        MDGLabel3.Text = getControlText2(dt, "MDGLabel3", Me.jezik)
        MDGLabel2.Text = getControlText2(dt, "MDGLabel2", Me.jezik)
        bc.Text = getControlText2(dt, "naslovCancel", Me.jezik)
        bok.Text = getControlText2(dt, "naslovOK", Me.jezik)
        MDGLabel4.Text = getControlText2(dt, "MDGLabel4", Me.jezik)
        MDGGroupBox1.Text = getControlText2(dt, "MDGGroupBox1", Me.jezik)
        MDGbVratiKolone.Text = getControlText2(dt, "MDGbVratiKolone", Me.jezik)
        MDGbPamtiKolone.Text = getControlText2(dt, "MDGbPamtiKolone", Me.jezik)

        meText.Text = getControlText2(dt, "naslov18", Me.jezik)

        tt1.SetToolTip(Me.MDGbmd, getControlText2(dt, "TTbmd", Me.jezik))
        tt1.SetToolTip(Me.MDGbmu, getControlText2(dt, "TTmbu", Me.jezik))
        tt1.SetToolTip(Me.brre, getControlText2(dt, "TTbrre", Me.jezik))
        tt1.SetToolTip(Me.baaa, getControlText2(dt, "TTbaaa", Me.jezik))
        tt1.SetToolTip(Me.baaaAll, getControlText2(dt, "TTbaaaAll", Me.jezik))
        tt1.SetToolTip(Me.brreAll, getControlText2(dt, "TTbrreAll", Me.jezik))

    End Sub

    Private Sub bizaberi(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baaaAll.Click
        Dim o As Object
        For Each o In Me.lleft.Items
            Me.lright.Items.Add(o)
        Next
        Me.lleft.Items.Clear()
        Me.mset()
    End Sub

    Private Sub bodbac(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brreAll.Click
        Dim o As Object
        For Each o In Me.lright.Items
            Me.lleft.Items.Add(o)
        Next
        Me.lright.Items.Clear()
        Me.mset()
    End Sub

    Private Sub ffiltact(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.tbtc.Focus()
        Me.tbtc_TextChanged(Nothing, Nothing)

    End Sub

    Private Sub mset()
        Me.ybacc.Text = Me.lleft.Items.Count.ToString
        Me.tbdcc.Text = Me.lright.Items.Count.ToString
    End Sub

    Private Sub baaa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles baaa.Click
        With Me.lleft
            Dim o As Object
            For Each o In .SelectedItems
                Me.lright.Items.Add(o)
            Next
            Dim a(.SelectedItems.Count - 1) As Object
            .SelectedItems.CopyTo(a, 0)
            For Each o In a
                .Items.Remove(o)
            Next
        End With
        Me.mset()
    End Sub

    Private Sub brre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brre.Click
        With Me.lright
            Dim o As Object
            For Each o In .SelectedItems
                Me.lleft.Items.Add(o)
            Next
            Dim a(.SelectedItems.Count - 1) As Object
            .SelectedItems.CopyTo(a, 0)
            For Each o In a
                .Items.Remove(o)
            Next
        End With
        Me.mset()
    End Sub

    Private Sub bmu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDGbmu.Click
        With Me.lright
            If .SelectedItems.Count > 1 Then
                ISTMessageBox.Show("Select one row", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If .SelectedIndex < 1 Then
                Return
            End If
            Dim i As Integer = .SelectedIndex
            Dim o As Object = .SelectedItem
            .Items.Remove(o)
            .Items.Insert(i - 1, o)
            .SetSelected(i - 1, True)
        End With
    End Sub

    Private Sub bmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDGbmd.Click
        With Me.lright
            If .SelectedItems.Count > 1 Then
                ISTMessageBox.Show("Select one row", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If
            If .SelectedIndex < 0 OrElse .SelectedIndex >= .Items.Count - 1 Then
                Return
            End If
            Dim i As Integer = .SelectedIndex
            Dim o As Object = .SelectedItem
            .Items.Remove(o)
            .Items.Insert(i + 1, o)
            .SetSelected(i + 1, True)
        End With
    End Sub

    Private Sub tbtc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtc.TextChanged
        Me.lleft.ClearSelected()
        Dim s As String = Me.tbtc.Text.Trim
        If s <> String.Empty Then
            Dim i As Integer
            i = Me.lleft.FindString(s)
            If i >= 0 Then
                Me.lleft.SetSelected(i, True)
                Return
            End If
        End If
    End Sub

    Private Sub tbtc_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbtc.GotFocus
        With Me.tbtc
            .Select(0, .Text.Length)
        End With
        Me.tbtc_TextChanged(Nothing, Nothing)
    End Sub

    Private Sub bPamtiKolone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDGbPamtiKolone.Click
        Dim o As Object
        Dim str As String = ""
        For Each o In Me.lright.Items
            str = str + o.ToString() + ";"
        Next
        str = str.Trim
        str = str.Substring(0, str.Length - 1)
        Dim gde As String = System.Environment.GetEnvironmentVariable("TEMP") & "\trt.txt"
        SaveTextToFile(str, gde)
    End Sub

    Private Sub bVratiKolone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDGbVratiKolone.Click

        Me.lright.Items.Clear()
        Dim gde As String = System.Environment.GetEnvironmentVariable("TEMP") & "\trt.txt"

        If File.Exists(gde) Then
            Dim niz As String() = GetFileContents(gde).Split(New Char() {";"c})
            Dim clanNiza As String
            For Each clanNiza In niz
                Me.lright.Items.Add(clanNiza)
            Next
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub FormFilterColumns_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call Podesi_Formu()
        'Call setTheme(GetTheme())
        PanelTop.BackColor = setTheme(Nothing, Nothing)
    End Sub
    'Sub setTheme(ByVal theme As String)
    '    If theme = "L" Then
    '        ISTTheme.ChosenTheme("Light")
    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    Else
    '        ISTTheme.ChosenTheme("Dark")
    '        PanelTop.BackColor = ISTTheme.PanelParent
    '    End If
    'End Sub
    Private Function mgcst(
ByVal css As System.Windows.Forms.GridColumnStylesCollection,
ByVal ctc As String) As System.Windows.Forms.DataGridColumnStyle
        Dim cs As System.Windows.Forms.DataGridColumnStyle
        For Each cs In css
            If Me.mect = ect.emn Then
                If cs.MappingName = ctc Then
                    Return cs
                End If
            Else
                'If mdout.MyGetColumnHeaderTextInitial(cs) = ctc Then
                '    Return cs
                'End If
            End If
        Next
        Return Nothing
    End Function

    Public Sub mgcs(
    ByVal fcolumnforselection As System.Windows.Forms.GridColumnStylesCollection,
    ByRef tcs() As String)
        tcs = New String() {}
        For Each ct As String In Me.lright.Items
            Dim cs As System.Windows.Forms.DataGridColumnStyle
            cs = Me.mgcst(fcolumnforselection, ct)
            ReDim Preserve tcs(1 + tcs.GetUpperBound(0))
            tcs(tcs.GetUpperBound(0)) = cs.MappingName
        Next
    End Sub
    Dim wworg As Integer = 1920 '1366
    Dim hhorg As Integer = 1080 '768
    Dim ww As Integer = 1366 'Me.Width
    Dim hh As Integer = 768 'Me.Heigh
    'Dim RW As Double = ww / wworg   ' Ratio change of width
    'Dim RH As Double = hh / hhorg   ' Ratio change of height
    Dim DD As Integer   'Me.ClientSize.Width
    Dim VV As Integer  ' Me.ClientSize.Height
    Private Sub Podesi_Formu()
        Dim RH As Double = 1
        Dim RW As Double = 1
        If Not Me.WindowState = FormWindowState.Minimized Then
            If VV > hh - 50 Then
                RH = (hh - 50) / VV
                Me.Height = hh - 50 'CInt(VV * RH)
            End If
            If DD > ww Then
                RW = ww / wworg
                Me.Width = CInt(DD * RW)
            End If
            If RH < 1 Then
                For Each k As Control In Me.Controls
                    k.Height = CInt(k.Height * RH)
                    k.Top = CInt(k.Top * RH)
                Next

                tv.Height = CInt(tv.Height * RH)
                tv.Top = CInt(tv.Top * RH)

                Panel2.Height = CInt(Panel2.Height * RH)
                Panel2.Top = CInt(Panel2.Top * RH)

                'For Each k As Control In Panel2.Controls
                '    k.Height = CInt(k.Height * RH)
                '    k.Top = CInt(k.Top * RH)
                'Next

                For Each k As Control In PanelContext.Controls
                    k.Height = CInt(k.Height * RH)
                    k.Top = CInt(k.Top * RH)
                Next

            End If
        End If


    End Sub


End Class