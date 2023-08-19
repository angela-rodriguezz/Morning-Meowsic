using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour
{
    private Image button;
    [SerializeField] private Sprite defImage;
    [SerializeField] private Sprite buttonPress;
    // Start is called before the first frame update
    [SerializeField] private KeyCode keypressed;
    void Start()
    {
        button = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keypressed))
        {
            button.sprite = buttonPress;
        }

        if (Input.GetKeyUp(keypressed))
        {
            button.sprite = defImage;
        }
    }
}
