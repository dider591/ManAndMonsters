using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Man : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Quadrocopter>(out Quadrocopter quadrocopter))
        {
            quadrocopter.PlayAnimation();
        }
    }
}
