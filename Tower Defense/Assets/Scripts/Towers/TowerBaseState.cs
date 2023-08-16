
public abstract class TowerBaseState
{
    //setting up the methods that all concrete states will derive from
    //abstract means that the concrete states deriving from this will have to define it themselves
    public abstract void EnterState(TowerHandler tower);

    public abstract void UpdateState(TowerHandler tower);

}
