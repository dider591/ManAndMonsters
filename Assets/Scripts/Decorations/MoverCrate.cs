using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoverCrate : MonoBehaviour
{
    private float _moveDown = 2f;
    private float _minPosition = -10f;

    private void Start()
    {
        transform.DOMoveY(_moveDown, 5).SetDelay(5);
    }

    private void Update()
    {
        if (transform.position.y <= _minPosition)
        {
            Destroy(gameObject);
        }
    }
}
