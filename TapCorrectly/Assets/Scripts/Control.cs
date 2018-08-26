using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Control : MonoBehaviour
{

    public GameObject image1, image2, image3, boxbotton1, boxbotton2, boxbotton3;
    public Button button1, button2, button3;
    int health = 3, score, i, j;
    public float speed;
    public Text textScore, textSpeed, textHealth;
  


    void Start()
    {
        j = 50;
        speed = 0;
        score = 0;

    }
    // Update is called once per frame
    void Update()
    {

        SetTime();
        textScore.text = score.ToString();
        textSpeed.text = speed.ToString();
        textHealth.text = health.ToString();

        if (speed >= 2.1f)
        {
            Health();
        }
        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    // УСТАНОВКА ИЗОБРАЖЕНИЯ
    public void Setimage()
    {

        int randomrange = Random.Range(1, 4);
        switch (randomrange)
        {
            case 1:
                image2.SetActive(false);
                image3.SetActive(false);
                image1.SetActive(true);
                break;
            case 2:
                image3.SetActive(false);
                image1.SetActive(false);
                image2.SetActive(true);
                break;
            case 3:
                image1.SetActive(false);
                image2.SetActive(false);
                image3.SetActive(true);
                break;
        }
        Setbox();
    }
    // СЧЕТ ДЛЯ 1 кнопки
    public void Score1()
    {
        if (image1.activeSelf)
        {
            ScoreAll();
        }
        else
        {
            health--;
        }
        speed = 0f;
    }
    // СЧЕТ ДЛЯ 2 кнопки
    public void Score2()
    {
        if (image2.activeSelf)
        {
            ScoreAll();
        }
        else
        {
            health--;
        }
        speed = 0f;
    }
    // СЧЕТ ДЛЯ 3 кнопки
    public void Score3()
    {
        if (image3.activeSelf)
        {
            ScoreAll();
        }
        else
        {
            health--;
        }
        speed = 0f;
    }
    public void Health()
    {
        health--;
        speed = 0f;
    }
    // УСТАНОВКА НОВОГО БОКСА КНОПОК
    public void Setbox()
    {
        for (i = j; i < score;)
        {
            int randomrange = Random.Range(1, 4);

            switch (randomrange)
            {
                case 1:
                    boxbotton2.SetActive(false);
                    boxbotton3.SetActive(false);
                    boxbotton1.SetActive(true);
                    j = j + 50;
                    break;
                case 2:
                    boxbotton3.SetActive(false);
                    boxbotton1.SetActive(false);
                    boxbotton2.SetActive(true);
                    j = j + 50;
                    break;
                case 3:
                    boxbotton1.SetActive(false);
                    boxbotton2.SetActive(false);
                    boxbotton3.SetActive(true);
                    j = j + 50;
                    break;

            }
            break;

        }
    }
    // УСТАНОВКА Скорости нажатия
    public void SetTime()
    {
        if (score <= 30)
        {
            speed += Time.deltaTime * 1f;
            return;
        }
        if (score > 30 && score <= 60)
        {
            speed += Time.deltaTime * 1.25f;
            return;
        }
        if (score > 60 && score <= 100)
        {
            speed += Time.deltaTime * 1.5f;
            return;
        }
        if (score > 100 && score <= 200)
        {
            speed += Time.deltaTime * 2f;
            return;
        }
        if (score > 200)
        {
            speed += Time.deltaTime * 3f;
            return;
        }

    }
    public void ScoreAll()
    {
        if (speed <= 0.5f)
        {
            score = score + 3;
            return;
        }
        if (speed >= 0.5f && speed <= 1.2f)
        {
            score += 2;
            return;
        }
        if (speed > 1.2f && speed < 2f)
        {
            score++;
            return;
        }
        
    }
}
