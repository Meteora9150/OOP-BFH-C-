namespace FriniC-Sharp
{
	public class ElixirOfLife : IAbility
	{
		private readonly Player _player;
		private readonly string _name;
		private readonly IAbility.Type _type;

		public ElixirOfLife(Player player)
		{
			this._player = player;
			this._name = "Elixir of Life";
			this._type = IAbility.Type.ELIXIR_OF_LIFE;
		}

		public void Apply()
		{
			player.getLife().setLifePoints(player.getLife().getLifePoints() + 10);
		}

		public string GetName()
		{
			return this._name;
		}
	}
}
