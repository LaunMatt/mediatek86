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
    /// Contrôleur de FrmConnexion
    /// </summary>
    class FrmConnexionController
    {
        /// <summary>
        /// objet d'accès aux opérations possibles sur Developpeur
        /// </summary>
        private readonly ResponsableAccess responsableAccess;

        /// <summary>
        /// Récupère l'acces aux données
        /// </summary>
        public FrmConnexionController()
        {
            responsableAccess = new ResponsableAccess();
        }

        /// <summary>
        /// Vérifie l'authentification
        /// </summary>
        /// <param name="responsable">objet contenant les informations de connexion</param>
        /// <returns> vrai si les informations de connexion sont correctes</returns>
        public Boolean ControleConnexion(Responsable responsable)
        {
            return responsableAccess.ControleConnexion(responsable);
        }
    }
}
