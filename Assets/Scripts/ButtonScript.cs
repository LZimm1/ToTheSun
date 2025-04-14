using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LastLevel(){
        GameManager.LoadLastLost = true;
    }
    public void NextLevel(){
        GameManager.LoadNextLevel = true;
    }
    public void BackToMenu(){
        GameManager.LoadMenu = true;
    }
    public void LoadFirstLevel(){
        GameManager.LoadLevel1 = true;
    }
}
