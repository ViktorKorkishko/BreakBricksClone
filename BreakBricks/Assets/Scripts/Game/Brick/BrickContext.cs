using Game.Ball;
using Game.Collision;
using HelpersAndExtensions;
using UnityEngine;

namespace Game.Brick
{
    public class BrickContext : MonoBehaviour
    {
        [SerializeField] private CollisionDetectionModel _collisionDetector;

        private void OnEnable()
        {
            _collisionDetector.OnCollisionDetected += HandleOnCollisionDetected;
        }

        private void OnDisable()
        {
            _collisionDetector.OnCollisionDetected -= HandleOnCollisionDetected;
        }

        private void HandleOnCollisionDetected(Collision2D collision)
        {
            if (collision.gameObject.TryGetComponentExtended<BallModel>(out var ballContext))
                Disable();
        }

        private void Enable() => gameObject.SetActive(true);
        private void Disable() => gameObject.SetActive(false);
    }
}
