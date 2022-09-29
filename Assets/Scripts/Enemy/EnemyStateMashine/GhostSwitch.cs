using UnityEngine;

public class GhostSwitch : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0, 0);
    }
}
