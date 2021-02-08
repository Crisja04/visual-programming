'20.Elaborar un algoritmo que permita mostrar el sueldo promedio de un grupo de empleados.
Module Module1

	Sub Main()
		Dim SE As Decimal
		Dim NE As Short
		Dim SS As Decimal
		Dim SP As Decimal

		Console.WriteLine("Escriba el numero de empleados")
		NE = Console.ReadLine
		SS = 0
		For K As Integer = 1 To NE
			Console.WriteLine("Ingrese el sueldo")
			SE = Console.ReadLine
			SS = SS + SE
		Next
		SP = SS / NE
		Console.WriteLine("El sueldo promedio es: {0}", SP)
	End Sub

End Module
