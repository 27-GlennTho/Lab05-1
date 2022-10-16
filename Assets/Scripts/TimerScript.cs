using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerScript : MonoBehaviour
{
    private float scoreValue;
    public float totalCoins;
    public float timeLeft;
    public int timeRemaining;

    public Text ScoreText;
    public Text TimerText;

    private float timerValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeRemaining = Mathf.FloorToInt(timeLeft % 60);
        TimerText.text = "Timer: " + timeRemaining.ToString();
        if(scoreValue==totalCoins)
        {
            if(timeLeft<=timerValue)
            {
                SceneManager.LoadScene("GameLose");
            }
        }
    }
}
