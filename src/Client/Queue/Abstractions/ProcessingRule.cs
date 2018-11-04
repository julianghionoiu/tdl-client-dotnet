using System;

namespace TDL.Client.Queue.Abstractions
{
    public class ProcessingRule
    {
        public Func<string[], object> UserImplementation { get; }

        public ProcessingRule(
            Func<string[], object> userImplementation)
        {
            UserImplementation = userImplementation;
        }
    }
}
