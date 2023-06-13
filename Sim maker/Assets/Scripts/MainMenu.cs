using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public InputField inputusername;
    public Button EnterBTN;
    public string Username;
    public Text finalname;
    public Dropdown Weatherlist;
    public bool load = false;
    public Dropdown LevelList;
    public string[] Levelnames;
    public bool Onlymainmenu = false;


    private void Start()
    {
        if (Onlymainmenu == true)
        {
            finalname.gameObject.SetActive(false);

            if (load == false)
            {
                PlayerPrefs.SetInt("age of user", 125);
                print("Saved !");
            }
            if (load == true)
            {
                print("age of user will be : " + PlayerPrefs.GetInt("age of user"));
                print("User name will be : " + PlayerPrefs.GetString("UserName"));
                print("Weather will be : " + PlayerPrefs.GetInt("Weather"));
            }
        } 
    }


    public void EnterMybuttonaction() 
    {
        Username = inputusername.text;
        inputusername.gameObject.SetActive(false);
        EnterBTN.gameObject.SetActive(false);
        finalname.gameObject.SetActive(true);
        finalname.text ="It is our user name = " + Username + " in our sim";
        PlayerPrefs.SetString("UserName", Username);
        PlayerPrefs.SetInt("Weather", Weatherlist.value);
    }

    public void GoToScene() 
    {
        print(Levelnames[LevelList.value]);
        SceneManager.LoadScene(Levelnames[LevelList.value]);
    }

    public void GoToMenu() 
    {
        SceneManager.LoadScene(0);
    }

}
