using UnityEngine;

namespace Assets
{
    public class Rotate : MonoBehaviour {

        public void Update()
        {
            if (!Input.GetMouseButton(0)) return;
            var x = -Input.GetAxis("Mouse X");
            var y = -Input.GetAxis("Mouse Y");
            float speed = 10;
            transform.rotation *= Quaternion.AngleAxis(x * speed, Vector3.down);
            transform.rotation *= Quaternion.AngleAxis(-y * speed, Vector3.left);
        }
    }
}
