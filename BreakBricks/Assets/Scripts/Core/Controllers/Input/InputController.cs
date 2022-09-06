using Core.Controllers.Interfaces;
using Game.Ball;
using UnityEngine;
using Zenject;

namespace Core.Controllers
{
    public class InputController : IInputController, ITickable
    {
        [Inject] private BallModel BallModel { get; }

        private Vector2 direction => (mouseWorldPosition - BallModel.transform.position).normalized;

        private Vector3 mouseWorldPosition => Camera.main.ScreenToWorldPoint(Input.mousePosition);

        private bool isTouching => Input.GetMouseButton(0);

        private bool ballWillBeLaunched;

        public void Tick() => HandleInput();

        public void HandleInput()
        {
            if (isTouching)
            {
                HandlePlayerTouchingScreen();
            }
            else
            {
                HandlePlayerReleaseTouch();
            }

            HandleDebugActions();
        }

        public void DrawGizmoz()
        {
            Gizmos.DrawLine(BallModel.transform.position, mouseWorldPosition);
        }

        private void HandlePlayerTouchingScreen()
        {
            ballWillBeLaunched = true;
        }

        private void HandlePlayerReleaseTouch()
        {
            if (ballWillBeLaunched)
            {
                BallModel.Launch(direction.normalized);
                ballWillBeLaunched = false;
            }
        }

        private void HandleDebugActions()
        {
            if (Input.GetMouseButton(1))
                BallModel.Launch(Vector2.zero);
        }
    }
}
