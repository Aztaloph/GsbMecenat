using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GsbMecenat.BO;
using GsbMecenat.DAL;

namespace GsbMecenat.BLL
{
    public class AssociationManager
    {

        #region Singleton
        private static AssociationManager instance;
        public static AssociationManager GetInstance()
        {
            if (instance == null)
            {
                instance = new AssociationManager();
            }
            return instance;
        }
        #endregion Singleton

        public int AjouterAssociation(string nom, string Responsable, string CodeISOPays, int IdMission)
        {
            Association p = new Association();
            p.Nom = nom;
            p.Responsable = Responsable;
            p.CodeISOPays = CodeISOPays;
            p.IdMission = IdMission;
            return AssociationDAO.GetInstance().AjouterAssociation(p);
        }

        

        public int ModifierAssociation(Association p)
        {
            return AssociationDAO.GetInstance().ModifierAssociation(p);
        }

        public int SupprimerProduit(Association p)
        {

            return AssociationDAO.GetInstance().SupprimerAssociation(p);
        }

    }
}
