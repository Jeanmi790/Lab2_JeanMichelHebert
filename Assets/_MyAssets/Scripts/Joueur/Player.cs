using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected float _vitesse = 700;
    [SerializeField] protected float _rotation = 10f;
    //[SerializeField] private float _sprint = 2;
    Rigidbody _rbPlayer;

    private void Start()
    {
        Vector3 positionini = new Vector3(44.96f, 0.992f, -44.51f);
        this.transform.position = positionini ;
        _rbPlayer= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    //RigidBody ou Gravit� demandent d'�tre un fixedupdate
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

        //M�thode qui pousse le joueur avec de la force
        //_rbPlayer.AddForce(direction * temps * _vitesse);
        //M�thode qui fait glisser le joueur avec de la v�locit�
        _rbPlayer.velocity = direction * temps * _vitesse;

        //Method to rotate the player
        //if(direction != Vector3.zero)
        //{
        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), _rotation * temps);
        //}
        

        
    }
    public void FinDeJeu()
    {
        this.gameObject.SetActive(false);
    }

}
