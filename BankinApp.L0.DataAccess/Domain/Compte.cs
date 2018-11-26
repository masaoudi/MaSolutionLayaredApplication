using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankinApp.L0.DataAccess.Domain
{
    public class Compte
    {
        public string Numero { get; set; }
        public string Proprietaire { get; set; }
        public decimal Solde { get; set; }
        public override string ToString() => $"Compte : {Numero} - De: {Proprietaire} - Solde: {Solde}";

        // override object.Equals
        public override bool Equals(object obj)
        {
           
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var converti = obj as Compte; 

            return this.Numero.Equals(converti.Numero) &&
                   this.Proprietaire.Equals(converti.Proprietaire) &&
                   this.Solde.Equals(converti.Solde);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {

            return Numero.GetHashCode();
        }

    }
}
