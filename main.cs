using System;

class MainClass {
  public static void Main (string[] args) {
    //Declarando las variables
    int entero = 10;
    bool booleano = true;
    string caracter ="Caracter";
    double doble = 23.56;
    char  letra = 'a';
    float flotante = 8.7F;

    Console.WriteLine ("Ejemplo de entero (int): "+ entero);
    Console.WriteLine("Ejemplo de booleano (bool): " + booleano);
    Console.WriteLine("Ejemplo de caracteres (string): "+ caracter);
    Console.WriteLine("Ejemplo de doble (double): "+ doble);
    Console.WriteLine("Ejemplo de letra (char:): "+ letra);
    Console.WriteLine("Ejemplo de flotante (float): "+ flotante);

    concatenacion();
  }

  public static void concatenacion(){
    convstr = string Parse(entero);
    Console.WriteLine(convstr);
  }

}