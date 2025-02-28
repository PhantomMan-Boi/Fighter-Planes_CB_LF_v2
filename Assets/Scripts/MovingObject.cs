using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

    public int whatAmI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (whatAmI == 1) 
        {
            //I am the Bullet
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * 8f);
        } else if (whatAmI == 2)
        {
            //I am the EnemyOne
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * 4f);
        } else if (whatAmI == 3)
        {
            //I am the Cloud
            transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * Random.Range(3f, 6f));
        } else if (whatAmI == 4)
        {
            //I am the Coin implimented by Luis Fajardo
            transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * 3f);
        }

        if ((transform.position.y > 9f || transform.position.y <= -9f) && whatAmI != 3)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.y <= -9f && whatAmI == 3)
        {
            transform.position = new Vector3(Random.Range(-12f, 12f), 9f, 0);
        }

        if ((transform.position.y > 7.5f || transform.position.y <= -7.5f) && whatAmI == 4)
        {
            Destroy(this.gameObject);
        }
    }
}
