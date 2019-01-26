using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoll : MonoBehaviour
{
    public float RollAmount = 30;

    // Update is called once per frame
    void Update()
    {
        float roll = Input.GetAxis("Horizontal") * RollAmount;
        transform.localEulerAngles = new Vector3(0, 180, roll);
    }
}
