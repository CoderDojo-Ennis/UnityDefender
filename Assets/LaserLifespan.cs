using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserLifespan : MonoBehaviour
{
    public float LifeSpan = 0.2f;
    private float Age = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Age += Time.deltaTime;
        if (Age >= LifeSpan)
        {
            Destroy(gameObject);
        } else
        {
            // Scale down the X, and Y, but keep the Z scale value the same
            float scale = 1 - (Age / LifeSpan);
            transform.localScale = new Vector3(scale, scale, transform.localScale.z);
        }
    }
}
