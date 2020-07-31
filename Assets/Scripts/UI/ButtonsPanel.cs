using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsPanel : MonoBehaviour
{
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Button _restart;
    [SerializeField] private Button _spawnEnemy;

    private void OnEnable()
    {
        _restart.onClick.AddListener(OnRestartButtonClick);
        _spawnEnemy.onClick.AddListener(SpawnEnemy);
    }

    private void OnDisable()
    {
        _restart.onClick.RemoveListener(OnRestartButtonClick);
        _spawnEnemy.onClick.RemoveListener(SpawnEnemy);
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SpawnEnemy()
    {
        _enemySpawner.Spawn();
    }
}
