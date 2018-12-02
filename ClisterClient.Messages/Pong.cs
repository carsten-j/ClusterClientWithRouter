﻿using Akka.Actor;

namespace ClisterClient.Messages
{
    public class Pong
    {
        public Pong(string rsp, Address replyAddr)
        {
            Rsp = rsp;
            ReplyAddr = replyAddr;
        }

        public string Rsp { get; }
        public Address ReplyAddr { get; }
    }
}