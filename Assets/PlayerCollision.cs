using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Enemy":
            case "Terrain":
                GetComponent<Die>().DieNow();
                break;
            default:
                Debug.Log("Ship collision with: " + collision.gameObject.name);
                break;
        }
    }
}
