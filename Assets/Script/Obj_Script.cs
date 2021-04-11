using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_Script : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float randomX = Random.Range(-5f, 5f);
        //transform.Translate(0.0f, 0.0f, 0.0f);
        //transform.localScale = transform.localScale+ new Vector3(0.001f, 0.001f, 0.001f);
       if( Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(obj,new Vector3(randomX,5,0), Quaternion.identity);
            //transform.localScale = transform.localScale + new Vector3(0.1f, 0.1f, 0.1f);
        
        }

    }
}
