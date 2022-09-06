using Core.Controllers.Game.Ball;
using UnityEngine;
using Zenject;

namespace Game.Ball
{
    public class BallInstaller : MonoInstaller
    {
        [SerializeField] private BallModel _ball;

        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<BallController>().AsSingle();
            
            Container.Bind<BallModel>().FromInstance(_ball).AsSingle().NonLazy();
            Container.QueueForInject(_ball);
        }
    }
}
