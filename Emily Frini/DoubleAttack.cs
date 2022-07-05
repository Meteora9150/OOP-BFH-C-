namespace FriniC-Sharp
{
	public class DoubleAttack : IAbility
	{
		private readonly PlayerAttackImpl _playerAttack;
		private readonly string _name;
		private readonly IAbility.Type _type;

		public DoubleAttack(PlayerAttackImpl playerAttack)
		{
			this._playerAttack = playerAttack;
			this._name = "Double Attack";
			this._type = IAbility.Type.DOUBLE_ATTACK;
		}

		public void Apply()
		{
			this._playerAttack.SetAttackPoints(playerAttack.GetAttackPoints() * 2);
		}

		public string GetName()
		{
			return this._name;
		}
	}
}
