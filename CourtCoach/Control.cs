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
        private List<Session> sessions = new List<Session>();
        private List<ShootingSession> shootingSessions= new List<ShootingSession>();
        private List<HandlingSession> handlingSessions = new List<HandlingSession>();
        private MainPage _mainPage;
        private ShootingSession _current;
        private DataHandler _dataHandler;
        private string statsType;
        private int currentStatsPageNum = 0;
        
    
        public static Control Instance
        {
            get
            {   
               return instance;
            }
        }
        
        public string StatsType { get { return statsType; } set { statsType = value; } }

        public int CurrentStatsPageNum { get { return currentStatsPageNum; } set { currentStatsPageNum = value; } }

        public List<ShootingSession> ShootingSessions { get { return shootingSessions; } }
        public Control()
        {
            _mainPage = MainPage.Instance;
            _dataHandler = DataHandler.Instance;
            
        }

        public void Navigate(Type page)
        {
            _mainPage.NavigateTo(page);
            
        }
        public async Task LoadSessionData()
        {
            sessions = await _dataHandler.LoadData();
        }

        public void AddShootingSession()
        {
            ShootingSession cur = new ShootingSession();
            _current = cur;
            sessions.Add(cur);
        }

        public void GetShootingValues(ShootingStatsTable table)
        {
            table.TwoPointAttempts = shootingSessions[currentStatsPageNum].TwoPointAttempts;
            table.TwoPointHits = shootingSessions[currentStatsPageNum].TwoPointHits;
            table.ThreePointAttempts = shootingSessions[currentStatsPageNum].ThreePointAttempts;
            table.ThreePointHits = shootingSessions[currentStatsPageNum].ThreePointHits;
            table.FreethrowAttempts = shootingSessions[currentStatsPageNum].FreethrowAttempts;
            table.FreethrowHits = shootingSessions[currentStatsPageNum].FreethrowHits;
        }

        public void EndShootingSession()
        {
            _current.EndTime = DateTime.Now;
            _dataHandler.SaveData(sessions);
            _current = null;
        }

        public void SplitSessionList()
        {
            shootingSessions.Clear();
            handlingSessions.Clear();

            foreach(Session session in sessions)
            {
                if (session.GetType() == typeof(ShootingSession))
                {
                    shootingSessions.Add(session as ShootingSession);
                }
                else if(session.GetType() == typeof(HandlingSession))
                {
                    handlingSessions.Add(session as HandlingSession);
                }
                else
                {
                    throw new Exception();
                }
            }
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
