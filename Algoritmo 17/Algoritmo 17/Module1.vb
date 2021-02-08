'17. Se desea leer un numero entero de 2 cifras y que se muestre el numero de unidades, decenas que lo componen.
Module Module1

	Sub Main()
		Dim D As Short
		Dim U As Short
		Dim NE As Short
		Dim Q As Short
		Dim R As Short

		Console.WriteLine("Ingrese un numero entre 0 y 99")
		NE = Console.ReadLine
		Q = Math.Truncate(NE / 10)
		R = NE - (Q * 10)
		D = Q
		U = R
		Console.WriteLine("El numero de decenas es: {0}", D)
		Console.WriteLine("El numero de unidades es: {0}", U)
	End Sub

End Module
