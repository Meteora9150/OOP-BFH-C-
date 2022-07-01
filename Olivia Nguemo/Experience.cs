using System;

namespace ConsoleApp1
{

    public class Experience {
        
        private readonly int MAX_EXP_POINTS = 50;
        private int DEFAULT_EXP_POINTS = 0;
        private int level = 1;
        private int expPoints { get; set; }

        public Experience() {
            expPoints=DEFAULT_EXP_POINTS;
        }

        public int GetLevel()=> level;	
  
        public boolean AddLevel() {
            if(checkLevel()) {
                return true;		
            }
            else {
                return false;
            }
        }
        
        public void IncreaseLevel()=>level = getLevel() +1;

        private boolean CheckLevel() {
            if(expPoints >= MAX_EXP_POINTS * level) {		
                return true;
            }
            else {
                return false;
            }
        } 

        public void GainExp(int exp) { 
            expPoints += exp;
            addLevel();	
        }
    }
}
