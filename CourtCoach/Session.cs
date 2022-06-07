using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtCoach
{
    public abstract class Session
    {
        protected DateTime startTime;
        protected DateTime endTime;
        
        public DateTime StartTime { get { return StartTime; } }
        public DateTime EndTime { get { return EndTime; } }

        public abstract void EndSession();

        
    }
}
