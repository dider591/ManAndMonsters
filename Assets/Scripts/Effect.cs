using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect : MonoBehaviour
{
    //[SerializeField] private ParticleSystem _effect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            Debug.Log("Enrmy");
            //_effect.Play();
        }
    }
}
