using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Magic : MonoBehaviour
{
    private Animator _animator;
    private int MagicAnimation = Animator.StringToHash("Magic");

    private void Start()
    {
        _animator = GetComponent<Animator>();       
    }

    public void Play()
    {
        _animator.Play(MagicAnimation);
    }
}
