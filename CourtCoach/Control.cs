using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtCoach
{
    public sealed class Control
    {
        private static readonly Control instance = new Control();
        private MainPage mainPage;
        private List<Session> sessions = new List<Session>();
        private ShootingSession _current;
    
        public static Control Instance
        {
            get
            {   
               return instance;
            }
        }
        public Control()
        {
            mainPage = MainPage.Instance;
        }

        public void Navigate(Type page)
        {
            mainPage.NavigateTo(page);
        }

        public void AddShootingSession()
        {
            ShootingSession cur = new ShootingSession();
            _current = cur;
            sessions.Add(cur);
        }

        public void EndShootingSession()
        {

        }

        public void incCounter(string kind, bool hit)
        {
            switch (kind)
            {
                case "free":
                    if (hit)
                        _current.FreethrowHits++;
                    _current.FreethrowAttempts++;
                    break;
                case "two":
                    if (hit)
                        _current.TwoPointHits++;
                    _current.TwoPointAttempts++;
                    break;
                case "three":
                    if (hit)
                        _current.ThreePointHits++;
                    _current.ThreePointAttempts++;
                    break;
            }
        }

        public int GetRate(string v)
        {
            switch (v)
            {
                case "FA":
                    return _current.FreethrowAttempts;
                case "FH":
                    return _current.FreethrowHits;
                case "2A":
                    return _current.TwoPointAttempts;
                case "2H":
                    return _current.TwoPointHits;
                case "3A":
                    return _current.ThreePointAttempts;
                case "3H":
                    return _current.ThreePointHits;
                default:
                    return 0;

            }
        }
    }
}
