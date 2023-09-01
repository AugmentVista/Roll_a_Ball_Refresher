using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class Fireworkcontroller: MonoBehaviour
{
    GlobalVariables globalVariables;
    public TextMeshProUGUI countText;
    public GameObject firework;
    public float thrust = 1.0f;
    public Rigidbody rb;
    public bool pressed;
    public GameObject winTextObject;

    public GameObject player;
    private Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        globalVariables = FindObjectOfType<GlobalVariables>();
        offset = transform.position - player.transform.position;
        pressed = false;
    }

    // Update is called once per frame
    void LateUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Reload();
        }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                buttonOnClick();
            }
        if (pressed == false)
        { 
            transform.position = player.transform.position + offset;
        }


        void buttonOnClick()
        {
            Debug.Log("sdgfdsgsgs");

            Rigidbody fireworkRigidbody = firework.GetComponent<Rigidbody>();
            fireworkRigidbody.isKinematic = false;
            fireworkRigidbody.AddForce(0, 0, thrust, ForceMode.Impulse);
            pressed = true;
            Destroy(firework, 3);
            
        }
        void Reload()
        {
            Instantiate(firework);
            firework.transform.position = player.transform.position;
            firework.transform.position = player.transform.position + offset;
            Destroy(firework, 3);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            globalVariables.count = globalVariables.count + 1;
            SetCountText();
            
        }

    }
    void SetCountText()
    {
        countText.text = "Count: " + globalVariables.count.ToString();
        if (globalVariables.count == 12)
        {
            winTextObject.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
