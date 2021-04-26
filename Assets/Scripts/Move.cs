using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 movePosition;
    public Entity entity;

    public virtual void Tick()
    {
        entity.desiredHeading = ComputeDH();
        entity.desiredSpeed = entity.maxSpeed;
        // line.SetPosition(1, movePosition);
    }

    public Vector3 diff = Vector3.positiveInfinity;
    public float dhRadians;
    public float dhDegrees;
    public float ComputeDH()
    {
        diff = movePosition - entity.position;
        dhRadians = Mathf.Atan2(diff.x, diff.z);
        dhDegrees = Utils.Degrees360(Mathf.Rad2Deg * dhRadians);
        return dhDegrees;
    }

    public float doneDistanceSq = 1000;
    public virtual bool IsDone()
    {
        return (diff.sqrMagnitude < doneDistanceSq);
    }

    public virtual void Stop()
    {
        entity.desiredSpeed = 0;
        // LineMgr.inst.DestroyLR(line);
    }
}
