using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EnergyBar: MonoBehaviour{
    Image bar;
    Text txt;

    public Color AlertColor = Color.red;
    Color startColor;

    public float alert = 25f;
    private float val;

    public float Val {
        get {
            return val;
        }
        set {
            val = value;
            val = Mathf.Clamp(val, 0, 100); // Clamping the value directly
            UpdateValue();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("Bar").GetComponent<Image>();
        txt = bar.transform.Find("Text").GetComponent<Text>();
        startColor = bar.color;
        Val = 100;
    }

    void UpdateValue() {
        txt.text = val + "%"; // Changed from txt.Text to txt.text
        bar.fillAmount = val / 100;
        if(val<=alert){
            bar.color = AlertColor;
        }
        else{
            bar.color = startColor;
        }
        if(val <=0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void SetEnergy(float energy)
    {
        Val = energy;
    }
}

