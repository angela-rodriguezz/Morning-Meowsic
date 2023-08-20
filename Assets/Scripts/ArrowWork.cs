using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowWork : MonoBehaviour
{
    public bool canPress;
    [SerializeField] private KeyCode keyPressed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (!RectTransformExtension.IsVisibleFrom(gameObject.GetComponent<RectTransform>())) {
            //gameObject.GetComponent<Image>().enabled = false;
        //} 

        //if (RectTransformExtension.IsVisibleFrom(gameObject.GetComponent<RectTransform>())) {
            //gameObject.GetComponent<Image>().enabled = true;
        //}
        if (Input.GetKeyDown(keyPressed))
        {
            if (canPress)
            {
                gameObject.SetActive(false);
                StartMusic.instance.RightBeat();
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
            StartMusic.instance.WrongBeat();
        }
    }
}
