using UnityEngine;

public class Weapon : MonoBehaviour
{
    private float _angleZ = 10f;

    private void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _angleZ));
        transform.LookAt(mouse);
    }
}
