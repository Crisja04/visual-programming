'30. Elaborar un algoritmo que solicite 2 numeros y muestre el promedio de ambos.
Module Module1

	Sub Main()
		Dim N1 As Integer
		Dim N2 As Integer
		Dim S As Integer
		Dim P As Decimal

		Console.WriteLine("Ingrese el primer numero")
		N1 = Console.ReadLine
		Console.WriteLine("Ingrese el segundo numero")
		N2 = Console.ReadLine

		S = N1 + N2
		P = S / 2
		Console.WriteLine("El resultado es: {0}", P)
	End Sub

End Module
