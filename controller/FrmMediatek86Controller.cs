using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.dal;
using mediatek86.model;

namespace mediatek86.controller
{
    /// <summary>
    /// Contrôleur de FrmMediatek86
    /// </summary>
    public class FrmMediatek86Controller
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Responsable
        /// </summary>
        private readonly PersonnelAccess personnelAccess;
        /// <summary>
        /// objet d'accès aux opérations possible sur Service
        /// </summary>
        private readonly ServiceAccess serviceAccess;
        /// <summary>
        /// objet d'accès aux opérations possibles sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// Récupère les acces aux données
        /// </summary>
        public FrmMediatek86Controller()
        {
            personnelAccess = new PersonnelAccess();
            serviceAccess = new ServiceAccess();
            absenceAccess = new AbsenceAccess();
        }

        /// <summary>
        /// Récupère et retourne les infos du personnel
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Personnel> GetLePersonnel()
        {
            return personnelAccess.GetLePersonnel();
        }

        /// <summary>
        /// Récupère et retourne les infos des services
        /// </summary>
        /// <returns>liste des profils</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Récupère et retourne les infos des absences
        /// </summary>
        /// <returns>liste des développeurs</returns>
        public List<Absence> GetLesAbsences(int idpersonnelselect)
        {
            return absenceAccess.GetLesAbsences(idpersonnelselect);
        }

        /// <summary>
        /// Demande d'ajout du personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification du personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression du personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }
    }
}
