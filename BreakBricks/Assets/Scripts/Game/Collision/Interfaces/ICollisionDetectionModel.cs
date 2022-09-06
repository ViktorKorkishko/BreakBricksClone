using System;
using UnityEngine;

namespace Game.Collision.Interfaces
{
    public interface ICollisionDetectionModel
    {
        Action<Collision2D> OnCollisionDetected { get; set; }
        void OnCollisionEnter2D(Collision2D other);
    }
}