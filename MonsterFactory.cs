using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class MonsterFactory
    {

        private MonsterFactory()
        {

        }
        public static IMonster CreateMonster(MonsterEnum MonsterType, int Hp, int Dmg)
        {
           
            IMonster monster;
            if(MonsterType == MonsterEnum.Spider)
            {
                monster = new Spider( MonsterType,  Hp,  Dmg);
                
            }else if (MonsterType == MonsterEnum.Bee)
            {
                monster = new Bee(MonsterType, Hp, Dmg);
            }
            else
            {
                throw new Exception("Wrong entry");
            }

            return monster;
        }
    }
}
