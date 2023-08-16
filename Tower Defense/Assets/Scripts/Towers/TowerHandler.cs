using UnityEngine;

public class TowerHandler : MonoBehaviour
{
    TowerBaseState currentState;
    UnbuiltState unbuilt = new UnbuiltState();
    BuiltState built = new BuiltState();
    MaxUpgradeState maxUpgrade = new MaxUpgradeState();

    // Start is called before the first frame update
    public void Start()
    {
        currentState = unbuilt;

        currentState.EnterState(this);
    }

    public void Update()
    {
        
    }

    public void SwitchState()
    {

    }

    public void Click()
    {

    }

}
