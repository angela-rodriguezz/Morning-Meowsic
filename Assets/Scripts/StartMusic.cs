using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    [SerializeField] private AudioSource music;
    [SerializeField] private bool gamePlay;
    [SerializeField] private AudioController bgGo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gamePlay)
        {
            if (Input.anyKeyDown)
            {
                gamePlay = true;
                bgGo.gameStart = true;

                music.Play();
            }
        }
    }
}
