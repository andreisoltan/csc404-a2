using UnityEngine;
using System.Collections;

public class Logic : MonoBehaviour {

    public GameObject player, heli, cubeDispatcher, civilianDispatcher;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        heli = GameObject.Find("Heli");
        cubeDispatcher = GameObject.Find("CubeDispatcher");
        civilianDispatcher = GameObject.Find("CivilianDispatcher");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
/*
public class Player : GameObject {

    public int health;

    // Use this for initialization
    void Start() {
        
        health = 100;
    }

    // Update is called once per frame
    void Update() {

    }

}

public class Heli : GameObject {

    public int health;
    public int capacity;
    public int occupancy;

    // Use this for initialization
    void Start() {
        health = 100;
        capacity = 300;
        occupancy = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Cube : GameObject {

    public int health;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Civilian : GameObject {

    public int health;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class CubeDispatcher : GameObject {

    // Use this for initialization
    void Start()
    {
        GameObject.Find("CubeDispatcher");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class CivilianDispatcher : GameObject {

    // Use this for initialization
    void Start()
    {
        GameObject.Find("CivilianDispatcher");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class GameMain : GameObject {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
*/