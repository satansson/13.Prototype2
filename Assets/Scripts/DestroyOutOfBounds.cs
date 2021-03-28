using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float bottomBound = -10;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < bottomBound)
        {
            // Instead of destroying the projectile when it leaves the screen
            //Destroy(gameObject);

            // Just deactivate it
            gameObject.SetActive(false);

        }
        else if (transform.position.z > topBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }

    }
}
