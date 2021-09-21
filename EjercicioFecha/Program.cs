using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFecha
{
    public class Fecha
    {
        private int dia;
        private int mes;
        private int anio;

        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Anio { get => anio; set => anio = value; }

        public bool validarFecha()
        {
            bool esValida = false;
            if (this.mes == 4 || this.mes == 6 || this.mes == 9 || this.mes == 4)
            {
                if (this.dia > 0 && this.dia <= 30)
                {
                    esValida = true;
                }
            }
            else
            {
                if (this.mes==2)
                {
                    //BISIESTO
                    if ((this.anio%4==0&&this.anio%100!=0)||(this.anio%4==0&&this.anio%400==0))
                    {
                        if (this.dia>0&&this.dia<=29)
                        {
                            esValida = true;
                        }
                    }
                    else
                    {
                        if (this.dia>0&&this.dia<=28)
                        {
                            esValida = true;
                        }
                    }
                }
                else
                {
                    if (this.mes>0&&this.mes<=12)
                    {
                        if (this.dia>0&&this.dia<=31)
                        {
                            esValida = true;
                        }
                    }
                }
            }
            return esValida;
        }
       public string mostrarFecha()
        {
            return this.dia + "/" + this.mes + "/" + this.anio;
        } 
    }
    public class Persona
    {
        private String codigo;
        private String nombre;
        private String apellido;
        private Fecha fechaNac;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public Fecha FechaNac
        {
            get => fechaNac;
            set
            {
                if (value.validarFecha())
                    fechaNac = value;
                else
                {
                    fechaNac = new Fecha();
                    fechaNac.Dia = 0;
                    fechaNac.Mes = 0;
                    fechaNac.Anio = 0;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            Fecha fn = new Fecha();
            Console.Write("Digite el codigo de la persona: ");
            p.Codigo = Console.ReadLine();
            Console.Write("Digite el nombre de la persona: ");
            p.Nombre = Console.ReadLine();
            Console.Write("Digite el apellido de la persona: ");
            p.Apellido = Console.ReadLine();
            Console.Write("Digite el dia de nacimiento: ");
            fn.Dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el mes de nacimiento: ");
            fn.Mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite el anio de nacimiento: ");
            fn.Anio = Convert.ToInt32(Console.ReadLine());
            p.FechaNac = fn;
            Console.WriteLine(" ");
            Console.WriteLine(p.Codigo + " " + p.Nombre + " " + p.Apellido + " " + p.FechaNac.mostrarFecha());
            Console.Read();
        }
    }
}
