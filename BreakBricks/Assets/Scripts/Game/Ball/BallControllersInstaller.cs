using Zenject;
using UnityEngine;
using Game.Collision.Interfaces;
using Game.Collision;
using Game.Ball.Controllers;

namespace Game.Ball
{
    public class BallControllersInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _hitboxObject;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BallCollisionDetectionController>().AsSingle();
            Container.Bind<ICollisionDetectionModel>().To<CollisionDetectionModel>().FromComponentsOn(_hitboxObject).AsSingle();
        }
    }
}
