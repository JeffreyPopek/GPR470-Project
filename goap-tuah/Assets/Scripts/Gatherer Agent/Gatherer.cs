using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatherer : GoapAgent
{
    public void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isHome", 1, true);
        goals.Add(s1, 3);
    }
}
