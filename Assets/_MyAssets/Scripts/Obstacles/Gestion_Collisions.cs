using Cinemachine;
using UnityEngine;
using UnityEngine.ProBuilder;

public class Gestion_Collisions : MonoBehaviour
{
    GameManager _gameManager;
    bool _collision = false;
    Player _player;
    //Material vert = Resources.Load("Materials/Wall_Mat",typeof(Material)) as Material;


    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _player = FindObjectOfType<Player>();

    }
    private void OnCollisionEnter(Collision collision)
    {

        if ((!_collision) && (collision.gameObject.tag == "Player"))
        {
            //_player.GetComponent<MeshRenderer>().material.color = Color.red;
            _player.GetComponent<ProBuilderMesh>().GetComponent<MeshRenderer>().material.color = Color.red;
            _gameManager.AugmenterAccrochage();


            _collision = true;
        }
     


    }

    private void OnCollisionExit(Collision collision)
    {
        //_player.GetComponent<MeshRenderer>().material.color = Color.white;
        _player.GetComponent<ProBuilderMesh>().GetComponent<MeshRenderer>().material.color = Color.white;
        _collision = false;
    }

}
