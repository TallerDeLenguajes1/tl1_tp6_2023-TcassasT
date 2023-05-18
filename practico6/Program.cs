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
