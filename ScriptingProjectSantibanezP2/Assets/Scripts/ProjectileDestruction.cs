using System.Collections;
using UnityEngine;

public class ProjectileDestruction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3.5f);
    }
}
