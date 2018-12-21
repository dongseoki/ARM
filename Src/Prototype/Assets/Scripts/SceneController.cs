using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // 씬 컨트롤러

public class SceneController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ReturnAchieve()
    {
        SceneManager.LoadScene("Achieve");
    }

    public void ReturnKorean()
    {
        SceneManager.LoadScene("Korean");
    }

    public void ReturnMap()
    {
        SceneManager.LoadScene("Map");
    }
}
