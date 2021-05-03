using System;
using System.Collections.Generic;
using System.Text;

using System.Security.Cryptography;
using AgenciaDeAlojamientos.Helpers;
using AgenciaDeAlojamientos.Models;

namespace AgenciaDeAlojamientos.Pruebas
{
    public class PruebasClaseAgenciaManager
    {
        public static void iniciar()
        {
            Console.WriteLine("\n~~~~ PRUEBAS DE LA CLASE AGENCIAMANAGER ~~~~ \n");
            AgenciaManager agencia = new AgenciaManager();

            /* LOGIN USER */
            //if (agencia.autenticarUsuario(40393222, "admin1234"))
            //    Console.WriteLine("Logeado");
            //else
            //    Console.WriteLine("No logeado");

            /* CREATE USER */
            //agencia.AgregarUsuario(12312312, "juan", "juan@gmail.com", "juan", true, false);
            //agencia.AgregarUsuario(23423423, "pepe", "pepe@gmail.com", "pepe", false, false);
            //agencia.AgregarUsuario(34534534, "martina", "martina@gmail.com", "martina", true, false);
            //agencia.AgregarUsuario(45645645, "martin", "martin@gmail.com", "martin", false, false);
            //agencia.AgregarUsuario(56756756, "jose", "jose@gmail.com", "jose", false, false);
            //agencia.AgregarUsuario(67867867, "sofia", "sofia@gmail.com", "sofia", false, false);
            //agencia.AgregarUsuario(40393222, "saul", "saul@gmail.com", "admin", true, false);
            //agencia.GuardarCambiosEnLosUsuarios();

            /* UPDATE */
            //agencia.ModificarUsuario(40393222, "saul","saul@gmail.com"); /* datos antiguos */
            //agencia.ModificarUsuario(40393222, "saul001","saul_zarate@gmail.com","admin1234");
            //agencia.GuardarCambiosEnLosUsuarios();

            /* DELETE */
            //agencia.EliminarUsuario(40393222);
            //agencia.GuardarCambiosEnLosUsuarios();

            /* BLOQUEAR Y DESBLOQUEAR */
            //agencia.BloquearUsuario(40393222);
            //Console.WriteLine(agencia.FindUserForDNI(40393222));
            //agencia.DesbloquearUsuario(40393222);
            //Console.WriteLine(agencia.FindUserForDNI(40393222));
        
        }
    }
}
