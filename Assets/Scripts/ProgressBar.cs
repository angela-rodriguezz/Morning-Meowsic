using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ProgressBar : MonoBehaviour
{
    [SerializeField] private StartMusic pointGetter;
    [SerializeField] private Image progressBar;
    [SerializeField] private ArrowWork truther;

    float progress, fullScore = 35;
    float lerpSpeed;

    // Start is called before the first frame update
    void Start()
    {
        progress = 0;
    }

    // Update is called once per frame
    void Update()
    {
        lerpSpeed = 3f * Time.deltaTime;
        if (!pointGetter.music.isPlaying && pointGetter.gamePlay)
        {
            if (progress / fullScore < 0.7)
            {
                SceneManager.LoadScene("LoseScene");
            } else if (progress / fullScore >= 0.7)
            {
                SceneManager.LoadScene("WinScene");
            }
        } else
        {
            if (!PointChecker(pointGetter.currentScore))
            {
                progress = pointGetter.currentScore;
                progressFiller(progress);
                ColorChanger(progress);

            }
        }
    }

    void progressFiller(float score)
    {
        //progressBar.fillAmount = Mathf.Lerp(progressBar.fillAmount, progress / fullScore, lerpSpeed);
        progressBar.fillAmount = progress / fullScore;
    }

    void ColorChanger(float score)
    {
        Color progressColor = Color.Lerp(Color.red, Color.green, (score / fullScore));
        progressBar.color = progressColor;
    }

    public bool PointChecker(float comparison)
    {
        return progress == comparison;
    }

    
}
