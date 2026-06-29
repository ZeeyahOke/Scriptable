using UnityEngine;

[CreateAssetMenu(fileName = "AnimalData", menuName = "Scriptable Objects/AnimalData")]
public class AnimalData : ScriptableObject
{
   public string animalName;
   public int animalAge;
   public float animalWeight; 
}
