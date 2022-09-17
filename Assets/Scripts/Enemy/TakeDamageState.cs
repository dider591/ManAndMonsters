using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class TakeDamageState : State
{
    private Animator _animator;
    private int Damage = Animator.StringToHash("Damage");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.Play(Damage);
    }
}
