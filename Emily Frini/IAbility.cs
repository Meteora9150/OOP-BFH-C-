namespace FriniC-Sharp
{
	public interface IAbility
	{
		public enum Type
		{
			DOUBLE_ATTACK,
			ELIXIR_OF_LIFE
		}

		void Apply();

		string GetName();
	}
}
