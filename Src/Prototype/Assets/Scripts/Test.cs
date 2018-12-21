using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour {

    public GameObject Cube;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void Ttest()
    {
        Debug.Log("test");
        SceneManager.LoadScene("Test");
    }
}
