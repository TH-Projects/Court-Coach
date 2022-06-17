using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CourtCoach
{
    [XmlRoot(ElementName = "ShootingSession")]
    public class ShootingSession : Session
    {
        private int _twoPointAttempts = 0;
        private int _freethrowAttempts = 0;
        private int _threePointAttempts = 0;
        private int _twoPointHits = 0;
        private int _freethrowHits = 0;
        private int _threePointHits = 0;
        

        public int TwoPointAttempts { get { return _twoPointAttempts; } set { _twoPointAttempts = value; } }
        public int FreethrowAttempts { get { return _freethrowAttempts; } set { _freethrowAttempts = value; } }
        public int ThreePointAttempts { get { return _threePointAttempts; } set { _threePointAttempts = value; } }
        public int TwoPointHits { get { return _twoPointHits; } set { _twoPointHits = value; } }
        public int FreethrowHits { get { return _freethrowHits; } set { _freethrowHits = value; } }
        public int ThreePointHits { get { return _threePointHits; } set { _threePointHits = value; } }
        public ShootingSession()
        {
            StartTime = DateTime.Now;
        }

        
    }
}
