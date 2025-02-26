﻿namespace ChatServer.Serializers
{
    public class DirectMessage
    {
        public string Receiver { get; set; }

        public string Name { get; set; }

        public string Message { get; set; }

        public DirectMessage() { }

        public DirectMessage(string receiver, string name, string message)
        {
            Receiver = receiver;
            Name = name;
            Message = message;
        }
        public override bool Equals(object obj)
        {
            if (obj is not DirectMessage directMessage)
            {
                return false;
            }

            return directMessage.Receiver == Receiver && directMessage.Name == Name && directMessage.Message == Message;
        }
    }
}
