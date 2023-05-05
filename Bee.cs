using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Bee : IMonster ,ICanDmg
    {
        private MonsterEnum _monsterType = MonsterEnum.Spider;
        private int _hp;
        private int _dmg;

        IMonster _me;
        

        public int Hp { get { return _hp; } set { _hp=value; } }
        public int Dmg { get { return _dmg; } set { _dmg = value; } }
        public MonsterEnum MonsterType { get { return _monsterType; } set { _monsterType=value; } }

        public int GORBENIIII { get; set; } = 4;


        public Bee(MonsterEnum MonsterType, int Hp, int Dmg)
        {  
            this.MonsterType = MonsterType;
            this.Hp = Hp;
            this.Dmg = Dmg;
        }

        public Bee GetMe<Bee>()
        {
            try
            {
                if (_me == null)
                {
                    _me = this;
                    return (Bee)_me;
                }
                else
                {
                    return (Bee)_me;
                }
                //return (Bee)Convert.ChangeType(this, this.GetType());

            }
            catch 
            {
                throw new Exception("I want Bee class but you send me something else!");

            }



        }

        public void DmgDeal(IGetDmg enemyMonster)
        {
            var enemy = (IMonster)enemyMonster;
            
            int hpRemain = enemy.Hp - this.Dmg;

            Console.WriteLine("enemy hp: " + enemy.Hp + " \nyour dmg: " + Dmg);

            enemy.Hp -= this.Dmg;

            Console.WriteLine( hpRemain + " hp remains");
        }
    }

}
