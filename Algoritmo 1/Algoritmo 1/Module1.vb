'1. Se desea calcular la distancia recorrida (m) por un movil que tiene velocidad constante (m/s) durante un tiempo T (Sg), considerar que es un MRU (Movimiento Rectilineo Uniforme).
Module Module1

	Sub Main()
		Dim V As Decimal
		Dim T As Decimal
		Dim D As Double

		Console.Write("Escribe la velocidad")
		Console.WriteLine()
		V = Console.ReadLine
		Console.Write("Escriba el tiempo")
		Console.WriteLine()
		T = Console.ReadLine
		D = V * T
		Console.Write("La distancia recorrida es {0}", D)
		Console.WriteLine()
	End Sub

End Module
