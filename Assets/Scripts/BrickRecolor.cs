using UnityEngine;
using System.Collections;

public class BrickRecolor : MonoBehaviour {
    public int brickStr;

    private void Update()
    {
        if (brickStr == 3)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (brickStr == 2)
        {
            GetComponent<SpriteRenderer>().color = Color.magenta;
        }
        if (brickStr == 1)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball") && brickStr > 0)
        {
            brickStr--;
            this.tag = "Brick" + brickStr.ToString();
            Debug.Log(this.tag);
        }
    }
}
