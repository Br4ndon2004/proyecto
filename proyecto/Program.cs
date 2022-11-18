using System;

namespace Encriptar
{
    static class ArrayExtensions
    {
        public static int IndexOf<T>(this T[] array, T value)
        {
            return Array.IndexOf(array, value);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            static int[] convertNumber(string frase)
            {
                char[] charfrase = frase.ToCharArray();
                int[] numbers = new int[charfrase.Length];
                for (int i = 0; i < charfrase.Length; i++)
                {
                    numbers[i] = numberTo(charfrase[i]);
                }
                return numbers;
            }
            static int numberTo(char letter)
            {
                char[] alfabeto = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                int index = alfabeto.IndexOf(letter);
                return index;
            }

            int opcion = 0;
            while (opcion != 3)
            {
                Console.WriteLine("/nELIGE OPCIONES");
                Console.WriteLine("1. Encriptar");
                Console.WriteLine("2. Desencriptar");
                Console.WriteLine("3. ADIOS");
                Console.WriteLine("Ingrese una opcion");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Encriptar();
                            break;
                        case 2:
                            break;
                        case 3:
                            Console.WriteLine("Fin del Programa");
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Opcion no valida");
                }
            }
            Console.ReadKey();

            async static void Encriptar()
            {
                char[] alfabeto = new char[26];
                char letra;
                int posicion = 0;
                for (int i = 0; i < alfabeto.Length; i++)
                {
                    letra = Convert.ToChar(i + 65);
                    alfabeto[i] = letra;
                }
                Console.WriteLine("Frase: ");
                string texto = Console.ReadLine();
                texto = texto.ToUpper();
                for (int i = 0; i < texto.Length; i++)
                {
                    for (int j = 0; j < alfabeto.Length; j++)
                    {
                        if (texto[i] == alfabeto[j])
                        {
                            posicion = j + 1;
                            break;
                        }
                    }
                    int[] a = new int[] { 1, 3, 5, 7, 9 };
                    int resultado = posicion * a[i % 5];
                    int[] b = new int[5];
                    b[i % 5] = resultado;
                    Console.Write(b[i % 5] + " ");

                }
            }
        }
    }
}
