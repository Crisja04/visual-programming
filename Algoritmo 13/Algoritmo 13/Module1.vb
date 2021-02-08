'13. Elabora un algoritmo que sirva para identificar el tipo de triangulo conociendo sus tres lados.
Module Module1

	Sub Main()
		Dim L1 As Decimal
		Dim L2 As Decimal
		Dim L3 As Decimal
		Dim TT As String

		Console.WriteLine("Escribe el largo del primer lado")
		L1 = Console.ReadLine
		Console.WriteLine("Escribe el largo del segundo lado")
		L2 = Console.ReadLine
		Console.WriteLine("Escribe el largo del tercer lado")
		L3 = Console.ReadLine

		If (L1 <> L2) And (L2 <> L3) And (L3 <> L1) Then
			TT = "Escaleno"
		Else
			If (L1 = L2) And (L2 = L3) Then
				TT = "Equilatero"
			Else
				TT = "Isosceles"
			End If
		End If
		Console.WriteLine(TT)
	End Sub

End Module
