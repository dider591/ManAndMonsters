using UnityEngine;

public class Corpse : MonoBehaviour
{
    private float _minPosition = -2f;
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (transform.position.y <= _minPosition)
        {
            Destroy(gameObject);
        }
    }

    public void AddForce(float force)
    {
        _rigidbody.AddForce(Vector3.forward * force, ForceMode.Force);
        _rigidbody.AddTorque(Vector3.forward * force);
    }
}
