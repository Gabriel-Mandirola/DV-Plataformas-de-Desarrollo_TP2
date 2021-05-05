using System;
using System.Collections.Generic;
using System.Text;

using AgenciaDeAlojamientos.Helpers;
using AgenciaDeAlojamientos.Models;

namespace AgenciaDeAlojamientos.Pruebas
{
    public class PruebasClaseAgencia
    {
        public static void iniciar()
        {
            //var hotel1 = new Hotel(863, "buenos aires", "retiro", 4, 1, true, 1000);
            //var hotel2 = new Hotel(752, "Cordoba", "villa carlos paz", 2, 3, true, 1500);
            //var hotel3 = new Hotel(645, "Buenos aires", "puerto madero", 1, 2, false, 2000);
            //var cabania1 = new Cabania(334, "Buenos aires", "puerto madero", 3, 2, true, 2400, 2, 1);
            //var cabania2 = new Cabania(543, "La Plata", "centro", 2, 2, false, 3000, 1, 1);


            #region Pruebas de los metodos de la clase Agencia

            // TODO: Probar los metodos agregados en la clase Agencia:
            
            #endregion

            #region prueba CRUD de alojamientos con Agencia
            List<String> pathUser = Utils.GetDataFile(Config.PATH_FILE_ALOJAMIENTOS);
            Agencia agencia = new Agencia();

            /* READ */
            //agencia.GetAlojamientos().ForEach(alojamiento => Console.WriteLine(alojamiento));

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
            //    if (agencia.EliminarAlojamiento(al.GetCodigo()))
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
            //if (!agencia.ExisteAlojamiento(alojamiento))
            //{
            //    Console.WriteLine("No existe ese alojamientos");
            //}
            //else
            //{
            //    Console.WriteLine("El alojamiento si existe (fue encontrado)");
            //    if (agencia.ModificarAlojamiento(alojamiento))
            //    {
            //        Console.WriteLine("EL alojamiento fue modificado de la lista de alojamientos");
            //        if (agencia.GuardarCambiosEnElArchivo())
            //        {
            //            Console.WriteLine("Los cambios fueron guardados en el archivo de alojamientos.txt");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No se pudieron guardar los alojamientos");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("No se pudo modificadar de la lista de alojamientos");
            //    }
            //}
            #endregion

        }
    }
}
