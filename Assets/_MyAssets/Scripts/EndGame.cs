using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    GameManager _gameManager;
    bool _collision = false;
    Player _player;


    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _player = FindObjectOfType<Player>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        int noScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(SceneManager.sceneCountInBuildSettings);
        if ((!_collision) && (collision.gameObject.tag == "Player"))
        {

            switch (noScene)
            {
                case 0:
                    _gameManager.StatistiqueNiv1(_gameManager.GetPointage(), Time.time);
                    Debug.Log("Prochain niveau...");
                    _gameManager.ResetPointage();
                    SceneManager.LoadScene(noScene + 1);


                    break;
                case 1:
                    _gameManager.StatistiqueNiv2(_gameManager.GetPointage(), Time.time);
                    Debug.Log("Prochain niveau...");
                    _gameManager.ResetPointage();

                    SceneManager.LoadScene(noScene + 1);




                    break;
                case 2:
                    _gameManager.StatistiqueNiv3(_gameManager.GetPointage(), Time.time);
                    Debug.Log("Dernier niveau...");
                    _gameManager.ResetPointage();
                    _gameManager.FinJeu();
                    _player.FinDeJeu();

                    //SceneManager.LoadScene(noScene + 1);

                    break;


            }

        }




    }
}

