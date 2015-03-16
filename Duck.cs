using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject {
    class Duck {
        bool fly;
        bool swim;
        public Duck()
        {
        fly = false;
        swim = false;
        }
        public Duck(bool fly, bool swim)
        {
        }
        sealed public void fly()
        {
            fly = true;
            swim = false;
        }
        public void swim()
        {
            fly = false;
            swim = true;
        }
        public void 
    }
}
