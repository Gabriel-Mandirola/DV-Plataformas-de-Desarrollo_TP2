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
            //agencia.GetReservas().ForEach(reserva => Console.WriteLine(reserva));

            /* Find Reserva*/
            //String reserva_id = "1620250906";
            //Console.WriteLine(agencia.FindReservaForId(reserva_id).ToString());

            /* Get Reservas For User */
            //foreach (Reserva reserva in agencia.GetAllReservasForUsuario(12312312))
            //{
            //    Console.WriteLine(reserva);
            //}

            /* CREATE */
            //Console.WriteLine(agencia.AgregarReserva(DateTime.Now, DateTime.Now, 412, 12312312) ? "Se agrego" : "No se agrego");
            //Thread.Sleep(1000);
            //Console.WriteLine(agencia.AgregarReserva(DateTime.Now, DateTime.Now, 543, 23423423) ? "Se agrego" : "No se agrego");
            //Thread.Sleep(1000);
            //Console.WriteLine(agencia.AgregarReserva(DateTime.Now, DateTime.Now, 752, 34534534) ? "Se agrego" : "No se agrego");
            //Console.Write(agencia.GuardarCambiosDeLasReservas() ? "Cambios guardados" : "No se pudo guardar");

            /* Eliminar */
            //if (agencia.EliminarReserva("1620250908"))
            //{
            //    Console.Write(agencia.GuardarCambiosDeLasReservas() ? "Cambios guardados" : "No se pudo guardar");
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo eliminar la reserva");
            //}
            //agencia.GetReservas().ForEach(reserva => Console.WriteLine(reserva.ToString()));

            /* UPDATE */
            ////Antes de ser modificado: 1620250908,5/5/2021 18:41:48,5/7/2021 23:59:59,752,34534534,4500
            //if (agencia.ModificarReserva("1620250908", new DateTime(2021,5,5,18,25,00), new DateTime(2021,10,5), 123, 34534534))
            //{
            //    Console.WriteLine("Reserva modificada");
            //    Console.WriteLine( agencia.GuardarCambiosDeLasReservas() ? "Cambios guardados":"No se guardaron los cambios" );
            //}
            //else
            //{
            //    Console.WriteLine("No se pudo modificada la reserva");
            //}
            #endregion

            #region PRUEBAS DE LOS ALOJAMIENTOS
            Agencia alojamientoController = agencia.GetAgencia();

            /* TODOS LOS ALOJAMIENTOS */
            //alojamientoController.GetAllAlojamientos().ForEach(al => Console.WriteLine(al));
            //alojamientoController.GetAllAlojamientos(4).ForEach(al => Console.WriteLine(al));
            //alojamientoController.GetAllAlojamientos(4000,5000).ForEach(al => Console.WriteLine(al));
            
            // METODOS DE ORDENAMIENTO
            //alojamientoController.GetAlojamientoPorEstrellas().ForEach(al => Console.WriteLine(al));
            //alojamientoController.GetAlojamientoPorCodigo().ForEach(al => Console.WriteLine(al));
            //alojamientoController.GetAlojamientoPorPersonas().ForEach(al => Console.WriteLine(al));
            
            Console.WriteLine(); // Separador

            /* HOTELS */
            //alojamientoController.GetHoteles().ForEach( hotel => Console.WriteLine(hotel));
            //alojamientoController.GetHoteles(3500,5000).ForEach(hotel => Console.WriteLine(hotel));

            //Console.WriteLine(); // Separador

            /* CABANIAS */
            //alojamientoController.GetCabanias().ForEach(cabania => Console.WriteLine(cabania));
            //alojamientoController.GetCabanias(2000, 3000).ForEach(cabania => Console.WriteLine(cabania));
            #endregion

        }
    }
}
