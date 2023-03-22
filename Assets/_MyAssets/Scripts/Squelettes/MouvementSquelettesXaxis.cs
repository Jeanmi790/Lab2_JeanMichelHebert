using UnityEngine;

public class MouvementSquelettesXaxis : MonoBehaviour
{
    // Start is called before the first frame update
    // Start is called before the first frame update

    [SerializeField] Vector3 positionDebut;
    [SerializeField] Vector3 positionFinale;


    float rotationYFinale = 180;

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

        if (transform.position.x > positionFinale.x)
        {
            direction.z = 1f;
            transform.Rotate(0, rotationYFinale, 0);
        }
        if (transform.position.x == positionFinale.x)
        {
            direction.z = -1f;
            transform.Rotate(0, -(rotationYFinale), 0);
        }
        if (transform.position.x < positionDebut.x)
        {
            direction.z = 1f;
            transform.Rotate(0, rotationYFinale, 0);
        }


        transform.Translate(direction * temps * vitesse);



    }

}

