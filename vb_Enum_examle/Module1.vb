Module Module1
    Public Enum EnumFindDirection As Integer
        Nearest = 0
        Less = 1
        LessOrEqual = 2
        Greater = 3
        GreaterOrEqual = 4
    End Enum

    <DebuggerStepThrough>
    Public Function FindNearestEnumValue(Of T)(ByVal value As Long,
                                                  ByVal direction As EnumFindDirection) As T

        Select Case direction

            Case EnumFindDirection.Nearest
                Return (From enumValue As T In [Enum].GetValues(GetType(T)).Cast(Of T)()
                        Order By Math.Abs(value - Convert.ToInt64(enumValue))
                    ).FirstOrDefault

            Case EnumFindDirection.Less
                If value < Convert.ToInt64([Enum].GetValues(GetType(T)).Cast(Of T).First) Then
                    Return [Enum].GetValues(GetType(T)).Cast(Of T).FirstOrDefault

                Else
                    Return (From enumValue As T In [Enum].GetValues(GetType(T)).Cast(Of T)()
                            Where Convert.ToInt64(enumValue) < value
                        ).LastOrDefault
                End If

            Case EnumFindDirection.LessOrEqual
                If value < Convert.ToInt64([Enum].GetValues(GetType(T)).Cast(Of T).First) Then
                    Return [Enum].GetValues(GetType(T)).Cast(Of T).FirstOrDefault

                Else
                    Return (From enumValue As T In [Enum].GetValues(GetType(T)).Cast(Of T)()
                            Where Convert.ToInt64(enumValue) <= value
                        ).LastOrDefault
                End If

            Case EnumFindDirection.Greater
                If value > Convert.ToInt64([Enum].GetValues(GetType(T)).Cast(Of T).Last) Then
                    Return [Enum].GetValues(GetType(T)).Cast(Of T).LastOrDefault

                Else
                    Return (From enumValue As T In [Enum].GetValues(GetType(T)).Cast(Of T)()
                            Where Convert.ToInt64(enumValue) > value
                        ).FirstOrDefault
                End If

            Case EnumFindDirection.GreaterOrEqual
                If value > Convert.ToInt64([Enum].GetValues(GetType(T)).Cast(Of T).Last) Then
                    Return [Enum].GetValues(GetType(T)).Cast(Of T).LastOrDefault

                Else
                    Return (From enumValue As T In [Enum].GetValues(GetType(T)).Cast(Of T)()
                            Where Convert.ToInt64(enumValue) >= value
                        ).FirstOrDefault
                End If

        End Select

    End Function

    Enum Size
        Small
        Medium
        Large
    End Enum
    Sub Main()
        'Dim enu As [Enum] = New ConsoleColor()
        'Dim hasFlags As Boolean = enu.GetType().GetCustomAttributes(GetType(FlagsAttribute), inherit:=False).Any()
        'Console.WriteLine("{0} Enum has FlagsAttribute?: {1}", enu.GetType().Name, hasFlags)
        Dim sizes = [Enum].GetNames(GetType(EnumFindDirection))

        For Each size In sizes
            Console.WriteLine(size)
        Next

        Dim shirtSize As Size = DirectCast([Enum].Parse(GetType(Size), "Medium"), Size)

        ' Prints 'Medium'
        Console.WriteLine(shirtSize.ToString())

        ' Waits until user presses any key
        Console.ReadKey()

    End Sub

End Module
