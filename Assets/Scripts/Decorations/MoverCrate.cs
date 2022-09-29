using UnityEngine;
using DG.Tweening;

public class MoverCrate : MonoBehaviour
{
    private const float MoveDown = 2f;
    private const float MinPosition = -10f;
    private const float Delay = 5f;
    private const float Duration = 5f;

    private void Start()
    {
        transform.DOMoveY(MoveDown, Duration).SetDelay(Delay);
    }

    private void Update()
    {
        if (transform.position.y <= MinPosition)
        {
            Destroy(gameObject);
        }
    }
}
