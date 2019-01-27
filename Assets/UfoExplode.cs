using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoExplode : MonoBehaviour
{
    public GameObject ExplosionPosition;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var chunk in GetComponentsInChildren<Rigidbody>())
        {
            chunk.AddExplosionForce(1, ExplosionPosition.transform.position, 0.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
