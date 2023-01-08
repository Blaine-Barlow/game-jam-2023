using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour 
{   
    // Asteroid
    // public Asteroid asteroidPrefab;
    public Asteroid2[] asteroids;
    public float trajectoryVariance = 15.0f;
    public float spawnRate = 1.8f;
    public int spawnAmount = 1;
    public float spawnDistance = 25.0f;

    // PowerUps
    // public PowerUp powerUpPrefab;
    public Powerup2[] powerups;
    // public float powerUpSpawnRate = 750.0f;


    // Start is called before the first frame update
    void Start() {
        InvokeRepeating(nameof(Spawn), 1, this.spawnRate);
        InvokeRepeating(nameof(SpawnPowerUps), 1, 5.0f);
    }

    private void Spawn() {
        for (int i = 0; i < this.spawnAmount; i++) {

            Vector3 spawnDirection = Random.insideUnitCircle.normalized * this.spawnDistance;
            Vector3 spawnPoint = this.transform.position + spawnDirection;

            float variance = Random.Range(-trajectoryVariance, trajectoryVariance);
            Quaternion rotation = Quaternion.AngleAxis(variance, Vector3.forward);
            int temp = Random.Range(0, asteroids.Length);
            Asteroid2 asteroid = Instantiate(asteroids[temp], spawnPoint, rotation);
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

            int temp = Random.Range(0, powerups.Length);
            Powerup2 powerUp = Instantiate(powerups[temp], spawnPoint, rotation);
            // powerUp.size = Random.Range(powerUp.size, powerUp.size);
            powerUp.SetTrajectory(rotation * -spawnDirection);
        }
    }

    // Update is called once per frame
    void Update() {
        
    }
}
