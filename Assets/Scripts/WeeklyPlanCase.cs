using UnityEngine;
using System; // Used to access DateTime

public class WeeklyPlanCase : MonoBehaviour
{
    // Declare variables and choose what is shown in the inspector in the unity editor
    [Header("Write a day of the week")] // Instructions on what to do
    public string dayOftheWeek = "Random"; // Default to showing a random day
    [HideInInspector] public string[] days = new string[7] 
    { 
        "Monday", 
        "Tuesday", 
        "Wednesday", 
        "Thursday", 
        "Friday", 
        "Saturday", 
        "Sunday" 
    };
    [HideInInspector] public string[] tasks = new string[7] 
    { 
        "Take Vincent to the daycare and buy new chairs for the office",
        "Set up a supervisor meeting for the group and procrastinate for the rest of the day",
        "Onboard the team to tasks in Notion and leave early for a family dinner",
        "Research agency in games and ponder new features for the game",
        "Review the new features and set up tasks in Notion for first sprint",
        "Drive the family to the summerhouse for the weekend and freak out over scope creep",
        "Have a relaxing day with the family and drive back to the city before starting all over again"
    };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintDayPlan(dayOftheWeek);
    }

    // Method to print the plan
    public void PrintDayPlan(string dayOftheWeek)
    {
        switch (dayOftheWeek)
        {
            case "Monday":
                Debug.Log($"On {days[0]} I will: {tasks[0]}");
                break;
            case "Tuesday":
                Debug.Log($"On {days[1]} I will: {tasks[1]}");
                break;
            case "Wednesday":
                Debug.Log($"On {days[2]} I will: {tasks[2]}");
                break;
            case "Thursday":
                Debug.Log($"On {days[3]} I will: {tasks[3]}");
                break;
            case "Friday":
                Debug.Log($"On {days[4]} I will: {tasks[4]}");
                break;
            case "Saturday":
                Debug.Log($"On {days[5]} I will: {tasks[5]}");
                break;
            case "Sunday":
                Debug.Log($"On {days[6]} I will: {tasks[6]}");
                break;
            case "Random":
                int randomDay = UnityEngine.Random.Range(0, days.Length);
                Debug.Log($"On {days[randomDay]} I will: {tasks[randomDay]}");
                break;
            default:
                Debug.Log($"What day is {dayOftheWeek}? Today is {DateTime.Now.DayOfWeek}");
                break;
        }
    }
}
