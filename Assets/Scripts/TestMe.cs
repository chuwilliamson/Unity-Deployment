using UnityEngine;
using System.Collections;

public class TestMe : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(Mathf.Cos(Time.realtimeSinceStartup), 0, 0);
	}
}

