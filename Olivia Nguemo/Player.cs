using controller.playerAttack.PlayerAttackImpl;
using model.actions.Action;
using System

namespace ConsoleApp1
{

	public interface IPlayer
	{
		 Pair<Integer, Integer> getPlayerPosition();

		 void setPlayerPosition(Pair<Integer, Integer> newPos);

		 Life getLife();

		 Gold getGold();

		 Experience getExperience();

		 Action getPlayer_action();

		 void recoverPlayer();

		 PlayerAttackImpl getPlayerAtt();
	}
}