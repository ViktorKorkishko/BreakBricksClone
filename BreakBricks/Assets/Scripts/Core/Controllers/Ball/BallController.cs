using System;
using Game.Ball;
using UnityEngine;
using Zenject;

namespace Core.Controllers.Game.Ball
{
    public class BallController : IInitializable, IDisposable
    {
        [Inject] private BallModel BallModel { get; }

        public void Initialize()
        {
            BallModel.OnLaunch += HandleOnLaunch;
        }

        public void Dispose()
        {
            BallModel.OnLaunch -= HandleOnLaunch;
        }

        private void HandleOnLaunch(Vector2 direction)
        {
            BallModel.Rigidbody.velocity = direction;
        }
    }
}
