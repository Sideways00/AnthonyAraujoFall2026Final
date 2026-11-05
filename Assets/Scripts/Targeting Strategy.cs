using UnityEngine;

public class TargetingManager : MonoBehaviour
{

    public abstract class TargetingStrategy
    {
        protected Ability ability;
        protected TargetingManager targetingManager;
        protected bool isTargeting = false;
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
