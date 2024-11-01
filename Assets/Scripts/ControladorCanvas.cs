using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCanvas : MonoBehaviour
{
    public GameObject MenuPrincipal;
    public GameObject Pajarraco;
    public GameObject MenuMuerte;
    public GameObject MenuInGame;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MostrarMenuMuerte()
    {
        MenuMuerte.SetActive(true);
    }

    public void EsconderMenuPrincipal()
    {
        MenuPrincipal.SetActive(false);
        Pajarraco.SetActive(true);
        MenuInGame.SetActive(true);
    }

    public void ReiniciarJuego()
    {
        Debug.Log("Botón presionado");
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
