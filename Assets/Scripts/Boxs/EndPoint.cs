using UnityEngine;

public class EndPoint : MonoBehaviour
{
    [SerializeField] private Transform _nextPoint;

    public Transform NextPoint => _nextPoint;
}
