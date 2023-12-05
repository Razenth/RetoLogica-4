class Universidad
{
    public string Nombre { get; }
    public int Aceptan { get; private set; }
    public int Rechazan { get; private set; }
    public int Nulos { get; private set; }
    public int Blancos { get; private set; }

    public Universidad(string nombre)
    {
        Nombre = nombre;
    }

    public void RegistrarVoto(string voto)
    {
        switch (voto)
        {
            case "A":
                Aceptan++;
                break;
            case "R":
                Rechazan++;
                break;
            case "N":
                Nulos++;
                break;
            case "B":
                Blancos++;
                break;
            default:
                Console.WriteLine("Voto no válido. Ingrese A, R, N o B.");
                break;
        }
    }
}