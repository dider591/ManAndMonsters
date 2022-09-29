using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject _water;
    [SerializeField] private GameObject _laser;

    private GameObject _currentWeapon;

    private void Start()
    {
        _currentWeapon = _water;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _currentWeapon.SetActive(true);
        }
        else
        {
            _currentWeapon.SetActive(false);
        }
    }

    public void MoveUp()
    {
        transform.DOMove(new Vector3(transform.position.x - 0.3f, transform.position.y + 0.7f, transform.position.z), 1f).SetDelay(0.5f);
    }

    public void EffectChange()
    {
        _currentWeapon = _laser;
    }
}
