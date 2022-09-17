using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoverCoin : MonoBehaviour
{
    private float _step;

    private float _minStep = 0.4f;
    private float _maxStep = 0.6f;

    private void Start()
    {
        _step = Random.Range(_minStep, _maxStep);
        transform.DOMoveY(transform.position.y + _step, 0.3f);
    }
}
