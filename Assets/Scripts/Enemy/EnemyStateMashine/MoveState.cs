using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MoveState : State
{
    [SerializeField] private float _speed;

    private int Walk = Animator.StringToHash("Walk");
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.Play(Walk);
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}
