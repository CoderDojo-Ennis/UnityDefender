using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DudeSpawner : MonoBehaviour
{
    public GameObject DudePrefab;
    public int NumberOfDudes = 10;
    public float MinX, MaxX, MinZ, MaxZ;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < NumberOfDudes; i++)
        {
            SpawnDude();
        }
    }

    // Spawn a dude
    private void SpawnDude()
    {
        Vector3 position = new Vector3();
        position.x = Random.Range(MinX, MaxX);
        position.z = Random.Range(MinZ, MaxZ);
        position.y = 200;

        bool isHit = Physics.Raycast(position, Vector3.down, out RaycastHit hitInfo, 300);
        if (isHit)
        {
            Instantiate(DudePrefab, hitInfo.point, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
