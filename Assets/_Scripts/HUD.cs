using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
    TaskManager taskManager;

    [SerializeField]
    Text tasksList;

    void Awake()
    {
        taskManager = FindObjectOfType<TaskManager>();
    }

    void UpdateTasksList()
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        ArrayList tasks = taskManager.GetTasks();
        foreach (Task t in tasks)
        {
            sb.Append("- ").Append(t.GetDescr()).Append("\n");
        }
        tasksList.text = sb.ToString();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
