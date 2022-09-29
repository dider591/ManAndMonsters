using UnityEngine;

public class BoxOne : Box
{
    [SerializeField] private GameObject _spot;

    public void InstantiateSpot(Vector3 point)
    {
        Instantiate(_spot, point, transform.rotation);
    }
}
