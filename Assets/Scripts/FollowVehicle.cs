using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowVehicle : Move
{
    public Entity vehicle;
    public Entity devil;
    public Vector3 relativeOffset;
    public Vector3 offset;
    public float followThreshold = 2000;

    public FollowVehicle(Entity monster, Entity player, Vector3 delta)
    {
        devil = monster;
        vehicle = player;
        relativeOffset = delta;
    }

    public override void Tick()
    {
        offset = vehicle.transform.TransformVector(relativeOffset);
        movePosition = vehicle.transform.position + offset;
        float dh = ComputeDH();
        devil.desiredHeading = dh;
        if (diff.sqrMagnitude < followThreshold)
        {
            devil.desiredSpeed = vehicle.speed;
            devil.desiredHeading = vehicle.heading;
        }
        else
        {
            devil.desiredSpeed = devil.maxSpeed;
        }
    }

    public bool done = false;//user can set it to done

    public override bool IsDone()
    {
        return done;
    }

    public override void Stop()
    {
        base.Stop();
        devil.desiredSpeed = 0;
        // LineMgr.inst.DestroyLR(line);
    }
}
