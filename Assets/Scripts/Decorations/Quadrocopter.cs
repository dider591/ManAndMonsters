using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Quadrocopter : MonoBehaviour
{
    private Animator _animator;
    private int Run = Animator.StringToHash("Run");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        _animator.Play(Run);
    }
}
