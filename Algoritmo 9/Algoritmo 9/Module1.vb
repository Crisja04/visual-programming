'9.Elabora un algoritmo que permita averiguar si una persona debe sacar su CUIL, sabiendo su año de nacimiento. El codigo unico de identificacion laboral CUIL es el numero que se otorga a todo trabajador al inicio de su actividad laborar en relacion de dependencia (mayores de 17 años) que pertenezca al sistema integrado de jubilaciones y pensiones SIJP, y a toda otra persona que gestione alguna prestacion o servicio de la seguridad social en la republica argentina.
Module Module1

	Sub Main()
		Dim AN As Short
		Dim AA As Short
		Dim E As Short

		Console.WriteLine("Escribe el año de nacimiento")
		AN = Console.ReadLine
		Console.WriteLine("Escribe el año actual")
		AA = Console.ReadLine
		E = AA - AN
		If (E > 17) Then
			Console.WriteLine("Debe solicitar su CUIL")
		Else
			Console.WriteLine("No debe solicitar su CUIL aun")
		End If
	End Sub

End Module
