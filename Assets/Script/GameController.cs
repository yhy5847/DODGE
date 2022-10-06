using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject uiStartGameObject;
    public GameObject uiEndGameObject;
    public GameObject bulletPrefab;
    public Text uiTime;

    int sec;

    void Start()
    {

    }

    void MakeBullet()
    {
        GameObject bullet;

        float switchValue = UnityEngine.Random.value;
        float xValue = UnityEngine.Random.Range(-13f, 13f);
        float yValue = UnityEngine.Random.Range(-22f, 22f);

        if (switchValue > 0.5f)
        {
            if (UnityEngine.Random.value > 0.5f)
            {
                bullet = Instantiate(bulletPrefab, new Vector3(-13f, yValue, 0f), Quaternion.identity);

            }
            else
            {
                bullet = Instantiate(bulletPrefab, new Vector3(13f, yValue, 0f), Quaternion.identity);

            }
        }
        else
        {
            if (UnityEngine.Random.value > 0.5f)
            {
                bullet = Instantiate(bulletPrefab, new Vector3(xValue, -22f, 0f), Quaternion.identity);

            }
            else
            {
                bullet = Instantiate(bulletPrefab, new Vector3(xValue, 22f, 0f), Quaternion.identity);

            }
        }
    }

    public void PressStart()
    {
        sec = 0;
        uiStartGameObject.SetActive(false);
        InvokeRepeating("MakeBullet", 0f, 0.5f);
        InvokeRepeating("SetTime", 1f, 1f);
    }

    public void PressRestart()
    {
        GameObject[] bullets = GameObject.FindGameObjectsWithTag("bullet");
        foreach (GameObject bullet in bullets)
        {
            Destroy(bullet);
        }
        
        sec = 0;
        uiTime.text = "" + sec;

        uiEndGameObject.SetActive(false);
    }
    void SetTime()
    {
        sec += 1;
        uiTime.text = "" + sec;
    }

    void Update()
    {
        
    }
}
