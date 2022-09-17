using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private float _force;

    private float _angleZ = 10f;
    private int _damage = 1;

    private void Update()
    {
        Vector3 mause = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, _angleZ));
        transform.LookAt(mause);
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.TryGetComponent<Enemy>(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);
        }
        if (other.TryGetComponent<Corpse>(out Corpse corpse))
        {
            corpse.AddForce(_force);
        }
        if (other.TryGetComponent<Crate>(out Crate Crate))
        {
            Crate.InstantiateCrate();
        }
    }
}
