using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AbilityType { Attack }

public class Ability
{
    public static List<Ability> abilities = new List<Ability>();


    private byte damage = 3;
    private byte manaCost = 2;

    public void Cast(InteractiveObject source, AbilityType type)
    {
        if (source.mana >= 2)
            source.mana -= manaCost;


    }
}
