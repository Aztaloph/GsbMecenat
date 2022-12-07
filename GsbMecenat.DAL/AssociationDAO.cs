using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbMecenat.BO;

namespace GsbMecenat.DAL
{
    public class AssociationDAO
    {
        #region Singleton
        private static AssociationDAO instance;

        public static AssociationDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new AssociationDAO();
            }
            return instance;
        }
        #endregion Singleton

        



        public int AjouterAssociation(Association p)
        {
            using (var ctx = new GsbMecenatEntities())
            {
                try
                {
                    ctx.sp_association_add(p.Nom, p.Responsable, p.CodeISOPays, p.IdMission);
                    return 0;
                }
                catch
                {
                    return -1;
                }

            }
        }

        public int ModifierAssociation(Association p)
        {
            using (var ctx = new GsbMecenatEntities())
            {
                try
                {
                    ctx.sp_association_update(p.Id, p.Nom, p.Responsable, p.CodeISOPays, p.IdMission);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }

        public int SupprimerAssociation(Association p)
        {
            using (var ctx = new GsbMecenatEntities())
            {
                try
                {
                    ctx.sp_association_delete(p.Id);
                    return 0;
                }
                catch
                {
                    return -1;
                }
            }
        }
    }
}
