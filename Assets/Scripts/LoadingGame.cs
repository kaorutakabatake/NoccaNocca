using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingGame : MonoBehaviour
{
    public void LoadScene(){
        SceneManager.LoadScene("Difficulty_Select");
    }
}
