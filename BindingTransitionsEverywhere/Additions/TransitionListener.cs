using System;

namespace Com.Transitionseverywhere
{
    public class TransitionListener : Java.Lang.Object, Transition.ITransitionListener
    {
        public Action EndAction { get; set; }
        public Action StartAction { get; set; }
        public Action CancelAction { get; set; }
        public Action PauseAction { get; set; }
        public Action ResumeAction { get; set; }

        public void OnTransitionEnd(Transition transition)
        {
            EndAction?.Invoke();
        }

        public void OnTransitionStart(Transition transition)
        {
            StartAction?.Invoke();
        }

        public void OnTransitionCancel(Transition p0)
        {
            CancelAction?.Invoke();
        }

        public void OnTransitionPause(Transition p0)
        {
            PauseAction?.Invoke();
        }

        public void OnTransitionResume(Transition p0)
        {
            ResumeAction?.Invoke();
        }
    }
}
