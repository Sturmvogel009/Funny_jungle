using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        //if (col.gameObject.name == "Cube") ;
        //Destroy(col.gameObject);

        if (col.gameObject.CompareTag("Food"))
            Destroy(col.gameObject);



    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
            if (col.gameObject.CompareTag("Enemy"))
            Destroy(gameObject);

    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Food"))
            Destroy(col.gameObject);
    }
}
