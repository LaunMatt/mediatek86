using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mediatek86.model;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    public class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Absence> GetLesAbsences(int idpersonnelselect)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select d.idpersonnel as idpersonnel, d.datedebut as datedebut, d.datefin as datefin, p.idmotif as idmotif, p.libelle as nom ";
                req += "from absence d join motif p on (d.idmotif = p.idmotif) ";
                req += "order by datedebut desc;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        foreach (Object[] record in records)
                        {
                            if ((int)record[0] == idpersonnelselect)
                            {
                                Motif motif = new Motif((int)record[3], (string)record[4]);
                                Absence absence = new Absence((int)record[0], (DateTime)record[1], (DateTime)record[2], motif);
                                lesAbsences.Add(absence);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }
    }
}
