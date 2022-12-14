using UnityEngine;

[RequireComponent(typeof(Animator))]
public class IdleState : State
{
    private Animator _animator;
    private int Idle = Animator.StringToHash("Idle");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        _animator.Play(Idle);
    }
}
