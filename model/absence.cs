using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.model
{
    /// <summary>
    /// Package model
    /// </summary>
    internal class NamespaceDoc
    {

    }
    /// <summary>
    /// Classe traitant l'ensemble des absences de la base de données mediatek86 et leurs champs.
    /// </summary>
    public class Absence
    {
        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel">identifiant du personnel de l'absence</param>
        /// <param name="datedebut">date de début de l'absence</param>
        /// <param name="datefin">date de fin de l'absence</param>
        /// <param name="motif">motif de l'absence</param>
        public Absence(int idpersonnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Idpersonnel = idpersonnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }

        public int Idpersonnel { get; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Motif Motif { get; set; }
    }
}
