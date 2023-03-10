using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected float _vitesse = 1000;
    //[SerializeField] private float _sprint = 2;
    Rigidbody _rbPlayer;

    private void Start()
    {
        Vector3 positionini = new Vector3(48f, 0.03f, -44f);
        this.transform.position = positionini ;
        _rbPlayer= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    //RigidBody ou Gravité demandent d'être un fixedupdate
    private void FixedUpdate()
    {
        MouvementsJoueur();

    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        float temps = Time.fixedDeltaTime;

        Vector3 direction = new Vector3(positionX, 0f, positionZ);

        //transform.Translate(direction * temps * _vitesse);

        //Méthode qui pousse le joueur avec de la force
        //_rbPlayer.AddForce(direction * temps * _vitesse);
        //Méthode qui fait glisser le joueur avec de la vélocité
        _rbPlayer.velocity = direction * temps * _vitesse;
        
    }
    public void FinDeJeu()
    {
        this.gameObject.SetActive(false);
    }

}
