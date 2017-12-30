﻿using TDL.Client.Queue.Abstractions;
using TDL.Client.Queue.Abstractions.Response;
using TDL.Client.Queue.Transport;
using TDL.Client.Utils;

namespace TDL.Client.Queue.Actions
{
    public class StopAction : IClientAction
    {
        public string AuditText { get; } = "(NOT PUBLISHED)";

        public void AfterResponse(RemoteBroker remoteBroker, Request request, IResponse response)
        {
        }

        public Maybe<Request> GetNextRequest(RemoteBroker remoteBroker) => Maybe<Request>.None;
    }
}