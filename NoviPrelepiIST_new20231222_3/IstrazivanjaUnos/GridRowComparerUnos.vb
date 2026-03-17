Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Windows.Forms

'Imports System.Collections.Comparer

Namespace DataGridViewMultiSortUnos

    Public Class GridRowComparerUnos
        Implements System.Collections.IComparer
        Private _columnList As List(Of KeyValuePair(Of DataGridViewColumn, Boolean))

        Public Sub New(ByVal columnList As List(Of KeyValuePair(Of DataGridViewColumn, Boolean)))
            _columnList = columnList
        End Sub

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
            Dim DataGridViewRow1 As DataGridViewRow = DirectCast(x, DataGridViewRow)
            Dim DataGridViewRow2 As DataGridViewRow = DirectCast(y, DataGridViewRow)

            Dim CompareResult__1 As Integer = compareResult(DataGridViewRow1, DataGridViewRow2, 0)

            Return (CompareResult__1)
        End Function

        Public Function compareResult(ByVal DataGridViewRow1 As DataGridViewRow, ByVal DataGridViewRow2 As DataGridViewRow, ByVal i As Integer) As Integer
            Dim dgvColumn As DataGridViewColumn = _columnList(i).Key

            Dim sortOrderModifier As Integer = 0
            If _columnList(i).Value Then
                sortOrderModifier = 1
            Else
                sortOrderModifier = -1
            End If

            Dim CompareResult__1 As Integer = 0

            Dim value1 As Object = DataGridViewRow1.Cells(dgvColumn.Index).Value
            Dim value2 As Object = DataGridViewRow2.Cells(dgvColumn.Index).Value

            'Sort Images Together if images are in datagrid view
            If (TypeOf value1 Is System.Drawing.Bitmap) AndAlso Not (TypeOf value2 Is System.Drawing.Bitmap) Then
                Return -1 * sortOrderModifier
            ElseIf Not (TypeOf value1 Is System.Drawing.Bitmap) AndAlso (TypeOf value2 Is System.Drawing.Bitmap) Then
                Return 1 * sortOrderModifier
            ElseIf TypeOf value1 Is System.Drawing.Bitmap AndAlso TypeOf value2 Is System.Drawing.Bitmap Then
                Return 0
            End If

            Dim cellValue1 As String = Convert.ToString(DataGridViewRow1.Cells(dgvColumn.Index).Value)
            Dim cellValue2 As String = Convert.ToString(DataGridViewRow2.Cells(dgvColumn.Index).Value)

            'When Cell value is null or empty
            If (cellValue1 Is Nothing OrElse cellValue1 = String.Empty) AndAlso (cellValue2 IsNot Nothing OrElse cellValue2 <> String.Empty) Then
                Return -1 * sortOrderModifier
            ElseIf (cellValue1 IsNot Nothing OrElse cellValue1 <> String.Empty) AndAlso (cellValue2 Is Nothing OrElse cellValue2 = String.Empty) Then
                Return 1 * sortOrderModifier
            ElseIf (cellValue1 Is Nothing OrElse cellValue1 = String.Empty) AndAlso (cellValue2 Is Nothing OrElse cellValue2 <> String.Empty) Then
                Return 0
            End If

            'compare Numeric values
            If dgvColumn.ValueType Is GetType([Double]) Then
                Dim numVal1 As Double = Convert.ToDouble(cellValue1)
                Dim numVal2 As Double = Convert.ToDouble(cellValue2)

                If numVal1 > numVal2 Then
                    CompareResult__1 = 1
                ElseIf numVal1 < numVal2 Then
                    CompareResult__1 = -1
                Else
                    CompareResult__1 = 0
                End If
                'compare date values
            ElseIf dgvColumn.ValueType Is GetType(DateTime) Then
                Dim cellValueDt1 As DateTime
                Dim cellValueDt2 As DateTime

                If (DateTime.TryParse(cellValue1, cellValueDt1)) AndAlso (DateTime.TryParse(cellValue2, cellValueDt2)) Then
                    If cellValueDt1 > cellValueDt2 Then
                        CompareResult__1 = 1
                    ElseIf cellValueDt1 < cellValueDt2 Then
                        CompareResult__1 = -1
                    Else
                        CompareResult__1 = 0

                    End If
                End If
            Else
                'compare string values
                CompareResult__1 = System.[String].Compare(cellValue1, cellValue2)
            End If

            CompareResult__1 = CompareResult__1 * sortOrderModifier

            'if same values, perform this routine again
            If CompareResult__1 = 0 Then
                If i <> _columnList.Count - 1 Then
                    i += 1
                    CompareResult__1 = compareResult(DataGridViewRow1, DataGridViewRow2, i)
                End If
            End If
            Return CompareResult__1
        End Function

    End Class

End Namespace