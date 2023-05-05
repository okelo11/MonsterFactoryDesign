using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IMonster 
    {
        public int Hp { get; set; }
        public int Dmg { get; set; }

        public MonsterEnum MonsterType { get; set; }


        public T GetMe<T>();


    }
}

