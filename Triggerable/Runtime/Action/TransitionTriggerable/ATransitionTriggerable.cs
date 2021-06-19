using System;
using System.Collections;
using UnityEngine;

namespace com.rikoo.triggerable.Triggerable.Runtime.Action.TransitionTriggerable
{
    public abstract class ATransitionTriggerable : ATriggerableMonobehaviour
    {
        [SerializeField] private AnimationCurve m_TransitionCurve;
        [SerializeField] private float m_Duration;
        private float m_InverseDuration;

        private void Awake()
        {
            InitVariables();
        }

        private void InitVariables()
        {
            m_InverseDuration = m_Duration == 0.0f ? 1 : 1 / m_Duration;
        }

        private float m_CurrentDuration = 0.0f;
        private Coroutine m_CurrentActionCoroutine;

        public override void OnTriggerOn()
        {
            StopCurrentCoroutineIfPossible();
            StartCoroutine(TransitionCoroutine(false));
        }

        public override void OnTriggerDown()
        {
            StopCurrentCoroutineIfPossible();
            StartCoroutine(TransitionCoroutine(true));
        }

        private void StopCurrentCoroutineIfPossible()
        {
            if (m_CurrentActionCoroutine != null)
            {
                StopCoroutine(m_CurrentActionCoroutine);
            }
        }

        private IEnumerator TransitionCoroutine(bool _isReversed)
        {
            if (_isReversed)
            {
                return TransitionCoroutine(-1, value => value > 0, 0f);
            }
            else
            {
                return TransitionCoroutine(1, value => value < m_Duration, m_Duration);
            }
        }

        private IEnumerator TransitionCoroutine(float _direction, Func<float, bool> _breakCondition, float _endValue)
        {
            float transitionValue;
            while (_breakCondition(m_CurrentDuration))
            {
                yield return null;
                m_CurrentDuration += Time.deltaTime * _direction;
                transitionValue = EvaluateCurrentDuration();
                OnTransitionValueChanged(transitionValue);
            }
            m_CurrentDuration = _endValue;
            transitionValue = EvaluateCurrentDuration();
            OnTransitionValueChanged(transitionValue);
        }

        private float EvaluateCurrentDuration()
        {
            return m_TransitionCurve.Evaluate(m_CurrentDuration * m_InverseDuration);
        }
        
        protected abstract void OnTransitionValueChanged(float _transitionValue);
    }
}