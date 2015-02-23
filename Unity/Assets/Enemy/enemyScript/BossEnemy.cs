using UnityEngine;
using System.Collections;

public class BossEnemy : MonoBehaviour {
    [SerializeField]
    private int Hp = 10;
    [SerializeField]
    private CircleCollider2D rad;
    public GameObject[] enemySield = new GameObject[3];
	[SerializeField]
	private GameObject kairo;
	private CircuitSwitch cirSwi;
    private Animator myAnim;
    private lookat2D speedAccessScript;
    private bool deadSwitch;
    private BGM bgm;
    public GameObject explosion;
    private GameObject res;
    private Result rs;
	private int level;
    private int ExproAnimCount = 0;
	private Spawns spawns;
	public GameObject spawnsObj;
	private bool clear = false;

	void Awake(){
		spawns = spawnsObj.GetComponent<Spawns> ();
        res = GameObject.Find("Result").gameObject;
        rs = res.GetComponent<Result>();
		kairo = GameObject.Find ("CircuitSwitch").gameObject;
		cirSwi = kairo.GetComponent<CircuitSwitch>();
        bgm = GameObject.Find("BGMobject").GetComponent<BGM>();
		level = rs.getSentLevel();

	}

    void Start() {
        rad = GetComponent<CircleCollider2D>();
        rad.radius = 1.86f;//初期状態のコライダーのradius
        enemySield[0] = transform.FindChild("BossEnemy2").gameObject;
        enemySield[1] = transform.FindChild("BossEnemy3").gameObject;
        enemySield[2] = transform.FindChild("BossEnemy4").gameObject;
		cirSwi.CSwitch ();
        speedAccessScript = this.GetComponent<lookat2D>();
        myAnim = this.GetComponent<Animator>();
        deadSwitch = false;
        bgm.SetBOSSBGM();

    }

    public void setHP() {//HPに応じてコライダー２Dの範囲を減らしていく
        Hp--;
        if (Hp == 0) {
            rs.setEnd();
            Destroy(this.gameObject,5f);
            Debug.Log("PlayerHit");
            speedAccessScript.setSpeed();
            rad.radius = 0.01f;
            deathAnim();
            bgm.SetNormalBGM();
            SoundManager.Instance.PlayVoice(0);
			clear = true;
            
        }else if (Hp == 2) {
            Destroy(enemySield[0].gameObject);
            rad.radius = 0.65f;
        }else if(Hp == 5){
            Destroy(enemySield[1].gameObject);
            rad.radius = 1.02f;
        }else if(Hp == 8){
            Destroy(enemySield[2].gameObject);
            rad.radius = 1.28f;
        }
    }

	//ボス撃破でCSwitch起動
	void OnDestroy(){
		if (level == spawns.enemy.Length-1 && clear == true) {
			rs.congratulations ();
		}else{
			rs.change();
		}

	}
    void deathAnim() {
        myAnim.SetBool("dead", true);
        cirSwi.CSwitch();
    }

    void Update() {
        
        if (Hp < 1) {
            ExproAnimCount++;
            if (ExproAnimCount >= 5) {
                float rnd1 = Random.Range(-1.3f,1.3f);
                float rnd2 = Random.Range(-1.3f, 1.3f);

                Instantiate(explosion,new Vector3(//インスタンス生成をするオブジェクトをある程度散らす。
                    this.transform.localPosition.x+rnd1,
                    this.transform.localPosition.y+rnd2,
                    0),Quaternion.identity);

                ExproAnimCount = 0;
            }
        }
    }

}
