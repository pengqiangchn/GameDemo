﻿using GameMain.Enums;
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
    public abstract class Character
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

        private void ShowInfo()
        {
            if (InfoChanged != null)
            {
                Model model = GetModel();
                //string r1 = Label("职业", Name);

                //string userInfo = Label("职业", Name) + Label("金币", Money) + "\r\n" +
                //                  Label("生命值", Health) + "\r\n" +
                //                  Label("武器", Weapon?.FullName) + Label("攻击力", ATK) +
                //                  Label("盔甲", Armor?.FullName) + Label("防御力", DEF) + "\r\n";

                InfoChanged(model);
            }
        }

        protected virtual Model GetModel()
        {
            return new Model();
        }

        protected string Label(string text, object value)
        {
            string valueStr = value?.ToString();
            string label = (text + ":").PadRight(8 - text.CNCharCount())
                           + valueStr.PadRight(12 - valueStr.CNCharCount());
            return label.PadRight(20 - label.CNCharCount());
        }

    };
}

