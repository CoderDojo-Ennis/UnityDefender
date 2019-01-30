using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoExplode : MonoBehaviour
{
    public GameObject ExplosionPosition;
    public float ExplosionForce = 1f;
    public float ExplisionRadius = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        foreach(var chunk in GetComponentsInChildren<Rigidbody>())
        {
            chunk.AddExplosionForce(ExplosionForce, ExplosionPosition.transform.position, ExplisionRadius);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
