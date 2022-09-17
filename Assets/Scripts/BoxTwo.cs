using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxTwo : MonoBehaviour
{
    [SerializeField] private GameObject _ghost;
    [SerializeField] private Material _handMaterial;

    private bool _isColorChanged = false;

    public event UnityAction SeePlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Hands>(out Hands hands))
        {
            if (!_isColorChanged)
            {
                hands.StartColorChange(_handMaterial, 0f);
                _isColorChanged = true;
            }          
        }
        if (other.TryGetComponent<Player>(out Player player))
        {
            SeePlayer.Invoke();
            player.EffectChange();
            _ghost.SetActive(true);
        }
    }
}
