using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task {
    private string description;
    private bool isFinished;
    
    public Task(string descr)
    {
        description = descr;
        isFinished = false;
    }

    public void FinishTask()
    {
        isFinished = true;
    }

    public string GetDescr()
    {
        return description;
    }
}
