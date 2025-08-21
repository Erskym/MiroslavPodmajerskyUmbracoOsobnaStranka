using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiroslavPodmajerskyUmbracoOsobnaStranka.lib.Models
{
    public class VzdelanieModel
    {
        public string ZakladnaSkola;
        public string StrednaSkola;
        public string VysokaSkola;

        public Kurzy ZoznamKurzov;

        public VzdelanieModel()
        {
            ZoznamKurzov = new Kurzy();
        }
    }
}
