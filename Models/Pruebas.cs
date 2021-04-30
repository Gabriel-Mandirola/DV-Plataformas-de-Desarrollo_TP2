using System;
using System.Collections.Generic;
using System.Text;

using AgenciaDeAlojamientos.Interfaces;

namespace AgenciaDeAlojamientos
{
    class Pruebas
    {
        public static void iniciar()
        {
            //var hotel1 = new Hotel(123, "buenos aires", "retiro", 4, 1, true, 1000);
            //var hotel2 = new Hotel(752, "Cordoba", "villa carlos paz", 2, 3, true, 1500);
            //var hotel3 = new Hotel(645, "Buenos aires", "puerto madero", 1, 2, false, 2000);
            //var cabania1 = new Cabania(124, "Buenos aires", "puerto madero", 3, 2, true, 2400, 2, 1);
            //var cabania2 = new Cabania(543, "La Plata", "centro", 2, 2, false, 3000, 1, 1);

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

            //Usuario user1 = new Usuario(40393222, "saul", "saul@gmail.com", "1234", true);
            //Reserva reserva1 = new Reserva(1234, new DateTime(2020, 5, 3, 15, 30, 00), new DateTime(2020, 5, 10, 15, 30, 00), hotel1, user1, hotel1.Precio());
            //Reserva reserva2 = new Reserva(2345, new DateTime(2020, 6, 13, 5, 30, 00), new DateTime(2020, 6, 20, 5, 30, 00), hotel2, user1, hotel2.Precio());


            /* ~~~~~~~~~~~~ Leer un archivo txt ~~~~~~~~~~~~ */
            //List<String> dataUsers = Utils.GetDataFile(Utils.PATH_FILE_RESERVAS);


            /* ~~~~~~~~~~~~ Pruebas de Serializacion de objetos ~~~~~~~~~~~~ */
            //Console.WriteLine(hotel1.SerializarObjeto());
            //Console.WriteLine(cabania1.SerializarObjeto());
            //Console.WriteLine(reserva1.SerializarObjeto());
            //Console.WriteLine(reserva2.SerializarObjeto());
            //Console.WriteLine(user1.SerializarObjeto());


            /* ~~~~~~~~~~~~ Pruebas de escritura de archivos ~~~~~~~~~~~~ */
            //String pathPrueba = "../../../Data/usuariosDePrueba.txt";
            //List<String> datosPrueba = new List<string>();
            //datosPrueba.Add("12312312,juan,juan@gmail.com,1234,True,False");
            //datosPrueba.Add("23423423,pepe,pepe@gmail.com,1234,False,False");
            //datosPrueba.Add("34534534,martina,martina@gmail.com,1234,True,False");
            //datosPrueba.Add("45645645,martin,martin@gmail.com,1234,False,False");
            //datosPrueba.Add("56756756,jose,jose@gmail.com,1234,False,False");
            //datosPrueba.Add("67867867,sofia,sofia@gmail.com,1234,False,False");
            //Console.WriteLine(Utils.WriteInFile(pathPrueba, datosPrueba) ? "Archivo creado y con contenido" : "Error"));



            /* ~~~~~~~~~~~~ Leer archivo y convertirlo a lista de objetos ~~~~~~~~~~~~ */
            //String pathTest = "../../../Data/usuariosDePrueba.txt";
            //List<String> userTestString = Utils.GetDataFile(pathTest);
            //List<Usuario> userTest = new List<Usuario>();
            //foreach (String row in userTestString)
            //{
            //    String[] rowToArray = Utils.StringSerializadoToArray(row);
            //    userTest.Add(Usuario.Deserializar(rowToArray));
            //}

            /* ~~~~~~~~~~~~ Eliminar un objeto de un archivo ~~~~~~~~~~~~ */
            //Usuario userToDelete = userTest.Find(user => user.GetDni() == 34534534);
            //userTest.Remove(userToDelete);
            //List<String> usersSerializados = new List<string>();
            //foreach (Usuario user in userTest)
            //{
            //    usersSerializados.Add(user.SerializarObjeto());
            //}
            //Console.WriteLine(Utils.WriteInFile(pathTest, usersSerializados) ? "Eliminado" : "No se elimino");

            /* ~~~~~~~~~~~~ Modificar un objeto del archivo ~~~~~~~~~~~~ */
            //Usuario userToUpdate = userTest.Find(user => user.GetDni() == 45645645);
            //userToUpdate.SetNombre("Saul");
            //userToUpdate.SetEmail("saul@gmail.com");
            //userToUpdate.SetBloqueado(true);

            //List<String> usersSerializado = new List<string>();
            //foreach (Usuario user in userTest)
            //{
            //    Console.WriteLine(user.SerializarObjeto());
            //    usersSerializado.Add(user.SerializarObjeto());
            //}

            //Console.WriteLine(Utils.WriteInFile(pathTest, usersSerializado) ? "Cambios guardados" : "Error en los cambios");



            /* ~~~~~~~~~~~~ Pruebas de alojamientos en la agencia con la persistencia de los datos ~~~~~~~~~~~~ */

            //Agencia agencia = new Agencia();

            /* Agregar alojamiento */
            //Hotel h1 = new Hotel(123, "buenos aires", "retiro", 4, 1, true, 1000);
            //if (!agencia.ExisteAlojamiento(h1) && agencia.AgregarAlojamiento(h1) && agencia.GuardarCambiosEnElArchivo())
            //{
            //    Console.WriteLine("Alojamiento agregado\n");
            //}
            //else
            //{
            //    Console.WriteLine("El alojamiento que desea ingresar ya existe\n");
            //}

            /* Eliminar alojamiento */
            //Hotel h2 = new Hotel(123, "buenos aires", "retiro", 4, 1, true, 1000);
            //if (agencia.ExisteAlojamiento(h2) && agencia.EliminarAlojamiento(h2) && agencia.GuardarCambiosEnElArchivo())
            //{
            //    Console.WriteLine("Alojamiento eliminado\n");
            //}
            //else
            //{
            //    Console.WriteLine("No se encontro el alojamiento de desea borrar\n");
            //}

            /* Modificar alojamiento */
            //Hotel h3 = new Hotel(123, "La plata", "Centro", 3, 2, true, 3500);
            //if (agencia.ExisteAlojamiento(h3) && agencia.ModificarAlojamiento(h3) && agencia.GuardarCambiosEnElArchivo())
            //{
            //    Console.WriteLine("Alojamiento modificado");
            //}
            //else
            //{
            //    Console.WriteLine("No existe ese alojamiento por ende no puede modificarlo");
            //}

        }
    }
}
