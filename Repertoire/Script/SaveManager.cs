using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.Compression;

namespace Repertoire
{
    public static class SaveManager
    {
        // Variables 

        private const string filePath = "Data.bin";

        // Fonction de sauvegarde des données Group
        public static void Save(List<Group> data)
        {
            FileStream fs = File.Create(filePath);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, data);

            fs.Close();
        }

        // Ouvrir les données 
        public static List<Group> Open()
        {
            List<Group> data = new List<Group>()
            {
                new Group("Contactée"),
                new Group("Non contactée")
            };

            if(File.Exists(filePath))
            {
                FileStream fs = null;

                try
                {
                    fs = File.OpenRead(filePath);
                    BinaryFormatter bf = new BinaryFormatter();
                    data = (List<Group>)bf.Deserialize(fs);
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    fs.Close();
                }
            }

            return data;
        }
    }
}
