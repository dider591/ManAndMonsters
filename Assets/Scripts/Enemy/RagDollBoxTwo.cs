using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDollBoxTwo : RagDoll
{
    private float deleteTime = 3f;

    public override void Destroyer()
    {
         Destroy(gameObject , deleteTime);
    }
}
