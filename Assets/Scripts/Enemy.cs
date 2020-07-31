using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _timeDestroy;

    private Animator _animator;
    private Rigidbody[] _rigidbodies;
    private Limb[] _limbs;
    private bool _alive = true;

    private void OnDisable()
    {
        for (int i = 0; i < _limbs.Length; i++)
            _limbs[i].Hited -= Die;
    }

    private void Awake()
    {
        _rigidbodies = GetComponentsInChildren<Rigidbody>();
        _limbs = GetComponentsInChildren<Limb>();
        _animator = GetComponent<Animator>();

        for (int i = 0; i < _rigidbodies.Length; i++)
            _rigidbodies[i].isKinematic = true;

        for (int i = 0; i < _limbs.Length; i++)
            _limbs[i].Hited += Die;
    }

    public void Die()
    {
        if (_alive)
        {
            _animator.enabled = false;

            for (int i = 0; i < _rigidbodies.Length; i++)
                _rigidbodies[i].isKinematic = false;
        }
        Destroy(gameObject, _timeDestroy);
    }
}
