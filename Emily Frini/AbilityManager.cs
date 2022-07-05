using System;
using System.Collections.Generic;
using System.Linq;

namespace FriniC-Sharp
{
	public class AbilityManager
	{
		private GlobalGenerator _gg = GlobalGenerator.getInstance();

		private Dictionary<IAbility.Type, List<IAbility>> _listOfAbilities;
		private Dictionary<IAbility.Type, int> _abilities;


		public AbilityManager(Dictionary<IAbility.Type, int> abilities)
		{
			this._abilities = abilities;
		}

		public void GenerateAbilities()
		{
			foreach (var ability in this.abilities)
			{
				this.listOfAbilities.Add(ability.Key, Generate(ability.Key, ability.Value));
			}
		}

		private List<IAbility> Generate(IAbility.Type type, int maxNumbers)
		{
			var abilitiesOfType = new List<IAbility>();
			for (int i = 0; i < maxNumbers; i++)
			{
				switch (type)
				{
					case IAbility.Type.DOUBLE_ATTACK:
						abilitiesOfType.Add(new DoubleAttack(gg.playerAttack));
						break;
					case IAbility.Type.ELIXIR_OF_LIFE:
						abilitiesOfType.Add(new ElixirOfLife(gg.player));
						break;
					default:
						throw new Exception("Abilità non esistente");
				}
			}
			return abilitiesOfType;
		}

		public bool IsAvailable(IAbility.Type abilityType)
		{
			if (abilities.ContainsKey(abilityType))
			{
				return _abilities[abilityType] > 0;
			}

			return false;
		}

		public void Remove(IAbility.Type abilityType)
		{
			if (IsAvailable(abilityType))
			{
				_abilities[abilityType]--;
			}
		}

		public IAbility GetAbilityOfType(IAbility.Type abilityType)
		{
			if(this.listOfAbilities.ContainsKey(abilityType))
			{
				return this.listOfAbilities[abilityType].FirstOrDefault();
			}

			return null;
		}

		public int GetSize(IAbility.Type abilityType)
		{
			if (this.listOfAbilities.ContainsKey(abilityType))
			{
				return this.listOfAbilities[abilityType].Count;
			}

			return 0;
		}
	}
}
