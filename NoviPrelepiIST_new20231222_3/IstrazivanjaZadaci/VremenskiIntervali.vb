Friend Class vi
    Public intrv() As int = {}
    Public datum As Date = Date.Now

    Public Sub New()
    End Sub

    Public ReadOnly Property Count() As Integer
        Get
            Return Me.intrv.Length
        End Get
    End Property

    Public Sub New(ByVal ii As vi)
        ii.jedan()
        Dim bf As Boolean = False
        Dim td As Date = Date.Now
        For Each i As int In ii.intrv
            datum = i.k
            If i.p <= td And td <= i.k Then
                bf = True
            End If
        Next
        If bf Then
            datum = td
        End If
    End Sub

    Public Sub New(ByVal it() As vi, ByVal t As DatasetIntervaliVremenskeTacke.IntervaliDataTable)
        t.Rows.Clear()
        If it.Length = 0 Then
            Return
        End If
        Dim i As vi = it(0)
        Dim p As vi = i
        For Each ii2 As vi In it
            If Not ii2 Is i Then
                p = Me.pr(p, ii2)
            End If
        Next
        jedan()
        Dim bFound As Boolean = False
        Dim td As Date = Date.Now
        For Each ik As int In p.intrv
            t.AddIntervaliRow(ik.p, ik.k)
            datum = ik.k
            If ik.p <= td _
            And td <= ik.k Then
                bFound = True
            End If
        Next
        If bFound Then
            Me.datum = td
        End If
        t.AcceptChanges()
    End Sub

    Private Function pr(ByVal ii As vi, ByVal ii2 As vi) As vi
        Dim result As New vi
        For Each i As int In ii.intrv
            For Each i2 As int In ii2.intrv
                result.ini(i.pk(i2))
            Next
        Next
        Return result
    End Function

    Private Sub jedan()
        Dim i As Integer = 0
        While 0 <= i And i + 1 <= Me.intrv.GetUpperBound(0)
            If Me.intrv(i).inb(Me.intrv(i + 1)) Then
                Dim it As New int(Me.intrv(i).p, Me.intrv(i + 1).k)
                Me.RItem(i, i + 1)
                Me.ie(i, it)
            Else : i += 1
            End If
        End While
    End Sub

    Public Sub ini(ByVal il As int)
        If il.w Then
            Return
        End If
        Dim bFound As Boolean = False
        Dim pk, kr As Date
        Dim i As Integer
        For i = 0 To Me.intrv.GetUpperBound(0)
            If Not Me.intrv(i).mi(il) Then
                bFound = True
                If il.p < Me.intrv(i).p Then
                    pk = il.p
                Else : pk = Me.intrv(i).p
                End If
                Dim endIndex As Integer = -1
                For j As Integer = i To Me.intrv.GetUpperBound(0)
                    If il.k < Me.intrv(j).p Then
                        kr = il.k
                        Exit For
                    End If
                    endIndex = j
                    If il.k <= Me.intrv(j).k Then
                        kr = Me.intrv(j).k
                        Exit For
                    End If
                    If j = Me.intrv.GetUpperBound(0) Then
                        kr = il.k
                        Exit For
                    End If
                Next
                Me.RItem(i, endIndex)
                Exit For
            End If
        Next
        If Not bFound Then
            pk = il.p
            kr = il.k
        End If
        Me.ie(i, New int(pk, kr))
    End Sub

    Private Sub RItem(ByVal si As Integer, ByVal ei As Integer)
        If ei < si Then
            Return
        End If
        For i As Integer = ei + 1 To Me.intrv.GetUpperBound(0)
            Me.intrv(i - ei + si - 1) = Me.intrv(i)
        Next
        ReDim Preserve Me.intrv(Me.intrv.GetUpperBound(0) - (ei - si + 1))
    End Sub

    Private Sub ie(ByVal ix As Integer, ByVal il As int)
        If il.w Then
            Return
        End If
        If ix < 0 OrElse ix > Me.intrv.GetUpperBound(0) + 1 Then
            Return
        End If
        ReDim Preserve Me.intrv(1 + Me.intrv.GetUpperBound(0))
        For j As Integer = Me.intrv.GetUpperBound(0) To ix + 1 Step -1
            Me.intrv(j) = Me.intrv(j - 1)
        Next
        Me.intrv(ix) = il
    End Sub

    Public Structure int
        Dim p As Date
        Dim k As Date
        Dim w As Boolean

        Public Function inb(ByVal i As int) As Boolean
            Dim dan As New System.TimeSpan(1, 0, 0, 0)
            If Me.k = i.p.Subtract(dan) Then
                Return True
            End If
            If Me.p = i.k.Add(dan) Then
                Return True
            End If
            Return False
        End Function

        Public Function mi(ByVal i As int) As Boolean
            If Me.w OrElse i.w Then
                Return True
            End If
            If Me.k < i.p Then
                Return True
            End If
            Return False
        End Function

        Public ReadOnly Property prInt() As int
            Get
                Return New int(Date.MaxValue, Date.MinValue)
            End Get
        End Property

        Public Function pk(ByVal i As int) As int
            If i.w Then
                Return Me.prInt
            End If
            If Me.w Then
                Return Me.prInt
            End If
            If i.k < Me.p Then
                Return Me.prInt
            End If
            If i.p > Me.k Then
                Return Me.prInt
            End If
            If i.p < Me.p Then
                If i.k <= Me.k Then
                    Return New int(Me.p, i.k)
                End If
                Return Me
            End If
            If i.k <= Me.k Then
                Return New int(i.p, i.k)
            End If
            Return New int(i.p, Me.k)
        End Function

        Public Sub New(ByVal po As Date, ByVal kr As Date)
            Me.p = po
            Me.k = kr
            Me.w = Me.k < Me.p
        End Sub

    End Structure

End Class