using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject LaserPrefab;
    public GameObject LaserImpactPrefab;
    public float MaxDistance = 1000;
    private AudioSource LaserSound;

    // Start is called before the first frame update
    void Start()
    {
        LaserSound = GetComponent<AudioSource>();           
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            // Did we hit anything?
            float laserLength = MaxDistance;
            Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
            bool hitSomething = Physics.Raycast(ray, out RaycastHit hitInfo, MaxDistance);
            if (hitSomething)
            {
                laserLength = hitInfo.distance;

                // Create a particle effect
                Instantiate(LaserImpactPrefab, hitInfo.point, Quaternion.identity);

                // Does the thing we hit have a Die script?
                var dieScript = hitInfo.transform.GetComponent<Die>();
                if (dieScript != null)
                {
                    dieScript.DieNow();
                }
            }

            // Create a new laser at the position and rotation of the gun
            GameObject laser = Instantiate(LaserPrefab, transform.position, transform.rotation);

            // Set the length of the laser
            laser.transform.localScale = new Vector3(1, 1, laserLength);

            LaserSound.Play();
        }   
    }
}
