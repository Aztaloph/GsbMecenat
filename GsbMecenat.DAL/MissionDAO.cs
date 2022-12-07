using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbMecenat.BO;

namespace GsbMecenat.DAL
{
    public class MissionDAO
    {

        #region Singleton
        private static MissionDAO instance;

        public static MissionDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new MissionDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<Mission> GetLesMissions()
        {
            using (var ctx = new GsbMecenatEntities())
            {
                var liste = ctx.Missions
                .ToList();
                return liste;
            }
        }
    }
}
