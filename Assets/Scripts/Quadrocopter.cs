using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]

public class Quadrocopter : MonoBehaviour
{
    //[SerializeField] private GameObject _man;

    private Animator _animator;
    private int Run = Animator.StringToHash("Run");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayAnimation()
    {
        //_man.SetActive(true);
        _animator.Play(Run);
    }
}
