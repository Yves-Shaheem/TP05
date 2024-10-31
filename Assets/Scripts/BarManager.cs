using UnityEngine;

public class BarManager : MonoBehaviour
{
    
    public HealthBar healthBar; // Référence à la barre de santé
    private float currentHealth;
    private float maxHealth = 100f;

    public EnergyBar energyBar; // Référence à la barre de santé
    private float currentEnergy;
    private float maxEnergy = 100f;

    public FoodBar foodBar; // Référence à la barre de santé
    private float currentFoodLvl;
    private float maxFoodLvl = 100f;
    void Start()
    {
        Debug.Log("Démarrage du script HealthBarManager"); // Debug pour vérifier que Start est bien appelé
        currentHealth = maxHealth;
        currentEnergy = maxEnergy;
        currentFoodLvl = maxFoodLvl;

    }
    void Update()
    {
        TakeDamage(0.00001f);
        GetTired(0.00001f);
        if(currentEnergy == maxEnergy*0.7){
            GetHungry(0.00001f);
        }
    }
    public void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("insect"))
        {   
            Debug.Log("-10pv");
            TakeDamage(10f);
            GetHungry(15f);
        } 
    }
    public void TakeDamage(float damageAmount)
    {
        currentHealth -= damageAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); 
        healthBar.SetHealth(currentHealth); 
    }
    public void GetTired(float tiredness){
        currentEnergy -= tiredness;
        currentEnergy = Mathf.Clamp(currentEnergy,0 , maxEnergy);
        energyBar.SetEnergy(currentEnergy);
    }
    public void GetHungry(float hungryness){
        currentFoodLvl -= hungryness;
        currentFoodLvl = Mathf.Clamp(currentFoodLvl,0 , maxFoodLvl);
        foodBar.SetFoodLvl(currentFoodLvl);
    }
     public void Heal(float healthAmount)
    {
        if(currentHealth != 100){
            currentHealth += healthAmount;
            currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); 
            healthBar.SetHealth(currentHealth); 
        }else{
            Debug.Log("Max health level");
        }
    }
    public void GetEnergy(float energy){
        if(currentEnergy != 100){
           currentEnergy += energy;
            currentEnergy = Mathf.Clamp(currentEnergy, 0 , maxEnergy);
            energyBar.SetEnergy(currentEnergy); 
        }else{
            Debug.Log("Max energy level");
        }
        

    }
    public void GetFood(float foodLvl){
        if(currentFoodLvl != 100){
            currentFoodLvl += foodLvl;
            currentFoodLvl = Mathf.Clamp(currentFoodLvl, 0 , maxFoodLvl);
            foodBar.SetFoodLvl(currentFoodLvl);
        }else{
            Debug.Log("Max food level");
        }
        
    }
}

