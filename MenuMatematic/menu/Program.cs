int num1 = 0, num2 = 0;
char seleccionarOpcio;
Console.CursorVisible = false;
Console.ForegroundColor = ConsoleColor.Red;

do
{
    Menu();
    seleccionarOpcio = char.ToLower(Console.ReadKey().KeyChar);

    switch (seleccionarOpcio)
    {
        case '1':
            EsborraConsola();
            Console.Write("Introdueix el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix el segon numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numero mes gran: " + Maxim(num1, num2));
            CompteEnrera();
            break;

        case '2':
            EsborraConsola();
            Console.Write("Introdueix el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix el segon numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Maxim comu divisor: " + Mcd(num1, num2));
            CompteEnrera();
            break;

        case '3':
            EsborraConsola();
            Console.Write("Introdueix el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix el segon numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("minim comu multiple: " + Mcm(num1, num2));
            CompteEnrera();
            break;

        case '4':
            EsborraConsola();
            Console.Write("Introdueix el numero per fer el seu factorial: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El resultat del seu factorial es: " + Factorial(num1));
            CompteEnrera();
            break;

        case '5':
            EsborraConsola();
            Console.Write("Introdueix el valor de n: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix el valor de m: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("n! / m!(n-m)! = " + Combinatori(num1, num2));
                CompteEnrera();
            }
            else
            {
                Console.WriteLine("El valor de [ m ] no pot ser major al de [ n ]");
                CompteEnrera();
                goto case '5';
            }
            break;

        case '6':
            EsborraConsola();
            Console.Write("Introdueix el numero per trobar els seus divisors: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (DivisorMajor(num1) != -1)
            {
                Console.WriteLine("El divisor major es: " + DivisorMajor(num1));
                CompteEnrera();
            }
            else
            {
                Console.WriteLine("Es un numero primer");
                CompteEnrera();
            }
            break;

        case '7':
            EsborraConsola();
            Console.Write("Introdueix el numero per saber si es primer: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (EsPrimer(num1) == true)
            {
                Console.WriteLine("ES PRIMER 1, " + num1);
                CompteEnrera();
            }
            else
            {
                Console.WriteLine("NO ES PRIMER");
                CompteEnrera();
            }
            break;

        case '8':
            EsborraConsola();
            Console.Write("Introdueix el numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix els primers que es volen trobar: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (NnumerosPrimers(num1, num2) == "ERROR")
            {
                Console.WriteLine("No s'han trobat numeros primers");
                CompteEnrera();
            }
            else
            {
                Console.WriteLine("Resultat: " + NnumerosPrimers(num1, num2));
                CompteEnrera();
            }
            break;

    }
    EsborraConsola();
} while (seleccionarOpcio != '9');

// MENU DE LES OPCIONS
static void Menu()
{

    Console.Write(Centrar(DateTime.Now.ToString("ddd dd MMM")));

    Console.WriteLine(Centrar("                                           "));
    Console.WriteLine(Centrar("                                           "));
    Console.WriteLine(Centrar("                ▄▀▄     ▄▀▄                "));
    Console.WriteLine(Centrar("               ▄█░░▀▀▀▀▀░░█▄               "));
    Console.WriteLine(Centrar("           ▄▄  █░░░░░░░░░░░█  ▄▄           "));
    Console.WriteLine(Centrar("          █▄▄█ █░░▀░░┬░░▀░░█ █▄▄█          "));


    Console.WriteLine(Centrar(" ---------- Selecciona una opcio --------- "));
    Console.WriteLine(Centrar("|                                         |"));
    Console.WriteLine(Centrar("|        1. Calcular Maxim                |"));
    Console.WriteLine(Centrar("|        2. Calcular MCD                  |"));
    Console.WriteLine(Centrar("|        3. Calcular MCM                  |"));
    Console.WriteLine(Centrar("|        4. Calcular Factorial            |"));
    Console.WriteLine(Centrar("|        5. Calcular Combinatori          |"));
    Console.WriteLine(Centrar("|        6. Mostrar Divisor Major         |"));
    Console.WriteLine(Centrar("|        7. Verificar si es Primer        |"));
    Console.WriteLine(Centrar("|        8. N Numeros Primers             |"));
    Console.WriteLine(Centrar("|                                         |"));
    Console.WriteLine(Centrar("|        9. SORTIR                        |"));
    Console.WriteLine(Centrar("|-----------------------------------------|"));

}



// CENTRAR
static string Centrar(string valor)
{
    int longitud = (valor.Length + 80) / 2;
    string cadenaAmbEspais = valor.PadLeft(longitud);
    return cadenaAmbEspais;
}

// TEMPS ESPERA
static void CompteEnrera()
{
    int num = 5;
    while (num > 0)
    {
        Console.Write("\r");
        Console.Write(num);
        Thread.Sleep(1000);

        num--;
    }
}

static void EsborraConsola()
{
    Console.Clear();
}

// [1] CALCULAR MAXIM (donat 2 numeros quin es el major)
static double Maxim(double a, double b)
{
    return Math.Max(a, b);
}

// [2] CALCULAR EL MAXIM COMU DIVISOR
static int Mcd(int num1, int num2)
{
    while (num2 != 0)
    {
        int aux = num2;
        num2 = num1 % num2;
        num1 = aux;
    }
    return num1;
}

// [3] CALCULAR EL MINIM COMU MULTIPLE
static int Mcm(int num1, int num2)
{
    int mcd = Mcd(num1, num2);
    int mcm = Math.Abs(num1 * num2) / mcd;
    return mcm;
}

// [4] CALCULAR EL NUMERO FACTORIAL
static double Factorial(double num1)
{
    double resultat = 1;

    for (int i = 1; i <= num1; i++)
    {
        resultat *= i;
    }

    return resultat;
}

// [5] CALCULAR EL COMBINATORI
static double Combinatori(int n, int m)
{
    double resultat = Factorial(n) / (Factorial(m) * Factorial(n - m));

    return resultat;
}

// [6] CALCULAR EL DIVISOR MAJOR (de un numero quin es el seu divisor major)
static int DivisorMajor(int num1)
{
    if (EsPrimer(num1))
    {
        return -1; // Indica amb un if que el numero es primer
    }

    for (int i = num1 / 2; i >= 2; i--)
    {
        if (num1 % i == 0)
        {
            return i;
        }
    }

    return -1;
}

// [7] CALCULAR SI ES NUMERO PRIMER
static bool EsPrimer(int num1)
{
    bool NoEs = false;
    if (num1 < 2)
    {
        return NoEs;
    }

    for (int i = 2; i <= Math.Sqrt(num1); i++)
    {
        if (num1 % i == 0)
        {
            return NoEs;
        }
    }

    return true;
}

// [8] CALCULAR N NUMEROS PRIMERS 
static string NnumerosPrimers(int numDonat, int QuantsNums)
{
    string valors = "";
    if (QuantsNums <= 0)
    {
        return "ERROR";
    }

    int primersTrobats = 0;

    while (primersTrobats < QuantsNums)
    {
        if (EsPrimer(numDonat))
        {
            primersTrobats++;
            valors += Convert.ToString(numDonat + " ");
        }

        numDonat++;
    }
    return valors;

    if (primersTrobats <= 0)
    {
        return "ERROR";
    }
}