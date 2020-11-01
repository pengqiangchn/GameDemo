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
    public class Player : Character
    {

        public Player(int health = 2000, int atk = 0, int def = 0, int money = 500, string name = "无")
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

        protected override Model GetModel()
        {
            string userInfo = Label("职业", Name) + Label("金币", Money) + "\r\n" +
                              Label("生命值", Health) + "\r\n" +
                              Label("武器", Weapon?.FullName) + Label("攻击力", ATK) +
                              Label("盔甲", Armor?.FullName) + Label("防御力", DEF) + "\r\n";

            return new Model() { User = userInfo };
        }
    };
}

