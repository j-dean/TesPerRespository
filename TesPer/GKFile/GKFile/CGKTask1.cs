using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace GKForm
{
	public enum _eFSMTaskState
	{
		Error    = -1,
		None	 = 0,
		Success  = 1,
		Complete = 2
	}

	public enum _eFSMState
	{
		Unstart = 0,
		Running = 1,
		Stop	= 2
	}

	public class CGKTask
	{
		private Thread				m_ThreadStageAlign  = null;
		private ManualResetEvent	m_mreScreenPause    = null;
		private int					nSequence           = 0;
		private int					m_nBaseThreadSleep  = 100;
		private _eFSMState			m_eFSMState			= _eFSMState.Unstart;

		public _eFSMState FSMState
		{
			get { return m_eFSMState; }
		}
		
		public CGKTask(ThreadStart dleThreadFunc , int nBaseThreadSleep)
        {
            m_ThreadStageAlign = new Thread(dleThreadFunc);
            m_mreScreenPause = new ManualResetEvent(false);
            m_nBaseThreadSleep = nBaseThreadSleep;
        }

	
		public void SetProcess(ThreadStart dleThreadFunc)
		{
			m_ThreadStageAlign = new Thread(dleThreadFunc);
			m_mreScreenPause = new ManualResetEvent(false);
		}

		public void Close()
		{
			m_ThreadStageAlign.Abort();
			m_mreScreenPause.Reset();
		}

		public void Start()
		{
			if (m_eFSMState != _eFSMState.Running)
			{
				m_mreScreenPause.Set();

				if (!m_ThreadStageAlign.IsAlive)
				{
					m_eFSMState = _eFSMState.Running;
					m_ThreadStageAlign.Start();
				}
			}
		}

		public int GetSqn()
		{
			Thread.Sleep(m_nBaseThreadSleep);

			return nSequence;
		}

		public void GoNextSqn()
		{
			nSequence++;
		}

		public void GoNextSqn(int nSqn)
		{
			nSequence = nSqn;
		}

		public void EndSqn()
		{
			m_eFSMState = _eFSMState.Stop;
			nSequence = 0;
			m_mreScreenPause.Reset();
		}

		public bool GetWaitOne()
		{
			return m_mreScreenPause.WaitOne();
		}


	}
}
