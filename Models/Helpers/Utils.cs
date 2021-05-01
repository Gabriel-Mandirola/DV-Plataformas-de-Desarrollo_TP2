using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AgenciaDeAlojamientos.Helpers
{
    internal class Utils
    {
        public static String[] StringToArray(String str)
        {
            return str.Split(",");
        }

        // Return List<String> | null
        public static List<String> GetDataFile(String pathFile)
        {
            List<String> data = new List<string>();
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(pathFile);

                //Read the first line of text
                String line = sr.ReadLine();

                while (line != null)
                {
                    // Guardo en la lista
                    data.Add(line);
                    // Proxima linea
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return data;
        }

        // Sobre escribe el contenido anterior
        public static bool WriteInFile(String pathFile, List<String> contenidoDelArchivo )
        {
            try
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter(pathFile);
                
                foreach (String fila in contenidoDelArchivo)
                {
                    sw.WriteLine(fila);
                }

                //Close the file
                sw.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return false;
            }
        }

    }
}
