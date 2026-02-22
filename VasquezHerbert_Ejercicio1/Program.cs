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
double presion  = double.Parse(Console.ReadLine());
if (tipo > 0 && edad > 0 && temperatura > 0 && oxigeno > 0 && dolor > 0 && presion > 0)
{
    switch (tipo)
    {
        //se crea un limite por cada cosa, le agregamos 3 tipos de prioridades tales como maxima, media y minima
        //Ya que el ennunciado no tiene limitantes ni algo minimo
        case 1: //emergencia
            if (oxigeno < 90)
            {
                Console.WriteLine("Prioridad máxima y reanimación inmediata");
            }
            else if (temperatura >= 39 && dolor >= 8)
            {
                Console.WriteLine("Prioridad media y observación intensiva");
            }
            else
            {
                Console.WriteLine("Prioridad mínima y atención rápida");
            }
            break;
        case 2: //Consulta
            if (dolor <= 3 && temperatura < 38)
            {
                Console.WriteLine("Prioridad mínima y consulta programada");
            }
            else
            {
                Console.WriteLine("Prioridad media y atención en el día");
            }
            break; //Pediatra
        case 3:
            if (edad < 12 && temperatura >= 38.5)
            {
                Console.WriteLine("Prioridad máxima y observación pediátrica urgente");
            }
            else
            {
                Console.WriteLine("Prioridad media y consulta pediátrica");
            }
            break;
        case 4: // Traumotologia
            if (dolor >= 7 || presion < 90)
            {
                Console.WriteLine("Prioridad máxima y atención traumatológica urgente");
            }
            else
            {
                Console.WriteLine("Prioridad media y consulta traumatológica");
            }
            break;
        default://error
            Console.WriteLine("Tipo de atención inválido.");
            break;
    }
}
else
{
    Console.WriteLine("Dato erroneo");
}