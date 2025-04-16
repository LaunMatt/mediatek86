using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    /// <summary>
    /// Classe traitant l'ensemble des motifs de la base de données mediatek86 et leurs champs.
    /// </summary>
    public class Motif
    {
        public int Idmotif { get; }
        public string Libelle { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif">identifiant du motif</param>
        /// <param name="libelle">libelle du motif</param>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (juste le libelle)
        /// </summary>
        /// <returns>nom du profil</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
