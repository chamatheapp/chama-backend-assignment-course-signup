using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Chama.Infrastructure.Messaging.Interfaces;

namespace Chama.Domain
{
    public class Entity
    {
        protected Entity()
        {
            UncommittedCommands = new List<ICommand>();
            UncommittedEvents = new List<IEvent>();
        }
        
        [JsonIgnore] public List<IEvent> UncommittedEvents { get; set; }

        [JsonIgnore] public List<ICommand> UncommittedCommands { get; set; }
        
        public void RaiseEvent(IEvent @event)
        {
            UncommittedEvents.Add(@event);
        }

        public void SendCommand(ICommand @command)
        {
            UncommittedCommands.Add(@command);
        }

        public void ClearUncommittedMessages()
        {
            UncommittedCommands.Clear();
            UncommittedEvents.Clear();
        }
    }
}