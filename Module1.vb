Imports System.Console
Module Module1
    Dim j As Integer
    Dim temp As Integer
    Dim count As Integer
    Dim MaxIndex As Integer
    Dim mylist(7) As Integer ' DECLARE mylist : ARRAY[1:7] OF INTEGER
    Dim n As Integer           'DECLARE n : INTEGER
    Dim NoMoreSwaps As Boolean 'DECLARE NoMoreSwaps : BOOLEAN

    Function Search2(SearchNumber As Integer) As Boolean
        Dim found As Boolean
        Dim Index As Integer
        'Dim SearchNumber As Integer 'remove because parameter has been included
        found = False
        For count = 1 To 7
            If SearchNumber = mylist(Index) Then
                found = True
                WriteLine("The number was found at Index" & Index)
            End If
        Next
        If found = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Sub InitializeMaxIndex(upperbound As Integer)
        MaxIndex = upperbound
    End Sub

    Sub Initialize()                      'PROCEDURE Initialize
        For count = 1 To MaxIndex            'FOR count <- 1 TO MaxIndex
            mylist(count) = 0                        'mylist[count] <- 0
        Next                                  'NEXT
    End Sub
    Sub Enter()
        For count = 1 To MaxIndex
            WriteLine("Enter Number to store in the list at index " & count)
            mylist(count) = ReadLine()
        Next
    End Sub
    Sub Display()
        WriteLine("My list is displayed below:")
        For count = 1 To MaxIndex
            WriteLine(mylist(count))
        Next
    End Sub
    Sub BubbleSort() ' PROCEDURE BubbleSort ( )
        n = MaxIndex - 1 'n <- MaxIndex
        Do 'REPEAT
            NoMoreSwaps = True

            For Index = 1 To n
                If mylist(Index) > mylist(Index + 1) Then
                    temp = mylist(Index)
                    mylist(Index) = mylist(Index + 1)
                    mylist(Index + 1) = temp
                    NoMoreSwaps = False
                End If
            Next
            n = n - 1
        Loop Until NoMoreSwaps = True ' UNTIL NoMoreSwaps = TRUE
        WriteLine("the sorted list is shown below: ")
        'ENDPROCEDURE

        For output = 1 To MaxIndex

            WriteLine(mylist(output))
        Next
    End Sub



    Sub Main()
        Call InitializeMaxIndex(7)
        Call Initialize()
        Call Enter()
        Call Display()
        Call BubbleSort()
        Dim Result As Boolean
        Result = Search2(32) ' Result <- Search2( )
        WriteLine(Result) 'OUTPUT Result
        ReadKey()
    End Sub
End Module
