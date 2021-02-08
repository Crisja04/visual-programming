'5. Se requiere el algoritmo para elaborar la planilla de un empleado. Para ello se dispone de sus horas laboradas en el mes, asi como de la tarifa por hora.
Module Module1

	Sub Main()
		Dim HL As Short
		Dim TH As Short
		Dim P As Short

		Console.WriteLine("Escribe el numero de horas laboradas")
		HL = Console.ReadLine
		Console.WriteLine("Escribe la tarifa por hora")
		TH = Console.ReadLine
		P = HL * TH
		Console.WriteLine("La planilla es: {0}", P)

	End Sub

End Module
