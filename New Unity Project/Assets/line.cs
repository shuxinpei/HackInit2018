using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class line : MonoBehaviour {
    private static byte[] result = new byte[1024];
    protected float jump_speed = 5.0f;  //设置起跳时的速度

    // Use this for initialization
    string[] sArray;
        void Start () {
        
        string strReadFilePath = @"E:\\ak.txt";
        StreamReader srReadFile = new StreamReader(strReadFilePath);
        string strReadLine = srReadFile.ReadLine();
        sArray=strReadLine.Split(' ');
        srReadFile.Close();
       
    }
    
    public int speed = 5;
    public float H;
    public float V;
    // Update is called once per frame
    public float fireRate = 0.05F;
    private float nextFire = 0.0F;
    int i=0;
    double v=0;
    void Update () {
        
        if (Time.time > nextFire&&i<sArray.Length-1) {
           //transform.position += -transform.up * Time.deltaTime * 1;
            nextFire = Time.time + fireRate;
            v=(v*0.01F+0.25*(double.Parse(sArray[i])+double.Parse(sArray[i+1]))*1-0.02)*0.8;
            string a=v.ToString();
            i+=1;
            this.GetComponent<Rigidbody> ().velocity=new Vector3(0,  float.Parse(a),0);
        }
        //else if(i>sArray.Length-1){this.GetComponent<Rigidbody> ().velocity=new Vector3(0,2,0);
       // i+=1;}
    }
}