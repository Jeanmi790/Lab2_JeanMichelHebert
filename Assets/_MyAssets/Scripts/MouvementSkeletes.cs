using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MouvementSkeletes : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float rotationY;
    [SerializeField] Vector3 positionDebut;
    [SerializeField] Vector3 positionFinale;

    
    [SerializeField] float rotationYFinale;

    [SerializeField] float vitesse;
    float temps; 



    void Start()
    {
        this.transform.position = positionDebut;
        temps = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(0f, 0f, 1f);
        
        if(transform.position != positionFinale)
        {
            transform.Translate(direction * temps * vitesse);
        }
       
       
    }

}
