using GenericClass;
 
class Program
{
    static void Main()
    {
        var parEnteros = new Par<int,int>(150, 20);
        var parNombres= new Par<string,string>("Juan","Pedro");
        var parMixto = new Par<int, string>(1, "Distrito Nacional");
        var parObjeto = new Par<Punto, Punto>(new Punto(1, 2), new Punto(4, 6));
       
        Console.WriteLine(parEnteros);
        Console.WriteLine(parNombres);
        Console.WriteLine(parMixto);
        Console.WriteLine(parObjeto);

       
    }
}