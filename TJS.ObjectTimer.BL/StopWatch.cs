namespace TJS.ObjectTimer.BL
{
    public class StopWatch
    {
        //returns elapsed time if the clock is running and the last end time if it's not
        public string ElapsedTime
        {
            get 
            {
                if (isRunning) return (DateTime.Now - startTime).ToString(@"hh\:mm\:ss");
                else return (endTime - startTime).ToString(@"hh\:mm\:ss");
            }
        }
     
        private DateTime startTime;
        private DateTime endTime;
        private bool isRunning;
        private int splitNumber;

        //starts the clock if it isn't running
        public void StartClock()
        {
            splitNumber = 0;
            if (!isRunning)
            {
                startTime = DateTime.Now;
                isRunning = true;
            }
            else throw new StartException();
        }
        //returns a split time string if the clock is running
        public string newSplit()
        {
            if (isRunning) 
            {
                splitNumber++;
                return splitNumber + ": " + ElapsedTime;
            }
            else throw new SplitException();
            
        }
        //stops the clock if it's running
        public void StopClock()
        {
            if (isRunning)
            {
                endTime = DateTime.Now;
                isRunning = false;
            } else throw new StopException();
        }

        public class StartException : Exception
        {
            public StartException() : base("Clock already running")
            {
            }
        }
        public class StopException : Exception
        {
            public StopException() : base("Clock already stopped")
            {
            }
        }
        public class SplitException : Exception
        {
            public SplitException() : base("Clock isn't running")
            { }
        }

    }
}
