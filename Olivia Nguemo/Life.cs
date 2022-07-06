using System;

/**
 * This Class manages the Player's Life and all the possible methods.
 */
namespace consoleApp1
{
	public class Life
	{

		//Starting Life Points.
		private int MAX_LIFE_POINTS = 50;
		private int lifePoints { get; }

		public Life()
		{
			this.lifePoints = MAX_LIFE_POINTS;
		}


		public int getMaxLifePoints() => MAX_LIFE_POINTS;

		public void setMaxLifePoints(int lifeP) => MAX_LIFE_POINTS = lifeP;

		public void setLifePoints(int newlifePoints)
		{
			if (checkLifePoints(newlifePoints))
			{
				lifePoints = newlifePoints;
			}
			else
			{
				lifePoints = MAX_LIFE_POINTS;
			}
		}


		private boolean checkLifePoints(final int lifePoints) => lifePoints < MAX_LIFE_POINTS;


		public void resetLife() => lifePoints = getMaxLifePoints();


		public boolean isAlive() =>  this.lifePoints > 0;
	}
}
