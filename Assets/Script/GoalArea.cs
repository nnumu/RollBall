using UnityEngine;

public class GoalArea : MonoBehaviour
{
    public GameObject GoalText;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GoalText.SetActive(true);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
