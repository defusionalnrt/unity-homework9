using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGUI : MonoBehaviour{
    public ParticleSystem whiteSmoke;
    public ParticleSystem blackSmoke;
    public GameObject car;
    bool carStart = false;
    bool err = false;
    // Start is called before the first frame update
    void Start(){
        Debug.Log("start");
        whiteSmoke = car.transform.GetChild(6).GetChild(0).GetComponent<ParticleSystem>();
        blackSmoke = car.transform.GetChild(7).GetChild(0).GetComponent<ParticleSystem>();
        if(whiteSmoke == null || blackSmoke == null){
            Debug.Log("null");
        }
    }

    // Update is called once per frame
    void Update(){
        
    }
    private void OnGUI(){
        if(GUI.Button(new Rect(0.7f * Screen.width, 100, 150, 35),"汽车发动") && !carStart){
            whiteSmoke.Play();
            carStart = true;
        }
        if (GUI.Button(new Rect(0.7f * Screen.width, 140, 150, 35),"故障") && !err){
            blackSmoke.Play();
            err = true;
        }
        if (GUI.Button(new Rect(0.7f * Screen.width, 60, 150, 35),"汽车停止") && carStart){
            whiteSmoke.Stop();
            carStart = false;
        }
        if (GUI.Button(new Rect(0.7f * Screen.width, 180, 150, 35),"故障解除") && err){
            blackSmoke.Stop();
            err = false;
        }
    }

}
