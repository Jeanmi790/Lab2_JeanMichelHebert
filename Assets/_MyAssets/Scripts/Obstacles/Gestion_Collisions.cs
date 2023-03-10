using UnityEngine;

public class Gestion_Collisions : MonoBehaviour
{
    GameManager _gameManager;
    bool _collision = false;
    //Material vert = Resources.Load("Materials/Wall_Mat",typeof(Material)) as Material;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {

        if ((!_collision) && (collision.gameObject.tag == "Player"))
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.yellow;
            _gameManager.AugmenterPointage();
            _collision = true;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }


    }

    private void OnCollisionExit(Collision collision)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }

}
