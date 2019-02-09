using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject RespawnPrefab;
    public Vector3 RespawnPosition;
    public float DelaySeconds = 5;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("RespawnNow", DelaySeconds);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RespawnNow()
    {
        if (RespawnPrefab != null)
        {
            if (RespawnPosition != null)
            {
                Instantiate(RespawnPrefab, RespawnPosition, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
