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
        swim = true;
        }
        public Duck(bool _fly, bool _swim)
        {
            if (_fly && !_swim || !_fly && _swim) {
                fly = _fly;
                swim = _swim;
            }
            else {
                Console.WriteLine("Invalid input data");
            }
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
        public void quack()
        {
            Console.WriteLine("QUYAAAA!!!");
        }
    }
}
