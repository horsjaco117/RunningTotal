'header stuff

Option Strict On
Option Explicit On
Option Compare Text

'To do list
' [x] Keep track of transactions in a Function called RunningTotal()
' [x] Get the current total as needed 
' [x] Provide a way to clear/zero the total
' [x] Display transactions and runnning total formatted as currency
' [ ] Use optional arguments for coolness     
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
            Console.WriteLine("Enter Q to quit")
            Console.WriteLine("Enter T for total")
            Console.WriteLine("Enter C to clear total")
            userInput = Console.ReadLine()
            Console.Clear()


            Try
                transactionNumber = CDec(userInput)
                RunningTotal(transactionNumber)
                Console.WriteLine($"The sales tax on {transactionNumber.ToString("C")} is {calculateSalesTax(transactionNumber).ToString("c")}")
            Catch ex As Exception
                Select Case userInput
                    Case "q"
                        quit = True
                    Case "t"
                        Console.WriteLine($"The current total is {RunningTotal(0).ToString("c")}")
                    Case "c"
                        RunningTotal(, True)
                    Case Else
                        Console.WriteLine($"You entered: {userInput} ")
                End Select

                'If userInput = "q" Then
                'Else
                'End If

            End Try

        Loop Until quit

        Console.Clear()
        Console.WriteLine($"The total is: {RunningTotal(0, False).ToString("c")}")
        Console.WriteLine("Have a nice day!")
    End Sub

    Function RunningTotal(Optional currentNumber As Decimal = 0, Optional clear As Boolean = False) As Decimal
        Static _runningTotal As Decimal = 0 'Dim could be used, but it limits our scope

        If clear Then
            '_runningTotal
        Else

            _runningTotal += currentNumber
        End If

        Return _runningTotal

    End Function

    Function calculateSalesTax(amount As Decimal) As Decimal
        'constants are in all caps
        Const TAXRATE = 0.06@

        Return amount * TAXRATE

    End Function

    Sub SomeOtherGuysBadSub()
        myGlobalNumberThing = 0 'Is a good idea to initialize to zero
    End Sub

End Module
