using UnityEngine;

public class ManTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<QuadrocopterStarter>(out QuadrocopterStarter quadrocopter))
        {
            quadrocopter.PlayAnimation();
        }
    }
}
