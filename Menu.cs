using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public  void EscenaJuego()
    {
        SceneManager.LoadScene("Nivel 1");
    }
    public void Opciones()
    {
        SceneManager.LoadScene("Opciones");
    }

    public void Salir()
    {
    Application.Quit();
    }
}
