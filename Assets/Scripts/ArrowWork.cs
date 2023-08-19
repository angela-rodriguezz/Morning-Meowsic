using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowWork : MonoBehaviour
{
    [SerializeField] private bool canPress;
    [SerializeField] private KeyCode keyPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyPressed))
        {
            if (canPress)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Matched")
        {
            canPress = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Matched")
        {
            canPress = false;
        }
    }
}
