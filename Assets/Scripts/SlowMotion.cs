using System.Collections;
using UnityEngine;

public class SlowMotion : MonoBehaviour
{
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private float _slowMotionTime;
    [SerializeField] [Range(0, 1)] private float _slowTimeValue;

    private void OnEnable()
    {
        _enemySpawner.Spawned += SubscribeOnEnemy;
    }

    private void OnDisable()
    {
        _enemySpawner.Spawned -= SubscribeOnEnemy;
    }

    public void SubscribeOnEnemy(Enemy enemy)
    {
        enemy.Died += SlowMotionActive;
    }

    public void SlowMotionActive()
    {
        Time.timeScale = _slowTimeValue;
        StartCoroutine(SetNormalTimeScale());
    }

    private IEnumerator SetNormalTimeScale()
    {
        yield return new WaitForSeconds(_slowMotionTime);
        Time.timeScale = 1;
    }
}
