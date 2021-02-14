using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time = 60f;
    private float countDown = 0f;

    // Start is called before the first frame update
    void Start()
    {
        countDown = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (countDown > 0 && Coin.counter > 0)
        {
            countDown -= Time.deltaTime;
            Debug.Log(countDown + " seconds left");
        }
        else {
            if(Coin.counter > 0)
            {
                Debug.Log("You Lost");
                SceneManager.LoadScene("MainScene");
            }
        }

    }
}
