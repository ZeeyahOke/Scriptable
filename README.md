Animal Data – PlayerPrefs Demo

A small Unity project that stores an animal's name, age, and weight using a ScriptableObject, saves them with PlayerPrefs, and shows them on screen.

What it does

Stores three data types: a string (name), an int (age), and a float (weight).
Saves the values to disk with PlayerPrefs.
Loads the values back and displays them in the Unity UI.

Scripts

AnimalData.cs – a ScriptableObject that holds the animal's name, age, and weight.

AnimalDataPrefs.cs – saves the data with PlayerPrefs.Set..., loads it back with PlayerPrefs.Get..., and shows it on a UI text.
