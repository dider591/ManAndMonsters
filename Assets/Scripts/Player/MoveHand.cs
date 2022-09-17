using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveHand : MonoBehaviour
{
    private float _stepZ = 10f;
    private float _stepX = 0.04f;
    private float _stepY = 0.05f;
    private float _stepMini = 0.03f;


    private Vector3 _position;

    private void Start()
    {
        _position = GetComponent<Transform>().localPosition;
    }

    private void Update()
    {      
        Vector3 mause = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _stepZ));
        float stepX = Mathf.Clamp(mause.x, _position.x - _stepX, _position.x + _stepMini);
        float stepY = Mathf.Clamp(mause.y, _position.z - _stepMini, _position.z + _stepY);
        Vector3 correctedPosition = new Vector3(stepX, _position.y, stepY);

        transform.DOLocalMove(correctedPosition, 1f);
    }
}
