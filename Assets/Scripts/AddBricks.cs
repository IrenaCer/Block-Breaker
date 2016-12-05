using UnityEngine;
using System.Collections;

public class AddBricks : MonoBehaviour {

    
    public Transform canvas;

    
    public GameObject brick;

    private void Start()
    {
        Debug.Log("I'm alive...");

        for(int y = 0; y <= 3; y++)
        {

            for(float x = -5; x <= 5; x += 1.8f )
            {
                Debug.Log("I'm here");
                Instantiate(brick, new Vector3(x, y, 1), Quaternion.identity);
                //Instantiate(brick, canvas);
                //brk.name = "" + i;
                //brk.transform.SetParent(canvas, false);

            }

        }
    }
}
