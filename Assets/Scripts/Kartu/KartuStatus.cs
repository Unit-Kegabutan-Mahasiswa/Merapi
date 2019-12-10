﻿using UnityEngine;

[CreateAssetMenu(fileName = "KartuStatus", menuName = "Kartu/Kartu Status", order = 2)]
public class KartuStatus : ScriptableObject, IKartu
{
    public EffectStatus status;

    public GameVariables.EffectType OnExecuteEvent;
    /*public System.Object OnExecute;*/
   /* public GameVariables.EffectType OnEverydayEvent;
    public Object OnEveryday;
    public GameVariables.EffectType OnLastEvent;
    public Object OnLast;*/

    public DiceDecide diceDecide;
    public PlayerAffect playerAffect;

    public EffectStatus GetEffectStatus()
    {
        return status;
    }

    public EffectStatus GetPlayerAffect()
    {
        return playerAffect.specialEffect;
    }

    public EffectStatus GetDiceDecide(int diceNumber)
    {
        if (diceNumber>0 && diceNumber <= diceDecide.maxDice[0])
        {
            return diceDecide.specialEffect[0];
        } else return diceDecide.specialEffect[1];
    }

    public string GenerateStatusEffect()
    {
        string format = "";

        if (status.hp != 0) format += "HP " + status.hp + "   ";
        if (status.sanity != 0) format += "Sanity " + status.sanity + "   ";
        if (status.food != 0) format += "Food " + status.food;

        return format;
    }

    public string GenerateDiceEffect(int index)
    {
        string format = "";

        if (GetDiceDecide(index).hp != 0) format += "HP " + GetDiceDecide(index).hp + "   ";
        if (GetDiceDecide(index).sanity != 0) format += "Sanity " + GetDiceDecide(index).sanity + "   ";
        if (GetDiceDecide(index).food != 0) format += "Food " + GetDiceDecide(index).food;

        return format;
    }

}