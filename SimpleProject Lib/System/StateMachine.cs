using System.Threading;

namespace SimpleProject
{
    public abstract class StateMachine
    {
        private Thread main_thread;
        protected volatile bool is_exit;
        protected StateMachine()
        {
            is_exit = false;
            main_thread = new Thread(Go);
        }
        public void Start()
        {
            if (main_thread != null)
            {
                main_thread.Start();
            }
        }
        public void Close()
        {
            is_exit = true;
            main_thread.Join();
            main_thread = null;
        }
        public void Stop()
        {
            is_exit = true;
        }
        //main_thread
        protected abstract bool Init();
        protected abstract void Deinit();
        protected abstract bool DoAnytghing();
        private void Go()
        {
            bool is_ok;
            is_ok = Init();
            while (is_ok && !is_exit)
            {
                is_ok = DoAnytghing();
            }
            Deinit();
        }
    }
}
