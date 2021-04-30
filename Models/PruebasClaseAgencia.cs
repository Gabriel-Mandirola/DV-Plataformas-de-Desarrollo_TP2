using System;
using System.Collections.Generic;
using System.Text;

using AgenciaDeAlojamientos.Helpers;

namespace AgenciaDeAlojamientos
{
    class PruebasClaseAgencia
    {
        public static void iniciar()
        {
            var hotel1 = new Hotel(863, "buenos aires", "retiro", 4, 1, true, 1000);
            var hotel2 = new Hotel(752, "Cordoba", "villa carlos paz", 2, 3, true, 1500);
            var hotel3 = new Hotel(645, "Buenos aires", "puerto madero", 1, 2, false, 2000);
            var cabania1 = new Cabania(334, "Buenos aires", "puerto madero", 3, 2, true, 2400, 2, 1);
            var cabania2 = new Cabania(543, "La Plata", "centro", 2, 2, false, 3000, 1, 1);

            #region Pruebas de la clase agencia
            //var agencia = new Agencia();
            //agencia.AgregarAlojamiento(hotel1);
            //agencia.AgregarAlojamiento(hotel2);
            //agencia.AgregarAlojamiento(hotel3);
            //agencia.AgregarAlojamiento(cabania1);
            //agencia.AgregarAlojamiento(cabania2);

            /* ~~~~~~~~~~~~ Pruebas de los metodos de Agencia ~~~~~~~~~~~~ */
            //Console.WriteLine(agencia.GetCantidadDeAlojamientos());
            //Console.WriteLine(agencia.AlojamientosEntrePrecios(1200,2000).GetCantidadDeAlojamientos());
            //Console.WriteLine(agencia.GetHoteles().GetCantidadDeAlojamientos
            //Console.WriteLine(agencia.GetCabanias().GetCantidadDeAlojamientos());
            //Console.WriteLine(agencia.GetAlojamientosConUnMinimoDeEstrellas(3).GetCantidadDeAlojamientos());
            //Console.WriteLine(agencia.GetCabaniasEntrePrecios(1000,3000).GetCantidadDeAlojamientos());

            //Usuario user1 = new Usuario(12312312, "juan","juan@gmail.com","1234",True);
            //Usuario user2 = new Usuario(23423423, "pepe","pepe@gmail.com","1234",False,True);
            //Reserva reserva1 = new Reserva(1234, new DateTime(2020, 5, 3, 15, 30, 00), new DateTime(2020, 5, 10, 15, 30, 00), hotel1, user1, hotel1.Precio());
            //Reserva reserva2 = new Reserva(2345, new DateTime(2020, 6, 13, 5, 30, 00), new DateTime(2020, 6, 20, 5, 30, 00), hotel2, user1, hotel2.Precio());
            #endregion

            #region Pruebas de ABM del archivo usuariosDePrueba.txt
            /* ~~~~~~~~~~~~ Leer archivo y convertirlo a lista de objetos ~~~~~~~~~~~~ */
            //String pathTest = "../../../Data/usuariosDePrueba.txt";
            //List<Usuario> userTest = new List<Usuario>();
            //Utils.GetDataFile(pathTest).ForEach(user => userTest.Add(Usuario.Deserializar(user)));
            //userTest.ForEach(user => Console.WriteLine(user.Serializar()));

            /* ~~~~~~~~~~~~ Eliminar un objeto de un archivo ~~~~~~~~~~~~ */
            //Usuario userToDelete = userTest.Find(user => user.GetDni() == 34534534);
            //userTest.Remove(userToDelete);
            //List<String> usersSerializados = new List<string>();
            //foreach (Usuario user in userTest)
            //{
            //    usersSerializados.Add(user.Serializar());
            //}
            //Console.WriteLine(Util.WriteInFile(pathTest, usersSerializados) ? "Eliminado" : "No se elimino");

            /* ~~~~~~~~~~~~ Modificar un objeto del archivo ~~~~~~~~~~~~ */
            //Usuario userToUpdate = userTest.Find(user => user.GetDni() == 45645645);
            //userToUpdate.SetNombre("Saul");
            //userToUpdate.SetEmail("saul@gmail.com");
            //userToUpdate.SetBloqueado(true);

            //List<String> usersSerializado = new List<string>();
            //foreach (Usuario user in userTest)
            //{
            //    Console.WriteLine(user.Serializar());
            //    usersSerializado.Add(user.Serializar());
            //}
            //Console.WriteLine(Util.WriteInFile(pathTest, usersSerializado) ? "Cambios guardados" : "Error en los cambios");
            #endregion


            /* ~~~~~~~~~~~~ Pruebas de alojamientos en la agencia con la persistencia de los datos ~~~~~~~~~~~~ */

            //Agencia agencia = new Agencia();

            /* Agregar varios alojamientos */
            //Hotel h1 = new Hotel(123, "buenos aires", "retiro", 4, 1, true, 1000);
            //new List<Alojamiento>() { hotel1, hotel2, hotel3, cabania1, cabania2, h1 }.ForEach( al => {
            //    bool flag = !agencia.ExisteAlojamiento(al) && agencia.AgregarAlojamiento(al) && agencia.GuardarCambiosEnElArchivo();
            //    Console.WriteLine((flag ? "Se agrego el alojamiento: " : "No se agrego el alojamiento: ") + al.Serializar());
            //});

            /* Eliminar alojamiento */
            //Hotel h2 = new Hotel(123, "buenos aires", "retiro", 4, 1, true, 1000);
            //bool flagH2 = agencia.ExisteAlojamiento(h2) && agencia.EliminarAlojamiento(h2) && agencia.GuardarCambiosEnElArchivo();
            //Console.WriteLine(flagH2 ? $"Alojamiento eliminado: {h2.Serializar()}" : "No se pudo eliminar");

            /* Modificar alojamiento */
            //Hotel h3 = new Hotel(123, "La plata", "Centro", 3, 2, true, 3500);
            //bool flagH3 = agencia.ExisteAlojamiento(h3) && agencia.ModificarAlojamiento(h3) && agencia.GuardarCambiosEnElArchivo();
            //Console.WriteLine(flagH3 ? "Alojamiento modificado" : "No se pudo modificar");


        }
    }
}
