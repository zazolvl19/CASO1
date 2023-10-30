using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : Singleton<StateManager>
{
    int _kills = 0;

    public int getKills()
    {
        return _kills;
    }

    public void setKills(int newKills)
    {
        _kills = newKills;
    }
}
