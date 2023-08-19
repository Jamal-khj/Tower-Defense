using UnityEngine;

public class TowerHandler : MonoBehaviour
{
    TowerBaseState currentState;
    UnbuiltState unbuilt = new UnbuiltState();
    BuiltState built = new BuiltState();
    MaxUpgradeState maxUpgrade = new MaxUpgradeState();

    [SerializeField] private GameObject towerPrefab;
    [SerializeField] private GameObject optionsPanel;

    public Vector3 mousePos;
    public Vector3 currentTowerSpawnLocation;

    public Collider2D currentCollider;
    public bool canPlace;
    public bool releasedButton;

    PassiveManaTest slider;
    CostManager cost;

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
