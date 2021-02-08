'16. Elabore un algoritmo que solicite un numero entero y muestre un mensaje indicando la vocal correspondiente, considerando que la vocal A = 1.
Module Module1

	Sub Main()
		Dim NE As Short
		Dim V As String

		Console.WriteLine("Escriba un numero del 1 al 5")
		NE = Console.ReadLine

		Select Case NE
			Case 1
				V = "A"
			Case 2
				V = "E"
			Case 3
				V = "I"
			Case 4
				V = "O"
			Case 5
				V = "U"
			Case Else
				V = "Valor incorrecto"
		End Select
		Console.WriteLine(V)
	End Sub

End Module
