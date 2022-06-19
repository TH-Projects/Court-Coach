using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourtCoach
{
    [XmlInclude(typeof(ShootingSession))]
    [XmlInclude(typeof(HandlingSession))] 
    public abstract class Session
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
  
    }
}
