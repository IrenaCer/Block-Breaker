using UnityEngine;
using System.Collections;

public class BallSpeedLimit : MonoBehaviour
{

    public Rigidbody2D rgbody;
    private float maxSpeed = 10;
    //private float minSpeed = 10;

    void FixedUpdate()
    {
        if (rgbody.velocity.magnitude > maxSpeed || rgbody.velocity.magnitude < maxSpeed)
        {
            LimitSpeed();
        }

    }

    void LimitSpeed()
    {
        rgbody.velocity = rgbody.velocity.normalized * maxSpeed;
    }

    /*void SlowDown()
    {
        Vector2 currentVelocity = rgbody.velocity;
        Vector2 oppositeForce = -currentVelocity / 2;
        rgbody.AddRelativeForce(oppositeForce);
    }*/

  /*  private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Paddle") && rgbody.velocity.x < minSpeed)
        {
            rgbody.velocity = rgbody.velocity.normalized * minSpeed;
        }
    }
    */
}