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

    void UpdateTasksList(ArrayList tasks)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        foreach (Task t in tasks)
        {
            sb.Append("- ").Append(t.GetDescr()).Append("\n");
        }
        tasksList.text = sb.ToString();
    }

    void OnEnable()
    {
        //taskManager.taskFinished += UpdateTasksList;
        UpdateTasksList(taskManager.GetTasks());
    }
}
