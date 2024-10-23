using UnityEngine;
using System; // Used to access DateTime

public class WeeklyPlanIfElse : MonoBehaviour
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
            for (int i = 0; i < days.Length; i++)
            {
                if (dayOftheWeek == days[i])
                {
                    Debug.Log($"On {days[i]} I will: {tasks[i]}");
                    return;
                }
            }
            
            if (dayOftheWeek == "Random")
            {
                int randomDay = UnityEngine.Random.Range(0, days.Length);
                Debug.Log($"On {days[randomDay]} I will: {tasks[randomDay]}");
            }
            else
            {
                Debug.Log($"What day is {dayOftheWeek}? Today is {DateTime.Now.DayOfWeek}");
            }
    }
}
