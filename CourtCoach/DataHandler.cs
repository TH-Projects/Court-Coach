using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Windows.Storage;
using Windows.System;

namespace CourtCoach
{
    public class DataHandler
    {
        private static readonly DataHandler s_instance = new DataHandler();
        XmlSerializer sr = new XmlSerializer(typeof(SessionData));
        public static DataHandler Instance
        {
            get
            {
                return s_instance;
            }
        }
        public async Task SaveData(List<Session> data)
        {
            SessionData sd = new SessionData();
            sd.Sessions = data;
            var file = await getDataFile();
            string fd;
            using (StringWriter writer = new Utf8StringWriter())
            {
                sr.Serialize(writer, sd);                                   //serialisieren von den objekten in xml
                fd = writer.ToString();
            }
            await FileIO.WriteTextAsync(file, fd);                          //Schreibt in die Datei

        }
        private async Task<StorageFile> getDataFile()
        {
            StorageFolder storage = ApplicationData.Current.RoamingFolder;  //Speicherplatz holen/festlegen
            //await Launcher.LaunchFolderAsync(storage);                    //Debugging Zeile
            IStorageItem item = await storage.TryGetItemAsync("courtCoachData.xml"); //Versuche element zu bekommen
            if (item == null)                                               //wenn Datei nicht vorhanden
            {
                await storage.CreateFileAsync("courtCoachData.xml");        //neue Datei erstellen          
            }
            return await storage.GetFileAsync("courtCoachData.xml");        //Rückgabe der existierenden Datei
        }
        public async Task<List<Session>> LoadData()
        {
            var file = await getDataFile();
            var stream = (await file.OpenReadAsync()).AsStream();           //öffnen der Datei zum lesen
            try
            {
                XmlReader reader = XmlReader.Create(stream);                //Xml-reader für Datei erstellen
                return ((SessionData)sr.Deserialize(reader)).Sessions;      //deserialisieren und Rückgabe
            }
            catch
            {
                return new List<Session>();                                 //wenn Fehler Rückgabe von leerer Liste
            }
        }
    }

    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
