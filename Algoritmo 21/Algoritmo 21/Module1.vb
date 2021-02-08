'21.Elaborar un algoritmo que solicite la edad de 200 personas, y que muestre cuantos son mayores y menores de edad hay.
Module Module1

	Sub Main()
		Dim EP As Short
		Dim MAY As Short = 0
		Dim MEN As Short = 0

		For K As Integer = 1 To 10
			Console.WriteLine("Ingrese la edad")
			EP = Console.ReadLine
			If EP > 18 Then
				MEN += 1
			Else
				MAY += 1
			End If
		Next
		Console.WriteLine("El numero de mayores es: {0}", MAY)
		Console.WriteLine("El numero de menores es: {0}", MEN)
	End Sub

End Module
