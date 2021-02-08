'25. Elaborar un algoritmo que solicite ingresar letras hasta que este ingrese una vocal.
Module Module1

	Sub Main()
		Dim L As Char
		Dim SEMAF As Char = "V"

		While SEMAF = "V"
			Console.WriteLine("Ingrese una letra")
			L = Console.ReadLine
			L = CStr(L)
			Select Case L
				Case "A", "a", "E", "e", "I", "i", "O", "o", "U", "u"
					SEMAF = "R"
				Case Else
					SEMAF = "V"
			End Select
		End While
	End Sub

End Module
