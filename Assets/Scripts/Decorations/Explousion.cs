using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explousion : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _radius;

    private void Explode()
    {
        Collider[] coliders = Physics.OverlapSphere(transform.position, _force);

        foreach (var colider in coliders)
        {
            Rigidbody rigidbody = colider.attachedRigidbody;

            if (rigidbody)
            {
                rigidbody.AddExplosionForce(_force, transform.position, _force);
            }
        }
    }
}
