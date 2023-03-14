using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PassageSecret : MonoBehaviour
{
    bool collision = false;
    Player player;
[SerializeField] List<GameObject> passages = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        
        player =  GameObject.FindObjectOfType<Player>();
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
    
        if((!collision) && (other.gameObject.tag == "Player"))
        {
            
            collision = true;
            player.GetComponent<MeshRenderer>().material.color = Color.green;
            foreach(GameObject passage in passages) { 
            passage.SetActive(false);
            }

            Debug.Log("Passage débloqué");
        }
    }

    
}
