'2. Se necesita obtener el promedio simple de un estudiante a partir de sus tres notas parciales.
Module Module1

	Sub Main()
		Dim N1 As Short
		Dim N2 As Short
		Dim N3 As Short
		Dim P As Decimal

		Console.WriteLine("Escribe la Primera Nota")
		N1 = Console.ReadLine
		Console.WriteLine("Escribe la Segunda Nota")
		N2 = Console.ReadLine
		Console.WriteLine("Escribe la Tercera Nota")
		N3 = Console.ReadLine
		P = (N1 + N2 + N3) / 3
		Console.WriteLine("El promedio es: {0}", P)


	End Sub

End Module
