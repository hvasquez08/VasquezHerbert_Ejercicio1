//incio del trabajo 
//prioridad medica
using System.Runtime.CompilerServices;

Console.WriteLine("Ingrese el tipo de atencion que necesita");
Console.WriteLine("1 Emergencia\r\n2 Consulta\r\n3 Pediatría\r\n4 Traumatología");
int tipo = int .Parse(Console.ReadLine());
Console.WriteLine("Ingrese la edad del paciente");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la temperatura del paciente en grados centigrados");
double temperatura = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese saturacin del oxigeno");
double oxigeno = double.Parse(Console.ReadLine());
Console.WriteLine("Nivel de dolor(0-10)");
int dolor = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese presion sistolica");
double precion  = double.Parse(Console.ReadLine());
if (tipo > 0 && edad > 0 && temperatura > 0 && oxigeno > 0 && dolor > 0 && precion > 0)
{
    switch (tipo)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        default:
            break;
    }
}
else
{
    Console.WriteLine("Dato erroneo");
}