using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    
    private void Start()
    {
        
    }

    public void OpenMap()
    {
        if (gameObject.tag == "Map")
        {
            SceneManager.LoadScene("UI_Selector");
        }
    }

    public void OpenScene()
    {
        if(gameObject.tag == "AssetEnvironment")
        {
            SceneManager.LoadScene("AssetEnvironment");
        }

        if(gameObject.tag == "DragAndDropEnvironment")
        {
            SceneManager.LoadScene("DragAndDropEnvironment");
        }
        if (gameObject.tag == "GarageScene")
        {
            SceneManager.LoadScene("GarageScene");
        }

        
    }
}
