using System;
using System.Collections.Generic;

namespace G1
{
    class Program
    {
        static void Main(string[] args)
        {
            CharacterFactory characterFactory = new CharacterFactory(); //角色产生工厂  
            Character player1; //玩家一角色 
            Character player2; //玩家二角色
            StoreManager storeManager = new StoreManager(); //商店产生工厂（决定产生哪种职业的武器和盔甲） 
            WeaponStore player1weaponStore; //玩家一武器商店
            ArmorStore player1armorStore; //玩家一盔甲商店  
            WeaponStore player2weaponStore; //玩家二武器商店  
            ArmorStore player2armorStore; //玩家二盔甲商店
            Weapon player1Weapon; //玩家一武器 
            Weapon player2Weapon; //玩家二武器  
            Armor player1Armor; //玩家一盔甲  
            Armor player2Armor; //玩家二盔甲
            var rand = new Random();

            int money; //每回合随机生成金币 
            //srand((unsigned)time(NULL));
            money = rand.Next(100) + 200; //每回合生成200到300的金币

            int flag = 0, count = 0; //用于switch的flag和记录回合数的count 
            string readLine = "";
            const int treatCD = 4; //治疗术的CD，即四个回合 
            int player1NextTreat = 1, player2NextTreat = 1; //玩家一和玩家二下次可以使用治疗术的回合

            List<string> characterFlags = new List<string> { "1", "2", "3" };
            List<string> actFlags = new List<string> { "1", "2", "3", "4" };
            List<string> actMFlags = new List<string> { "0", "1", "2", "3", "4" };

            //游戏开始  
            Console.WriteLine($"游戏开始");

            //玩家一创建角色  
            Console.WriteLine($"玩家一请选择职业：\n1.战士\t2.法师\t3.妖怪");
            while (true)
            {
                readLine = Console.ReadLine();
                if (!characterFlags.Contains(readLine))
                {
                    Console.WriteLine($"输入错误，请重新输入！");
                }
                else
                {
                    flag = Convert.ToInt32(readLine);
                    break;
                }
            }
            player1 = characterFactory.CreatCharacter(flag);
            player1weaponStore = storeManager.CreatWeaponStore(player1.Name);
            player1armorStore = storeManager.CreatArmorStore(player1.Name);


            //玩家二创建角色 
            Console.WriteLine($"玩家二请选择职业：\n1.战士\t2.法师\t3.妖怪");
            while (true)
            {
                readLine = Console.ReadLine();
                if (!characterFlags.Contains(readLine))
                {
                    Console.WriteLine($"输入错误，请重新输入！");
                    flag = Convert.ToInt32(readLine);
                }
                else break;
            }
            player2 = characterFactory.CreatCharacter(flag);
            player2weaponStore = storeManager.CreatWeaponStore(player2.Name);
            player2armorStore = storeManager.CreatArmorStore(player2.Name);

            //无限循环，直到有一方生命值下降为0  
            while (true)
            {
                count++;
                Console.WriteLine($"*************");
                Console.WriteLine($"***第{count}回合***");
                Console.WriteLine($"*************");
                //玩家一进行游戏  
                Console.WriteLine($"玩家一：");
                money = rand.Next(100) + 200;
                player1.GetMoney(money);
                player1.Show();

                while (true) //为了能退到上一级，即选择攻击或买武器等，需要这个循环 
                {
                    Console.WriteLine($"请选择操作：\n1.攻击\n2.买武器\n3.买盔甲\n4.治疗术（回复200生命值，冷却时间为四个回合）");
                    while (true)
                    {
                        readLine = Console.ReadLine();
                        if (!actFlags.Contains(readLine))
                        {
                            Console.WriteLine($"输入错误，请重新输入！");
                        }
                        else
                        {
                            flag = Convert.ToInt32(readLine);
                            break;
                        }
                    }
                    switch (flag)
                    {
                        case 1: //攻击  
                            player2.TakeAttack(player1.ATK);
                            break;
                        case 2: //买武器   
                            player1weaponStore.Show();
                            Console.WriteLine($"0.返回上一级");
                            while (true)
                            {
                                Console.WriteLine($"请选择武器");
                                readLine = Console.ReadLine();
                                if (!actMFlags.Contains(readLine))
                                {
                                    Console.WriteLine($"输入错误，请重新输入！");
                                    continue;
                                }
                                flag = Convert.ToInt32(readLine);

                                if (flag == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Weapon tempWeapon = player1weaponStore.CreatWeapon(flag);
                                    if (player1.Money < tempWeapon.Price - player1.Weapon.Price)
                                    {
                                        Console.WriteLine($"你的金币不够，请重新选择或输入0返回上一级");
                                    }
                                    else { break; }
                                }
                            }
                            if (flag == 0)
                                break;
                            player1Weapon = player1weaponStore.CreatWeapon(flag);
                            player1.GetWeapon(player1Weapon);
                            break;
                        case 3: //买盔甲
                            player1armorStore.Show();
                            Console.WriteLine($"0.返回上一级");
                            while (true)
                            {
                                Console.WriteLine($"请选择盔甲");
                                readLine = Console.ReadLine();
                                if (!actMFlags.Contains(readLine))
                                {
                                    Console.WriteLine($"输入错误，请重新输入！");
                                    continue;
                                }
                                flag = Convert.ToInt32(readLine);

                                if (flag == 0) break;
                                else
                                {
                                    Armor tempArmor = player1armorStore.CreatArmor(flag);
                                    if (player1.Money < tempArmor.Price - player1.Armor.Price)
                                    {
                                        Console.WriteLine($"你的金币不够，请重新选择或输入0返回上一级");
                                    }
                                    else { break; }
                                }
                            }
                            if (flag == 0) break;
                            player1Armor = player1armorStore.CreatArmor(flag);
                            player1.GetArmor(player1Armor);
                            break;
                        case 4: //补血  
                            if (count >= player1NextTreat) { player1.Treatment(); player1NextTreat += treatCD; }
                            else
                            {
                                Console.WriteLine($"治疗术正在冷却中，还剩{player1NextTreat - count}个回合");
                                while (true)
                                {
                                    Console.WriteLine($"0.返回上一级");
                                    if (!actMFlags.Contains(readLine))
                                    {
                                        Console.WriteLine($"输入错误，请重新输入！");
                                        continue;
                                    }
                                    flag = Convert.ToInt32(readLine);
                                    if (flag == 0)
                                        break;
                                }
                            }
                            break;
                    }
                    if (flag != 0) break;
                }  //判断输赢  
                if (player2.Health <= 0)
                {
                    Console.WriteLine($"玩家二生命值下降为0，玩家一胜利");
                    break;
                }

                //玩家二进行游戏  
                Console.WriteLine($"玩家二：");
                money = rand.Next(100) + 200;
                player2.GetMoney(money);
                player2.Show();

                while (true) //为了能退到上一级，即选择攻击或买武器等，需要这个循环 
                {
                    Console.WriteLine($"请选择操作：\n1.攻击\n2.买武器\n3.买盔甲\n4.治疗术（回复200生命值，冷却时间为四个回合）");
                    while (true)
                    {
                        readLine = Console.ReadLine();
                        if (!actFlags.Contains(readLine))
                        {
                            Console.WriteLine($"输入错误，请重新输入！");
                        }
                        else
                        {
                            flag = Convert.ToInt32(readLine);
                            break;
                        }
                    }
                    switch (flag)
                    {
                        case 1: //攻击  
                            player1.TakeAttack(player2.ATK);
                            break;
                        case 2: //买武器   
                            player2weaponStore.Show();
                            Console.WriteLine($"0.返回上一级");
                            while (true)
                            {
                                Console.WriteLine($"请选择武器");
                                readLine = Console.ReadLine();
                                if (!actMFlags.Contains(readLine))
                                {
                                    Console.WriteLine($"输入错误，请重新输入！");
                                    continue;
                                }
                                flag = Convert.ToInt32(readLine);

                                if (flag == 0)
                                {
                                    break;
                                }
                                else
                                {
                                    Weapon tempWeapon = player2weaponStore.CreatWeapon(flag);
                                    if (player2.Money < tempWeapon.Price - player2.Weapon.Price)
                                    {
                                        Console.WriteLine($"你的金币不够，请重新选择或输入0返回上一级");
                                    }
                                    else { break; }
                                }
                            }
                            if (flag == 0)
                                break;
                            player2Weapon = player2weaponStore.CreatWeapon(flag);
                            player2.GetWeapon(player2Weapon);
                            break;
                        case 3: //买盔甲
                            player2armorStore.Show();
                            Console.WriteLine($"0.返回上一级");
                            while (true)
                            {
                                Console.WriteLine($"请选择盔甲");
                                readLine = Console.ReadLine();
                                if (!actMFlags.Contains(readLine))
                                {
                                    Console.WriteLine($"输入错误，请重新输入！");
                                    continue;
                                }
                                flag = Convert.ToInt32(readLine);

                                if (flag == 0) break;
                                else
                                {
                                    Armor tempArmor = player2armorStore.CreatArmor(flag);
                                    if (player2.Money < tempArmor.Price - player2.Armor.Price)
                                    {
                                        Console.WriteLine($"你的金币不够，请重新选择或输入0返回上一级");
                                    }
                                    else { break; }
                                }
                            }
                            if (flag == 0) break;
                            player2Armor = player2armorStore.CreatArmor(flag);
                            player2.GetArmor(player2Armor);
                            break;
                        case 4: //补血  
                            if (count >= player2NextTreat) { player2.Treatment(); player2NextTreat += treatCD; }
                            else
                            {
                                Console.WriteLine($"治疗术正在冷却中，还剩{player2NextTreat - count}个回合");
                                while (true)
                                {
                                    Console.WriteLine($"0.返回上一级");
                                    if (!actMFlags.Contains(readLine))
                                    {
                                        Console.WriteLine($"输入错误，请重新输入！");
                                        continue;
                                    }
                                    flag = Convert.ToInt32(readLine);
                                    if (flag == 0)
                                        break;
                                }
                            }
                            break;
                    }
                    if (flag != 0) break;
                }  //判断输赢  
                if (player1.Health <= 0)
                {
                    Console.WriteLine($"玩家一生命值下降为0，玩家二胜利");
                    break;
                }
            }
        }
    }
}
