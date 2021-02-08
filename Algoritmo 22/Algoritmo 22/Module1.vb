'22. Elaborar un algoritmo que solicite 2 numeros enteros y muestre su producto por el metodo de sumas sucesivas.
Module Module1

	Sub Main()
		Dim PN As Integer
		Dim SN As Integer
		Dim P As Integer = 0

		Console.WriteLine("Escriba el primer numero")
		PN = Console.ReadLine
		Console.WriteLine("Escriba el segundo numero")
		SN = Console.ReadLine
		For K As Integer = 1 To SN
			P += PN
		Next
		Console.WriteLine("El producto es: {0}", P)
	End Sub

End Module
