using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class line1 : MonoBehaviour {

    protected float jump_speed = 5.0f;  //设置起跳时的速度

    // Use this for initialization
    void Start () {
        
    }
    public int speed = 5;
    public float H;
    public float V;
    // Update is called once per frame
    void Update () {

        if (Input.GetKey(KeyCode.W)) {
            transform.position += -transform.up * Time.deltaTime * 4;
            //this.GetComponent<Rigidbody>().position+=transform.up;  //设定向上速度
        }
        if (Input.GetKey(KeyCode.S))  //点击鼠标左键触发
        {
             transform.position -= -transform.up * Time.deltaTime * 4; //设定向上速度
        }
    }
}