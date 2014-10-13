using UnityEngine;
using System.Collections.Generic;

public class ShareBunch : MonoBehaviour {

    
    private static string BUNCH = "ShareBunch";
    
    private static ShareBunch INSTANCE = null;
    
    public static ShareBunch GetInstance() {
        return INSTANCE;
    }
    
    void Awake() {
        if (ShareBunch.INSTANCE == null) {
            ShareBunch.INSTANCE = this;
            BunchManager.registerBunch(BUNCH);
            GameObject.DontDestroyOnLoad(this);
        } else {
            GameObject.Destroy(this.gameObject);
        }
    }
    
    public void ShareText(string text) {
        NativeGateway.dispatch(
            BUNCH,
            "shareText",
            new Dictionary<string, object> () {{"text", text}}
        );
    }
}
