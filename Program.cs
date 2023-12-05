internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        System.Console.Write("Ingrese la cantidad de universidades que participan: ");
        int cantidadUniversidades = int.Parse(Console.ReadLine());

        List<Universidad> universidades = new List<Universidad>();
        for (int i = 0; i < cantidadUniversidades; i++)
        {
            Console.Clear();
            Console.Write($"Ingrese el nombre de la universidad #{i + 1}: ");
            string nombreUniversidad = Console.ReadLine();

            Universidad universidad = new Universidad(nombreUniversidad);
            int cont = 1;
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Ingrese voto para la universidad {nombreUniversidad} (A para aceptar, R para rechazar, N para nulo, B para blanco). Ingrese X para finalizar.");
                System.Console.WriteLine("Voto {0}", cont);
                cont++;
                string voto = Console.ReadLine().ToUpper();

                if (voto == "X")
                    break;

                universidad.RegistrarVoto(voto);
            }

            universidades.Add(universidad);
        }

        MostrarResultados(universidades);
    }

    static void MostrarResultados(List<Universidad> universidades)
    {
        int aceptan = 0, rechazan = 0, empate = 0;
        Console.Clear();
        System.Console.WriteLine("Número de Universidades {0}", universidades.Count());
        foreach (var universidad in universidades)
        {
            System.Console.WriteLine("Universidad: {0}", universidad.Nombre);
            System.Console.WriteLine("Aceptan: {0}", universidad.Aceptan);
            System.Console.WriteLine("Rechazan: {0}", universidad.Rechazan);
            System.Console.WriteLine("Nulos: {0}", universidad.Nulos);
            System.Console.WriteLine("Blancos: {0}", universidad.Blancos);
            System.Console.WriteLine("---------------------------------");
            if (universidad.Aceptan > universidad.Rechazan)
                aceptan++;
            else if (universidad.Aceptan < universidad.Rechazan)
                rechazan++;
            else
                empate++;
        }

        System.Console.WriteLine($"Universidades que aceptan: {aceptan}");
        System.Console.WriteLine($"Universidades que rechazan: {rechazan}");
        System.Console.WriteLine($"Universidades con empate: {empate}");
    }
}

