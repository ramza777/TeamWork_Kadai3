using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;         // �ړ����x


    void Start()
    {

    }

    void Update()
    {
        // �������ֈړ�
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
