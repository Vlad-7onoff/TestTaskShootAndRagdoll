using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New BulletData", menuName = "Bullet Data", order = 51)]
public class BulletData : ScriptableObject
{
    [SerializeField] private float _speed;
    [SerializeField] private float _power;

    public float Speed => _speed;
    public float Power => _power;
}
