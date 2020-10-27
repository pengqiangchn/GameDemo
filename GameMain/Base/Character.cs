using GameMain.Qeuips.Armors;
using GameMain.Qeuips.Weapons;
using GameMain.Stores.Armors;
using GameMain.Stores.Weapons;
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
        protected string _name;
        /// <summary>
        /// 职业名称
        /// </summary>
        public string Name { get { return _name; } }

        protected int _health;
        /// <summary>
        /// 生命值
        /// </summary>
        public int Health { get { return _health; } }

        protected int _atk;
        /// <summary>
        /// 攻击力
        /// </summary>
        public int ATK { get { return _atk; } }

        protected int _def;
        /// <summary>
        /// 防御力
        /// </summary>
        public int DEF { get { return _def; } }

        protected int _money;
        /// <summary>
        /// 钱
        /// </summary>
        public int Money { get { return _money; } }

        protected Weapon _weapon;
        /// <summary>
        /// 武器
        /// </summary>
        public Weapon Weapon { get { return _weapon; } }

        //protected WeaponStore _weaponStore;
        /// <summary>
        /// 武器商店
        /// </summary>
        public WeaponStore WeaponStore { get; set; }


        protected Armor _armor;
        /// <summary>
        /// 盔甲
        /// </summary>
        public Armor Armor { get { return _armor; } }

        //protected ArmorStore _armorStore;
        /// <summary>
        /// 盔甲商店
        /// </summary>
        public ArmorStore ArmorStore { get; set; }

        //药（暂用治疗术代替药水） 
        //Medicine medicine;

        public Character(int health = 2000, int atk = 0, int def = 0, int money = 500, string name = "")
        {
            _health = health;
            _atk = atk;
            _def = def;
            _money = money;
            _name = name;
            _weapon = new Weapon();
            _armor = new Armor();
        }

        //获得金钱，武器，装备  
        public void GetMoney(int money)
        {
            _money += money;
            Console.WriteLine($"获得了{money}金币");
        }

        public void GetWeapon(Weapon weapon)
        {
            _money -= weapon.Price - Weapon.Price; //金币减少  
            _atk += weapon.ATK - Weapon.ATK; //攻击力上升 
            _weapon = weapon;
        }

        public void GetArmor(Armor armor)
        {
            _money -= armor.Price - Armor.Price; //金币减少 
            _def += armor.DEF - Armor.DEF; //防御力上升 
            _armor = armor;
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
                _health = _health - atk + DEF;
            if (_health < 0)
                _health = 0;
        }

        ////使用治疗术 
        ///// <summary>
        ///// 使用治疗术
        ///// </summary>
        //public void Treatment()
        //{
        //    if ((_health + 200) <= 2000)
        //        _health += 200;
        //    else _health = 2000;
        //}

        /*void TakeMedicine()  {  if((Health+medicine.value)<=2000)  Health+=medicine.value;  else  Health=2000;  }*/

        //展示角色信息  
        public void Show()
        {
            //Console.WriteLine($"职业{Name}");
            //Console.WriteLine($"生命值{Health}");
            //Console.WriteLine($"武器{weapon.GetRank()}{weapon.Name }\t攻击力:{ATK}");
            //Console.WriteLine($"盔甲{armor.GetRank() }{armor.Name}\t防御力:{DEF}");
            //Console.WriteLine($"金币{Money}");
        }
    };
}

