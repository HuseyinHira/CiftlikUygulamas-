/****************************************************************************
// Hüseyin Hıra 2018
// Çiftlik Projem
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A_B181210105_Proje
{
    class Hayvan
    {
        public int zaman { get; set; }


        private string İsim;
        

        public int zamantut()
        {
            return zaman; 
        }
    
    }
    class Tavuk:Hayvan
    {

        private string İsim="Tavuk";


        public int TavukYumurta { get; set; }

        public int tavukYumurta()
        {
            return TavukYumurta;
        }

    }
    class Ördek : Hayvan
    {


        private string İsim="Ördek";

        public int ÖrdekYumurta { get; set; }

        public int ördekYumurta()
        {
            return ÖrdekYumurta;
        }

    }
    class İnek : Hayvan
    {
        private string İsim="İnek";

        public int İnekSüt { get; set; }

        public int inekSüt()
        {
            return İnekSüt;
        }

    }
    class Keçi : Hayvan
    {


        private string İsim="Keçi";

        public int KeçiSüt { get; set; }

        public int keçiSüt()
        {
            return KeçiSüt;
        }

    }
}
