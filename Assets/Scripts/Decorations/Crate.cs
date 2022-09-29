using UnityEngine;

public class Crate : MonoBehaviour
{
    [SerializeField] private StarterEffects _crashCrate;

    public void InstantiateCrate()
    {
        Instantiate(_crashCrate, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
