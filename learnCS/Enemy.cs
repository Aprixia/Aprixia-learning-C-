using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace learnCS
{
    class Enemy
    {
        public string name;
        public int level;
        public int atk;
        public int def;
        public int hp;
        public int maxHP;
        public int moneyReward;

        public Enemy(string enemyName, int enemyLevel, int enemyATK, int enemyDEF, int enemyHP, int enemyMaxHP, int enemyReward)
        {
            name = enemyName;
            level = enemyLevel;
            atk = enemyATK;
            def = enemyDEF;
            hp = enemyHP;
            maxHP = enemyMaxHP;
            moneyReward = enemyReward;
        }
    }
}
