using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BotonMenu : MonoBehaviour {
    public void CambiarNivel(int nivel){
        if (nivel == 0){
            SceneManager.LoadScene("Niveles");
        }
        else{
            SceneManager.LoadScene("Nivel" + nivel);
        }
    }
}