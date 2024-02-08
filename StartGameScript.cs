using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public void newGame()
    {
        SceneManager.LoadScene(01);
    }
}
