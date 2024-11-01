using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Pajarraco : MonoBehaviour
{
    public Rigidbody2D rigidbodyPajarraco;
    public bool estaMuerto = false;
    public bool partidaEmpezada = false;
    public ControladorCanvas controladorCanvas;
    public int puntuacion;
    public TextMeshProUGUI textoPuntuacion, textoPuntuacionMuerte; 
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyPajarraco.gravityScale = 0;
    }

    public void AumentarPuntuacion()
    {
        puntuacion++;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            partidaEmpezada=true;
            rigidbodyPajarraco.gravityScale = 1.0f;

            if (!estaMuerto)
            {
                rigidbodyPajarraco.velocity = new Vector2(0, 2.5f);
            }
            else
            {
               // UnityEngine.SceneManagement.SceneManager.LoadScene(0);
            }
        textoPuntuacion.text = puntuacion.ToString();
        textoPuntuacionMuerte.text = puntuacion.ToString();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!estaMuerto)
        {   // si algo le choca...
            estaMuerto = true;
            rigidbodyPajarraco.velocity = new Vector2(0, 0);
            controladorCanvas.Invoke("MostrarMenuMuerte", 1f);
        }
    }
}
