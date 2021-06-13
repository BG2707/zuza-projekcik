using System;

namespace figury
{
    class Program
    {
        static void Main(string[] args)
        {


            // zmienne
            bool powt = true;

            while (powt == true)
            {



                // Menu
                Console.WriteLine("Wybierz opcję");
                Console.WriteLine();
                Console.WriteLine("1.Figury dwuwymiorowe");
                Console.WriteLine("2.Figury trójwymiarowe");
                Console.WriteLine("3.Zakończ program");
                int a = 0;

                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Wybierz figurę:");
                        Console.WriteLine();
                        Console.WriteLine("1.Kwadrat");
                        Console.WriteLine("2.Prostokąt");
                        Console.WriteLine("3.Okrąg");
                        Console.WriteLine("4.Równoległobok");
                        Console.WriteLine("5.Trójkąt");
                        Console.WriteLine("6.Trapez");
                        Console.WriteLine("7.Romb");

                        // switch od wyboru figury
                        int b = 0;
                        b = int.Parse(Console.ReadLine());
                        switch (b)
                        {
                            case 1: //kwadrat
                                Console.Clear();
                                Console.WriteLine(" _");
                                Console.WriteLine("|_|");
                                Console.WriteLine();
                                Console.WriteLine("Kwadrat");

                                Console.WriteLine("Wybierz operację:");
                                Console.WriteLine("1.Pole figury");
                                Console.WriteLine("2.Obwód figury");
                                Console.WriteLine("3. Powrót");

                                byte c = 0;
                                c = byte.Parse(Console.ReadLine());

                                switch (c)
                                {
                                    case 1: //pole
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie pola kwadratu");

                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość boku:");
                                            int a1;
                                            a1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Twój bok to a = {0} ", a1);
                                            Console.WriteLine("Pole kwadratu to a*a");
                                            Console.WriteLine("Pole Twojego kwadratu to {0}", a1 * a1);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć pole innego kwadratu? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    case 2: //obwod
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie obwodu kwadratu");
                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość boku:");
                                            int a1;
                                            a1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Twój bok to a = {0} ", a1);
                                            Console.WriteLine("Obwód kwadratu to 4*a");
                                            Console.WriteLine("Obwód Twojego kwadratu to {0}", 4 * a1);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć obwód innego kwadratu? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    default:
                                        break;
                                }

                                break;

                            case 2: //PROSTOKAT
                                Console.Clear();
                                Console.WriteLine(" __");
                                Console.WriteLine("|__|");
                                Console.WriteLine();
                                Console.WriteLine("Prostokąt");

                                Console.WriteLine("Wybierz operację:");
                                Console.WriteLine("1.Pole figury");
                                Console.WriteLine("2.Obwód figury");
                                Console.WriteLine("3. Powrót");

                                byte d = 0;
                                d = byte.Parse(Console.ReadLine());
                                switch (d)
                                {
                                    case 1: //pole
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie pola prostokątu");

                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość boku 'a':");
                                            int a1;
                                            a1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość boku 'b':");
                                            int b1;
                                            b1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Twój bok to 'a' = {0} ", a1);
                                            Console.WriteLine("Twój bok to 'b' = {0} ", b1);
                                            Console.WriteLine("Pole prostokąta to a*b");
                                            Console.WriteLine("Pole Twojego prostokąta to {0}", a1 * b1);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć pole innego prostokąta t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    case 2: //obwod
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie obwodu prostokąta");
                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość boku 'a':");
                                            int a1;
                                            a1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość boku 'b':");
                                            int b1;
                                            b1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Twój bok to 'a' = {0} ", a1);
                                            Console.WriteLine("Twój bok to 'b' = {0} ", b1);
                                            Console.WriteLine("Obwód obwód prostokąta to 2a+2b");
                                            Console.WriteLine("Obwód Twojego prostokąta to {0}", 2 * a1 + 2 * b1);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć obwód innego prostokąta? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    default:
                                        break;
                                }
                                break;
                                    case 3: //Okrąg
                                        Console.Clear();
                                        Console.WriteLine("  *  ");
                                        Console.WriteLine(" * * ");
                                        Console.WriteLine("*   *");
                                        Console.WriteLine(" * * ");
                                        Console.WriteLine("  *  ");
                                        Console.WriteLine();
                                        Console.WriteLine("Okrąg");
                                        Console.WriteLine("pi = 3.14");


                                        Console.WriteLine("Wybierz operację:");
                                        Console.WriteLine("1.Pole figury");
                                        Console.WriteLine("2.Obwód figury");
                                        Console.WriteLine("3. Powrót");

                                        byte e = 0;
                                        e = byte.Parse(Console.ReadLine());
                                        switch (e)
                                        {
                                            case 1: //pole
                                                Console.Clear();
                                                Console.WriteLine("Obliczanie pola okręgu");

                                                while (powt == true)
                                                {
                                                    Console.WriteLine("Podaj długość promień 'r' :");
                                                    double a1;
                                                    a1 = double.Parse(Console.ReadLine());
                                                    Console.WriteLine("Promień Twojego okręgu to {0}", a1);
                                                    Console.WriteLine("Pole okręgu to pi*r*r");
                                                    Console.WriteLine("Pole Twojego okręgu to {0}", a1 * a1 * 3.14);
                                                    Console.WriteLine();
                                                    Console.WriteLine("Czy chcesz policzyć pole innego okręgu? t/n");
                                                    string t;
                                                    string tak = "t";

                                                    t = Console.ReadLine();

                                                    if (t == tak) powt = true;
                                                    else powt = false;

                                                }
                                                break;
                                            case 2: //obwod
                                                Console.Clear();
                                                Console.WriteLine("Obliczanie obwodu okręgu");
                                                while (powt == true)
                                                {
                                                    Console.WriteLine("Podaj długość promienia 'r':");
                                                    double a1;
                                                    a1 = double.Parse(Console.ReadLine());

                                                    Console.WriteLine("Twój promień to 'r' = {0} ", a1);

                                                    Console.WriteLine("Obwód okręgu to 2*pi*r");
                                                    Console.WriteLine("Obwód Twojego okręgu to {0}", 2 * 3.14 * a1);
                                                    Console.WriteLine();
                                                    Console.WriteLine("Czy chcesz policzyć obwód innego okręgu t/n");
                                                    string t;
                                                    string tak = "t";

                                                    t = Console.ReadLine();

                                                    if (t == tak) powt = true;
                                                    else powt = false;

                                                }
                                                break;
                                            default:
                                                break;

                                        }break;
                            case 4: //Równoległobok
                                Console.Clear();
                                Console.WriteLine(" __");
                                Console.WriteLine("/__/");
                                Console.WriteLine();
                                Console.WriteLine("Równoległobok");

                                Console.WriteLine("Wybierz operację:");
                                Console.WriteLine("1.Pole figury");
                                Console.WriteLine("2.Obwód figury");
                                Console.WriteLine("3. Powrót");

                                byte f = 0;
                                f = byte.Parse(Console.ReadLine());
                                switch (f)
                                {
                                    case 1: //pole
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie pola równoległoboku");

                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość podstawy 'a':");
                                            double a1;
                                            a1 = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj wysokość 'h': ");
                                            double b1;
                                            b1 = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Twója podstawa to 'a' = {0} ", a1);
                                            Console.WriteLine("Twója wysokość to 'h' = {0} ", b1);
                                            Console.WriteLine("Pole równoległoboku to a*h");
                                            Console.WriteLine("Pole Twojego równoległoboku to {0}", a1 * b1);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć pole innego równoległoboku? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    case 2: //obwod
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie obwodu równoległoboku");
                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość boku 'a':");
                                            int a1;
                                            a1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość boku 'b':");
                                            int b1;
                                            b1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Twój bok to 'a' = {0} ", a1);
                                            Console.WriteLine("Twój bok to 'b' = {0} ", b1);
                                            Console.WriteLine("Obwód równoległoboku to 2a+2b");
                                            Console.WriteLine("Obwód Twojego równoległoboku to {0}", 2 * a1 + 2 * b1);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć obwód innego równoległoboku? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    default:
                                        break;
                                }break;
                            case 5: //Trójkąt
                                Console.Clear();
                                Console.WriteLine(" /\\ ");
                                Console.WriteLine("/_\\ ");
                                Console.WriteLine("Trójkąt");

                                Console.WriteLine("Wybierz operację:");
                                Console.WriteLine("1.Pole figury");
                                Console.WriteLine("2.Obwód figury");
                                Console.WriteLine("3. Powrót");

                                byte g = 0;
                                g = byte.Parse(Console.ReadLine());
                                switch (g)
                                {
                                    case 1: //pole
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie pola trójkąta");

                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość podstawy 'a':");
                                            double a1;
                                            a1 = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj wysokość trójkąta 'h':");
                                            double b1;
                                            b1 = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Twoja podstawa to 'a' = {0} ", a1);
                                            Console.WriteLine("Twoja wysokość to 'h' = {0} ", b1);
                                            Console.WriteLine("Pole trójkąta to a*h/2");
                                            Console.WriteLine("Pole Twojego trójkąta to {0}", a1 * b1 / 2);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć pole innego trójkąta? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    case 2: //obwod
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie obwodu trójkąta");
                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość boku 'a':");
                                            int a1;
                                            a1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość boku 'b':");
                                            int b1;
                                            b1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość boku 'c':");
                                            int c1;
                                            c1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Twój bok to 'a' = {0} ", a1);
                                            Console.WriteLine("Twój bok to 'b' = {0} ", b1);
                                            Console.WriteLine("Twój bok to 'c' = {0} ", b1);
                                            Console.WriteLine("Obwód trójkąta to a+b+c");
                                            Console.WriteLine("Obwód Twojego trójkąta to {0}", a1+b1+c1);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć obwód innego trójkąta? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    default:
                                        break;
                                }break;
                            case 6: //Trapez
                                Console.Clear();
                                Console.WriteLine(" __");
                                Console.WriteLine("/__|");
                                Console.WriteLine();
                                Console.WriteLine("Trapez");

                                Console.WriteLine("Wybierz operację:");
                                Console.WriteLine("1.Pole figury");
                                Console.WriteLine("2.Obwód figury");
                                Console.WriteLine("3. Powrót");

                                byte h = 0;
                                h = byte.Parse(Console.ReadLine());
                                switch (h)
                                {
                                    case 1: //pole
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie pola trapezu");

                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość podstawy 'a':");
                                            double a1;
                                            a1 = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość podstawy 'b':");
                                            double b1;
                                            b1 = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj wysokość 'h':");
                                            double c1;
                                            c1 = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Twoja podstawa to 'a' = {0} ", a1);
                                            Console.WriteLine("Twoja podstawa to 'b' = {0} ", b1);
                                            Console.WriteLine("Twoja wysokość to 'h' = {0}",c1);
                                            Console.WriteLine("Pole trapezu to (a+b)/2*h");
                                            Console.WriteLine("Pole Twojego trapezu to {0}", (a1+b1)/2*c1);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć pole innego trapezu? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    case 2: //obwod
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie obwodu trapezu");
                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość podstawy 'a':");
                                            int a1;
                                            a1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość podstawy 'b':");
                                            int b1;
                                            b1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość boku 'c':");
                                            int c1;
                                            c1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość boku 'd':");
                                            int d1;
                                            d1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Twoja podstawa to 'a' = {0} ", a1);
                                            Console.WriteLine("Twoja podstawa to 'b' = {0} ", b1);
                                            Console.WriteLine("Twój bok to 'c' = {0}", c1);
                                            Console.WriteLine("Twój bok to 'd' = {0}", d1);
                                            Console.WriteLine("Obwód trapezu to a+b+c+d");
                                            Console.WriteLine("Obwód Twojego trapezu to {0}", a1+b1+c1+d1);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć obwód innego trapezu? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    default:
                                        break;
                                }break;
                            case 7: //Romb
                                Console.Clear();
                                Console.WriteLine("");
                                Console.WriteLine("");
                                Console.WriteLine();
                                Console.WriteLine("Romb");

                                Console.WriteLine("Wybierz operację:");
                                Console.WriteLine("1.Pole figury");
                                Console.WriteLine("2.Obwód figury");
                                Console.WriteLine("3. Powrót");

                                byte i = 0;
                                i = byte.Parse(Console.ReadLine());
                                switch (i)
                                {
                                    case 1: //pole
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie pola rombu");

                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość przekątnej 'd':");
                                            double a1;
                                            a1 = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Podaj długość przekątnej 'f':");
                                            double b1;
                                            b1 = double.Parse(Console.ReadLine());
                                            Console.WriteLine("Twoja przekątna to 'd' = {0} ", a1);
                                            Console.WriteLine("Twoja przekątna to 'f' = {0} ", b1);
                                            Console.WriteLine("Pole rombu to d*f/2");
                                            Console.WriteLine("Pole Twojego rombu to {0}", a1 * b1/2);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć pole innego rombu t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    case 2: //obwod
                                        Console.Clear();
                                        Console.WriteLine("Obliczanie obwodu rombu");
                                        while (powt == true)
                                        {
                                            Console.WriteLine("Podaj długość boku 'a':");
                                            int a1;
                                            a1 = int.Parse(Console.ReadLine());
                                            
                                            
                                            
                                            Console.WriteLine("Twój bok to 'a' = {0} ", a1);
                                            
                                            Console.WriteLine("Obwód rombu to 4a");
                                            Console.WriteLine("Obwód Twojego rombu to {0}", a1*4);
                                            Console.WriteLine();
                                            Console.WriteLine("Czy chcesz policzyć obwód innego rombu? t/n");
                                            string t;
                                            string tak = "t";

                                            t = Console.ReadLine();

                                            if (t == tak) powt = true;
                                            else powt = false;

                                        }
                                        break;
                                    default:
                                        break;
                                }break;


                        }
                                break;
                    default:break;

                    case 2:
                        Console.WriteLine("Figury trójwymiarowe");
                        int opcja;
                        Console.WriteLine("Wybierz figurę:");
                        Console.WriteLine("1.Sześcian");
                        Console.WriteLine("2.Kula");
                        Console.WriteLine("3.Stożek");
                        Console.WriteLine("4.Wałek");
                        Console.WriteLine("5.Ostrosłup");
                        opcja = int.Parse(Console.ReadLine());

                        if (opcja == 1)
                        {
                            Console.WriteLine("Sześcian");
                            Console.WriteLine("Wybierz opcję:");
                            Console.WriteLine("1.Pole");
                            Console.WriteLine("2.Objętość");
                            Console.WriteLine("3. Wyjdź");
                            int opcja1;
                            opcja1 = int.Parse(Console.ReadLine());
                            if (opcja1 == 1)
                            {
                                Console.WriteLine("Wzór na pole sześcianu to 6*a*a");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj długość krawędzi a:");
                                    int k;
                                    k = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Krawędź Twojego szescianu ma dlugosc {0}", k);
                                    Console.WriteLine("Pole powierzchni Twojego szescianu to {0}", k * k * 6);

                                    Console.WriteLine("Czy chcesz policzyć pole innego szescianu? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }
                            if (opcja1 == 2)
                            {
                                Console.WriteLine("Wzór na objętość sześcianu to a*a*a");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj długość krawędzi a:");
                                    int k;
                                    k = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Krawędź Twojego szescianu ma dlugosc {0}", k);
                                    Console.WriteLine("Pole powierzchni Twojego szescianu to {0}", k * k * k);

                                    Console.WriteLine("Czy chcesz policzyć objętość innego szescianu? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }
                            else break;
                        }
                        if (opcja == 2)
                        {
                            Console.WriteLine("Kula");
                            Console.WriteLine("Wybierz opcję:");
                            Console.WriteLine("1.Pole");
                            Console.WriteLine("2.Objętość");
                            Console.WriteLine("3. Wyjdź");
                            int opcja1;
                            opcja1 = int.Parse(Console.ReadLine());
                            if (opcja1 == 1)
                            {
                                Console.WriteLine("Pi = 3,14");
                                Console.WriteLine("Wzór na pole kuli to 4*3,14*r*r");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj długość promienia r:");
                                    double k;
                                    k = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Promien Twojej kuli ma dlugosc {0}", k);
                                    Console.WriteLine("Pole powierzchni Twojej kuli to {0}", k*k*3.14*4);

                                    Console.WriteLine("Czy chcesz policzyć pole innej kuli? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }
                            if (opcja1 == 2)
                            {
                                Console.WriteLine("Wzór na objętość kuli to r*r*r*3,14*4/3");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj długość promienia r:");
                                    double k;
                                    k = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Krawędź Twojego szescianu ma dlugosc {0}", k);
                                    Console.WriteLine("objętość Twojej kuli to to {0}", k * k * k*3.14*4/3);

                                    Console.WriteLine("Czy chcesz policzyć objętość innej kuli? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }

                            else break;
                        }
                        if (opcja == 3)
                        {
                            Console.WriteLine("Stożek");
                            Console.WriteLine("Wybierz opcję:");
                            Console.WriteLine("1.Pole");
                            Console.WriteLine("2.Objętość");
                            Console.WriteLine("3. Wyjdź");
                            int opcja1;
                            opcja1 = int.Parse(Console.ReadLine());
                            if (opcja1 == 1)
                            {
                                Console.WriteLine("Wzór na pole stożka to 3.14*r*r+3.14*r*l");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj promien podstawy r:");
                                    double k;
                                    k = double.Parse(Console.ReadLine());
                                    Console.WriteLine("promien postawy stozka ma dlugosc {0}", k);
                                    Console.WriteLine("podaj tworzaca stozka l:");
                                    double l;
                                    l = double.Parse(Console.ReadLine());
                                    Console.WriteLine("wysokosc twojego stozka to {0}, l");

                                    Console.WriteLine("Pole powierzchni Twojego stozka to {0}", 3.14*k*k+3.14*k*l);

                                    Console.WriteLine("Czy chcesz policzyć pole innego stozka? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }
                            if (opcja1 == 2)
                            {
                                Console.WriteLine("Wzór na objętość stozka to 3.14*r*r*h/3");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj długość promienia r:");
                                    double k;
                                    k = double.Parse(Console.ReadLine());
                                    Console.WriteLine("podaj wysokosc stozka h");
                                    double h;
                                    h = double.Parse(Console.ReadLine());
                                    Console.WriteLine("wysokosc twojego stozka {0}", h);
                                    Console.WriteLine("objetosc twojego stozka to {0}", 3.14*k*k*h/3);

                                    Console.WriteLine("Czy chcesz policzyć objętość innego stozka? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }
                            else break;

                        }
                        if (opcja == 4)
                        {
                            Console.WriteLine("Walec");
                            Console.WriteLine("Wybierz opcję:");
                            Console.WriteLine("1.Pole");
                            Console.WriteLine("2.Objętość");
                            Console.WriteLine("3. Wyjdź");
                            int opcja1;
                            opcja1 = int.Parse(Console.ReadLine());
                            if (opcja1 == 1)
                            {
                                Console.WriteLine("Wzór na pole sześcianu to 2*3.14*r*r+2*3.14*r*h");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj długość promienia r:");
                                    Double k;
                                    k = double.Parse(Console.ReadLine());
                                    Console.WriteLine("promien Twojego walca ma dlugosc {0}", k);
                                    Console.WriteLine("podaj wysokosc walca h:");
                                    double h;

                                    h = double.Parse(Console.ReadLine());
                                    Console.WriteLine("wysokosc twojego walca to {0}", h);
                                    Console.WriteLine("Pole powierzchni Twojego walca to {0}", 2*3.14*k*k+2*3.13*k*h);

                                    Console.WriteLine("Czy chcesz policzyć pole innego walca? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }
                            if (opcja1 == 2)
                            {
                                Console.WriteLine("Wzór na objętość walca to 3.14*r*r*h");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj długość promienia r:");
                                    Double k;
                                    k = double.Parse(Console.ReadLine());
                                    Console.WriteLine("promien Twojego walca ma dlugosc {0}", k);
                                    Console.WriteLine("podaj wysokosc walca h:");
                                    double h;

                                    h = double.Parse(Console.ReadLine());
                                    Console.WriteLine("wysokosc twojego walca to {0}",h);
                                    Console.WriteLine("objetosc twojego walca to {0}", 3.14*k*k*h);

                                    Console.WriteLine("Czy chcesz policzyć objętość innego walca? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }
                            else break;
                        }
                        if (opcja == 5)
                        {
                            Console.WriteLine("Ostroslup");
                            Console.WriteLine("Wybierz opcję:");
                            Console.WriteLine("1.Pole");
                            Console.WriteLine("2.Objętość");
                            Console.WriteLine("3. Wyjdź");
                            int opcja1;
                            opcja1 = int.Parse(Console.ReadLine());
                            if (opcja1 == 1)
                            {
                                Console.WriteLine("Wzór na pole ostroslupa to Pp + Pb  ");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj wyliczone pole podstawy");
                                    Double k;
                                    k = double.Parse(Console.ReadLine());
                                    Console.WriteLine("pole podstawy twojego ostroslupa to {0}", k);
                                    Console.WriteLine("podaj pole boczne calkowite");
                                    double h;

                                    h = double.Parse(Console.ReadLine());
                                    Console.WriteLine("pole boczne twojego ostroslupa to {0}", h);
                                    Console.WriteLine("Pole powierzchni twojego ostroslupa to {0}", k+h);

                                    Console.WriteLine("Czy chcesz policzyć pole innego ostroslupa? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }
                            if (opcja1 == 2)
                            {
                                Console.WriteLine("Wzór na objętość ostroslupa to Pp*h/3");
                                while (powt == true)
                                {
                                    Console.WriteLine("podaj pole podtawy:");
                                    Double k;
                                    k = double.Parse(Console.ReadLine());
                                    Console.WriteLine("promien Twojego walca ma dlugosc {0}", k);
                                    Console.WriteLine("podaj wysokosc ostroslupa h:");
                                    double h;

                                    h = double.Parse(Console.ReadLine());
                                    Console.WriteLine("wysokosc twojego ostroslupa to {0}", h);
                                    Console.WriteLine("objetosc twojego ostroslupa to {0}", k*h/3);

                                    Console.WriteLine("Czy chcesz policzyć objętość innego ostroslupa? t/n");
                                    string t;
                                    string tak = "t";

                                    t = Console.ReadLine();

                                    if (t == tak) powt = true;
                                    else powt = false;
                                }
                            }
                            else break;
                        }




                        break;


                        }
                        break;

                }
            }
        }
    
}
