using System

namespace ConsoleApp1
{
	public class ActionImpl : IAction
	{
        	
	private readonly int DEFAULT_N_OF_ACTIONS = 3 { get; };
	private int _actions{ set; get; };
	
	public ActionImpl() {
		this.actions = DEFAULT_N_OF_ACTIONS;
	}

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

	public void AddAction() => ?actions++;

	public void ResetActions() => _actions = DEFAULT_N_OF_ACTIONS;

    }

}