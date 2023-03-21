using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouvementSquelettes : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float rotationY;
    [SerializeField] Vector3 positionDebut;
    [SerializeField] Vector3 positionFinale;

    
    [SerializeField] float rotationYFinale = 180;

    [SerializeField] float vitesse;
    float temps; 



    void Start()
    {
        this.transform.position = positionDebut;
        temps = Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = new Vector3(0f, 0f, 1f);

        if (transform.position.z >= positionFinale.z)
        {
            direction.z = -1f;
        }
        if (transform.position.z == positionFinale.z)
        {
            direction.z = 1f;
        }

        transform.Translate(direction * temps * vitesse);
        
       
       
    }

}
