using UnityEngine;

public class NameGenerator : MonoBehaviour
{
    public string[] animalNames = new string[]
 {
    "Chicken",
    "Dog",
    "Cat",
    "Lion",
    "Tiger",
    "Elephant",
    "Giraffe",
    "Zebra",
    "Kangaroo",
    "Monkey",
    "Racoon"
 };

    void Start()
    {
        string generatedName = GenerateRandomAnimalName();
        Debug.Log("Your Name: " + generatedName);
    }

    string GenerateRandomAnimalName()
    {
        if (animalNames == null || animalNames.Length == 0)
        {
            Debug.LogError("Animal names array is empty or not assigned.");
            return "Error: No names available";
        }

        // Choose two random animal names from the array.
        string animalName1 = animalNames[Random.Range(0, animalNames.Length)];
        string animalName2 = animalNames[Random.Range(0, animalNames.Length)];

        // Combine the two names to create a new name.
        string combinedName = animalName1 + animalName2;

        return combinedName;
    }
}
