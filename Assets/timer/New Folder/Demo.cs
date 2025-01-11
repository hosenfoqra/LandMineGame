using UnityEngine ;

public class Demo : MonoBehaviour {

    private playerMove playerMove;
    private GameObject player;
   [SerializeField] Timer timer1 ;
   /*[SerializeField] Timer timer2 ;
   [SerializeField] Timer timer3 ;
   [SerializeField] Timer timer4 ;*/
    bool check = false;
   private void Start () {
        player = GameObject.FindGameObjectWithTag("man");
        if (player != null)
        {
            playerMove = player.gameObject.GetComponent<playerMove>();
        }
        timer();
 /*
      timer1
      .SetDuration (5)
      .OnEnd (() => playerMove.hitPlayer())
      .Begin () ;
/*
      timer2
      .SetDuration (10)
      .OnEnd (() => playerMove.hitPlayer())
      .Begin () ;

      timer3
      .SetDuration (15)
      .OnEnd (() => Debug.Log ("Timer 3 ended"))
      .Begin () ;

      timer4
      .SetDuration (25)
      .OnEnd (() => Debug.Log ("Timer 4 ended"))
      .Begin () ;
   }*/
}
private void Update(){
 if (check)
 {
    playerMove.hitPlayer();
    timer();
    check = false;
 }

}
private void timer(){

    timer1
      .SetDuration (20)
      .OnEnd (() => check = true)
      .Begin () ;

}
}


//playerMove.hitPlayer()