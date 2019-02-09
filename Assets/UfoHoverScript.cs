using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoHoverScript : MonoBehaviour
{
    public float HoverHeight = 1;
    public float HoverSpeed = 1;
    private float TimeOffset;

    // Start is called before the first frame update
    void Start()
    {
        TimeOffset = Random.Range(0.0f, 5.0f);
        HoverHeight *= Random.Range(.9f, 1.1f);
        HoverSpeed *= Random.Range(0.9f, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        float y = Mathf.Sin((Time.time + TimeOffset) * HoverSpeed) * HoverHeight;
        transform.localPosition = new Vector3(transform.localPosition.x, y, transform.localPosition.z);
    }
}
