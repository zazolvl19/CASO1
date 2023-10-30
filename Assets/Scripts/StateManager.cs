using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : Singleton<StateManager>
{
    string _kills;

    public string getKills()
    {
        return _kills;
    }

    public void setKills(string newKills)
    {
        _kills = newKills;
    }
}
