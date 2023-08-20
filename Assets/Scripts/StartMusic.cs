using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMusic : MonoBehaviour
{
    public AudioSource music;
    public bool gamePlay;
    [SerializeField] private AudioController bgGo;
    public static StartMusic instance;

    public int currentScore;
    [SerializeField] int scorePerNote = 1;

    public Animator pawAnimator;



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
        pawAnimator.SetBool("PlayAnimation", true);


    }

    public void WrongBeat()
    {
        Debug.Log("Missed");
    }
}
