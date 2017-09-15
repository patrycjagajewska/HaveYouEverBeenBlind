using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour {
    private ArrayList tasks;

    public Transform remoteController;

	// Use this for initialization
	void Start () {
        Object findRemoteControllerTask = new FindTask("Find remote controller", remoteController);
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
