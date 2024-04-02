using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject mygtukas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void ZaidejasNumire ()
    {
        Time.timeScale = 0;
        mygtukas.SetActive(true);
    }
    public void PaspaudeiReplay()
    {

        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void Update()
    {

    }
}
