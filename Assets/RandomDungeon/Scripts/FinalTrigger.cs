using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalTrigger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
        
    }
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            StartCoroutine("WaitForSec");
            Debug.Log("Final");
            
        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(1);
        
        //Destroy(gameObject);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
