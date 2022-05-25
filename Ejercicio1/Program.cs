namespace Ejercicio1;

static class Program
{

    public static int Main(string[] args)
    {
        int bucle = 0;
        int opcion;
        double entrada;
        Calculadora calculadora = new Calculadora(0);

        while(bucle == 0)
        {
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            
            Console.WriteLine("Resultado: " + calculadora.VerResultado());
            
            opcion = Convert.ToInt32(Console.ReadLine());
            
            if(opcion != 5)
            {
                Console.WriteLine("Ingrese el numero");
                entrada = float.Parse(Console.ReadLine());

                switch(opcion)
                {
                    case 1:
                        calculadora.Sumar(entrada);
                        break;
                    case 2:
                        calculadora.Restar(entrada);
                        break;
                    case 3:
                        calculadora.Multiplicar(entrada);
                        break;
                    case 4:
                        calculadora.Dividir(entrada);
                        break;
                }
            }
            else
            {
                bucle = 1;
            }
        }

        return 0;
    }
}