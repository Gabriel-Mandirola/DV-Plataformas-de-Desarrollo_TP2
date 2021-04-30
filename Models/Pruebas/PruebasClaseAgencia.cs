using System;
using System.Collections.Generic;
using System.Text;

using AgenciaDeAlojamientos.Helpers;

namespace AgenciaDeAlojamientos.Pruebas
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


            #region prueba CRUD de alojamientos con Agencia
            //List<AgenciaDeAlojamientos> pathUser = Utils.GetDataFile(Config.PATH_FILE_ALOJAMIENTOS);
            Agencia agencia = new Agencia();

            /* CREATE */
            //if (agencia.ExisteAlojamiento(new Hotel(999893, "La plata", "Centro", 3, 2, true, 3500)))
            //{
            //    Console.WriteLine("El alojamiento ya existe");
            //}
            //else
            //{
            //    Console.WriteLine("No se encontro el alojamiento");
            //    if (agencia.AgregarAlojamiento(new Hotel(999893, "La plata", "Centro", 3, 2, true, 3500)))
            //    {
            //        Console.WriteLine("Alojamiento agregado a la lista de alojamientos");
            //        if (agencia.GuardarCambiosEnElArchivo())
            //        {
            //            Console.WriteLine("Los cambios fueron guardados en el archivo");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No se pudo guardar el alojamiento en el archivo");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se pudo agregar el alojamietno a la lista");
            //    }
            //}

            /* DELETE */
            //Alojamiento al = new Hotel(999893, "La plata", "Centro", 3, 2, true, 3500);
            //if (!agencia.ExisteAlojamiento(al))
            //{
            //    Console.WriteLine("No existe el alojamiento");
            //}
            //else
            //{
            //    Console.WriteLine("Alojamiento encontrado");
            //    if (agencia.EliminarAlojamiento(al))
            //    {
            //        Console.WriteLine("Alojamiento eliminado de la lista de alojamientos");
            //        if (agencia.GuardarCambiosEnElArchivo())
            //        {
            //            Console.WriteLine("Cambios guardados en el archivo");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No se pudieron guardar los cambios");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("El alojamiento no se pudo eliminar");
            //    }
            //}

            /* UPDATE */
            //Alojamiento alojamiento = new Cabania(543, "La Plata", "Centro", 3, 2, true, 4000, 1, 1);
            //if (!agencia.ExisteAlojamiento(alojamiento)){
            //    Console.WriteLine("No existe ese alojamientos");
            //}
            //else
            //{
            //    Console.WriteLine("Alojamiento modificado en alojamientos de la clase Agencia");
            //    agencia.ModificarAlojamiento(alojamiento);
            //    if (agencia.GuardarCambiosEnElArchivo())
            //    {
            //        Console.WriteLine("Los cambios fueron guardados en el archivo de alojamientos.txt");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se pudieron guardar los alojamientos");
            //    }
            //}


            #endregion
        }
    }
}
