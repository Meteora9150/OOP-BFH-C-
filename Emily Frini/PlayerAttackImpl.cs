using System;

namespace FriniC-Sharp
{
	public class PlayerAttackImpl : IPlayerAttack
	{
		private int DEFAULT_ATTACK_POINTS = 5;
		private int _attackPoints = 5;

		private GlobalGenerator _gg = GlobalGenerator.getInstance();
		public Player _player;

		public PlayerAttackImpl(Player player)
		{
			this._player = player;
		}

		public void Attack(Enemy enemy)
		{
			Console.WriteLine("Hero is attacking!");
			enemy.GetHit(GetAttackPoints());
			ResetAttackPoints();
		}

		public int GetAttackPoints()
		{
			return this._attackPoints;
		}

		public void GetHit(int enemyID, int enemyResponseHit)
		{
			gg.player.getLife().setLifePoints(gg.player.getLife().getLifePoints() - enemyResponseHit);
		}

		public void IncreaseAtt()
		{
			SetAttackPoints(this.DEFAULT_ATTACK_POINTS += 3);
		}

		public void SetAttackPoints(int newAttackPoints)
		{
			this._attackPoints = newAttackPoints;
		}

		public void ResetAttackPoints()
		{
			this._attackPoints = DEFAULT_ATTACK_POINTS;
		}
	}
}
