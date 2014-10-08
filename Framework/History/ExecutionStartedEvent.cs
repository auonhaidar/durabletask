﻿//  ----------------------------------------------------------------------------------
//  Copyright Microsoft Corporation
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//  http://www.apache.org/licenses/LICENSE-2.0
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  ----------------------------------------------------------------------------------

namespace DurableTask.History
{
    using System.Runtime.Serialization;

    [DataContract]
    internal class ExecutionStartedEvent : HistoryEvent
    {
        [DataMember] public OrchestrationInstance OrchestrationInstance;

        public ExecutionStartedEvent(int eventId, string input)
            : base(eventId)
        {
            Input = input;
        }

        public override EventType EventType
        {
            get { return EventType.ExecutionStarted; }
        }

        [DataMember]
        public ParentInstance ParentInstance { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Version { get; set; }

        [DataMember]
        public string Input { get; set; }

        [DataMember]
        public string Tags { get; set; }
    }
}