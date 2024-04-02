using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PagrindinisMenu : MonoBehaviour
{
    public void ZaistiZaidima ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void IseitiIsZaidimo ()
    {

        Debug.Log("QUIT");
        Application.Quit();
    }
}
