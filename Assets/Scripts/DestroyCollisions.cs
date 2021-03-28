using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Human"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
