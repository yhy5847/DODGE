using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    string dir;

    void Start()
    {
    
    }

    void Update()
    {
        if(dir == "up")
        {
            transform.Translate(Vector3.up * 0.05f);
        }
        else if(dir == "left")
        {
            transform.Translate(Vector3.left * 0.05f);
        }
        else if (dir == "right")
        {
            transform.Translate(Vector3.right * 0.05f);
        }
        else if (dir == "down")
        {
            transform.Translate(Vector3.down * 0.05f);
        }
    }

    public void Press_up()
    {
        dir = "up";
    }

    public void Press_down()
    {
        dir = "down";
    }
    public void Press_left()
    {
        dir = "left";   
    }
    public void Press_right()
    {
        dir = "right";
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
        GameObject.Find("game").GetComponent<GameController>().uiEndGameObject.SetActive(true);
        Debug.Log("Game Over");
    }

    public void Press_normal()
    {
        dir = "null";
    }
}
