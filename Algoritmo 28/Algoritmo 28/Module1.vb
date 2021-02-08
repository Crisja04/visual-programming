'28. Elaborar un algoritmo que permita ingresar 10 letras cualquiera, y luego nos indique al final cuantas vocales y consonantes se ingresaron.
Module Module1

	Sub Main()
		Dim L As Char
		Dim NV As Integer = 0
		Dim NC As Integer = 0

		For K As Integer = 1 To 10
			Console.WriteLine("Escriba una letra")
			L = Console.ReadLine
			Select Case L
				Case "A", "a", "E", "e", "I", "i", "O", "o", "U", "u"
					NV += 1
				Case Else
					NC += 1
			End Select
		Next
		Console.WriteLine("El numero de vocales es: {0}", NV)
		Console.WriteLine("El numero de consonantes es: {0}", NC)

	End Sub

End Module
