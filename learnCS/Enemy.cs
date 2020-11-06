using System;
using System.Collections.Generic;
using System.Text;

namespace learnCS
{
    class Enemy
    {
        public string name;
        public int level;
        public int atk;
        public int def;

        public Enemy(string enemyName, int enemyLevel, int enemyATK, int enemyDEF)
        {
            name = enemyName;
            level = enemyLevel;
            atk = enemyATK;
            def = enemyDEF;
        }
    }
}
