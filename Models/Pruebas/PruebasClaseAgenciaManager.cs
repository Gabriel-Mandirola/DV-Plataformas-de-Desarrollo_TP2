using System;
using System.Collections.Generic;
using System.Text;

using System.Security.Cryptography;
using AgenciaDeAlojamientos.Helpers;
using AgenciaDeAlojamientos.Models;
using System.Threading;

namespace AgenciaDeAlojamientos.Pruebas
{
    public class PruebasClaseAgenciaManager
    {
        public static void iniciar()
        {
            Console.WriteLine("\n~~~~ PRUEBAS DE LA CLASE AGENCIAMANAGER ~~~~ \n");
            AgenciaManager agencia = new AgenciaManager();

            #region PRUEBAS DE USUARIOS
            /* LOGIN USER */
            //if (agencia.autenticarUsuario(40393222, "admin1234"))
            //    Console.WriteLine("Logeado");
            //else
            //    Console.WriteLine("No logeado");

            /* READ */
            //agencia.GetUsuarios().ForEach(user => Console.WriteLine(user));

            /* CREATE */
            //agencia.AgregarUsuario(12312312, "juan", "juan@gmail.com", "juan", true, false);
            //agencia.AgregarUsuario(23423423, "pepe", "pepe@gmail.com", "pepe", false, false);
            //agencia.AgregarUsuario(34534534, "martina", "martina@gmail.com", "martina", true, false);
            //agencia.AgregarUsuario(45645645, "martin", "martin@gmail.com", "martin", false, false);
            //agencia.AgregarUsuario(56756756, "jose", "jose@gmail.com", "jose", false, false);
            //agencia.AgregarUsuario(67867867, "sofia", "sofia@gmail.com", "sofia", false, false);
            //agencia.AgregarUsuario(40393222, "saul", "saul@gmail.com", "admin", true, false);
            //agencia.GuardarCambiosDeLosUsuarios();

            /* UPDATE */
            //agencia.ModificarUsuario(40393222, "saul","saul@gmail.com"); /* datos antiguos */
            //agencia.ModificarUsuario(40393222, "saul001","saul_zarate@gmail.com","admin1234");
            //agencia.GuardarCambiosDeLosUsuarios();

            /* DELETE */
            //agencia.EliminarUsuario(40393222);
            //agencia.GuardarCambiosDeLosUsuarios();

            /* BLOQUEAR Y DESBLOQUEAR */
            //agencia.BloquearUsuario(40393222);
            //Console.WriteLine(agencia.FindUserForDNI(40393222));
            //agencia.DesbloquearUsuario(40393222);
            //Console.WriteLine(agencia.FindUserForDNI(40393222));
            #endregion

            #region PRUEBAS DE RESEVAS
            /* READ */
            agencia.GetReservas().ForEach(reserva => Console.WriteLine(reserva.ToString()));

            /* Find Reserva*/
            //String reserva_id = "1620250908";
            //Console.WriteLine(agencia.FindReservaForId(reserva_id).ToString());

            /* CREATE */
            //Console.WriteLine(agencia.AgregarReserva(DateTime.Now, DateTime.Now, 412, 12312312) ? "Se agrego" : "No se agrego");
            //Thread.Sleep(1000);
            //Console.WriteLine(agencia.AgregarReserva(DateTime.Now, DateTime.Now, 543, 23423423) ? "Se agrego" : "No se agrego");
            //Thread.Sleep(1000);
            //Console.WriteLine(agencia.AgregarReserva(DateTime.Now, DateTime.Now, 752, 34534534) ? "Se agrego" : "No se agrego");
            //agencia.GuardarCambiosDeLasReservas();

            /* Eliminar */


            #endregion
        }
    }
}
