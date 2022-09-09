///Programa creado por Brisa Leticia Figueroa Bautista
//Programa

//Ciclo for
//Lista de numeros del 01 al 10
int x, y;
Console.WriteLine("Dónde comienza el ciclo:");
x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Dónde termina el ciclo");
y = Convert.ToInt32(Console.ReadLine());

//Desarrolamos el ciclo
for (int i = x; i <= y; i += 4)
{
    Console.WriteLine("i= " + i);
}
