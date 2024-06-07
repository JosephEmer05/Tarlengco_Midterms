using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject eggPrefab; 

    void Start()
    {
        Invoke("SpawnEgg", 2f); 
    }

    void SpawnEgg()
    {
        Instantiate(eggPrefab, transform.position, Quaternion.identity);
    }
}

