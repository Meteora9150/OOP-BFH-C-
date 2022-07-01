using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    class Enemy
    {

        Dictionary<int, Pair> enemyposWithID = new Dictionary<int, Pair>();
        List<int> skipenemy = new List<int>();

        private const int GRID_SIZE = 15;

        Pair pos = new Pair(0,0);

        private readonly int ID = 0;

        private int x = 0;
        private int y { get; set; }
        private int HP { get; set; }
        private int def { get; set; }
        private int atk { get; set; }
        private int exp  { get; set; }
        private int Gold { get; set; }
        private int HeroEXP = 700; 
        // per evitare di rifare tutto Hero si suppone abbia 700 exp
        //HeroExp = HeroExp.getCurrentMAX_EXP();

        Random rand = new Random();

        public Enemy(int id)
        {

            ID = id;
            int value = rand.Next(10) + 1;

            // i valori sono arbitrari
            HP = (5 + value + (HeroEXP / (15 * 5)));
            def = (1 + value / 2 + (HeroEXP / (20 * 8)));
            atk = (1 + value / 3 + (HeroEXP / (10 * 10)));
            exp = (20 + value * 2 + (HeroEXP / (15 * 6)));
            Gold = rand.Next(15) + 10;

            generate_pos();
        }

        private void generate_pos()
        {
            Boolean ok = false;
            while (!ok)
            {
                x = rand.Next(GRID_SIZE);
                y = rand.Next(GRID_SIZE);
                pos = new Pair(x, y);
                // si suppone che la generazione delle posizioni sia sempre coretta 
                enemyposWithID.Add(ID,pos);
                ok = true;
                
            }
        }

        public String toString()
        {
            String s = "HP = " + this.HP + " atk = " + this.atk + " def = " + this.def + " exp = " + this.exp;
            return s;
        }

        private void SetHP(int damage)
        {

           HP =- damage;
           Console.WriteLine("Enemy ID : " + this.ID + " HP Remaining = " + HP);
            if (HP <= 0)
            {
               /* Hero.GainExp(this.getEXP());
                Hero.GainGold(this.Gold); */
                Death();
            }
        }

        public void GetHit(int hero_ATK)
        {
            Console.WriteLine("getting hit by counter BY " + (hero_ATK - def) + " Damage");
            SetHP(hero_ATK - def);

        }

        private void Death()
        {
            Console.WriteLine("ENEMY " + this.ID + " has died");
            exp=0;
            Gold=0;
            skipenemy.Add(ID);
        }

    }
}
