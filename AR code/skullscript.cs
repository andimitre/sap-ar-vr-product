using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class skullscript : MonoBehaviour,IVirtualButtonEventHandler {

	public int count = 0;
	private GameObject jaw;
	private GameObject lteeth;
	private GameObject uteeth;
	private GameObject skull;


	void Awake()
	{
		//DNA=transform.Find("DNA").gameObject;
		jaw = GameObject.Find ("jaw");
		lteeth = GameObject.Find ("lteeth");
		uteeth = GameObject.Find ("uteeth");
		skull = GameObject.Find ("skull");
		VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();   //获取VirtualButton Behaviour组件
		for (int i = 0; i < vbs.Length; ++i) {     //遍历所有组件
			vbs [i].RegisterEventHandler (this);    //对该脚本进行注册
		}//


	}

	// Use this for initialization
	void Start () {
		jaw.SetActive (false);
		lteeth.SetActive (false);
		uteeth.SetActive (false);
		skull.SetActive (false);
		
	}

	public void OnButtonPressed( VirtualButtonAbstractBehaviour vb ) { 
		Debug.Log ("=================== button pressed ======================"); 
		count += 1;
		if ((count % 4) == 1) {
			jaw.SetActive (true);
			lteeth.SetActive (false);
			uteeth.SetActive (false);
			skull.SetActive (false);

		}
		if ((count % 4) == 2) {
			jaw.SetActive (true);
			lteeth.SetActive (true);
			uteeth.SetActive (false);
			skull.SetActive (false);
		}
		if ((count % 4) == 3) {
			jaw.SetActive (true);
			lteeth.SetActive (true);
			uteeth.SetActive (true);
			skull.SetActive (false);
		}
		if ((count % 4) == 0) {
			jaw.SetActive (true);
			lteeth.SetActive (true);
			uteeth.SetActive (true);
			skull.SetActive (true);

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
