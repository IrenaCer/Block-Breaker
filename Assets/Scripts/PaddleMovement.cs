using UnityEngine;
using System.Collections;

public class PaddleMovement : MonoBehaviour {

    private float speed = 15;
    Vector3 _prevPosition;
    Vector3 vel;

    void Update () {
        Move();
        CalculateVelocity();
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
    void CalculateVelocity ()
    {
         vel = (transform.position - _prevPosition) / Time.deltaTime;
         _prevPosition = transform.position;

        //Debug.Log(vel.x);
    }

     private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ball"))
        {
            Rigidbody2D col = collision.collider.attachedRigidbody;

           // Debug.Log(collision.collider.gameObject);
            collision.collider.attachedRigidbody.velocity = new Vector2(
                col.velocity.x / 2 + vel.x / 3,
                col.velocity.y
            );
        }
    }
}
