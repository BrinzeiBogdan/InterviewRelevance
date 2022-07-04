using ProjectRelevance.Articole;

namespace ProjectRelevance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ghiozdan ghiozdan = new Ghiozdan(3, 3.0f, 5.0f);


            Console.WriteLine(ghiozdan.Raportare());
            Console.WriteLine("");

            Console.Write("ADAUGA ARTICOLE DIN MENIU: \n" +
                "Sageata: greutate - 0.1; volum - 0.05 => APASA 1 \n" +
                "Arc: greutate - 1; volum - 4  => APASA 2 \n" +
                "Franghie: greutate - 1; volum - 1.5  => APASA 3 \n" +
                "Apa: greutate - 2; volum - 3  => APASA 4 \n" +
                "Mancare: greutate - 1; volum - 0.5  => APASA 5 \n" +
                "Sabie: greutate - 5; volum - 3  => APASA 6 \n" +
                "Iesire => APASA 7 \n" +
                "Raportare => APASA 8 \n");


            while (true) {
                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":{
                           String result = ghiozdan.Adauga(new Sageata()) ? "Sageata a fost adaugata" : "Limitele sunt depasite!";
                           Console.WriteLine(result);
                           break;
                        }

                    case "2":
                        {
                            String result = ghiozdan.Adauga(new Arc()) ? "Arcul a fost adaugat" : "Limitele sunt depasite!";
                            Console.WriteLine(result);
                            break;
                        }
                    case "3":
                        {
                            String result = ghiozdan.Adauga(new Franghie()) ? "Franghia a fost adaugata" : "Limitele sunt depasite!";
                            Console.WriteLine(result);
                            break;
                        }
                    case "4":
                        {
                            String result = ghiozdan.Adauga(new Apa()) ? "Apa a fost adaugata" : "Limitele sunt depasite!";
                            Console.WriteLine(result);
                            break;
                        }
                    case "5":
                        {
                            String result = ghiozdan.Adauga(new Mancare()) ? "Mancarea a fost adaugata" : "Limitele sunt depasite!";
                            Console.WriteLine(result);
                            break;
                        }
                    case "6":
                        {
                            String result = ghiozdan.Adauga(new Sabie()) ? "Sabia a fost adaugata" : "Limitele sunt depasite!";
                            Console.WriteLine(result);
                            break;
                        }
                    case "7":
                        {
                            goto LoopEnd;
                        }
                    case "8":
                        {
                            Console.WriteLine(ghiozdan.Raportare());
                            break;
                        }
                    default:
                        Console.WriteLine("Alege alt articol");
                        break;
                }

                

            }

        LoopEnd:
            Console.WriteLine("Calatorie placuta!");
        }

    }
}
