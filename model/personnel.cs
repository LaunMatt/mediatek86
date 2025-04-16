using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    /// <summary>
    /// Classe traitant l'ensemble du personnel de la base de données mediatek86 et ses champs.
    /// </summary>
    public class Personnel
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel">identifiant du personnel</param>
        /// <param name="nom">nom du personnel</param>
        /// <param name="prenom">prénom du personnel</param>
        /// <param name="tel">téléphone du personnel</param>
        /// <param name="mail">mail du personnel</param>
        /// <param name="service">service du personnel</param>
        public Personnel(int idpersonnel, string nom, string prenom, string tel, string mail, Service service)
        {
            this.Idpersonnel = idpersonnel;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Tel = tel;
            this.Mail = mail;
            this.Service = service;
        }

        public int Idpersonnel { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public Service Service { get; set; }
    }
}
