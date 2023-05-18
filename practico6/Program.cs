string? input;
int operacion;

Console.WriteLine("¿Que operación desea realizar?");

do {
  Console.WriteLine(" 1- Sumar");
  Console.WriteLine(" 2- Restar");
  Console.WriteLine(" 3- Multiplicar");
  Console.WriteLine(" 4- Dividir");
  Console.WriteLine(" 0- Salir");

  input = Console.ReadLine();

  if ((input != null) & (int.TryParse(input, out operacion))) {
    if (operacion == 0) continue;
    if (operacion >= 1 && operacion <= 4) {
      int inputParseadoA, inputParseadoB;
      bool inputsValidos = true;

      Console.Write("Ingrese el primer numero: ");
      input = Console.ReadLine();

      if (!(int.TryParse(input, out inputParseadoA))) {
        inputsValidos = false;        
      }

      Console.Write("Ingrese el segundo numero: ");
      input = Console.ReadLine();
      
      if (!(int.TryParse(input, out inputParseadoB))) {
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
