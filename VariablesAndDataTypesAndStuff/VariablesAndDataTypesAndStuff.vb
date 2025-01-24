'Payden Hoskins
'Spring 2025
'RCET2265
'OperatorsExample
'https://github.com/PaydenHoskins/VariablesAndDataTypesAndStuff.git

Option Strict On
Option Explicit On


Imports System.Globalization
Imports Microsoft.VisualBasic.ApplicationServices


Module VariablesAndDataTypesAndStuff


    Sub Main()

        Dim LaffyTaffy As Integer
        Dim jellyBeans As Integer
        Dim userinput As String
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        Console.WriteLine(jellyBeans)

        jellyBeans = 120
        Console.WriteLine(jellyBeans)

        jellyBeans = jellyBeans + 10
        Console.WriteLine(jellyBeans)

        jellyBeans += 10
        Console.WriteLine(jellyBeans)

        LaffyTaffy = 26
        Console.WriteLine(LaffyTaffy)

        Console.WriteLine("Choose your first number")
        userinput = Console.ReadLine()
        firstNumber = CInt(userinput)
        Console.WriteLine("Choose your second number")
        userinput = Console.ReadLine()
        secondNumber = CInt(userinput)

        Console.WriteLine("Please make a selection:" & vbNewLine _
                          & "1. subtract" & vbNewLine _
                          & "2. add")
        userinput = Console.ReadLine()

        Console.WriteLine($"you have selecter {userinput}")
        If userinput = "1" Then
            Console.WriteLine("Let's subtract!")
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}")
        ElseIf userinput = "2" Then
            Console.WriteLine("Let's Add!")
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        Else
            Console.WriteLine("INVALID, Try again later!")
        End If


    End Sub

End Module
