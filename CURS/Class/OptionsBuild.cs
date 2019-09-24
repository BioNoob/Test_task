using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURS.Class
{

    public struct OptionsBuild
    {
        private bool _nominality;
        public OptionsBuild(bool nom)
        {
            _nominality = nom;
        }
        public bool nominal
        {
            get { return _nominality; }
            set { _nominality = value; }
        }
        public static OptionsBuild Default
        {
            get
            {
                return new OptionsBuild(false);
            }
        }
    }


}
