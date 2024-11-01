using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberia : MonoBehaviour
{
    public Pajarraco scriptPajarraco;
    public Transform PajarracoTransform;
    public bool HaSumadoPuntos = false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(transform.position.x, Random.Range(-0.5f, 0.75f), transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (!scriptPajarraco.estaMuerto && scriptPajarraco.partidaEmpezada)
        {
            transform.position = transform.position - new Vector3(0.8f * Time.deltaTime, 0, 0);

            if (transform.position.x <= -2.5f)
            {
                transform.position = new Vector3(2.6f, Random.Range(-0.3f, 0.75f), transform.position.z);
                HaSumadoPuntos = false;


            }
            if (PajarracoTransform.position.x >= transform.position.x -0.4f  && !HaSumadoPuntos)
            {
                scriptPajarraco.AumentarPuntuacion();
                HaSumadoPuntos = true;
            }
        }

    }
}
