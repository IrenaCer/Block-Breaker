using UnityEngine;
using System.Collections;

public class AddBricks : MonoBehaviour {

    
    public Transform canvas;

    
    public GameObject brick1;
    public GameObject brick2;
    public GameObject brick3;
    public GameObject brick;
    private int brickCount = 0;

    private void Start()
    {
        brick = brick1;

        for(int y = 0; y <= 3; y++)
        {

            for(float x = -4.7f; x <= 5; x += 1.8f )
            {
                brickCount++;
                if (brickCount > 18)
                {
                    brick = brick3;
                }
                if (brickCount > 12 && brickCount < 18)
                {
                    brick = brick2;
                }
                Instantiate(brick, new Vector3(x, y, 1), Quaternion.identity);              
            }

        }
    }
}
