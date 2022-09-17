using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandLook : MonoBehaviour
{
    //[SerializeField] private BoxTwo _boxTwo;

    private float _angleZ = 10f;
    private float _angleRotation = 3f;

    private Quaternion _rotation;

    private void Start()
    {
        _rotation = GetComponent<Transform>().localRotation;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mause = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _angleZ));
            float angleX = Mathf.Clamp(_rotation.x, _rotation.x - _angleRotation, _rotation.x + _angleRotation);
            float angleY = Mathf.Clamp(_rotation.x, _rotation.x - _angleRotation, _rotation.x + _angleRotation);
            //Vector3 correctedAngle = new Vector3(angleX, angleY, _mause.z);

            transform.LookAt(mause);
            //transform.localRotation.x. = Mathf.Clamp(_rotation.x, _rotation.x - _angleRotation, _rotation.x + _angleRotation);
            //transform.rotation = Quaternion.LookRotation(correctedAngle);
        }
    }
}
