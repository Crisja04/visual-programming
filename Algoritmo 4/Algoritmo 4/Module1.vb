'4. Elaborar un algoritmo que permita ingresar el numero de partidos ganados, perdidos y empatados, por algun equipo en el torneo apertura, se debe de mostrar su puntaje total, teniendo en cuenta que por cada partido ganado obtendra 3 puntos, empatado 1 punto y perdido 0 puntos.
Module Module1

	Sub Main()
		Dim PG As Short
		Dim PE As Short
		Dim PP As Short
		Dim PPG As Short
		Dim PPE As Short
		Dim PT As Short

		Console.WriteLine("Escribe el numero de partidos ganados")
		PG = Console.ReadLine
		Console.WriteLine("Escribe el numero de partidos empatados")
		PE = Console.ReadLine
		Console.WriteLine("Escribe el numero de partidos perdidos")
		PP = Console.ReadLine
		PPG = PG * 3
		PPE = PE * 1
		PT = PPG + PPE
		Console.WriteLine("El puntaje total es: {0}", PT)
	End Sub

End Module
