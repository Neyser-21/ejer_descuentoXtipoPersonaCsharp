using System;

namespace descuentoXtipoPersona
{
    internal class Program
    {
       
        public static void Main(string[] args)
        {
            string genero, dia;
            Console.WriteLine("Por favor, ingresa tu género: Hombre o Mujer.");
            genero = Console.ReadLine();
            
            Console.WriteLine("Ingrese el día de la semana");
            dia = Console.ReadLine();
            
            
            //metodo de valores
            PersonaDiaSemana(genero, dia);
            
            Console.WriteLine("Precione una tecla para continuar...");
            Console.ReadKey();

            

        }

        static void PersonaDiaSemana(string genero,string dia)
        {
            //precios originales
            double precioH = 10.0;
            double precioM = 5.0;
            double total = 0;
            
            //descuento x dia para mujer 
            double lunMiercolesSabado = 0.50;
            
        
            //descuento x dia para hombre
            double domingoH = 0.50;
            double juevesH = 0.10;
            double martesH = 0.30;
            
            //Verificacion de genero 
           // if (genero != "Hombre" || genero != "Mujer")
           //     Console.WriteLine("El valor ingresado no es valido, intente de nuevo");
            
            
            if (genero == "Hombre")
            {
                switch (dia)
                {
                    case "domingo":
                        total = CalcularDescuento(precioH, domingoH);
                        break;
                    case "jueves":
                        total = CalcularDescuento(precioM, juevesH);
                        break;
                    case "martesH":
                        total = CalcularDescuento(precioM, martesH);
                        break;
                    default:
                        Console.WriteLine("El precio a pagar sera de {0:C}", precioH);
                        break;
                }
                
            }
            else if (genero == "Mujer")
            {
                switch (dia)
                {
                    case "lunes":
                    case "miercoles":
                    case "Sabado":
                        total = CalcularDescuento(precioM, lunMiercolesSabado);
                        break;
                    case "viernes":
                        Console.WriteLine("Usted puede ingresar Gratis");
                        break;
                    default:
                        Console.WriteLine("El precio que debe pagar es: {0:C}", precioM);
                        break;
                }
            }
            
            
            //Imprime el valor a pagar del usuario dependiendo el dia y su genero
            Console.WriteLine("El total a pagar con descuento sera {0:C}", total);
           
            
        }

        static double CalcularDescuento(double precio, double tipoDescuento)
        {
            double total = precio * tipoDescuento;
            return precio - total;
        }
    }
}
