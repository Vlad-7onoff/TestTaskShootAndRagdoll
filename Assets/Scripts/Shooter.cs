using UnityEngine;
using UnityEngine.Events;

public class Shooter : MonoBehaviour
{
    [SerializeField] private float _rayDistance;
    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private Bullet _bulletPrefab;
    [SerializeField] private BulletData[] _bulletsType;

    private Camera _camera;
    private int _currentBulletType;

    public UnityAction<string> BulletTypeChanged;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Start()
    {
        BulletTypeChanged?.Invoke(_bulletsType[_currentBulletType].name);
    }

    public void TryShoot()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, _rayDistance, _layerMask))
        {
            Vector3 direction = hit.point - transform.position;
            Bullet bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
            bullet.Init(_bulletsType[_currentBulletType], direction);
        }
    }

    public void ChangeCurrentBulletType()
    {
        if (_currentBulletType >= _bulletsType.Length - 1)
            _currentBulletType = 0;
        else
            _currentBulletType++;

        BulletTypeChanged?.Invoke(_bulletsType[_currentBulletType].name);
    }
}
