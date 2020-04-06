using Obi;
using UnityEngine;

public class GagOnClick : MonoBehaviour
{
    public enum State { Idle, InPain, Cough, Gag }
    public State currentState = State.Idle;
    public Animator animator;
    public State _lastState = State.Idle;
    public ObiEmitter obiEmitter;
    public ObiSolver obiSolver;
    public Transform barfTransorm;
    private const int NUM_GAG_VARIATIONS = 4;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            obiEmitter.enabled = true;
            obiEmitter.transform.position = barfTransorm.position;
            obiEmitter.transform.rotation = barfTransorm.rotation;
            obiEmitter.KillAll();
            
            Gag();
        }
    }

    // index is 1 based
    public void Gag(int index = -1)
    {
        if (index < 0)
        {
            index = Random.Range(1, NUM_GAG_VARIATIONS);
        }

        index = ((index - 1) % NUM_GAG_VARIATIONS) + 1;
        currentState = _lastState = State.Gag;
        animator.SetTrigger("Gag" + index);
    }
}
