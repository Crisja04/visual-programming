'3. Elaborar un algoritmo que solicite el numero de respuestas correctas, incorrectas y en blanco, correspondientes a postulantes, y muestre su puntaje final considerando, que por cada respuesta correcta tendra 4 putnos, respuestas incorrectas tendra -1 y respuestas en blanco tendra 0.
Module Module1

	Sub Main()
		Dim RC As Short
		Dim RI As Short
		Dim RB As Short
		Dim PRC As Short
		Dim PRI As Short
		Dim PF As Short
		Console.WriteLine("Escriba el numero de respuestas correctas")
		RC = Console.ReadLine
		Console.WriteLine("Escriba el numero de respuestas incorrectas")
		RI = Console.ReadLine
		Console.WriteLine("Escriba el numero de respuestas en blanco")
		RB = Console.ReadLine
		PRC = RC * 4
		PRI = RI * -1
		PF = PRC + PRI
		Console.WriteLine("Su puntaje final es: {0}", PF)
	End Sub

End Module
