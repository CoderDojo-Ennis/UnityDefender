using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoSpinScript : MonoBehaviour
{
    public float SpinSpeed = 360;

    private void Start()
    {
        SpinSpeed *= Random.Range(0.9f, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, SpinSpeed * Time.deltaTime, 0);
    }
}
