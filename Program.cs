Console.WriteLine("ingrese nombre");
string Nombre = Console.ReadLine();
Console.WriteLine("ingrese mail");
string Mail = Console.ReadLine();
Console.WriteLine("ingrese cupon");
string cupon = Console.ReadLine();

double precio = 200;
bool descuento;

if(cupon == "si")
{
    descuento = true;
}
else
{
    descuento = false;
}

if (descuento)
{
    Console.WriteLine(precio * 0.9);
}
else
{
    Console.WriteLine(precio);
}