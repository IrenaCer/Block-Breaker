using UnityEngine;
using System.Collections;

public class PaddleMovement : MonoBehaviour {

    private float speed = 15;
    Vector3 _prevPosition;
    Vector3 vel;
    bool wallColiderRight = false;
    bool wallColiderLeft = false;


    void Update () {
        Move();
        CalculateVelocity();
	}

    void Move()
    {
        if (wallColiderLeft || !wallColiderRight)
        {
            
            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);

            }
        }

        if (wallColiderRight || !wallColiderLeft)
        { 
            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
        }
    }
    void CalculateVelocity ()
    {
         vel = (transform.position - _prevPosition) / Time.deltaTime;
         _prevPosition = transform.position;

    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.tag);

        if (collision.collider.CompareTag("Ball"))
        {
            Rigidbody2D col = collision.collider.attachedRigidbody;

            collision.collider.attachedRigidbody.velocity = new Vector2(
                col.velocity.x / 2 + vel.x / 3,
                col.velocity.y
            );
        }

        if (collision.collider.CompareTag("Wall"))
        {

            if(collision.collider.transform.position.x > 0)
            {
                wallColiderRight = true;
            }
            else if (collision.collider.transform.position.x < 0)
            {
                wallColiderLeft = true;
            }

        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Wall"))
        {
            wallColiderLeft = false;
            wallColiderRight = false;
            
        }
    }
}
