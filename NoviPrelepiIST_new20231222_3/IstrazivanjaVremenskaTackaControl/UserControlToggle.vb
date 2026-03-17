
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class UserControlToggle
    Inherits System.Windows.Forms.UserControl

    Private _checked As Boolean
    Public Property Checked As Boolean
        Get
            Return _checked
        End Get
        Set(ByVal value As Boolean)
            If Not _checked.Equals(value) Then
                _checked = value
                Me.OnCheckedChanged()
            End If
        End Set
    End Property

    Protected Overridable Sub OnCheckedChanged()
        RaiseEvent CheckedChanged(Me, EventArgs.Empty)
    End Sub

    Public Event CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)

    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        Me.Checked = Not Me.Checked
        Me.Invalidate()
        MyBase.OnMouseClick(e)
    End Sub
    Private Structure RGBColors
        Public Shared bBackColor As Color = Color.FromArgb(233, 151, 30)
        Public Shared fBackColor As Color = Color.FromArgb(3, 10, 26)
    End Structure
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Me.OnPaintBackground(e)
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        'Dim b1 As Brush
        'b1 = New Drawing.SolidBrush(Color.FromArgb(100, 128, 0, 0))
        'Dim b2 As Brush
        'b2 = New Drawing.SolidBrush(Color.FromArgb(100, 128, 0, 0))
        'Dim b3 As Brush
        'b3 = New Drawing.SolidBrush(Color.FromArgb(100, 128, 0, 0))
        'Dim b4 As Brush
        'b4 = New Drawing.SolidBrush(Color.FromArgb(100, 128, 0, 0))
        Dim b1 As Brush
        b1 = New Drawing.SolidBrush(Color.LightGray)  'pozadina za false  DarkGray
        Dim b2 As Brush
        b2 = New Drawing.SolidBrush(Color.LightGray)  'pozadina za true  
        Dim b3 As Brush
        b3 = New Drawing.SolidBrush(RGBColors.bBackColor) 'FALSE
        Dim b4 As Brush
        b4 = New Drawing.SolidBrush(Color.LightSlateGray)   'TRUE
        Using path As GraphicsPath = New GraphicsPath()
            Dim d As Integer = Padding.All
            Dim r As Integer = Me.Height - 2 * d
            path.AddArc(d, d, r, r, 90, 180)
            path.AddArc(Me.Width - r - d, d, r, r, -90, 180)
            path.CloseFigure()
            e.Graphics.FillPath(If(Checked, b1, b2), path)
            r = Height - 1
            Dim rect As System.Drawing.Rectangle = If(Checked, New System.Drawing.Rectangle(Width - r - 1, 0, r, r), New System.Drawing.Rectangle(0, 0, r, r))

            e.Graphics.FillEllipse(If(Checked, b3, b4), rect)
        End Using





        'Me.OnPaintBackground(e)
        'e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        'Using path = New GraphicsPath()
        '    Dim d = Padding.All
        '    Dim r = Me.Height - 2 * d
        '    path.AddArc(d, d, r, r, 90, 180)
        '    path.AddArc(Me.Width - r - d, d, r, r, -90, 180)
        '    path.CloseFigure()
        '    e.Graphics.FillPath(If(Checked, Brushes.DarkGray, Brushes.LightGray), path)
        '    r = Height - 1
        '    Dim rect = If(Checked, New System.Drawing.Rectangle(Width - r - 1, 0, r, r), New System.Drawing.Rectangle(0, 0, r, r))
        '    e.Graphics.FillEllipse(If(Checked, Brushes.Green, Brushes.LightSlateGray), rect)
        'End Using
    End Sub
End Class