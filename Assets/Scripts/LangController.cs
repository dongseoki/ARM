using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;  // 씬 관리

public class LangController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetKorean ()
    {
        SceneManager.LoadScene("Korean");
    }

    public void SetEnglish()
    {
        SceneManager.LoadScene("Korean");
    }
}
