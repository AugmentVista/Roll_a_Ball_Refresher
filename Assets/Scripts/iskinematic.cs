using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class iskinematic : MonoBehaviour
{
    public GameObject firework;
    public float thrust = 1.0f;
    public Rigidbody rb;

    // Update is called once per frame
    void LateUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            buttonOnClick();
        }
    }
    void buttonOnClick()
    {
        Debug.Log("sdgfdsgsgs");
        Rigidbody fireworkRigidbody = firework.GetComponent<Rigidbody>();
        fireworkRigidbody.isKinematic = false;
        fireworkRigidbody.AddForce(0, 0, thrust, ForceMode.Impulse);
    }
}
