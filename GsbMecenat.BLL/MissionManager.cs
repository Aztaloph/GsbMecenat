using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbMecenat.BO;
using GsbMecenat.DAL;

namespace GsbMecenat.BLL
{
    public class MissionManager
    {
        #region Singleton
        private static MissionManager instance;
        public static MissionManager GetInstance()
        {
            if (instance == null)
            {
                instance = new MissionManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<Mission> GetLesMissions()
        {
            return MissionDAO.GetInstance().GetLesMissions();
        }
    }
}
