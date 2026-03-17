Imports System.Configuration
Imports System.Runtime.InteropServices

Public Class UserControlVremenskaTacka
    Inherits System.Windows.Forms.UserControl

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.dtp.Value = Date.Now
    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Public components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.

    Public WithEvents dtp As System.Windows.Forms.DateTimePicker
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents tbMes59 As IstrazivanjaVremenskaTackaControl.UserControlToggle

    <System.Diagnostics.DebuggerStepThrough()> Public Sub InitializeComponent()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMes59 = New IstrazivanjaVremenskaTackaControl.UserControlToggle()
        Me.SuspendLayout()
        '
        'dtp
        '
        Me.dtp.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.dtp.CustomFormat = "MM / yyyy"
        Me.dtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtp.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(3, 4)
        Me.dtp.Name = "dtp"
        Me.dtp.ShowUpDown = True
        Me.dtp.Size = New System.Drawing.Size(110, 26)
        Me.dtp.TabIndex = 24
        Me.dtp.Value = New Date(2007, 9, 2, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(10, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(58, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "01-12"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbMes59
        '
        Me.tbMes59.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMes59.Checked = False
        Me.tbMes59.Location = New System.Drawing.Point(15, 45)
        Me.tbMes59.Name = "tbMes59"
        Me.tbMes59.Size = New System.Drawing.Size(34, 20)
        Me.tbMes59.TabIndex = 28
        '
        'UserControlVremenskaTacka
        '
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tbMes59)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!)
        Me.Name = "UserControlVremenskaTacka"
        Me.Size = New System.Drawing.Size(115, 71)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '***********************

    '***********************
    Public mvo As String
    Public mvd As String
    Public mts() As ti = {}
    Public MyHELP_FILE As String = Application.StartupPath & "\ist.chm"
    Public HelpP As System.Windows.Forms.HelpProvider

    Public Overloads Sub Dispose()
        Me.HelpP.Dispose()
        MyBase.Dispose()
    End Sub

    Public Structure ti
        Dim name As String
        Dim cn As String
        Dim evod As Boolean
        Dim eGM As Boolean
        Dim eGME As Boolean
        Dim SamoGod As Boolean

        Public Sub New(ByVal name As String, ByVal cn As String, ByVal evod As Boolean, ByVal eGM As Boolean, ByVal eGME As Boolean, Optional ByVal SG As Boolean = False)
            Me.name = name.Trim.ToLower
            Me.evod = evod
            Me.cn = cn.Trim
            Me.eGM = eGM
            Me.eGME = eGME
            If SG Then Me.SamoGod = True
        End Sub

    End Structure
    Public Function IExCOL(ByVal cols As System.Data.DataColumnCollection, ByVal c As String) As Boolean
        c = c.Trim.ToLower
        For Each col As System.Data.DataColumn In cols
            If col.ColumnName.Trim.ToLower = c Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function vWhere(ByVal tN As String, ByVal cName As String, ByVal s As String, Optional ByVal prefiks As String = "") As String
        tN = tN.Trim.ToUpper   'zbog N'(karakter)
        Dim ti As ti = Nothing
        If s <> "" Then
            Do
                For Each ti In mts
                    If Not ti.name Is Nothing Then
                        ti.name = ti.name.Trim.ToUpper
                        If ti.name = tN Then
                            For Each ti2 As ti In mts
                                If ti2.name = tN AndAlso ti2.cn.ToUpper = cName.ToUpper Then
                                    ti = ti2
                                    Exit Do
                                End If
                            Next
                            ti = New ti(ti.name, cName, ti.evod, ti.eGM, ti.eGME, ti.SamoGod)
                            Exit Do
                        End If
                    End If
                Next
                Dim sql As String = "select * from " + tN + " T"
                sql = sql + " where 1=2"
                Dim t As New System.Data.DataTable
                'Dim adp As New System.Data.SqlClient.SqlDataAdapter(sql, s)
                t = FormTemplate.izvrsiSQLvratiDT(sql, s, Nothing)
                Try
                    'adp.Fill(t)
                    If Me.IExCOL(t.Columns, Me.mvo) AndAlso Me.IExCOL(t.Columns, Me.mvd) Then
                        ti = New ti(tN, cName, True, False, False)
                    ElseIf Me.IExCOL(t.Columns, "GOD") AndAlso Me.IExCOL(t.Columns, "MES") Then
                        ti = New ti(tN, cName, False, True, False)
                    ElseIf Me.IExCOL(t.Columns, "ISTYear") AndAlso Me.IExCOL(t.Columns, "ISTMonth") Then
                        ti = New ti(tN, cName, False, False, True)
                    ElseIf Me.IExCOL(t.Columns, "GOD") Then
                        ti = New ti(tN, cName, False, True, False, True)
                    ElseIf Me.IExCOL(t.Columns, "ISTYear") Then
                        ti = New ti(tN, cName, False, False, True, True)
                    Else
                        ti = New ti(tN, cName, False, False, False)
                    End If
                Catch ex As Exception
                    Try
                        Dim sql1 As String = tN.Substring(0, tN.IndexOf("WHERE")) + " WHERE 1=2)"
                        'Dim adp1 As New System.Data.SqlClient.SqlDataAdapter(sql1, s)
                        t = FormTemplate.izvrsiSQLvratiDT(sql1, s, Nothing)
                        'adp1.Fill(t)
                        If Me.IExCOL(t.Columns, Me.mvo) AndAlso Me.IExCOL(t.Columns, Me.mvd) Then
                            ti = New ti(sql1, cName, True, False, False)
                        ElseIf Me.IExCOL(t.Columns, "GOD") AndAlso Me.IExCOL(t.Columns, "MES") Then
                            ti = New ti(sql1, cName, False, True, False)
                        ElseIf Me.IExCOL(t.Columns, "ISTYear") AndAlso Me.IExCOL(t.Columns, "ISTMonth") Then
                            ti = New ti(sql1, cName, False, False, True)
                        ElseIf Me.IExCOL(t.Columns, "GOD") Then
                            ti = New ti(sql1, cName, False, True, False, True)
                        ElseIf Me.IExCOL(t.Columns, "ISTYear") Then
                            ti = New ti(sql1, cName, False, False, True, True)
                        Else
                            ti = New ti(sql1, cName, False, False, False)
                        End If
                    Catch ex1 As Exception
                        ISTMessageBox.Show(ex1.Message)
                    End Try
                Finally
                    'adp.Dispose()
                    t.Dispose()
                End Try
                ReDim Preserve mts(1 + mts.GetUpperBound(0))
                mts(mts.GetUpperBound(0)) = ti
            Loop While False
        Else
            ti = New ti(tN, cName, True, False, False)
        End If
        If ti.evod Then
            Dim ldm As String = Me.DADD("01.01." + Me.G.ToString, Me.M, -1)
            Dim sql As String = "((" + ldm + ") between "
            If ti.cn <> "" Then sql = sql + ti.cn + "."
            sql = sql + Me.mvo + " and "
            If ti.cn <> "" Then sql = sql + ti.cn + "."
            sql = sql + Me.mvd + ")"
            Return sql
        End If
        If ti.eGM Then
            Return Me.vtwhere(ti.cn, prefiks, ti.SamoGod)
        End If
        If ti.eGME Then
            Return Me.yvtwhere(ti.cn, prefiks, ti.SamoGod)
        End If
        Return ""
    End Function

    Function DADD(ByVal sd As String, ByVal am As Integer, ByVal ad As Integer) As String
        'MS SQL SERVER
        Dim sql As String = "dateadd(day," + ad.ToString + ",dateadd(month," + am.ToString + ",'" + sd + "'))"
        Return sql
    End Function

    Public ReadOnly Property MyValue() As Date
        Get
            Return Me.dtp.Value
        End Get
    End Property

    Public Sub MyInit(ByVal vod As String, ByVal vdo As String, ByVal md As Date, ByVal mmd As Date, ByVal value As Date)
        mts = New ti() {}
        Me.mvo = vod
        Me.mvd = vdo

        Dim oDateMin As DateTime = Convert.ToDateTime("1/1/1800")
        Dim oDateMax As DateTime = Convert.ToDateTime("1/1/2099")
        Dim ddMinDateTime As Date = oDateMin
        Dim ddMaxDateTime As Date = oDateMax

        If md < ddMinDateTime Then md = ddMinDateTime
        If mmd > ddMaxDateTime Then mmd = ddMaxDateTime

        Me.dtp.Checked = False
        If md <= mmd Then
            Me.dtp.MinDate = md
            Me.dtp.MaxDate = mmd
            value = New Date(value.Year, value.Month, 2)
            If value < Me.dtp.MinDate OrElse value > Me.dtp.MaxDate Then
                Me.dtp.Value = Me.dtp.MinDate
            Else
                Me.dtp.Value = value
            End If
        End If
        Me.dtp.Checked = True
    End Sub

    Public Sub Init(ByVal ucVT As UserControlVremenskaTacka)

        Me.mvo = ucVT.mvo
        Me.mvd = ucVT.mvd
        mts = ucVT.mts
        Me.dtp.Checked = False
        Me.dtp.MinDate = ucVT.dtp.MinDate
        Me.dtp.MaxDate = ucVT.dtp.MaxDate
        Me.dtp.Value = ucVT.dtp.Value
        Me.dtp.CustomFormat = ucVT.dtp.CustomFormat
        Me.dtp.Checked = True
    End Sub

    Public ReadOnly Property GWhere(ByVal p As String) As String
        Get
            Dim god As String = "GOD"
            If p <> "" Then god = p.Trim + "." + god
            Return god + "='" + Me.dtp.Value.Year.ToString + "'"
        End Get
    End Property

    Public ReadOnly Property YWhere(ByVal p As String) As String
        Get
            Dim god As String = "ISTYEAR"
            If p <> "" Then god = p.Trim + "." + god
            Return god + "='" + Me.dtp.Value.Year.ToString + "'"
        End Get
    End Property

    Public ReadOnly Property mWhere(ByVal p As String) As String
        Get
            Dim mes As String = "MES"
            If p <> "" Then mes = p.Trim + "." + mes
            If Me.tbMes59.Checked Or (Me.dtp.CustomFormat.IndexOf("ss") >= 0) Then
                Return mes + "='" + String.Format("{0:d2}", Me.dtp.Value.Second) + "'"
            Else
                Return mes + "='" + String.Format("{0:d2}", Me.dtp.Value.Month) + "'"
            End If
        End Get
    End Property

    Public ReadOnly Property monWhere(ByVal p As String) As String
        Get
            Dim mes As String = "ISTMONTH"
            If p <> "" Then mes = p.Trim + "." + mes
            If Me.tbMes59.Checked Or (Me.dtp.CustomFormat.IndexOf("ss") >= 0) Then
                Return mes + "='" + String.Format("{0:d2}", Me.dtp.Value.Second) + "'"
            Else
                Return mes + "='" + String.Format("{0:d2}", Me.dtp.Value.Month) + "'"
            End If
        End Get
    End Property

    Public ReadOnly Property vtwhere(ByVal p As String, Optional ByVal prefiks As String = "", Optional ByVal SG As Boolean = False) As String
        Get
            Dim vt As String = ""
            vt = vt + prefiks & Me.GWhere(p)
            If Not SG Then
                If vt <> "" Then vt = vt + " and "
                vt = vt + prefiks & Me.mWhere(p)
            End If
            Return vt
        End Get
    End Property

    'za VRTACKU, nije pokriveno na engleskom i nece ni biti
    Public ReadOnly Property yvtwhere(ByVal p As String, Optional ByVal prefiks As String = "", Optional ByVal SG As Boolean = False) As String
        Get
            Dim vt As String = ""
            vt = vt + prefiks & Me.YWhere(p)
            If Not SG Then
                If vt <> "" Then vt = vt + " and "
                vt = vt + prefiks & Me.monWhere(p)
            End If
            Return vt
        End Get
    End Property

    Public ReadOnly Property vtpos() As String
        Get
            Dim vt As String = "#" + Me.dtp.Value.Year.ToString + ";"
            If Me.tbMes59.Checked Then
                vt = vt + String.Format("{0:d2}", Me.dtp.Value.Second)
            Else
                vt = vt + String.Format("{0:d2}", Me.dtp.Value.Month)
            End If
            Return vt + "##"
        End Get
    End Property

    Public ReadOnly Property G() As Integer
        Get
            Return Me.dtp.Value.Year
        End Get
    End Property

    Public ReadOnly Property M() As Integer
        Get
            If Me.tbMes59.Checked Or (Me.dtp.CustomFormat.IndexOf("ss") >= 0) Then
                Return Me.dtp.Value.Second
            Else
                Return Me.dtp.Value.Month
            End If
        End Get
    End Property

    Public Event ValueChanged()

    Public Sub dtp_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp.ValueChanged
        RaiseEvent ValueChanged()
    End Sub

    Private Sub tb59_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbMes59.CheckedChanged
        If Me.tbMes59.Checked Then
            Me.dtp.CustomFormat = "ss / yyyyy"
            Label1.Text = "00-59"
        Else
            Me.dtp.CustomFormat = "MM / yyyyy"
            Label1.Text = "01-12"
        End If
    End Sub


End Class

'**********************
