using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{ 
    public static GameManager instance;
    private string lastWon;
    private string lastLost;
    private string nextLevel;

    public static bool LoadLastLost = false;
    public static bool LoadNextLevel = false;
    public static bool LoadMenu = false;
    public static bool LoadLevel1 = false;

    void Awake(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Menu" || SceneManager.GetActiveScene().name == "WholeGameWon" || SceneManager.GetActiveScene().name == "Win" || SceneManager.GetActiveScene().name == "Loss"){
            Cursor.visible = true;
        }
        else{
            Cursor.visible = false;
        }
        StartCoroutine(GameWon());
        StartCoroutine(GameOver());
        switch (lastWon){
            case "Level1":
                nextLevel = "Level2";
                break;
            case "Level2":
                nextLevel = "Level3";
                break;
            case "Level3":
                nextLevel = "Level4";
                break;
            case "Level4":
                nextLevel = "Level5";
                break;
            case "Level5":
                nextLevel = "Level6";
                break;
            case "Level6":
                nextLevel = "Level7";
                break;
            case "Level7":
                nextLevel = "Level8";
                break;
            case "Level8":
                nextLevel = "Level9";
                break;
            case "Level9":
                nextLevel = "Level10";
                break;
            default:
                nextLevel = "Level1";
                break;
                
        }
        GoBackLevel();
        GoNextLevel();
        GoBackToMenu();
        LoadLevelOne();
    }
    IEnumerator GameWon(){
        if(Balloon.gameWon){
            lastWon = SceneManager.GetActiveScene().name;
            Balloon.gameWon = false;
            
            if(SceneManager.GetActiveScene().name != "Level10"){
                yield return new WaitForSeconds(1);
                SceneManager.LoadScene("Win");
            }
            else{
                yield return new WaitForSeconds(1);
                SceneManager.LoadScene("WholeGameWon");
            }
        }
    }
    IEnumerator GameOver(){
        if(Balloon.gameOver){
            lastLost = SceneManager.GetActiveScene().name;
            Balloon.gameOver = false;
            yield return new WaitForSeconds(1);
            SceneManager.LoadScene("Loss");
        }
    }
    void GoBackLevel(){
        if(LoadLastLost){
            LoadLastLost = false;
            SceneManager.LoadScene(lastLost);
        }
    }
    void GoNextLevel(){
        if(LoadNextLevel){
            LoadNextLevel = false;
            SceneManager.LoadScene(nextLevel);
        }
    }
    void GoBackToMenu(){
        if(LoadMenu){
            LoadMenu = false;
            nextLevel = null;
            lastLost = null;
            lastWon = null;
            SceneManager.LoadScene("Menu");
        }
    }
    void LoadLevelOne(){
        if(LoadLevel1){
            LoadLevel1 = false;
            SceneManager.LoadScene("Level1");
        }
    }
}
