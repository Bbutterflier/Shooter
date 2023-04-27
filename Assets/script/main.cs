using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class main : MonoBehaviour
{   
    public GameObject mainText;
    public Image bgground;
    public Image blackground;
    public Button startButton;
    public Button optionButton;
    public Button exitButton;

    bool flag;
    int count;

    private void Start()
    {
        flag = false;
        count = 0;
    }

    private void Update()
    {
        if (flag == true) {
            count++;
            if (count == 1000) {
                count = 0;
                flag = false;
                SceneManager.LoadScene("Game1", LoadSceneMode.Single);
            }
        }
    }

    public void LoadBlackground() {
        flag = true;
        GameObject.Find("Background"). SetActive(false);
        GameObject.Find("StartButton"). SetActive(false);
        GameObject.Find("OptionButton"). SetActive(false);
        GameObject.Find("ExitButton"). SetActive(false);
    }

    public void QuitGame() {
         Application.Quit();
    }
    public void nextSecne(){
        SceneManager.LoadScene("Game2");
    }
}
