using UnityEngine;

namespace FizbinRacer.Controls
{
    /// <summary>
    /// Camera following player.
    /// Author: AZinman
    /// </summary>
    public class CameraFollow : MonoBehaviour
    {
        private Camera cam;

        private void Start()
        {
            cam = Camera.main;
        }

        private void LateUpdate()
        {
            Vector3 camPosition = cam.transform.position;
            camPosition.x = this.transform.position.x;
            camPosition.y = this.transform.position.y;
            cam.transform.position = camPosition;
        }
    }
}
