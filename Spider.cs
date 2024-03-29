﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Spider : IMonster, IGetDmg
    {
        private MonsterEnum _monsterType = MonsterEnum.Spider;
        private int _hp;
        private int _dmg;

        IMonster me;


        public int Hp {get { return _hp; }set { _hp = value; } } 
        public int Dmg { get { return _dmg; } set {  _dmg=value; } }
        public MonsterEnum MonsterType { get { return _monsterType; } set { _monsterType=value; } }


        public Spider(MonsterEnum MonsterType, int Hp, int Dmg)
        {
           
            this.MonsterType = MonsterType;
            this.Hp = Hp;
            this.Dmg = Dmg;
        }
     

        public Spider GetMe<Spider>()
        {

            try
            {
                if (me == null)
                {
                    me = this;
                    return (Spider)me;

                }
                else
                {
                    return (Spider)me;
                }
                //return (Spider)Convert.ChangeType(this, this.GetType());
   
            }
            catch
            {
                throw new Exception("I want Spider class but you send me something else!");

            }

        }

    }
}
