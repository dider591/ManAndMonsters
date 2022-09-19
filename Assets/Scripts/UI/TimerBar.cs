using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class TimerBar : MonoBehaviour
{
    [SerializeField] private BoxTwo _boxTwo;
    [SerializeField] private CanvasGroup _canvasGroup;

    private float _maxValue = 1f;
    private float _currentvalue = 1f;
    private float _stepTimer = 0.1f;
    private Image _imageBar;
    private bool _isSee = false;

    private void OnEnable()
    {
        _imageBar = GetComponent<Image>();
        _boxTwo.SeePlayer += IsSee;
    }

    private void OnDisable()
    {
        _boxTwo.SeePlayer -= IsSee;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && _isSee == true)
        {
            SetTimer();
            _isSee = false;
        }
        if (_currentvalue > 0)
        {
            _currentvalue -= Time.deltaTime * _stepTimer;
            _imageBar.fillAmount = _currentvalue;
        }
        if (_currentvalue <= 0)
        {
            _canvasGroup.alpha = 0;
        }
    }

    private void SetTimer()
    {
        _canvasGroup.alpha = 1;
        _currentvalue = _maxValue;
    }

    private void IsSee()
    {
        _isSee = true;
    }
}
