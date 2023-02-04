using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Conditional : ScriptableObject
{
    public abstract bool Evaluate (AIController controller);
}
