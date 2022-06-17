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
        private static readonly DataHandler instance = new DataHandler();
        XmlSerializer sr = new XmlSerializer(typeof(SessionData));
        public static DataHandler Instance
        {
            get
            {
                return instance;
            }
        }
        public async Task SaveData(List<Session> data)
        {
            SessionData sd = new SessionData();
            sd.Sessions = data;
            var file = await getDataFile(); //bekommen xml file
            string fd;
            using (StringWriter writer = new Utf8StringWriter()) { 
                sr.Serialize(writer, sd); //serialisieren von den objekten in xml
                fd = writer.ToString();
            }
            await FileIO.WriteTextAsync(file, fd); //Schreibt in die datei
                
        }

        private async Task<StorageFile> getDataFile()
        {
            StorageFolder storage = ApplicationData.Current.RoamingFolder; //späterer Speicherplatz holen
            await Launcher.LaunchFolderAsync(storage); //Ordner Starten (Explorer geht auf)
            IStorageItem item = await storage.TryGetItemAsync("courtCoachData.xml"); // versuche element zu bekommen
            if (item == null) //wenn element nicht existiert
            {
                await storage.CreateFileAsync("courtCoachData.xml"); //datei erstellen          
            }
            return await storage.GetFileAsync("courtCoachData.xml"); //rückgabe der existierenden Datei
        }

        public async Task<List<Session>> LoadData()
        {
            var file = await getDataFile(); //bekommen xml file
            var stream = (await file.OpenReadAsync()).AsStream(); //öffnen der datei zum lesen
            try
            {
                XmlReader reader = XmlReader.Create(stream); // bauen eines xmlreaders
                 return ((SessionData)sr.Deserialize(reader)).Sessions; //deserialisieren und Rückgabe
            }
            catch
            {
                return new List<Session>();//wenn fehler rückgabe von leerer liste
            }
        }
    }
    
    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding => Encoding.UTF8;
    }
}
