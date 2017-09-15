using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTask : Task {
    public Transform target;

    public FindTask(string descr, Transform tar) : base(descr)
    {
        target = tar;
    }
}
