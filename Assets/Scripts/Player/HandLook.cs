using UnityEngine;

public class HandLook : MonoBehaviour
{
    private float _angleZ = 10f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mause = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _angleZ));
            transform.LookAt(mause);
        }
    }
}
