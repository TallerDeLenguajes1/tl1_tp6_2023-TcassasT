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

