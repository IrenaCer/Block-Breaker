using UnityEngine;
using System.Collections;

public class BrickDestroy : MonoBehaviour
{

    void OnCollisionEnter2D (Collision2D collision)
    {

        if (collision.collider.CompareTag("Brick0"))
        {

            Destroy(collision.gameObject);
        }
    }
}
