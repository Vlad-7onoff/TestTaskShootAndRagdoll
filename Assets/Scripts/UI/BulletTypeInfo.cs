using TMPro;
using UnityEngine;

public class BulletTypeInfo : MonoBehaviour
{
    [SerializeField] private TMP_Text _bulletTypeInfo;
    [SerializeField] private Shooter _shooter;

    private void OnEnable()
    {
        _shooter.BulletTypeChanged += SetBulletType;
    }

    private void OnDisable()
    {
        _shooter.BulletTypeChanged -= SetBulletType;
    }

    private void SetBulletType(string bulletType)
    {
        _bulletTypeInfo.text = bulletType.ToString();
    }
}
