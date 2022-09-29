using UnityEngine;

[RequireComponent(typeof(Animator))]
public class QuadrocopterStarter : MonoBehaviour
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
