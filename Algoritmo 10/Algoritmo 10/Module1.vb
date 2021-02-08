'10. Elabora un algoritmo que solicite la edad de 2 hermanos y muestre un mensaje indicando la edad del mayor y cuantos años de diferencia tiene con el menor.
Module Module1

	Sub Main()
		Dim E1 As Short
		Dim E2 As Short
		Dim DE As Short

		Console.WriteLine("Ingrese la edad del primer hermano")
		E1 = Console.ReadLine
		Console.WriteLine("Ingrese la edad del segundo hermano")
		E2 = Console.ReadLine
		If (E1 > E2) Then
			Console.WriteLine("El primer hermano es el mayor, por")
			DE = E1 - E2
		Else
			Console.WriteLine("El segundo hermano es el mayor, por")
			DE = E2 - E1
		End If
		Console.WriteLine(DE)
	End Sub

End Module
