using UnityEngine;

public abstract class RagDoll : MonoBehaviour
{
    private float minPosition = 0f;

    private void Update()
    {
        Destroyer();
    }

    public virtual void Destroyer()
    {
        if (transform.position.y <= minPosition)
        {
            Destroy(gameObject);
        }
    }
}
