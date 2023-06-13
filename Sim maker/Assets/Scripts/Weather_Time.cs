using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Weather_Time : MonoBehaviour
{
    public Material Sunnyskybox;
    public Material Rainybox;
    public Material Nightskybox;
    public Light Sun;
    public Slider Climateslider;
    public Text climatetitle;
    public GameObject RainPrefab;
    public int LoadedWeathervalue;

    private void Start()
    {
        LoadedWeathervalue = PlayerPrefs.GetInt("Weather");
        Climateslider.value = LoadedWeathervalue;
        Changeclimate();
    }


    public void Changeclimate() 
    {
        if (Climateslider.value == 0) 
        {
            RenderSettings.skybox = Sunnyskybox;
            Sun.intensity = 1;
            Sun.gameObject.transform.localEulerAngles = new Vector3(50,-30,0);
            Sun.color = Color.white;
            RainPrefab.SetActive(false);
            climatetitle.text = "Day";
        }


        if (Climateslider.value == 1)
        {
            RenderSettings.skybox = Rainybox;
            Sun.intensity = 0.46f;
            Sun.gameObject.transform.localEulerAngles = new Vector3(50, -30, 0);
            Sun.color = Color.gray;
            RainPrefab.SetActive(true);
            climatetitle.text = "Rain";
        }



        if (Climateslider.value == 2)
        {
            RenderSettings.skybox = Nightskybox;
            Sun.intensity = 0.3f;
            Sun.gameObject.transform.localEulerAngles = new Vector3(50, -30, 0);
            Sun.color = Color.gray;
            RainPrefab.SetActive(false);
            climatetitle.text = "Night";
        }
    }


}
