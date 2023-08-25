namespace MaquinaDaVuelto
{       //Hurrraaaa Joyisima salio

    //ctrl k ctrl d Dar Formato
    internal class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, acum, billetes, resto;
            A = 270; B = 340; C = 390;
            string opcion;
            acum = 0;

            Console.Write("Elija Producto : ");
            opcion = Console.ReadLine();

            if (opcion == "A" || opcion == "B" || opcion == "C")
            {
                Console.WriteLine("Ingrese Billetes : ");

                if (opcion == "A")
                {
                    do
                    {
                        billetes = Convert.ToInt32(Console.ReadLine());

                        if (billetes == 50 || billetes == 100 || billetes == 10)
                        {
                            acum = acum + billetes;
                        }
                        else
                        {
                            Console.WriteLine("Te equivocaste Guachin");
                        }
                    } while (acum < 270);

                    resto = acum - A;


                    if (resto > 0)
                    {
                        Console.WriteLine("Su Vuelto :");
                        if (resto >= 100)
                        {
                            do
                            {
                                resto = resto - 100;
                                Console.WriteLine("100");
                            } while (resto < 100);
                        }
                        else if (resto >= 50)
                        {
                            do
                            {
                                resto = resto - 50;
                                Console.WriteLine("50");

                            } while (resto >= 50);

                            if (resto >= 10)
                            {
                                do
                                {
                                    resto = resto - 10;
                                    Console.WriteLine("10");
                                } while (resto >= 10);

                            }
                        }
                    }
                }
                if (opcion == "B")
                {
                    do
                    {
                        billetes = Convert.ToInt32(Console.ReadLine());

                        if (billetes == 50 || billetes == 100 || billetes == 10)
                        {
                            acum = acum + billetes;
                        }
                        else
                        {
                            Console.WriteLine("Te equivocaste Guachin");
                        }
                    } while (acum < 340);

                    resto = acum - B;


                    if (resto > 0)
                    {
                        Console.WriteLine("Su Vuelto :");
                        if (resto >= 100)
                        {
                            do
                            {
                                resto = resto - 100;
                                Console.WriteLine("100");
                            } while (resto < 100);
                        }
                        else if (resto >= 50)
                        {
                            do
                            {
                                resto = resto - 50;
                                Console.WriteLine("50");

                            } while (resto >= 50);

                            if (resto >= 10)
                            {
                                do
                                {
                                    resto = resto - 10;
                                    Console.WriteLine("10");
                                } while (resto >= 10);

                            }
                        }
                    }
                }
                if (opcion == "C")
                {
                    do
                    {
                        billetes = Convert.ToInt32(Console.ReadLine());

                        if (billetes == 50 || billetes == 100 || billetes == 10)
                        {
                            acum = acum + billetes;
                        }
                        else
                        {
                            Console.WriteLine("Te equivocaste Guachin");
                        }
                    } while (acum < 390);

                    resto = acum - C;


                    if (resto > 0)
                    {
                        Console.WriteLine("Su Vuelto :");
                        if (resto >= 100)
                        {
                            do
                            {
                                resto = resto - 100;
                                Console.WriteLine("100");
                            } while (resto < 100);
                        }
                        else if (resto >= 50)
                        {
                            do
                            {
                                resto = resto - 50;
                                Console.WriteLine("50");

                            } while (resto >= 50);

                            if (resto >= 10)
                            {
                                do
                                {
                                    resto = resto - 10;
                                    Console.WriteLine("10");
                                } while (resto >= 10);

                            }
                        }
                    }
                }

            }
            else
                Console.WriteLine("Son Tres Opciones A , B y C , No hay mas.");


        }
    }
}