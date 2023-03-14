using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    GameManager _gameManager;
    bool _collision = false;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        int noScene = SceneManager.GetActiveScene().buildIndex;
        if (noScene == 1)
        {
            if ((!_collision) && (collision.gameObject.tag == "Player"))
            {
                _gameManager.FinJeu();


            }
        }
        else
        {
            SceneManager.LoadScene(noScene + 1);
        }
   
    }
}
