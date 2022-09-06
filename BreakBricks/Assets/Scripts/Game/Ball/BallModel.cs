using System;
using Game.Ball.ScriptableObjects;
using UnityEngine;

namespace Game.Ball
{
    public class BallModel : MonoBehaviour
    {
        [SerializeField] private BallSettings _ballSettings;

        [SerializeField] private Rigidbody2D _rigidbody;
        public Rigidbody2D Rigidbody => _rigidbody;

        public Vector2 Direction { get; private set; } = Vector2.zero;

        public float Speed => _ballSettings.Speed;

        public event Action<Vector2> OnLaunch;
        public void Launch(Vector2 direction)
        {
            OnLaunch?.Invoke(direction * Speed);
        }
    }
}