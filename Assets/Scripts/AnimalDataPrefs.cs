using System;
using TMPro;
using UnityEngine;

public class AnimalDataPrefs : MonoBehaviour
{
    public AnimalData animalData;
    public TMP_Text displayText;

    void Start()
    {
        SavePrefs();
        LoadPrefs();
    }

    public void SavePrefs()
    {
        PlayerPrefs.SetString("animalName", animalData.animalName);
        PlayerPrefs.SetInt("animalAge", animalData.animalAge);
        PlayerPrefs.SetFloat("animalWeight", animalData.animalWeight);
        PlayerPrefs.Save();
    }

    public void LoadPrefs()
    {
        string name = PlayerPrefs.GetString("animalName");
        int age = PlayerPrefs.GetInt("animalAge");
        float weight = PlayerPrefs.GetFloat("animalWeight");

        displayText.text = "Name: " + name + "\n" +
                           "Age: " + age + "\n" +
                           "Weight: " + weight;
    }
}
