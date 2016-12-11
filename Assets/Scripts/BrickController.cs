using UnityEngine;
using System.Collections;

public class BrickController : MonoBehaviour {
    public int brickStr;

    private Score score;
    int points = 10;
    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            score = gameControllerObject.GetComponent<Score>();
        }
        if (score == null)
        {
            //Debug.Log("Reiks mesti error");
        }
    }

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
            score.AddScore(points);
            brickStr--;
            this.tag = "Brick" + brickStr.ToString();
        }
    }
}
