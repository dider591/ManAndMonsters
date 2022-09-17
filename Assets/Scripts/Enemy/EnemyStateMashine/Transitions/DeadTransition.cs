using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class DeadTransition : Transition
{
    private Enemy _enemy;
    private bool isDead = false;

    private void OnEnable()
    {
        _enemy = GetComponent<Enemy>();
        _enemy.Dying += onDamage;
    }

    private void onDamage()
    {
        isDead = true;
    }

    private void OnDisable()
    {
        _enemy.Dying -= onDamage;
    }

    private void Update()
    {
        if (isDead == true)
        {
            NeedTransit = true;
        }
    }
}
