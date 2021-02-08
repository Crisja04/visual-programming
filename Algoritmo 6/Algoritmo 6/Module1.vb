'6. Elabore un algoritmo que lea 3 lados de un triangulo cualquiera y calcule su area, considerar: Si A, B y C son los lados, y S el semiperimetro.
Module Module1

	Sub Main()
		Dim AT As Decimal
		Dim LA As Decimal
		Dim LB As Decimal
		Dim LC As Decimal
		Dim LS As Decimal

		Console.WriteLine("Escriba la longitud A")
		LA = Console.ReadLine
		Console.WriteLine("Escriba la longitud B")
		LB = Console.ReadLine
		Console.WriteLine("Escriba la longitud C")
		LC = Console.ReadLine
		LS = (LA + LB + LC) / 2
		AT = (LS * (LS - LA) * (LS - LB) * (LS - LC)) ^ 0.5
		Console.WriteLine("El area del triangulo es: {0}", AT)
	End Sub

End Module
