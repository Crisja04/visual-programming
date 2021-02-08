'11. Se tiene registrado la produccion (unidades) logradas por un operario a lo largo de la semana (lunes a sabado). Elabore un algoritmo que nos muestre o nos diga si el operario recibira incentivos sabiendo que el promedio de produccion minima es de 100 unidades.
Module Module1

	Sub Main()
		Dim PL As Short
		Dim PMa As Short
		Dim PMi As Short
		Dim PJ As Short
		Dim PV As Short
		Dim PS As Short
		Dim PT As Short
		Dim PP As Decimal
		Dim MSG As String

		Console.WriteLine("Ingrese produccion del lunes")
		PL = Console.ReadLine
		Console.WriteLine("Ingrese produccion del martes")
		PMa = Console.ReadLine
		Console.WriteLine("Ingrese produccion del miercoles")
		PMi = Console.ReadLine
		Console.WriteLine("Ingrese produccion del jueves")
		PJ = Console.ReadLine
		Console.WriteLine("Ingrese produccion del viernes")
		PV = Console.ReadLine
		Console.WriteLine("Ingrese produccion del sabado")
		PS = Console.ReadLine

		PT = (PL + PMa + PMi + PJ + PV + PS)
		PP = PT / 6
		If (PP >= 100) Then
			MSG = "Recibira incentivos"
		Else
			MSG = "No Recibira incentivos"
		End If
		Console.WriteLine(MSG)

	End Sub

End Module
