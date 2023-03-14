using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _pointage;
    float temps;
    private float _tempsperdu;
    //Player p = FindGameObjectOfType("Player");

    private void Awake()
    {
        int nbGM = FindObjectsOfType<GameManager>().Length;
        if(nbGM > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _pointage = 0;
        temps = Time.time;
        Instructions();

    }
    void Instructions()
    {
        Debug.Log("Bienvenu, but du jeu atteindre la fin du parcours");
        Debug.Log("Chaque obstacle vous rajoute une pénalité sur votre temps.");
    }

    public void AugmenterPointage()
    {
        _pointage++;
        _tempsperdu += 1f;
        Debug.Log(_tempsperdu);
       

    }

    public void FinJeu()
    {
        temps = Time.time + _tempsperdu;
        Debug.Log("Ton temps: " + temps);
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().enabled = false;



    }
    // Update is called once per frame
    void Update()
    {
        temps = Time.time;
    }
}
