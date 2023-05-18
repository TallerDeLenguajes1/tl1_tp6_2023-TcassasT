﻿Random random = new Random();

Console.Write("Ingrese un numero A: ");
string? input = Console.ReadLine();
int inputParsesado;

if ((input != null) && (int.TryParse(input, out inputParsesado))) {
  int numeroAleatorio = random.Next(100) + 1;

  Console.WriteLine("Basado en el numero aleatorio B: " + numeroAleatorio);

  if (inputParsesado > 0) {
    int auxiliar = inputParsesado;

    inputParsesado = numeroAleatorio;
    numeroAleatorio = auxiliar;

    Console.WriteLine("Resultado invertido A: " + inputParsesado + " B: " + numeroAleatorio);
  } else {
    Console.WriteLine("Resultado A: " + inputParsesado + " B: " + numeroAleatorio);
  }
} else {
  Console.WriteLine("El valor ingresado o es nulo o no es un numero.");
}
