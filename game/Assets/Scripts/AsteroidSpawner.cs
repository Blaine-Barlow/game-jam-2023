using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour 
{   
    // Asteroid
    public Asteroid asteroidPrefab;
    public float trajectoryVariance = 15.0f;
    public float spawnRate = 2.0f;
    public int spawnAmount = 1;
    public float spawnDistance = 15.0f;

    // PowerUps
    public PowerUp powerUpPrefab;
    public float powerUpSpawnRate = 1000.0f;


    // Start is called before the first frame update
    void Start() {
        InvokeRepeating(nameof(Spawn), this.spawnRate, this.spawnRate);
        InvokeRepeating(nameof(SpawnPowerUps), 1, 20.0f);
    }

    private void Spawn() {
        for (int i = 0; i < this.spawnAmount; i++) {

            Vector3 spawnDirection = Random.insideUnitCircle.normalized * this.spawnDistance;
            Vector3 spawnPoint = this.transform.position + spawnDirection;

            float variance = Random.Range(-trajectoryVariance, trajectoryVariance);
            Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

            Asteroid asteroid = Instantiate(this.asteroidPrefab, spawnPoint, rotation);
            asteroid.size = Random.Range(asteroid.minSize, asteroid.maxSize);
            asteroid.setLife(1);
            // if (asteroid.size > 1) {asteroid.setLife(2);}
            asteroid.SetTrajectory(rotation * -spawnDirection);
        }
    }

    private void SpawnPowerUps() {
        for (int i = 0; i < this.spawnAmount; i++) {
            
            Vector3 spawnDirection = Random.insideUnitCircle.normalized * this.spawnDistance;
            Vector3 spawnPoint = this.transform.position + spawnDirection;

            float variance = Random.Range(-trajectoryVariance, trajectoryVariance);
            Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);

            PowerUp powerUp = Instantiate(this.powerUpPrefab, spawnPoint, rotation);
            powerUp.size = Random.Range(powerUp.size, powerUp.size);
            powerUp.SetTrajectory(rotation * -spawnDirection);
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
