using UnityEngine;
using System.Collections;

public class HenBehavior : MonoBehaviour
{
    public GameObject eggPrefab;
    public int minEggsLaying = 2;
    public int maxEggsLaying = 10;
    public float layEggInterval = 0.05f;
    public float whenEggsLay = 30f;
    public float disappears = 40f;
    public float eggSpawnHeight = 1f;
    void Start()
    {
        StartCoroutine(LayEggs());
        StartCoroutine(Disappears());
    }

    IEnumerator LayEggs()
    {
        yield return new WaitForSeconds(whenEggsLay);



        int eggsToLay = Random.Range(minEggsLaying, maxEggsLaying + 1);

        for (int i = 0; i < eggsToLay; i++)
        {
            LayEgg();
            yield return new WaitForSeconds(layEggInterval);
        }

    }

    void LayEgg()
    {
        Vector3 spawnPosition = transform.position + Vector3.up * eggSpawnHeight;
        Instantiate(eggPrefab, spawnPosition, Quaternion.identity);
    }

    IEnumerator Disappears()
    {
        yield return new WaitForSeconds(disappears);

        Destroy(gameObject);
    }
}
