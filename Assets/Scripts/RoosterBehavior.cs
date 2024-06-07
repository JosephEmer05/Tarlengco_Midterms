using UnityEngine;
using System.Collections;

public class RoosterBehavior : MonoBehaviour
{
    public float disappears = 40f;

    void Start()
    {
        StartCoroutine(DisappearAfterDelay());
    }

    void Update()
    {

    }
    IEnumerator DisappearAfterDelay()
    {
        yield return new WaitForSeconds(disappears);

        Destroy(gameObject);
    }
}
