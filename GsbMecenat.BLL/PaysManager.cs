using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbMecenat.BO;
using GsbMecenat.DAL;

namespace GsbMecenat.BLL
{
    public class PaysManager
    {
        #region Singleton
        private static PaysManager instance;
        public static PaysManager GetInstance()
        {
            if (instance == null)
            {
                instance = new PaysManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<Pay> GetLesPays()
        {
            return PaysDAO.GetInstance().GetLesPays();
        }
    }
}
