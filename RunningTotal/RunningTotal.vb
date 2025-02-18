'header stuff

Option Strict On
Option Explicit On
Option Compare Text

'To do list
' [x] Keep track of transactions in a Function called RunningTotal()
' [x] Get the current total as needed 
' [ ] Provide a way to clear/zero the total
' [ ] Display transactions and runnning total formatted as currency
' [ ] Super bonus: create a method to include sales tax to the transaction amount


Module RunningTotal
    Dim myGlobalNumberThing As Decimal

    Sub Main()
        'For i = 1 To 10
        '    Console.WriteLine(RunningTotal(10))

        'Next ''This works good
        Dim userInput As String
        Dim transactionNumber As Decimal
        Dim quit As Boolean = False
        Do
            Console.WriteLine("Enter a transaction amount or press Q to quit")
            userInput = Console.ReadLine()

            Try
                transactionNumber = CDec(userInput)
                RunningTotal(transactionNumber)
            Catch ex As Exception
                If userInput = "q" Then
                    quit = True
                Else
                    Console.WriteLine($"You entered: {userInput} ")
                End If

            End Try

        Loop Until quit

        Console.Clear()
        Console.WriteLine($"The total is: {RunningTotal(0)}")
        Console.WriteLine("Have a nice day!")
    End Sub

    Function RunningTotal(currentNumber As Decimal) As Decimal
        Static _runningTotal As Decimal 'Dim could be used, but it limits our scope
        _runningTotal += currentNumber

        Return _runningTotal

    End Function

    Sub SomeOtherGuysBadSub()
        myGlobalNumberThing = 0 'Is a good idea to initialize to zero
    End Sub

End Module
