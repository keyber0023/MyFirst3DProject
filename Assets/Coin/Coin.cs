using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        Coin.counter = coins.Length;
        Debug.Log("Coin created " + Coin.counter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Coin.counter--;
            Debug.Log("Coin Picked. " + Coin.counter + " Letf");
            if (Coin.counter == 0)
            {
                Debug.Log("You Win!");
                GameObject timeManager = GameObject.Find("TimeManager");//Find by name 
                Destroy(timeManager);
                GameObject[] fireworks = GameObject.FindGameObjectsWithTag("Fireworks");
                foreach (GameObject firework in fireworks) {
                    firework.GetComponent<ParticleSystem>().Play();
                }
            }
            Destroy(gameObject);
        }
    }
}
