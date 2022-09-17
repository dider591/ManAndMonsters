using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxOne : MonoBehaviour
{
    [SerializeField] private ParticleSystem _spot;

    public void InstantiateSpot(Vector3 point)
    {
        Instantiate(_spot, point, transform.rotation);
    }
}
