using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task {
    private string description;
    private bool isDone;
    
    public Task(string descr)
    {
        description = descr;
        isDone = false;
    }

    public void FinishTask()
    {
        isDone = true;
    }

    public string GetDescr()
    {
        return description;
    }
}
