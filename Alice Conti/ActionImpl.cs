using System

namespace ConsoleApp1
{
	public class ActionImpl : IAction
	{
        	
	private final static int DEFAULT_N_OF_ACTIONS = 3;
	private int _actions;
	
	public ActionImpl() {
		this.actions = DEFAULT_N_OF_ACTIONS;
	}
	
	public void SetActions(int actions) => _actions = actions;

	public int GetMaxActions() => DEFAULT_N_OF_ACTIONS;

	public int GetAvailableActions() => _actions;

	public void RemoveAction() {
		if(isActionAvailable(_actions)) {
			_actions--;
		}
	}
	private boolean IsActionAvailable(final int actions) {
		if(_actions > 0) {
			return true;
		}
		return false;
	}

	public void AddAction() {
		this.actions++;
	}

	public void ResetActions() => _actions = DEFAULT_N_OF_ACTIONS;


    }

}