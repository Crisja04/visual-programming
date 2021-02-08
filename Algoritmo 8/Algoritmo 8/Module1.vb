'8. Se tiene los puntos A y B en el cuadrante positivo del plano cartesiano, elabore el algoritmo que permite obtener la distancia entre A y B.
Module Module1

	Sub Main()
		Dim AA As Short
		Dim AB As Short
		Dim OA As Short
		Dim OB As Short
		Dim D As Decimal

		Console.WriteLine("Escribir la abcisa de A")
		AA = Console.ReadLine
		Console.WriteLine("Escribir la abcisa de B")
		AB = Console.ReadLine
		Console.WriteLine("Escribir la ordenada de A")
		OA = Console.ReadLine
		Console.WriteLine("Escribir la ordenada de A")
		OB = Console.ReadLine

		D = ((AB - AA) ^ 2 + (OB - OA) ^ 2) ^ 0.5
		Console.WriteLine("La distancia entre A y B es: {0}", D)

	End Sub

End Module
