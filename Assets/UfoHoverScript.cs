using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoHoverScript : MonoBehaviour
{
    public float HoverHeight = 1;
    public float HoverSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Sin(Time.time * HoverSpeed) * HoverHeight;
        transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
    }
}
