using System

namespace ConsoleApp1
{
	public class ObstacleImpl : Obstacle
    {
        private readonly Pair<Integer, Integer> _obstaclePos { get; };

        private final Type _obstacleType { get; };

        public ObstacleImpl(final Pair<Integer, Integer> pos, Type type){
            this.obstaclePos = pos;
            this.obstacleType = type;
        }

    }

}