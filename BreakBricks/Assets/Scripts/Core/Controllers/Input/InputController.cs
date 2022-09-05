using Core.Controllers.Interfaces;
using UnityEngine;
using Zenject;

namespace Core.Controllers
{
    public class InputController : IInputController, IInitializable
    {
        public void HandleInput()
        {
            Debug.Log("Test");
        }

        public void Initialize()
        {
            HandleInput();
        }
    }
}
