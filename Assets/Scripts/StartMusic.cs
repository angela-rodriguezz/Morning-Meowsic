using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMusic : MonoBehaviour
{
    [SerializeField] private AudioSource music;
    [SerializeField] private bool gamePlay;
    [SerializeField] private AudioController bgGo;
    public static StartMusic instance;

    [SerializeField] private int currentScore;
    [SerializeField] private int scorePerNote = 1;


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
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

    public void RightBeat()
    {
        Debug.Log("On Time");
        currentScore += scorePerNote;
    }

    public void WrongBeat()
    {
        Debug.Log("Missed");
    }
}
