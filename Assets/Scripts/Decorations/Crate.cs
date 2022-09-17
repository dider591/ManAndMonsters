using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    [SerializeField] private CrashCrate _crashCrate;

    public void InstantiateCrate()
    {
        Instantiate(_crashCrate, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
