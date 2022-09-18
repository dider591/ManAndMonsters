using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Incinerator : MonoBehaviour
{
    private Material[] _materials;

    private const string Cutoff = "_Cutoff";

    private void Start()
    {
        _materials = GetComponent<Renderer>().materials;

        SetAlfa();
        Destroy(gameObject, 2f);
    } 

    private void SetAlfa()
    {
        foreach (var material in _materials)
        {
            material.DOFloat(1f, Cutoff, 3f);
        }
    }
}
