using UnityEngine;
using DG.Tweening;

public class Relocator : MonoBehaviour
{
    [SerializeField] private float _jumpPower;

    private int _countJump = 1;
    private float _duration = 2f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<EndPoint>(out EndPoint endPoint))
        {
            transform.DOJump(endPoint.NextPoint.position, _jumpPower, _countJump, _duration);
            transform.DORotate(endPoint.NextPoint.rotation.eulerAngles, _duration);
        }
    }  
}
