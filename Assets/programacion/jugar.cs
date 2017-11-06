using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class jugar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void CargaNivel1(string pNombreNivel1)
    {
        SceneManager.LoadScene(pNombreNivel1);
    }



}
