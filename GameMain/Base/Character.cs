using GameMain.Enums;
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
        //public EventHandler
        public delegate void InfoChangedEventHandler(Model model);
        public event InfoChangedEventHandler InfoChanged;

        protected string _name;
        /// <summary>
        /// 职业名称
        /// </summary>
        public string Name { get { return _name; } set { _name = value; ShowInfo(); } }

        protected CharacterRoleEnum _role;
        public CharacterRoleEnum Role { get { return _role; } set { _role = value; ShowInfo(); } }
        public string RoleName { get { return _role.ToDescription(); } }

        protected int _health;
        /// <summary>
        /// 生命值
        /// </summary>
        public int Health { get { return _health; } set { _health = value; ShowInfo(); } }

        protected int _atk;
        /// <summary>
        /// 攻击力
        /// </summary>
        public int ATK { get { return _atk; } set { _atk = value; ShowInfo(); } }

        protected int _def;
        /// <summary>
        /// 防御力
        /// </summary>
        public int DEF { get { return _def; } set { _def = value; ShowInfo(); } }

        protected int _money;
        /// <summary>
        /// 钱
        /// </summary>
        public int Money { get { return _money; } set { _money = value; ShowInfo(); } }

        protected Weapon _weapon;
        /// <summary>
        /// 武器
        /// </summary>
        public Weapon Weapon { get { return _weapon; } set { _weapon = value; ShowInfo(); } }

        //protected WeaponStore _weaponStore;
        /// <summary>
        /// 武器商店
        /// </summary>
        public WeaponStore WeaponStore { get; set; }


        protected Armor _armor;
        /// <summary>
        /// 盔甲
        /// </summary>
        public Armor Armor { get { return _armor; } set { _armor = value; ShowInfo(); } }

        //protected ArmorStore _armorStore;
        /// <summary>
        /// 盔甲商店
        /// </summary>
        public ArmorStore ArmorStore { get; set; }

        //药（暂用治疗术代替药水） 
        //Medicine medicine;

        public Character(int health = 2000, int atk = 0, int def = 0, int money = 500, string name = "无")
        {
            Name = name;
            Money = money;
            Health = health;
            ATK = atk;
            DEF = def;
            Weapon = new Weapon();
            Armor = new Armor();
        }

        public void GetRole(Character character)
        {
            this.Fill(character);
        }

        //获得金钱，武器，装备  
        public void GetMoney(int money)
        {
            Money += money;
            Console.WriteLine($"获得了{money}金币");
        }

        public void GetEquip(Equip equip)
        {
            if (equip is Weapon)
            {
                GetWeapon(equip as Weapon);
            }
            else if (equip is Armor)
            {
                GetArmor(equip as Armor);
            }
        }

        private void GetWeapon(Weapon weapon)
        {
            Money -= weapon.Price - Weapon.Price; //金币减少  
            ATK += weapon.ATK - Weapon.ATK; //攻击力上升 
            Weapon = weapon;
        }

        private void GetArmor(Armor armor)
        {
            Money -= armor.Price - Armor.Price; //金币减少 
            DEF += armor.DEF - Armor.DEF; //防御力上升 
            Armor = armor;
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
                Health = _health - atk + DEF;
            if (Health < 0)
                Health = 0;
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
        public void ShowInfo()
        {
            if (InfoChanged != null)
            {
                string r1 = Label("职业", Name);

                string userInfo = Label("职业", Name) + Label("金币", Money) + "\r\n" +
                                  Label("生命值", Health) + "\r\n" +
                                  Label("武器", Weapon?.FullName) + Label("攻击力", ATK) +
                                  Label("盔甲", Armor?.FullName) + Label("防御力", DEF) + "\r\n";

                InfoChanged(new Model() { User = userInfo });
            }
        }

        private string Label(string text, object value)
        {
            string valueStr = value?.ToString();
            string label = (text + ":").PadRight(8 - text.CNCharCount())
                           + valueStr.PadRight(12 - valueStr.CNCharCount());
            return label.PadRight(20 - label.CNCharCount());
        }
    };
}

