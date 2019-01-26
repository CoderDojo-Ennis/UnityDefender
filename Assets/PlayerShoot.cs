using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject LaserPrefab;
    public AudioSource LaserSound;

    // Start is called before the first frame update
    void Start()
    {
        LaserSound = GetComponent<AudioSource>();           
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Create a new laser at the position and rotation of the gun
            Instantiate(LaserPrefab, transform.position, transform.rotation);

            LaserSound.Play();
        }   
    }
}
