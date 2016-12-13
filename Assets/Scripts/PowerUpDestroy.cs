using UnityEngine;
using System.Collections;

public class PowerUpDestroy : MonoBehaviour {

	void Update () {
	
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Power"))
        {
            Destroy(collider.gameObject);
        }
    }
}
