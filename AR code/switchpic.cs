using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;



public class switchpic : MonoBehaviour,IVirtualButtonEventHandler {
	public int count = 0;
	private GameObject Plane3;
	private GameObject Plane2;
	private GameObject Plane1;

	void Awake()
	{
		//DNA=transform.Find("DNA").gameObject;
		Plane3 = GameObject.Find ("Plane3");
		Plane2 = GameObject.Find ("Plane2");
		Plane1 = GameObject.Find ("Plane1");

	}

	// Use this for initialization
	void Start () {
		//Plane3 = GameObject.Find ("Plane3");
		Plane3.SetActive (false);
		Plane2.SetActive (false);
		Plane1.SetActive (false);
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();   //获取VirtualButton Behaviour组件
		for (int i = 0; i < vbs.Length; ++i) {     //遍历所有组件
			vbs [i].RegisterEventHandler (this);    //对该脚本进行注册
		}//
		
	}

	public void OnButtonPressed( VirtualButtonAbstractBehaviour vb ) { 
		Debug.Log ("=================== button pressed ======================"); 
		count += 1;
		if ((count % 3) == 1) {
			Plane1.SetActive (true);
			Plane2.SetActive (false);
			Plane3.SetActive (false);
		}
		if ((count % 3) == 2) {
			Plane1.SetActive (false);
			Plane2.SetActive (true);
			Plane3.SetActive (false);
		}
		if ((count % 3) == 0) {
			Plane1.SetActive (false);
			Plane2.SetActive (false);
			Plane3.SetActive (true);
		}

		//DNA.SetActive (false);
	

	}
	public void OnButtonReleased( VirtualButtonAbstractBehaviour vb ) { 
		//DNA.SetActive (true);
		//DNA.transform.Rotate (new Vector3(2,Time.deltaTime * 60, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
