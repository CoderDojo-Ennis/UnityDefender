using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float ForwardSpeed = 30;
    public float PitchSpeed = -2;
    public float YawSpeed = 2;
    public Vector2 InputXY;

    // Update is called once per frame
    void Update()
    {
        Vector2 input = GetInput();

        Vector3 forward = this.transform.forward * ForwardSpeed * Time.deltaTime;
        Vector3 pitch = this.transform.up * input.y * PitchSpeed * Time.deltaTime;
        Vector3 yaw = this.transform.right * input.x * YawSpeed * Time.deltaTime;
        Vector3 direction = forward + pitch + yaw;
        this.transform.rotation = Quaternion.LookRotation(direction);

        this.transform.Translate(Vector3.forward * ForwardSpeed * Time.deltaTime);
    }

    private Vector2 GetInput()
    {
        Vector2 input;
        input.x = Input.GetAxis("Horizontal");
        input.y = Input.GetAxis("Vertical");
        return input;
    }
}
