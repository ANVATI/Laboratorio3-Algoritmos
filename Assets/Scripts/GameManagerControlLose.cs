using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerControlLose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void TryAgain()
    {
        SceneManager.LoadScene("Nivel 1");
        Time.timeScale = 1;
    }
    public void ReturnToMenú()
    {
        SceneManager.LoadScene("Menú");
        Time.timeScale = 1;
    }
}
