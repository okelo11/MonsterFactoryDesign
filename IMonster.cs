using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDenemeler
{
    public interface IMonster
    {
        public int Hp { get; set; } 
        public int Dmg { get; set; }


        public MonsterEnum MonsterType { get; set; }






        public void DmgDeal(IMonster enemyMonster) //Default Method
        {
            
            int hpRemain = enemyMonster.Hp - this.Dmg;
            enemyMonster.Hp -= this.Dmg;
            Console.WriteLine("enemy hp: "+enemyMonster.Hp+
                " \nyour dmg: "+
                Dmg+"\n"+hpRemain+ " hp remains");
            
        }


    }
}

