using System;
using System.Threading.Channels;

//Un instructor prepara tres modelos de exámenes
//para tres secciones en un curso de programación
//El instructor sabe que tarda 5 minutos en el modelo del salón A,
//8 minutos en el modelo del salón B y 6 minutos
//en el modelo del salón C ¿Cuántas horas y minutostardará
//el instructor en revisar los exámenes de todos los salones?

Console.WriteLine("Cantidada de estudiantes");
Console.Write("Salón A:  "); 
int salona = int.Parse(Console.ReadLine());
Console.Write("Salón B:  ");
int salonb = int.Parse(Console.ReadLine());
Console.Write("Salón C:  ");
int salonc = int.Parse(Console.ReadLine());

int tsalona = salona * 5;
int tsalonb = salonb * 8;
int tsalonc = salonc * 6;
int total1 = tsalona + tsalonb + tsalonc;

if (total1%60==0)
{
    int total2 = total1 / 60;
    Console.WriteLine("El total es: " + total2 + " horas");
}
else
{
    int minutos = total1% 60;
    int total2 = total1 / 60;
    Console.WriteLine("El total es: " + total2 +" horas y " + minutos + " minuto(s)" );
}