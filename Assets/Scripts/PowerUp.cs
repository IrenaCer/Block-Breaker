using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
    public GameObject paddle;
    public GameObject ball;
    float timer;
    float powerUpTime = 10;
    bool activated = false;
    delegate void Activate();
    Activate activate;
    Activate deactivate;
    float rand;

    private void Update()
    {
        if (activated)
        {
            timer -= Time.deltaTime;
            if(timer <= 0)
            {
                activated = false;
                deactivate();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Paddle"))
        {
            SetPower();
            activate();
        }
    }

    private void SetPower()
    {
        activated = true;
        timer = powerUpTime;
        Debug.Log(timer);

        rand = Random.Range(0, 4);
        if ( rand <= 1)
        {
            activate = LongPaddle;
            deactivate = ResetPaddle;
        }
        else if (rand <= 2)
        {
            activate = BigBall;
            deactivate = ResetBall;
        }
        else if(rand <= 3)
        {
            activate = ShortPaddle;
            deactivate = ResetPaddle;
        }
        else
        {
            activate = SwapControls;
            deactivate = RestoreControls;
        }

    }

    private void LongPaddle()
    {
        paddle.transform.localScale = new Vector3(6, 2);
    }
    private void ResetPaddle()
    {
        paddle.transform.localScale = new Vector3(4, 2);

    }

    private void BigBall()
    {
        ball.transform.localScale = new Vector3(2, 2);

    }
    private void ResetBall()
    {
        ball.transform.localScale = new Vector3(1, 1);

    }

    private void ShortPaddle()
    {
        paddle.transform.localScale = new Vector3(2, 2);
    }

    private void SwapControls()
    {
        PaddleMovement.right = KeyCode.A;
        PaddleMovement.left = KeyCode.D;
    }
    private void RestoreControls()
    {
        PaddleMovement.right = KeyCode.D;
        PaddleMovement.left = KeyCode.A;
    }
}

