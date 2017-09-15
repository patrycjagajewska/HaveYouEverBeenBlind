using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour {
    private ArrayList tasks;

    public Transform remoteController;

    public event System.Action<Task> taskFinished;

    public void finishTask(Task finishedTask)
    {

    }

    // Use this for initialization
    void Start () {
        Task findRemoteControllerTask = new FindTask("Find remote controller", remoteController);
        tasks = new ArrayList();
        tasks.Add(findRemoteControllerTask);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public ArrayList GetTasks()
    {
        return tasks;
    }
}
