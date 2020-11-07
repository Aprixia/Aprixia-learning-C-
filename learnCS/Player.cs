using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Text;

namespace learnCS
{
    class Player
    {
        public string name;
        public double money;
        public int level;
        public int exp;
        public int maxEXP;
        public int atk;
        public int def;
        public int hp;
        public int maxHP;
        
        public Player(string playerName)
        {
            name = playerName;
            money = 0;
            level = 1;
            exp = 0;
            maxEXP = 3;
            atk = 10;
            def = 10;
            hp = 100;
            maxHP = 100;
        }
    }
}
