using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_script : MonoBehaviour
{
    public Image guns;
    public GameObject obj;
    private float time;
    private Vector3 tempos;
    private Transform firepoint;
    private float moving_speed = 10.0f;
    private float rot_speed = 10.0f;
       
    // Start is called before the first frame update
    void Start()
    {
        firepoint = transform;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Player_moving_Control();
        Rotation();
        DrawGun();
        GetAttackDir();
        if (Input.GetMouseButton(0))
        {
            time += Time.deltaTime;
            GetAttackDir();
        }
        if(time >= 0.5f)
        {
            attack();
            time = 0;
        }

        Cursor.visible = false;


    }
    private void Player_moving_Control()
    {

        float KeyHoriztional = Input.GetAxis("Horizontal");
        float KeyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * moving_speed * Time.smoothDeltaTime * KeyHoriztional, Space.World);
        transform.Translate(Vector3.up * moving_speed * Time.smoothDeltaTime * KeyVertical, Space.World);
    }
    private void Rotation()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        h = h * this.rot_speed * Time.deltaTime;
        v = v * this.rot_speed * Time.deltaTime;

        transform.Rotate(Vector3.back * h);
        transform.Rotate(Vector3.right * v);


    }
   

    private void attack()
    {

        Instantiate(obj, firepoint.position, firepoint.rotation);

    }

    private void DrawGun()
    {
        guns.transform.position = Input.mousePosition;
    }

    private void GetAttackDir()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            tempos = hit.point;
            firepoint.LookAt(tempos);
        }
    }
}
