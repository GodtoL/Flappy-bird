using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
    
{
    public Transform transformDelOtroSuelo;
    public Pajarraco scriptPajarraco;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!scriptPajarraco.estaMuerto && scriptPajarraco.partidaEmpezada) 
        {
            transform.position = transform.position - new Vector3(0.8f * Time.deltaTime, 0, 0);

            if (transform.position.x <= -5f)
            {
                transform.position = new Vector3(transformDelOtroSuelo.position.x + 5, transformDelOtroSuelo.position.y, transform.position.z);

            }
        }

    }
}
