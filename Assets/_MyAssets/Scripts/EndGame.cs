using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (noScene == (SceneManager.sceneCountInBuildSettings - 1))
        {
            if ((!_collision) && (collision.gameObject.tag == "Player"))
            {
                _gameManager.FinJeu();


            }
        }
        else
        {

            switch (noScene)
            {
                case 1:
                    _gameManager.StatistiqueNiv1(_gameManager.GetPointage(), Time.time);
                    Debug.Log("Prochain niveau...");
                    SceneManager.LoadScene(noScene + 1);
                    break;
                case 2:
                    _gameManager.StatistiqueNiv2(_gameManager.GetPointage(), Time.time);
                    Debug.Log("Prochain niveau...");
                    SceneManager.LoadScene(noScene + 1);
                    break;
                case 3:
                    _gameManager.StatistiqueNiv3(_gameManager.GetPointage(), Time.time);
                    Debug.Log("Dernier niveau...");
                    break;
            }

        }

    }
}
