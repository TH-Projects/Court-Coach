using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourtCoach
{
    [XmlRoot("SessionData")]
    public class SessionData
    {
        [XmlArray("Sessions")]
        [XmlArrayItem("ShootingSession", typeof(ShootingSession))]
        //[XmlArrayItem("HandlingSession", typeof(HandlingSession))] Todo!!!
        public List<Session> Sessions { get; set; }
    }
}
