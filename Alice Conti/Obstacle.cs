using System
using model.player.Pair;

namespace ConsoleApp1
{
    public interface IObstacle
    {

	enum Type{
		ROCK,
		POOL;
	}
	
    Pair<Integer, Integer> GetObstaclePos();
    
    Type GetObstacleType();
    
    }

}