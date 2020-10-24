using System;
using System.Collections.Generic;
using System.Text;

namespace GameMain.Base
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Character
    {
        /// <summary>
        /// 职业名称
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// 生命值
        /// </summary>
        protected int Health { get; set; }

        /// <summary>
        /// 攻击力
        /// </summary>
        protected int ATK { get; set; }

        /// <summary>
        /// 防御力
        /// </summary>
        protected int DEF { get; set; }

        /// <summary>
        /// 钱
        /// </summary>
        protected int Money { get; set; }

        /// <summary>
        /// 武器
        /// </summary>
        protected Weapon weapon { get; set; }

        /// <summary>
        /// 盔甲
        /// </summary>
        protected Armor armor { get; set; }

        //药（暂用治疗术代替药水） 
        //Medicine medicine;

        public Character(int health = 2000, int atk = 0, int def = 0, int money = 500, string name = "")
        {
            Health = health; ATK = atk; DEF = def; Money = money; Name = name; weapon = new Weapon();
            armor = new Armor();
        }

        //得到角色的信息 
        public string GetName() { return Name; }

        public int GetHealth() { return Health; }

        public int GetATK() { return ATK; }

        public int GetDEF() { return DEF; }

        public int GetMoney() { return Money; }

        public Weapon GetWeapon() { return weapon; }

        public Armor GetArmor() { return armor; }

        //获得金钱，武器，装备  
        public void GetMoney(int money)
        {
            Money += money;
            Console.WriteLine($"获得了{money}金币");
        }

        public void GetWeapon(Weapon w)
        {
            Money -= w.GetPrice() - weapon.GetPrice(); //金币减少  
            ATK += w.GetATK() - weapon.GetATK(); //攻击力上升 
            weapon = w;
        }

        public void GetArmor(Armor a)
        {
            Money -= a.GetPrice() - armor.GetPrice(); //金币减少 
            DEF += a.GetDEF() - armor.GetDEF(); //防御力上升 
            armor = a;
        }

        /*void GetMedicine(Medicine m)  {  Medicine=m;  Money-=m.Price;  }*/
        //受到攻击 

        /// <summary>
        /// 受到攻击
        /// </summary>
        /// <param name="atk"></param>
        public void TakeAttack(int atk)
        {
            if (atk > DEF)
                Health = Health - atk + DEF;
            if (Health < 0)
                Health = 0;
        }

        //使用治疗术 
        /// <summary>
        /// 使用治疗术
        /// </summary>
        public void Treatment()
        {
            if ((Health + 200) <= 2000)
                Health += 200;
            else Health = 2000;
        }

        /*void TakeMedicine()  {  if((Health+medicine.value)<=2000)  Health+=medicine.value;  else  Health=2000;  }*/

        //展示角色信息  
        public void Show()
        {
            Console.WriteLine($"职业{Name}");
            Console.WriteLine($"生命值{Health}");
            Console.WriteLine($"武器{weapon.GetRank()}{weapon.GetName() }\t攻击力:{ATK}");
            Console.WriteLine($"盔甲{armor.GetRank() }{armor.GetName()}\t防御力:{DEF}");
            Console.WriteLine($"金币{Money}");
        }
    };
}

