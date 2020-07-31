using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Rigidbody))]
public class Limb : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public UnityAction Hited;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void ApplyHit(Vector3 direction, float power)
    {
        Hited?.Invoke();
        _rigidbody.AddForce(direction * power, ForceMode.Impulse);
    }
}
