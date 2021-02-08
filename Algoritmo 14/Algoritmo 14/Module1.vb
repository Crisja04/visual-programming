'14. Elabore un algoritmo que permita ingresar un numero entero (1 a 10), y muestre su equivalente en romano.
Module Module1

	Sub Main()
		Dim NE As Short
		Dim ER As String

		Console.WriteLine("Ingrese un numero del 1 al 10")
		NE = Console.ReadLine
		Select Case NE
			Case 1
				ER = "I"
			Case 2
				ER = "II"
			Case 3
				ER = "III"
			Case 4
				ER = "IV"
			Case 5
				ER = "V"
			Case 6
				ER = "VI"
			Case 7
				ER = "VII"
			Case 8
				ER = "VIII"
			Case 9
				ER = "IX"
			Case 10
				ER = "X"
		End Select
		Console.WriteLine("{0}, en romanos es {1}", NE, ER)
	End Sub

End Module
