Console.Write("Ingrese el lado A:");
var ladoA=int.Parse(Console.ReadLine());
Console.Write("Ingrese el lado B:");
var ladoB=int.Parse(Console.ReadLine());
Console.Write("Ingrese el lado C:");
var ladoC=int.Parse(Console.ReadLine());

var esTriangulo=VerificarTriangulo(ladoA,ladoB,ladoC);
if (esTriangulo)
{
    string tipoDeTriangulo = DevolverTipoDeTriangulo(ladoA, ladoB, ladoC);
    Console.WriteLine($"Los lados ingresados conforman un {tipoDeTriangulo}");
}
else
{
    Console.WriteLine($"Los lados ingresados no conforman un triángulo");

}
Console.ReadLine();
string DevolverTipoDeTriangulo(int ladoA, int ladoB, int ladoC)
{
    if(ladoA!=ladoB && ladoB!=ladoC && ladoA != ladoC)
    {
        return "Triangulo Escaleno";
    }else if(ladoA==ladoB && ladoB == ladoC)
    {
        return "Triangulo Equilátero";
    }else {
        return "Triángulo Isosceles";
    }
}

bool VerificarTriangulo(int ladoA, int ladoB, int ladoC)
{
    return ladoA + ladoB > ladoC && ladoA + ladoC > ladoB &&
        ladoB + ladoC > ladoA;
}