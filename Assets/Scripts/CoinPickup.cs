using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            //Coin hit by player Impliented by Luis Fajardo
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(1);
            Destroy(this.gameObject);
        }
        else if (whatIHit.tag == "Weapon")
        {
            //Coin shot at by player Implimented by Luis Fajardo
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(1);
            Destroy(whatIHit.gameObject);
            Destroy(this.gameObject);
        }
    }
}
