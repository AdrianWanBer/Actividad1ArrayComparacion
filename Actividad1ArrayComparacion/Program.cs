namespace Actividad1ArrayComparacion
{
    class program
    {
        public static void Main(String[] args)
        {
            char[] Vocales1 = {'a', 'e', 'i', 'o','u' };
            char[] Vocales2 = { 'a', 'e', 'i', 'o', 'x' };

            for(int recorrido = 0; recorrido < Vocales1.Length; recorrido++)
            {
               if( Vocales1[recorrido] != Vocales2[recorrido])
                {
                    Console.WriteLine("En la posicion: " + recorrido + " del segundo array esta mal");
                }
            }
        }
    }
}
