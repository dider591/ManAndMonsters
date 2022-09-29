using UnityEngine;
using UnityEngine.Events;

public class LastBox : Box
{
    [SerializeField] private GameObject _man;
    [SerializeField] private ParticleSystem _confetti;
    [SerializeField] private Material _handMaterial;


    public event UnityAction SeePlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Hands>(out Hands hands))
        {
            hands.StartColorChange(_handMaterial, 0f);
            hands.MoveDown();
        }
        if (other.TryGetComponent<Player>(out Player player))
        {
            SeePlayer.Invoke();
            _confetti.Play();
            _man.SetActive(true);

            player.MoveUp();
        }
    }
}
