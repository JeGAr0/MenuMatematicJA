
        case '2':
    Calcular(Mcd);
    break;
case '3':
    Calcular(Mcm);
    break;
case '4':
    Calcular(Factorial);
    break;
case '5':
    Calcular(Combinatori);
    break;
case '6':
    Calcular(DivisorMajor);
    break;
case '7':
    Calcular(EsPrimer);
    break;
case '8':
    Calcular(NnumerosPrimers);
    break;
case 'q':
    Console.WriteLine("\nSortint");
    break;





    // [8] CALCULAR N NUMEROS PRIMERS
    static int NnumerosPrimers(int numDonat, int QuantsNums)
    {
        if (QuantsNums <= 0)
        {
            return;
        }

        int primersTrobats = 0;

        while (primersTrobats <= QuantsNums)
        {
            if (EsPrimer(numDonat))
            {
                primersTrobats++;
            }

            numDonat++;
        }

        if (primersTrobats <= 0)
        {
            return;
        }
    }