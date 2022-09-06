using Core.Controllers;
using Zenject;

namespace Core.Installers
{
    public class GameSceneControllersInstaller : MonoInstaller<GameSceneControllersInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputController>().AsSingle().NonLazy();
            Container.BindInterfacesAndSelfTo<DebugActionsController>().AsSingle();
        }
    }
}
