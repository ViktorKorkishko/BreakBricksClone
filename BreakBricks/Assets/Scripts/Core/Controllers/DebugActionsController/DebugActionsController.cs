using System;
using UnityEngine;
using Zenject;

namespace Core.Controllers
{
    public class DebugActionsController : IInitializable, IDisposable, ITickable
    {
        public void Initialize()
        {
            
        }

        public void Dispose()
        {

        }

        public void Tick()
        {
            if (Input.GetKeyDown(KeyCode.F7))
            {
                Time.timeScale += 1;
            }
            
            if (Input.GetKeyDown(KeyCode.F8))
            {
                Time.timeScale = 1;
            }
        }
    }
}
