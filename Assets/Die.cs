using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public GameObject ChunksPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DieNow()
    {
        Destroy(gameObject);
        Instantiate(ChunksPrefab, this.transform.position, this.transform.rotation);
    }
}
