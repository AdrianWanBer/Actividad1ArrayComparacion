namespace Actividad1ArrayComparacion
{
    class program
    {
        public static void Main(String[] args)
        {
            char[] Vocales1 = {'a', 'e', 'i', 'o','u' };
            char[] Vocales2 = { 'a', 'e', 'i', 'o', 'x' };

            for(int fila = 0; fila < 1; fila++)
            {
                for(int columna = 0; columna < Vocales1.Length; columna++)
                {
                    if(Vocales1[columna] != Vocales2[columna])
                    {
                        Console.WriteLine("El errar esta en Vocales2 en la posicion fila: " + fila + " / columna: " + columna);
                    }

                }
               
            }
        }
    }
}
