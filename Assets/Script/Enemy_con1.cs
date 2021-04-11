using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_con1 : MonoBehaviour
{
    public GameObject obj;
    private int counter;
    public Transform Enemy_pos;


    // Start is called before the first frame update
    void Start()
    {
        counter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        int a;

        ++counter;

        a = counter % 100;
        if (a == 60)
        {

            float randomX = Random.Range(-2f, 2f);

            Instantiate(obj, Enemy_pos.transform.position * randomX, Quaternion.identity);


        }


    }
}
