using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]

public class Attack : MonoBehaviour
{
    [SerializeField] float speed = 4f;

    private Animator animator;

    Transform cam;

    Rigidbody rb;
    CapsuleCollider caps;

    //列挙型、Actionの部分は自分で名前つける
    enum Action
    {
        Move,
        Attack,
        Damage,
        Kick
    }

    //列挙型の名前を型にして変数を宣言する
    [SerializeField] Action action = Action.Move;

    //攻撃判定のオブジェクトを入れる
    [SerializeField]GameObject attackObj;
    [SerializeField]GameObject kickObj;

    void Start()
    {
        animator = GetComponent<Animator>();

        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        cam = Camera.main.transform;

        caps = GetComponent<CapsuleCollider>();
        // caps.center = new Vector3(0, 0.76f, 0);
        // caps.radius = 0.23f;
        // caps.height = 1.6f;

        //攻撃判定のオブジェクトをしまっておく
        attackObj.SetActive(false);
        kickObj.SetActive(false);
    }

    void Update()
    {
        //Action.Moveの時だけ移動できるようにする
        if (action == Action.Move)
        {
            float x = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;

            float z = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

            // animator.SetFloat("X", x * 50);
            // animator.SetFloat("Y", z * 50);

            if (z > 0)
            {
                // transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.x,
                //         cam.eulerAngles.y, transform.rotation.z));
            }
            else if (z < 0)
            {
                // z = z / 1.5f;
            }

            // transform.position += transform.forward * z + transform.right * x;

            //マウスの左クリックでAction.Attackに変更する
            if (Input.GetMouseButtonDown(0))
            {
                action = Action.Attack;
            }
        }
        //Action.Attackの時だけ攻撃をする
        else if (action == Action.Attack)
        {
            //パンチのアニメーションを出す
            animator.SetBool("Attack", true);
            //攻撃判定のオブジェクトを出す
            attackObj.SetActive(true);

            if (Input.GetMouseButtonDown(0))
            {
                action = Action.Kick;
            }

            if (action == Action.Kick)
            {
                animator.SetBool("Kick", true);
                kickObj.SetActive(true);
            }
            else if(action == Action.Damage)
            {
                animator.SetBool("Damage", true);
            }

               
        } 
        //Action.Damageの時だけダメージのアニメーションを出す
        else if (action == Action.Damage)
        {
            animator.SetBool("Damage", true);
        }
    }

    //TagがEenmyAttackのオブジェクトに当たるとAction.Damageになる
    //Action.Damageの時に当たるとreturnでそれ以降何も起きない
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyAttack")
        {
            if (action == Action.Damage)
            {
                return;
            }
            else
            {
                action = Action.Damage;
            }
        }
    }

    //POSE30のアニメーションイベントで呼ばれる
    //Invokeで指定した秒数の後にAttackEndAnimが呼ばれる
    public void AttackEnd()
    {
        Invoke("AttackEndAnim", 0.7f);
    }

    //Action.Moveに戻す
    //パンチアニメーションから移動アニメーションへ
    //攻撃判定のオブジェクトをしまう
    void AttackEndAnim()
    {
        if (action == Action.Kick)
        {
            action = Action.Move;
            animator.SetBool("Attack", false);
            animator.SetBool("Kick", false);
            attackObj.SetActive(false);
        }
        else
        {
            action = Action.Move;
            animator.SetBool("Attack", false);
            attackObj.SetActive(false);
        }
    }

    //DAMAGED00のアニメーションイベントで呼ばれる
    //Action.Moveに戻す
    //ダメージアニメーションから移動アニメーションへ
    void DamageEnd()
    {
        action = Action.Move;
        animator.SetBool("Damage", false);
    }
}