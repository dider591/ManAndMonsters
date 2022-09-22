using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Hands : MonoBehaviour
{
    [SerializeField] private GameObject[] _handMeshs;

    public void MoveDown()
    {
        transform.DOMove(new Vector3(transform.position.x, transform.position.y - 2f, transform.position.z), 3f).SetDelay(1.5f);
    }

    public void StartColorChange(Material material, float delay)
    {
        StartCoroutine(ColorChange(material, delay));
    }

    private IEnumerator ColorChange(Material material, float delay)
    {
        yield return new WaitForSeconds(delay);

        foreach (var mesh in _handMeshs)
        {
            mesh.GetComponent<Renderer>().material = material;
        }
    }
}
