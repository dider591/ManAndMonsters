using UnityEngine;

public class HandLook : MonoBehaviour
{
    //private Quaternion _originRotation;
    //private float _angleHorizontal;
    //private float _angleVertical;
    //private float _mauseSpeed = 1f;
    //private float _angle = 30f;

    //private void Start()
    //{
    //    _originRotation = transform.rotation;
    //}

    //private void Update()
    //{
    //    _angleHorizontal += Input.GetAxis("Mouse X") * _mauseSpeed;
    //    _angleVertical += Input.GetAxis("Mouse Y") * _mauseSpeed;

    //    _angleHorizontal = Mathf.Clamp(_angleHorizontal, -_angle, _angle);
    //    _angleVertical = Mathf.Clamp(_angleVertical, -_angle, _angle);

    //    Quaternion rotationY = Quaternion.AngleAxis(_angleHorizontal, Vector3.up);
    //    Quaternion rotationX = Quaternion.AngleAxis(-_angleVertical, Vector3.right);

    //    transform.rotation = _originRotation * rotationY * rotationX;
    //}

    private float _angleZ = 10f;
    private float _angleRotation = 3f;

    private Quaternion _rotation;

    private void Start()
    {
        _rotation = transform.rotation;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mause = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _angleZ));
            //float angleX = Mathf.Clamp(mause.x, _rotation.x - _angleRotation, _rotation.x + _angleRotation);
            //float angleY = Mathf.Clamp(mause.y, _rotation.x - _angleRotation, _rotation.x + _angleRotation);
            transform.LookAt(mause);
        }
    }
}
