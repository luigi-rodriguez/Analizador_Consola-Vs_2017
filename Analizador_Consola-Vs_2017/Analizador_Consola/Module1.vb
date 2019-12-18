Module Module1

    Sub Main()
        Console.WriteLine("")
        Console.WriteLine("Análizador Léxico y Sintático")
        Console.WriteLine("Análizador de una EXPRESIÓN Algebraica")
        Console.WriteLine("")
        Console.WriteLine("Creado Por J.L Rodriguez Andrade")
        Console.WriteLine("")
        Console.WriteLine("Ingrese Una Expresión Algebraica;")
        Console.WriteLine("")

        'Se declara la variable como cadena donde sera leida
        Dim MiCadeda As String = Console.ReadLine
        Console.WriteLine(" ")

        Dim MiCaracter As String
        'Permite saber la Longitud del tamaño de la Expreseión Ingresada
        Dim TesLen As Integer = Len(MiCadeda)
        'Se crea otra variable en la cual contendra la cadena de Caracteres y define la longitud de la cadena
        Dim exp(TesLen) As String

        'se declaran los contadores para los ciclos for
        Dim i As Integer
        Dim j As Integer

        Console.WriteLine("Analizador Léxico")

        Console.WriteLine("     Tokens Recorridos;  ")
        Console.WriteLine("     ")

        'Ciclo que recorrera con la longitud que fue asignada de mayor a menor; For i = 0 To (TesLen - 1)
        'ejemplo(5, 4, 3, 2, 1, 0)
        For i = 0 To (TesLen - 1)
            'Cada caracter guardado en "MiCadena" sera guardado en "MiCaracter" por separado
            MiCaracter = MiCadeda.Chars(i)

            'Cada "Sí" o "No-sí" sera evaluado y más adelante acomodado en la tabla de Expresiones
            If MiCaracter = "+" Or MiCaracter = "-" Or MiCaracter = "/" Or MiCaracter = "*" Or MiCaracter = "^" Then
                exp(i) = "Operadores"
                Console.WriteLine("<" & exp(i) & ",  " & MiCaracter & ">")

            ElseIf MiCaracter = "a" Or MiCaracter = "b" Or MiCaracter = "c" Or MiCaracter = "d" Or MiCaracter = "e" Or MiCaracter = "f" Or MiCaracter = "g" Or MiCaracter = "h" Or MiCaracter = "i" Or MiCaracter = "j" Or MiCaracter = "l" Or MiCaracter = "n" Or MiCaracter = "m" Or MiCaracter = "o" Or MiCaracter = "p" Or MiCaracter = "q" Or MiCaracter = "r" Or MiCaracter = "s" Or MiCaracter = "t" Or MiCaracter = "u" Or MiCaracter = "w" Or MiCaracter = "x" Or MiCaracter = "z" Then
                exp(i) = "Expre"
                Console.WriteLine("<" & exp(i) & ",  " & MiCaracter & ">")

            ElseIf MiCaracter = "1" Or MiCaracter = "2" Or MiCaracter = "3" Or MiCaracter = "4" Or MiCaracter = "5" Or MiCaracter = "6" Or MiCaracter = "7" Or MiCaracter = "8" Or MiCaracter = "9" Or MiCaracter = "10" Then
                exp(i) = "Numeros"
                Console.WriteLine("<" & exp(i) & ",  " & MiCaracter & ">")

            ElseIf exp(i) = "(" Then
                exp(i) = "Parentesis_Derecho"
                Console.WriteLine("<" & exp(i) & ",  " & MiCaracter & ">")

            ElseIf exp(i) = ")" Then
                exp(i) = "Parentesis_Izquierdo"
                Console.WriteLine("<" & exp(i) & ",  " & MiCaracter & ">")

            Else
                Console.WriteLine(MiCaracter & "      Tokens No Reconocido")
            End If
        Next
        'Fin del Reconocedor ~ Primer For I = 0



        Console.WriteLine("         ")
        Dim z As Integer
        j = 0
        z = 1
        Console.WriteLine("         ")
        Console.WriteLine("     Tabla de Símbolos;      ")

        For j = 0 To (TesLen - 1)
            MiCaracter = MiCadeda.Chars(j)

            If MiCaracter = "+" Or MiCaracter = "-" Or MiCaracter = "/" Or MiCaracter = "*" Or MiCaracter = "^" Then

            ElseIf MiCaracter = "a" Or MiCaracter = "b" Or MiCaracter = "c" Or MiCaracter = "d" Or MiCaracter = "e" Or MiCaracter = "f" Or MiCaracter = "g" Or MiCaracter = "h" Or MiCaracter = "i" Or MiCaracter = "j" Or MiCaracter = "l" Or MiCaracter = "n" Or MiCaracter = "m" Or MiCaracter = "o" Or MiCaracter = "p" Or MiCaracter = "q" Or MiCaracter = "r" Or MiCaracter = "s" Or MiCaracter = "t" Or MiCaracter = "u" Or MiCaracter = "w" Or MiCaracter = "x" Or MiCaracter = "z" Then
                Console.WriteLine("     <<ID, " & z & ">> = " & MiCaracter)
                'contador que se va sumando para sacar cada caracter en la tabala de simbolos con su Id
                z = z + 1

            ElseIf MiCaracter = "1" Or MiCaracter = "2" Or MiCaracter = "3" Or MiCaracter = "4" Or MiCaracter = "5" Or MiCaracter = "6" Or MiCaracter = "7" Or MiCaracter = "8" Or MiCaracter = "9" Or MiCaracter = "10" Then

            ElseIf exp(i) = "(" Then
                exp(i) = "Parentesis_Derecho"

            ElseIf exp(i) = ")" Then
                exp(i) = "Parentesis_Izquierdo"


            Else
                Console.WriteLine(MiCaracter & "      Tokens No Reconocido")
            End If
        Next
        'Fin de la Tabla de Símbología ~ 2do For J = 0


        'se reutiliza z donde tiene valor 1 para realice el análisis Léxico
        j = 0
        z = 1
        Console.WriteLine("     ")
        Console.WriteLine("     Analizador Léxico;    ")
        Console.WriteLine("     ")

        For j = 0 To (TesLen - 1)
            MiCaracter = MiCadeda.Chars(j)
            If MiCaracter = "+" Or MiCaracter = "-" Or MiCaracter = "/" Or MiCaracter = "*" Or MiCaracter = "^" Then
                'imprime el tipo de operador
                Console.WriteLine("<" & MiCaracter & ">")

            ElseIf MiCaracter = "a" Or MiCaracter = "b" Or MiCaracter = "c" Or MiCaracter = "d" Or MiCaracter = "e" Or MiCaracter = "f" Or MiCaracter = "g" Or MiCaracter = "h" Or MiCaracter = "i" Or MiCaracter = "j" Or MiCaracter = "l" Or MiCaracter = "n" Or MiCaracter = "m" Or MiCaracter = "o" Or MiCaracter = "p" Or MiCaracter = "q" Or MiCaracter = "r" Or MiCaracter = "s" Or MiCaracter = "t" Or MiCaracter = "u" Or MiCaracter = "w" Or MiCaracter = "x" Or MiCaracter = "z" Then
                Console.WriteLine("<ID " & z & " = " & MiCaracter & ">")
                'contador que se va sumando para sacar el numero en la tabala de simbolos con su Id; <ID> = un caracter
                z = z + 1

            ElseIf MiCaracter = "1" Or MiCaracter = "2" Or MiCaracter = "3" Or MiCaracter = "4" Or MiCaracter = "5" Or MiCaracter = "6" Or MiCaracter = "7" Or MiCaracter = "8" Or MiCaracter = "9" Or MiCaracter = "10" Then
                Console.WriteLine("<" & MiCaracter & ">")

            ElseIf exp(i) = "(" Then
                exp(i) = "Parentesis_Derecho"
                Console.WriteLine(MiCaracter)
            ElseIf exp(i) = ")" Then
                exp(i) = "Parentesis_Izquierdo"
                Console.WriteLine(MiCaracter)

            Else
                Console.WriteLine(MiCaracter & "       Tokens No Reconocido")
            End If
        Next
        'Fin del Análisis Lexico



        Console.WriteLine("     ")

        Dim g As Integer
        Dim h As Integer
        Dim e As Integer

        i = 0
        h = 1
        e = 0
        g = 0
        Console.WriteLine("     ")
        Console.WriteLine("Analizador Sintáctico; ")
        'console.wrinte("::: Tokens:::")

        For i = 0 To (TesLen - 1)

            If i = 0 Then
                If MiCadeda.Chars(i) = "(" Then
                    'El contador sirve para verificar que los Datos ingresados si es que le falta algun parentesis
                    g = g + 1
                Else
                    If exp(i) = "Expre" Or exp(i) = "Numeros" Then
                        If MiCadeda.Chars(i) = "-" Then

                        Else
                            If MiCadeda.Chars(i) = "+" Or MiCadeda.Chars(i) = "*" Or MiCadeda.Chars(i) = "/" Or MiCadeda.Chars(i) = "=" Then

                                Console.WriteLine("     ERROR EN EL CARACTER " & i & ": ")
                                Console.WriteLine("     No se Puede Escribir Un Opererador " & MiCadeda.Chars(i) & "Al inicio de la Expresión")
                                h = 0
                            End If
                        End If
                    End If
                End If

            Else
                'Cada una de la expresiones pasaran a un Case, donde la Expresion será analizada
                'y asi para cada NUMERO, EXPRESIÓN Y OPERADOR
                Select Case exp(i)
                    Case "Expre"

                        'esta decisión si el primer o anterior al valor introducido es un parentesis 
                        If MiCadeda.Chars(i - 1) = "(" Then

                        Else
                            If exp(i - 1) = "Operadores" Then
                            Else
                                Console.WriteLine(" ERROR en Caracter " & i & " : ")
                                Console.WriteLine("No se puede poner una Expresión despues de una Expresión")
                                h = 0
                            End If
                        End If

                    Case "Numeros"

                        'esta decisión 
                        If MiCadeda.Chars(i - 1) = "(" Then

                        Else
                            If exp(i - 1) = "Operadores" Then
                            Else
                                Console.WriteLine(" ERROR en Caracter " & i & ": ")
                                Console.WriteLine("No se puede poner una Expresión despues de una Expresión")
                                h = 0
                            End If
                        End If

                    Case "Operadores"

                        'esta decisión 
                        If MiCadeda.Chars(i - 1) = "Parentesis_Derecho" Or MiCadeda.Chars(i - 1) = "=" Then

                            If MiCadeda.Chars(i - 1) = "-" Then
                            Else
                                Console.WriteLine(" ERROR en Caracter " & i & ": ")
                                Console.WriteLine("No se puede escribir el operador " & MiCadeda.Chars(i) & "despues de un " & MiCadeda.Chars(1 - 1))
                                h = 0

                            End If
                        End If


                    Case "Parentesis_Derecho"

                        'este contador permite 
                        e = e + 1

                        If MiCadeda.Chars(i - 1) = "(" Or MiCadeda.Chars(i - 1) = "=" Then

                        Else
                            If exp(i - 1) = "Operadores" Then

                            Else
                                Console.WriteLine(" ERROR en Caracter " & i & ": ")
                                Console.WriteLine(" No se puede escribir parentesis CERRADO despues de uno ABIRETO")
                                h = 0
                            End If

                        End If
                    Case "Parentesis_Izquierdo"

                        'esta decisión 
                        If exp(i - 1) = "Expre" Or exp(i - 1) = "Numeros" Then

                        Else
                            If exp(i - 1) = "Parentesis_Izquierdo" Then

                            Else
                                If exp(1 - 1) = "Operadores" Then
                                    Console.WriteLine(" ERROR en Caracter " & i & ": ")
                                    Console.WriteLine("No se puede escribir un Parentesis ABIRTO luego de un Operador")
                                Else
                                    Console.WriteLine(" ERROR en Caracter " & i & ": ")
                                    Console.WriteLine("No se puede escribir un Parentesis sin NINGUNA EXPRESIÓN")
                                End If
                                h = 0
                            End If
                        End If
                End Select
                'Fin del Select Case

            End If
            'Fin de Todo el Análizador Sintático "For"

        Next
        'Fin del for



        'Validación de ERRORES
        If h = 1 Then
            Console.WriteLine(" No Muestra ERRORES")
        End If
        Console.WriteLine("     ")
        Console.WriteLine("     Resultados del Analizador Sintático;")

        'se conparan los resultados
        If h = 1 Then
            'e muestra si es un parentesis Cerrado si no manda mensaje de error
            If e = g Then
                Console.WriteLine("     La Espresión esta bien Escrita !!!")
            Else
                Console.WriteLine("     Le falta un parentesis...")
            End If
        Else
            Console.WriteLine("     ERROR DE LA EXPRESIÓN !!!")
        End If

        Console.WriteLine("vuelve a Ejecutar el código si deseas evaluar otra Expresión ^_^")
        'MUESTRA EN PANTALLA todo lo leido
        Dim expresion As String = Console.ReadLine

    End Sub

End Module