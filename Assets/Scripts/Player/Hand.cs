using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Hand : MonoBehaviour
{
    private Animator _animator;
    private int Attack = Animator.StringToHash("Attack");
    private bool isAttackAnimation = false;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && isAttackAnimation)
        {
            _animator.SetBool(Attack, true);
        }
        else
        {
            _animator.SetBool(Attack, false);
        }
    }

    public void SetAttackAnimation()
    {
        isAttackAnimation = true;
    }
}
