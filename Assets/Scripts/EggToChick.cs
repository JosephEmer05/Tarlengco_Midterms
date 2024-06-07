using UnityEngine;
using System.Collections;

public class EggBehavior : MonoBehaviour
{
    public GameObject chickPrefab;

    void Start()
    {
        StartCoroutine(SwitchToChickAfterDelay(10f));
    }

    IEnumerator SwitchToChickAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        GameObject chickInstance = Instantiate(chickPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
