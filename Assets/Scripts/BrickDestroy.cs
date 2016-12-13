using UnityEngine;
using System.Collections;

public class BrickDestroy : MonoBehaviour
{
    public GameObject powerPrefab;

    void OnCollisionEnter2D (Collision2D collision)
    {

        if (collision.collider.CompareTag("Brick0"))
        {

            if (Random.Range(0, 10) < 1)
            {
                float x = collision.collider.transform.position.x;
                float y = collision.collider.transform.position.y;

                Instantiate(powerPrefab, new Vector3(x, y, 1), Quaternion.identity);
            }
            Destroy(collision.gameObject);

        }
    }
}
