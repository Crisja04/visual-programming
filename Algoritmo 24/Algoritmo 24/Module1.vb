'24.Elabore un algoritmo que muestre los terminos de la serie que sean menores a 1000.
Module Module1

	Sub Main()
		Dim S As Integer = 0

		While S < 1000
			S = (S ^ 2) + 1
			Console.WriteLine(S)
		End While
	End Sub

End Module
