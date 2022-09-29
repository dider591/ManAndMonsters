using UnityEngine;
using DG.Tweening;

public class MoverCoin : MonoBehaviour
{
    private const float MinStep = 0.4f;
    private const float MaxStep = 0.6f;
    private const float Duration = 0.3f;

    private float _step;

    private void Start()
    {
        _step = Random.Range(MinStep, MaxStep);
        transform.DOMoveY(transform.position.y + _step, Duration);
    }
}
