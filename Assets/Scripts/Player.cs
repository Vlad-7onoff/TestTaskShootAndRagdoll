using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Shooter _shooter;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _shooter.TryShoot();
        if (Input.GetKeyDown("space"))
            _shooter.ChangeCurrentBulletType();
    }
}
