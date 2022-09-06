using UnityEngine;

namespace Game.Ball.ScriptableObjects
{
    [CreateAssetMenu(fileName = "BallSettings", menuName = "Game/Ball", order = 2)]
    public class BallSettings : ScriptableObject
    {
        [SerializeField] private float _speed;
        public float Speed => _speed;
    }
}
