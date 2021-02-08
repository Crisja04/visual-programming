'31. Elabora un algoritmo que solicite un numero entero y muestre el nombre del mes correspondiente.
Module Module1

	Sub Main()
		Dim N As Short
		Dim MES As String

		Console.WriteLine("Ingrese un numero del 1 al 12")
		N = Console.ReadLine
		Select Case N
			Case 1
				MES = "Enero"
			Case 2
				MES = "Febrero"
			Case 3
				MES = "Marzo"
			Case 4
				MES = "Abril"
			Case 5
				MES = "Mayo"
			Case 6
				MES = "Junio"
			Case 7
				MES = "Julio"
			Case 8
				MES = "Agosto"
			Case 9
				MES = "Septiembre"
			Case 10
				MES = "Octubre"
			Case 11
				MES = "Noviembre"
			Case 12
				MES = "Diciembre"
			Case Else
				MES = "Invalido"
		End Select
		Console.WriteLine(MES)
	End Sub

End Module
