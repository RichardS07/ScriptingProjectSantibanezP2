using System.Collections;
using UnityEngine;

public class UpdateAndFixedUpdate : MonoBehaviour
{
    private float fixedUpdateTimer;
    private float UpdateTimer;

    private void LateUpdate()
    {
        
    }

    private void OnMouseUpAsButton()
    {
    
    }

    void FixedUpdate()
        // called every physics step
        // FixedUpdate intervals are consistent
        // Used for regular updates such as:
        // Adjusting physics (Rigidbody) objects
    {
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
}
