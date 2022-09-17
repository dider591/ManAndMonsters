using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private Player _target;

    public event UnityAction Damage;
    public event UnityAction Dying;
    public Player Target => _target;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        Damage?.Invoke();

        if (_health <= 0)
        {
            Dying?.Invoke();
        }
    }
}
