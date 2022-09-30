using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private float _angleZ = 6f;

    private void Update()
    {
        Vector3 mause = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _angleZ));
        transform.LookAt(mause);
    }
}
