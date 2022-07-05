using System

namespace ConsoleApp1
{
    public interface IAction
    {

	    void SetActions(int actions);

	    int GetMaxActions();

	    int GetAvailableActions();
	
	    void RemoveAction();

    	void AddAction();
	
    	void ResetActions();

    }

}