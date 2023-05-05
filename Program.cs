// See https://aka.ms/new-console-template for more information 


using Factory;


var spider= MonsterFactory.CreateMonster(MonsterEnum.Spider, 30, 15);
var bee = MonsterFactory.CreateMonster(MonsterEnum.Bee, 20, 5);


bee.GetMe<Bee>().DmgDeal(spider.GetMe<Spider>());

