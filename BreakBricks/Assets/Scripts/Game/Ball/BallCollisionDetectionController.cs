using System;
using Game.Collision.Interfaces;
using UnityEngine;
using Zenject;

namespace Game.Ball.Controllers
{
    public class BallCollisionDetectionController : IInitializable, IDisposable
    {
        [Inject] private ICollisionDetectionModel ICollisionDetectionModel { get; set; }

        public void Initialize()
        {
            ICollisionDetectionModel.OnCollisionDetected += HandleOnCollisionDetected;
        }

        public void Dispose()
        {
            ICollisionDetectionModel.OnCollisionDetected -= HandleOnCollisionDetected;
        }

        private void HandleOnCollisionDetected(Collision2D collision)
        {
            Debug.Log("Ball hit");
        }
    }
}
