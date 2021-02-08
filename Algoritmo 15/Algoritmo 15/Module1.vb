'15. Elabore un algoritmo que permita ingresar el monto de venta alcanzado por un vendedor durante el mes, luego de calcular la bonificacion que le corresponde sabiendo que: Monto 0-1000 --> 0%, 1000-5000 --> 3%, 5000-20000 --> 5%, mas de 20000 --> 8%
Module Module1

	Sub Main()
		Dim MV As Decimal
		Dim TB As Decimal

		Console.WriteLine("Escriba el monto de venta")
		MV = Console.ReadLine
		Select Case MV
			Case 0 To 999
				TB = 0 * MV
			Case 1000 To 4999
				TB= 0.03 * MV
			Case 5000 To 19999
				TB= 0.05 * MV
			Case Is > 20000
				TB = 0.08 * MV
		End Select
		Console.WriteLine("La bonificion sera de: {0}", TB)
	End Sub

End Module
