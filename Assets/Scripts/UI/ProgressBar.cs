using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private Image _bar;
    [SerializeField] private BoxTwo _boxTwo;
    [SerializeField] private LastBox _lastBox;

    private float _currentvalue = 0f;
    private float _stepProgress = 0.5f;

    private void OnEnable()
    {
        _bar.fillAmount = _currentvalue;
        _boxTwo.SeePlayer += SetBar;
        _lastBox.SeePlayer += SetBar;
    }

    private void OnDisable()
    {
        _boxTwo.SeePlayer -= SetBar;
        _lastBox.SeePlayer -= SetBar;
    }

    private void SetBar()
    {
        _currentvalue += _stepProgress;
        _bar.DOFillAmount(_currentvalue, 1f);
    }
}
