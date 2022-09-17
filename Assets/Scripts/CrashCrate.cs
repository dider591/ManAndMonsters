using UnityEngine;

public class CrashCrate : MonoBehaviour
{
    [SerializeField] private GameObject _rewardCoin;
    [SerializeField] private GameObject _rewardConfetti;

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
