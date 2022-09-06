using System;
using Game.Collision.Interfaces;
using UnityEngine;

namespace Game.Collision
{
    public class CollisionDetectionModel : MonoBehaviour, ICollisionDetectionModel
    {
        public Action<Collision2D> OnCollisionDetected { get; set; }
        public void OnCollisionEnter2D(Collision2D other) => OnCollisionDetected?.Invoke(other);
    }
}
