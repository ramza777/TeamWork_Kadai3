using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f; 

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        // �J�����̃r���[�|�[�g�����E�E��̃��[���h���W���擾
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

        float spawnX = topRight.x + 1.0f; // ��ʉE�̊O��
        float minY = bottomLeft.y;
        float maxY = (bottomLeft.y + topRight.y) / 2f;

        float spawnY = Random.Range(minY, maxY);

        Vector3 spawnPos = new Vector3(spawnX, spawnY, 0);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}
