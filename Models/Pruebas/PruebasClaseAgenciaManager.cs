using System;
using System.Collections.Generic;
using System.Text;

namespace AgenciaDeAlojamientos.Pruebas
{
    public class PruebasClaseAgenciaManager
    {
        public static void iniciar()
        {
            Console.WriteLine("Pruebas de la clase AgenciaManager");
            AgenciaManager agencia = new AgenciaManager();
            Console.WriteLine(agencia.GetReservas().Count);
            Console.WriteLine(agencia.GetUsuarios().Count);
        }
    }
}
