using System
using controller.globalGenerator.GlobalGenerator;
using controller.playerAttack.PlayerAttackImpl;
using model.actions.Action;
using model.actions.ActionImpl;

namespace ConsoleApp1
{
	public class PlayerImpl : IPlayer
	{

		private readonly Life life { get; }
		private readonly Experience experience { get; }
		private Pair<Integer, Integer> playerPosition { set; get; }
		private readonly Action player_action { get; }
		private readonly Gold gold { get; }
		private readonly PlayerAttackImpl attack { get; }
		private readonly int ADD_HP = 5;

		GlobalGenerator gg = GlobalGenerator.getInstance();

		/**
		 * Constructor for the Player.
		 * @param pair starting position.
		 */
		public PlayerImpl(Pair<Integer, Integer> pair)
		{
			life = new Life();
			playerPosition = pair;
			experience = new Experience();
			player_action = new ActionImpl();
			gold = new Gold();
			attack = new PlayerAttackImpl(gg.player);
		}

		public void recoverPlayer()
		{
			Console.WriteLine("You feel stronger than before and by magic all your wounds are healed!");
			life.setMaxLifePoints(life.getMaxLifePoints() + ADD_HP);
			life.resetLife();
		}


	}
}
