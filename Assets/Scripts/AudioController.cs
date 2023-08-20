using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Threading;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private float beatTime;
    public bool gameStart;
    // Start is called before the first frame update
    void Start()
    {
        beatTime = beatTime / 0.273f; 
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStart)
        {
            /*
            if (Input.anyKeyDown)
            {
                gameStart = true;
            } 
            */
        }
        else
        {
            GetComponent<RectTransform>().anchoredPosition -= new Vector2(0f, beatTime * Time.deltaTime);
        }

       
    }
/*
    void FixedUpdate()
    {
        if (!gameStart)
        {
            
        } else
        {
            transform.position -= new Vector3(0f, beatTime * Time.deltaTime, 0f);
        }
    }
*/
}
