using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class BotonSalir : MonoBehaviour {
    public bool salir;
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (salir){
                Debug.Log("Salimos Del Juego");
                Application.Quit();
           }
            else
            {
                SceneManager.LoadScene("Niveles");
            }
        }
	}
}
