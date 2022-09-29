using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class DamageTransition : Transition
{
    private Enemy _enemy;
    private bool isDamage = false;

    private void OnEnable()
    {
        _enemy = GetComponent<Enemy>();
        _enemy.Damage += onDamage;
    }

    private void onDamage()
    {
        isDamage = true;
    }

    private void OnDisable()
    {
        _enemy.Damage -= onDamage;
    }

    private void Update()
    {
        if (isDamage == true)
        {
            NeedTransit = true;
        }
    }
}
