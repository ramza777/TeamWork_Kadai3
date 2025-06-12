using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;         // ˆÚ“®‘¬“x


    void Start()
    {

    }

    void Update()
    {
        // ¶•ûŒü‚ÖˆÚ“®
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
