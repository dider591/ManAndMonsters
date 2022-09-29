using UnityEngine;

public class BoxOne : Box
{
    [SerializeField] private ParticleSystem _spot;

    public void InstantiateSpot(Vector3 point)
    {
        Instantiate(_spot, point, transform.rotation);
    }
}
