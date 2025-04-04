﻿using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using TDL.Client.Queue.Abstractions;

namespace TDL.Client.Queue
{
    public partial class ProcessingRules
    {
        public class Builder
        {
            private readonly ProcessingRules processingRules;
            private readonly string methodName;

            private Func<List<ParamAccessor>, object>? userImplementation;

            public Builder(string methodName, ProcessingRules processingRules)
            {
                this.methodName = methodName;
                this.processingRules = processingRules;
            }

            public Builder Call(Func<List<ParamAccessor>, object> userImplementation)
            {
                this.userImplementation = userImplementation;
                return this;
            }

            public void Build()
            {
                if (userImplementation is not null) 
                {
                    processingRules.Add(methodName, userImplementation);
                }
            }
        }
    }
}
