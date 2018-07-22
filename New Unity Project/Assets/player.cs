using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RootMotion.FinalIK;
public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	//public FullBodyBipedIKInspector ik;
	public FullBodyBipedIK ik;
	public Transform leftHandTarget,rightHandTarget;// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))  //点击鼠标左键触发
        {
            ik.solver.rightHandEffector.position = rightHandTarget.position;
			ik.solver.rightHandEffector.positionWeight=1f; 
			ik.solver.leftHandEffector.position = leftHandTarget.position;
			ik.solver.leftHandEffector.positionWeight=1f; 
        }


	}




}

