using UnityEngine;
using UnityEngine.UI;

public class PassiveManaTest : MonoBehaviour
{
    //attached to currency bar UI parent
    public Slider coinSlider;
    public float currentAmount;
    public int coinMax;
    // Start is called before the first frame update
    void Start()
    {
        coinSlider = GetComponent<Slider>();
        currentAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinSlider.value = currentAmount;
        coinSlider.maxValue = coinMax;
        currentAmount += Time.deltaTime;
    }
}
