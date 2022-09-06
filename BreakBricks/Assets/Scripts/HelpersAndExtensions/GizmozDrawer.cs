using Core.Controllers;
using UnityEditor;
using UnityEngine;
using Zenject;

namespace HelpersAndExtensions
{
    public class GizmozDrawer : MonoBehaviour
    {
#if UNITY_EDITOR
        [Inject] private InputController _inputController;

        private void OnDrawGizmos()
        {
            if (EditorApplication.isPlaying)
                _inputController.DrawGizmoz();
        }
#endif
    }
}
