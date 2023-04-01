void matriz()
{
    string[] nombre = new string[]
    {
        "Anderson", "Brandon", "Yeimi", "Fatima", "Vivian"
    };


    int[] notas = new int[]
    {
        50,90,85,73,95
    };
    int mayor = 0;
    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] > mayor)
        {
            mayor = notas[i];

        }
    }
    Console.WriteLine("La nota mayor es de: " + mayor);

}
matriz();
