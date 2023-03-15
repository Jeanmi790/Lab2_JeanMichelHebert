using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _pointage;
    float temps;
    private float _tempsperdu;
    float tempsNiv1;
    float tempsNiv2;
    float tempsNiv3;
    float tempsTotal;
    int nbAccrochageNiv1;
    int nbAccrochageNiv2;
    int nbAccrochageNiv3;
    int nbAccrochageTotal;

    public float TempsNiv1 { get; set; }
    public float TempsNiv2 { get; set; }
    public float TempsNiv3 { get; set; }
    public float TempsTotal { get; set; }
    public int NbAccrochageNiv1 { get; set; }
    public int NbAccrochageNiv2 { get; set; }
    public int NbAccrochageNiv3 { get; set; }
    public int NbAccrochageTotal { get; set; }
    public int NbAccrochageTotal1 { get ; set; }

    //Player p = FindGameObjectOfType("Player");

    private void Awake()
    {
        int nbGM = FindObjectsOfType<GameManager>().Length;
        if (nbGM > 1)
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
        Instructions();
        _pointage = 0;
        temps = Time.time;


    }
    void Instructions()
    {
        Debug.Log("Bienvenu, vous devez trouver la sortie du donjon.");
        Debug.Log("Vous devez éviter de toucher au mur avec des piques et les trappes au sol.");
        Debug.Log("Chaque obstacle vous rajoute une pénalité sur votre temps.");
    }

    public void AugmenterPointage()
    {
        _pointage++;
       // _tempsperdu += 1f;
       // Debug.Log(_tempsperdu);


    }
    public int GetPointage()
    {
        return _pointage;
    }

    public void StatistiqueNiv1(int accrochages, float temps)
    {
        tempsNiv1 = temps + (1F* accrochages);

        nbAccrochageNiv1 = _pointage;

        Debug.Log("Temps Niv 1: " + tempsNiv1);
        Debug.Log("Nombre d'accrochage Niv 1: " + nbAccrochageNiv1);
    }

    public void StatistiqueNiv2(int accrochages, float temps)
    {
        tempsNiv2 = temps + (1F * accrochages);
        nbAccrochageNiv2 = _pointage - nbAccrochageNiv1;
        Debug.Log("Temps Niv 2: " + tempsNiv2);
        Debug.Log("Nombre d'accrochage Niv 2: " + nbAccrochageNiv2);
    }

    public void StatistiqueNiv3(int accrochages, float temps)
    {
        tempsNiv3 = temps + (1F * accrochages);
        nbAccrochageNiv3 = _pointage - nbAccrochageNiv1 - nbAccrochageNiv2;
        Debug.Log("Temps Niv 3: " + tempsNiv3);
        Debug.Log("Nombre d'accrochage Niv 3: " + nbAccrochageNiv3);
    }


    public void FinJeu()
    {
        temps = Time.time + _tempsperdu;
        Debug.Log("Ton temps: " + temps);
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().enabled = false;
        



    }

}
