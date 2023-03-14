using System.Collections.Generic;
using UnityEngine;

public class ZonePieges : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<GameObject> _Listepieges = new List<GameObject>();
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
        Debug.Log("Collision");
        if ((!_collision) && (collision.gameObject.tag == "Player"))
        {   
            _collision = true;
            _player.GetComponent<MeshRenderer>().material.color = Color.red;
            _gameManager.AugmenterPointage();
            Debug.Log("Collision");
        }



    }

    private void OnCollisionExit(Collision collision)
    {
        _player.GetComponent<MeshRenderer>().material.color = Color.white;
    }



    //// Update is called once per frame
    //void Update()
    //{

    //}
}
