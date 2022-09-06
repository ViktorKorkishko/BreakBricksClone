using Game.Brick.Controllers;
using Game.Collision;
using Game.Collision.Interfaces;
using UnityEngine;
using Zenject;

namespace Game.Brick
{
    public class BrickControllersInstaller : MonoInstaller
    {
        [SerializeField] private GameObject _hitboxObject;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BrickCollisionDetectionController>().AsSingle();
            Container.Bind<ICollisionDetectionModel>().To<CollisionDetectionModel>().FromComponentsOn(_hitboxObject).AsSingle();
        }
    }
}
