using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 _direction;
    private float _speed;
    private float _power;

    private void Update()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }

    public void Init(BulletData bulletData, Vector3 direction)
    {
        _speed = bulletData.Speed;
        _power = bulletData.Power;
        _direction = direction;
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Limb limb))
        {
            limb.ApplyHit(_direction, _power);
            Destroy(gameObject);
        }
    }
}
