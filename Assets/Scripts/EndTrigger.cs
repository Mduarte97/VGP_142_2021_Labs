using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollision(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.QuitGame();


        }
    }


}
