using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    public TextMeshPro NameText;
    public TextMeshPro AgeText;
    public TextMeshPro WeightText;
    public AnimalData animalData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        NameText.text = animalData.animalName;
        AgeText.text = animalData.animalAge.ToString();
        WeightText.text = animalData.animalWeight.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
