using Zenject;

namespace Core.Controllers
{
    public class ControllersInstaller : MonoInstaller<ControllersInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesAndSelfTo<InputController>().AsSingle().NonLazy();
        }
    }
}
