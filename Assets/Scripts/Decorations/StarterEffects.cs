using UnityEngine;

public class StarterEffects : MonoBehaviour
{
    [SerializeField] private ParticleSystem _rewardCoin;
    [SerializeField] private ParticleSystem _rewardConfetti;

    private void Start()
    {
        Spawn();
    }

    public void Spawn()
    {
        Instantiate(_rewardCoin, transform.position, Quaternion.LookRotation(Vector3.up));
        Instantiate(_rewardConfetti, transform.position, Quaternion.LookRotation(Vector3.up));
    }
}
