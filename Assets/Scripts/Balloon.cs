using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool gameWon = false;
    public AudioSource pop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Destructor")){
            Destroy(gameObject);
            gameOver = true;
            pop.Play();
            
        }
        else if(collision.gameObject.CompareTag("Sun")){
            Destroy(gameObject);
            gameWon = true;
            pop.Play();
            
        }
    }
}
