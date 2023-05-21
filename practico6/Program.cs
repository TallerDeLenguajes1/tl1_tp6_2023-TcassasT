int numeroParaAplicarPropiedades;
Random random = new Random();

Console.Write("Ingrese un numero para aplicar propiedades: ");
if (int.TryParse(Console.ReadLine(), out numeroParaAplicarPropiedades)) {
  Console.WriteLine(" |" + numeroParaAplicarPropiedades + "| = " + Math.Abs(numeroParaAplicarPropiedades));
  Console.WriteLine(" " + numeroParaAplicarPropiedades + "² = " + Math.Pow(numeroParaAplicarPropiedades, 2));
  Console.WriteLine(" ²√" + numeroParaAplicarPropiedades + " = " + Math.Sqrt(numeroParaAplicarPropiedades));
  Console.WriteLine(" SEN(" + numeroParaAplicarPropiedades + ") = " + Math.Sin(numeroParaAplicarPropiedades));
  Console.WriteLine(" COS(" + numeroParaAplicarPropiedades + ") = " + Math.Cos(numeroParaAplicarPropiedades));

  float numeroDecimal = ((float) random.NextDouble() * (float) (10));
  Console.WriteLine(" Parte entera de " + numeroDecimal + " = " + (Math.Truncate(numeroDecimal)));
} else {
  Console.WriteLine(" El numero ingresado no es valido.");
}

bool numerosACompararValidos = true;
int numeroACompararA, numeroACompararB;

Console.WriteLine("");
Console.WriteLine("Ingrese un numero A para comparar: ");
if (!int.TryParse(Console.ReadLine(), out numeroACompararA)) {
  numerosACompararValidos = false;
}

Console.WriteLine("Ingrese un numero B para comparar: ");
if (!int.TryParse(Console.ReadLine(), out numeroACompararB)) {
  numerosACompararValidos = false;
}

if (numerosACompararValidos) {
  Console.WriteLine("Dados los numeros ingresados, se sabe que:");
  if (numeroACompararA == numeroACompararB) {
    Console.WriteLine(" Ambos numeros son iguales: " + numeroACompararA + " = " + numeroACompararB);
  } else {
    Console.WriteLine(" Maximo: " + (numeroACompararA > numeroACompararB ? numeroACompararA : numeroACompararB));
    Console.WriteLine(" Minimo: " + (numeroACompararA < numeroACompararB ? numeroACompararA : numeroACompararB));
  }
} else {
  Console.WriteLine("Numeros a comparar invalidos, por favor ingrese numeros.");
}

int operacion;

Console.WriteLine("¿Que operación desea realizar?");

do {
  Console.WriteLine(" 1- Sumar");
  Console.WriteLine(" 2- Restar");
  Console.WriteLine(" 3- Multiplicar");
  Console.WriteLine(" 4- Dividir");
  Console.WriteLine(" 0- Salir");

  if (int.TryParse(Console.ReadLine(), out operacion)) {
    if (operacion == 0) continue;
    if (operacion >= 1 && operacion <= 4) {
      int inputParseadoA, inputParseadoB;
      bool inputsValidos = true;

      Console.Write("Ingrese el primer numero: ");
      if (!(int.TryParse(Console.ReadLine(), out inputParseadoA))) {
        inputsValidos = false;        
      }

      Console.Write("Ingrese el segundo numero: ");      
      if (!(int.TryParse(Console.ReadLine(), out inputParseadoB))) {
        inputsValidos = false;      
      }

      if (inputsValidos) {
        switch(operacion) {
          case 1:
            Console.WriteLine(inputParseadoA + " + " + inputParseadoB + " = " + (inputParseadoA + inputParseadoB));
            break;
          case 2:
            Console.WriteLine(inputParseadoA + " - " + inputParseadoB + " = " + (inputParseadoA - inputParseadoB));
            break;
          case 3:
            Console.WriteLine(inputParseadoA + " * " + inputParseadoB + " = " + (inputParseadoA * inputParseadoB));
            break;
          case 4:
            Console.WriteLine(inputParseadoA + " / " + inputParseadoB + " = " + (inputParseadoA / inputParseadoB));
            break;
        }
      } else {
        Console.WriteLine("Inputs invalidos, por favor ingrese numeros.");
      }
    } else {
      Console.WriteLine("Por favor utilice numeros para elegir la operación.");
    }
  }

  // Cambiar el titulo de la lista
  Console.WriteLine("");
  Console.WriteLine("¿Deseas realizar otra operación?");
} while (operacion != 0);

Console.WriteLine("A continuación, por favor ingrese una frase");
string? fraseAEvaluar = Console.ReadLine();

