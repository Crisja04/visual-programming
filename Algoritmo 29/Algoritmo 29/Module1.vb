'29. Elaborar un algoritmo para obtener el resultado del escrutinio en las elecciones del delegado del colegio, considerar que hay 160 electores y se han presentado 3 candidatos, todos votaron, el algoritmo debe de declarar al ganador por mayoria simple.
Module Module1

	Sub Main()
		Dim VE As Short
		Dim C1 As Short = 0
		Dim C2 As Short = 0
		Dim C3 As Short = 0
		Dim CO As Short = 0
		Dim G As Short

		For K As Integer = 1 To 160
			Console.WriteLine("Escriba el voto")
			VE = Console.ReadLine
			Select Case VE
				Case 1
					C1 += 1
				Case 2
					C2 += 2
				Case 3
					C3 += 3
				Case Else
					CO += 1
			End Select
		Next
		If (C1 > C2) And (C1 > C3) And (C1 > CO) Then
			G = C1
		Else
			If (C2 > C3) And (C2 > CO) Then
				G = C2
			Else
				If (C3 > CO) Then
					G = C3
				Else
					G = CO
				End If
			End If
		End If
		Console.WriteLine("El ganador es: {0}", G)

	End Sub

End Module
