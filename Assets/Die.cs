using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject ChunksPrefab;

    public void DieNow()
    {
        Destroy(gameObject);
        Instantiate(ChunksPrefab, this.transform.position, this.transform.rotation);
    }
}