if (fraseAEvaluar != null) {
    Console.WriteLine("");
  Console.WriteLine("Longitud de la frase: " + fraseAEvaluar.Length);

  Console.WriteLine("");
  Console.WriteLine("Ingrese otra frase:");
  string? segundaFrase = Console.ReadLine();

  Console.WriteLine("");
  if (segundaFrase != null) {
    Console.WriteLine("Frase concatenada: " + fraseAEvaluar + segundaFrase);
  } else {
    Console.WriteLine("Frase invalida.");
  }

  Console.WriteLine("");
  Console.Write("Subcadena aleatoria de la primera frase: ");
  int primerIndice = random.Next(0, fraseAEvaluar.Length / 2);
  int segundoIndice = random.Next(fraseAEvaluar.Length / 2, fraseAEvaluar.Length);
  Console.WriteLine(fraseAEvaluar.Substring(primerIndice, segundoIndice - primerIndice));

  Console.WriteLine("");
  Console.WriteLine("Mostrando \"" + fraseAEvaluar + "\" caracter por caracter:");
  foreach (var caracter in fraseAEvaluar) {
    Console.WriteLine(caracter);
  }

  Console.WriteLine("");
  Console.Write("Ingrese una palabra a buscar en la primera frase ingresada: ");
  string? palabraABuscar = Console.ReadLine();

  Console.WriteLine("");
  if (palabraABuscar != null) {
    if (fraseAEvaluar.Contains(palabraABuscar)) {
      Console.WriteLine("La palabra \"" + palabraABuscar + "\" SI se encuentra en la primera frase.");
    } else {
      Console.WriteLine("La palabra \"" + palabraABuscar + "\" NO se encuentra en la primera frase.");
    }
  } else {
    Console.WriteLine("Palabra invalida.");
  }

  Console.WriteLine("");
  Console.WriteLine("Ingrese una frase separando caracteres con el caracter '|'");
  string? fraseSeparadaPorCaracter = Console.ReadLine();

  if (fraseSeparadaPorCaracter != null && fraseSeparadaPorCaracter.Contains('|')) {
    Console.WriteLine("Resultado de aplicar metodo split a la frase ingresada:");
    string[] fraseArray = fraseSeparadaPorCaracter.Split("|");

    foreach (var fraseItem in fraseArray) {
      Console.WriteLine(fraseItem);
    }
  } else {
    Console.WriteLine("Frase invalida.");
  }

  Console.WriteLine("");
  Console.WriteLine("Ingrese una ecuación en forma de string para resolver:");
  string? ecuacion = Console.ReadLine();

  if (ecuacion != null) {
    List<string> ecuacionEnTerminos = new List<string>();
    string[] simbolosAritmeticos = {"+", "-", "/", "*"};
    string ecuacionTermino = "";
    foreach (var ecuacionCaracter in ecuacion) {
      string ecuacionCaracterString = ecuacionCaracter.ToString();
      if (ecuacionCaracter.ToString() != " ") {
        if (simbolosAritmeticos.Contains(ecuacionCaracterString) && ecuacionTermino != "") {
          ecuacionEnTerminos.Add(ecuacionTermino);
          ecuacionEnTerminos.Add(ecuacionCaracterString);
          ecuacionTermino = "";
        }
        
        if (!simbolosAritmeticos.Contains(ecuacionCaracterString)) {
          ecuacionTermino += ecuacionCaracterString;
        }
      }
    }

    if (ecuacionTermino != "") {
      ecuacionEnTerminos.Add(ecuacionTermino);
    }

    if (ecuacionEnTerminos.Count > 0) {
      int acumuladorResultado = 0;
      string ultimaOperacion = "+";

      for (int i = 0; i < ecuacionEnTerminos.Count; i++) {
        if (simbolosAritmeticos.Contains(ecuacionEnTerminos.ElementAt(i))) {
          ultimaOperacion = ecuacionEnTerminos.ElementAt(i);
          continue;
        }

        int terminoParseado;
        if (int.TryParse(ecuacionEnTerminos.ElementAt(i), out terminoParseado)) {
          switch (ultimaOperacion) {
            case "+":
              acumuladorResultado += terminoParseado;
              break;
            case "-":
              acumuladorResultado -= terminoParseado;
              break;
            case "/":
              acumuladorResultado /= terminoParseado;
              break;
            case "*":
              acumuladorResultado *= terminoParseado;
              break;
            default:
              acumuladorResultado += 0;
              break;
          }
        }
      }
      Console.WriteLine("Resultado de ecuacion: " + acumuladorResultado);
    }
  } else {
    Console.WriteLine("Ecuacion invalida.");
  }
} else {
  Console.WriteLine("Frase invalida.");
}