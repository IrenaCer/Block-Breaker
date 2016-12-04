using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    private float speed = 10;

	void Update () {
        Move();
	}

    void Move()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    } 
}
