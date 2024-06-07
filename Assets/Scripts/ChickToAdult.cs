using UnityEngine;
using System.Collections;

public class ChickBehavior : MonoBehaviour
{
    public GameObject henPrefab;
    public GameObject roosterPrefab;
    public float toAdult = 10f;

    void Start()
    {
        StartCoroutine(DecideChickenTypeAfterDelay(toAdult));
    }

    IEnumerator DecideChickenTypeAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        DecideChickenType();
    }

    void DecideChickenType()
    {
        if (CountChicks() == 1)
        {
            TransformToHen();
        }
        else
        {
            if (Random.value < 0.5f)
            {
                TransformToHen();
            }
            else
            {
                TransformToRooster();
            }
        }
    }

    void TransformToHen()
    {
        Instantiate(henPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    void TransformToRooster()
    {
        Instantiate(roosterPrefab, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    int CountChicks()
    {
        GameObject[] chickens = GameObject.FindGameObjectsWithTag("Chick");
        return chickens.Length;
    }
}