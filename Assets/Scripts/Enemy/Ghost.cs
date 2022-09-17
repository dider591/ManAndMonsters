using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Ghost : MonoBehaviour
{
    [SerializeField] private Material _handMaterial;
    [SerializeField] private float _delay;
    [SerializeField] private Transform _magic;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Magic>(out Magic magic))
        {
            transform.DOScale(new Vector3(0, 0, 0), 0.4f);
            transform.DOMove(new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z), 0.4f);
            magic.Play();
        }
        if (other.TryGetComponent<Hands>(out Hands hands))
        {
            hands.StartColorChange(_handMaterial, 0.8f);
        }
        if (other.TryGetComponent<Hand>(out Hand hand))
        {
            hand.SetAttackAnimation();
        }
    }

    private void Start()
    {
        transform.DOMove(_magic.position, _delay);
    }
}
