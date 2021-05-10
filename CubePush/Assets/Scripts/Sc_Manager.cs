using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sc_Manager : MonoBehaviour
{
    public int score;
    public int destroyCount;
    

    // Update is called once per frame
    void Update()
    {
        if (destroyCount == 3)
        {
            if (score >= 1)
            {
                Debug.Log("win");
                SceneManager.LoadScene("SampleScene");
            }
            if (score <= -1)
            {
                Debug.Log("lose");
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
}
