using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class AxisRawExample : MonoBehaviour
{
    public float range;

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        Debug.Log("Value Returned: " + h.ToString("F2"));
    }
}
