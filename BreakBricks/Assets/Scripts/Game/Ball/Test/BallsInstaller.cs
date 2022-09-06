using Game.Ball;
using HelpersAndExtensions;
using UnityEngine;
using Zenject;

public class BallsInstaller : MonoInstaller
{
    [SerializeField] private BallModel _ball;
    [SerializeField] private int _ballsCount;

    public override void InstallBindings()
    {
        for (int i = 0; i < _ballsCount; i++)
        {
            var ball = SpawnBall();
            Launch(ball);
        }
    }

    private BallModel SpawnBall()
    {
        var ball = Container.InstantiatePrefab(_ball, new Vector3(0, -2, 0), Quaternion.identity, null);
        if (ball.TryGetComponentExtended<BallModel>(out var component))
        {
            return component;
        }

        return null;
    }

    private void Launch(BallModel ball)
    {
        var direction = GetRandomDirection();
        ball.Launch(direction);

        Vector2 GetRandomDirection()
        {
            return new Vector2(GetRandomValue(), Random.value).normalized;
        
            float GetRandomValue()
            {
                int sign = Random.Range(0, 2);
                return sign == 0 ? Random.value : -Random.value;
            }
        }
    }
}