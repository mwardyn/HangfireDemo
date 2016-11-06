using System;
using System.Threading;

namespace HangfireJobs
{
    public class FailingJob
    {
        public void RunJob()
        {
            Thread.Sleep(4000);
            throw new InvalidOperationException("This job will never succeed.");
        }
    }
}
