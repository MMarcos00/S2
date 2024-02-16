// Conversión de tipos

int numeroEntero = 10;
decimal numeroDecimal = Convert.ToDecimal(numeroEntero);

Console.WriteLine("Número entero: " + numeroEntero);
Console.WriteLine("Número decimal: " + numeroDecimal);

decimal numeroDecimal2 = 10.5m;
float numeroFlotante = Convert.ToSingle(numeroDecimal2);

Console.WriteLine("Número decimal: " + numeroDecimal2);
Console.WriteLine("Número flotante: " + numeroFlotante);

float numeroFlotante2 = 10.5f;
int numeroEntero2 = Convert.ToInt32(numeroFlotante2);

Console.WriteLine("Número flotante: " + numeroFlotante2);
Console.WriteLine("Número entero: " + numeroEntero2);

char caracter = 'a';
int numeroEntero3 = Convert.ToInt32(caracter);

Console.WriteLine("Caracter: " + caracter);
Console.WriteLine("Número entero (código ASCII): " + numeroEntero3);

int numeroEntero4 = 97;
char caracter2 = Convert.ToChar(numeroEntero4);

Console.WriteLine("Número entero: " + numeroEntero4);
Console.WriteLine("Caracter: " + caracter2);

// Operaciones con tipos de datos

int num1 = 10;
int num2 = 20;
int suma = num1 + num2;

Console.WriteLine("Suma: " + suma);

decimal num3 = 10.5m;
decimal num4 = 5.25m;
decimal resta = num3 - num4;

Console.WriteLine("Resta: " + resta);

float num5 = 10.5f;
float num6 = 2.5f;
float multiplicacion = num5 * num6;

Console.WriteLine("Multiplicación: " + multiplicacion);

int num7 = 10;
int num8 = 2;
int division = num7 / num8;

Console.WriteLine("División: " + division);

int num9 = 10;
int num10 = 3;
int modulo = num9 % num10;

Console.WriteLine("Módulo: " + modulo);

// Uso de char y string

string texto = "Marcos";
string textoMayusculas = texto.ToUpper();

Console.WriteLine("Texto en mayúsculas: " + textoMayusculas);

string texto2 = "Marcos";
string textoMinusculas = texto2.ToLower();

Console.WriteLine("Texto en minúsculas: " + textoMinusculas);

string texto3 = "Marcos";
string textoReves = "";

for (int i = texto3.Length - 1; i >= 0; i--)
{
    textoReves += texto3[i];
}

Console.WriteLine("Texto al revés: " + textoReves);

string texto4 = "Marcos, cómo estás?";
string palabra = "Marcos";

if (texto4.Contains(palabra))
{
    Console.WriteLine("La palabra \"" + palabra + "\" se encuentra en la cadena.");
}
else
{
    Console.WriteLine("La palabra \"" + palabra + "\" no se encuentra en la cadena.");
}

string texto5 = "Marcos";
int numeroVocales = 0;

for (int i = 0; i < texto5.Length; i++)
{
    if ("aeiou".Contains(texto5[i]))
    {
        numeroVocales++;
    }
}

Console.WriteLine("Número de vocales: " + numeroVocales);

// Uso de tipos de datos numéricos

// Cálculo del área de un triángulo
double baseTriangulo = 5.0;
double alturaTriangulo = 4.0;
double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

Console.WriteLine("Área del triángulo: " + areaTriangulo);

// Cálculo del volumen de una esfera
double radioEsfera = 3.0;
double volumenEsfera = (4.0 / 3.0) * Math.PI * Math.Pow(radioEsfera, 3);

Console.WriteLine("Volumen de la esfera: " + volumenEsfera);

// Cálculo de la distancia entre dos puntos
double x1 = 1.0;
double y1 = 2.0;
double x2 = 4.0;
double y2 = 6.0;

// Fórmula: Fahrenheit = (Celsius * 9/5) + 32

double temperaturaCelsius = 20.0;
double temperaturaFahrenheit = (temperaturaCelsius * 9.0 / 5.0) + 32.0;

Console.WriteLine("Temperatura en Fahrenheit: " + temperaturaFahrenheit);

// Fórmula: Celsius = (Fahrenheit - 32) * 5/9

double temperaturaFahrenheit2 = 68.0;
double temperaturaCelsius2 = (temperaturaFahrenheit2 - 32.0) * 5.0 / 9.0;

Console.WriteLine("Temperatura en Celsius: " + temperaturaCelsius2);





