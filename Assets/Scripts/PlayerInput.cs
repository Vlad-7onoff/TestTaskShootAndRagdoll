using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private Shooter _shooter;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _shooter.TryShoot();
        if (Input.GetKeyDown("n"))
            _shooter.ChangeCurrentBulletType();
    }
}
