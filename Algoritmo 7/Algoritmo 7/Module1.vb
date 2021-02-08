'7. Elaborar un algoritmo que permita calcular el numero de CDs necesarios para hacer una copia de seguridad, de la informacion almacenada en un disco cuya capacidad se conoce. Considerar que el disco duro esta lleno de informacion, ademas expresado en gigabyte. Un CD virgen tiene 700 Megabytes de capacidad y un gigabyte es igual a 1,024 megabytes.
Module Module1

	Sub Main()
		Dim CD As Short
		Dim GB As Integer
		Dim MG As Integer

		Console.WriteLine("Escribe el numero de gigabytes")
		GB = Console.ReadLine
		MG = GB * 1024
		CD = Math.Truncate((MG / 700) + 1)
		Console.WriteLine("El numero de CD: {0}", CD)
	End Sub

End Module
