// 

class program
{
    static void Main(string[]args)
    {
        int opcion = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Elige una operacion aritmetica");
            Console.WriteLine("suma [1]");
            Console.WriteLine("resta [2]");
            Console.WriteLine("multiplicacion [3]");
            Console.WriteLine("division [4]");
            Console.WriteLine("salir [5]");
    
            opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion)
            {
                case 1: suma();
                break;

                case 2: resta();
                
                break;

                case 3: multiplicacion();
                
                break;

                case 4: division();
                break;

                case 5: salir();
                break;

                default: Default();
                break;
            }
        
        }while(opcion != 5);
        Console.Clear();
        
          static void suma()
          {
            Console.Clear();
            int num, num2;
            int sum;

            Console.WriteLine("Digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
           
            sum = num + num2;
            Console.WriteLine($"La suma de los dos digitos es {sum} ");
            Console.ReadKey();
          }
            

        static void resta()
        {
            Console.Clear();
            int num, num2;
            int res;

            Console.WriteLine("Digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
           
            res = num - num2;
            Console.WriteLine($"La resta de los dos digitos es {res}");
            Console.ReadKey();
        }

        static void multiplicacion()
        {
            Console.Clear();
            int num, num2;
            int mul;

            Console.WriteLine("Digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
           
            mul = num * num2;
            Console.WriteLine($"la multiplicacion de los digitos es {mul} ");
            Console.ReadKey();
        }   

        static void division()
        {
            Console.Clear();
            int num, num2;
            int div;

            Console.WriteLine("Digite un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("digite otro numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
           
            div = num / num2;
            Console.WriteLine($"la division de los digitos es {div} ");
            Console.ReadKey();
        } 

        static void salir()
        {
            Console.Clear();
            Console.WriteLine("El programa ha finalizado, gracias por usar este programa (:");
            Console.ReadKey();
        }

        static void Default()
        {
            Console.Clear();
            Console.WriteLine("Opcion incorrecta ");
            Console.ReadKey();
        }

    }

}
                    