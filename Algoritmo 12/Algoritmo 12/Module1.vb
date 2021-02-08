'12.Elabora un algoritmo para leer 3 numeros enteros diferentes entre si, y determinar el numero mayor de los tres.
Module Module1

	Sub Main()
		Dim N1 As Integer
		Dim N2 As Integer
		Dim N3 As Integer
		Dim NM As Integer

		Console.WriteLine("Escriba el primer numero")
		N1 = Console.ReadLine
		Console.WriteLine("Escriba el segundo numero")
		N2 = Console.ReadLine
		Console.WriteLine("Escriba el tercer numero")
		N3 = Console.ReadLine

		If (N1 > N2) And (N1 > N3) Then
			NM = N1
		Else
			If (N2 > N3) Then
				NM = N2
			Else
				NM = N3
			End If
		End If
		Console.WriteLine("El mayor de los numeros es: {0}", NM)

	End Sub

End Module
