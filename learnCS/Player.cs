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
        public int atk;
        public int def;
        
        public Player(string playerName)
        {
            name = playerName;
            money = 0;
            level = 1;
            exp = 0;
            atk = 10;
            def = 10;
        }
    }
}
