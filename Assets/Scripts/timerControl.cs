using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerControl {

    /// <summary>
    /// 経過時間
    /// </summary>
    public float CurrentTime
    {
        get;
        private set;
    }

    /// <summary>
    /// 残り時間
    /// </summary>
    public float RemainingTime
    {
        get
        {
            return LimitTime - CurrentTime;
        }
        private set { }
    }

    /// <summary>
    /// 停止時間
    /// </summary>
    public float LimitTime
    {
        get;
        set;
    }

    /// <summary>
    /// 停止時間到達時に発火
    /// </summary>
    public Delegate.VoidDelegate LimitDelegate
    {
        get;
        set;
    }

    bool isEnable = true;
    public bool IsEnable
    {
        get
        {
            return isEnable;
        }
        set
        {
            isEnable = value;
            if(!value)
            {
                CurrentTime = 0;
            }
        }
    }

    public bool Update()
    {
        if (IsEnable)
        {
            CurrentTime += Time.deltaTime;
            if(CurrentTime >= LimitTime)
            {
                CurrentTime = 0;
                if(LimitDelegate != null)
                {
                    LimitDelegate();
                }
                return true;
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}
