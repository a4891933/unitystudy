using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainCamera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//初始化
		int manualWidth = 1920;
		int manualHeight = 720;
		int manaulRealHeight;
		if(System.Convert.ToSingle(Screen.height) / Screen.width > System.Convert.ToSingle(manualHeight) / manualWidth){
			manaulRealHeight = Mathf.RoundToInt(System.Convert.ToSingle(manualWidth)/ Screen.width * Screen.height);
		}else{
			manaulRealHeight = manualHeight;
		}
		Camera camera = GetComponent<Camera>();
		float scale =System.Convert.ToSingle(manualHeight / 640f);
		camera.fieldOfView*= scale;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
