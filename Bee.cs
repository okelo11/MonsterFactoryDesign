using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDenemeler
{
    public class Bee : IMonster
    {  

        private MonsterEnum _monsterType = MonsterEnum.Spider;
        private int _hp;
        private int _dmg;



        public int Hp { get { return _hp; } set { _hp=value; } }
        public int Dmg { get { return _dmg; } set { _dmg = value; } }
        public MonsterEnum MonsterType { get { return _monsterType; } set { _monsterType=value; } }

        public Bee(MonsterEnum MonsterType, int Hp, int Dmg)
        {
            this.MonsterType = MonsterType;
            this.Hp = Hp;
            this.Dmg = Dmg;
        }



    }
}
