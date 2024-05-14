using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggerzone : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
            Destroy(col.gameObject);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Finish"))
            Destroy(gameObject);
    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Enemy"))
            Destroy(col.gameObject);
    }
}
