using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject target;

    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1/2);

        CancelInvoke("SpawnObject");
    }

   void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float Z = Random.Range(-2.0F, 2.0F);
        Instantiate(target, new Vector3(x, 2, Z), Quaternion.identity);
    }
}
