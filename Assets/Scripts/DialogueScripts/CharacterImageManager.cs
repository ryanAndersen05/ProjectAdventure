using UnityEngine;
using System.Collections.Generic;

public class CharacterImageManager : MonoBehaviour {
    public PortraitUI[] allCharacters;

    static Dictionary<string, PortraitUI> allCharacterImages = new Dictionary<string, PortraitUI>();


    void Start()
    {
        foreach (PortraitUI p in allCharacters)
        {
            allCharacterImages.Add(p.characterName, p);
        }
    }

    public static PortraitUI getCharacter(string characterName)
    {
        if (allCharacterImages.ContainsKey(characterName))
        {
            return allCharacterImages[characterName];
        }
        return null;
    }
    
}
