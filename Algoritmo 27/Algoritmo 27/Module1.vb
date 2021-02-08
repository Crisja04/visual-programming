'27. Elaborar un algoritmo que solicite 2 numeros enteros y un operador aritmetico y luego debe de mostrar el resultado de la operacion correspondiente.
Module Module1

	Sub Main()
		Dim N1 As Integer
		Dim N2 As Integer
		Dim OP As Char
		Dim R As Integer

		Console.WriteLine("Escriba el primer numero")
		N1 = Console.ReadLine
		Console.WriteLine("Escriba el segundo numero")
		N2 = Console.ReadLine
		Console.WriteLine("Escriba la operacion (+,-,*,^")
		OP = Console.ReadLine

		Select Case OP
			Case "+"
				R = N1 + N2
			Case "-"
				R = N1 - N2
			Case "*"
				R = N1 * N2
			Case "^"
				R = N1 ^ N2
			Case Else
				R = 0
		End Select
		Console.WriteLine("El resultado es: {0}", R)
	End Sub

End Module
