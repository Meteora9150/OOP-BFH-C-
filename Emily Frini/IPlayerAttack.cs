namespace FriniC-Sharp
{
	public interface IPlayerAttack
{

		void Attack(Enemy enemy);

		int GetAttackPoints();

		void SetAttackPoints(int newAttackPoints);

		void GetHit(int enemyID, int enemyResponseHit);

		void IncreaseAtt();
	}
}
