using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbMecenat.BO;

namespace GsbMecenat.DAL
{
    public class PaysDAO
    {

        #region Singleton
        private static PaysDAO instance;

        public static PaysDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new PaysDAO();
            }
            return instance;
        }
        #endregion Singleton

        public List<Pay> GetLesPays()
        {
            using (var ctx = new GsbMecenatEntities())
            {
                var liste = ctx.Pays
                .ToList();
                return liste;
            }
        }



    }
}
