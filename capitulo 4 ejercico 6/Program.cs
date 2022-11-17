namespace ejercicio12
{

    internal class program
    {

        static void Main()
            {
            double cantidad, cantidad_delaño = 0, ahorrodelmes;
            for (int i=1; i< 13; i++) 
            {
                Console.WriteLine("proceso" + i);
                Console.WriteLine("ingrese el valor a depositar");
                cantidad = double.Parse(Console.ReadLine());
                cantidad_delaño = cantidad_delaño + cantidad;
                ahorrodelmes = cantidad_delaño;
                Console.WriteLine("el valor de cantidad del mes es de" + ahorrodelmes);

            
            }
            Console.WriteLine("el ahorro de un año es de" + cantidad_delaño);        }
    }
}