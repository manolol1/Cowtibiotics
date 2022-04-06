using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    float timeLeft = 3.0f;
    float nextTimer = 3.0f / 1.1f;
    float score = 0;
    public Text countDownText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        score += Time.deltaTime;

        if(timeLeft <= 0)
        {
            PlayerPrefs.SetInt("lastScore", Mathf.FloorToInt(score));
            SceneManager.LoadScene("gameover");
        }

        countDownText.text = timeLeft.ToString();
    }

    public void GiveBtn()
    {
        timeLeft = nextTimer;
        nextTimer /= 1.15f;
    }
}
